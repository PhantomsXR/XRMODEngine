using System;
using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    /// <summary>
    /// Helper class for detecting and identifying the current runtime platform and device model.
    /// Provides methods to check for specific XR hardware and software configurations.
    /// </summary>
    public static class RuntimePlatformHelper
    {
        /// <summary>
        /// Checks if the current execution environment matches the specified <see cref="PlatformType"/>.
        /// </summary>
        /// <param name="_platformType">The platform type to check against.</param>
        /// <returns>True if the platform matches; otherwise, false.</returns>
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

        /// <summary>
        /// Gets a string representation of the current platform based on defined symbols.
        /// </summary>
        /// <returns>The name of the platform.</returns>
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

        /// <summary>
        /// Gets the runtime OS platform as a string.
        /// </summary>
        /// <returns>A string representing the OS (e.g., "iOS", "Android").</returns>
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

        /// <summary>
        /// Mapping from build-time defines to <see cref="XRMODPlatform"/> enum values.
        /// </summary>
        /// <returns>The <see cref="XRMODPlatform"/> for the current build.</returns>
        public static XRMODPlatform GetXRMODRuntimePlatformType()
        {
#if PICO_INSTALL && UNITY_ANDROID
            return XRMODPlatform.Pico;
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

        /// <summary>
        /// Is the current platform Apple VisionOS?
        /// </summary>
        public static bool IsVisionOS()
        {
#if VISIONOS_INSTALL
            return true;
#else
            return false;
#endif
        }

        /// <summary>
        /// Is the current platform Pico XR?
        /// </summary>
        public static bool IsPico()
        {
#if PICO_INSTALL && UNITY_ANDROID
            return true;
#else
            return false;
#endif
        }

        /// <summary>
        /// Is the current platform Rokid?
        /// </summary>
        public static bool IsRokid()
        {
#if ROKID_INSTALL && UNITY_ANDROID
            return true;
#else
            return false;
#endif
        }


        /// <summary>
        /// Is the current platform Handheld AR (ARKit/ARCore on Mobile)?
        /// </summary>
        public static bool IsHandheldAR()
        {
#if HANDHELD_ARMODULE_INSTALL && (UNITY_ANDROID||UNITY_IOS)
            return true;
#else
            return false;
#endif
        }

        /// <summary>
        /// Is the current platform XReal?
        /// </summary>
        public static bool IsXReal()
        {
#if (XREAL_INSTALL && UNITY_ANDROID) || UNITY_EDITOR
            return true;
#else
            return false;
#endif
        }

        /// <summary>
        /// Is the current platform Hololens?
        /// </summary>
        public static bool IsHololens()
        {
#if HOLOLENS_INSTALL && UNITY_WSA
            return true;
#else
            return false;
#endif
        }

        /// <summary>
        /// Is the current platform Meta Quest?
        /// </summary>
        public static bool IsQuest()
        {
#if QUEST_INSTALL && UNITY_ANDROID
            return true;
#else
            return false;
#endif
        }

        /// <summary>
        /// Is the current platform WebAR?
        /// </summary>
        public static bool IsWebAR()
        {
#if WEB_AR_INSTALL && UNITY_WEBGL
            return true;
#else
            return false;
#endif
        }

        /// <summary>
        /// Is the current platform WebVR?
        /// </summary>
        public static bool IsWebVR()
        {
#if WEB_VR_INSTALL && UNITY_WEBGL
            return true;
#else
            return false;
#endif
        }

        /// <summary>
        /// Is the current platform Web 3D (Non-AR/VR)?
        /// </summary>
        public static bool IsWeb3D()
        {
#if WEB_3D_INSTALL && UNITY_WEBGL
            return true;
#else
            return false;
#endif
        }

        /// <summary>
        /// Is the current platform Classic 3D (Non-XR)?
        /// </summary>
        public static bool IsClassic3D()
        {
#if CLASSIC_3D_INSTALL && (UNITY_IOS||UNITY_ANDROID||UNITY_STANDALONE)
            return true;
#else
            return false;
#endif
        }


        /// <summary>
        /// Internal method to detect the specific Meta Quest model.
        /// </summary>
        /// <returns>The detected <see cref="PlatformType"/> for Quest models.</returns>
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