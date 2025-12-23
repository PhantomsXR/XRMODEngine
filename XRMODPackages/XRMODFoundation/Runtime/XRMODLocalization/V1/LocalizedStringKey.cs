/*===============================================================================
Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The Localization cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Provides extension methods for strings to easily retrieve localized versions 
    /// from various localization scopes and modules.
    /// </summary>
    public static class LocalizedStringKeyExtension
    {
        /// <summary>
        /// Retrieves the localized version of this string from a specific <see cref="LocalizationModule"/>.
        /// </summary>
        /// <param name="_key">The localization key.</param>
        /// <param name="_module">The localization module to search in.</param>
        /// <returns>The localized string if found; otherwise, an empty string.</returns>
        public static string Localized(this string _key, LocalizationModule _module)
        {
            return _module == null ? string.Empty : _module.GetLocalizedString(_key);
        }

        /// <summary>
        /// Retrieves the localized version of this string from the <see cref="LocalizationManager"/> using a specific scope.
        /// </summary>
        /// <param name="_key">The localization key.</param>
        /// <param name="_localizationScope">The localization scope to search in. Defaults to <see cref="LocalizationScope.InExperiences"/>.</param>
        /// <returns>The localized string.</returns>
        public static string Localized(this string _key, LocalizationScope _localizationScope = LocalizationScope.InExperiences)
        {
            return LocalizationManager.Instance.GetLocalizedString(_key, _localizationScope);
        }

        /// <summary>
        /// Retrieves the localized version of this string and formats it with a dynamic value.
        /// </summary>
        /// <example>
        /// <code>
        /// "Hello {0}".Localized("World", LocalizationScope.InExperiences); // Returns "Hello World" (localized)
        /// </code>
        /// </example>
        /// <param name="_key">The localization key (which should contain a format placeholder like {0}).</param>
        /// <param name="_dynamicValue">The value to insert into the localized string format.</param>
        /// <param name="_localizationScope">The localization scope to search in.</param>
        /// <returns>The localized and formatted string.</returns>
        public static string Localized(this string _key, string _dynamicValue,
            LocalizationScope _localizationScope = LocalizationScope.InExperiences)
        {
            return string.Format(LocalizationManager.Instance.GetLocalizedString(_key, _localizationScope), _dynamicValue);
        }

        /// <summary>
        /// Retrieves the localized version of this string and formats it with multiple dynamic values.
        /// </summary>
        /// <param name="_key">The localization key (which should contain multiple format placeholders).</param>
        /// <param name="_localizationScope">The localization scope to search in.</param>
        /// <param name="_dynamicValues">The values to insert into the localized string format.</param>
        /// <returns>The localized and formatted string.</returns>
        public static string Localized(this string _key, LocalizationScope _localizationScope = LocalizationScope.InExperiences,
            params object[] _dynamicValues)
        {
            return string.Format(LocalizationManager.Instance.GetLocalizedString(_key, _localizationScope),
                _dynamicValues);
        }
    }
}