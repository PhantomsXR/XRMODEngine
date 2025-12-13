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

using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public class PlayerBase : XRMODBehaviour, IDamage
    {
        internal void Init()
        {
            var tmp_ChildNote = GetComponentInChildren<ChildNoteComponent>();
            Assert.IsNotNull(tmp_ChildNote, "tmp_ChildNote != null");

            var tmp_Comps = GetComponentsInChildren<XRMODBehaviour>();
            Assert.AreEqual(tmp_Comps.Length, 3);
        }

        public void Damage(float _damage)
        {
            Assert.AreEqual(_damage, -10);
        }
    }
}