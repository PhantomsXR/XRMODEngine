// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODInput.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using UnityEngine;

#if UNITY_IOS
using System.Runtime.InteropServices;
#endif


namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// Static utility class for triggering haptic feedback and vibrations on mobile devices (iOS and Android).
    /// </summary>
    public static class Vibration
    {
#if UNITY_IOS
    [DllImport ( "__Internal" )]
    private static extern bool _HasVibrator ();

    [DllImport ( "__Internal" )]
    private static extern void _Vibrate ();

    [DllImport ( "__Internal" )]
    private static extern void _VibratePop ();

    [DllImport ( "__Internal" )]
    private static extern void _VibratePeek ();

    [DllImport ( "__Internal" )]
    private static extern void _VibrateNope ();

    [DllImport("__Internal")]
    private static extern void _impactOccurred(string style);

    [DllImport("__Internal")]
    private static extern void _notificationOccurred(string style);

    [DllImport("__Internal")]
    private static extern void _selectionChanged();
#endif

#if UNITY_ANDROID
        public static AndroidJavaClass UnityPlayer;
        public static AndroidJavaObject CurrentActivity;
        public static AndroidJavaObject Vibrator;
        public static AndroidJavaObject Context;

        public static AndroidJavaClass VibrationEffect;


#endif

        private static bool _INITIALIZED = false;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void AutoInit()
        {
            Init();
        }

        /// <summary>
        /// Initializes the vibration system. This is called automatically on load.
        /// </summary>
        public static void Init()
        {
            if (_INITIALIZED) return;

#if UNITY_ANDROID

            if (Application.isMobilePlatform)
            {
                UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                CurrentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                Vibrator = CurrentActivity.Call<AndroidJavaObject>("getSystemService", "vibrator");
                Context = CurrentActivity.Call<AndroidJavaObject>("getApplicationContext");
#if !ROKID_INSTALL
                if (AndroidVersion >= 26)
                {
                    VibrationEffect = new AndroidJavaClass("android.os.VibrationEffect");
                }
#endif
            }
#endif

            _INITIALIZED = true;
        }


        /// <summary>
        /// Triggers a haptic feedback on iOS using a specific impact style.
        /// </summary>
        /// <param name="_style">The impact feedback style (Heavy, Medium, Light, Rigid, Soft).</param>
        public static void VibrateIOS(ImpactFeedbackStyle _style)
        {
#if UNITY_IOS
        _impactOccurred(_style.ToString());
#endif
        }

        /// <summary>
        /// Triggers a haptic feedback on iOS using a specific notification style.
        /// </summary>
        /// <param name="_style">The notification feedback style (Error, Success, Warning).</param>
        public static void VibrateIOS(NotificationFeedbackStyle _style)
        {
#if UNITY_IOS
        _notificationOccurred(_style.ToString());
#endif
        }

        /// <summary>
        /// Triggers a selection change haptic feedback on iOS.
        /// </summary>
        public static void VibrateIOS_SelectionChanged()

        {
#if UNITY_IOS
        _selectionChanged();
#endif
        }


        /// <summary>
        /// Triggers a tiny pop vibration.
        /// </summary>
        public static void VibratePop()
        {
            if (Application.isMobilePlatform)
            {
#if UNITY_IOS
                _VibratePop ();
#elif UNITY_ANDROID
                VibrateAndroid(50);
#endif
            }
        }

        /// <summary>
        /// Triggers a small peek vibration.
        /// </summary>
        public static void VibratePeek()
        {
            if (Application.isMobilePlatform)
            {
#if UNITY_IOS
                _VibratePeek ();
#elif UNITY_ANDROID
                VibrateAndroid(100);
#endif
            }
        }

        /// <summary>
        /// Triggers a series of three small vibrations (often used for negative feedback).
        /// </summary>
        public static void VibrateNope()
        {
            if (!Application.isMobilePlatform) return;
#if UNITY_IOS
            _VibrateNope ();
#elif UNITY_ANDROID
            long[] tmp_Pattern = {0, 50, 50, 50};
            VibrateAndroid(tmp_Pattern, -1);
#endif
        }


#if UNITY_ANDROID
        /// <summary>
        /// Triggers a vibration for a specific number of milliseconds on Android.
        /// </summary>
        /// <param name="_milliseconds">The duration of the vibration in milliseconds.</param>
        public static void VibrateAndroid(long _milliseconds)
        {
            if (Application.isMobilePlatform)
            {
#if !ROKID_INSTALL
                if (AndroidVersion >= 26)
                {
                    AndroidJavaObject tmp_CreateOneShot =
                        VibrationEffect.CallStatic<AndroidJavaObject>("createOneShot", _milliseconds, -1);
                    Vibrator.Call("vibrate", tmp_CreateOneShot);
                }
                else
                {
                    Vibrator.Call("vibrate", _milliseconds);
                }
#else
                Vibrator.Call("vibrate", _milliseconds);
#endif
            }
        }

        /// <summary>
        /// Triggers a vibration with a specific pattern and repeat index on Android.
        /// </summary>
        /// <param name="pattern">The vibration pattern (alternating off/on durations).</param>
        /// <param name="repeat">The index into the pattern to begin repeating from, or -1 to not repeat.</param>
        public static void VibrateAndroid(long[] pattern, int repeat)
        {
            if (Application.isMobilePlatform)
            {
#if !ROKID_INSTALL
                if (AndroidVersion >= 26)
                {
                    _ = new long[pattern.Length];
                    AndroidJavaObject tmp_CreateWaveform =
                        VibrationEffect.CallStatic<AndroidJavaObject>("createWaveform", pattern, repeat);
                    Vibrator.Call("vibrate", tmp_CreateWaveform);
                }
                else
                {
                    Vibrator.Call("vibrate", pattern, repeat);
                }
#else
                Vibrator.Call("vibrate", pattern, repeat);
#endif
            }
        }
#endif

        /// <summary>
        /// Cancels any ongoing vibration on Android.
        /// </summary>
        public static void CancelAndroid()
        {
            if (Application.isMobilePlatform)
            {
#if UNITY_ANDROID
                Vibrator.Call("cancel");
#endif
            }
        }

        /// <summary>
        /// Checks if the device has a vibration motor.
        /// </summary>
        /// <returns><c>true</c> if the device has a vibrator, <c>false</c> otherwise.</returns>
        public static bool HasVibrator()
        {
            if (Application.isMobilePlatform)
            {
#if UNITY_ANDROID

                AndroidJavaClass tmp_ContextClass = new AndroidJavaClass("android.content.Context");
                string tmp_ContextVibratorService = tmp_ContextClass.GetStatic<string>("VIBRATOR_SERVICE");
                AndroidJavaObject tmp_SystemService =
                    Context.Call<AndroidJavaObject>("getSystemService", tmp_ContextVibratorService);
                return tmp_SystemService.Call<bool>("hasVibrator");

#elif UNITY_IOS
        return _HasVibrator ();
#else
        return false;
#endif
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Triggers a generic short vibration.
        /// </summary>
        public static void Vibrate()
        {
#if UNITY_ANDROID || UNITY_IOS

            if (Application.isMobilePlatform)
            {
                Handheld.Vibrate();
            }

#endif
        }

        /// <summary>
        /// Gets the Android SDK version.
        /// </summary>
        public static int AndroidVersion
        {
            get
            {
                int tmp_IVersionNumber = 0;
                if (Application.platform == RuntimePlatform.Android)
                {
                    string tmp_AndroidVersion = SystemInfo.operatingSystem;
                    int tmp_SDKPos = tmp_AndroidVersion.IndexOf("API-", StringComparison.Ordinal);
                    tmp_IVersionNumber = int.Parse(tmp_AndroidVersion.Substring(tmp_SDKPos + 4, 2).ToString());
                }

                return tmp_IVersionNumber;
            }
        }
    }

    /// <summary>
    /// Styles for iOS impact haptic feedback.
    /// </summary>
    public enum ImpactFeedbackStyle
    {
        /// <summary>
        /// A heavy impact feel.
        /// </summary>
        Heavy,
        /// <summary>
        /// A medium impact feel.
        /// </summary>
        Medium,
        /// <summary>
        /// A light impact feel.
        /// </summary>
        Light,
        /// <summary>
        /// A rigid impact feel.
        /// </summary>
        Rigid,
        /// <summary>
        /// A soft impact feel.
        /// </summary>
        Soft
    }

    /// <summary>
    /// Styles for iOS notification haptic feedback.
    /// </summary>
    public enum NotificationFeedbackStyle
    {
        /// <summary>
        /// An error notification feel.
        /// </summary>
        Error,
        /// <summary>
        /// A success notification feel.
        /// </summary>
        Success,
        /// <summary>
        /// A warning notification feel.
        /// </summary>
        Warning
    }
}