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
    /// <summary>
    /// Utility class for network prefab validation and management.
    /// </summary>
    public class NetworkPrefabUtility
    {
        /// <summary>
        /// Checks if a given prefab is registered in the <see cref="NetworkManager"/>'s prefab list.
        /// </summary>
        /// <param name="_prefab">The GameObject prefab to check.</param>
        /// <returns>True if the prefab is registered for network spawning, false otherwise.</returns>
        /// <remarks>
        /// This is essential to check before calling spawn methods to ensure the server knows about the object.
        /// </remarks>
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