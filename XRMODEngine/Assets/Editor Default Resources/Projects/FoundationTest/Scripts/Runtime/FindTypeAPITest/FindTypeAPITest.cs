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
 
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public class FindTypeAPITest : XRMODBehaviour
    {
        private ActivatedFindA nonPTypeFind;
        private ActivatedFindA OnePTypeFind;
        private ActivatedFindA OPTFind;
        private ActivatedFindA[] OPTFinds;
        private DeactivatedFindB OnePTFind;
        private DeactivatedFindB[] OnePTFinds;
        private DeactivatedFindB[] deactivatedFindBs;

        private void Start()
        {
            #region FindObjectOfType

            nonPTypeFind = FindObjectOfType(typeof(ActivatedFindA)) as ActivatedFindA;
            Assert.IsNotNull(nonPTypeFind);

            OnePTFind = FindObjectOfType(typeof(DeactivatedFindB), true) as DeactivatedFindB;
            Assert.IsNotNull(OnePTFind);

            OPTFind = FindObjectOfType<ActivatedFindA>();
            Assert.IsNotNull(OPTFind);

            OnePTFind = FindObjectOfType<DeactivatedFindB>();
            Assert.IsNull(OnePTFind);

            var tmp_OPTFind = FindObjectOfType<DeactivatedFindB>(true);
            Assert.IsNotNull(tmp_OPTFind);

            #endregion

            #region FindObjectsOfType

            OPTFinds = FindObjectsOfType(typeof(ActivatedFindA)) as ActivatedFindA[];
            Assert.AreEqual(OPTFinds.Length, 1);
            OnePTFinds = null;
            OPTFinds = null;
            OnePTFinds = FindObjectsOfType(typeof(DeactivatedFindB), true) as DeactivatedFindB[];
            Assert.AreEqual(OnePTFinds.Length, 1);
            OnePTFinds = null;
            OPTFinds = null;
            OPTFinds = FindObjectsOfType<ActivatedFindA>();
            Assert.AreEqual(OPTFinds.Length, 1);
            OnePTFinds = null;
            OPTFinds = null;
            OnePTFinds = FindObjectsOfType<DeactivatedFindB>();
            Assert.AreEqual(OnePTFinds.Length, 0);
            OnePTFinds = null;
            OPTFinds = null;
            OnePTFinds = FindObjectsOfType<DeactivatedFindB>(true);
            Assert.AreEqual(OnePTFinds.Length, 1);

            #endregion

            #region FindFirstObjectByType

            OnePTFind = FindFirstObjectByType<DeactivatedFindB>();
            Assert.IsNull(OnePTFind);

            OnePTFind = FindFirstObjectByType<DeactivatedFindB>(FindObjectsInactive.Include);
            Assert.IsNotNull(OnePTFind);

            OnePTFind = FindFirstObjectByType<DeactivatedFindB>();
            Assert.IsNull(OnePTFind);

            OnePTFind = FindFirstObjectByType(typeof(DeactivatedFindB)) as DeactivatedFindB;
            Assert.IsNull(OnePTFind);

            OnePTFind = FindFirstObjectByType(typeof(DeactivatedFindB),
                FindObjectsInactive.Include) as DeactivatedFindB;
            Assert.IsNotNull(OnePTFind);

            #endregion


            #region FindAnyObjectByType

            OnePTFind = FindAnyObjectByType<DeactivatedFindB>();
            Assert.IsNull(OnePTFind);

            OnePTFind = FindAnyObjectByType<DeactivatedFindB>(FindObjectsInactive.Include);
            Assert.IsNotNull(OnePTFind);

            OnePTFind = FindAnyObjectByType<DeactivatedFindB>();
            Assert.IsNull(OnePTFind);

            OnePTFind = FindAnyObjectByType(typeof(DeactivatedFindB)) as DeactivatedFindB;
            Assert.IsNull(OnePTFind);

            OnePTFind = FindAnyObjectByType(typeof(DeactivatedFindB),
                FindObjectsInactive.Include) as DeactivatedFindB;
            Assert.IsNotNull(OnePTFind);

            #endregion

            #region FindObjectsByType

            deactivatedFindBs = FindObjectsByType<DeactivatedFindB>(FindObjectsSortMode.InstanceID);
            Assert.AreEqual(deactivatedFindBs.Length, 0);
            deactivatedFindBs = null;
            deactivatedFindBs =
                FindObjectsByType<DeactivatedFindB>(FindObjectsInactive.Include, FindObjectsSortMode.InstanceID);
            Assert.AreNotEqual(deactivatedFindBs.Length, 0);
            deactivatedFindBs = null;
            deactivatedFindBs =
                FindObjectsByType(typeof(DeactivatedFindB), FindObjectsSortMode.None) as DeactivatedFindB[];
            Assert.AreEqual(deactivatedFindBs.Length, 0);
            deactivatedFindBs = null;
            deactivatedFindBs =
                FindObjectsByType(typeof(DeactivatedFindB), FindObjectsInactive.Include, FindObjectsSortMode.None) as
                    DeactivatedFindB[];
            Assert.AreNotEqual(deactivatedFindBs.Length, 0);
            deactivatedFindBs = null;

            #endregion

            Debug.Log($"<color=green>{nameof(FindTypeAPITest)} Test passed!</color>");
        }
    }
}