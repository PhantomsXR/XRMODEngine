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
using System.Collections;
using System.Collections.Generic;
using Fusion;
using Fusion.Sockets;
using UnityEngine;
using UnityEngine.Events;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    [RequireComponent(typeof(NetworkObject))]
    public class XRMODNetworkBehaviour : NetworkBehaviour, INetworkRunnerCallbacks
    {
        public UnityEvent FixedUpdateNetworkEvent;
        public UnityEvent SpawnedEvent;
        public UnityEvent<NetworkRunner, bool> DespawnedEvent;
        public UnityEvent RenderEvent;

        public int GetTick => Runner.Tick;
        public Single GetDeltaTime => Runner.DeltaTime;
        public bool GetStateAuthority => HasStateAuthority;
        public bool GetInputAuthority => HasInputAuthority;

        #region NetworkRunnerCallbacks

        public UnityEvent<NetworkRunner, NetworkObject, PlayerRef> OnObjectExitAOIEvent;
        public UnityEvent<NetworkRunner, NetworkObject, PlayerRef> OnObjectEnterAOIEvent;
        public UnityEvent<NetworkRunner, PlayerRef> OnPlayerJoinedEvent;
        public UnityEvent<NetworkRunner, PlayerRef> OnPlayerLeftEvent;
        public UnityEvent<NetworkRunner, NetworkInput> OnInputEvent;
        public UnityEvent<NetworkRunner, PlayerRef, NetworkInput> OnInputMissingEvent;
        public UnityEvent<NetworkRunner, ShutdownReason> OnShutdownEvent;
        public UnityEvent<NetworkRunner> OnConnectedToServerEvent;
        public UnityEvent<NetworkRunner, NetDisconnectReason> OnDisconnectedFromServerEvent;
        public UnityEvent<NetworkRunner, NetworkRunnerCallbackArgs.ConnectRequest, byte[]> OnConnectRequestEvent;
        public UnityEvent<NetworkRunner> OnSceneLoadStartEvent;
        public UnityEvent<NetworkRunner> OnSceneLoadDoneEvent;
        public UnityEvent<NetworkRunner, PlayerRef, ReliableKey, float> OnReliableDataProgressEvent;
        public UnityEvent<NetworkRunner, HostMigrationToken> OnHostMigrationEvent;
        public UnityEvent<NetworkRunner, PlayerRef, ReliableKey, ArraySegment<byte>> OnReliableDataReceivedEvent;
        public UnityEvent<NetworkRunner, Dictionary<string, object>> OnCustomAuthenticationResponseEvent;
        public UnityEvent<NetworkRunner, List<SessionInfo>> OnSessionListUpdatedEvent;
        public UnityEvent<NetworkRunner, SimulationMessagePtr> OnUserSimulationMessageEvent;
        public UnityEvent<NetworkRunner, NetAddress, NetConnectFailedReason> OnConnectFailedEvent;

        #endregion

        private readonly Dictionary<string, Action<string, RpcInfo>> methods = new();
        private readonly Dictionary<string, BaseFusionType> fusionTypes = new();

        private void Awake()
        {
            var tmp_AllFusionTypes = GetComponents<BaseFusionType>();
            foreach (BaseFusionType tmp_FusionType in tmp_AllFusionTypes)
            {
                fusionTypes.TryAdd(tmp_FusionType.Key, tmp_FusionType);
            }
        }

        #region Fusion LifeCycle

        public override void FixedUpdateNetwork()
        {
            base.FixedUpdateNetwork();
            FixedUpdateNetworkEvent?.Invoke();
        }

        public override void Despawned(NetworkRunner _runner, bool _hasState)
        {
            base.Despawned(_runner, _hasState);
            DespawnedEvent?.Invoke(_runner, _hasState);
        }

        public override void Spawned()
        {
            base.Spawned();
            // Technically, it does not really matter which InputController fills the input structure,
            // since the actual data will only be sent to the one that does have authority,
            // but in the name of clarity, let's make sure we give input control to the gameobject that also has Input authority.
            Runner.AddCallbacks(this);
            SpawnedEvent?.Invoke();
        }

        public override void Render()
        {
            base.Render();
            RenderEvent?.Invoke();
        }

        #endregion


        #region RPC Trigger

        [Rpc(RpcSources.StateAuthority, RpcTargets.StateAuthority)]
        public void RPC_SendStateAuthority(string _key, string _data, RpcInfo _info = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _info);
            }
        }

        [Rpc(RpcSources.StateAuthority, RpcTargets.InputAuthority)]
        public void RPC_SendStateAuthorityForInputAuthority(string _key, string _data, RpcInfo _info = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _info);
            }
        }

        [Rpc(RpcSources.StateAuthority, RpcTargets.All)]
        public void RPC_SendStateAuthorityForAll(string _key, string _data, RpcInfo _info = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _info);
            }
        }

        [Rpc(RpcSources.All, RpcTargets.All)]
        public void RPC_SendAll(string _key, string _data, RpcInfo _info = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _info);
            }
        }

        [Rpc(RpcSources.All, RpcTargets.InputAuthority)]
        public void RPC_SendAllForInputAuthority(string _key, string _data, RpcInfo _info = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _info);
            }
        }

        [Rpc(RpcSources.All, RpcTargets.StateAuthority)]
        public void RPC_SendAllForStateAuthority(string _key, string _data, RpcInfo _info = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _info);
            }
        }

        [Rpc(RpcSources.InputAuthority, RpcTargets.InputAuthority)]
        public void RPC_SendInputAuthority(string _key, string _data, RpcInfo _info = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _info);
            }
        }

        [Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority)]
        public void RPC_SendInputStateAuthority(string _key, string _data, RpcInfo _info = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _info);
            }
        }

        [Rpc(RpcSources.InputAuthority, RpcTargets.All)]
        public void RPC_SendInputAuthorityForAll(string _key, string _data, RpcInfo _info = default)
        {
            if (methods.TryGetValue(_key, out var tmp_Action))
            {
                tmp_Action?.Invoke(_data, _info);
            }
        }

        #endregion

        /// <summary>
        /// Register an action method to Rpc dictionary
        /// </summary>
        /// <param name="_key">Action method name</param>
        /// <param name="_action"></param>
        public void RegisterRpcMethods(string _key, Action<string, RpcInfo> _action)
        {
            methods.TryAdd(_key, _action);
        }

        /// <summary>
        /// Get Fusion type via Key
        /// </summary>
        /// <param name="_key">Key of fusion type component</param>
        /// <param name="_fusionType">The <see cref="BaseFusionType"/> component</param>
        /// <typeparam name="T">The fusion type component</typeparam>
        /// <returns></returns>
        public bool TryGetFusionType<T>(string _key, out T _fusionType) where T : BaseFusionType
        {
            bool tmp_Got = fusionTypes.TryGetValue(_key, out var tmp_Value);
            if (tmp_Got)
                _fusionType = tmp_Value as T;
            else
                _fusionType = null;
            return tmp_Got;
        }


        internal bool TryGetFusionType(string _key, out BaseFusionType _fusionType)
        {
            bool tmp_Got = fusionTypes.TryGetValue(_key, out var tmp_Value);
            if (tmp_Got)
                _fusionType = tmp_Value;
            else
                _fusionType = null;
            return tmp_Got;
        }

        public void OnObjectExitAOI(NetworkRunner _runner, NetworkObject _obj, PlayerRef _player)
        {
            OnObjectExitAOIEvent?.Invoke(_runner, _obj, _player);
        }

        public void OnObjectEnterAOI(NetworkRunner _runner, NetworkObject _obj, PlayerRef _player)
        {
            OnObjectEnterAOIEvent?.Invoke(_runner, _obj, _player);
        }

        public void OnPlayerJoined(NetworkRunner _runner, PlayerRef _player)
        {
            OnPlayerJoinedEvent?.Invoke(_runner, _player);
        }

        public void OnPlayerLeft(NetworkRunner _runner, PlayerRef _player)
        {
            OnPlayerLeftEvent?.Invoke(_runner, _player);
        }

        public void OnInput(NetworkRunner _runner, NetworkInput _input)
        {
            if (!HasInputAuthority) return;
            OnInputEvent?.Invoke(_runner, _input);
        }

        public void OnInputMissing(NetworkRunner _runner, PlayerRef _player, NetworkInput _input)
        {
            OnInputMissingEvent?.Invoke(_runner, _player, _input);
        }

        public void OnShutdown(NetworkRunner _runner, ShutdownReason _shutdownReason)
        {
            OnShutdownEvent?.Invoke(_runner, _shutdownReason);
        }

        public void OnConnectedToServer(NetworkRunner _runner)
        {
            OnConnectedToServerEvent?.Invoke(_runner);
        }

        public void OnDisconnectedFromServer(NetworkRunner _runner, NetDisconnectReason _reason)
        {
            OnDisconnectedFromServerEvent?.Invoke(_runner, _reason);

            RenderEvent.RemoveAllListeners();
            DespawnedEvent.RemoveAllListeners();
            FixedUpdateNetworkEvent.RemoveAllListeners();
            SpawnedEvent.RemoveAllListeners();
            OnObjectExitAOIEvent.RemoveAllListeners();
            OnObjectEnterAOIEvent.RemoveAllListeners();
            OnPlayerJoinedEvent.RemoveAllListeners();
            OnPlayerLeftEvent.RemoveAllListeners();
            OnInputEvent.RemoveAllListeners();
            OnInputMissingEvent.RemoveAllListeners();
            OnShutdownEvent.RemoveAllListeners();
            OnConnectedToServerEvent.RemoveAllListeners();
            OnConnectRequestEvent.RemoveAllListeners();
            OnSceneLoadStartEvent.RemoveAllListeners();
            OnSceneLoadDoneEvent.RemoveAllListeners();
            OnReliableDataProgressEvent.RemoveAllListeners();
            OnHostMigrationEvent.RemoveAllListeners();
            OnReliableDataReceivedEvent.RemoveAllListeners();
            OnCustomAuthenticationResponseEvent.RemoveAllListeners();
            OnSessionListUpdatedEvent.RemoveAllListeners();
            OnUserSimulationMessageEvent.RemoveAllListeners();
            OnConnectFailedEvent.RemoveAllListeners();
            OnDisconnectedFromServerEvent.RemoveAllListeners();
        }

        public void OnConnectRequest(NetworkRunner _runner, NetworkRunnerCallbackArgs.ConnectRequest _request,
            byte[] _token)
        {
            OnConnectRequestEvent?.Invoke(_runner, _request, _token);
        }

        public void OnConnectFailed(NetworkRunner _runner, NetAddress _remoteAddress, NetConnectFailedReason _reason)
        {
            OnConnectFailedEvent?.Invoke(_runner, _remoteAddress, _reason);
        }

        public void OnUserSimulationMessage(NetworkRunner _runner, SimulationMessagePtr _message)
        {
            OnUserSimulationMessageEvent?.Invoke(_runner, _message);
        }

        public void OnSessionListUpdated(NetworkRunner _runner, List<SessionInfo> _sessionList)
        {
            OnSessionListUpdatedEvent?.Invoke(_runner, _sessionList);
        }

        public void OnCustomAuthenticationResponse(NetworkRunner _runner, Dictionary<string, object> _data)
        {
            OnCustomAuthenticationResponseEvent?.Invoke(_runner, _data);
        }

        public void OnHostMigration(NetworkRunner _runner, HostMigrationToken _hostMigrationToken)
        {
            OnHostMigrationEvent?.Invoke(_runner, _hostMigrationToken);
        }

        public void OnReliableDataReceived(NetworkRunner _runner, PlayerRef _player, ReliableKey _key,
            ArraySegment<byte> _data)
        {
            OnReliableDataReceivedEvent?.Invoke(_runner, _player, _key, _data);
        }

        public void OnReliableDataProgress(NetworkRunner _runner, PlayerRef _player, ReliableKey _key, float _progress)
        {
            OnReliableDataProgressEvent?.Invoke(_runner, _player, _key, _progress);
        }

        public void OnSceneLoadDone(NetworkRunner _runner)
        {
            OnSceneLoadDoneEvent?.Invoke(_runner);
        }

        public void OnSceneLoadStart(NetworkRunner _runner)
        {
            OnSceneLoadStartEvent?.Invoke(_runner);
        }
    }
}
#endif