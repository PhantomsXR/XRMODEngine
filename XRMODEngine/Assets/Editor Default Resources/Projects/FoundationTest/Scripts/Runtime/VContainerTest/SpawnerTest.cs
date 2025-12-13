// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine.Assertions;
using VContainer;

namespace FoundationTest.Runtime
{
    public class SpawnerTest : XRMODBehaviour
    {
        [Inject] public int[] valueArray;
        private SpawnTargetData spawnTargetData;
        [Inject] public SpawnTeset2 spawnTest2;

        [Inject]
        public void Init(SpawnTargetData _data)
        {
            spawnTargetData = _data;
        }

        private void Start()
        {
            Assert.AreEqual(spawnTargetData.TargetTypeSize, 1);
            Assert.AreEqual(valueArray.Length, 3);
            Assert.IsNotNull(spawnTest2);
        }
    }
}