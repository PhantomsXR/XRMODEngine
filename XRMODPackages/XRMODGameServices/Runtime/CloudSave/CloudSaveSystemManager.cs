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
    public class CloudSaveSystemManager : ICloudSaveGameData, IDeleteData
    {
        private static CloudSaveSystemManager _INSTANCE;
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

        ///<inheritdoc/>
        public async Task<bool> SavePlayerData(Dictionary<string, object> _saveData)
        {
            return await iCloudSaveGameDataProvider.SavePlayerData(_saveData);
        }

        ///<inheritdoc/>
        public async Task<Dictionary<string, Item>> LoadPlayerData(HashSet<string> _keys)
        {
            return await iCloudSaveGameDataProvider.LoadPlayerData(_keys);
        }

        ///<inheritdoc/>
        public void DeletePlayerData(string _key)
        {
            iDeleteDataProvider?.DeletePlayerData(_key);
        }
    }
}