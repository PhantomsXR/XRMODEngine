/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;
using UnityEngine.Assertions;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Localizes an <see cref="AudioSource"/> component by updating its <see cref="AudioClip"/>.
    /// Requires an <see cref="AudioSource"/> component on the same GameObject.
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class LocalizationAudioComponent : BaseLocalizationData<AudioClip>
    {
        private AudioSource audioSource;

        protected override void Start()
        {
            base.Start();
            audioSource = GetComponent<AudioSource>();
        }


        /// <summary>
        /// Sets the localization key and registers this component with the <see cref="LocalizationManager"/> for audio updates.
        /// </summary>
        /// <param name="_key">The unique localization key.</param>
        public override void SetKey(string _key)
        {
            base.SetKey(_key);
            LocalizationManager.Instance.AddAudio(this, localizationScope);
        }

        /// <summary>
        /// Updates the <see cref="AudioClip"/> of the <see cref="AudioSource"/> component.
        /// </summary>
        /// <param name="_value">The new localized <see cref="AudioClip"/>.</param>
        public override void UpdateContent(AudioClip _value)
        {
            if (audioSource == null)
                audioSource = GetComponent<AudioSource>();
            
            Assert.IsNotNull(_value);
            audioSource.clip = _value;
        }
    }
}