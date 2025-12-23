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
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Represents a collection of localization entries for a specific scope and platform.
    /// This ScriptableObject allows for organized translation data management.
    /// </summary>
    [Icon("Packages/com.phantomsxr.foundation/Editor/XRMODLocalization/Assets/Icons/LocalizationDatabase.png")]
    public class LocalizationTable : ScriptableObject
    {
        /// <summary> The scope (launcher or experience) this table applies to. </summary>
        public LocalizationScope Scope;
        /// <summary> The runtime platform this table is optimized for. </summary>
        public XRMODPlatform Platform;
        /// <summary> The list of localization entries within this table. </summary>
        public List<LocalizationEntry> Entries = new();


        /// <summary>
        /// Retrieves the localized string for a given key and language.
        /// </summary>
        /// <param name="_key">The localization key.</param>
        /// <param name="_lang">The target language.</param>
        /// <returns>The localized string if found; otherwise, null.</returns>
        public string Get(string _key, SystemLanguage _lang)
        {
            var tmp_Entry = Entries.Find(_localizationEntry => _localizationEntry.Key == _key);
            return tmp_Entry?.Get(_lang);
        }
    }
}