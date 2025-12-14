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
    public class PoolCell
    {
        public bool IsPooled;

        public GameObject GameObject;
        public Transform Transform;
        public object Component;

        private BaseNotificationData notificationData = new BaseNotificationData();

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


        public void SetComponent<T>(bool _componentInChild = false)
        {
            Component = _componentInChild ? GameObject.GetComponentInChildren<T>() : GameObject.GetComponent<T>();
        }

        public void SetComponent(Type _type, bool _componentInChild = false)
        {
            Component = _componentInChild
                ? GameObject.GetComponentInChildren(_type)
                : GameObject.GetComponent(_type);
        }

        public Component GetComponent(Type _type)
        {
            if (Component != null)
                return (Component) Component;
            return default;
        }

        public T GetComponent<T>()
        {
            if (Component != null)
                return (T) Component;
            return default;
        }
    }
}