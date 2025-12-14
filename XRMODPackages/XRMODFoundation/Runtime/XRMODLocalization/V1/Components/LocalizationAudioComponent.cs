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
using UnityEngine.Assertions;

namespace Phantom.XRMOD.Localization.Runtime
{
    [RequireComponent(typeof(AudioSource))]
    public class LocalizationAudioComponent : BaseLocalizationData<AudioClip>
    {
        private AudioSource audioSource;

        protected override void Start()
        {
            base.Start();
            audioSource = GetComponent<AudioSource>();
        }


        public override void SetKey(string _key)
        {
            base.SetKey(_key);
            LocalizationManager.Instance.AddAudio(this, localizationScope);
        }

        public override void UpdateContent(AudioClip _value)
        {
            if (audioSource == null)
                audioSource = GetComponent<AudioSource>();
            Assert.IsNotNull(_value);
            audioSource.clip = _value;
        }
    }
}