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

using System.Collections.Generic;
using Phantom.XRMOD.ActionNotification.Runtime;

namespace FoundationTest.Runtime.Networks
{
    public class NetworkFactory
    {
        private Dictionary<System.Type, INetworkCallback> callbacks = new()
        {
            {typeof(BaseNotificationData), new OnServerStarted()}
        };

        public void GetCallback(BaseNotificationData _data)
        {
            if (callbacks.TryGetValue(_data.GetType(), out INetworkCallback tmp_Callback))
                tmp_Callback?.Execute();
        }
    }
}