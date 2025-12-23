/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Specifies the scope or location where localization is applied.
    /// </summary>
    public enum LocalizationScope
    {
        /// <summary>
        /// Localization applied within the XR experiences.
        /// </summary>
        InExperiences,

        /// <summary>
        /// Localization applied within the application launcher/hub.
        /// </summary>
        InLauncher
    }

    /// <summary>
    /// Obsolete enum for specifying the available place for localization. Use <see cref="LocalizationScope"/> instead.
    /// </summary>
    [Obsolete("Use LocalizationScope instead.")]
    public enum AvailablePlace
    {
        /// <summary>
        /// Localization applied within the XR experiences.
        /// </summary>
        InExperiences,

        /// <summary>
        /// Localization applied within the application launcher/hub.
        /// </summary>
        InLauncher
    }

    /// <summary>
    /// Provides conversion utility methods between <see cref="AvailablePlace"/> and <see cref="LocalizationScope"/>.
    /// </summary>
    public static class LocalizationScopeCompat
    {
        /// <summary>
        /// Converts an <see cref="AvailablePlace"/> value to its corresponding <see cref="LocalizationScope"/>.
        /// </summary>
        /// <param name="place">The <see cref="AvailablePlace"/> value to convert.</param>
        /// <returns>The corresponding <see cref="LocalizationScope"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the place value is not recognized.</exception>
        public static LocalizationScope ToLocalizationScope(this AvailablePlace place)
        {
            return place switch
            {
                AvailablePlace.InExperiences => LocalizationScope.InExperiences,
                AvailablePlace.InLauncher => LocalizationScope.InLauncher,
                _ => throw new ArgumentOutOfRangeException(nameof(place), place, null)
            };
        }

        /// <summary>
        /// Converts a <see cref="LocalizationScope"/> value to its corresponding <see cref="AvailablePlace"/>.
        /// </summary>
        /// <param name="scope">The <see cref="LocalizationScope"/> value to convert.</param>
        /// <returns>The corresponding <see cref="AvailablePlace"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the scope value is not recognized.</exception>
        public static AvailablePlace ToAvailablePlace(this LocalizationScope scope)
        {
            return scope switch
            {
                LocalizationScope.InExperiences => AvailablePlace.InExperiences,
                LocalizationScope.InLauncher => AvailablePlace.InLauncher,
                _ => throw new ArgumentOutOfRangeException(nameof(scope), scope, null)
            };
        }
    }
}