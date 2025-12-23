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

using System.Collections.Generic;
using System.Linq;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// A ScriptableObject that stores a collection of localization tables and settings.
    /// Acts as the primary database for internationalization data within XRMOD.
    /// </summary>
    [Icon("Packages/com.phantomsxr.foundation/Editor/XRMODLocalization/Assets/Icons/LocalizationDatabase.png")]
    public class LocalizationDatabase : ScriptableObject
    {
        /// <summary>
        /// A list of localization tables, separated by scope and platform.
        /// </summary>
        public List<LocalizationTable> Tables = new();

        /// <summary>
        /// Settings related to the localization process and behavior.
        /// </summary>
        public LocalizatoinSettings LocalizatoinSettings;

        /// <summary>
        /// Retrieves a localized string based on the provided key, language, scope, and platform.
        /// </summary>
        /// <param name="_key">The localization key to look up.</param>
        /// <param name="_language">The desired language.</param>
        /// <param name="_scope">The scope of the localization (e.g., InExperiences, Global).</param>
        /// <param name="_platform">The XRMOD runtime platform.</param>
        /// <returns>The localized string if found; otherwise, returns the original <paramref name="_key"/>.</returns>
        public string GetLocalizedString(string _key, SystemLanguage _language, LocalizationScope _scope,
            XRMODPlatform _platform)
        {
            var tmp_Table = Tables.FirstOrDefault(t => t.Scope == _scope && t.Platform == _platform);
            if (tmp_Table == null) return _key;
            var tmp_Entry = tmp_Table.Entries.FirstOrDefault(e => e.Key == _key);
            return tmp_Entry == null ? _key : tmp_Entry.Get(_language);
        }
    }
}