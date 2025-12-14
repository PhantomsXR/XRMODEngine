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
using System.Text;
using System.Collections;
using UnityEngine;
using Object = UnityEngine.Object;

#if USE_APPLE_AUTHENTICATION
using Unity.Services.Authentication;
using AppleAuth;
using AppleAuth.Enums;
using AppleAuth.Interfaces;
using AppleAuth.Native;
using Unity.Services.CloudSave;
using Unity.Services.Core;
using UnityEngine.Assertions;
#endif

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class SignInWithAppleProvider : IPlatformSignInProvider
    {
#if USE_APPLE_AUTHENTICATION
        IAppleAuthManager appleAuthManager;

        private IEnumerator loopToCheckState;
        private MonoBehaviour executorOfMonoBehaviour;
#endif
        public void Initialize(Action _onSuccess = null, Action _onFailure = null)
        {
#if USE_APPLE_AUTHENTICATION
            var tmp_Deserializer = new PayloadDeserializer();
            appleAuthManager = new AppleAuthManager(tmp_Deserializer);
            loopToCheckState = LoopToCheckState();
            executorOfMonoBehaviour = Object.FindFirstObjectByType<MonoBehaviour>();
            executorOfMonoBehaviour.StartCoroutine(loopToCheckState);
#endif
        }
#if USE_APPLE_AUTHENTICATION
        private IEnumerator LoopToCheckState()
        {
            while (true)
            {
                yield return null;
                if (appleAuthManager != null)
                    appleAuthManager.Update();
            }
        }
#endif

        public void SignIn(Action<UserInfoModel> _successCallback, Action<string> _failedCallback)
        {
#if USE_APPLE_AUTHENTICATION
            if (appleAuthManager == null)
            {
                Initialize();
            }

            Assert.IsNotNull(appleAuthManager, "Apple auth manager is NULL!");
            var tmp_SignInArgs = new AppleAuthLoginArgs(LoginOptions.IncludeEmail | LoginOptions.IncludeFullName);

            appleAuthManager?.LoginWithAppleId(tmp_SignInArgs,
                async _credential =>
                {
                    if (_credential is IAppleIDCredential tmp_AppleIdCredential)
                    {
                        var tmp_IdToken = Encoding.UTF8.GetString(tmp_AppleIdCredential.IdentityToken, 0,
                            tmp_AppleIdCredential.IdentityToken.Length);

                        var tmp_Credential = new UserInfoModel
                        {
                            token = tmp_IdToken
                        };
                        if (tmp_AppleIdCredential.FullName != null)
                        {
                            tmp_Credential.player_name =
                                $"{tmp_AppleIdCredential.FullName.GivenName}{tmp_AppleIdCredential.FullName.FamilyName}";
                        }

                        if (!string.IsNullOrEmpty(tmp_AppleIdCredential.Email))
                            tmp_Credential.email = tmp_AppleIdCredential.Email;

                        try
                        {
                            await AuthenticationService.Instance.SignInWithAppleAsync(tmp_Credential.token);
                            // First time auth
                            if (!string.IsNullOrEmpty(tmp_Credential.player_name))
                            {
                                var tmp_UpdatedName =
                                    await AuthenticationService.Instance.UpdatePlayerNameAsync(tmp_Credential
                                        .player_name);
                                tmp_Credential.player_name = AuthenticationService.Instance.PlayerName;
                            }
                            else if (string.IsNullOrEmpty(tmp_Credential.player_name))
                            {
                                tmp_Credential.player_name =
                                    await AuthenticationService.Instance.GetPlayerNameAsync();
                            }


                            // Stop Apple authentication checking
                            executorOfMonoBehaviour.StopCoroutine(loopToCheckState);
                            appleAuthManager = null;
                            _successCallback?.Invoke(tmp_Credential);
                        }
                        catch (AuthenticationException tmp_Ex)
                        {
                            // Compare error code to AuthenticationErrorCodes
                            // Notify the player with the proper error message
                            Debug.LogException(tmp_Ex);
                            _failedCallback?.Invoke(tmp_Ex.Message);
                        }
                        catch (RequestFailedException tmp_Ex)
                        {
                            // Compare error code to CommonErrorCodes
                            // Notify the player with the proper error message
                            Debug.LogException(tmp_Ex);
                            _failedCallback?.Invoke(tmp_Ex.Message);
                        }
                    }
                    else
                    {
                        _failedCallback?.Invoke("Retrieving Apple Id token failed.");
                    }
                },
                _error => { _failedCallback.Invoke($"Retrieving Apple Id token failed.\n{_error}"); });
#endif
        }
    }
}