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
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using UnityEngine.XR.ARFoundation;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class BuildVisionOSFocusSlamCommand: BaseBuildFeature<VisionOSFocusSlamDecorator>, ICommand, IReleaseCommand
    {
        public void Execute()
        {
            IocContainer.GetIoc.Resolve<ARComponentModel>().ARRaycastManager = !IocContainer.GetIoc
                .Resolve<ARComponentModel>().XROriginGameObject
                .TryGetComponent(out ARRaycastManager tmp_ARRaycastManager)
                ? IocContainer.GetIoc.Resolve<ARComponentModel>().XROriginGameObject.AddComponent<ARRaycastManager>()
                : tmp_ARRaycastManager;

            base.Create();
        }

        public void Release(string _projectName = null)
        {
            base.ReleaseFeature();
        }
    }
}