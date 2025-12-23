// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/


using System.Collections.Generic; 
using UnityEngine.Build.Pipeline;

namespace Phantom.XRMOD.XRMODPackageTools.Runtime
{
    /// <summary>
    /// Data structure representing the contents and metadata of an XR experience package (Asset Bundle).
    /// Contains mapping information, packing modes, and build details.
    /// </summary>
    [System.Serializable]
    public class XRExperienceData
    {
        /// <summary> The name of the Unity Asset Bundle file. </summary>
        public string BundleName;
        /// <summary> The packing mode used for this package (e.g., Asset only vs Asset + Scene). </summary>
        public PackModeType PackMode;
        /// <summary> A list of addressable names for the assets within the bundle. </summary>
        public List<string> AddressableName;
        /// <summary> A list of physical asset names (paths) within the bundle. </summary>
        public List<string> AssetsName;
        /// <summary> Detailed build information for the bundle. </summary>
        public BundleDetails BundleDetails;


        /// <summary> Specifies how the experience assets were packed. </summary>
        public enum PackModeType
        {
            /// <summary> Only individual assets are included. </summary>
            AssetOnly,
            /// <summary> Both assets and scene files are included. </summary>
            AssetAndScene
        }

        /// <summary>
        /// Clears all data within the experience data structure.
        /// </summary>
        public void CleanUp()
        {
            BundleName = null;
            AddressableName?.Clear();
            AssetsName?.Clear();
            BundleDetails.FileName = null;
            BundleDetails.Crc = 0;
            BundleDetails.Dependencies = null;
        }
    }
}