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
    public class DimDissolveAnimation : IUIAnimationProvider
    {
        private RectTransform rect;
        private CanvasGroup cg;
        private Vector3 baseScale;
        private float timer, duration;
        private AnimationCurve alphaCurve;
        private AnimationCurve scaleCurve;

        public void Initialize(RectTransform _rect, CanvasGroup _cg, Vector3 _baseScale)
        {
            this.rect = _rect;
            this.cg = _cg ?? _rect.gameObject.GetComponent<CanvasGroup>() ??
                _rect.gameObject.AddComponent<CanvasGroup>();
            this.baseScale = _baseScale;
        }

        public void Play(float _duration, AnimationCurve _)
        {
            this.duration = Mathf.Max(_duration, .3f);
            this.alphaCurve = UIAnimationCurve.AlphaSoftIn;
            this.scaleCurve = UIAnimationCurve.EaseOut;

            timer = 0f;
            cg.alpha = 0f;
            rect.localScale = baseScale * 0.98f; // 轻微从小到正
        }

        public bool Update(float _dt)
        {
            if (timer >= duration) return false;
            timer += _dt;

            float tmp_T = Mathf.Clamp01(timer / duration);
            cg.alpha = Mathf.Clamp01(alphaCurve.Evaluate(tmp_T));
            float tmp_ScaleT = Mathf.Clamp01(scaleCurve.Evaluate(tmp_T));
            rect.localScale = Vector3.Lerp(baseScale * 0.98f, baseScale, tmp_ScaleT);
            return timer < duration;
        }
    }
}