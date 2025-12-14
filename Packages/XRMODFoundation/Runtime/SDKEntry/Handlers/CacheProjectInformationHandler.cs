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
    public class CacheProjectInformationHandler : AbstractHandler
    {
        public override void Handle()
        {
            // Cache current project information
            var tmp_SDKEntryPointModel = IocContainer.GetIoc.Resolve<SDKEntryPointModel>();

            IocContainer.GetIoc.Resolve<BaseContextDataModel>().ExperienceInfo =
                new BaseContextDataModel.ExperienceInfoData()
                {
#if XRMOD_3_0_0_OR_NEWER
                    ProjectUid = tmp_SDKEntryPointModel.ResponseMapper.data.project_uid,
                    Platform = tmp_SDKEntryPointModel.ResponseMapper.data.platform_type,
                    AppUid = tmp_SDKEntryPointModel.ResponseMapper.data.app_uid,
                    UserUid = tmp_SDKEntryPointModel.ResponseMapper.data.user_uid,
#else
                    ProjectUid = tmp_SDKEntryPointModel.ResponseMapper.data.project_uid.ToString(),
                    Platform = tmp_SDKEntryPointModel.ResponseMapper.data.platform_type,
                    AppUid = tmp_SDKEntryPointModel.ResponseMapper.data.app_uid.ToString(),
                    UserUid = tmp_SDKEntryPointModel.ResponseMapper.data.user_uid.ToString(),
#endif
                };
            base.Handle();
        }
    }
}