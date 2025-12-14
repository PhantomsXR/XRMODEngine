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

using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.BaseFeatures.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    public class LaunchXRModuleHandler : AbstractHandler
    {
        public override void Handle()
        {
            var tmp_BaseFeatureModule = IocContainer.GetIoc.Resolve<BaseFeatureModule>();
            // Avoid multiple executions
            if (tmp_BaseFeatureModule == null)
            {
                //Register base feature for all platform
                tmp_BaseFeatureModule = new BaseFeatureModule();
                IocContainer.GetIoc.Register(tmp_BaseFeatureModule);
            }

            tmp_BaseFeatureModule.StartModule();

            ActionNotificationCenter.DefaultCenter.PostNotification
                (nameof(ActionParameterDataType.OnXRDataGot), new BaseNotificationData());

            base.Handle();
        }
    }
}