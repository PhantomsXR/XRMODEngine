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
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODPackageTools.Runtime
{
    /// <summary>
    /// Legacy utility class for instantiating GameObjects and managing a simple object pool for tracking.
    /// Note: Most methods are marked as Obsolete in favor of modern loading systems.
    /// </summary>
    public static class InstantiateUtility
    {
        /// <summary> Internal pool for storing references to instantiated objects by name. </summary>
        private static readonly IDictionary<string, Object> STORE_POOL = new Dictionary<string, Object>();

        [Obsolete("", true)]
        public static GameObject Instantiate(GameObject _prefab, string _uniqueName, Vector3 _position,
            Quaternion _quaternion)
        {
            var tmp_Instantiate = Object.Instantiate(_prefab);
            tmp_Instantiate.name = tmp_Instantiate.name.Replace("(Clone)", "");
            //StoreInstantiatedObject(tmp_Instantiate);

            // var tmp_Transform = tmp_Instantiate.GetComponentsInChildren<Transform>(true);
            // for (int tmp_ChildIndex = 0; tmp_ChildIndex < tmp_Transform.Length; tmp_ChildIndex++)
            // {
            //     StoreInstantiatedObject(tmp_Transform[tmp_ChildIndex]);
            // }

            return tmp_Instantiate;
        }

        [Obsolete("", true)]
        public static GameObject Instantiate(GameObject _prefab, string _uniqueName, Transform _parent)
        {
            var tmp_Instantiate = Object.Instantiate(_prefab, _parent);
            tmp_Instantiate.name = tmp_Instantiate.name.Replace("(Clone)", "");
            //StoreInstantiatedObject(tmp_Instantiate);
            // var tmp_Transform = tmp_Instantiate.GetComponentsInChildren<Transform>(true);
            // for (int tmp_ChildIndex = 0; tmp_ChildIndex < tmp_Transform.Length; tmp_ChildIndex++)
            // {
            //     StoreInstantiatedObject(tmp_Transform[tmp_ChildIndex]);
            // }


            return tmp_Instantiate;
        }


        /// <summary>
        /// Recursively stores all Transforms in a GameObject's hierarchy into the internal pool.
        /// </summary>
        /// <param name="_gameObject">The root GameObject to store.</param>
        public static void StoreGameObject(GameObject _gameObject)
        {
            var tmp_Transform = _gameObject.GetComponentsInChildren<Transform>(true);
            foreach (var tmp_Trans in tmp_Transform)
            {
                StoreInstantiatedObject(tmp_Trans);
            }
        }


        /// <summary>
        /// Adds an object to the internal storage pool if its name isn't already present.
        /// </summary>
        /// <typeparam name="T">The type of object to store.</typeparam>
        /// <param name="_object">The object to add to the pool.</param>
        private static void StoreInstantiatedObject<T>(T _object) where T : Object
        {
            if (STORE_POOL.ContainsKey(_object.name))
            {
                Debug.LogWarning($"{_object.name} is already!");
                return;
            }


            STORE_POOL.Add(_object.name, _object);
        }

        /// <summary>
        /// Destroys all objects in the pool and clears the storage.
        /// Handles associated GameObjects if the pooled object is a Transform.
        /// </summary>
        public static void CleanPool()
        {
            var tmp_ConvertedListPool = STORE_POOL.Values.ToList();
            foreach (var tmp_Element in tmp_ConvertedListPool)
            {
                if (null == tmp_Element)
                {
                    continue;
                }

                if (tmp_Element is Transform tmp_Transform)
                {
                    Object.Destroy(tmp_Transform.gameObject);
                }

                Object.Destroy(tmp_Element);
            }

            STORE_POOL.Clear();
        }


        /// <summary>
        /// Retrieves an object from the pool by its name.
        /// </summary>
        /// <param name="_name">The name of the object to find.</param>
        /// <returns>The Unity Object if found; otherwise, null.</returns>
        public static Object FindByName(string _name)
        {
            return STORE_POOL.TryGetValue(_name, out Object tmp_Value) ? tmp_Value : null;
        }
    }
}