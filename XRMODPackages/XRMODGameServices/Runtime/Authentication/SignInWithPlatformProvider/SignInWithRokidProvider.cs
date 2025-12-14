// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.GameServices.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.GameServices.Runtime;

namespace AuthenticationModule.Runtime
{
    public class SignInWithRokidProvider : IPlatformSignInProvider
    {
        private string clientId;
        private string clientSecret;

        public SignInWithRokidProvider(string _clientId, string _clientSecret)
        {
            clientId = _clientId;
            clientSecret = _clientSecret;
        }

        public void Initialize(Action _onSuccess = null, Action _onFailure = null)
        {
#if ROKID_INSTALL && USE_ROKID_AUTHENTICATION
            AuthenticationModule.Runtime.Rokid.ThirdCloudHelper.Instance.Init();
#endif
        }

        public void SignIn(Action<UserInfoModel> _successCallback, Action<string> _failedCallback)
        {
#if ROKID_INSTALL && USE_ROKID_AUTHENTICATION
            AuthenticationModule.Runtime.Rokid.ThirdCloudHelper.Instance.GetUserInfo(clientId, clientSecret,
                _data =>
                {
                    var tpm_Token = string.Empty;
                    if (!string.IsNullOrEmpty(_data.mobile))
                    {
                        tpm_Token = $"Nn{_data.mobile}@{_data.accountId.Substring(0, 6)}";
                    }
                    else if (!string.IsNullOrEmpty(_data.email))
                    {
                        tpm_Token = $"Nn{_data.email.Split("@")[0]}@{_data.gmtCreate}";
                    }

                    _successCallback?.Invoke(new UserInfoModel
                    {
                        token = tpm_Token,
                        player_name = _data.userName,
                        email = null,
                        user_avatar = _data.headIcon,
                        mobile = _data.mobile,
                        accountId = _data.userId
                    });
                }, _failedCallback);
#endif
        }
    }
}