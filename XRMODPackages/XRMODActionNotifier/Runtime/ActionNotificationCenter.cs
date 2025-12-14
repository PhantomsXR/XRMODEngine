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
    public partial class ActionNotificationCenter : IActionNotificationCenter<Action<BaseNotificationData>>
    {
        private static readonly ActionNotificationCenter _DEFAULT_CENTER = new();
 

        public void Release()
        { 
            handlers.Clear();
        }


        public static ActionNotificationCenter DefaultCenter => _DEFAULT_CENTER;
 


        /// <summary>
        /// add the method observer from notification actions
        /// </summary>
        /// <param name="_name">Will add notification name</param>
        /// <param name="_action">Will executed method</param>
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
        /// add the method observer from notification actions
        /// </summary>
        /// <param name="_name">Will add notification name</param>
        /// <param name="_action">Will executed method</param>
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
        /// add the method observer from notification actions
        /// </summary>
        /// <param name="_name">Will add notification name</param>
        /// <param name="_action">Will executed method</param>
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
        /// Remove the method observer from notification actions
        /// </summary>
        /// <param name="_name">Will remove notification name</param>
        /// <param name="_action">Will executed method</param>
        public void RemoveObserver(string _name, Action<BaseNotificationData> _action)
        {
            RemoveHandler(_name); 
        }

        /// <summary>
        /// Remove the method observer from notification actions
        /// </summary>
        /// <param name="_name">Will remove notification name</param>
        /// <param name="_action">Will executed method</param>
        public void RemoveObserver(string _name, Func<BaseNotificationData, object> _action)
        {
            RemoveHandler(_name, new SyncNotificationHandler(_name, _action)); 
        }

        /// <summary>
        /// Remove the method observer from notification actions
        /// </summary>
        /// <param name="_name">Will remove notification name</param>
        public void RemoveObserver(string _name)
        {
            RemoveHandler(_name); 
        }


        /// <summary>
        /// Post notification event
        /// </summary>
        /// <param name="_name">Trigger method name</param>
        /// <param name="_object">The parameters to the method</param>
        public void PostNotification(string _name, BaseNotificationData _object)
        {
            if (string.IsNullOrEmpty(_name))
            {
                return;
            }

            Post(_name, _object);
        }


        /// <summary>
        /// Post notification event
        /// </summary>
        /// <param name="_name">Trigger method name</param>
        /// <param name="_object">The parameters to the method</param>
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
        /// Post notification event
        /// </summary>
        /// <param name="_name">Trigger method name</param>
        /// <param name="_data">The parameters to the method</param>
        public async Task<List<object>> PostNotificationAsync(string _name, BaseNotificationData _data)
        {
            if (string.IsNullOrEmpty(_name))
                return null;
            return await PostAsync(_name, _data);
        }
    }
}