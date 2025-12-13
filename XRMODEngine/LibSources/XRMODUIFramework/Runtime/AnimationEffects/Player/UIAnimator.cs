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

using System;
using UnityEngine;

namespace Phantom.XRMOD.UIFramework.Runtime.AnimationEffects
{
    public class UIAnimator : MonoBehaviour
    {
        public UIAnimationPreset Preset;

        public float Duration = 0;
        public bool ReducedMotion = false;
        public bool AutoPlay;

        public UIAnimationType animationType = UIAnimationType.SpringPop;
        public AnimationCurve customCurve;

        public Action OnAnimationComplete;

        private float timer;
        private bool isPlaying;

        private Vector3 baseScale;
        private CanvasGroup canvasGroup;
        private RectTransform rect;
        private IUIAnimationProvider animationProvider;


        void Awake()
        {
            rect = GetComponent<RectTransform>();
            baseScale = transform.localScale;
            canvasGroup = GetComponent<CanvasGroup>();
            if (canvasGroup == null)
                canvasGroup = gameObject.AddComponent<CanvasGroup>();

            animationProvider = UIAnimatorFactory.CreateStrategy(animationType);
            animationProvider.Initialize(rect, canvasGroup, baseScale);
        }

        private void Start()
        {
            if (AutoPlay)
            {
                Play();
            }
        }

        [ContextMenu("Play")]
        public void Play()
        {
            if (Preset)
            {
                animationType = Preset.AnimationType;
                customCurve = Preset.CustomCurve;
                Duration = Preset.Duration;
                ReducedMotion = Preset.SupportReducedMotion && ReducedMotion;
            }

            if (ReducedMotion)
            {
                animationType = UIAnimationType.DimDissolve;
                animationProvider = UIAnimatorFactory.CreateStrategy(animationType);
                animationProvider.Initialize(rect, canvasGroup, baseScale);
                customCurve = UIAnimationCurve.EaseOut;
                Duration = Mathf.Max(.22f, Duration);
            }

            isPlaying = true;
            animationProvider.Play(Duration, customCurve);
        }

        public void Play(UIAnimationType _animationType)
        {
            if (ReducedMotion)
            {
                animationProvider = UIAnimatorFactory.CreateStrategy(UIAnimationType.DimDissolve);
                animationProvider.Initialize(rect, canvasGroup, baseScale);
                customCurve = UIAnimationCurve.EaseOut;
                Duration = Mathf.Max(.22f, Duration);
            }
            else
            {
                animationProvider = UIAnimatorFactory.CreateStrategy(_animationType);
                animationProvider.Initialize(rect, canvasGroup, baseScale);
            }

            isPlaying = true;
            animationProvider.Play(Duration, customCurve);
        }


        public void Reverse()
        {
            if (animationProvider is LiftOnFocusAnimation tmp_Lift)
            {
                tmp_Lift.SetReverse(true);
                isPlaying = true;
                animationProvider.Play(Duration, customCurve);
            }
        }

        void Update()
        {
            if (!isPlaying) return;

            bool tmp_Running = animationProvider.Update(Time.deltaTime);
            if (tmp_Running) return;
            isPlaying = false;
            OnAnimationComplete?.Invoke();
        }
    }


    public enum UIAnimationType
    {
        ScalePop, // 缩放弹出
        FadeIn,
        FadeInScale, // 淡入+缩放
        Pulse, // 呼吸循环

        SpringPop,
        EmphasizedPop,
        LiftOnFocus, // 需要 Play/Reverse 成对使用
        DimDissolve
    }
}