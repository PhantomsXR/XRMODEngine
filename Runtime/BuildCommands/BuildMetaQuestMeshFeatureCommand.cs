// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.QuestModule.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.IO;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    public class BuildMetaQuestMeshFeatureCommand : BaseBuildFeature<MetaQuestMeshingDecorator>, ICommand,
        IReleaseCommand
    {
        const string CONST_DEFAULT_MESH_VISUALIZER_NAME = "DefaultMeshVisualizer";
        const string CONST_PREFAB_FOLDER_NAME = "Prefabs";


        public async void Execute()
        {
            try
            {
                var tmp_CurrentConfigures = IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>();
                var tmp_Config = tmp_CurrentConfigures.CurrentConfigures.Value as XRConfiguresModel;
                GameObject tmp_MeshVisualizer = null;

                if (String.Compare(tmp_Config.CustomMeshVisualizerName, CONST_DEFAULT_MESH_VISUALIZER_NAME,
                        StringComparison.Ordinal) == 0 || string.IsNullOrEmpty(tmp_Config.CustomMeshVisualizerName))
                {
                    tmp_MeshVisualizer =
                        Resources.Load<GameObject>(Path.Combine(CONST_PREFAB_FOLDER_NAME,
                            CONST_DEFAULT_MESH_VISUALIZER_NAME));
                }
                else
                {
                    tmp_MeshVisualizer = await BasePackageLoaderUtility.LoadAssetFromPackage<GameObject>(
                        tmp_Config.ProjectName.ToLower(), tmp_Config.CustomMeshVisualizerName);
                }

                IocContainer.GetIoc.Resolve<XRRuntimeContextDataModel>().MeshVisualizer = tmp_MeshVisualizer;

                base.Create();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void Release(string _projectName = default)
        {
            base.ReleaseFeature();
        }
    }
}