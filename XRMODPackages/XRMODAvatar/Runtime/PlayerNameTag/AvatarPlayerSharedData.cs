// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODAvatar.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.NetcodeModule.Runtime.Gameplay;
using Phantom.XRMOD.XRMODAvatar.Runtime;
using Phantom.XRMOD.XRMODAvatar.Runtime.XR;
using Unity.Collections;
using UnityEngine;

namespace Phantom.XRMOD.XRMODAvatar.PlayerNameTag
{
    /// <summary>
    /// A central component for synchronizing shared player data (name, voice state, device type) 
    /// between network variables and local UI/visuals.
    /// </summary>
    public class AvatarPlayerSharedData : MonoBehaviour
    {
        internal BindableProperty<bool> selfMutedProperty = new();
        internal BindableProperty<string> playerDeviceProperty = new();
        internal BindableProperty<string> playerNameProperty = new();
        internal BindableProperty<string> playerVoiceIdProperty = new();
        internal BindableProperty<bool> readyStateProperty = new();

        private NGOPlayerBase player;
        private PlayerVoiceChat playerVoiceChat;
        private UpdateBatchOptimization updateBatchOptimization;

        private Transform playerNameTagTrackingTransform;

        public NGOPlayerBase Player => player;

        public Transform AvatarLeftHand => ((XRNetworkPlayerAvatar) Player).leftHand;
        public Transform AvatarRightHand => ((XRNetworkPlayerAvatar) Player).rightHand;

        public PlayerVoiceChat PlayerVoiceChat => playerVoiceChat;
        public Transform GetHeadTransform => playerNameTagTrackingTransform;
        public UpdateBatchOptimization UpdateBatchOptimization => updateBatchOptimization;


        private void Awake()
        {
            updateBatchOptimization = GetComponentInParent<UpdateBatchOptimization>();

            if (TryGetComponent(out player))
            {
                player.PlayerNameProperty.OnValueChanged += OnPlayerNamePropertyChanged;
                player.DeviceTypeProperty.OnValueChanged += OnDeviceTypePropertyChanged;
                player.IsReadyProperty.OnValueChanged += OnReadyStateChanged;
            }

            if (TryGetComponent(out playerVoiceChat))
            {
                playerVoiceChat.selfMutedNetworkVariable.OnValueChanged += OnMicrophoneMuted;
                playerVoiceChat.playerVoiceIdNetworkVariable.OnValueChanged += OnPlayerVoiceIdChanged;
            }

#if USE_XR_HAND
            playerNameTagTrackingTransform = ((Runtime.XR.XRNetworkPlayerAvatar) player).head;
#endif
        }

        /// <summary>
        /// Synchronizes the local bindable properties with the current values of network variables.
        /// Typically used when a remote player joins and their initial state needs to be reflected locally.
        /// </summary>
        public void SyncSharedDataSnapshot()
        {
            OnMicrophoneMuted(playerVoiceChat.selfMutedNetworkVariable.Value,
                playerVoiceChat.selfMutedNetworkVariable.Value);

            OnPlayerVoiceIdChanged(playerVoiceChat.playerVoiceIdNetworkVariable.Value,
                playerVoiceChat.playerVoiceIdNetworkVariable.Value);

            OnPlayerNamePropertyChanged(player.GetPlayerName);
            OnDeviceTypePropertyChanged(player.GetDeviceType);
            OnReadyStateChanged(player.IsReady);
        }

        private void OnDestroy()
        {
            if (player)
            {
                player.PlayerNameProperty.OnValueChanged -= OnPlayerNamePropertyChanged;
                player.DeviceTypeProperty.OnValueChanged -= OnDeviceTypePropertyChanged;
                player.IsReadyProperty.OnValueChanged -= OnReadyStateChanged;
            }

            if (playerVoiceChat)
            {
                playerVoiceChat.selfMutedNetworkVariable.OnValueChanged -= OnMicrophoneMuted;
                playerVoiceChat.playerVoiceIdNetworkVariable.OnValueChanged -= OnPlayerVoiceIdChanged;
            }
        }

        private void OnReadyStateChanged(bool _readyState)
        { 
            readyStateProperty.Value = _readyState;
        }


        private void OnDeviceTypePropertyChanged(string _obj)
        {
            playerDeviceProperty.Value = _obj;
        }


        private void OnPlayerNamePropertyChanged(string _obj)
        {
            playerNameProperty.Value = _obj;
        }

        private void OnMicrophoneMuted(bool _previousValue, bool _newValue)
        {
            selfMutedProperty.Value = _newValue;
        }


        private void OnPlayerVoiceIdChanged(FixedString128Bytes _previousValue, FixedString128Bytes _newValue)
        {
            playerVoiceIdProperty.Value = _newValue.ToString();
        }
    }
}