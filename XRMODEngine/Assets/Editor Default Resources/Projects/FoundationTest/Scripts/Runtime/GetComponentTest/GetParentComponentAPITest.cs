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
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public class GetParentComponentAPITest : XRMODBehaviour
    {
        private void Start()
        { 
            Assert.IsNotNull(gameObject.GetComponentInParent<Transform>());
            Assert.IsNotNull(gameObject.GetComponentInParent(typeof(Transform)));
            Assert.IsNotNull(gameObject.GetComponentInParent(typeof(Transform), true));
            Assert.IsNotNull(gameObject.GetComponentInParent<Transform>(true));
            Assert.AreEqual(gameObject.GetComponentsInParent<Transform>().Length, 5);
            Assert.AreEqual(gameObject.GetComponentsInParent<Transform>(true).Length, 5);
            Assert.IsNotNull(transform.GetComponentInParent<Transform>());
            Assert.IsNotNull(transform.GetComponentInParent(typeof(Transform)));
            Assert.IsNotNull(transform.GetComponentInParent(typeof(Transform), true));
            Assert.IsNotNull(transform.GetComponentInParent<Transform>(true));
            Assert.AreEqual(transform.GetComponentsInParent<Transform>().Length, 5);
            Assert.AreEqual(transform.GetComponentsInParent<Transform>(true).Length, 5);
            Debug.Log($"<color=green>{nameof(GetParentComponentAPITest)} Test passed!</color>");


        }
    }
}