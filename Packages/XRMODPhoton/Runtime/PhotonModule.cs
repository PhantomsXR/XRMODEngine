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
using Fusion;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.ActionNotification.Runtime;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public class PhotonModule : SimulationBehaviour, IModule
    {
        private NetworkEvents networkEvents;
        private OnEventFusionInputArgs OnEventFusionInputArgs = new();
        private OnEventFusionShutdownArgs OnEventFusionShutdownArgs = new();
        private OnEventFusionPlayerJoinedArgs OnEventFusionPlayerJoinedArgs = new();
        private OnEventFusionPlayerLeftArgs OnEventFusionPlayerLeftArgs = new();
        private OnEventFusionConnectRequestArgs OnEventFusionConnectRequestArgs = new();
        private OnEventFusionConnectedToServerArgs OnEventFusionConnectedToServerArgs = new();
        private OnEventFusionConnectFailedArgs OnEventFusionConnectFailedArgs = new();
        private OnEventFusionHostMigrationArgs OnEventFusionHostMigrationArgs = new();
        private OnEventFusionInputMissingArgs OnEventFusionInputMissingArgs = new();
        private OnEventFusionReliableDataArgs OnEventFusionReliableDataArgs = new();
        private OnEventFusionReliableProgressArgs OnEventFusionReliableProgressArgs = new();
        private OnEventFusionSimulationMessageArgs OnEventFusionSimulationMessageArgs = new();
        private OnEventFusionCustomAuthenticationResponseArgs OnEventFusionCustomAuthenticationResponseArgs = new();
        private OnEventFusionDisconnectedFromServerArgs OnEventFusionDisconnectedFromServerArgs = new();
        private OnEventFusionSessionListUpdateArgs OnEventFusionSessionListUpdateArgs = new();
        private OnEventFusionObjectExitAOIArgs OnEventFusionObjectExitAOIArgs = new();
        private OnEventFusionObjectEnterAOIArgs OnEventFusionObjectEnterAOIArgs = new();

        private void Awake()
        {
            StartModule();
        }


        public bool StartModule()
        {
            networkEvents = FindFirstObjectByType<NetworkEvents>();
            networkEvents.OnShutdown.AddListener((_arg0, _reason) => { StopModule(); });
            MakeSureEventNotify();
            return true;
        }


        [Obsolete("This method will be removed in future versions. Please use NetworkEvents instead.")]
        private void MakeSureEventNotify()
        {
            networkEvents.OnInput.AddListener((_runner, _input) =>
            {
                OnEventFusionInputArgs.NetworkInput = _input;
                OnEventFusionInputArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionInputArgs);
            });

            networkEvents.OnShutdown.AddListener((_runner, _shutdownReason) =>
            {
                StopModule();
                OnEventFusionShutdownArgs.ShutdownReason = _shutdownReason;
                OnEventFusionShutdownArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionShutdownArgs);
            });

            networkEvents.PlayerJoined.AddListener((_runner, _playerRef) =>
            {
                OnEventFusionPlayerJoinedArgs.PlayerRef = _playerRef;
                OnEventFusionPlayerJoinedArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionPlayerJoinedArgs);
            });

            networkEvents.PlayerLeft.AddListener((_runner, _playerRef) =>
            {
                OnEventFusionPlayerLeftArgs.PlayerRef = _playerRef;
                OnEventFusionPlayerLeftArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionPlayerLeftArgs);
            });

            networkEvents.OnConnectRequest.AddListener((_runner, _request, _bytes) =>
            {
                OnEventFusionConnectRequestArgs.Request = _request;
                OnEventFusionConnectRequestArgs.Bytes = _bytes;
                OnEventFusionConnectRequestArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionConnectRequestArgs);
            });

            networkEvents.OnConnectFailed.AddListener((_runner, _address, _reason) =>
            {
                OnEventFusionConnectFailedArgs.Address = _address;
                OnEventFusionConnectFailedArgs.Reason = _reason;
                OnEventFusionConnectFailedArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionConnectFailedArgs);
            });

            networkEvents.OnConnectedToServer.AddListener(_runner =>
            {
                OnEventFusionConnectedToServerArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionConnectedToServerArgs);
            });

            networkEvents.OnHostMigration.AddListener((_runner, _token) =>
            {
                OnEventFusionHostMigrationArgs.Token = _token;
                OnEventFusionHostMigrationArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionHostMigrationArgs);
            });

            networkEvents.OnInputMissing.AddListener((_runner, _playerRef, _input) =>
            {
                OnEventFusionInputMissingArgs.PlayerRef = _playerRef;
                OnEventFusionInputMissingArgs.Input = _input;
                OnEventFusionInputMissingArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionInputMissingArgs);
            });

            networkEvents.OnReliableData.AddListener((_runner, _playerRef, _reliableKey, _arraySegment) =>
            {
                OnEventFusionReliableDataArgs.PlayerRef = _playerRef;
                OnEventFusionReliableDataArgs.ReliableKey = _reliableKey;
                OnEventFusionReliableDataArgs.ArraySegment = _arraySegment;
                OnEventFusionReliableDataArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionReliableDataArgs);
            });

            networkEvents.OnReliableProgress.AddListener((_runner, _playerRef, _reliableKey, _progress) =>
            {
                OnEventFusionReliableProgressArgs.PlayerRef = _playerRef;
                OnEventFusionReliableProgressArgs.ReliableKey = _reliableKey;
                OnEventFusionReliableProgressArgs.Progress = _progress;
                OnEventFusionReliableProgressArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionReliableProgressArgs);
            });

            networkEvents.OnSimulationMessage.AddListener((_runner, _msgPtr) =>
            {
                OnEventFusionSimulationMessageArgs.SimulationMessagePtr = _msgPtr;
                OnEventFusionSimulationMessageArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionSimulationMessageArgs);
            });

            networkEvents.OnCustomAuthenticationResponse.AddListener((_runner, _dictionary) =>
            {
                OnEventFusionCustomAuthenticationResponseArgs.Dictionary = _dictionary;
                OnEventFusionCustomAuthenticationResponseArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionCustomAuthenticationResponseArgs);
            });

            networkEvents.OnDisconnectedFromServer.AddListener((_runner, _reason) =>
            {
                OnEventFusionDisconnectedFromServerArgs.Reason = _reason;
                OnEventFusionDisconnectedFromServerArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionDisconnectedFromServerArgs);
            });

            networkEvents.OnSessionListUpdate.AddListener((_runner, _sessionInfos) =>
            {
                OnEventFusionSessionListUpdateArgs.SessionInfos = _sessionInfos;
                OnEventFusionSessionListUpdateArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionSessionListUpdateArgs);
            });

            networkEvents.OnObjectEnterAOI.AddListener((_runner, _networkObject, _playerRef) =>
            {
                OnEventFusionObjectEnterAOIArgs.PlayerRef = _playerRef;
                OnEventFusionObjectEnterAOIArgs.NetworkObject = _networkObject;
                OnEventFusionObjectEnterAOIArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionObjectEnterAOIArgs);
            });

            networkEvents.OnObjectExitAOI.AddListener((_runner, _networkObject, _playerRef) =>
            {
                OnEventFusionObjectExitAOIArgs.PlayerRef = _playerRef;
                OnEventFusionObjectExitAOIArgs.NetworkObject = _networkObject;
                OnEventFusionObjectExitAOIArgs.Runner = _runner;
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                    OnEventFusionObjectExitAOIArgs);
            });

            GetComponent<NetworkRunner>().ProvideInput = true;
        }

        public bool PauseModule()
        {
            return true;
        }

        public bool StopModule()
        {
            networkEvents.OnInput.RemoveAllListeners();
            networkEvents.OnShutdown.RemoveAllListeners();
            networkEvents.PlayerJoined.RemoveAllListeners();
            networkEvents.PlayerLeft.RemoveAllListeners();
            networkEvents.OnConnectRequest.RemoveAllListeners();
            networkEvents.OnConnectFailed.RemoveAllListeners();
            networkEvents.OnConnectedToServer.RemoveAllListeners();
            networkEvents.OnHostMigration.RemoveAllListeners();
            networkEvents.OnInputMissing.RemoveAllListeners();
            networkEvents.OnReliableData.RemoveAllListeners();
            networkEvents.OnReliableProgress.RemoveAllListeners();
            networkEvents.OnSimulationMessage.RemoveAllListeners();
            networkEvents.OnCustomAuthenticationResponse.RemoveAllListeners();
            networkEvents.OnDisconnectedFromServer.RemoveAllListeners();
            networkEvents.OnSessionListUpdate.RemoveAllListeners();
            networkEvents.OnObjectEnterAOI.RemoveAllListeners();
            networkEvents.OnObjectExitAOI.RemoveAllListeners();
            if (Runner)
                Runner.Shutdown();
            return true;
        }

        public bool IsModuleAvailability()
        {
            return true;
        }

        public void MakeSureDependencies()
        {
        }
    }
}
#endif