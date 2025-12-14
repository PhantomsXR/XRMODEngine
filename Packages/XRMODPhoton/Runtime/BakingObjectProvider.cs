// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

#if FUSION2
using System;
using System.Collections.Generic;
using System.Linq;
using Fusion;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    /// <summary>
    /// Adapter to Unity Fusion spawn the network object at runtime.
    /// </summary>
    public class BakingObjectProvider : NetworkObjectProviderDefault
    {
        [Tooltip("The objects to be pooled, leave it empty to pool every Network Object spawned")] [SerializeField]
        private List<NetworkObject> poolableObjects = new List<NetworkObject>();

        private readonly Dictionary<NetworkObjectTypeId, Stack<NetworkObject>> free = new();

        // The NetworkObjectBaker class can be reused and is Runner independent.
        private static NetworkObjectBaker _BAKER;
        private static NetworkObjectBaker Baker => _BAKER ??= new NetworkObjectBaker();

        public override NetworkObjectAcquireResult AcquirePrefabInstance(NetworkRunner _runner,
            in NetworkPrefabAcquireContext _context, out NetworkObject _result)
        {
            _result = null;

            if (DelayIfSceneManagerIsBusy && _runner.SceneManager.IsBusy)
            {
                return NetworkObjectAcquireResult.Retry;
            }

            NetworkObject tmp_Prefab;
            try
            {
                tmp_Prefab = _runner.Prefabs.Load(_context.PrefabId, isSynchronous: _context.IsSynchronous);
            }
            catch (Exception tmp_Ex)
            {
                Log.Error($"Failed to load prefab: {tmp_Ex}");
                return NetworkObjectAcquireResult.Failed;
            }

            if (!tmp_Prefab)
            {
                // this is ok, as long as Fusion does not require the prefab to be loaded immediately;
                // if an instance for this prefab is still needed, this method will be called again next update
                return _context.IsSynchronous ? NetworkObjectAcquireResult.Failed : NetworkObjectAcquireResult.Retry;
            }
 
            _result = InstantiatePrefab(_runner, tmp_Prefab);
            if (_result == null) return NetworkObjectAcquireResult.Failed;
            var tmp_Go = _result.gameObject;

            // Baking is required for the NetworkObject to be valid for spawning.
            Baker.Bake(tmp_Go);

            // Move the object to the applicable Runner Scene/PhysicsScene/DontDestroyOnLoad
            // These implementations exist in the INetworkSceneManager assigned to the runner.
            if (_context.DontDestroyOnLoad)
            {
                _runner.MakeDontDestroyOnLoad(tmp_Go);
            }
            else
            {
                _runner.MoveToRunnerScene(tmp_Go);
            }

            // We are finished. Return the NetworkObject and report success.
            _result = tmp_Go.GetComponent<NetworkObject>();
            _runner.Prefabs.AddInstance(_context.PrefabId);
            return NetworkObjectAcquireResult.Success;
        }


        protected override NetworkObject InstantiatePrefab(NetworkRunner _runner, NetworkObject _prefab)
        {
            if (ShouldPool(_prefab))
            {
                var tmp_Instance = GetObjectFromPool(_prefab);

                tmp_Instance.transform.position = Vector3.zero;

                return tmp_Instance;
            }

            if (CreateUnityFusionNetworkObject(_prefab, out var tmp_InstanceObject))
                return tmp_InstanceObject;
            return null;
        }

        protected override void DestroyPrefabInstance(NetworkRunner _runner, NetworkPrefabId _prefabId,
            NetworkObject _instance)
        {
            if (free.TryGetValue(_prefabId, out var tmp_Stack))
            {
                _instance.gameObject.SetActive(false);
                tmp_Stack.Push(_instance);
            }
            else
            {
                base.DestroyPrefabInstance(_runner, _prefabId, _instance);
            }
        }

        private NetworkObject GetObjectFromPool(NetworkObject _prefab)
        {
            NetworkObject tmp_Instance = null;

            if (free.TryGetValue(_prefab.NetworkTypeId, out var tmp_Stack))
            {
                while (tmp_Stack.Count > 0 && tmp_Instance == null)
                {
                    tmp_Instance = tmp_Stack.Pop();
                }
            }

            if (tmp_Instance == null)
                tmp_Instance = GetNewInstance(_prefab);

            tmp_Instance.gameObject.SetActive(true);
            return tmp_Instance;
        }

        private NetworkObject GetNewInstance(NetworkObject _prefab)
        {
            if (!CreateUnityFusionNetworkObject(_prefab, out var tmp_Instance)) return null;

            if (free.TryGetValue(_prefab.NetworkTypeId, out var tmp_Stack) == false)
            {
                tmp_Stack = new Stack<NetworkObject>();
                free.Add(_prefab.NetworkTypeId, tmp_Stack);
            }

            return tmp_Instance;
        }

        private static bool CreateUnityFusionNetworkObject(NetworkObject _prefab, out NetworkObject _networkObject)
        {
            _networkObject = null;
            // VERY IMPORTANT!!! It will convert the Mono-behaviour(Binder) scripts to Unity fusion adapter.
            // Because Network-behaviour CAN NOT add to the game-object at runtime.
            var tmp_Results = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.Instantiate), new InstantiateArgs()
                {
                    Prefab = _prefab.gameObject
                });
            if (tmp_Results.Count == 0) return false;

            if (tmp_Results[0] is not GameObject tmp_SpawnObject) return false;

            //NetworkBehaviourBinderManager.DoBind(tmp_SpawnObject.GetComponents<NetWorkBehaviourBinder>().ToList());
            return tmp_SpawnObject.TryGetComponent<NetworkObject>(out _networkObject);
        }

        private bool ShouldPool(NetworkObject _prefab)
        {
            return poolableObjects.Count > 0 && IsPoolableObject(_prefab);
        }

        private bool IsPoolableObject(NetworkObject _networkObject)
        {
            foreach (var tmp_PoolableObject in poolableObjects)
            {
                if (_networkObject == tmp_PoolableObject)
                {
                    return true;
                }
            }

            return false;
        }

        private void OnDestroy()
        {
            poolableObjects.Clear();
            poolableObjects = null;
            free.Clear();
            _BAKER = null;
        }
    }
}
#endif