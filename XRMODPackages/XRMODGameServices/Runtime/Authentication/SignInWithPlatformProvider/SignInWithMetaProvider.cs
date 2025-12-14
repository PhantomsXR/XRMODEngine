// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the AuthenticationSystem.Runtime.
// //
// // The Nin1 cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.GameServices.Runtime;

#if USE_META_AUTHENTICATION && META_PLATFORM_PLUGIN_INSTALL
using Newtonsoft.Json;
using Oculus.Platform;
using Oculus.Platform.Models;
using UnityEngine;
#endif

namespace AuthenticationModule.Runtime
{
    public class SignInWithMetaProvider : IPlatformSignInProvider
    {
        private bool isInitialized;

        public void Initialize(Action _onSuccess = null, Action _onFailure = null)
        {
#if USE_META_AUTHENTICATION
            Core.AsyncInitialize().OnComplete(_initializeState =>
            {
                isInitialized = !_initializeState.IsError;
                _onSuccess?.Invoke();
            });
#endif
        }


        public void SignIn(Action<UserInfoModel> _successCallback, Action<string> _failedCallback)
        {
#if USE_META_AUTHENTICATION
            if (!isInitialized)
            {
                Initialize();
                _failedCallback?.Invoke("Initialized failed.");
                return;
            }

            Entitlements.IsUserEntitledToApplication().OnComplete(_msg =>
            {
                if (_msg.IsError)
                {
                    _failedCallback?.Invoke(_msg.GetError().Message);
                    return;
                }

                Users.GetLoggedInUser().OnComplete(_user =>
                {
                    Users.GetUserProof().OnComplete(_userProof =>
                    {
                        var tmp_UserModel = new UserInfoModel
                        {
                            token = _userProof.Data.Value,
                            accountId = _user.Data.ID.ToString(),
                            player_name = string.IsNullOrEmpty(_user.Data.DisplayName)
                                ? _user.Data.OculusID
                                : _user.Data.DisplayName,
                            email = _user.Data.Presence,
                            user_avatar = _user.Data.ImageURL
                        };
                        _successCallback?.Invoke(tmp_UserModel);
                    });
                });
            });
#endif
        }
    }
}