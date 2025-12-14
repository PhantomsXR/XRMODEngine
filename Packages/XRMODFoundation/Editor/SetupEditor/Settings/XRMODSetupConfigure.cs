// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using Phantom.XRMOD.Core.Runtime; 
using UnityEngine;

namespace Phantom.XRMOD.Setup.Editor
{
    public class XRMODSetupConfigure : ScriptableObject
    {
        public SDKInformation SDKInformation;
        public List<XRMODEnginePlatformSettings> PlatformSettingValue = new List<XRMODEnginePlatformSettings>();
        public List<string> RuntimePlatformKey = new List<string>();
        public bool Simulation;

        public void OnValidate()
        {
            if (SDKInformation != null) return;
            SDKInformation =
                Resources.Load<SDKInformation>(nameof(SDKInformation));
        }
    }
}