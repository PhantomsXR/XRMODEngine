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

using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    public static class LocalizedAssetLoader
    {
        public static async System.Threading.Tasks.Task<T> LoadAsync<T>(
            string _key,
            SystemLanguage _lang,
            string _projectName,
            LocalizationScope _scope,
            string _langKey
        ) where T : UnityEngine.Object
        {
            if (_scope == LocalizationScope.InLauncher)
            {
                return Resources.Load<T>(_langKey);
            }

            // InExperience
            return await BasePackageLoaderUtility.LoadAssetFromPackage<T>(_projectName, _langKey);
        }
    }
}