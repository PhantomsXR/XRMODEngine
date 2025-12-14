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
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.XRMODAvatar.Runtime.XR
{
    public class AvatarVisualizer : MonoBehaviour
    {
        [SerializeField] private GameObject[] headTrackerParts;
        [SerializeField] private GameObject[] avatarParts;
        [SerializeField] private GameObject[] hands;
        [SerializeField] private BlendShapeSetting[] blendShapeSettings;

        private PlayerVoiceChat playerVoiceChat;
        private UpdateBatchOptimization updateBatchOptimization;

        public BlendShapeSetting[] BlendShapeSettings
        {
            get => blendShapeSettings;
            set => blendShapeSettings = value;
        }


        private void Awake()
        {
            TryGetComponent(out playerVoiceChat);
            TryGetComponent(out updateBatchOptimization);

            updateBatchOptimization.RegisterUpdate(DoBatchUpdate);
        }

        private void OnDestroy()
        {
            updateBatchOptimization.UnregisterUpdate(DoBatchUpdate);
        }

        private void DoBatchUpdate()
        {
            if (!playerVoiceChat || blendShapeSettings.Length == 0) return;

            foreach (var tmp_BlendShapeSetting in blendShapeSettings)
            {
                tmp_BlendShapeSetting.SkinnedMeshRenderer.SetBlendShapeWeight(tmp_BlendShapeSetting.BlendShapeIndex,
                    playerVoiceChat.GetVoiceAudioEnergy);
            }
        }

        internal void SetAvatarPartsVisualizer(bool _render)
        {
            foreach (GameObject tmp_AvatarPart in avatarParts)
            {
                tmp_AvatarPart.SetActive(_render);
            }
        }

        internal void SetHandsVisualizer(bool _render)
        {
            foreach (GameObject tmp_Hand in hands)
            {
                tmp_Hand.SetActive(_render);
            }
        }

        internal void SetHeadTrackVisualizer(bool _render)
        {
            foreach (GameObject tmp_HeadTracker in headTrackerParts)
            {
                tmp_HeadTracker.SetActive(_render);
            }
        }
    }

    [System.Serializable]
    public class BlendShapeSetting
    {
        public string BlendShapeName;
        public int BlendShapeIndex;
        public float BlendShapeValue = 1;
        public SkinnedMeshRenderer SkinnedMeshRenderer;
    }
}