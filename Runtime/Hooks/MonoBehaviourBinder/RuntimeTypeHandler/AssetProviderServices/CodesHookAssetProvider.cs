// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public class CodesHookAssetProvider : IAssetProvider
    {
        public T GetAsset<T>(string _projectName, string _assetName) where T : Object
        {
            if (CodesHook.AssetReferences.TryGetValue(_projectName, out var tmp_AssetReferenceDb))
            {
                tmp_AssetReferenceDb.GetAssetReference(_assetName, out T tmp_Asset);
                return tmp_Asset;
            }

            return null;
        }

        public T[] GetAssets<T>(string _projectName, string[] _assetNames) where T : Object
        {
            if (CodesHook.AssetReferences.TryGetValue(_projectName, out var tmp_AssetReferenceDatabase))
            {
                tmp_AssetReferenceDatabase.GetAssetReferences(_assetNames, out T[] tmp_Assets);
                return tmp_Assets;
            }

            return null;
        }
    }
}