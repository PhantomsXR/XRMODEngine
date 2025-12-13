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
    [CreateAssetMenu(fileName = "AudioClipData", menuName = "XR-MOD/Audio Module/Audio Clip Data")]
    public class AudioClipData : ScriptableObject
    {
        [SerializeField] private List<AudioClip> audioClips;
        [SerializeField] private float pitchBase = 1f;
        [SerializeField] private float pitchVariation = 0f;

        public void Initialize(bool _loadIntoMemory = true)
        {
            if (!_loadIntoMemory) return;
            foreach (AudioClip tmp_Clip in audioClips)
            {
                if (tmp_Clip.loadState == AudioDataLoadState.Loaded) continue;
                tmp_Clip.LoadAudioData();
            }
        }

        public void Initialize(float _pitchBase, float _pitchVariation, bool _loadIntoMemory = true,
            params AudioClip[] _audioClips)
        {
            pitchBase = _pitchBase;
            pitchVariation = _pitchVariation;
            audioClips ??= new List<AudioClip>();
            audioClips.AddRange(_audioClips);
            Initialize(_loadIntoMemory);
        }

        public AudioClip GetAudioClip()
        {
            return audioClips[Random.Range(0, audioClips.Count)];
        }

        public float GetPitchOffset()
        {
            float tmp_PitchVariationHalf = pitchVariation / 2f;
            return pitchBase + Random.Range(-tmp_PitchVariationHalf, tmp_PitchVariationHalf);
        }
    }
}