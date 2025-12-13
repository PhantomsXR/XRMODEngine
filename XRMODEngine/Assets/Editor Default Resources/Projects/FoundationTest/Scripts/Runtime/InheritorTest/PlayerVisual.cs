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

using System;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public class PlayerVisual : XRMODBehaviour
    {
        [SerializeField] private PlayerBase playerBase;
        [SerializeField] private Player player;

        private void Start()
        {
            Assert.IsNotNull(playerBase);
            Assert.IsNotNull(player);
        }
    }
}