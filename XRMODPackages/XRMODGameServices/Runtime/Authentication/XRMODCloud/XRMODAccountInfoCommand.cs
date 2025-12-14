// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Nin1.Runtime.
// //
// // The Nin1 cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class XRMODAccountInfoCommand
    {
        public async Task<UserInfoModel> Execute(string _data)
        {
            var tmp_Client = new HttpClient();
            var tmp_Request = new HttpRequestMessage(HttpMethod.Get, "https://phantomsxr.com/api/v2/auth/getuserinfo");
            tmp_Request.Headers.Add("Authorization", $"token {_data}");
            var tmp_Response = await tmp_Client.SendAsync(tmp_Request);
            tmp_Response.EnsureSuccessStatusCode();
            var tmp_UserInfoResponse = await tmp_Response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UserInfoModel>(tmp_UserInfoResponse);
        }
    }
}