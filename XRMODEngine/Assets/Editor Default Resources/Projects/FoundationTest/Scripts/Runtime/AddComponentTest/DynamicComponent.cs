// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The UnityVisionOSLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Core.Runtime;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public class DynamicComponent : XRMODBehaviour
    {
        public int Health = 100;

        private void Start()
        {
            Assert.AreEqual(Health, 100);
        }
    }
}