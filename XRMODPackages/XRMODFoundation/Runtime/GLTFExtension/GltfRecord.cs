// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the glTFExtension.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using UnityEngine;

namespace Phantom.XRMOD.GLTFExtension.Runtime
{
    /// <summary>
    /// Represents a cached GLTF file record, including its local path and a timestamp for versioning.
    /// </summary>
    [System.Serializable]
    public class GltfRecord
    {
        /// <summary>
        /// The absolute local file path to the cached GLTF/GLB asset.
        /// </summary>
        public string GltfFilePath;

        /// <summary>
        /// A timestamp or hash used to determine if the cached version is still valid.
        /// </summary>
        public string Timestamp;
    }

    /// <summary>
    /// A simple database structure that stores a dictionary of <see cref="GltfRecord"/>s.
    /// Supports serialization to/from JSON.
    /// </summary>
    [System.Serializable]
    public class GltfCacheDb
    {
        /// <summary>
        /// Dictionary mapping file names to their respective cache records.
        /// </summary>
        public Dictionary<string, GltfRecord> cacheDict = new Dictionary<string, GltfRecord>();

        /// <summary>
        /// Serializes the database to a JSON string.
        /// </summary>
        /// <returns>A JSON representation of the database.</returns>
        public string Serializer()
        {
            return JsonUtility.ToJson(new Serialization<string, GltfRecord>(cacheDict));
        }

        /// <summary>
        /// Populates the database from a JSON string.
        /// </summary>
        /// <param name="_jsonStr">The JSON string to deserialize.</param>
        public void DeSerializer(string _jsonStr)
        {
            var tmp_Serialization = JsonUtility.FromJson<Serialization<string, GltfRecord>>(_jsonStr);
            cacheDict = tmp_Serialization.ToDictionary();
        }
    }
}