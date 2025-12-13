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
    public class RefAssetsTest : XRMODBehaviour
    {
        public string Name;
        public GameObject RuntimeLoadPrefabTest;
        public GameObject RuntimeLoadPrefabTest2;
        public Sprite RuntimeLoadSprite1;
        public Sprite RuntimeLoadSprite2;
        public float Progress;
        [SerializeField] private List<GameObject> refList;
        [SerializeField] private GameObject[] refArray;
        public GameObject[] RefArray;
        public List<GameObject> RefList;
        public Sprite[] RefSpriteArray;
        public Texture2D[] RefT2dArray;

        private void Start()
        {
            Assert.AreEqual(Name, "TOM");
            Assert.AreEqual(Progress, 10521.25f);
            Assert.IsNotNull(RuntimeLoadPrefabTest);
            Assert.IsNotNull(RuntimeLoadPrefabTest2);
            Assert.IsNotNull(RuntimeLoadSprite1);
            Assert.IsNotNull(RuntimeLoadSprite2);
            Assert.AreEqual(refList.Count, 2);
            Assert.AreEqual(refList.Count, refArray.Length);
            Assert.AreEqual(RefList.Count, 2);
            Assert.AreEqual(refList.Count, RefArray.Length);
            Assert.AreEqual(RefSpriteArray.Length, 1);
            Assert.AreEqual(RefT2dArray.Length, 1);
            Debug.Log($"<color=green>{nameof(RefAssetsTest)} Test passed!</color>");
        }
    }
}