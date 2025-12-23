// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XR-MOD SDK.
// //
// // The XR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using Phantom.XRMOD.Models.Runtime;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.DataRequest;
using Phantom.XRMOD.SDKEntry.Runtime.Mapper;
using Phantom.XRMOD.SDKEntry.Runtime.Models;
using Phantom.XRMOD.XRMODUtilites.Runtime;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    /// <summary>
    /// Handler that asynchronously fetches XR experience metadata and asset bundle manifests
    /// from the backend based on the project identity and target platform.
    /// </summary>
    public class FetchXRResourcesHandler : AbstractHandler
    {
        private readonly NetworkRequestType networkRequestType;
        private readonly string projectUid;

        /// <summary>
        /// Get current XRExperience information
        /// </summary>
        /// <param name="_networkRequestType"></param>
        /// <param name="_projectUid"></param>
        public FetchXRResourcesHandler(NetworkRequestType _networkRequestType, string _projectUid)
        {
            networkRequestType = _networkRequestType;
            projectUid = _projectUid;
        }

        public override async void Handle()
        {
            try
            {
                ResponseMapper tmp_Response = null;
                try
                {
                    var tmp_SDKInformation = IocContainer.GetIoc.Resolve<SDKEntryPointModel>().SDKInformation;
                    var tmp_Config = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value
                        .dashboardConfig;
                    var tmp_QueryParameter = new QueryParameter
                    {
                        experienceUid = projectUid,
                        Platform = RuntimePlatformHelper.GetPlatformName(),
                        URL = tmp_Config.dashboardGateway,
                        Token = tmp_Config.token,
                        Timeout = tmp_Config.timeout,
                        AppKey = tmp_Config.appKey,
                        BackendType = tmp_Config.backendType,
                        Env = tmp_SDKInformation.environmentType.ToString().ToLower()
                    };

                    tmp_Response =
                        await NetworkRequestFactory<ResponseMapper>.CreateNetworkRequest(networkRequestType,
                            tmp_QueryParameter);

                    var tmp_SDKEntryPointModel = IocContainer.GetIoc.Resolve<SDKEntryPointModel>();
                    tmp_SDKEntryPointModel.ResponseMapper = tmp_Response;

                    //  Download the experience file
                    //  Decompress the experience file 
                    //  Load experience
                    tmp_SDKEntryPointModel.XRExperienceData =
                        await NetworkRequestFactory<XRExperienceData>.CreateNetworkRequest(
                            NetworkRequestType.DownloadAssetBundleJson,
                            new QueryParameter
                            {
                                AssetBundleJsonUrl = tmp_Response.data.json_url.Trim().Replace("'", "")
                            }
                        );
                    base.Handle();
                }
                catch (Exception tmp_Exception)
                {
                    throw new Exception(
                        $"Experience not found.\n {JsonUtility.ToJson(tmp_Response)} \n{tmp_Exception}");
                }
            }
            catch (Exception e)
            {
                // TODO handle exception
                throw;
            }
        }
    }
}