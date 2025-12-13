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

using System;

namespace Phantom.XRMOD.Localization.Runtime
{
    public enum LocalizationScope
    {
        InExperiences,
        InLauncher
    }

    [Obsolete("Use LocalizationScope instead.")]
    public enum AvailablePlace
    {
        InExperiences,
        InLauncher
    }
    
    public static class LocalizationScopeCompat
    {
        public static LocalizationScope ToLocalizationScope(this AvailablePlace place)
        {
            return place switch
            {
                AvailablePlace.InExperiences => LocalizationScope.InExperiences,
                AvailablePlace.InLauncher => LocalizationScope.InLauncher,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public static AvailablePlace ToAvailablePlace(this LocalizationScope scope)
        {
            return scope switch
            {
                LocalizationScope.InExperiences => AvailablePlace.InExperiences,
                LocalizationScope.InLauncher => AvailablePlace.InLauncher,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}