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
using System.Collections.Generic;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public class GetComponentInChildrenAPITest : XRMODBehaviour
    {
        private List<TestInterfaceComponent> TestInterfaceComponents = new List<TestInterfaceComponent>();
        private List<Transform> childTransform = new List<Transform>();

        private void Start()
        {
            Assert.AreEqual(gameObject.GetComponentsInChildren<ChildComponent>().Length, 2);
            Assert.AreEqual(gameObject.GetComponentsInChildren<ChildComponent>(true).Length, 3);
            Assert.AreEqual(gameObject.GetComponentsInChildren(typeof(ChildComponent)).Length, 2);
            Assert.AreEqual(gameObject.GetComponentsInChildren(typeof(ChildComponent), true).Length, 3);
            Assert.AreEqual(transform.GetComponentsInChildren<ChildComponent>().Length, 2);
            Assert.AreEqual(transform.GetComponentsInChildren<ChildComponent>(true).Length, 3);
            Assert.AreEqual(transform.GetComponentsInChildren(typeof(ChildComponent)).Length, 2);
            Assert.AreEqual(transform.GetComponentsInChildren(typeof(ChildComponent), true).Length, 3);

            childTransform.AddRange(transform.GetComponentsInChildren<Transform>());
            Assert.AreEqual(childTransform.Count, 4);

            List<Transform> tmp_Transforms = new List<Transform>();
            tmp_Transforms.AddRange(transform.GetComponentsInChildren<Transform>());

            var tmp_Components = transform.GetComponentsInChildren<TestInterfaceComponent>();
            Assert.AreEqual(tmp_Components.Length,2);
            TestInterfaceComponents.Add(tmp_Components[0]);
            Assert.AreEqual(TestInterfaceComponents.Count, 1);
            TestInterfaceComponents.Clear();
            TestInterfaceComponents.AddRange(tmp_Components);
            Assert.AreEqual(TestInterfaceComponents.Count, 2);


            Debug.Log($"<color=green>{nameof(GetComponentInChildrenAPITest)} Test passed!</color>");
        }
    }
}