// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if FUSION2
using Fusion;
using Phantom.XRMOD.ActionNotification.Runtime;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public abstract class OnEventFusionBaseArgs:OnEventBaseArgs
    {
        public NetworkRunner Runner;
    }
}
#endif