// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Miscellaneous Files.
// //
// // The Nin1 cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using DeleteOptions = Unity.Services.CloudSave.Models.Data.Player.DeleteOptions;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class UnityCloudSavePlayerDataGameDataProvider : ICloudSaveGameData, ICloudSaveGameDataQuery, IDeleteData
    {
        /// <summary>
        /// Batch save player data
        /// </summary>
        /// <param name="_gameData">Data to store</param>
        /// <returns>The operation completed</returns>
        public async Task<bool> SavePlayerData(Dictionary<string, object> _gameData)
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(_gameData);
            return true;
        }

        /// <summary>
        /// Batch load the player data
        /// </summary>
        /// <param name="_keys">The batch loading data keys</param>
        /// <returns>The loaded data dict</returns>
        public async Task<Dictionary<string, Item>> LoadPlayerData(HashSet<string> _keys)
        {
            return await CloudSaveService.Instance.Data.Player.LoadAsync(_keys);
        }

        /// <summary>
        /// Delete the player data
        /// </summary>
        /// <param name="_key">The deleting player data key</param>
        public async void DeletePlayerData(string _key)
        {
            await CloudSaveService.Instance.Data.Player.DeleteAsync(_key, new DeleteOptions());
        }


        /// <summary>
        /// Query the player data
        /// </summary>
        /// <param name="_options">The Query options</param>
        /// <returns>The query data</returns>
        public async Task<List<EntityData>> QueryPlayerData(Query _options)
        {
            return await CloudSaveService.Instance.Data.Player.QueryAsync(_options, new QueryOptions());
        }

        /// <summary>
        /// Save the player file
        /// </summary>
        /// <param name="_fileName">The saving file name</param>
        /// <param name="_fileBytes">The file data bytes</param>
        /// <returns>The operation completed</returns>
        public async Task<bool> SavePlayerFile(string _fileName, byte[] _fileBytes)
        {
            await CloudSaveService.Instance.Files.Player.SaveAsync(_fileName, _fileBytes);
            return true;
        }

        /// <summary>
        /// Delete the player file
        /// </summary>
        /// <param name="_fileName">The file name to delete</param>
        /// <returns>The operation completed</returns>
        public async Task<bool> DeletePlayerFile(string _fileName)
        {
            await CloudSaveService.Instance.Files.Player.DeleteAsync(_fileName);
            return true;
        }

        /// <summary>
        /// Get the player file
        /// </summary>
        /// <param name="_fileName">The file name to query</param>
        /// <returns>The file bytes</returns>
        public async Task<byte[]> GetPlayerFileAsByteArray(string _fileName)
        {
            return await CloudSaveService.Instance.Files.Player.LoadBytesAsync(_fileName);
        }
    }
}