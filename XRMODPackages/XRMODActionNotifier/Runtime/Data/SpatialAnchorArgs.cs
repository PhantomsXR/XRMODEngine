// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.ActionNotification.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    public class SpatialAnchorArgs : BaseNotificationData
    {
        public ulong TaskId;
        public string Result;
        public ulong AnchorId;
        public Guid Uuid;
        public uint Count;
    }
}