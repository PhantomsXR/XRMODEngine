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
    public class SerializedFieldTest : XRMODBehaviour
    {
        [SerializeField] private int PrivateSerializedFieldValue = 1;
        [SerializeField] internal int InternalSerializedFieldValue = 1;
        private int m_PrivateSerializedFieldValue = 10;
        public Transform Transform;
        public Renderer Renderer;

        private void Start()
        {
            Assert.AreEqual(PrivateSerializedFieldValue, 2);
            Assert.AreEqual(InternalSerializedFieldValue, 3);
            Debug.Log($"<color=green>{nameof(SerializedFieldTest)} Test passed!</color>");
        }
    }
}