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
    /// <summary>
    /// Stores reference information for a single asset within an XRMOD package.
    /// Used at runtime to map asset names to their actual Unity Objects for easy retrieval by name.
    /// </summary>
    public class AssetReferenceData : ScriptableObject
    {
        /// <summary> The unique name or identifier of the asset within the package. </summary>
        public string AssetName;
        /// <summary> The fully qualified type name of the asset (e.g., UnityEngine.GameObject). </summary>
        [HideInInspector] public string AssetType;
        /// <summary> The actual Unity Object reference, populated at runtime via the loading system. </summary>
        [HideInInspector] public UnityEngine.Object Asset;
    }
}