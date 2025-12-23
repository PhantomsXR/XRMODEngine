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

using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// A helper class for managing localized string templates that support argument formatting.
    /// </summary>
    public class LocalizedTemplate
    {
        private string template;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedTemplate"/> class by fetching a localized string.
        /// </summary>
        /// <param name="_db">The localization database.</param>
        /// <param name="_key">The localization key.</param>
        /// <param name="_lang">The desired language.</param>
        /// <param name="_scope">The localization scope.</param>
        /// <param name="_platform">The target platform.</param>
        public LocalizedTemplate(LocalizationDatabase _db, string _key, SystemLanguage _lang, LocalizationScope _scope,
            XRMODPlatform _platform)
        {
            template = _db.GetLocalizedString(_key, _lang, _scope, _platform);
        }

        /// <summary>
        /// Gets the raw, unformatted localized string template.
        /// </summary>
        /// <returns>The localized template string.</returns>
        public string GetString() => template;

        /// <summary>
        /// Formats the localized template using the provided arguments.
        /// </summary>
        /// <param name="_args">The arguments to insert into the template (using <c>string.Format</c> syntax).</param>
        /// <returns>The formatted localized string, or the raw template if formatting fails.</returns>
        public string Format(params object[] _args)
        {
            try
            {
                return string.Format(template, _args);
            }
            catch
            {
                Debug.LogWarning($"Format failed: {template}");
                return template;
            }
        }
    }
}