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
    /// Base abstract class for all localizable image components in XRMOD.
    /// Specializes <see cref="BaseLocalizationData{T}"/> for <see cref="Sprite"/> assets.
    /// </summary>
    public abstract class BaseLocalizedImageComponent : BaseLocalizationData<Sprite>
    {
       
    }
}