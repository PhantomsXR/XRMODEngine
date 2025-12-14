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

namespace Phantom.XRMOD.Localization.Runtime
{
    public static class LocalizedStringKeyExtension
    {
        /// <summary>
        /// Get the localized string from specified localization module.
        /// </summary>
        /// <param name="_key">The localization key.</param>
        /// <param name="_module">Specified localization module.</param>
        /// <returns>The localized string.</returns>
        public static string Localized(this string _key, LocalizationModule _module)
        {
            return _module == null ? string.Empty : _module.GetLocalizedString(_key);
        }

        /// <summary>
        /// Get the localized string from LocalizationManager.
        /// </summary>
        /// <param name="_key">The localization key.</param>
        /// <param name="_localizationScope">Workspace</param>
        /// <returns>The localized string.</returns>
        public static string Localized(this string _key, LocalizationScope _localizationScope = LocalizationScope.InExperiences)
        {
            return LocalizationManager.Instance.GetLocalizedString(_key, _localizationScope);
        }

        /// <summary>
        ///  Get the localized string from LocalizationManager.
        ///  But you can modify at runtime.
        /// </summary>
        /// <param name="_key">The localization key.</param>
        /// <param name="_dynamicValue">The dynamic value from script</param>
        /// <param name="_localizationScope">Workspace</param>
        /// <returns>The localized string with your dynamic value.</returns>
        public static string Localized(this string _key, string _dynamicValue,
            LocalizationScope _localizationScope = LocalizationScope.InExperiences)
        {
            return string.Format(LocalizationManager.Instance.GetLocalizedString(_key, _localizationScope), _dynamicValue);
        }

        /// <summary>
        ///  Get the localized string from LocalizationManager.
        ///  But you can modify at runtime.
        /// </summary>
        /// <param name="_key">The localization key.</param>
        /// <param name="_dynamicValues">The dynamic values from script</param>
        /// <param name="_localizationScope">Workspace</param>
        /// <returns>The localized string with your dynamic values.</returns>
        public static string Localized(this string _key, LocalizationScope _localizationScope = LocalizationScope.InExperiences,
            params object[] _dynamicValues)
        {
            return string.Format(LocalizationManager.Instance.GetLocalizedString(_key, _localizationScope),
                _dynamicValues);
        }
    }
}