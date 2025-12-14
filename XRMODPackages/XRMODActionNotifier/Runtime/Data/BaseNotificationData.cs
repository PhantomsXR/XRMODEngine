// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/


using System;
using System.Threading.Tasks;

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    public class BaseNotificationData : IDisposable
    {
        /// <summary>
        /// Callback without return data. Execute after receiving notification message
        /// </summary>
        public Action NotificationAct;

        /// <summary>
        /// Callback with return data. Execute after received notification message 
        /// </summary>
        public Action<object> NotificationActWithData;
        
        public Func<BaseNotificationData, Task<object>> NotificationAsyncWithData;

        /// <summary>
        /// Type of action
        /// </summary>
        public string ActionName;

        /// <summary>
        /// meta data
        /// </summary>
        public string BaseData;

        /// <summary>
        /// Universal data
        /// </summary>
        public Object ObjectData;

        public virtual void Dispose()
        {
            NotificationAct = null;
            ActionName = null;
            BaseData = null;
            NotificationAsyncWithData = null;
        }
    }
}