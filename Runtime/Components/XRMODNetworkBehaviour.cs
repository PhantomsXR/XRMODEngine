// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// Extended NetworkBehaviour base class for XRMOD that provides UnityEvent-based callbacks and dynamic RPC registration.
    /// </summary>
    /// <remarks>
    /// This class wraps Unity Netcode callbacks with UnityEvents, making them accessible in the Inspector and allowing runtime subscription.
    /// It also supports registering network variables by key and invoking RPCs via string-based lookups.
    /// </remarks>
    [RequireComponent(typeof(NetworkObject))]
    public class XRMODNetworkBehaviour : NetworkBehaviour
    {
        /// <summary>
        /// Event triggered when deferring despawn.
        /// </summary>
        [HideInInspector] public UnityEvent<int> OnDeferringDespawnEvent = new();
        
        /// <summary>
        /// Event triggered when the network object is despawned.
        /// </summary>
        [HideInInspector] public UnityEvent OnNetworkDespawnEvent = new();
        
        /// <summary>
        /// Event triggered when the object is destroyed.
        /// </summary>
        [HideInInspector] public UnityEvent OnDestroyEvent = new();
        
        /// <summary>
        /// Event triggered when this object gains ownership.
        /// </summary>
        [HideInInspector] public UnityEvent OnGainedOwnershipEvent = new();
        
        /// <summary>
        /// Event triggered when in-scene objects have spawned.
        /// </summary>
        [HideInInspector] public UnityEvent OnInSceneObjectsSpawnedEvent = new();
        
        /// <summary>
        /// Event triggered when this object loses ownership.
        /// </summary>
        [HideInInspector] public UnityEvent OnLostOwnershipEvent = new();


        /// <summary>
        /// Gets called after the <see cref="NetworkObject"/> is spawned. All NetworkBehaviours associated with the NetworkObject will have had <see cref="OnNetworkSpawn"/> invoked.
        /// </summary>
        /// <remarks>
        /// Will be invoked on each <see cref="NetworkBehaviour"/> associated with the <see cref="NetworkObject"/> being spawned.
        /// All associated <see cref="NetworkBehaviour"/> components will have had <see cref="OnNetworkSpawn"/> invoked on the spawned <see cref="NetworkObject"/>.
        /// </remarks>
        [HideInInspector] public UnityEvent OnNetworkPostSpawnEvent = new();

        /// <summary>
        /// Gets called after the <see cref="NetworkObject"/> is spawned. No NetworkBehaviours associated with the NetworkObject will have had <see cref="OnNetworkSpawn"/> invoked yet.
        /// A reference to <see cref="NetworkManager"/> is passed in as a parameter to determine the context of execution (`IsServer` or `IsClient`).
        /// </summary>
        /// <param name="networkManager">a ref to the <see cref="NetworkManager"/> since this is not yet set on the <see cref="NetworkBehaviour"/></param>
        /// <remarks>
        /// The <see cref="NetworkBehaviour"/> will not have anything assigned to it at this point in time.
        /// Settings like ownership, NetworkBehaviourId, NetworkManager, and most other spawn-related properties will not be set.
        /// This can be used to handle things like initializing a NetworkVariable.
        /// </remarks>
        [HideInInspector] public UnityEvent<NetworkManager> OnNetworkPreSpawnEvent = new();


        /// <summary>
        /// Event triggered when the network object's parent changes.
        /// </summary>
        [HideInInspector] public UnityEvent<NetworkObject> OnNetworkObjectParentChangedEvent = new();
        
        /// <summary>
        /// Event triggered when the network session is synchronized.
        /// </summary>
        [HideInInspector] public UnityEvent OnNetworkSessionSynchronizedEvent = new();
        
        /// <summary>
        /// Event triggered when ownership changes (previous owner, new owner).
        /// </summary>
        [HideInInspector] public UnityEvent<ulong, ulong> OnOwnershipChangedEvent = new();
        
        /// <summary>
        /// Event triggered on reanticipation (for network prediction).
        /// </summary>
        [HideInInspector] public UnityEvent<double> OnReanticipateEvent = new();

        /// <summary>
        /// Gets called when the <see cref="NetworkObject"/> gets spawned, message handlers are ready to be registered, and the network is set up.
        /// </summary>
        [HideInInspector] public UnityEvent OnNetworkSpawnEvent = new();

        /// <summary>
        /// Unity Update event exposed for network behaviors.
        /// </summary>
        [HideInInspector] public UnityEvent OnUpdate = new();
        
        /// <summary>
        /// Unity FixedUpdate event exposed for network behaviors.
        /// </summary>
        [HideInInspector] public UnityEvent OnFixedUpdate = new();

        private Dictionary<string, BaseNetworkVariable> networkVariableDict = new();

        private readonly Dictionary<string, Action<string, RpcParams>> methods = new();

        private void Awake()
        {
            var tmp_AllNetworkVariable = gameObject.GetComponentsInChildren<BaseNetworkVariable>();
            foreach (BaseNetworkVariable tmp_NetworkVariable in tmp_AllNetworkVariable)
            {
                networkVariableDict.TryAdd(tmp_NetworkVariable.Key, tmp_NetworkVariable);
            }
        }

        /// <summary>
        /// Retrieves a network variable by key.
        /// </summary>
        /// <param name="_key">Key of the network variable component.</param>
        /// <param name="_networkVariable">The <see cref="BaseNetworkVariable"/> component.</param>
        /// <typeparam name="T">The network variable type component.</typeparam>
        /// <returns><c>true</c> if the variable was found, <c>false</c> otherwise.</returns>
        public bool TryGetNetworkVariable<T>(string _key, out T _networkVariable) where T : BaseNetworkVariable
        {
            bool tmp_Got = networkVariableDict.TryGetValue(_key, out var tmp_Value);
            if (tmp_Got)
                _networkVariable = tmp_Value as T;
            else
                _networkVariable = null;
            return tmp_Got;
        }


        /// <summary>
        /// Registers an action method to the RPC dictionary for dynamic invocation.
        /// </summary>
        /// <param name="_key">Unique identifier for the RPC action.</param>
        /// <param name="_action">The action to invoke when the RPC is called.</param>
        public void RegisterRpcMethods(string _key, Action<string, RpcParams> _action)
        {
            methods.TryAdd(_key, _action);
        }


        private void Update()
        {
            OnUpdate?.Invoke();
        }

        private void FixedUpdate()
        {
            OnFixedUpdate?.Invoke();
        }


        #region Callback

        /// <summary>
        /// Called when despawn is deferred.
        /// </summary>
        public override void OnDeferringDespawn(int despawnTick)
        {
            base.OnDeferringDespawn(despawnTick);
            OnDeferringDespawnEvent?.Invoke(despawnTick);
        }

        /// <summary>
        /// Called when the network object is despawned.
        /// </summary>
        public override void OnNetworkDespawn()
        {
            base.OnNetworkDespawn();
            OnNetworkDespawnEvent?.Invoke();
        }

        /// <summary>
        /// Called when the object is destroyed.
        /// </summary>
        public override void OnDestroy()
        {
            base.OnDestroy();
            OnDestroyEvent?.Invoke();
        }

        /// <summary>
        /// Called when this object gains ownership.
        /// </summary>
        public override void OnGainedOwnership()
        {
            base.OnGainedOwnership();
            OnGainedOwnershipEvent?.Invoke();
        }

        /// <summary>
        /// Called after in-scene objects have spawned.
        /// </summary>
        protected override void OnInSceneObjectsSpawned()
        {
            base.OnInSceneObjectsSpawned();
            OnInSceneObjectsSpawnedEvent?.Invoke();
        }

        /// <summary>
        /// Called when this object loses ownership.
        /// </summary>
        public override void OnLostOwnership()
        {
            base.OnLostOwnership();
            OnLostOwnershipEvent?.Invoke();
        }

        /// <summary>
        /// Called when the network object's parent changes.
        /// </summary>
        public override void OnNetworkObjectParentChanged(NetworkObject parentNetworkObject)
        {
            base.OnNetworkObjectParentChanged(parentNetworkObject);
            OnNetworkObjectParentChangedEvent?.Invoke(parentNetworkObject);
        }

        /// <summary>
        /// Called when the network object spawns.
        /// </summary>
        public override void OnNetworkSpawn()
        {
            base.OnNetworkSpawn();
            OnNetworkSpawnEvent?.Invoke();
        }

        /// <summary>
        /// Called after the network object spawns (post-spawn hook).
        /// </summary>
        protected override void OnNetworkPostSpawn()
        {
            base.OnNetworkPostSpawn();
            OnNetworkPostSpawnEvent?.Invoke();
        }


        /// <summary>
        /// Called before the network object spawns (pre-spawn hook).
        /// </summary>
        protected override void OnNetworkPreSpawn(ref NetworkManager networkManager)
        {
            BinderManager.Instance.DoBind(GetComponentsInChildren<MonoBinder>(true).ToList());
            base.OnNetworkPreSpawn(ref networkManager);
            OnNetworkPreSpawnEvent?.Invoke(networkManager);
        }

        /// <summary>
        /// Called when the network session is synchronized.
        /// </summary>
        protected override void OnNetworkSessionSynchronized()
        {
            base.OnNetworkSessionSynchronized();
            OnNetworkSessionSynchronizedEvent?.Invoke();
        }


        /// <summary>
        /// Called when ownership changes.
        /// </summary>
        protected override void OnOwnershipChanged(ulong previous, ulong current)
        {
            base.OnOwnershipChanged(previous, current);
            OnOwnershipChangedEvent?.Invoke(previous, current);
        }

        /// <summary>
        /// Called on reanticipation (for network prediction).
        /// </summary>
        public override void OnReanticipate(double _lastRoundTripTime)
        {
            base.OnReanticipate(_lastRoundTripTime);
            OnReanticipateEvent?.Invoke(_lastRoundTripTime);
        }

        #endregion

        #region Rpcs

        /// <summary>
        /// Sends an RPC to the server.
        /// </summary>
        [Rpc(SendTo.Server)]
        public void SendToServerRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


        /// <summary>
        /// Sends an RPC to the authority.
        /// </summary>
        [Rpc(SendTo.Authority)]
        public void SendToAuthorityRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


        /// <summary>
        /// Sends an RPC to self (the caller).
        /// </summary>
        [Rpc(SendTo.Me)]
        public void SendToMeRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }

        /// <summary>
        /// Sends an RPC to everyone (server and all clients).
        /// </summary>
        [Rpc(SendTo.Everyone)]
        public void SendToEveryoneRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


        /// <summary>
        /// Sends an RPC to the owner.
        /// </summary>
        [Rpc(SendTo.Owner)]
        public void SendToOwnerRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


        /// <summary>
        /// Sends an RPC to everyone except the authority.
        /// </summary>
        [Rpc(SendTo.NotAuthority)]
        public void SendToNotAuthorityRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }

        /// <summary>
        /// Sends an RPC to everyone except self.
        /// </summary>
        [Rpc(SendTo.NotMe)]
        public void SendToNotMeRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


        /// <summary>
        /// Sends an RPC to everyone except the owner.
        /// </summary>
        [Rpc(SendTo.NotOwner)]
        public void SendToNotOwnerRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }

        /// <summary>
        /// Sends an RPC to everyone except the server.
        /// </summary>
        [Rpc(SendTo.NotServer)]
        public void SendToNotServerRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


        /// <summary>
        /// Sends an RPC to all clients and the host.
        /// </summary>
        [Rpc(SendTo.ClientsAndHost)]
        public void SendToClientsAndHostRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


        /// <summary>
        /// Sends an RPC to targets specified in the RpcParams.
        /// </summary>
        [Rpc(SendTo.SpecifiedInParams)]
        void SendToSpecifiedInParamsRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }

        #endregion
    }
}