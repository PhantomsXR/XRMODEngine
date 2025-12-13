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

namespace FoundationTest.Runtime
{
    public class CreatePearLogic : XRMODBehaviour
    {
        public GameObject PearPrefab;

        private void Start()
        {
            for (int tmp_Idx = 0; tmp_Idx < 10; tmp_Idx++)
            {
                CreatePear();
            }
        }

        private void CreatePear()
        {
            var tmp_RandomPosition = UnityEngine.Random.insideUnitCircle * 5;
            var tmp_PearInstance = Object.Instantiate(PearPrefab);
            tmp_PearInstance.transform.SetPositionAndRotation(
                new Vector3(tmp_RandomPosition.x, 0, tmp_RandomPosition.y), Quaternion.identity);
        }
    }
}