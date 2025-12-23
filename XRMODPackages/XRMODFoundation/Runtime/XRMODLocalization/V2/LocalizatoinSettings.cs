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
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Configuration settings for the localization system, including supported languages and default scope.
    /// </summary>
    [Icon("Packages/com.phantomsxr.foundation/Editor/XRMODLocalization/Assets/Icons/SettingIcon.png")]
    public class LocalizatoinSettings : ScriptableObject
    {
        /// <summary> The list of languages supported by the project. </summary>
        public List<SystemLanguage> SupportLanguages = new List<SystemLanguage>()
        {
            SystemLanguage.English,
            SystemLanguage.ChineseSimplified
        };

        /// <summary> The default localization scope. </summary>
        public LocalizationScope LocalizationScope;
    }
}