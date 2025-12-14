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
    public class FadeInAnimation: IUIAnimationProvider
    { 
        private CanvasGroup canvasGroup;
        private Vector3 baseScale;
        private AnimationCurve curve;
        private float timer, duration;

        public void Initialize(RectTransform _, CanvasGroup _canvasGroup, Vector3 _baseScale)
        { 
            this.canvasGroup = _canvasGroup;
            this.baseScale = _baseScale;
        }

        public void Play(float _duration, AnimationCurve _curve)
        {
            this.duration = Mathf.Max(_duration, 0.5f);
            this.curve = _curve.length > 0 ? _curve : UIAnimationCurve.FadeInScale;
            this.timer = 0f; 
            if (canvasGroup != null) canvasGroup.alpha = 0f;
        }

        public bool Update(float _deltaTime)
        {
            if (timer >= duration) return false;

            timer += _deltaTime;
            float tmp_T = Mathf.Clamp01(timer / duration);
            float tmp_Eval = curve.Evaluate(tmp_T);
            if (canvasGroup != null) canvasGroup.alpha = tmp_Eval;
            return timer < duration;
        }
    }
}