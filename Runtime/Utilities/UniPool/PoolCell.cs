// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODUtilites.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.ActionNotification.Runtime; 
using UnityEngine;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODUtilites.Runtime.UniPool
{
    /// <summary>
    /// Represents a single pooled object and its associated metadata.
    /// Wraps a <see cref="GameObject"/> and an optional component for fast retrieval.
    /// </summary>
    public class PoolCell
    {
        /// <summary>
        /// Is this cell currently available in the pool?
        /// </summary>
        public bool IsPooled;

        /// <summary>
        /// The instantiated GameObject instance.
        /// </summary>
        public GameObject GameObject;

        /// <summary>
        /// The transform of the pooled GameObject.
        /// </summary>
        public Transform Transform;

        /// <summary>
        /// An optional component associated with the GameObject for fast access.
        /// </summary>
        public object Component;

        private BaseNotificationData notificationData = new BaseNotificationData();

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolCell"/> class by instantiating a prefab.
        /// </summary>
        /// <param name="_prefab">The prefab to instantiate.</param>
        /// <param name="_container">The initial parent transform for the instance.</param>
        /// <param name="_isXRMOD">If true, triggers XRMOD-specific initialization notifications.</param>
        public PoolCell(GameObject _prefab, Transform _container, bool _isXRMOD = false)
        {
            GameObject = Object.Instantiate(_prefab, _container);
            GameObject.SetActive(false);
            Transform = GameObject.transform;

            if (_isXRMOD)
            { 
                ActionNotificationCenter.DefaultCenter.PostNotification(
                    nameof(ActionParameterDataType.ProcessMonoBinder), notificationData);
            }
        }


        /// <summary>
        /// Retrieves and stores a component of type T from the pooled GameObject.
        /// </summary>
        /// <typeparam name="T">The type of component to fetch.</typeparam>
        /// <param name="_componentInChild">If true, searches in children; otherwise, searches the root GameObject.</param>
        public void SetComponent<T>(bool _componentInChild = false)
        {
            Component = _componentInChild ? GameObject.GetComponentInChildren<T>() : GameObject.GetComponent<T>();
        }

        /// <summary>
        /// Retrieves and stores a component of a specific type from the pooled GameObject.
        /// </summary>
        /// <param name="_type">The type of component to fetch.</param>
        /// <param name="_componentInChild">If true, searches in children; otherwise, searches the root GameObject.</param>
        public void SetComponent(Type _type, bool _componentInChild = false)
        {
            Component = _componentInChild
                ? GameObject.GetComponentInChildren(_type)
                : GameObject.GetComponent(_type);
        }

        /// <summary>
        /// Gets the stored component as a <see cref="UnityEngine.Component"/>.
        /// </summary>
        /// <param name="_type">The type to cast to (for safety/consistency).</param>
        /// <returns>The stored component or null.</returns>
        public Component GetComponent(Type _type)
        {
            if (Component != null)
                return (Component) Component;
            return default;
        }

        /// <summary>
        /// Gets the stored component as type T.
        /// </summary>
        /// <typeparam name="T">The type to cast to.</typeparam>
        /// <returns>The stored component or null.</returns>
        public T GetComponent<T>()
        {
            if (Component != null)
                return (T) Component;
            return default;
        }
    }
}