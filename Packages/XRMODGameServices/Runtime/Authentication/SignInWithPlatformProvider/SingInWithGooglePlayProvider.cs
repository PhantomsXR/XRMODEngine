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

#if USE_GOOGLE_AUTHENTICATION
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
#endif

namespace AuthenticationModule.Runtime
{
    public class SingInWithGooglePlayProvider : IPlatformSignInProvider
    {
        private bool isInitialized;

        public void Initialize(Action _onSuccess = null, Action _onFailure = null)
        {
#if USE_GOOGLE_AUTHENTICATION
            var config = new PlayGamesClientConfiguration.Builder()
                // Requests an ID token be generated.  
                // This OAuth token can be used to
                // identify the player to other services such as Firebase.
                .RequestIdToken()
                .Build();

            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.DebugLogEnabled = true;
            PlayGamesPlatform.Activate();
            isInitialized = true;
#endif
        }

        public void SignIn(Action<UserInfoModel> _successCallback, Action<string> _failedCallback)
        {
#if USE_GOOGLE_AUTHENTICATION
            if (!isInitialized)
            {
                Initialize();
            }

            Social.localUser.Authenticate(_success =>
            {
                if (_success)
                {
                    var tmp_LocalUser = (PlayGamesLocalUser) Social.localUser;
                    _successCallback?.Invoke(new UserInfoModel
                    {
                        token = tmp_LocalUser.GetIdToken(),
                        player_name = tmp_LocalUser.userName,
                        email = tmp_LocalUser.email,
                        user_avatar = tmp_LocalUser.AvatarURL
                    });
                }
                else
                {
                    _failedCallback?.Invoke("Unsuccessful login");
                }
            });
#endif
        }
    }
}