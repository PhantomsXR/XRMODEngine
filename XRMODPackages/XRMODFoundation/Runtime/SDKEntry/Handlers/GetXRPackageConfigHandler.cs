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

using System.Text;
using System.Threading.Tasks;
using Phantom.XRMOD.Models.Runtime;
using UnityEngine;
using UnityEngine.Assertions;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.DataRequest;
using Phantom.XRMOD.SDKEntry.Runtime.Models;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    /// <summary>
    /// Handler that downloads and parses the core configuration file for an XR experience package.
    /// </summary>
    public class GetXRPackageConfigHandler : AbstractHandler
    {
        public override async void Handle()
        {
            var tmp_SdkEntryPointModel = IocContainer.GetIoc.Resolve<SDKEntryPointModel>();
            var tmp_SdkConfigModel = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value;
            Assert.IsNotNull(tmp_SdkEntryPointModel, "tmp_SdkEntryPointModel != null");
            var tmp_Response = tmp_SdkEntryPointModel.ResponseMapper;
            var tmp_PackageBaseConfigureTextAsset = await NetworkRequestFactory<TextAsset>.CreateNetworkRequest(
                NetworkRequestType.LoadConfigure,
                new QueryParameter
                {
                    AssetBundleContentUrl = tmp_Response.data.bundle_url,
                    Crc = tmp_SdkEntryPointModel.XRExperienceData.BundleDetails.Crc,
                    Hash = tmp_SdkEntryPointModel.XRExperienceData.BundleDetails.Hash.ToString(),
                    Timeout = tmp_SdkConfigModel.dashboardConfig.timeout,
                });

            Assert.IsNotNull(tmp_PackageBaseConfigureTextAsset, "tmp_PackageBaseConfigureTextAsset != null");

            // Keep meta data for special platform
            IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().MetaData = tmp_PackageBaseConfigureTextAsset.text;

            // Remap to runtime project config(Not include special platform data)
            IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.Value =
                JsonUtility.FromJson<BaseExperienceConfigModel>(tmp_PackageBaseConfigureTextAsset.text);
            base.Handle();
        }
    }
}