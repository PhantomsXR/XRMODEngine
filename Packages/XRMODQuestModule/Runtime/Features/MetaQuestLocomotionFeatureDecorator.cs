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
using Phantom.XRMOD.XRMODInput.Runtime;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    public class MetaQuestLocomotionFeatureDecorator : BaseMetaQuestFeatureDecorator
    {
        private ArchitectureComponentsModel architectureComponentsModel;

        public MetaQuestLocomotionFeatureDecorator()
        {
            architectureComponentsModel = IocContainer.GetIoc.Resolve<ArchitectureComponentsModel>();
        }

        public override void StartAlgorithm()
        {
            base.StartAlgorithm();

            architectureComponentsModel.LeftController.Find("Teleport Interactor").gameObject.SetActive(true);
            architectureComponentsModel.RightController.Find("Teleport Interactor").gameObject.SetActive(true);
            architectureComponentsModel.CharacterController.enabled = true;
            architectureComponentsModel.LocomotionProvider.gameObject.SetActive(true);
        }

        public override bool SupportThisFeature()
        {
            return true;
        }

        public override void PauseAlgorithm()
        {
            throw new System.NotImplementedException();
        }

        public override void StopAlgorithm()
        {
            architectureComponentsModel.CharacterController.enabled = false;
            architectureComponentsModel.LocomotionProvider.gameObject.SetActive(false);
            architectureComponentsModel.LeftController.Find("Teleport Interactor").gameObject.SetActive(false);
            architectureComponentsModel.RightController.Find("Teleport Interactor").gameObject.SetActive(false);
        }
    }
}