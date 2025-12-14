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

using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class RegisterXRMODAccountCommand
    {
        public const string CONST_XRMOD_ACCOUNT_TOKEN = "XRMODAccountToken";
        public const string CONST_DEFAULT_AVATAR_IMG = "DefaultAvatarTexture";

        public async Task<UserInfoModel> Execute(UserInfoModel _userInfoModel)
        {
            if (_userInfoModel != null)
            {
                var tmp_AvatarTexture = Resources.Load<Texture2D>(CONST_DEFAULT_AVATAR_IMG);
                byte[] tmp_TextureData;
                using (var tmp_Stream = new MemoryStream(tmp_AvatarTexture.EncodeToJPG()))
                {
                    tmp_TextureData = tmp_Stream.ToArray();
                }

                Debug.Log($"TextureData:{tmp_TextureData.Length}");
                var tmp_StreamContent = new StreamContent(new MemoryStream(tmp_TextureData));

                var tmp_Client = new HttpClient();
                var tmp_Request = new HttpRequestMessage(HttpMethod.Post, "https://phantomsxr.com/api/v2/auth/signup");
                var tmp_Content = new MultipartFormDataContent();
                tmp_Content.Add(new StringContent(_userInfoModel.email), "user_email");
                tmp_Content.Add(new StringContent($"{_userInfoModel.player_name}@phantomsxr.com"), "user_password");
                tmp_Content.Add(new StringContent("0"), "user_industry");
                tmp_Content.Add(new StringContent(_userInfoModel.player_name), "user_name");
                tmp_Content.Add(tmp_StreamContent, "user_avatar", "avatar.jpg");
                tmp_Request.Content = tmp_Content;
                var tmp_Response = await tmp_Client.SendAsync(tmp_Request);
                tmp_Response.EnsureSuccessStatusCode();
                var tmp_ResponseStr = await tmp_Response.Content.ReadAsStringAsync();

                var tmp_XRMODAccountModel = JsonConvert.DeserializeObject<UserInfoModel>(tmp_ResponseStr);
                PlayerPrefs.SetString(PlayerPrefs.GetString(CONST_XRMOD_ACCOUNT_TOKEN),
                    tmp_XRMODAccountModel.token);
                Debug.Log(tmp_ResponseStr);
                return tmp_XRMODAccountModel;
            }

            return null;
        }
    }
}