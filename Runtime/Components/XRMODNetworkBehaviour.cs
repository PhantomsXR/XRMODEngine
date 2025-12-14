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
    [RequireComponent(typeof(NetworkObject))]
    public class XRMODNetworkBehaviour : NetworkBehaviour
    {
        [HideInInspector] public UnityEvent<int> OnDeferringDespawnEvent = new();
        [HideInInspector] public UnityEvent OnNetworkDespawnEvent = new();
        [HideInInspector] public UnityEvent OnDestroyEvent = new();
        [HideInInspector] public UnityEvent OnGainedOwnershipEvent = new();
        [HideInInspector] public UnityEvent OnInSceneObjectsSpawnedEvent = new();
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


        [HideInInspector] public UnityEvent<NetworkObject> OnNetworkObjectParentChangedEvent = new();
        [HideInInspector] public UnityEvent OnNetworkSessionSynchronizedEvent = new();
        [HideInInspector] public UnityEvent<ulong, ulong> OnOwnershipChangedEvent = new();
        [HideInInspector] public UnityEvent<double> OnReanticipateEvent = new();

        /// <summary>
        /// Gets called when the <see cref="NetworkObject"/> gets spawned, message handlers are ready to be registered, and the network is set up.
        /// </summary>
        [HideInInspector] public UnityEvent OnNetworkSpawnEvent = new();

        [HideInInspector] public UnityEvent OnUpdate = new();
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
        /// Get Fusion type via Key
        /// </summary>
        /// <param name="_key">Key of fusion type component</param>
        /// <param name="_networkVariable">The <see cref="BaseNetworkVariable"/> component</param>
        /// <typeparam name="T">The network variable type component</typeparam>
        /// <returns></returns>
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
        /// Register an action method to Rpc dictionary
        /// </summary>
        /// <param name="_key">Action method name</param>
        /// <param name="_action"></param>
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

        public override void OnDeferringDespawn(int despawnTick)
        {
            base.OnDeferringDespawn(despawnTick);
            OnDeferringDespawnEvent?.Invoke(despawnTick);
        }

        public override void OnNetworkDespawn()
        {
            base.OnNetworkDespawn();
            OnNetworkDespawnEvent?.Invoke();
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
            OnDestroyEvent?.Invoke();
        }

        public override void OnGainedOwnership()
        {
            base.OnGainedOwnership();
            OnGainedOwnershipEvent?.Invoke();
        }

        protected override void OnInSceneObjectsSpawned()
        {
            base.OnInSceneObjectsSpawned();
            OnInSceneObjectsSpawnedEvent?.Invoke();
        }

        public override void OnLostOwnership()
        {
            base.OnLostOwnership();
            OnLostOwnershipEvent?.Invoke();
        }

        public override void OnNetworkObjectParentChanged(NetworkObject parentNetworkObject)
        {
            base.OnNetworkObjectParentChanged(parentNetworkObject);
            OnNetworkObjectParentChangedEvent?.Invoke(parentNetworkObject);
        }

        public override void OnNetworkSpawn()
        {
            base.OnNetworkSpawn();
            OnNetworkSpawnEvent?.Invoke();
        }

        protected override void OnNetworkPostSpawn()
        {
            base.OnNetworkPostSpawn();
            OnNetworkPostSpawnEvent?.Invoke();
        }


        protected override void OnNetworkPreSpawn(ref NetworkManager networkManager)
        {
            BinderManager.Instance.DoBind(GetComponentsInChildren<MonoBinder>(true).ToList());
            base.OnNetworkPreSpawn(ref networkManager);
            OnNetworkPreSpawnEvent?.Invoke(networkManager);
        }

        protected override void OnNetworkSessionSynchronized()
        {
            base.OnNetworkSessionSynchronized();
            OnNetworkSessionSynchronizedEvent?.Invoke();
        }


        protected override void OnOwnershipChanged(ulong previous, ulong current)
        {
            base.OnOwnershipChanged(previous, current);
            OnOwnershipChangedEvent?.Invoke(previous, current);
        }

        public override void OnReanticipate(double _lastRoundTripTime)
        {
            base.OnReanticipate(_lastRoundTripTime);
            OnReanticipateEvent?.Invoke(_lastRoundTripTime);
        }

        #endregion

        #region Rpcs

        [Rpc(SendTo.Server)]
        public void SendToServerRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


        [Rpc(SendTo.Authority)]
        public void SendToAuthorityRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


        [Rpc(SendTo.Me)]
        public void SendToMeRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }

        [Rpc(SendTo.Everyone)]
        public void SendToEveryoneRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


        [Rpc(SendTo.Owner)]
        public void SendToOwnerRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


        [Rpc(SendTo.NotAuthority)]
        public void SendToNotAuthorityRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }

        [Rpc(SendTo.NotMe)]
        public void SendToNotMeRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


        [Rpc(SendTo.NotOwner)]
        public void SendToNotOwnerRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }

        [Rpc(SendTo.NotServer)]
        public void SendToNotServerRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


        [Rpc(SendTo.ClientsAndHost)]
        public void SendToClientsAndHostRpc(string _key, string _data, RpcParams _rpcParams = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _rpcParams);
            }
        }


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