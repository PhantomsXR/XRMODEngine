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

using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public abstract class InhertiorBase : XRMODBehaviour, IHitable
    {
        public string Name;
        public LayerMask layerMask;

        protected virtual void Awake()
        {
            if (!enabled) return;
            Name = nameof(InhertiorBase);
            Assert.AreEqual(layerMask, 7);
        }

        public void Print(string _tagetName)
        {
            Debug.Log($"{_tagetName}->{Name}");
        }
    }
}