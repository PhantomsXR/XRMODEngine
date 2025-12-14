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
    public static class UIAnimationCurve
    {
        // 近似 iOS/visionOS “spring (medium)”：小超调后快速收敛
        public static AnimationCurve SpringMedium =>
            new AnimationCurve(
                new Keyframe(0.00f, 0.00f, 0.00f, 6.00f),
                new Keyframe(0.22f, 1.10f, 0.00f, -4.50f),
                new Keyframe(0.45f, 0.98f, -1.50f, 0.50f),
                new Keyframe(0.60f, 1.00f, 0.20f, 0.00f),
                new Keyframe(1.00f, 1.00f, 0.00f, 0.00f)
            );

        // 强调弹簧：更快到峰值，略大超调，但仍克制
        public static AnimationCurve SpringEmphasized =>
            new AnimationCurve(
                new Keyframe(0.00f, 0.00f, 0.00f, 7.50f),
                new Keyframe(0.18f, 1.15f, 0.00f, -6.00f),
                new Keyframe(0.38f, 0.99f, -2.00f, 0.60f),
                new Keyframe(0.52f, 1.00f, 0.15f, 0.00f),
                new Keyframe(1.00f, 1.00f, 0.00f, 0.00f)
            );

        // 快速减速（Ease-Out），替代“减少动态”时的首选
        public static AnimationCurve EaseOut =>
            AnimationCurve.EaseInOut(0f, 0f, 1f, 1f); // 简洁耐看

        // 轻柔淡入（透明度插值曲线，后半段略提速）
        public static AnimationCurve AlphaSoftIn =>
            new AnimationCurve(
                new Keyframe(0.00f, 0.00f, 0.00f, 2.50f),
                new Keyframe(0.60f, 0.85f, 1.80f, 0.50f),
                new Keyframe(1.00f, 1.00f, 0.20f, 0.00f)
            );

        public static AnimationCurve ScalePop = new AnimationCurve(
            new Keyframe(0f, 0.3f, 0f, 3f), // 开始时很小
            new Keyframe(0.3f, 1.2f, 0f, -2f), // 快速放大到 1.2 倍
            new Keyframe(0.5f, 1.0f, -1f, 0f) // 回落到正常大小
        );

        public static AnimationCurve FadeInScale = new AnimationCurve(
            new Keyframe(0f, 0f), // 透明且小
            new Keyframe(1f, 1f) // 完全显示
        );
    }
}