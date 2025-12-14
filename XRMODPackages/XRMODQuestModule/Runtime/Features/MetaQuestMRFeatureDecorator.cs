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

using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Rendering.Universal;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    public class MetaQuestMRFeatureDecorator : BaseMetaQuestFeatureDecorator
    {
        private XRConfiguresModel xrConfig;
        private ArchitectureComponentsModel architectureComponents;

        public MetaQuestMRFeatureDecorator()
        {
            var tmp_CurrentConfigures = IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>();
            xrConfig = tmp_CurrentConfigures.CurrentConfigures.Value as XRConfiguresModel;
            Assert.IsNotNull(xrConfig, "XR Config is NULL");
            architectureComponents = IocContainer.GetIoc.Resolve<ArchitectureComponentsModel>(); 
            Assert.IsNotNull(architectureComponents, "ArchitectureComponentsModel is NULL");

        }

        public override void StartAlgorithm()
        {
            base.StartAlgorithm();

            // Entry MR passthrought
            architectureComponents.ARCamera.clearFlags = CameraClearFlags.Color;
            architectureComponents.ARCamera.backgroundColor = new Color(0, 0, 0, 0);
            architectureComponents.CameraManager.enabled = true;
        }


        public override bool SupportThisFeature()
        {
            return true;
        }

        public override void PauseAlgorithm()
        {
            architectureComponents.ARCamera.clearFlags = CameraClearFlags.Skybox;
            architectureComponents.CameraManager.enabled = false;
        }

        public override void StopAlgorithm()
        {
            architectureComponents.ARCamera.clearFlags = CameraClearFlags.Skybox;
            architectureComponents.CameraManager.enabled = false;
        }
    }
}