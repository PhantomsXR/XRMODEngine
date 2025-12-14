using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AuthenticationModule.Runtime;
using Newtonsoft.Json;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;

namespace Phantom.XRMOD.GameServices.Runtime
{
    /// <summary>
    /// Sample implementation of the Unity Authentication Service.
    /// </summary>
    public class AuthenticationSystemManager
    {
        public static event Action SignedInCallback;
        public static event Action SignOutCallback;
        public static event Action<RequestFailedException> SignFailedCallback;
        public static event Action<SignInCodeInfo> SignInCodeReceivedCallback;
        public static event Action SignInCodeExpiredCallback;
        public static event Action ExpiredCallback;

        private static bool isSiginning;


        private static UserInfoModel _USER_INFO_MODEL = new();

        public static void InitServices()
        {
            // AuthenticationService.SignedIn execute before got the user data
            // AuthenticationService.Instance.SignedIn += SignedInCallback;

            AuthenticationService.Instance.SignedOut += SignOutCallback;
            AuthenticationService.Instance.SignInFailed += SignFailedCallback;
            AuthenticationService.Instance.SignInCodeExpired += SignInCodeExpiredCallback;
            AuthenticationService.Instance.SignInCodeReceived += SignInCodeReceivedCallback;
            AuthenticationService.Instance.Expired += ExpiredCallback;
        }

        #region Custom UserName and Password APIs

        public static async Task SignInUserNameWithPassword(string _userName, string _pwd, Action<string> _error)
        {
            try
            {
                await AuthenticationService.Instance.SignInWithUsernamePasswordAsync(_userName, _pwd);
            }
            catch (AuthenticationException tmp_Ex)
            {
                // Compare error code to AuthenticationErrorCodes
                // Notify the player with the proper error message
                Debug.LogError($"Authentication:{tmp_Ex}");
                _error?.Invoke(tmp_Ex.Message);
            }
            catch (RequestFailedException tmp_Ex)
            {
                // Compare error code to CommonErrorCodes
                // Notify the player with the proper error message
                Debug.LogError(tmp_Ex);
                _error?.Invoke(tmp_Ex.Message);
            }
        }

        public static async Task UpdateUserNamePassword(string _currentPwd, string _newPwd)
        {
            try
            {
                await AuthenticationService.Instance.UpdatePasswordAsync(_currentPwd, _newPwd);
            }
            catch (AuthenticationException tmp_Ex)
            {
                // Compare error code to AuthenticationErrorCodes
                // Notify the player with the proper error message
                Debug.LogException(tmp_Ex);
            }
            catch (RequestFailedException tmp_Ex)
            {
                // Compare error code to CommonErrorCodes
                // Notify the player with the proper error message
                Debug.LogException(tmp_Ex);
            }
        }

        public static async Task SignUpUserNameWithPassword(string _userName, string _newPwd, Action<string> _error)
        {
            try
            {
                await AuthenticationService.Instance.SignUpWithUsernamePasswordAsync(_userName, _newPwd);
            }
            catch (AuthenticationException tmp_Ex)
            {
                // Compare error code to AuthenticationErrorCodes
                // Notify the player with the proper error message
                Debug.LogException(tmp_Ex);
                _error?.Invoke(tmp_Ex.Message);
            }
            catch (RequestFailedException tmp_Ex)
            {
                // Compare error code to CommonErrorCodes
                // Notify the player with the proper error message
                Debug.LogException(tmp_Ex);
                _error?.Invoke(tmp_Ex.Message);
            }
        }

        #endregion

        #region Sign with Platforms

        /// <summary>
        /// Sign in with apple account
        /// </summary>  
        public static void SignInWithApple()
        {
#if USE_APPLE_AUTHENTICATION
            var tmp_AppleIdSignInProvider = PlatformProviderFactory.GetPlatformProvider(PlatformProviderType.Apple);
            tmp_AppleIdSignInProvider.Initialize();
            tmp_AppleIdSignInProvider.SignIn(_userInfo =>
            {
                _USER_INFO_MODEL = _userInfo;
                SignedInCallback?.Invoke();
            }, Debug.LogError);
#endif
        }


        public static async void SignInWithAppIdToken(string _idToken)
        {
            var tmp_Credential = new UserInfoModel
            {
                token = _idToken
            };


            try
            {
                await AuthenticationService.Instance.SignInWithAppleAsync(tmp_Credential.token);

                if (string.IsNullOrEmpty(tmp_Credential.player_name))
                {
                    var tmp_PlayerName = await AuthenticationService.Instance.GetPlayerNameAsync();
                    tmp_Credential.player_name = tmp_PlayerName;
                }

                // Cloud save user information to cloud
                if (!string.IsNullOrEmpty(tmp_Credential.email))
                {
                    tmp_Credential.player_name = AuthenticationService.Instance.PlayerInfo.Username;
                    var tmp_UserInfoDict = new System.Collections.Generic.Dictionary<string, object>()
                    {
                        {"UserInformation", tmp_Credential}
                    };
                    await Unity.Services.CloudSave.CloudSaveService.Instance.Data.Player.SaveAsync(tmp_UserInfoDict);
                }
                else
                {
                    var tmp_Result = await Unity.Services.CloudSave.CloudSaveService.Instance.Data.Player.LoadAsync(
                        new System.Collections.Generic.HashSet<string> {"UserInformation"});
                    if (tmp_Result.TryGetValue("UserInformation", out var tmp_Item))
                    {
                        tmp_Credential = tmp_Item.Value.GetAs<UserInfoModel>();
                    }
                }

                SignedInCallback?.Invoke();

                // Stop Apple authentication checking
            }
            catch (AuthenticationException tmp_Ex)
            {
                // Compare error code to AuthenticationErrorCodes
                // Notify the player with the proper error message
                Debug.LogException(tmp_Ex);
            }
            catch (RequestFailedException tmp_Ex)
            {
                // Compare error code to CommonErrorCodes
                // Notify the player with the proper error message
                Debug.LogException(tmp_Ex);
            }
        }

        /// <summary>
        /// Sign in with google account
        /// </summary> 
        public static void SignInWithGooglePlay()
        {
#if UNITY_ANDROID && USE_GOOGLE_AUTHENTICATION
            IPlatformSignInProvider tmp_PlatformSignInProvider = new SingInWithGooglePlayProvider();
            tmp_PlatformSignInProvider.SignIn(
                async _credential =>
                {
                    try
                    {
                        await AuthenticationService.Instance.SignInWithGoogleAsync(_credential.token);
                        var tmp_PlayerName = await AuthenticationService.Instance.GetPlayerNameAsync(false);

                        _USER_INFO_MODEL = _credential;
                        SignedInCallback?.Invoke();
                    }
                    catch (AuthenticationException tmp_Ex)
                    {
                        // Compare error code to AuthenticationErrorCodes
                        // Notify the player with the proper error message
                        Debug.LogException(tmp_Ex);
                    }
                    catch (RequestFailedException tmp_Ex)
                    {
                        // Compare error code to CommonErrorCodes
                        // Notify the player with the proper error message
                        Debug.LogException(tmp_Ex);
                    }
                },
                Debug.LogError);
#endif
        }

        /// <summary>
        /// Sign in with meta account
        /// </summary> 
        public static void SignInWithMeta()
        {
#if USE_META_AUTHENTICATION
            IPlatformSignInProvider tmp_SignInProvider = new SignInWithMetaProvider();
            tmp_SignInProvider.Initialize(() =>
            {
                tmp_SignInProvider.SignIn(async _credential =>
                {
                    try
                    {
                        await AuthenticationService.Instance.SignInWithOculusAsync(_credential.token,
                            _credential.accountId);
                        
                        if (!string.IsNullOrEmpty(_credential.player_name))
                        {
                            await AuthenticationService.Instance.UpdatePlayerNameAsync(_credential.player_name);
                        }

                        _USER_INFO_MODEL = _credential;
                        SignedInCallback?.Invoke();
                    }
                    catch (AuthenticationException tmp_Ex)
                    {
                        // Compare error code to AuthenticationErrorCodes
                        // Notify the player with the proper error message
                        Debug.LogException(tmp_Ex);
                    }
                    catch (RequestFailedException tmp_Ex)
                    {
                        // Compare error code to CommonErrorCodes
                        // Notify the player with the proper error message
                        Debug.LogException(tmp_Ex);
                    }
                }, Debug.LogError);
            });

#endif
        }

        /// <summary>
        /// Sign in with rokid account
        /// </summary>
        /// <param name="_clientId">Rokid platform client id</param>
        /// <param name="_clientSecret">Rokid platform client secret</param> 
        public static void SignInWithRokid(string _clientId, string _clientSecret)
        {
#if USE_ROKID_AUTHENTICATION
            var tmp_RokidSignInProvider = PlatformProviderFactory.GetPlatformProvider(PlatformProviderType.Rokid);
            tmp_RokidSignInProvider.Initialize();
            tmp_RokidSignInProvider.SignIn(async _userInfo =>
            {
                string tmp_UserName;
                if (!string.IsNullOrEmpty(_userInfo.email))
                    tmp_UserName = $"n{_userInfo.email.Split("@")[0]}";
                else if (!string.IsNullOrEmpty(_userInfo.mobile))
                    tmp_UserName = $"n{_userInfo.mobile}";
                else
                    tmp_UserName = $"n{_userInfo.accountId.Substring(0, 11)}";
                bool tmp_IsExists = false;
                await SignUpUserNameWithPassword(tmp_UserName, _userInfo.token, async _error =>
                {
                    if (!_error.Contains("exists")) return;
                    await SignInUserNameWithPassword(tmp_UserName, _userInfo.token, Debug.LogError);
                    if (!string.IsNullOrEmpty(_userInfo.player_name))
                        await AuthenticationService.Instance.UpdatePlayerNameAsync(_userInfo.player_name);
                    SignedInCallback?.Invoke();
                });
            }, Debug.LogError);
#endif
        }

        #endregion

        /// <summary>
        /// A cached player is a player who has their session token cached on the SDK.
        /// Every time a sign in event is successful, the SDK caches a session token.
        /// A cached player exists if these conditions are fulfilled:
        ///  - The player previously signed in with Unity Authentication via anonymous login or platform login.
        ///  - The cached session token hasn't been deleted.
        /// If the session token exists, then the <see cref="SignInWithCache"/> method recovers the existing credentials
        /// of a player, regardless of whether they signed in anonymously or through a platform account. 
        /// </summary> 
        public static async Task SignInWithCache()
        {
            if (!AuthenticationService.Instance.SessionTokenExists) return;
            if (AuthenticationService.Instance.IsSignedIn) return;
            if (AuthenticationService.Instance.IsAuthorized) return;
            if (isSiginning) return;
            isSiginning = true;
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                isSiginning = false;
                _USER_INFO_MODEL = new UserInfoModel
                {
                    token = AuthenticationService.Instance.AccessToken,
                    player_name = AuthenticationService.Instance.PlayerName,
                    email = string.Empty,
                    user_avatar = string.Empty
                };
                SignedInCallback?.Invoke();
            }
            catch (AuthenticationException tmp_Ex)
            {
                // Compare error code to AuthenticationErrorCodes
                // Notify the player with the proper error message
                Debug.LogException(tmp_Ex);
            }
            catch (RequestFailedException tmp_Ex)
            {
                // Compare error code to CommonErrorCodes
                // Notify the player with the proper error message
                Debug.LogException(tmp_Ex);
            }
        }

        /// <summary>
        /// Sign in with anonymous user
        /// </summary> 
        public static async Task SignInWithAnonymous()
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                var tmp_PlayerName = await AuthenticationService.Instance.GetPlayerNameAsync(true);
                _USER_INFO_MODEL = new UserInfoModel()
                {
                    email = String.Empty,
                    user_avatar = string.Empty,
                    player_name = tmp_PlayerName
                };
                SignedInCallback?.Invoke();
            }
            catch (AuthenticationException ex)
            {
                // Compare error code to AuthenticationErrorCodes
                // Notify the player with the proper error message
                Debug.LogException(ex);
            }
            catch (RequestFailedException ex)
            {
                // Compare error code to CommonErrorCodes
                // Notify the player with the proper error message
                Debug.LogException(ex);
            }
        }


        /// <summary>
        /// Sign out current account
        /// </summary>
        /// <param name="_profileName">The signin profile</param>
        public static void SignOut(string _profileName = null)
        {
            if (AuthenticationService.Instance.IsAuthorized || AuthenticationService.Instance.IsSignedIn)
            {
                _USER_INFO_MODEL.CleanUp();
                AuthenticationService.Instance.SignOut();
                AuthenticationService.Instance.ClearSessionToken();
            }
        }

        /// <summary>
        /// Delete current account
        /// </summary>
        public static void DeleteAccount()
        {
            AuthenticationService.Instance.DeleteAccountAsync();
        }

        /// <summary>
        /// Get current user information
        /// </summary>
        /// <returns>The user information</returns>
        public static UserInfoModel GetUserInfo()
        {
            _USER_INFO_MODEL.player_name = AuthenticationService.Instance.PlayerName;
            _USER_INFO_MODEL.accountId = AuthenticationService.Instance.PlayerId;
            return _USER_INFO_MODEL;
        }

        /// <summary>
        /// Refresh the authentication token
        /// </summary>
        /// <param name="_token">The old token</param>
        public static void ProcessAuthenticationTokens(string _token)
        {
            AuthenticationService.Instance.ProcessAuthenticationTokens(_token);
        }

        /// <summary>
        /// Change the player name
        /// </summary>
        /// <param name="_playerName">The new player name</param>
        public static void UpdatePlayerName(string _playerName)
        {
            AuthenticationService.Instance.UpdatePlayerNameAsync(_playerName);
        }

        public static bool IsSignedIn => AuthenticationService.Instance.IsSignedIn;
        public static bool IsAuthorized => AuthenticationService.Instance.IsAuthorized;

        public static bool IsExpired => AuthenticationService.Instance.IsExpired;

        public static bool SessionTokenExists => AuthenticationService.Instance.SessionTokenExists;
    }
}