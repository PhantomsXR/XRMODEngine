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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.GameServices.Runtime
{
    /// <summary>
    /// The core manager for XRMOD Game Services. 
    /// Handles initialization and coordination of various game service modules like Voice, Friends, etc.
    /// </summary>
    public class XRMODGameServicesManager : MonoBehaviour
    {
        /// <summary>
        /// Singleton instance of the XRMODGameServicesManager.
        /// </summary>
        public static XRMODGameServicesManager GetInstance { get; private set; }

        /// <summary>
        /// Whether the Friend system should be initialized.
        /// </summary>
        public bool EnableFriend = true;

        /// <summary>
        /// Whether the Voice system should be initialized.
        /// </summary>
        [Header("Voice Properties")] public bool EnableVoice = true;

        /// <summary>
        /// Configuration arguments for the Voice system.
        /// </summary>
        [SerializeField] private ConfigurationArgs voiceConfigurationArgs;

        /// <summary>
        /// 3D audio properties for the Voice system.
        /// </summary>
        [SerializeField] private Voice3DProperties voice3DProperties;

        /// <summary>
        /// Invoked when all enabled Game Services are ready.
        /// </summary>
        public UnityEvent GameServicesReady;

        /// <summary>
        /// Invoked when Game Services initialization fails.
        /// </summary>
        public UnityEvent GameServicesFailed;

        private bool authReady;
        private bool voiceReady;
        private bool friendReady;
        private bool readyInvoked;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        static void Initialize()
        {
            var tmp_XRMODServicesManager = FindAnyObjectByType<XRMODGameServicesManager>();
            if (tmp_XRMODServicesManager == null)
            {
                GameObject tmp_XRMODGameServices = new GameObject("XRMOD GameServices", new[]
                {
                    typeof(XRMODGameServicesManager)
                });
            }
        }

        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
            GetInstance = this;
            voice3DProperties ??= new Voice3DProperties();
            authReady = false;
            voiceReady = false;
            friendReady = false;
            readyInvoked = false;
        }

        /// <summary>
        /// Initializes Unity Services with an optional profile name.
        /// This is the entry point for starting all XRMOD game services.
        /// </summary>
        /// <param name="_profileName">Optional profile name for authentication (e.g., for multi-login testing).</param>
        /// <example>
        /// <code>
        /// XRMODGameServicesManager.GetInstance.InitializeUnityServices("Player1");
        /// </code>
        /// </example>
        /// <remarks>
        /// Ensure this is called before using any other game services. 
        /// Profile names must be alphanumeric.
        /// </remarks>
        public async void InitializeUnityServices(string _profileName = null)
        {
            if (UnityServices.State != ServicesInitializationState.Uninitialized)
                return;

            UnityServices.Initialized += OnUnityServicesInitialized;
            UnityServices.InitializeFailed += OnUnityServicesInitializeFailed;

            if (_profileName != null)
            {
                //ProfileNames can't contain non-alphanumeric characters
                var tmp_Rgx = new Regex("[^a-zA-Z0-9 -]");
                _profileName = tmp_Rgx.Replace(_profileName, "");
                var tmp_AuthProfile = new InitializationOptions().SetProfile(_profileName);

                //If you are using multiple unity services, make sure to initialize it only once before using your services.
                await UnityServices.InitializeAsync(tmp_AuthProfile);
            }
            else
                await UnityServices.InitializeAsync();
        }

        /// <summary>
        /// Asynchronously initializes Unity Services with an optional profile name.
        /// Provides a Task that can be awaited.
        /// </summary>
        /// <param name="_profileName">Optional profile name for authentication.</param>
        /// <returns>A Task representing the initialization process.</returns>
        /// <example>
        /// <code>
        /// await XRMODGameServicesManager.GetInstance.InitializeUnityServicesAsync("TestUser");
        /// </code>
        /// </example>
        public async Task InitializeUnityServicesAsync(string _profileName = null)
        {
            if (UnityServices.State != ServicesInitializationState.Uninitialized)
                return;

            UnityServices.Initialized += OnUnityServicesInitialized;
            UnityServices.InitializeFailed += OnUnityServicesInitializeFailed;

            if (_profileName != null)
            {
                //ProfileNames can't contain non-alphanumeric characters
                var tmp_Rgx = new Regex("[^a-zA-Z0-9 -]");
                _profileName = tmp_Rgx.Replace(_profileName, "");
                var tmp_AuthProfile = new InitializationOptions().SetProfile(_profileName);

                //If you are using multiple unity services, make sure to initialize it only once before using your services.
                await UnityServices.InitializeAsync(tmp_AuthProfile);
            }
            else
                await UnityServices.InitializeAsync();
        }

        private void OnUnityServicesInitialized()
        {
            // Listen for Authentication sign-in first
            AuthenticationSystemManager.SignedInCallback += OnAuthSignedIn;

            // Ensure auth service callbacks are wired
            AuthenticationSystemManager.InitServices();
        }

        private void OnAuthSignedIn()
        {
            authReady = true;

            // Subscribe to voice login success before initializing, to avoid missing the event
            if (EnableVoice)
            {
#if USE_VIVOX || USE_AGORA_RTC || USE_PHOTON_VOICE
                Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter.DefaultCenter.AddObserver(
                    _data =>
                    {
                        if (_data is VoiceNotificationDataArgs v && v.VoiceEventKey == VoiceNotificationKey.OnLogged)
                        {
                            voiceReady = true;
                            CheckReady();
                        }
                    },
                    VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY);
#endif
                VoiceSystemManager.GetInstance.Initialize(JsonUtility.ToJson(voiceConfigurationArgs),
                    voice3DProperties);
            }

            // Subscribe to friend sign-in notification and initialize
            if (EnableFriend)
            {
                var tmp_RelMgr = RelationshipsManager.GetInstance;
                tmp_RelMgr.FriendSignedIn += OnFriendSignedIn;
                tmp_RelMgr.InitFriendProvider(AuthenticationSystemManager.GetUserInfo());
            }

            // If neither Voice nor Friend is enabled, auth alone determines readiness
            CheckReady();
        }

        private void OnFriendSignedIn()
        {
            friendReady = true;
            CheckReady();
        }

        private void CheckReady()
        {
            if (readyInvoked) return;

            // Determine required conditions
            bool tmp_NeedVoice = EnableVoice;
            bool tmp_NeedFriend = EnableFriend;

            bool tmp_ConditionsMet = authReady && (!tmp_NeedVoice || voiceReady) && (!tmp_NeedFriend || friendReady);
            if (tmp_ConditionsMet)
            {
                readyInvoked = true;
                GameServicesReady?.Invoke();
            }
        }

        private void OnUnityServicesInitializeFailed(Exception _exception)
        {
            GameServicesFailed?.Invoke();
        }
    }
}