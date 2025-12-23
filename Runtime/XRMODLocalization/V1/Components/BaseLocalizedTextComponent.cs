/*===============================================================================
Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The Localization cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Base abstract class for all localizable text components in XRMOD.
    /// Handles the automatic registration of the component with the <see cref="LocalizationManager"/>.
    /// </summary>
    public abstract class BaseLocalizedTextComponent : BaseLocalizationData<string>
    {
        protected override void Start()
        {
            SetKey(key);
        }

        /// <summary>
        /// Sets a new localization key and automatically registers this component with the <see cref="LocalizationManager"/> during playback.
        /// </summary>
        /// <param name="_key">The new unique key.</param>
        public override void SetKey(string _key)
        {
            base.SetKey(_key);
            if (Application.isPlaying)
                LocalizationManager.Instance.AddText(this, localizationScope);
        }
    }
}