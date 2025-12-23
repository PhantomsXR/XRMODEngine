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
#if USE_AUDIO_MODULE
    /// <summary>
    /// Localizes a <see cref="Phantom.XRMOD.AudioModule.Runtime.AudioEmitter"/> component by updating its <see cref="Phantom.XRMOD.AudioModule.Runtime.AudioClipData"/>.
    /// Only available if <c>USE_AUDIO_MODULE</c> is defined.
    /// </summary>
    [RequireComponent(typeof(Phantom.XRMOD.AudioModule.Runtime.AudioEmitter))]
    public class LocalizationAudioModuleComponent : BaseLocalizationData<Phantom.XRMOD.AudioModule.Runtime.AudioClipData>
    {
        private Phantom.XRMOD.AudioModule.Runtime.AudioEmitter audioEmitter;

        /// <summary>
        /// Sets the localization key and registers this component with the <see cref="LocalizationManager"/> for audio module updates.
        /// </summary>
        /// <param name="_key">The unique localization key.</param>
        public override void SetKey(string _key)
        {
            base.SetKey(_key);
            LocalizationManager.Instance.AddAudioModule(this, localizationScope);
        }


        /// <summary>
        /// Updates the <see cref="Phantom.XRMOD.AudioModule.Runtime.AudioClipData"/> of the <see cref="Phantom.XRMOD.AudioModule.Runtime.AudioEmitter"/> component.
        /// </summary>
        /// <param name="_value">The new localized <see cref="Phantom.XRMOD.AudioModule.Runtime.AudioClipData"/>.</param>
        public override void UpdateContent(Phantom.XRMOD.AudioModule.Runtime.AudioClipData _value)
        {
            if (audioEmitter == null)
                audioEmitter = GetComponent<Phantom.XRMOD.AudioModule.Runtime.AudioEmitter>();
            
            audioEmitter.SetAudioClipData(_value);
        }
    }
#endif
}