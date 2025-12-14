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

using System;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public interface IRuntimeAssetTypeHandler
    { 
        object ProcessValue(IAssetProvider _assetProvider, string _projectName, string[] _loadAssetNames);
        object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName);
    }

    public abstract class BaseRuntimeAssetTypeHandler<T> : IRuntimeAssetTypeHandler where T : UnityEngine.Object
    { 
        public abstract object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames);

        public abstract object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName);
    }
}