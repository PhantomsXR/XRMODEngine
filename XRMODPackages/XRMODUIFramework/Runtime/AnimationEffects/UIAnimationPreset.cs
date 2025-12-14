// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIFramework.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.UIFramework.Runtime.AnimationEffects
{
    [CreateAssetMenu(fileName = "UIAnimationPreset", menuName = "XR-MOD/UI/Animation Preset", order = 0)]
    public class UIAnimationPreset : ScriptableObject
    {
        [Tooltip("Animation type")] public UIAnimationType AnimationType = UIAnimationType.SpringPop;

        [Tooltip("Animation curve (optional, if not filled in, use built-in presets)")]
        public AnimationCurve CustomCurve;

        [Tooltip("Duration(seconds)")] [Range(0f, 2f)]
        public float Duration = 0.5f;

        [Tooltip("Use fade-in substitution when reducing dynamics")]
        public bool SupportReducedMotion = true;
    }
}