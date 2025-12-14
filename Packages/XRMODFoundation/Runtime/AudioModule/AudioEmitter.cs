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

using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.AudioModule.Runtime
{
    public class AudioEmitter : MonoBehaviour
    {
        enum State
        {
            OnEnable,
            OnDisable,
            None
        }

        [SerializeField] private State startAction = State.None;
        [SerializeField] private State stopAction = State.None;

        [SerializeField] private AudioClipData audioClipData;
        [SerializeField] private AudioSource audioSource;

        public AudioSource AudioSource
        {
            get
            {
                if (audioSource == null)
                    audioSource = GetComponent<AudioSource>();
                return audioSource;
            }
        }

        private void Start()
        {
            if (audioSource == null)
                audioSource = GetComponent<UnityEngine.AudioSource>();
        }

        private void OnEnable()
        {
            CheckState(State.OnEnable);
        }

        private void OnDisable()
        {
            CheckState(State.OnDisable);
        }

        private void CheckState(State _currentState)
        {
            if (startAction == _currentState)
                PlayClip();
            if (stopAction == _currentState)
                StopClip();
        }

        public void Play()
        {
            PlayClip();
        }

        public void Play(AudioClipData _audioClipData)
        {
            this.audioClipData = _audioClipData;
            PlayClip();
        }

        public void Stop()
        {
            StopClip();
        }

        public void PlayOneShot()
        {
            SetAudioClipAndPitch();
            AudioSource.PlayOneShot(AudioSource.clip);
        }

        public void PlayOneShot(AudioClipData _audioClip)
        {
            this.audioClipData = _audioClip;
            PlayOneShot();
        }

        public void SetAudioClipData(AudioClipData _audioClipData)
        {
            audioClipData = _audioClipData;
        }
        
        private void PlayClip()
        {
            SetAudioClipAndPitch();
            AudioSource.Play();
        }

        private void SetAudioClipAndPitch()
        {
            AudioSource.clip = audioClipData.GetAudioClip();
            AudioSource.pitch = audioClipData.GetPitchOffset();
        }

        private void StopClip()
        {
            AudioSource.Stop();
        }
    }
}