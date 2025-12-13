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
#if USE_AUDIO_MODULE
    [RequireComponent(typeof(Phantom.XRMOD.AudioModule.Runtime.AudioEmitter))]
    public class
        LocalizationAudioModuleComponent : BaseLocalizationData<Phantom.XRMOD.AudioModule.Runtime.AudioClipData>
    {
        private Phantom.XRMOD.AudioModule.Runtime.AudioEmitter audioEmitter;

        public override void SetKey(string _key)
        {
            base.SetKey(_key);
            LocalizationManager.Instance.AddAudioModule(this, localizationScope);
        }


        public override void UpdateContent(Phantom.XRMOD.AudioModule.Runtime.AudioClipData _value)
        {
            if (audioEmitter == null)
                audioEmitter = GetComponent<Phantom.XRMOD.AudioModule.Runtime.AudioEmitter>();
            audioEmitter.SetAudioClipData(_value);
        }
    }
#endif
}