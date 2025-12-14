// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.RokidModule.Runtime.
// //
// // The RokidPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System; 
using UnityEngine;
using UnityEngine.XR.OpenXR.Features;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    public class RokidNativeAPI
    {
        public static RokidNativeAPI GetInstance => _INSTANCE ??= new RokidNativeAPI();
        public static event Action<ScreenOrientation> OnUnityScreenOrientation;

        private int phoneScreenHeight = 0;
        private int phoneScreenWidth = 0;

        private static RokidNativeAPI _INSTANCE;
        private ScreenOrientation systemOrientation = ScreenOrientation.Portrait;
        private ScreenOrientation unityOrientation = ScreenOrientation.Portrait;

        private RokidNativeAPI()
        {
#if !UNITY_EDITOR && UNITY_ANDROID
            GetRokidStation2TouchPadSize();
#endif
        }

        /// <summary>
        /// Controller screen height
        /// </summary>
        public int PhoneScreenHeight => phoneScreenHeight;

        /// <summary>
        /// Controller screen width
        /// </summary>
        public int PhoneScreenWidth => phoneScreenWidth;

        /// <summary>
        /// Set controller orientation
        /// </summary>
        /// <param name="_orientation">Describes screen orientation.</param>
        public void SetSystemScreenOrientation(ScreenOrientation _orientation)
        {
            if (Application.isEditor || Application.platform != RuntimePlatform.Android) return;

            systemOrientation = _orientation;
            using AndroidJavaClass tmp_UnityPlayer = new("com.unity3d.player.UnityPlayer");
            using AndroidJavaObject tmp_CurrentActivity =
                tmp_UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            switch (_orientation)
            {
                case ScreenOrientation.Portrait:
                    tmp_CurrentActivity.Call("setRequestedOrientation", 1);
                    break;
                case ScreenOrientation.LandscapeLeft:
                    tmp_CurrentActivity.Call("setRequestedOrientation", 0);
                    break;
                case ScreenOrientation.PortraitUpsideDown:
                    tmp_CurrentActivity.Call("setRequestedOrientation", 9);
                    break;
                case ScreenOrientation.LandscapeRight:
                    tmp_CurrentActivity.Call("setRequestedOrientation", 8);
                    break;
            }
        }


        /// <summary>
        /// Set glasses orientation
        /// </summary>
        /// <param name="_orientation">Describes screen orientation.</param>
        public void SetUnityScreenOrientation(ScreenOrientation _orientation)
        {
            unityOrientation = _orientation;
            OnUnityScreenOrientation?.Invoke(_orientation);
        }

        /// <summary>
        /// Get Glasses orientation
        /// </summary>
        /// <returns></returns>
        public ScreenOrientation GetUnityScreenOrientation()
        {
            return unityOrientation;
        }

        /// <summary>
        /// Get controller orientation
        /// </summary>
        /// <returns></returns>
        public ScreenOrientation GetSystemScreenOrientation()
        {
            return systemOrientation;
        }

        /// <summary>
        /// Access Camera frame.
        /// </summary>
        /// <param name="_enable">If enable is true the glasses camera frame will allow to access, otherwise.</param>
        /// <param name="_frameUpdateCallback">Callback of every frame.</param>
        public void SetCameraPreview(bool _enable, Action<byte[], ushort, ushort, long> _frameUpdateCallback = null)
        {
            if (Application.isEditor || Application.platform != RuntimePlatform.Android) return;

            if (_enable)
            {
                RokidNativeMonoPInvokeCallbacks.FrameUpdateCallback = _frameUpdateCallback;
                RokidExtensionAPI.RokidOpenXR_API_OpenCameraPreview(RokidNativeMonoPInvokeCallbacks
                    .OnCameraDataUpdateCallWithImage);
            }
            else
            {
                RokidNativeMonoPInvokeCallbacks.FrameUpdateCallback = null;
                RokidExtensionAPI.RokidOpenXR_API_CloseCameraPreview();
            }
        }

        /// <summary>
        /// Get the camera focal length
        /// </summary>
        /// <param name="_focalLength">Focal length</param>
        /// <returns></returns>
        public bool GetCameraFocalLength(out float[] _focalLength)
        {
            _focalLength = null;
            if (Application.isEditor || Application.platform != RuntimePlatform.Android) return false;
            _focalLength = new float[2]; // 焦距 [fx, fy]  
            return RokidExtensionAPI.RokidOpenXR_API_GetFocalLength(_focalLength) == 1;
        }

        /// <summary>
        /// Get the camera principal point.
        /// </summary>
        /// <param name="_principalPoint">Principal point</param>
        /// <returns></returns>
        public bool GetPrincipalPoint(out float[] _principalPoint)
        {
            _principalPoint = null;
            if (Application.isEditor || Application.platform != RuntimePlatform.Android) return false;
            _principalPoint = new float[2]; // 主点 [cx, cy]  
            return RokidExtensionAPI.RokidOpenXR_API_GetPrincipalPoint(_principalPoint) == 1;
        }

        /// <summary>
        /// Get the camera frame image dimensions.
        /// </summary>
        /// <param name="_dimensions">Image dimensions</param>
        /// <returns></returns>
        public bool GetImageDimensions(out int[] _dimensions)
        {
            _dimensions = null;
            if (Application.isEditor || Application.platform != RuntimePlatform.Android) return false;
            _dimensions = new int[2]; // 图像尺寸 [width, height]  
            return RokidExtensionAPI.RokidOpenXR_API_GetImageDimensions(_dimensions) == 1;
        }

        /// <summary>
        /// Get the camera distortion params.
        /// </summary>
        /// <param name="_distortionParams">Distortion params</param>
        /// <returns></returns>
        public bool GetDistortion(out float[] _distortionParams)
        {
            _distortionParams = null;
            if (Application.isEditor || Application.platform != RuntimePlatform.Android) return false;
            _distortionParams = new float[5]; // 畸变参数，对于pinhole或fisheye相机可能有所不同  
            return RokidExtensionAPI.RokidOpenXR_API_GetDistortion(_distortionParams) == 1;
        }

        /// <summary>
        /// Get the history camera physics pose.
        /// </summary>
        /// <param name="_timestamp">The frame timestamp</param>
        /// <param name="_pose">The camera pose</param>
        /// <returns></returns>
        public bool GetHistoryCameraPhysicsPose(long _timestamp, out Pose _pose)
        {
            _pose = new Pose();
            if (Application.isEditor || Application.platform != RuntimePlatform.Android) return false;
            float[] tmp_Position = new float[3];
            float[] tmp_Rotation = new float[4];
            _pose.position = new Vector3(tmp_Position[0], tmp_Position[1], -tmp_Position[2]);
            _pose.rotation = new Quaternion(-tmp_Rotation[0], -tmp_Rotation[1], tmp_Rotation[2], tmp_Rotation[3]);
            return RokidExtensionAPI.RokidOpenXR_API_GetHistoryCameraPhysicsPose(_timestamp, tmp_Position,
                tmp_Rotation) ==1;
        }


        /// <summary>
        /// Get the touchpad controller size. 
        /// </summary>
        private void GetRokidStation2TouchPadSize()
        {
            if (Application.isEditor || Application.platform != RuntimePlatform.Android) return;

            using AndroidJavaClass tmp_UnityPlayerClass = new("com.unity3d.player.UnityPlayer");
            using AndroidJavaObject tmp_MetricsInstance = new AndroidJavaObject("android.util.DisplayMetrics"),
                tmp_ActivityInstance = tmp_UnityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity"),
                tmp_WindowManagerInstance = tmp_ActivityInstance.Call<AndroidJavaObject>("getWindowManager"),
                tmp_DisplayInstance = tmp_WindowManagerInstance.Call<AndroidJavaObject>("getDefaultDisplay");
            tmp_DisplayInstance.Call("getMetrics", tmp_MetricsInstance);
            phoneScreenHeight = tmp_MetricsInstance.Get<int>("heightPixels");
            phoneScreenWidth = tmp_MetricsInstance.Get<int>("widthPixels");
        }
    }
}