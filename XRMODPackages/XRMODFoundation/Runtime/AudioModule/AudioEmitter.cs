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
    /// <summary>
    /// A component that facilitates playing specified audio clips with configurable
    /// start/stop actions based on the object's lifecycle (<c>OnEnable</c>/<c>OnDisable</c>).
    /// </summary>
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

        /// <summary>
        /// Gets the <see cref="AudioSource"/> component associated with this emitter.
        /// Lazily initializes if not already assigned.
        /// </summary>
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

        /// <summary>
        /// Plays the default audio clip assigned to this emitter.
        /// </summary>
        public void Play()
        {
            PlayClip();
        }

        /// <summary>
        /// Plays a specific <see cref="AudioClipData"/> instead of the default one.
        /// </summary>
        /// <param name="_audioClipData">The audio clip data to play.</param>
        public void Play(AudioClipData _audioClipData)
        {
            this.audioClipData = _audioClipData;
            PlayClip();
        }

        /// <summary>
        /// Stops the current audio playback.
        /// </summary>
        public void Stop()
        {
            StopClip();
        }

        /// <summary>
        /// Plays the current audio clip as a one-shot effect.
        /// Useful for short sound effects that shouldn't cut each other off.
        /// </summary>
        public void PlayOneShot()
        {
            SetAudioClipAndPitch();
            AudioSource.PlayOneShot(AudioSource.clip);
        }

        /// <summary>
        /// Plays a specific <see cref="AudioClipData"/> as a one-shot effect.
        /// </summary>
        /// <param name="_audioClip">The audio clip data to play.</param>
        public void PlayOneShot(AudioClipData _audioClip)
        {
            this.audioClipData = _audioClip;
            PlayOneShot();
        }

        /// <summary>
        /// Sets a new <see cref="AudioClipData"/> for this emitter.
        /// </summary>
        /// <param name="_audioClipData">The new audio clip data.</param>
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