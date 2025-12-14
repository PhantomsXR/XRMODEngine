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
using System;
using System.Collections;
using System.Collections.Generic;

namespace Phantom.XRMOD.UIFramework.Runtime.AnimationEffects
{
    public class UIAnimationSequence : MonoBehaviour
    {
        public List<UIAnimationStep> steps = new();

        private RectTransform rect;
        private CanvasGroup cg;
        private Vector3 baseScale;

        void Awake()
        {
            rect = GetComponent<RectTransform>();
            baseScale = rect.localScale;
            cg = GetComponent<CanvasGroup>() ?? gameObject.AddComponent<CanvasGroup>();

            // 初始化所有 track
            foreach (var tmp_Step in steps)
            foreach (var tmp_Track in tmp_Step.tracks)
                tmp_Track.Initialize(rect, cg, baseScale);
        }

        public void PlaySequence()
        {
            StopAllCoroutines();
            StartCoroutine(PlaySteps());
        }

        private IEnumerator PlaySteps()
        {
            for (int tmp_I = 0; tmp_I < steps.Count; tmp_I++)
            {
                var tmp_Step = steps[tmp_I];
                if (tmp_Step.delay > 0f)
                    yield return new WaitForSeconds(tmp_Step.delay);

                yield return StartCoroutine(PlayTracks(tmp_Step.tracks));
            }
        }

        private IEnumerator PlayTracks(List<UIAnimationTrack> _tracks)
        {
            // 播放全部 Track
            foreach (var tmp_Track in _tracks)
            {
                if (tmp_Track.delay > 0f) StartCoroutine(DelayPlay(tmp_Track));
                else tmp_Track.Play();
            }

            bool tmp_Running = true;
            while (tmp_Running)
            {
                tmp_Running = false;
                foreach (var tmp_T in _tracks)
                    if (tmp_T.Update(Time.deltaTime))
                        tmp_Running = true;

                yield return null;
            }
        }

        private IEnumerator DelayPlay(UIAnimationTrack _track)
        {
            yield return new WaitForSeconds(_track.delay);
            _track.Play();
        }
    }


    [Serializable]
    public class UIAnimationTrack
    {
        public UIAnimationPreset preset; 
        public float delay;

        // 内部运行时持有
        private IUIAnimationProvider provider;
        private bool isPlaying;
        private float timer;

        public void Initialize(RectTransform _rect, CanvasGroup _cg, Vector3 _baseScale)
        {
            if (preset == null) return;
            provider = UIAnimatorFactory.CreateStrategy(preset.AnimationType);
            provider.Initialize(_rect, _cg, _baseScale);
        }

        public void Play()
        {
            if (preset == null || provider == null) return;
            isPlaying = true;
            timer = 0f;
            provider.Play(preset.Duration, preset.CustomCurve);
        }

        public bool Update(float _deltaTime)
        {
            if (!isPlaying || provider == null) return false;

            bool tmp_Running = provider.Update(_deltaTime);
            if (tmp_Running) return true;
            isPlaying = false;
            return false;
        }
    }


    [Serializable]
    public class UIAnimationStep
    {
        public string Name = "Step";
        public List<UIAnimationTrack> tracks = new();
        public float delay; // 播放前延迟
    }
}