// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using Phantom.XRMOD.ActionNotification.Runtime;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Pool;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// Manages object pooling for NetworkObjects to reduce instantiation overhead.
    /// </summary>
    /// <remarks>
    /// This singleton class provides:
    /// - Efficient object pooling for networked prefabs
    /// - Automatic registration with Unity's NetworkManager
    /// - Pre-warming support to reduce runtime allocation spikes
    /// - Synchronized spawn/despawn behavior across all clients
    /// 
    /// Use <see cref="BuildPool(List{PoolConfigObject})"/> to register prefabs before spawning.
    /// </remarks>
    public class NetworkObjectPool : NetworkBehaviour
    {
        public static NetworkObjectPool Singleton { get; private set; }

        readonly HashSet<GameObject> prefabs = new();

        private readonly Dictionary<GameObject, ObjectPool<NetworkObject>> pooledObjects = new();

#pragma warning disable CS0414 // Field is assigned but its value is never used
        private bool allowToBuildPool;
#pragma warning restore CS0414 // Field is assigned but its value is never used

        public void Awake()
        {
            if (Singleton != null && Singleton != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Singleton = this;
            }
        }

        public override void OnNetworkSpawn()
        {
            // Registers all objects in PooledPrefabsList to the cache.
            allowToBuildPool = true;
        }

        /// <summary>
        /// Builds initial object pools from a list of configuration objects.
        /// </summary>
        /// <param name="_pooledPrefabsList">List of prefab and count configurations.</param>
        public void BuildPool(List<PoolConfigObject> _pooledPrefabsList)
        {
            foreach (var tmp_ConfigObject in _pooledPrefabsList)
            {
                RegisterPrefabInternal(tmp_ConfigObject.Prefab, tmp_ConfigObject.PrewarmCount,
                    tmp_ConfigObject.ParentTransform);
            }
        }

        /// <summary>
        /// Builds a pool for a single prefab configuration.
        /// </summary>
        /// <param name="_pooledPrefab">The prefab configuration.</param>
        public void BuildPool(PoolConfigObject _pooledPrefab)
        {
            RegisterPrefabInternal(_pooledPrefab.Prefab, _pooledPrefab.PrewarmCount, _pooledPrefab.ParentTransform);
        }

        public override void OnNetworkDespawn()
        {
            // Unregisters all objects in PooledPrefabsList from the cache.
            foreach (var tmp_Prefab in prefabs)
            {
                // Unregister Netcode Spawn handlers
                NetworkManager.Singleton.PrefabHandler.RemoveHandler(tmp_Prefab);
                pooledObjects[tmp_Prefab].Clear();
            }

            pooledObjects.Clear();
            prefabs.Clear();
        }

        /// <summary>
        /// Gets an instance of the given prefab from the pool. The prefab must be registered to the pool.
        /// </summary>
        /// <remarks>
        /// To spawn a NetworkObject from one of the pools, this must be called on the server, then the instance
        /// returned from it must be spawned on the server. This method will then also be called on the client by the
        /// PooledPrefabInstanceHandler when the client receives a spawn message for a prefab that has been registered
        /// here.
        /// </remarks>
        /// <param name="_prefab"></param>
        /// <param name="_position">The position to spawn the object at.</param>
        /// <param name="_rotation">The rotation to spawn the object with.</param>
        /// <returns></returns>
        public NetworkObject GetNetworkObject(GameObject _prefab, Vector3 _position, Quaternion _rotation)
        {
            var tmp_NetworkObject = pooledObjects[_prefab].Get();

            var tmp_NoTransform = tmp_NetworkObject.transform;
            tmp_NoTransform.position = _position;
            tmp_NoTransform.rotation = _rotation;

            return tmp_NetworkObject;
        }

        /// <summary>
        /// Return an object to the pool (reset objects before returning).
        /// </summary>
        public void ReturnNetworkObject(NetworkObject _networkObject, GameObject _prefab)
        {
            pooledObjects[_prefab].Release(_networkObject);
        }

        /// <summary>
        /// Builds up the cache for a prefab.
        /// </summary>
        void RegisterPrefabInternal(GameObject _prefab, int _prewarmCount, Transform _parent = null)
        {
            NetworkObject CreateFunc()
            {
                return Instantiate(_prefab, _parent).GetComponent<NetworkObject>();
            }

            void ActionOnGet(NetworkObject _networkObject)
            {
                _networkObject.gameObject.SetActive(true);
            }

            void ActionOnRelease(NetworkObject _networkObject)
            {
                _networkObject.gameObject.SetActive(false);
            }

            void ActionOnDestroy(NetworkObject _networkObject)
            {
                Destroy(_networkObject.gameObject);
            }

            prefabs.Add(_prefab);

            // Create the pool
            pooledObjects[_prefab] = new ObjectPool<NetworkObject>(CreateFunc, ActionOnGet, ActionOnRelease,
                ActionOnDestroy, defaultCapacity: _prewarmCount);

            // Populate the pool
            var tmp_PrewarmNetworkObjects = new List<NetworkObject>();
            for (var tmp_Idx = 0; tmp_Idx < _prewarmCount; tmp_Idx++)
            {
                tmp_PrewarmNetworkObjects.Add(pooledObjects[_prefab].Get());
            }

            foreach (var tmp_NetworkObject in tmp_PrewarmNetworkObjects)
            {
                pooledObjects[_prefab].Release(tmp_NetworkObject);
            }

            // Register Netcode Spawn handlers
            NetworkManager.Singleton.PrefabHandler.AddHandler(_prefab, new PooledPrefabInstanceHandler(_prefab, this));

            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.ProcessMonoBinderBatch), new BaseNotificationData());
        }
    }

    [Serializable]
    public class PoolConfigObject
    {
        // ReSharper disable once InconsistentNaming
        public GameObject Prefab;

        // ReSharper disable once InconsistentNaming
        public int PrewarmCount;

        // ReSharper disable once InconsistentNaming
        public Transform ParentTransform;
    }

    class PooledPrefabInstanceHandler : INetworkPrefabInstanceHandler
    {
        GameObject prefab;
        NetworkObjectPool pool;

        public PooledPrefabInstanceHandler(GameObject _prefab, NetworkObjectPool _pool)
        {
            prefab = _prefab;
            pool = _pool;
        }

        NetworkObject INetworkPrefabInstanceHandler.Instantiate(ulong _ownerClientId, Vector3 _position,
            Quaternion _rotation)
        {
            return pool.GetNetworkObject(prefab, _position, _rotation);
        }

        void INetworkPrefabInstanceHandler.Destroy(NetworkObject _networkObject)
        {
            pool.ReturnNetworkObject(_networkObject, prefab);
        }
    }
}