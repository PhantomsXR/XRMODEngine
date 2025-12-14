// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if FUSION2
using System;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public interface INetworkEvent : INetworkStruct
    {
    }
    
    /// <summary>
    /// The TickAlignedEventRelay is a networked object that gives each peer in shared mode a list
    /// of outgoing events meant for the State Authority of other peers.
    /// 
    /// Each peer will process all lists for all other peers looking for events destined for itself,
    /// and then execute that event.
    /// 
    /// The primary reason to use this over a regular RPC is that it allow synchronous execution of
    /// state changes for multiple State Authorities.
    /// 
    /// For example, in Tanknarok, when peer A fires a bullet on peer B, it is A that detects the collision,
    /// removes the bullet, triggers an explosion FX and decreases ammo count if relevant.
    /// 
    /// However, A cannot alter the visual state of B or reduce its HP since it does not have
    /// StateAuthority over it, so instead it sends an event to tell B to do it.
    /// 
    /// Because the event is part of A's state, it arrives at B in the same tick as the bullet
    /// destruction and the explosion FX, and everything will occur simultaneously as seen from B's perspective.
    /// (Note however that B will probably not be in the same state it was when A registered the event)
    /// 
    /// This is not a silver bullet, and does not generally replace RPCs. Specifically, the
    /// need to pre-allocate the event structure at build-time means there are certain limitations:
    /// 
    /// * You need to have a reasonable limit on the number of events that may be sent per tick
    /// * The event structure uses memory based on the largest possible event you have, so need to keep event size down, or use multiple event relays.
    /// * There's a risk of loosing events because the buffer is cyclic and will re-use slots as soon as they have been sent.
    /// </summary>
    public class TickAlignedEventRelay : NetworkBehaviour
    {
        // Theoretical maximum number of events you'll ever send with each relay in a single tick.
        // In reality this needs to be a couple of times larger than that to avoid loosing events due to package drops.
        const int _CONST_MAX_EVENTS = 10;

        // The maximum size of any event sent with the relay (in bytes).
        const int _CONST_MAX_EVENT_SIZE = 24;

        // Each event has a header which identifies the event and its intended target authority as well as a byte array payload.
        private struct EventHeader : INetworkStruct
        {
            public int ID { get; set; }
            public int Type { get; set; }
            public NetworkId Target { get; set; }
        }

        [Networked, Capacity(_CONST_MAX_EVENTS)] private NetworkArray<EventHeader> EventHeaders => default;

        [Networked, Capacity(_CONST_MAX_EVENTS * _CONST_MAX_EVENT_SIZE)]
        private NetworkArray<byte> EventBuffer => default;

        private int nextEventIndex = 1;
        private int handledEventIndex;

        private unsafe delegate void ITypeWrapper(int _typeIndex, byte* _data);

        private readonly List<Type> registeredTypes = new();
        private readonly List<ITypeWrapper> listeners = new();

        /// <summary>
        /// Register an event listener for a specific type of event. When you call this method a map of event type and type IDs
        /// is built dynamically, so it is crucial that calls to this method for any given relay is always done in the same order
        /// on all peers.
        ///
        /// Preferably, call this only from Spawned() of a single NB, and register all your listeners unconditionally.
        ///
        /// Note that the callback will trigger on both the source of the event (immediately for predictive updates),
        /// as well as on State Authority and proxies. Deal with that how you like.
        /// </summary>
        /// <param name="_listener">The callback that will receive the event</param>
        /// <typeparam name="T">Type of event struct</typeparam>
        public void RegisterEventListener<T>(Action<T> _listener) where T : unmanaged, INetworkEvent
        {
            int tmp_MonitoredTypeIndex = registeredTypes.IndexOf(typeof(T));
            if (tmp_MonitoredTypeIndex < 0)
            {
                tmp_MonitoredTypeIndex = registeredTypes.Count;
                registeredTypes.Add(typeof(T));
            }

            unsafe
            {
                listeners.Add((_typeIndex, _data) =>
                {
                    if (_typeIndex == tmp_MonitoredTypeIndex)
                    {
                        _listener(*(T*) _data);
                    }
                });
            }
        }

        /// <summary>
        /// Send event to be executed on the State Authority of another peer.
        ///
        /// This will trigger on the local peer immediately, regardless of whether it is StateAuthority or not.
        /// </summary>
        /// <param name="_target">A relay owned by the target StateAuthority (May be *this*, but generally isn't) </param>
        /// <param name="_evt">The event struct to send</param>
        /// <typeparam name="T">The type of the event struct</typeparam>
        public void RaiseEventFor<T>(TickAlignedEventRelay _target, T _evt) where T : unmanaged, INetworkEvent
        {
            unsafe
            {
                Assert.Check(sizeof(T) < _CONST_MAX_EVENT_SIZE,
                    $"Event of type {typeof(T)} is larger ({sizeof(T)} bytes) than MAX_EVENT_SIZE ({_CONST_MAX_EVENT_SIZE} bytes)");
            }

            byte[] tmp_Bytes = SerializeValueType(_evt);

            // Predict it locally
            int tmp_TypeIndex = registeredTypes.IndexOf(typeof(T));
            _target.OnTickAlignedEvent(tmp_TypeIndex, tmp_Bytes);

            // Do nothing in hosted mode - we're either authority over everything or nothing at all, nothing more to do here.
            if (Runner == null || Runner.Topology != Topologies.Shared)
                return;

            // If we don't have StateAuthority we're going to have to let SA know so it can change it properly.
            if (!_target.HasStateAuthority)
            {
                EventHeader tmp_Head = new()
                {
                    Target = _target.Object.Id,
                    ID = nextEventIndex,
                    Type = tmp_TypeIndex
                };
                int tmp_Index = nextEventIndex % EventHeaders.Length;
                EventHeaders.Set(tmp_Index, tmp_Head);
                for (int tmp_Idx = 0; tmp_Idx < tmp_Bytes.Length; tmp_Idx++)
                {
                    EventBuffer.Set(tmp_Index * _CONST_MAX_EVENT_SIZE + tmp_Idx, tmp_Bytes[tmp_Idx]);
                }

                nextEventIndex++;
            }
        }

        private unsafe void OnTickAlignedEvent(int _typeIndex, byte[] _evt)
        {
            fixed (byte* tmp_Buffer = _evt)
            {
                foreach (ITypeWrapper tmp_Listener in listeners)
                {
                    tmp_Listener(_typeIndex, tmp_Buffer);
                }
            }
        }

        public override void Render()
        {
            if (HasStateAuthority)
                return; // If we have State Authority then these are our outgoing messages and none of them are for us!

            if (TryGetSnapshotsBuffers(out var tmp_FromBuffer, out _, out _))
            {
                var tmp_HeadersReader = GetArrayReader<EventHeader>(nameof(EventHeaders));
                var tmp_Headers = tmp_HeadersReader.Read(tmp_FromBuffer);
                var tmp_ByteReader = GetArrayReader<byte>(nameof(EventBuffer));
                var tmp_Bytes = tmp_ByteReader.Read(tmp_FromBuffer);
                int tmp_HandledId = handledEventIndex;
                for (int tmp_Idx = 0; tmp_Idx < tmp_Headers.Length; tmp_Idx++)
                {
                    EventHeader tmp_Head = tmp_Headers[tmp_Idx];
                    if (tmp_Head.ID > handledEventIndex)
                    {
                        tmp_HandledId = Mathf.Max(tmp_HandledId, tmp_Head.ID);
                        if (Runner.TryFindObject(tmp_Head.Target, out NetworkObject tmp_No))
                        {
                            TickAlignedEventRelay tmp_Behaviour = tmp_No.GetComponent<TickAlignedEventRelay>();
                            byte[] tmp_Buffer = new byte[_CONST_MAX_EVENT_SIZE];
                            for (int tmp_Bdx = 0; tmp_Bdx < tmp_Buffer.Length; tmp_Bdx++)
                                tmp_Buffer[tmp_Bdx] = tmp_Bytes[tmp_Idx * _CONST_MAX_EVENT_SIZE + tmp_Bdx];
                            tmp_Behaviour.OnTickAlignedEvent(tmp_Head.Type, tmp_Buffer);
                        }
                    }
                }

                handledEventIndex = tmp_HandledId;
            }
        }

        public static unsafe byte[] SerializeValueType<T>(in T _value) where T : unmanaged
        {
            byte[] tmp_Result = new byte[sizeof(T)];
            fixed (byte* tmp_Dst = tmp_Result)
                *(T*) tmp_Dst = _value;
            return tmp_Result;
        }
    }
}
#endif