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
    [Icon("Packages/com.phantomsxr.foundation/Editor/XRMODLocalization/Assets/Icons/LocalizationDatabase.png")]
    public class LocalizationTable : ScriptableObject
    {
        public LocalizationScope Scope;
        public XRMODPlatform Platform;
        public List<LocalizationEntry> Entries = new();


        public string Get(string _key, SystemLanguage _lang)
        {
            var tmp_Entry = Entries.Find(_localizationEntry => _localizationEntry.Key == _key);
            return tmp_Entry?.Get(_lang);
        }
    }
}