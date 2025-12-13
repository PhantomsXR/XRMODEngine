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
    public class BaseFeatureModel : IModel, IReleaseCommand
    {
        public GltfFileCacheManager GltfFileCacheManager;
        public Dictionary<string,List<string>> Processes;

        public EventSystem EventSystem;

        public BaseFeatureModel()
        {
            Initialize();
        }

        public void Initialize()
        {
            GltfFileCacheManager = new GltfFileCacheManager();
            Processes = new Dictionary<string, List<string>>();
        }

        public void Release(string _projectName = null)
        {
            GltfFileCacheManager.CleanUp();
            GltfFileCacheManager = null;
            Processes.Clear();
            Processes = null;
        }
    }
}