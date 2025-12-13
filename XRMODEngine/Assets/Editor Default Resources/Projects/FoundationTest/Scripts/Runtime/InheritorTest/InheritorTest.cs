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
    public interface IHitable
    {
        void Print(string _tagetName);
    }



    public class InheritorTest : InhertiorBase
    {
        protected override void Awake()
        {
            if (!enabled) return;
            Assert.AreEqual(Name, "Hello");
            base.Awake();
            Assert.AreEqual(Name, nameof(InhertiorBase));
            Debug.Log($"<color=green>{nameof(InheritorTest)} Test passed!</color>");
        }

        private void Update()
        {
            Collider[] tmp_Colliders = new Collider[2];

            var tmp_OverlapCount =
                Physics.OverlapSphereNonAlloc(transform.position, 1.5f, tmp_Colliders, layerMask);
            for (int tmp_Idx = 0; tmp_Idx < tmp_OverlapCount; tmp_Idx++)
            {
                var tmp_Target = tmp_Colliders[tmp_Idx];
                if (tmp_Target != null)
                    Debug.Log(tmp_Colliders[tmp_Idx].name);
            }
        }
    }
}