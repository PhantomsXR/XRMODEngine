// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Agora.Runtime.
// //
// // The AgoraTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/


namespace Phantom.XRMOD.GameServices.Runtime
{
    [System.Serializable]
    public class WebResponseDataBody
    {
        public string token;
        public string channel_name;
        public string generate_type;
        public string user_info;
    }

    [System.Serializable]
    public class WebResponse
    {
        public int status_code;
        public string msg;
        public WebResponseDataBody data;
    }

    public class PermissionHelper
    {
        public static void RequestMicrophontPermission()
        {
#if (UNITY_2018_3_OR_NEWER && UNITY_ANDROID)
            if (!UnityEngine.Android.Permission.HasUserAuthorizedPermission(UnityEngine.Android.Permission.Microphone))
            {
                UnityEngine.Android.Permission.RequestUserPermission(UnityEngine.Android.Permission.Microphone);
            }
#endif
        }

        public static void RequestCameraPermission()
        {
#if (UNITY_2018_3_OR_NEWER && UNITY_ANDROID)
            if (!UnityEngine.Android.Permission.HasUserAuthorizedPermission(UnityEngine.Android.Permission.Camera))
            {
                UnityEngine.Android.Permission.RequestUserPermission(UnityEngine.Android.Permission.Camera);
            }
#endif
        }
    }

#if USE_AGORA_RTC && !USE_AGORA_OFFICIAL
    [System.Serializable]
    public class AgoraCallbackParam
    {
        public string @event;
        public string data;
    }

    [System.Serializable]
    public class AgoraConnectionParam
    {
        public string channelId;
        public uint uid;
    }

    [System.Serializable]
    public class AgoraErrorParam
    {
        public string errorCode;
    }
#endif
}