// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Core.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using UnityEngine;

namespace Phantom.XRMOD.Core.Runtime
{
    public class XRMODObjectPool : MonoBehaviour
    {
        /// <summary>
        /// Runtime prefab pool manager
        /// </summary>
        private readonly Dictionary<string, ObjectList> poolByPrefab = new();

        /// <summary>
        /// Runtime instance pool manager
        /// </summary>
        private readonly Dictionary<string, ObjectList> poolByInstance = new();

        /// <summary>
        /// Get or create a new pool.
        /// </summary>
        /// <param name="_prefab">Index conditions used to retrieve or create the corresponding pool</param>
        /// <returns>The corresponding pool.</returns>
        private ObjectList GetOrCreatePool(GameObject _prefab)
        {
            if (poolByPrefab.TryGetValue(_prefab.name, out var tmp_Pool)) return tmp_Pool;
            tmp_Pool = new ObjectList();
            poolByPrefab[_prefab.name] = tmp_Pool;
            return tmp_Pool;
        }

        /// <summary>
        /// Instance a game-object
        /// </summary>
        /// <param name="_prefab">The prefab to be instanced.</param>
        /// <param name="_position">The location to be set.</param>
        /// <param name="_rotation">The rotation to be set.</param>
        /// <param name="_parent">The parent to be set.</param>
        /// <returns></returns>
        public GameObject AcquireInstance(GameObject _prefab, Vector3 _position = default,
            Quaternion _rotation = default,
            Transform _parent = default)
        {
            var tmp_Pool = GetOrCreatePool(_prefab);
            var tmp_Object = tmp_Pool.GetFromPool(_position, _rotation, _parent);
            if (tmp_Object)
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
        /// If this object type is already in the PrefabPool manager,
        /// it will be recycled otherwise it will be destroyed directly.
        /// </summary>
        /// <param name="_object"></param>
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

        private class ObjectList
        {
            private readonly List<GameObject> free = new();

            /// <summary>
            /// Get the object from the pool.
            /// </summary>
            /// <param name="_position">The object location to be set.</param>
            /// <param name="_rotation">The object rotation to be set.</param>
            /// <param name="_parent">The object parent node to be set.</param>
            /// <returns>The T type object.</returns>
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
            /// Clean up this pool and release memory.
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

            public void ReturnToPool(GameObject _object)
            {
                free.Add(_object);
            }
        }
    }
}