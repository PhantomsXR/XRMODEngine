// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Localization.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    public class LocalizedAudio : LocalizedAssetBase<AudioClip>
    {
        [SerializeField] private AudioSource audioSource;
        private void Awake()
        {
            if (audioSource == null)
                audioSource = GetComponent<AudioSource>();
        }

        protected override void ApplyAsset(AudioClip _asset)
        {
            if (audioSource == null) return;
            audioSource.clip = _asset;
        }
    }
}