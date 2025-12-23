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
    /// <summary>
    /// Static utility class for asynchronously loading localized assets (like prefabs or textures) 
    /// from either Unity Resources or XRMOD asset bundles.
    /// </summary>
    public static class LocalizedAssetLoader
    {
        /// <summary>
        /// Asynchronously loads a localized asset of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of asset to load (must be a Unity Object).</typeparam>
        /// <param name="_key">The localization key (not used directly for asset loading here, but passed for context).</param>
        /// <param name="_lang">The desired language.</param>
        /// <param name="_projectName">The name of the XRMOD project (for in-experience loading).</param>
        /// <param name="_scope">The localization scope (InLauncher or InExperience).</param>
        /// <param name="_langKey">The actual resource path or asset name to load.</param>
        /// <returns>A task representing the asynchronous load operation, yielding the asset.</returns>
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