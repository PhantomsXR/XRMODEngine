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

using System.Collections.Generic;
using UnityEngine;

namespace Phantom.XRMOD.AudioModule.Runtime
{
    /// <summary>
    /// Data container for one or more <see cref="AudioClip"/>s.
    /// Provides settings for pitch randomization and automated audio data loading.
    /// </summary>
    [CreateAssetMenu(fileName = "AudioClipData", menuName = "XR-MOD/Audio Module/Audio Clip Data")]
    public class AudioClipData : ScriptableObject
    {
        [SerializeField] private List<AudioClip> audioClips;
        [SerializeField] private float pitchBase = 1f;
        [SerializeField] private float pitchVariation = 0f;

        /// <summary>
        /// Pre-loads audio data into memory if requested.
        /// </summary>
        /// <param name="_loadIntoMemory">If true, forces the audio data to be loaded.</param>
        public void Initialize(bool _loadIntoMemory = true)
        {
            if (!_loadIntoMemory) return;
            foreach (AudioClip tmp_Clip in audioClips)
            {
                if (tmp_Clip.loadState == AudioDataLoadState.Loaded) continue;
                tmp_Clip.LoadAudioData();
            }
        }

        /// <summary>
        /// Initializes the data container with specific pitch settings and clips.
        /// </summary>
        /// <param name="_pitchBase">The base pitch value.</param>
        /// <param name="_pitchVariation">The range of random pitch variation.</param>
        /// <param name="_loadIntoMemory">Whether to load audio data into memory immediately.</param>
        /// <param name="_audioClips">An array of audio clips to add to this container.</param>
        public void Initialize(float _pitchBase, float _pitchVariation, bool _loadIntoMemory = true,
            params AudioClip[] _audioClips)
        {
            pitchBase = _pitchBase;
            pitchVariation = _pitchVariation;
            audioClips ??= new List<AudioClip>();
            audioClips.AddRange(_audioClips);
            Initialize(_loadIntoMemory);
        }

        /// <summary>
        /// Retrieves a random audio clip from the collection.
        /// </summary>
        /// <returns>A randomly selected <see cref="AudioClip"/>.</returns>
        public AudioClip GetAudioClip()
        {
            return audioClips[Random.Range(0, audioClips.Count)];
        }

        /// <summary>
        /// Calculates a random pitch offset based on the base pitch and variation range.
        /// </summary>
        /// <returns>A randomized pitch value.</returns>
        public float GetPitchOffset()
        {
            float tmp_PitchVariationHalf = pitchVariation / 2f;
            return pitchBase + Random.Range(-tmp_PitchVariationHalf, tmp_PitchVariationHalf);
        }
    }
}