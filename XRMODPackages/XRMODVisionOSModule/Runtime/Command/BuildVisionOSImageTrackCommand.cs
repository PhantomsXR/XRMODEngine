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
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEngine.XR.ARSubsystems;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class BuildVisionOSImageTrackCommand: BaseBuildFeature<VisionOSImageTrackDecorator>, ICommand, IReleaseCommand
    {
        public async void Execute()
        {
            if (IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.Value is not
                ARConfiguresModel
                tmp_Config) return;
            
            new BuildDynamicLibraryCommand().Execute();

            IocContainer.GetIoc.Resolve<ARContextDataModel>().ReferenceImageLibrary =
                await BasePackageLoaderUtility.LoadAssetFromPackage<XRReferenceImageLibrary>(tmp_Config.ProjectName,
                    ConstKey.CONST_IMAGE_LIBRARY);
            base.Create();
        }

        public void Release(string _projectName = null)
        {
            base.ReleaseFeature();
        }
    }

}