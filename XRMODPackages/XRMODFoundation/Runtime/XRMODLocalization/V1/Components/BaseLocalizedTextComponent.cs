// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Localization.Runtime.
// //
// // The Localization cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.Localization.Runtime
{
    public abstract class BaseLocalizedTextComponent : BaseLocalizationData<string>
    {
        internal virtual void Start()
        {
            SetKey(key);
        }

        public override void SetKey(string _key)
        {
            base.SetKey(_key);
            if (Application.isPlaying)
                LocalizationManager.Instance.AddText(this, localizationScope);
        }
    }
}