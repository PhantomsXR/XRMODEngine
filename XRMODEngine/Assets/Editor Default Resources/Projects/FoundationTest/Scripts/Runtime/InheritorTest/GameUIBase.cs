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

using FoundationTest.Runtime.UserInterface;
using Phantom.XRMOD.Core.Runtime.Attribute;

namespace FoundationTest.Runtime
{
    public abstract class GameUIBase:UIViewBase
    {
        [DontConvertToMonoBinder] public string ViewName;
        public bool AutoOpen;
        internal bool IsOpen;


        protected virtual void Awake()
        {
            if (!enabled) return;
        }

    }
}