// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Runtime
{
    public class AssetReferenceData : ScriptableObject
    {
        public string AssetName;
        [HideInInspector] public string AssetType;
        [HideInInspector] public UnityEngine.Object Asset;
    }
}