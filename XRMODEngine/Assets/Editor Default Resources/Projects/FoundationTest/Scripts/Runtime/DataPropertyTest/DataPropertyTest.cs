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
using System.Collections.Generic;
using System.Linq;
using LitJson;
using Newtonsoft.Json;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Core.Runtime.Attribute;
using UnityEngine;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public class DataPropertyTest : XRMODBehaviour
    {
        [DataProperty] public CustomDataPropertyTest CustomDataPropertyTest;
        [DataProperty] public List<CustomDataPropertyTest> CustomDataPropertyTestList;
        [DataProperty] public CustomDataPropertyPack CustomDataPropertyPack;
        [DataProperty] public List<HammerPose> HammerPoseList;
        [DataProperty, SerializeField] private List<HammerPose> HammerPoseListPrivate;
        [DataProperty, SerializeField] protected List<HammerPose> HammerPoseListProtected;
        [DataProperty, SerializeField] internal List<HammerPose> HammerPoseListInternal;

        private void Start()
        {
            Assert.AreEqual(CustomDataPropertyTest.Id, 1);
            Assert.AreEqual(CustomDataPropertyTest.Name, "NSWell2");
            Assert.AreEqual(CustomDataPropertyTest.Score, 100);
            Assert.AreEqual(CustomDataPropertyTest.Rect, new Rect(0, 0, 1, 0));
            Assert.AreEqual(CustomDataPropertyTest.r.x, 0);
            Assert.AreEqual(Mathf.CeilToInt(CustomDataPropertyTest.r.y), Mathf.CeilToInt(0.87160f));
            Assert.AreEqual(CustomDataPropertyTest.r.z, 0);
            Assert.AreEqual(Mathf.CeilToInt(CustomDataPropertyTest.r.w), Mathf.CeilToInt(0.99619f));
            Assert.AreEqual(CustomDataPropertyTest.P, new Vector3(1, 0, 0));
            Assert.AreEqual(CustomDataPropertyTest.Colors[0], Color.white);
            Assert.AreEqual(CustomDataPropertyTest.Position[0], Vector3.zero);
            Assert.AreEqual(CustomDataPropertyTest.Quaternions[0], Quaternion.identity);
            Assert.AreEqual(CustomDataPropertyTest.Rects[0], Rect.zero);
            Assert.AreEqual(CustomDataPropertyTest.Vector3Array[0], Vector3.zero);
            Assert.AreEqual(CustomDataPropertyTest.Float, 23.25f);
            Assert.AreEqual(CustomDataPropertyTestList.FirstOrDefault().Rect, Rect.zero);
            Assert.AreEqual(CustomDataPropertyPack.Id, "TestID");
            Assert.AreEqual(CustomDataPropertyPack.CustomDataPropertyTest.Id, 1);
            Assert.AreEqual(CustomDataPropertyPack.CustomDataPropertyTest.Name, string.Empty);
            Assert.AreEqual(CustomDataPropertyPack.CustomDataPropertyTestList.FirstOrDefault().Name, "Name1");
            Assert.AreEqual(CustomDataPropertyPack.CustomDataPropertyTestList.Count, 2);
            Assert.AreEqual(HammerPoseListPrivate.Count, 1);
            Assert.AreEqual(HammerPoseListProtected.Count, 1);
            Assert.AreEqual(HammerPoseListInternal.Count, 1);
            Assert.AreEqual(HammerPoseList.Count, 1);
            Debug.Log($"<color=green>{nameof(DataPropertyTest)} Test passed!</color>");
        }
    }

    [System.Serializable]
    public class CustomDataPropertyPack
    {
        public string Id;
        public CustomDataPropertyTest CustomDataPropertyTest;
        public List<CustomDataPropertyTest> CustomDataPropertyTestList;
    }
}