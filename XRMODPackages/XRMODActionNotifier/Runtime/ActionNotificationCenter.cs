/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XR-MOD SDK.

The XR-MOD SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/


using System;
using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    /// <summary>
    /// The central hub for posting and receiving notifications within the XRMOD system.
    /// It supports synchronous, asynchronous, and result-returning notifications.
    /// </summary>
    public partial class ActionNotificationCenter : IActionNotificationCenter<Action<BaseNotificationData>>
    {
        private static readonly ActionNotificationCenter _DEFAULT_CENTER = new();
 

        /// <summary>
        /// Releases all registered handlers. Use this to clean up the notification center.
        /// </summary>
        public void Release()
        { 
            handlers.Clear();
        }


        /// <summary>
        /// Gets the default instance of the notification center.
        /// </summary>
        public static ActionNotificationCenter DefaultCenter => _DEFAULT_CENTER;
 


        /// <summary>
        /// Adds a synchronous observer that performs an action when a specific notification is posted.
        /// </summary>
        /// <param name="_action">The action to execute (delegate).</param>
        /// <param name="_name">The name of the notification to observe.</param>
        /// <example>
        /// <code>
        /// ActionNotificationCenter.DefaultCenter.AddObserver(data => {
        ///     Debug.Log($"Notification received: {data}");
        /// }, "MyEventName");
        /// </code>
        /// </example>
        public void AddObserver(Action<BaseNotificationData> _action, string _name)
        {
            if (string.IsNullOrEmpty(_name))
            {
                Debug.LogError("Null name specified for notification in AddObserver.");
                return;
            }

            AddHandler(new SyncNotificationHandler(_name, _action)); 
        }

        /// <summary>
        /// Adds an asynchronous observer that can be awaited when a notification is posted via PostNotificationAsync.
        /// </summary>
        /// <param name="_action">The async function to execute. It should return a Task of object.</param>
        /// <param name="_name">The name of the notification to observe.</param>
        /// <remarks>
        /// This is useful for operations that involve networking, file I/O, or other long-running tasks.
        /// </remarks>
        public void AddAsyncObserver(Func<BaseNotificationData, Task<object>> _action, string _name)
        {
            if (string.IsNullOrEmpty(_name))
            {
                Debug.LogError("Null name specified for notification in AddObserver.");
                return;
            }

            AddHandler(new AsyncNotificationHandler(_name, _action)); 
        }

        /// <summary>
        /// Adds a synchronous observer that returns a result object.
        /// </summary>
        /// <param name="_action">The function to execute that returns a result.</param>
        /// <param name="_name">The name of the notification to observe.</param>
        public void AddObserver(Func<BaseNotificationData, object> _action, string _name)
        {
            if (string.IsNullOrEmpty(_name))
            {
                Debug.LogError("Null name specified for notification in AddObserver.");
                return;
            }

            AddHandler(new SyncNotificationHandler(_name, _action)); 
        }

        /// <summary>
        /// Removes a specific synchronous action observer from a notification.
        /// </summary>
        /// <param name="_name">The name of the notification.</param>
        /// <param name="_action">The action to remove.</param>
        public void RemoveObserver(string _name, Action<BaseNotificationData> _action)
        {
            RemoveHandler(_name); 
        }

        /// <summary>
        /// Removes a specific synchronous function observer from a notification.
        /// </summary>
        /// <param name="_name">The name of the notification.</param>
        /// <param name="_action">The function to remove.</param>
        public void RemoveObserver(string _name, Func<BaseNotificationData, object> _action)
        {
            RemoveHandler(_name, new SyncNotificationHandler(_name, _action)); 
        }

        /// <summary>
        /// Removes all observers associated with a specific notification name.
        /// </summary>
        /// <param name="_name">The name of the notification.</param>
        public void RemoveObserver(string _name)
        {
            RemoveHandler(_name); 
        }


        /// <summary>
        /// Posts a notification to all registered observers synchronously.
        /// </summary>
        /// <param name="_name">The name of the notification to post.</param>
        /// <param name="_object">The data to pass to observers.</param>
        public void PostNotification(string _name, BaseNotificationData _object)
        {
            if (string.IsNullOrEmpty(_name))
            {
                return;
            }

            Post(_name, _object);
        }


        /// <summary>
        /// Posts a notification synchronously and collects results from all observers that return a value.
        /// </summary>
        /// <param name="_name">The name of the notification.</param>
        /// <param name="_object">The data to pass to observers.</param>
        /// <returns>A list of results from observers. Returns null if name is empty.</returns>
        public List<object> PostNotificationWithResult(string _name, BaseNotificationData _object)
        {
            if (string.IsNullOrEmpty(_name))
            {
#if DEBUG
                Debug.LogError("The method name is empty!.");
#endif
                return null;
            }

            return Post(_name, _object);
        }

        /// <summary>
        /// Posts a notification asynchronously and awaits all async observers.
        /// </summary>
        /// <param name="_name">The name of the notification.</param>
        /// <param name="_data">The data to pass to observers.</param>
        /// <returns>A task returning a list of result objects from async observers.</returns>
        public async Task<List<object>> PostNotificationAsync(string _name, BaseNotificationData _data)
        {
            if (string.IsNullOrEmpty(_name))
                return null;
            return await PostAsync(_name, _data);
        }
    }
}