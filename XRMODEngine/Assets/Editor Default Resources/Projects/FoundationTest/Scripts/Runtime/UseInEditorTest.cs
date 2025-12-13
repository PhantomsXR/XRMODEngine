// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Threading.Tasks;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Localization.Runtime;
using UnityEngine;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public class UseInEditorTest : XRMODBehaviour
    {
        public async void Start()
        {
            Assert.IsNotNull(SharedData.GetInstance.localizationManager);
            await Task.Delay(1000);
            Debug.Log("Matching_Title".Localized());
        }
    }
}