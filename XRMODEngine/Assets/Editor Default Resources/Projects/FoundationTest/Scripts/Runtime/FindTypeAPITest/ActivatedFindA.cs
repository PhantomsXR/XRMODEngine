// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Core.Runtime;
using UnityEngine;

namespace FoundationTest.Runtime
{
    public class ActivatedFindA : XRMODBehaviour
    {
        private Transform selfTransform;

        private void Awake()
        {
            if (!enabled) return;
            selfTransform = transform;
        }
    }
}