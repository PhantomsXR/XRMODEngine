// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VisionOSModule.Runtime.
// //
// // The AVPPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.IO;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class BuildVisionOSMeshingCommand : BaseBuildFeature<VisionOSMeshingDecorator>, ICommand, IReleaseCommand
    {
        private VisionOSMeshingDecorator meshingDecorator;

        public async void Execute()
        {
            if (IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.Value is not
                ARConfiguresModel tmp_Config) return;
            GameObject tmp_MeshVisualizer = null;
            if (String.Compare(tmp_Config.CustomMeshVisualizerName, ConstKey.CONST_DEFAULT_MESH_VISUALIZER_NAME,
                    StringComparison.Ordinal) == 0)
            {
                tmp_MeshVisualizer =
                    Resources.Load<GameObject>(Path.Combine(ConstKey.CONST_PREFAB_FOLDER_NAME, ConstKey.CONST_DEFAULT_MESH_VISUALIZER_NAME));
            }
            else
            {
                tmp_MeshVisualizer = await BasePackageLoaderUtility.LoadAssetFromPackage<GameObject>(
                    tmp_Config.ProjectName.ToLower(), tmp_Config.CustomMeshVisualizerName);
            }

            IocContainer.GetIoc.Resolve<ARContextDataModel>().MeshVisualizer = tmp_MeshVisualizer;
            
            meshingDecorator = new VisionOSMeshingDecorator();
            meshingDecorator.StartAlgorithm();
        }

        public void Release(string _projectName = null)
        {
            meshingDecorator?.StopAlgorithm();
        }
    }
}