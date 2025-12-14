// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.MixedRealityUtilities.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    public class XRMODAnchor : MonoBehaviour
    {
        public Guid Uuid;
    }
    
    [System.Serializable]
    public class LoadEnvironmentParameters
    {
        public string MapName;
        public string ProcessId;
    }
}