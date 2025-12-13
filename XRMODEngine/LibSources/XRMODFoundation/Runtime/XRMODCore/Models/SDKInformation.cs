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


using UnityEngine;
using Phantom.XRMOD.Core.Runtime.Enums;

namespace Phantom.XRMOD.Core.Runtime
{
    [CreateAssetMenu(fileName = "SDKInformation", menuName = "XR-MOD/SDK/SDKInformation", order = 0)]
    public class SDKInformation : ScriptableObject
    {
        public string Version;
        public SDKDeviceType currentSDKDeviceType;
        public GameObject DeviceLauncher;
        public EnvironmentType environmentType = EnvironmentType.Development;
    }

    public enum EnvironmentType
    {
        Development,
        Staging,
        Production
    }
}