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
    /// <summary>
    /// Manages the visual appearance of the avatar, including toggling different parts (head, hands, etc.) 
    /// and animating blend shapes based on voice chat energy.
    /// </summary>
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

        /// <summary>
        /// Sets the visibility of general avatar body parts.
        /// </summary>
        /// <param name="_render">True to show, False to hide.</param>
        internal void SetAvatarPartsVisualizer(bool _render)
        {
            foreach (GameObject tmp_AvatarPart in avatarParts)
            {
                if (tmp_AvatarPart) tmp_AvatarPart.SetActive(_render);
            }
        }

        /// <summary>
        /// Sets the visibility of hand objects.
        /// </summary>
        /// <param name="_render">True to show, False to hide.</param>
        internal void SetHandsVisualizer(bool _render)
        {
            foreach (GameObject tmp_Hand in hands)
            {
                if (tmp_Hand) tmp_Hand.SetActive(_render);
            }
        }

        /// <summary>
        /// Sets the visibility of head-tracked accessories.
        /// </summary>
        /// <param name="_render">True to show, False to hide.</param>
        internal void SetHeadTrackVisualizer(bool _render)
        {
            foreach (GameObject tmp_HeadTracker in headTrackerParts)
            {
                if (tmp_HeadTracker) tmp_HeadTracker.SetActive(_render);
            }
        }
    }

    /// <summary>
    /// Configuration for a specific blend shape on a SkinnedMeshRenderer.
    /// </summary>
    [System.Serializable]
    public class BlendShapeSetting
    {
        /// <summary>
        /// Descriptive name of the blend shape.
        /// </summary>
        public string BlendShapeName;

        /// <summary>
        /// Index of the blend shape on the SkinnedMeshRenderer.
        /// </summary>
        public int BlendShapeIndex;

        /// <summary>
        /// Multiplier applied to the audio energy to drive blend shape weight.
        /// </summary>
        public float BlendShapeValue = 100f;

        /// <summary>
        /// The SkinnedMeshRenderer containing the blend shape.
        /// </summary>
        public SkinnedMeshRenderer SkinnedMeshRenderer;
    }
}