// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using Phantom.XRMOD.XRMODPackageTools.Runtime;
using Phantom.XRMOD.Models.Runtime;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.Mapper;
using Phantom.XRMOD.SDKEntry.Runtime.Models;
using Phantom.XRMOD.XRMODUtilites.Runtime;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    public class OversizeCheckHandler : AbstractHandler
    {
        private XRExperienceData xrExperienceData;
        private ResponseMapper responseMapper;
        private float maximumDownloadSize;
        private float packageSize;
        private SDKEntryPointModel sdkEntryPointModel;

        public OversizeCheckHandler()
        {
            sdkEntryPointModel = IocContainer.GetIoc.Resolve<SDKEntryPointModel>();
            maximumDownloadSize = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value.dashboardConfig
                .maximumDownloadSize;
        }

        public override void Handle()
        {
            xrExperienceData = sdkEntryPointModel.XRExperienceData;
            packageSize = sdkEntryPointModel.ResponseMapper.data.bundle_size;
            Hash128 tmp_Hash128 = xrExperienceData.BundleDetails.Hash;
            bool tmp_InCache = Utility.ARExperienceInCache(xrExperienceData.BundleName, tmp_Hash128);
            if (packageSize < maximumDownloadSize || tmp_InCache || Application.internetReachability !=
                NetworkReachability.ReachableViaLocalAreaNetwork)
            {
                base.Handle();
                return;
            }

            sdkEntryPointModel.BreakDownloadWhenGreaterPresetSize.Value = true;
            //show alert to user and tell him the package size is more then (n)M
            APICallback.PackageSizeMoreThanPresetSize(packageSize, maximumDownloadSize);
        }
    }
}