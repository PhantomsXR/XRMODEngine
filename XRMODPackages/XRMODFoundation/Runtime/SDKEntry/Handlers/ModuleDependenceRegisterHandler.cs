// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
 
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.Models;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    public class ModuleDependenceRegisterHandler : AbstractHandler
    {
        public override void Handle()
        {
            // Register necessary runtime data
            IocContainer.GetIoc.Register(new SDKEntryPointModel());

            //XR-MOD Engine necessary data
            IocContainer.GetIoc.Register(new BaseContextDataModel());
            IocContainer.GetIoc.Register(new SdkConfigModel());
            IocContainer.GetIoc.Register(new RuntimeExperienceConfig());

            //Register common command
            IocContainer.GetIoc.Register(new BuildExitCommand());
            IocContainer.GetIoc.Register(new BuildExceptionCollectorCommand());
            
            IocContainer.GetIoc.Register(new BuildTryAcquireSdkTypeCommand());
            IocContainer.GetIoc.Register(new BuildTryAcquireSDKVersionCommand());
            IocContainer.GetIoc.Register(new BuildTryAcquireLaunchConfigCommand());

            // IocContainer.GetIoc.Register(new FetchProjectDetailCommand());
            // IocContainer.GetIoc.Register(new VerificationVersionCommand());
            // IocContainer.GetIoc.Register(new FetchXRResourcesCommand());
            // IocContainer.GetIoc.Register(new DownloadAndSDKVersionCheckCommand());

            //For Offline mode
            IocContainer.GetIoc.Register(new OfflineLicenseValidator());
            base.Handle();
        }
    }
}