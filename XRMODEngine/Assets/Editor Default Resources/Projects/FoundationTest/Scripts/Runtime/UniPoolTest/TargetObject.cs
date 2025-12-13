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

namespace FoundationTest.Runtime.UniPoolTest
{
    public class TargetObject : XRMODBehaviour, ITarget
    {
        TargetObjectVisualizer visualizer;

        private void Start()
        {
            visualizer = GetComponent<TargetObjectVisualizer>();
        }
    }
}