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
    public class PulseAnimation : IUIAnimationProvider
    {
        private RectTransform rect;
        private Vector3 baseScale;
        private float timer, duration;

        public void Initialize(RectTransform _rect, CanvasGroup _canvasGroup, Vector3 _baseScale)
        {
            this.rect = _rect;
            this.baseScale = _baseScale;
        }

        public void Play(float _duration, AnimationCurve _)
        {
            this.duration = Mathf.Max(_duration, 0.5f);
            this.timer = 0f;
        }

        public bool Update(float _deltaTime)
        {
            timer += _deltaTime / duration;
            float tmp_Scale = Mathf.Lerp(0.9f, 1.1f, Mathf.PingPong(timer, 1f));
            rect.localScale = baseScale * tmp_Scale;
            return true; // 永远循环
        }
    }
}