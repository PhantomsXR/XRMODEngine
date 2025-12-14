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
    public class LiftOnFocusAnimation : IUIAnimationProvider
    {
        private RectTransform rect;
        private Vector3 baseScale, targetScale;
        private Vector2 startPos, targetPos; // 轻微位移模拟“抬起”
        private float timer, duration;
        private AnimationCurve curve;
        private bool reverse;

        // 可调参数
        public float LiftScale = 1.04f;
        public Vector2 LiftOffset = new Vector2(0f, 6f); // UI像素单位
        public void SetReverse(bool _reverse) => this.reverse = _reverse;

        public void Initialize(RectTransform _rect, CanvasGroup _cg, Vector3 _baseScale)
        {
            this.rect = _rect;
            this.baseScale = _baseScale;
            startPos = _rect.anchoredPosition;
            targetScale = _baseScale * LiftScale;
            targetPos = startPos + LiftOffset;
        }

        public void Play(float _duration, AnimationCurve _customCurve)
        {
            this.duration = Mathf.Max(_duration, .25f);
            this.curve = _customCurve.length > 0 ? _customCurve : UIAnimationCurve.EaseOut;
            timer = 0f;
        }

        public bool Update(float _dt)
        {
            if (timer >= duration) return false;
            timer += _dt;

            float tmp_T = Mathf.Clamp01(timer / duration);
            float tmp_E = curve.Evaluate(tmp_T);

            if (!reverse)
            {
                rect.localScale = Vector3.Lerp(baseScale, targetScale, tmp_E);
                rect.anchoredPosition = Vector2.Lerp(startPos, targetPos, tmp_E);
            }
            else
            {
                rect.localScale = Vector3.Lerp(targetScale, baseScale, tmp_E);
                rect.anchoredPosition = Vector2.Lerp(targetPos, startPos, tmp_E);
            }

            return timer < duration;
        }
    }
}