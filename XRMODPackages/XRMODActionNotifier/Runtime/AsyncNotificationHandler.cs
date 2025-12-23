// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.ActionNotification.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    /// <summary>
    /// Asynchronous implementation of INotificationHandler.
    /// </summary>
    public class AsyncNotificationHandler: INotificationHandler
    {
        private readonly Func<BaseNotificationData, Task<object>> _asyncFunc;
        public string Name { get; }

        public AsyncNotificationHandler(string name, Func<BaseNotificationData, Task<object>> asyncFunc)
        {
            Name = name;
            _asyncFunc = asyncFunc;
        }

        public void Invoke(BaseNotificationData data, List<object> results)
        {
            // 忽略同步调用
        }

        public async Task InvokeAsync(BaseNotificationData data, List<object> results)
        {
            if (_asyncFunc != null)
                results.Add(await _asyncFunc(data));
        }
    }
}