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
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

#if UNITY_IOS
using System.Collections;
using System.Runtime.InteropServices;
#endif


namespace Phantom.XRMOD.XRMODInput.Runtime
{
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


        public static void VibrateIOS(ImpactFeedbackStyle _style)
        {
#if UNITY_IOS
        _impactOccurred(_style.ToString());
#endif
        }

        public static void VibrateIOS(NotificationFeedbackStyle _style)
        {
#if UNITY_IOS
        _notificationOccurred(_style.ToString());
#endif
        }

        public static void VibrateIOS_SelectionChanged()

        {
#if UNITY_IOS
        _selectionChanged();
#endif
        }


        ///<summary>
        /// Tiny pop vibration
        ///</summary>
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

        ///<summary>
        /// Small peek vibration
        ///</summary>
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

        ///<summary>
        /// 3 small vibrations
        ///</summary>
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
        ///<summary>
        /// Only on Android
        /// https://developer.android.com/reference/android/os/Vibrator.html#vibrate(long)
        ///</summary>
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

        ///<summary>
        /// Only on Android
        /// https://proandroiddev.com/using-vibrate-in-android-b0e3ef5d5e07
        ///</summary>
        public static void VibrateAndroid(long[] pattern, int repeat)
        {
            if (Application.isMobilePlatform)
            {
#if !ROKID_INSTALL
                if (AndroidVersion >= 26)
                {
                    long[] tmp_Amplitudes;
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

        ///<summary>
        ///Only on Android
        ///</summary>
        public static void CancelAndroid()
        {
            if (Application.isMobilePlatform)
            {
#if UNITY_ANDROID
                Vibrator.Call("cancel");
#endif
            }
        }

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


        public static void Vibrate()
        {
#if UNITY_ANDROID || UNITY_IOS

            if (Application.isMobilePlatform)
            {
                Handheld.Vibrate();
            }

#endif
        }

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

    public enum ImpactFeedbackStyle
    {
        Heavy,
        Medium,
        Light,
        Rigid,
        Soft
    }

    public enum NotificationFeedbackStyle
    {
        Error,
        Success,
        Warning
    }
}