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

using System;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public class ByteEnumTest : XRMODBehaviour
    {
        public enum HitableType : byte
        {
            Head,
            Body,
            Props,
            Celling,
            Walls,
            Tables,
            Chairs,
            Obstacles
        }


        public HitableType Hitable;


        private void Start()
        {
            Assert.AreEqual(Hitable, HitableType.Celling);
            Debug.Log($"<color=green>{nameof(ByteEnumTest)} Test passed!</color>");

        }
    }
}