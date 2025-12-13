// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The UnityRokidLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public class XRMODAPITest : XRMODBehaviour
    {
        private async void Start()
        {
            var tmp_IsRokidLite = SharedData.GetInstance.XRMODAPI.IsPlatform(PlatformType.RokidLite);
            var tmp_IsRokidStudio = SharedData.GetInstance.XRMODAPI.IsPlatform(PlatformType.RokidStudio);
            var tmp_LoadObjNames = new[] {"CubeG1", "CubeG2", "CubeG3", "CubeG4"};
            var tmp_Assets =
                await SharedData.GetInstance.XRMODAPI.LoadAssetsAsync<GameObject>(tmp_LoadObjNames);
 
            for (int tmp_Idx = 0; tmp_Idx < tmp_Assets.Length; tmp_Idx++)
            {
                Assert.AreEqual(tmp_Assets[tmp_Idx].name, tmp_LoadObjNames[tmp_Idx]);
            }


            Debug.Log("-------------------------------------");
            Debug.Log($"Is RokidLite:{tmp_IsRokidLite},Is RokidStudio:{tmp_IsRokidStudio}");
            Debug.Log("-------------------------------------");
        }
    }
}