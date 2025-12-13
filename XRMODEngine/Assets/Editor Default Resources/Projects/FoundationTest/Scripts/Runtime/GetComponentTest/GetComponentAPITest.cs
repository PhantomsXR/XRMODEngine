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
    public class GetComponentAPITest : XRMODBehaviour
    {
        private void Start()
        {
            Assert.IsNotNull(gameObject.GetComponent<Transform>());
            Assert.IsNotNull(gameObject.GetComponent<GetComponentAPITest>());
            Assert.IsNotNull(gameObject.GetComponent(typeof(Transform)));
            Assert.IsNotNull(gameObject.GetComponent(typeof(GetComponentAPITest)));
            
            Assert.IsNotNull(gameObject.GetComponentInChildren<Transform>());
            Assert.IsNotNull(gameObject.GetComponentInChildren<ActivatedFindA>());
            Assert.IsNotNull(gameObject.GetComponentInChildren(typeof(Transform)));
            Assert.IsNotNull(gameObject.GetComponentInChildren(typeof(ActivatedFindA)));
            
            
            Assert.IsNotNull(gameObject.GetComponentInChildren<Transform>(true));
            Assert.IsNotNull(gameObject.GetComponentInChildren<DeactivatedFindB>(true));
            Assert.IsNotNull(gameObject.GetComponentInChildren(typeof(Transform),true));
            Assert.IsNotNull(gameObject.GetComponentInChildren(typeof(DeactivatedFindB),true));
            Assert.IsNull(gameObject.GetComponentInChildren<DeactivatedFindB>(false));
            Assert.IsNull(gameObject.GetComponentInChildren(typeof(DeactivatedFindB),false));
             
            Assert.AreEqual(gameObject.GetComponentsInChildren(typeof(ActivatedFindA)).Length, 1);
            Assert.AreEqual(gameObject.GetComponentsInChildren<ActivatedFindA>().Length, 1);
            Assert.AreEqual(gameObject.GetComponentsInChildren(typeof(DeactivatedFindB),true).Length, 1);
            Assert.AreEqual(gameObject.GetComponentsInChildren<DeactivatedFindB>(true).Length, 1);
            
            
            
            Assert.IsNotNull(transform.GetComponent<Transform>());
            Assert.IsNotNull(transform.GetComponent<GetComponentAPITest>());
            Assert.IsNotNull(transform.GetComponent(typeof(Transform)));
            Assert.IsNotNull(transform.GetComponent(typeof(GetComponentAPITest)));
            
            Assert.IsNotNull(transform.GetComponentInChildren<Transform>());
            Assert.IsNotNull(transform.GetComponentInChildren<ActivatedFindA>());
            Assert.IsNotNull(transform.GetComponentInChildren(typeof(Transform)));
            Assert.IsNotNull(transform.GetComponentInChildren(typeof(ActivatedFindA)));
            
            
            Assert.IsNotNull(transform.GetComponentInChildren<Transform>(true));
            Assert.IsNotNull(transform.GetComponentInChildren<DeactivatedFindB>(true));
            Assert.IsNotNull(transform.GetComponentInChildren(typeof(Transform),true));
            Assert.IsNotNull(transform.GetComponentInChildren(typeof(DeactivatedFindB),true));
            Assert.IsNull(transform.GetComponentInChildren<DeactivatedFindB>(false));
            Assert.IsNull(transform.GetComponentInChildren(typeof(DeactivatedFindB),false));
             
            Assert.AreEqual(transform.GetComponentsInChildren(typeof(ActivatedFindA)).Length, 1);
            Assert.AreEqual(transform.GetComponentsInChildren<ActivatedFindA>().Length, 1);
            Assert.AreEqual(transform.GetComponentsInChildren(typeof(DeactivatedFindB),true).Length, 1);
            Assert.AreEqual(transform.GetComponentsInChildren<DeactivatedFindB>(true).Length, 1);
        }
    }
}