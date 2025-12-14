// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.AudioModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.AudioModule.Runtime
{
    public class MusicPlayer : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;
        private float currentVolume;
        [SerializeField] private float fadeDuration = 2f;
        private float fadeSpeed;

        [Header("Audio Mixer")] [SerializeField]
        private AudioMixer mixer;

        private (float min, float max) lowPassMinMax = (500f, 22000f);
        private float lowPassTransitionDuration = 0.5f;
        private float lowPassTransitionSpeed;
        private float lowPassTransitionTimer;
        private float lowPassTransitionDirection = -1f;

        private const string _CONST_LOW_PASS_CUTOFF = "LowPassCutoff";

        public static MusicPlayer Instance;
        public AudioMixer GetAudioMixer => mixer;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;

                Initialize();
            }
            else
            {
                Destroy(this);
            }
        }

        private void Initialize()
        {
            lowPassTransitionSpeed = 1f / lowPassTransitionDuration;
        }

        // Start is called before the first frame update
        void Start()
        {
            currentVolume = 0f;
            SetVolume();

            fadeSpeed = 1f / fadeDuration;
            audioSource.Play();
        }

        // Update is called once per frame
        void Update()
        {
            if (currentVolume < 1f)
            {
                FadeVolume();
            }

            if (!LowPassTargetReached())
                UpdateLowPassFilter();
        }

        private void UpdateLowPassFilter()
        {
            lowPassTransitionTimer =
                Mathf.Clamp(lowPassTransitionTimer + Time.deltaTime * lowPassTransitionDirection, 0,
                    lowPassTransitionDuration);
            float tmp_T = lowPassTransitionTimer / lowPassTransitionDuration;
            float tmp_LowPassValue = Mathf.Lerp(lowPassMinMax.min, lowPassMinMax.max, tmp_T);
            mixer.SetFloat(_CONST_LOW_PASS_CUTOFF, tmp_LowPassValue);
        }

        private bool LowPassTargetReached()
        {
            return (lowPassTransitionTimer == 0 && lowPassTransitionDirection < 0) ||
                   (lowPassTransitionTimer >= lowPassTransitionDuration && lowPassTransitionDirection > 0);
        }

        void FadeVolume()
        {
            currentVolume = Mathf.Min(currentVolume + Time.deltaTime * fadeSpeed, 1f);
            SetVolume();
        }

        void SetVolume()
        {
            audioSource.volume = currentVolume;
        }

        public void SetLowPassTranstionDirection(float f)
        {
            lowPassTransitionDirection = f;
        }
    }
}