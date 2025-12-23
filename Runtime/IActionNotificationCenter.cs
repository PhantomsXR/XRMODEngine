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


namespace Phantom.XRMOD.ActionNotification.Runtime
{
    /// <summary>
    /// Defines the contract for an action-based notification center.
    /// Supports synchronous and asynchronous notification posting and observing.
    /// </summary>
    /// <typeparam name="T">The type of action or delegate used for observers.</typeparam>
    public interface IActionNotificationCenter<in T>
    {
        /// <summary>
        /// Registers an observer for a specific notification.
        /// </summary>
        /// <param name="_action">The action to execute when the notification is posted.</param>
        /// <param name="_name">The unique identifier for the notification.</param>
        void AddObserver(T _action, string _name);

        /// <summary>
        /// Unregisters a specific observer from a notification.
        /// </summary>
        /// <param name="_name">The unique identifier for the notification.</param>
        /// <param name="_action">The specific action to remove.</param>
        void RemoveObserver(string _name, T _action);

        /// <summary>
        /// Removes all observers associated with a specific notification name.
        /// </summary>
        /// <param name="_name">The unique identifier for the notification.</param>
        void RemoveObserver(string _name);

        /// <summary>
        /// Posts a notification to all registered observers synchronously.
        /// </summary>
        /// <param name="_name">The unique identifier for the notification.</param>
        /// <param name="_notificationData">Data associated with the notification.</param>
        void PostNotification(string _name, BaseNotificationData _notificationData);
    }
}