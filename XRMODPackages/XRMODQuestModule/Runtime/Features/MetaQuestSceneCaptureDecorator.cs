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

using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine.XR.OpenXR.Features.Meta;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    public class MetaQuestSceneCaptureDecorator : BaseMetaQuestFeatureDecorator
    {
        public MetaQuestSceneCaptureDecorator()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(CaptureEnvironment, nameof(CaptureEnvironment));
        }

        private void CaptureEnvironment(BaseNotificationData _obj)
        {
            var tmp_ArchitectureComponentsModel = IocContainer.GetIoc.Resolve<ArchitectureComponentsModel>();
            if (tmp_ArchitectureComponentsModel.ARSession.subsystem is MetaOpenXRSessionSubsystem tmp_SceneCapture)
                tmp_SceneCapture.TryRequestSceneCapture();
        }


        public override bool SupportThisFeature()
        {
            return true;
        }

        public override void PauseAlgorithm()
        {
        }

        public override void StopAlgorithm()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(CaptureEnvironment));
        }
    }
}