// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the BaseFeaturesModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using Phantom.XRMOD.GLTFExtension.Runtime;
using UnityEngine.EventSystems;
using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.BaseFeatures.Runtime.Models
{
    /// <summary>
    /// Managed model that stores state for base features, including GLTF cache, event systems, and active processes.
    /// </summary>
    public class BaseFeatureModel : IModel, IReleaseCommand
    {
        /// <summary> Manages the runtime caching of exported GLTF assets. </summary>
        public GltfFileCacheManager GltfFileCacheManager;
        
        /// <summary> Dictionary tracking active processes and their associated keys. </summary>
        public Dictionary<string,List<string>> Processes;

        /// <summary> Reference to the active Unity EventSystem for UI interactions. </summary>
        public EventSystem EventSystem;

        public BaseFeatureModel()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes the model's components and collections.
        /// </summary>
        public void Initialize()
        {
            GltfFileCacheManager = new GltfFileCacheManager();
            Processes = new Dictionary<string, List<string>>();
        }

        /// <summary>
        /// Releases resources and clears collections when the module or project is disposed.
        /// </summary>
        /// <param name="_projectName">Optional project name for scoped release.</param>
        public void Release(string _projectName = null)
        {
            GltfFileCacheManager.CleanUp();
            GltfFileCacheManager = null;
            Processes.Clear();
            Processes = null;
        }
    }
}