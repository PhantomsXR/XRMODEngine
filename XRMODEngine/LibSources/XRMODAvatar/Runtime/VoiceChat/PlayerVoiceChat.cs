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
    public class PlayerVoiceChat : NetworkBehaviour
    {
        private const float _CONST_VOICE_AMPLITUDE_SPEED = 15f;

        #region Voice

        internal readonly NetworkVariable<bool> selfMutedNetworkVariable = new(false,
            NetworkVariableReadPermission.Everyone,
            NetworkVariableWritePermission.Owner);

        public string GetPlayerVoiceId => playerVoiceIdNetworkVariable.Value.ToString();

        internal readonly NetworkVariable<FixedString128Bytes> playerVoiceIdNetworkVariable = new("",
            NetworkVariableReadPermission.Everyone,
            NetworkVariableWritePermission.Owner);

        #endregion

        private Voice3DTracking voice3DTracking;
        private VoiceParticipant voiceParticipant;

        private float currentVoiceAmplitude;
        private float voiceAmplitudeDestination;


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


        public void SetUpPlayerVoice()
        {
            voiceParticipant = VoiceSystemManager.GetInstance.GetParticipant(GetPlayerVoiceId);
        }


        public void ToggleSquelch()
        {
            if (voiceParticipant == null) return;
            if (voiceParticipant.IsMuted)
                voiceParticipant.MuteUserLocally();
            else
                voiceParticipant.UnmuteUserLocally();


            selfMutedNetworkVariable.Value = voiceParticipant.IsMuted;
        }

        public void SetVoiceId(string _voiceId)
        {
            playerVoiceIdNetworkVariable.Value = new FixedString128Bytes(_voiceId);
            SetUpPlayerVoice();

            // Manually trigger update locations to avoid being updated due to small changes in player positions
            GetComponent<Voice3DTracking>().Set3DAudio();
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