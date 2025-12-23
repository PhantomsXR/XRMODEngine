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

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    /// <summary>
    /// Represents a handler that can process a notification.
    /// Supports both synchronous and asynchronous invocation.
    /// </summary>
    public interface INotificationHandler
    {
        /// <summary>
        /// Gets the name of the notification this handler processes.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Invokes the handler synchronously.
        /// </summary>
        /// <param name="_data">The notification data.</param>
        /// <param name="_results">A list to collect results from multiple handlers.</param>
        void Invoke(BaseNotificationData _data, List<object> _results);

        /// <summary>
        /// Invokes the handler asynchronously.
        /// </summary>
        /// <param name="_data">The notification data.</param>
        /// <param name="_results">A list to collect results from multiple handlers.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task InvokeAsync(BaseNotificationData _data, List<object> _results);
    }
}