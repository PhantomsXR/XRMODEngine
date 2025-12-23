// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Assembly-CSharp.
// //
// // The Nin1 cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Services.CloudSave.Models;
using UnityEngine.Assertions;

namespace Phantom.XRMOD.GameServices.Runtime
{
    /// <summary>
    /// Manages the Cloud Save system.
    /// Provides methods to save and load player data to/from the cloud.
    /// </summary>
    public class CloudSaveSystemManager : ICloudSaveGameData, IDeleteData
    {
        private static CloudSaveSystemManager _INSTANCE;

        /// <summary>
        /// Singleton instance of CloudSaveSystemManager.
        /// </summary>
        public static CloudSaveSystemManager GetInstance => _INSTANCE ??= new CloudSaveSystemManager();
        
        private ICloudSaveGameData iCloudSaveGameDataProvider;
        private IDeleteData iDeleteDataProvider;

        private CloudSaveSystemManager()
        {
#if USE_UNITY_CLOUD_SAVE
            var tmp_Provider = new UnityCloudSavePlayerDataGameDataProvider();
            iDeleteDataProvider = tmp_Provider;
            iCloudSaveGameDataProvider = tmp_Provider;
#endif
            Assert.IsNotNull(iCloudSaveGameDataProvider);
            Assert.IsNotNull(iDeleteDataProvider);
        }

        /// <summary>
        /// Saves player data to the cloud.
        /// </summary>
        /// <param name="_saveData">A dictionary of key-value pairs to save.</param>
        /// <returns>A Task representing the save operation, returning true if successful.</returns>
        /// <example>
        /// <code>
        /// var data = new Dictionary&lt;string, object&gt; { { "Level", 10 } };
        /// await CloudSaveSystemManager.GetInstance.SavePlayerData(data);
        /// </code>
        /// </example>
        public async Task<bool> SavePlayerData(Dictionary<string, object> _saveData)
        {
            return await iCloudSaveGameDataProvider.SavePlayerData(_saveData);
        }

        /// <summary>
        /// Loads player data from the cloud using the specified keys.
        /// </summary>
        /// <param name="_keys">A set of keys to load.</param>
        /// <returns>A Task representing the load operation, returning a dictionary of items.</returns>
        public async Task<Dictionary<string, Item>> LoadPlayerData(HashSet<string> _keys)
        {
            return await iCloudSaveGameDataProvider.LoadPlayerData(_keys);
        }

        /// <summary>
        /// Deletes player data associated with the specified key.
        /// </summary>
        /// <param name="_key">The key to delete.</param>
        public void DeletePlayerData(string _key)
        {
            iDeleteDataProvider?.DeletePlayerData(_key);
        }
    }
}