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
    [Icon("Packages/com.phantomsxr.foundation/Editor/XRMODLocalization/Assets/Icons/LocalizationDatabase.png")]
    public class LocalizationDatabase : ScriptableObject
    {
        public List<LocalizationTable> Tables = new();
        public LocalizatoinSettings LocalizatoinSettings;

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