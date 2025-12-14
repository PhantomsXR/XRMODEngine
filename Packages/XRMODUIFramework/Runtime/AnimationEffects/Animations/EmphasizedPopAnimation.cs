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
    public class EmphasizedPopAnimation : IUIAnimationProvider
    {
        private RectTransform rect;
        private Vector3 baseScale;
        private float timer, duration;
        private AnimationCurve curve;

        public void Initialize(RectTransform _rect, CanvasGroup _cg, Vector3 _baseScale)
        {
            this.rect = _rect;
            this.baseScale = _baseScale;
        }

        public void Play(float _duration, AnimationCurve _customCurve)
        {
            this.duration = Mathf.Max(_duration, 0.5f);
            this.curve = _customCurve.length > 0 ? _customCurve : UIAnimationCurve.SpringEmphasized;
            timer = 0f;
            rect.localScale = baseScale * 0.90f;
        }

        public bool Update(float _dt)
        {
            if (timer >= duration) return false;
            timer += _dt;

            float tmp_T = Mathf.Clamp01(timer / duration);
            float tmp_S = curve.Evaluate(tmp_T); // 带 1.15 峰值的感觉
            float tmp_Mapped = Mathf.LerpUnclamped(0.90f, 1.0f, tmp_S);
            rect.localScale = baseScale * tmp_Mapped; 
            return timer < duration;
        }
    }
}