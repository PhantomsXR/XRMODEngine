/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Localizes an <see cref="AudioSource"/> component by updating its <see cref="AudioClip"/> in XRMOD V2.
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class LocalizedAudio : LocalizedAssetBase<AudioClip>
    {
        [SerializeField] private AudioSource audioSource;
        
        private void Awake()
        {
            if (audioSource == null)
                audioSource = GetComponent<AudioSource>();
        }

        /// <summary>
        /// Applies the loaded localized <see cref="AudioClip"/> to the <see cref="AudioSource"/>.
        /// </summary>
        /// <param name="_asset">The localized audio clip.</param>
        protected override void ApplyAsset(AudioClip _asset)
        {
            if (audioSource == null) return;
            audioSource.clip = _asset;
        }
    }
}