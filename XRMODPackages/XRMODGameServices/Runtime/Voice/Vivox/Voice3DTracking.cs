// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.GameServices.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

#if USE_VIVOX
using Unity.Services.Vivox;
#endif
using UnityEngine;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class Voice3DTracking : MonoBehaviour
    {
        [SerializeField] private Transform trackingTransform;
        [SerializeField] private bool isOwner;
        [SerializeField] private bool positionalVoiceChat;
        [SerializeField] private float voicePositionUpdateTime = .1f;
        [SerializeField] private float voiceUpdatePositionDelta = .05f;


        private float voicePositionCheckTimer;
        private Vector3 prevTrackingPosition;


        public bool IsOwner
        {
            get => isOwner;
            set => isOwner = value;
        }

        public bool PositionalVoiceChat
        {
            get => positionalVoiceChat;
            set => positionalVoiceChat = value;
        }


        private void Update()
        {
#if USE_VIVOX
            if (!PositionalVoiceChat) return;
            if (!(Time.time > voicePositionCheckTimer)) return;
            voicePositionCheckTimer += voicePositionUpdateTime;
            if (!(Vector3.Distance(prevTrackingPosition, trackingTransform.position) >
                  voiceUpdatePositionDelta)) return;
            prevTrackingPosition = trackingTransform.position;

            Set3DAudio();
#endif
        }


        public void Set3DAudio()
        {
#if USE_VIVOX
            if (!VivoxService.Instance.IsLoggedIn) return;

            if (VivoxService.Instance.ActiveChannels.Count > 0 &&
                VivoxService.Instance.TransmittingChannels[0] == VoiceSystemManager.GetInstance.ChannelName)
            {
                VivoxService.Instance.Set3DPosition(trackingTransform.position, trackingTransform.position,
                    trackingTransform.forward, trackingTransform.up, VoiceSystemManager.GetInstance.ChannelName);
            }
#endif
        }
    }
}