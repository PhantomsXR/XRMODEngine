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
    public class LocalizedTemplate
    {
        private string template;

        public LocalizedTemplate(LocalizationDatabase _db, string _key, SystemLanguage _lang, LocalizationScope _scope,
            XRMODPlatform _platform)
        {
            template = _db.GetLocalizedString(_key, _lang, _scope, _platform);
        }

        public string GetString() => template;

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