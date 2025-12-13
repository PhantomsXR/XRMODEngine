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
using Phantom.XRMOD.Core.Runtime.Attribute;

namespace FoundationTest.Runtime.UserInterface
{
    public abstract class UIViewBase : XRMODBehaviour
    {
     
        public abstract void OnOpen(object _args = null);

        public abstract void OnClose();

        public abstract void OnFocus(bool _isFocus);

        public abstract void OnUpdate(float _deltaTime);
    }
}