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
    public class SyncNotificationHandler : INotificationHandler
    {
        private readonly Action<BaseNotificationData> _action;
        private readonly Func<BaseNotificationData, object> _func;
        public string Name { get; }

        public SyncNotificationHandler(string name, Action<BaseNotificationData> action)
        {
            Name = name;
            _action = action;
        }

        public SyncNotificationHandler(string name, Func<BaseNotificationData, object> func)
        {
            Name = name;
            _func = func;
        }

        public void Invoke(BaseNotificationData data, List<object> results)
        {
            _action?.Invoke(data);
            if (_func != null) results.Add(_func(data));
        }

        public Task InvokeAsync(BaseNotificationData data, List<object> results)
        {
            Invoke(data, results);
            return Task.CompletedTask;
        }
    }
}