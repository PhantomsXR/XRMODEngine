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

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Phantom.XRMOD.SDKEntry.Runtime.Mapper;
using Phantom.XRMOD.SDKEntry.Runtime.Models;
using UnityEngine;
using UnityEngine.Networking;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.SDKEntry.Runtime.DataRequest
{
    /// <summary>
    /// Command for querying project metadata from a Supabase backend service.
    /// Maps the Supabase-specific response to the SDK's internal <see cref="ResponseMapper"/>.
    /// </summary>
    public class QueryXRProjectForOnlineSupabase : IHttpRequestCommand<ResponseMapper>
    {
        private readonly QueryParameter queryParameter;

        public QueryXRProjectForOnlineSupabase(QueryParameter _queryParameter)
        {
            queryParameter = _queryParameter;
        }

        public async Task<ResponseMapper> Execute()
        {
            var tmp_SupabaseExperienceAsset = await SendGetRequest<SupabaseExperienceAssets>();
Debug.Log(tmp_SupabaseExperienceAsset.message);
            if (tmp_SupabaseExperienceAsset.code == 200)
            {
                Debug.Log(tmp_SupabaseExperienceAsset.data.bundle_url);
                return new ResponseMapper
                {
                    status_code = 0,
                    msg = null,
#if XRMOD_3_0_0_OR_NEWER
                    data = new ExperienceResourceMapper
                    {
                        app_uid = tmp_SupabaseExperienceAsset.data.project_id,
                        project_uid = tmp_SupabaseExperienceAsset.data.experience_id,
                        bundle_url = tmp_SupabaseExperienceAsset.data.bundle_url,
                        json_url = tmp_SupabaseExperienceAsset.data.config_url,
                        // ReSharper disable once PossibleLossOfFraction
                        bundle_size = tmp_SupabaseExperienceAsset.data.size / (1024 * 1024),
                        platform_type = tmp_SupabaseExperienceAsset.data.platform
                    }
#endif
                };
            }

            return null;
        }


        private async Task<ApiResponseSupabase<T>> SendGetRequest<T>()
        {
            StringBuilder tmp_Url = new StringBuilder();
            tmp_Url.Append(queryParameter.URL);
            tmp_Url.Append("/v1/experiences");
            tmp_Url.Append($"/{queryParameter.experienceUid}/assets");
            tmp_Url.Append($"?platform={queryParameter.Platform.ToLower()}");
            tmp_Url.Append($"&env={queryParameter.Env}"); 
            
            using UnityWebRequest tmp_Request = UnityWebRequest.Get(tmp_Url.ToString());

            if (!string.IsNullOrEmpty(queryParameter.AppKey))
            {
                tmp_Request.SetRequestHeader("x-app-key", queryParameter.AppKey);
            }

            if (!string.IsNullOrEmpty(queryParameter.BundleId))
            {
                tmp_Request.SetRequestHeader("x-bundle-id", queryParameter.BundleId);
            }

            UnityWebRequestAsyncOperation tmp_Operation = tmp_Request.SendWebRequest();

            while (!tmp_Operation.isDone)
            {
                await Task.Yield();
            }

            if (tmp_Request.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError($"[XrmodApi] Request failed: {tmp_Request.error}");
                throw new Exception(tmp_Request.error);
            }

            string tmp_JsonResponse = tmp_Request.downloadHandler.text;
            return JsonUtility.FromJson<ApiResponseSupabase<T>>(tmp_JsonResponse);
        }
    }
}