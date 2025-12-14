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
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.XRMODInput.Runtime;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    public class MetaQuestInteracterSwitherDecorator : BaseMetaQuestFeatureDecorator
    {
        private ArchitectureComponentsModel architectureComponentsModel;

        public MetaQuestInteracterSwitherDecorator()
        {
            architectureComponentsModel = IocContainer.GetIoc.Resolve<ArchitectureComponentsModel>();
        }

        public override void StartAlgorithm()
        {
            base.StartAlgorithm();
            ActionNotificationCenter.DefaultCenter.AddObserver(SwitchInput, nameof(SwitchInput));
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
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(SwitchInput));
        }


        private void SwitchInput(BaseNotificationData _notification)
        {
            architectureComponentsModel.XRInputModalityManager.enabled = false;
            var tmp_InputType = (InputType) _notification.ObjectData;
            switch (tmp_InputType)
            {
                case InputType.NatureHands:
                    architectureComponentsModel.LeftController.gameObject.SetActive(false);
                    architectureComponentsModel.RightController.gameObject.SetActive(false);
                    architectureComponentsModel.LeftHandController.gameObject.SetActive(true);
                    architectureComponentsModel.RightHandController.gameObject.SetActive(true);
                    break;
                case InputType.KeyboardNMouse:
                case InputType.GamePad:
                    architectureComponentsModel.LeftController.gameObject.SetActive(false);
                    architectureComponentsModel.RightController.gameObject.SetActive(false);

                    architectureComponentsModel.LeftHandController.gameObject.SetActive(false);
                    architectureComponentsModel.RightHandController.gameObject.SetActive(false);
                    break;
                case InputType.XRController:
                    architectureComponentsModel.LeftController.gameObject.SetActive(true);
                    architectureComponentsModel.RightController.gameObject.SetActive(true);

                    architectureComponentsModel.LeftHandController.gameObject.SetActive(false);
                    architectureComponentsModel.RightHandController.gameObject.SetActive(false);
                    break;
                case InputType.Unknown:
                    architectureComponentsModel.XRInputModalityManager.enabled = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}