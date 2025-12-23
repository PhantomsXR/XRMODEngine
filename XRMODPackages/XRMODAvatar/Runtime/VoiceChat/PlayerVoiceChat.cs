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

using System;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.GameServices.Runtime;
using Phantom.XRMOD.NetcodeModule.Runtime;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODAvatar.Runtime
{
    /// <summary>
    /// Handles networked voice chat for a player, including audio energy tracking and channel management.
    /// </summary>
    public class PlayerVoiceChat : NetworkBehaviour
    {
        private const float _CONST_VOICE_AMPLITUDE_SPEED = 15f;

        #region Voice

        internal readonly NetworkVariable<bool> selfMutedNetworkVariable = new(false,
            NetworkVariableReadPermission.Everyone,
            NetworkVariableWritePermission.Owner);

        /// <summary>
        /// Gets the unique voice ID associated with this player.
        /// </summary>
        public string GetPlayerVoiceId => playerVoiceIdNetworkVariable.Value.ToString();

        internal readonly NetworkVariable<FixedString128Bytes> playerVoiceIdNetworkVariable = new("",
            NetworkVariableReadPermission.Everyone,
            NetworkVariableWritePermission.Owner);

        #endregion

        private Voice3DTracking voice3DTracking;
        private VoiceParticipant voiceParticipant;

        private float currentVoiceAmplitude;
        private float voiceAmplitudeDestination;


        /// <summary>
        /// Gets the current audio energy level (0 to 1). 
        /// Useful for driving visual animations like mouth movement or voice bubbles.
        /// </summary>
        public float GetVoiceAudioEnergy => currentVoiceAmplitude;


        [SerializeField] private bool autoEnableVoiceChat = true;
        [SerializeField] private JoinChannelType joinChannelType = JoinChannelType.Positional;

        public bool AutoEnableVoiceChat
        {
            get => autoEnableVoiceChat;
            set => autoEnableVoiceChat = value;
        }

        public JoinChannelType VoiceChannelType
        {
            get => joinChannelType;
            set => joinChannelType = value;
        }

        private UpdateBatchOptimization updateBatchOptimization;


        private void Awake()
        {
            TryGetComponent(out voice3DTracking);
            voice3DTracking.enabled = false;

            updateBatchOptimization = GetComponentInParent<UpdateBatchOptimization>();
            updateBatchOptimization.RegisterUpdate(DoBatchUpdate);
        }


        public override void OnDestroy()
        {
            updateBatchOptimization.UnregisterUpdate(DoBatchUpdate);
            VoiceSystemManager.GetInstance.LeaveVoiceChannel();
        }


        private void DoBatchUpdate()
        {
            if (voiceParticipant == null) return;
            voiceAmplitudeDestination = Mathf.Clamp01((float) voiceParticipant.AudioEnergy);
            currentVoiceAmplitude = Mathf.Lerp(currentVoiceAmplitude, voiceAmplitudeDestination,
                Time.deltaTime * _CONST_VOICE_AMPLITUDE_SPEED);
        }

        public override void OnNetworkSpawn()
        {
            base.OnNetworkSpawn();
            if (voice3DTracking && IsOwner)
            {
                voice3DTracking.enabled = true;
                voice3DTracking.IsOwner = true;
            }
        }


        /// <summary>
        /// Connects this component to the underlying voice participant data.
        /// </summary>
        public void SetUpPlayerVoice()
        {
            voiceParticipant = VoiceSystemManager.GetInstance.GetParticipant(GetPlayerVoiceId);
        }


        /// <summary>
        /// Toggles the local squelch (mute) state for this player.
        /// </summary>
        public void ToggleSquelch()
        {
            if (voiceParticipant == null) return;
            if (voiceParticipant.IsMuted)
                voiceParticipant.UnmuteUserLocally();
            else
                voiceParticipant.MuteUserLocally();


            selfMutedNetworkVariable.Value = voiceParticipant.IsMuted;
        }

        /// <summary>
        /// Sets the voice ID for this player and initializes voice tracking.
        /// </summary>
        /// <param name="_voiceId">The unique voice identifier.</param>
        public void SetVoiceId(string _voiceId)
        {
            playerVoiceIdNetworkVariable.Value = new FixedString128Bytes(_voiceId);
            SetUpPlayerVoice();

            // Manually trigger update locations to avoid being updated due to small changes in player positions
            if (TryGetComponent<Voice3DTracking>(out var tmp_Voice3D))
            {
                tmp_Voice3D.Set3DAudio();
            }
        }

        protected override void OnNetworkPostSpawn()
        {
            base.OnNetworkPostSpawn();

            if (IsOwner)
            {
                VoiceSystemManager.GetInstance.JoinVoiceChannel(NetcodeServiceAPI.GetInstance.GetCurrentSessionCode,
                    VoiceChannelType);
            }
        }
    }
}