// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.RokidModule.Runtime.
// //
// // The RokidPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Core.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    public class HandInteractorFeature : IFeatureDecorator
    {
        private RokidRuntimeContextModel rokidRuntimeContextModel;

        public HandInteractorFeature()
        {
            rokidRuntimeContextModel = IocContainer.GetIoc.Resolve<RokidRuntimeContextModel>();
        }


        public bool SupportThisFeature()
        {
            return true;
        }

        public void StartAlgorithm()
        {
            rokidRuntimeContextModel.XRInputModalityManager.enabled = true;
            rokidRuntimeContextModel.ThreeDRay.SetActive(false);
            rokidRuntimeContextModel.HandVisualizer.SetActive(true);
            rokidRuntimeContextModel.HandPostProcessor.SetActive(true);
            rokidRuntimeContextModel.RightHand.SetActive(true);
            rokidRuntimeContextModel.LeftHand.SetActive(true);
        }

        public void PauseAlgorithm()
        {
        }

        public void StopAlgorithm()
        {
            rokidRuntimeContextModel.XRInputModalityManager.enabled = false;
            rokidRuntimeContextModel.RightHand.SetActive(false);
            rokidRuntimeContextModel.LeftHand.SetActive(false);
            rokidRuntimeContextModel.HandVisualizer.SetActive(false);
            rokidRuntimeContextModel.HandPostProcessor.SetActive(false);
        }
    }
}