// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.ActionNotification.Runtime.
// //
// // The ARMOD-DevelopmentKit cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    public class ImmersalMapperArgs:BaseNotificationData
    {
        public bool IsTracking;
        public string Message;
        public float Progress;
        public bool Uploading;
        public bool IsConnected;
    }
}