// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.CloudSave.Runtime.
// //
// // The Nin1 cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Services.CloudSave.Models;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public interface ICloudSaveGameData
    {
        /// <summary>
        /// Upload one or more key-value pairs to the Cloud Save service without write lock validation, overwriting any values
        /// that are currently stored under the given keys.
        /// Key can only contain alphanumeric characters, dashes, and underscores and be up to a length of 255 characters.
        /// Throws a CloudSaveException with a reason code and explanation of what happened.
        ///
        /// <code>Dictionary</code> as a parameter ensures the uniqueness of given keys.
        /// There is no client validation in place, which means the API can be called regardless if data is incorrect, invalid, and/or missing.
        /// </summary>
        /// <param name="_gameData">The dictionary of keys and corresponding values to upload</param>
        /// <returns>The dictionary of saved keys and the corresponding updated write lock</returns>
        /// <exception cref="CloudSaveException">Thrown if request is unsuccessful.</exception>
        /// <exception cref="CloudSaveValidationException">Thrown if the service returned validation error.</exception>
        /// <exception cref="CloudSaveRateLimitedException">Thrown if the service returned rate limited error.</exception>
        Task<bool>  SavePlayerData(Dictionary<string, object> _saveData);
        
        /// <summary>
        /// Downloads data from Cloud Save for the keys provided.
        /// There is no client validation in place for the provided keys.
        /// Throws a CloudSaveException with a reason code and explanation of what happened.
        /// </summary>
        /// <param name="_keys">The optional set of keys to load data for</param>
        /// <returns>The dictionary of all key-value pairs that represents the current state of data on the server including their write locks</returns>
        /// <exception cref="CloudSaveException">Thrown if request is unsuccessful.</exception>
        /// <exception cref="CloudSaveValidationException">Thrown if the service returned validation error.</exception>
        /// <exception cref="CloudSaveRateLimitedException">Thrown if the service returned rate limited error.</exception>
        Task<Dictionary<string,Item>> LoadPlayerData(HashSet<string> _keys);
    }

    public interface ICloudSaveGameDataQuery
    {
        /// <summary>
        /// Queries indexed player data from Cloud Save, and returns the requested keys for matching items.
        /// Throws a CloudSaveException with a reason code and explanation of what happened.
        /// </summary>
        /// <param name="_options">The query conditions to apply, including field filters and sort orders</param>
        /// <param name="_options">Options to modify the behavior of the method, specifying AccessClass</param>
        /// <returns>The dictionary of all key-value pairs that represents the current state of data on the server including their write locks</returns>
        /// <exception cref="CloudSaveException">Thrown if request is unsuccessful.</exception>
        /// <exception cref="CloudSaveValidationException">Thrown if the service returned validation error.</exception>
        /// <exception cref="CloudSaveRateLimitedException">Thrown if the service returned rate limited error.</exception>
        Task<List<EntityData>>  QueryPlayerData(Query _options);
    }

    public interface IDeleteData
    {
        /// <summary>
        /// Removes one key at a time, with optional write lock validation. If the given key doesn't exist, there is no feedback in place to inform a developer about it.
        /// If a write lock is provided and it does not match with the existing write lock, will throw a conflict exception.
        /// There is no client validation on the arguments for this method.
        /// Throws a CloudSaveException with a reason code and explanation of what happened.
        ///
        /// </summary>
        /// <param name="_key">The key to be removed from the server</param>
        /// <param name="deleteOptions">The optional options object for specifying the write lock to check conflict in the server</param>
        /// <exception cref="CloudSaveException">Thrown if request is unsuccessful.</exception>
        /// <exception cref="CloudSaveValidationException">Thrown if the service returned validation error.</exception>
        /// <exception cref="CloudSaveRateLimitedException">Thrown if the service returned rate limited error.</exception>
        /// <exception cref="CloudSaveConflictException">Thrown if the service returned write lock conflict error.</exception>
        void DeletePlayerData(string _key);
    }
}