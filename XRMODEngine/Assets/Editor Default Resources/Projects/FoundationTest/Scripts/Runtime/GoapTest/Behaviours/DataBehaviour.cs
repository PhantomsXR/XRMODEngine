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

using Phantom.XRMOD.Core.Runtime;
using UnityEngine;

namespace FoundationTest.Runtime
{
    public class DataBehaviour : XRMODBehaviour
    {
        public int pearCount = 0;
        public float hunger = 0f;

        private void Update()
        {
            // For simplicity, we will increase the hunger over time in this class.
            this.hunger += Time.deltaTime * 5f;
        }
    }
}