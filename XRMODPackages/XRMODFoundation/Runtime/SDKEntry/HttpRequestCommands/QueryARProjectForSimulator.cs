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

using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.Mapper;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.SDKEntry.Runtime.DataRequest
{
    public readonly struct QueryARProjectForSimulator : IHttpRequestCommand<ResponseMapper>
    {
        private const string _CONST_ASSETS_FOLDER = "Assets";
        private const string _CONST_SERVER_DATA_FOLDER = "ServerData";
        private const string _CONST_ASSET_SUFFIX = "arexperience";
        private const string _CONST_JSON_SUFFIX = "json";
        private readonly QueryParameter queryParameter;


        public QueryARProjectForSimulator(QueryParameter _queryParameter)
        {
            queryParameter = _queryParameter;
        }

        public async Task<ResponseMapper> Execute()
        {
            string tmp_ProjectNameLowercase = queryParameter.experienceUid.ToLower().Trim();
            var tmp_ServerDataWithPlatform = queryParameter.URL.Trim();

            // Fix support for Multiplayer play mode 
            const string tmp_const_ConstTMPMatchString = "Library";
            if (tmp_ServerDataWithPlatform.Contains(tmp_const_ConstTMPMatchString))
            {
                var tmp_IdxOfMatch =
                    tmp_ServerDataWithPlatform.IndexOf(tmp_const_ConstTMPMatchString, StringComparison.Ordinal);
                if (tmp_IdxOfMatch != -1)
                {
                    var tmp_SplitPaths = tmp_ServerDataWithPlatform.Split(tmp_const_ConstTMPMatchString);
                    var tmp_SplitPathOfServerData = tmp_SplitPaths[1].Split("ServerData");
                    StringBuilder tmp_PathBuilder = new StringBuilder(tmp_SplitPaths[0]);
                    tmp_PathBuilder.Append("ServerData");
                    tmp_PathBuilder.Append(tmp_SplitPathOfServerData[1]);
                    tmp_ServerDataWithPlatform = tmp_PathBuilder.ToString();
                }
            }

            var tmp_FinalServerDataPath = Path.Combine(tmp_ServerDataWithPlatform, tmp_ProjectNameLowercase);
            var tmp_BundleURL =
                Path.Combine(tmp_FinalServerDataPath, $"{tmp_ProjectNameLowercase}.{_CONST_ASSET_SUFFIX}");
            var tmp_JsonURL = Path.Combine(tmp_FinalServerDataPath, $"{tmp_ProjectNameLowercase}.{_CONST_JSON_SUFFIX}");

            var tmp_ResponseMapper = new ResponseMapper
            {
                status_code = 200,
                msg = "",
                data = Utility.MakeSurePlatformAsset(RuntimePlatformHelper.GetPlatformName(), tmp_BundleURL,
                    tmp_JsonURL)
            };

            await Task.Delay(1000);
            return tmp_ResponseMapper;
        }
    }
}