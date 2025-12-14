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
    [System.Serializable]
    public class XRExperienceData
    {
        public string BundleName;
        public PackModeType PackMode;
        public List<string> AddressableName;
        public List<string> AssetsName;
        public BundleDetails BundleDetails;


        public enum PackModeType
        {
            AssetOnly,
            AssetAndScene
        }

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