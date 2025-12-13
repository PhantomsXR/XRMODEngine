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

using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.VisionOSModule.Runtime.ExtensionComponents;
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class VisionOSFocusSlamDecorator : BaseVisionOSFeatureDecorator
    {
        private FocusPlacementExtension focusPlacementExtension;

        public override void StartAlgorithm()
        {
            base.StartAlgorithm();
            var tmp_ARComponent = IocContainer.GetIoc.Resolve<ARComponentModel>();

            Assert.IsNotNull(tmp_ARComponent.XROriginGameObject, "Session Origin is null");

            focusPlacementExtension =
                tmp_ARComponent.XROriginGameObject.AddComponent<FocusPlacementExtension>();

            Assert.IsNotNull(tmp_ARComponent.ARSession);
            tmp_ARComponent.ARSession.requestedTrackingMode = TrackingMode.PositionAndRotation;


            if (!focusPlacementExtension.enabled)
                focusPlacementExtension.enabled = true;
        }

        public override void PauseAlgorithm()
        {
            if (focusPlacementExtension)
                focusPlacementExtension.enabled = false;
        }

        public override void StopAlgorithm()
        {
            PauseAlgorithm();

            if (focusPlacementExtension)
            {
                focusPlacementExtension.DestroyWithPlatform();
                focusPlacementExtension = null;
            }
        }

        public override bool SupportThisFeature()
        {
            return focusPlacementExtension.Running;
        }
    }
}