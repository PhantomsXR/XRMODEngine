// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/


namespace Phantom.XRMOD.ActionNotification.Runtime
{
#if UNITY_6000 && !UNITY_EDITOR
    public class OpenBuiltInArgs : BaseNotificationData
    {
        public string Url;
        public string Data;
    }
#endif

    public class OpenInBuiltInBrowserArgs : BaseNotificationData
    {
        public string Url;
        public string Data;
    }
}