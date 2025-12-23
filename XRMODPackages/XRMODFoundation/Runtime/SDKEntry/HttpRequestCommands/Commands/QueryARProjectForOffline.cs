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

using System.IO;
using System.Threading.Tasks;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.Mapper;
using Phantom.XRMOD.SDKEntry.Runtime.Models;
using UnityEngine;

namespace Phantom.XRMOD.SDKEntry.Runtime.DataRequest
{
    /// <summary>
    /// Command for locating and retrieving project metadata for offline experiences
    /// stored in the StreamingAssets folder.
    /// </summary>
    public readonly struct QueryARProjectForOffline : IHttpRequestCommand<ResponseMapper>
    {
        private readonly QueryParameter queryParameter;
        private const string _CONST_ASSET_SUFFIX = "arexperience";
        private const string _CONST_JSON_SUFFIX = "json";

        public QueryARProjectForOffline(QueryParameter _queryParameter)
        {
            queryParameter = _queryParameter;
        }

        public async Task<ResponseMapper> Execute()
        {
            string tmp_ProjectNameLowercase = queryParameter.experienceUid.ToLower();
            var tmp_RuntimePlatform = Utility.GetRuntimePlatform();
            var tmp_StreamingAssetWithPlatformPath = Path.Combine(Application.streamingAssetsPath, tmp_RuntimePlatform);
            var tmp_FinalStreamAsset = Path.Combine(tmp_StreamingAssetWithPlatformPath, tmp_ProjectNameLowercase);
            var tmp_BundleURL = Path.Combine(tmp_FinalStreamAsset, $"{tmp_ProjectNameLowercase}.{_CONST_ASSET_SUFFIX}");
            var tmp_JsonURL = Path.Combine(tmp_FinalStreamAsset, $"{tmp_ProjectNameLowercase}.{_CONST_JSON_SUFFIX}");
            var tmp_ResponseMapper = new ResponseMapper
            {
                status_code = 200,
                msg = "",
                data = Utility.MakeSurePlatformAsset(tmp_RuntimePlatform, tmp_BundleURL, tmp_JsonURL)
            };
            await Task.Delay(100);
            return tmp_ResponseMapper;
        }
    }
}