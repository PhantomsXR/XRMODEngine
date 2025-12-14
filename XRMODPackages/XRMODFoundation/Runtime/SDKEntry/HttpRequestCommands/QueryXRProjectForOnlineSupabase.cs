// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.SDKEntry.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Threading.Tasks;
using Phantom.XRMOD.SDKEntry.Runtime.Mapper;
using UnityEngine;

namespace Phantom.XRMOD.SDKEntry.Runtime.DataRequest
{
    public class QueryXRProjectForOnlineSupabase : IHttpRequestCommand<ResponseMapper>
    {
        private readonly QueryParameter queryParameter;

        public QueryXRProjectForOnlineSupabase(QueryParameter _queryParameter)
        {
            queryParameter = _queryParameter;
        }

        public async Task<ResponseMapper> Execute()
        {
            var tmp_Response = await Object.FindFirstObjectByType<SDKEntryPoint>().QuerySupabaseExperience(
                _url: queryParameter.URL,
                _supabaseKey: queryParameter.Token,
                _experienceId: queryParameter.experienceUid,
                _platform: queryParameter.Platform.ToLower(),
                _appKey: queryParameter.AppKey,
                _appSecret: queryParameter.AppSecret);
            if (tmp_Response.statusCode == 200)
            {
                return new ResponseMapper
                {
                    status_code = 0,
                    msg = null,
#if XRMOD_3_0_0_OR_NEWER
                    data = new ExperienceResourceMapper
                    {
                        user_uid = tmp_Response.package.Id,
                        app_uid = tmp_Response.package.ExperienceId,
                        project_uid = tmp_Response.package.ExperienceId,
                        bundle_url = tmp_Response.package.BundleUrl,
                        json_url = tmp_Response.package.BundleJson,
                        bundle_size = tmp_Response.package.FileSize / (1024 * 1024),
                        platform_type = tmp_Response.package.PlatformId
                    }
#endif
                };
            }

            return null;
        }
    }
}