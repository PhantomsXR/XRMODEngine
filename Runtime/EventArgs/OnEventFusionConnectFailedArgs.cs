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
using Fusion.Sockets;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public class OnEventFusionConnectFailedArgs:OnEventFusionBaseArgs
    {
        public NetAddress Address;
        public NetConnectFailedReason Reason;
    }
}
#endif