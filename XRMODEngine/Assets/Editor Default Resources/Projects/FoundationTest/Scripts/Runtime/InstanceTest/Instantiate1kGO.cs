// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using Object = UnityEngine.Object;

namespace FoundationTest.Runtime.InstanceTest
{
    public class Instantiate1kGO:XRMODBehaviour
    {
        public GameObject go;

        private void Start()
        {
            for (int tmp_Idx = 0; tmp_Idx < 1000; tmp_Idx++)
            {
                Object.Instantiate(go).name += $"{tmp_Idx}";
            }
        }
    }
}