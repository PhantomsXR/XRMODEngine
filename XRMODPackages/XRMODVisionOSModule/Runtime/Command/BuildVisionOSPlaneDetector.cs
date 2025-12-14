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
    public class BuildVisionOSPlaneDetector: BaseBuildFeature<VisionOSPlaneDetectorDecorator>, ICommand, IReleaseCommand
    {
        public async void Execute()
        {
            if (IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.Value is not
                ARConfiguresModel tmp_Config) return;

            GameObject tmp_PlaneVisualizer = null;
            if (String.Compare(tmp_Config.CustomPlaneVisualizerName, ConstKey.CONST_DEFAULT_PLANE_VISUALIZER_NAME,
                    StringComparison.Ordinal) == 0)
            {
                tmp_PlaneVisualizer =
                    Resources.Load<GameObject>(Path.Combine(ConstKey.CONST_PREFAB_FOLDER_NAME, ConstKey.CONST_DEFAULT_PLANE_VISUALIZER_NAME));
            }
            else if (String.Compare(tmp_Config.CustomPlaneVisualizerName,
                         ConstKey.CONST_DEFAULT_FEATHERED_PLANE_VISUALIZER,
                         StringComparison.Ordinal) == 0)
            {
                tmp_PlaneVisualizer =
                    Resources.Load<GameObject>(Path.Combine(ConstKey.CONST_PREFAB_FOLDER_NAME,
                        ConstKey.CONST_DEFAULT_FEATHERED_PLANE_VISUALIZER));
            }
            else
            {
                tmp_PlaneVisualizer = await BasePackageLoaderUtility.LoadAssetFromPackage<GameObject>(
                    tmp_Config.ProjectName.ToLower(), tmp_Config.CustomPlaneVisualizerName);
            }

            IocContainer.GetIoc.Resolve<ARContextDataModel>().PlaneVisualizer = tmp_PlaneVisualizer;
            IocContainer.GetIoc.Resolve<ARContextDataModel>().PlaneDetectionMode = tmp_Config.PlaneDetectionMode;
            base.Create();
        }

        public void Release(string _projectName = null)
        {
            base.ReleaseFeature();
        }
    }

}