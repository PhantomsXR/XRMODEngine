using System;
using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    public static class RuntimePlatformHelper
    {
        public static bool IsPlatform(PlatformType _platformType)
        {
            switch (_platformType)
            {
                case PlatformType.Pico:
                    break;
                case PlatformType.Pico3:
                    break;
                case PlatformType.Pico4:
                    break;
                case PlatformType.Pico4p:
                    break;
                case PlatformType.Pico4u:
                    break;
                case PlatformType.QuestPro:
                    return GetQuestModel() == PlatformType.QuestPro;
                case PlatformType.Quest2:
                    return GetQuestModel() == PlatformType.Quest2;
                case PlatformType.Quest3:
                    return GetQuestModel() == PlatformType.Quest3;
                case PlatformType.Quest3s:
                    return GetQuestModel() == PlatformType.Quest3s;
                case PlatformType.VisionOS:
                    break;
                case PlatformType.VisionOS_1_X:
                    break;
                case PlatformType.VisionOS_2_X:
                    break;
                case PlatformType.RokidLite:
                    return SystemInfo.deviceModel.ToLower().Contains("max2") ||
                           SystemInfo.deviceModel.ToLower().Contains("stationmaster");

                case PlatformType.RokidStudio:
                    return SystemInfo.deviceModel.ToLower().Contains("max pro") ||
                           SystemInfo.deviceModel.ToLower().Contains("stationpro");

                case PlatformType.HandheldARiOS:
                    break;
                case PlatformType.HandheldARAndroid:
                    break;
                case PlatformType.Web:
                    break;
                case PlatformType.WebAR:
                    break;
                case PlatformType.WebVR:
                    break;
                case PlatformType.WebXR:
                    break;
                case PlatformType.XReal:
                    break;
                case PlatformType.Classic3DOSX:
                    break;
                case PlatformType.Classic3DiOS:
                    break;
                case PlatformType.Classic3DLinux:
                    break;
                case PlatformType.Classic3DWindows:
                    break;
                case PlatformType.Classic3DAndroid:
                    break;
                case PlatformType.DedicatedServerOSX:
                    break;
                case PlatformType.DedicatedServerWin:
                    break;
                case PlatformType.DedicatedServerLinux:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_platformType), _platformType, null);
            }

            return false;
        }

        public static string GetPlatformName()
        {
#if PICO_INSTALL && UNITY_ANDROID
            return "Pico";
#elif HANDHELD_ARMODULE_INSTALL && UNITY_IOS
            return "iOS";
#elif HANDHELD_ARMODULE_INSTALL && UNITY_ANDROID
            return "Android";
#elif HOLOLENS_INSTALL && UNITY_WSA
            return "Hololens";
#elif QUEST_INSTALL && UNITY_ANDROID
            return "Quest";
#elif NRSDK_INSTALL && UNITY_ANDROID
            return "XReal";
#elif ROKID_INSTALL && UNITY_ANDROID
            return "Rokid";
#elif VISIONOS_INSTALL
            return "VisionOS";
#elif RAYNEO_INSTALL
            return "Rayneo";
#elif CLASSIC_3D_INSTALL && UNITY_STANDALONE_OSX && !UNITY_SERVER
            return "Classic3DOSX";
#elif CLASSIC_3D_INSTALL && UNITY_STANDALONE_WIN && !UNITY_SERVER
            return "Classic3DWindows";
#elif CLASSIC_3D_INSTALL && UNITY_STANDALONE_LINUX && !UNITY_SERVER
            return "Classic3DLinux";
#elif CLASSIC_3D_INSTALL && UNITY_IOS
            return "Classic3DiOS";
#elif CLASSIC_3D_INSTALL && UNITY_ANDROID
            return "Classic3DAndroid";
#elif CLASSIC_3D_INSTALL && UNITY_SERVER && UNITY_STANDALONE_OSX
             return "DedicatedServerOSX";
#elif CLASSIC_3D_INSTALL && UNITY_SERVER && UNITY_STANDALONE_WIN
             return "DedicatedServerWin";
#elif CLASSIC_3D_INSTALL && UNITY_SERVER && UNITY_STANDALONE_LINUX
             return "DedicatedServerLinux";
#else
            return "NonePlatform";
#endif
        }

        public static string GetRuntimePlatform()
        {
#if UNITY_IOS
            return "iOS";
#elif UNITY_ANDROID
            return "Android";
#elif UNITY_WSA
            return "WSAPlayer";
#elif WEBGL_INSTALL
            return "WebGL";
#else
            return "Android";
#endif
        }

        public static XRMODPlatform GetXRMODRuntimePlatformType()
        {
#if PICO_INSTALL && UNITY_ANDROID
            return "XRMODPlatform.Pico;
#elif HANDHELD_ARMODULE_INSTALL && (UNITY_IOS||UNITY_ANDROID)
            return XRMODPlatform.Mobile;
#elif HOLOLENS_INSTALL && UNITY_WSA
            return XRMODPlatform.Unknown;
#elif QUEST_INSTALL && UNITY_ANDROID
            return XRMODPlatform.Quest;
#elif XRSDK_INSTALL && UNITY_ANDROID
            return XRMODPlatform.XReal;
#elif ROKID_INSTALL && UNITY_ANDROID && ROKID_ARLITE
            return XRMODPlatform.RokidLite;
#elif ROKID_INSTALL && UNITY_ANDROID && ROKID_STUDIO
            return XRMODPlatform.RokidStudio;
#elif VISIONOS_INSTALL
            return XRMODPlatform.VisionOS;
#elif CLASSIC_3D_INSTALL && !UNITY_SERVER
            return XRMODPlatform.Classic3D;
#else
            return XRMODPlatform.Unknown;
#endif
        }

        public static bool IsVisionOS()
        {
#if VISIONOS_INSTALL
            return true;
#else
            return false;
#endif
        }

        public static bool IsPico()
        {
#if PICO_INSTALL && UNITY_ANDROID
            return true;
#else
            return false;
#endif
        }

        public static bool IsRokid()
        {
#if ROKID_INSTALL && UNITY_ANDROID
            return true;
#else
            return false;
#endif
        }


        public static bool IsHandheldAR()
        {
#if HANDHELD_ARMODULE_INSTALL && (UNITY_ANDROID||UNITY_IOS)
            return true;
#else
            return false;
#endif
        }

        public static bool IsXReal()
        {
#if (XREAL_INSTALL && UNITY_ANDROID) || UNITY_EDITOR
            return true;
#else
            return false;
#endif
        }

        public static bool IsHololens()
        {
#if HOLOLENS_INSTALL && UNITY_WSA
            return true;
#else
            return false;
#endif
        }

        public static bool IsQuest()
        {
#if QUEST_INSTALL && UNITY_ANDROID
            return true;
#else
            return false;
#endif
        }

        public static bool IsWebAR()
        {
#if WEB_AR_INSTALL && UNITY_WEBGL
            return true;
#else
            return false;
#endif
        }

        public static bool IsWebVR()
        {
#if WEB_VR_INSTALL && UNITY_WEBGL
            return true;
#else
            return false;
#endif
        }

        public static bool IsWeb3D()
        {
#if WEB_3D_INSTALL && UNITY_WEBGL
            return true;
#else
            return false;
#endif
        }

        public static bool IsClassic3D()
        {
#if CLASSIC_3D_INSTALL && (UNITY_IOS||UNITY_ANDROID||UNITY_STANDALONE)
            return true;
#else
            return false;
#endif
        }


        internal static PlatformType GetQuestModel()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            using var tmp_Build = new AndroidJavaClass("android.os.Build");
            string tmp_Device = tmp_Build.GetStatic<string>("DEVICE").ToLower();

            if (tmp_Device.Contains("hollywood"))
                return PlatformType.Quest2;
            if (tmp_Device.Contains("eureka"))
                return PlatformType.Quest3;

            if (tmp_Device.Contains("panther"))
                return PlatformType.Quest3s;

            if (tmp_Device.Contains("cambria"))
                return PlatformType.QuestPro;
#endif

            return PlatformType.Unknow;
        }
    }
}