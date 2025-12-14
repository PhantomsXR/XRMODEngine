// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The SlingshotMatch cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Unity.Netcode;
using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    public class NetworkPrefabUtility
    {
        public static bool IsInNetworkPrefabList(GameObject _prefab)
        {
            if (NetworkManager.Singleton == null)
            {
                Debug.LogWarning("NetworkManager is not initialized.");
                return false;
            }

            var tmp_PrefabList = NetworkManager.Singleton.NetworkConfig.Prefabs;
            if (tmp_PrefabList == null || tmp_PrefabList.Prefabs.Count == 0)
            {
                return false;
            }

            foreach (var tmp_Entry in tmp_PrefabList.Prefabs)
            {
                if (tmp_Entry.Prefab == _prefab)
                {
                    return true;
                }
            }

            return false;
        }
    }
}