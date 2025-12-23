/*===============================================================================
Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Core.Runtime.

The  XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System.Collections.Generic;
using UnityEngine;

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// A runtime object pooling system for efficiently managing the lifecycle of GameObjects.
    /// Reduces GC allocations and performance spikes by recycling instances instead of repeatedly instantiating and destroying them.
    /// </summary>
    public class XRMODObjectPool : MonoBehaviour
    {
        /// <summary>
        /// Runtime prefab pool manager, indexed by prefab name.
        /// </summary>
        private readonly Dictionary<string, ObjectList> poolByPrefab = new();

        /// <summary>
        /// Runtime instance pool manager, mapping spawned instances back to their original pool by name.
        /// </summary>
        private readonly Dictionary<string, ObjectList> poolByInstance = new();

        /// <summary>
        /// Get or create a new pool for a specific prefab.
        /// </summary>
        /// <param name="_prefab">The prefab to retrieve or create a pool for.</param>
        /// <returns>The corresponding <see cref="ObjectList"/> pool.</returns>
        private ObjectList GetOrCreatePool(GameObject _prefab)
        {
            if (poolByPrefab.TryGetValue(_prefab.name, out var tmp_Pool)) return tmp_Pool;
            tmp_Pool = new ObjectList();
            poolByPrefab[_prefab.name] = tmp_Pool;
            return tmp_Pool;
        }

        /// <summary>
        /// Acquires an instance of the specified prefab from the pool, or instantiates a new one if the pool is empty.
        /// </summary>
        /// <param name="_prefab">The prefab to instance.</param>
        /// <param name="_position">The initial position for the instance.</param>
        /// <param name="_rotation">The initial rotation for the instance.</param>
        /// <param name="_parent">The parent transform to attach the instance to.</param>
        /// <returns>A recycled or newly created GameObject instance.</returns>
        public GameObject AcquireInstance(GameObject _prefab, Vector3 _position = default,
            Quaternion _rotation = default,
            Transform _parent = default)
        {
            var tmp_Pool = GetOrCreatePool(_prefab);
            var tmp_Object = tmp_Pool.GetFromPool(_position, _rotation, _parent);
            if (tmp_Object != null)
            {
                tmp_Object.transform.SetParent(_parent, false);
                tmp_Object.transform.SetPositionAndRotation(_position, _rotation);
            }
            else
            {
                tmp_Object = Object.Instantiate(_prefab, _position, _rotation, _parent);
                poolByInstance[tmp_Object.name] = tmp_Pool;
            }

            tmp_Object.transform.localScale = _prefab.transform.localScale;
            tmp_Object.SetActive(true);
            return tmp_Object;
        }

        /// <summary>
        /// Releases a GameObject back into its corresponding pool for future reuse.
        /// If no pool is found for this object, it is destroyed safely.
        /// </summary>
        /// <param name="_object">The GameObject to release.</param>
        public void ReleaseInstance(GameObject _object)
        {
            if (!_object) return;
            if (poolByInstance.TryGetValue(_object.name, out var tmp_Pool))
            {
                tmp_Pool.ReturnToPool(_object);
                _object.gameObject.SetActive(false);
                _object.transform.SetParent(transform, false);
            }
            else
            {
                _object.gameObject.SafeDestroy();
            }
        }

        /// <summary>
        /// Clears all object pools and destroys any cached instances.
        /// </summary>
        public void ClearPools()
        {
            foreach (ObjectList tmp_Pool in poolByPrefab.Values)
            {
                tmp_Pool.Clear();
            }

            foreach (ObjectList tmp_Pool in poolByInstance.Values)
            {
                tmp_Pool.Clear();
            }

            poolByPrefab.Clear();
            poolByInstance.Clear();
        }

        /// <summary>
        /// Internal implementation of an object pool list for a specific prefab type.
        /// </summary>
        private class ObjectList
        {
            /// <summary>
            /// List of currently free (recycled) objects.
            /// </summary>
            private readonly List<GameObject> free = new();

            /// <summary>
            /// Retrieves an object from the free list and prepares it for use.
            /// </summary>
            /// <param name="_position">Selected world position.</param>
            /// <param name="_rotation">Selected world rotation.</param>
            /// <param name="_parent">Selected parent node.</param>
            /// <returns>A pooled GameObject, or null if the pool is empty.</returns>
            public GameObject GetFromPool(Vector3 _position, Quaternion _rotation, Transform _parent = null)
            {
                GameObject tmp_Object = null;
                while (free.Count > 0 && tmp_Object == null)
                {
                    var tmp_Element = free[0];
                    free.RemoveAt(0);
                    if (!tmp_Element) continue; 
                    var tmp_Transform = tmp_Element.transform;
                    tmp_Transform.SetParent(_parent, false);
                    tmp_Transform.SetPositionAndRotation(_position, _rotation);
                    tmp_Object = tmp_Element;
                }

                return tmp_Object;
            }

            /// <summary>
            /// Destroys all objects currenty in this pool list.
            /// </summary>
            public void Clear()
            {
                foreach (var tmp_Pooled in free)
                {
                    if (tmp_Pooled)
                    {
                        tmp_Pooled.gameObject.SafeDestroy();
                    }
                }

                free.Clear();
            }

            /// <summary>
            /// Adds an object back to the free list for recycling.
            /// </summary>
            /// <param name="_object">The object to return.</param>
            public void ReturnToPool(GameObject _object)
            {
                free.Add(_object);
            }
        }
    }
}