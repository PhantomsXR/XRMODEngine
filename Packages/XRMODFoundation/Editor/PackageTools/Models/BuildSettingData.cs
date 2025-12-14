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

using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    [System.Serializable]
    public class BuildSettingData : ScriptableObject
    {
        public BuildTargetGroup BuildTargetGroup = Utility.GetBuildTargetGroup();
        public BuildTarget BuildTarget = Utility.GetBuildTarget();
        public BuildCompressionType BuildCompression = BuildCompressionType.LZ4;
        public bool AutoConvertOptions = false;
    }

    public enum BuildCompressionType
    {
        Uncompressed,
        LZ4,
        LZMA,
        UncompressedRuntime,
        LZ4Runtime
    }
}