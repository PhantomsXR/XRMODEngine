// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VisionOSModule.Runtime.
// //
// // The AVPPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;
using UnityEngine.InputSystem.Utilities;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public interface Interactor
    {
        void ExecuteInteraction(ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Touch> _touches);
    }
}