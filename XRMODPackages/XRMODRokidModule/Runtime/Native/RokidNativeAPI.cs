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
    /// <summary>
    /// Singleton class providing native APIs for interacting with Rokid device features.
    /// Includes functionality for screen orientation, camera previews, and intrinsics/extrinsics.
    /// </summary>
    public class RokidNativeAPI
    {
        /// <summary>
        /// Gets the singleton instance of the <see cref="RokidNativeAPI"/>.
        /// </summary>
        public static RokidNativeAPI GetInstance => _INSTANCE ??= new RokidNativeAPI();

        /// <summary>
        /// Event invoked when the Unity screen orientation changes.
        /// </summary>
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
        /// Gets the phone controller screen height.
        /// </summary>
        public int PhoneScreenHeight => phoneScreenHeight;

        /// <summary>
        /// Gets the phone controller screen width.
        /// </summary>
        public int PhoneScreenWidth => phoneScreenWidth;

        /// <summary>
        /// Sets the system screen orientation for the Android activity.
        /// </summary>
        /// <param name="_orientation">The desired screen orientation.</param>
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
        /// Sets the Unity screen orientation and triggers the <see cref="OnUnityScreenOrientation"/> event.
        /// </summary>
        /// <param name="_orientation">The new orientation.</param>
        public void SetUnityScreenOrientation(ScreenOrientation _orientation)
        {
            unityOrientation = _orientation;
            OnUnityScreenOrientation?.Invoke(_orientation);
        }

        /// <summary>
        /// Gets the current Unity screen orientation.
        /// </summary>
        /// <returns>The current <see cref="ScreenOrientation"/>.</returns>
        public ScreenOrientation GetUnityScreenOrientation()
        {
            return unityOrientation;
        }

        /// <summary>
        /// Gets the current system screen orientation.
        /// </summary>
        /// <returns>The current system <see cref="ScreenOrientation"/>.</returns>
        public ScreenOrientation GetSystemScreenOrientation()
        {
            return systemOrientation;
        }

        /// <summary>
        /// Enables or disables the camera preview and sets the frame update callback.
        /// </summary>
        /// <param name="_enable">True to enable, false to disable.</param>
        /// <param name="_frameUpdateCallback">Callback invoked with camera data: bytes, width, height, timestamp.</param>
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
        /// Gets the camera focal length.
        /// </summary>
        /// <param name="_focalLength">Output array for focal length [fx, fy].</param>
        /// <returns>True if successful.</returns>
        public bool GetCameraFocalLength(out float[] _focalLength)
        {
            _focalLength = null;
            if (Application.isEditor || Application.platform != RuntimePlatform.Android) return false;
            _focalLength = new float[2]; // 焦距 [fx, fy]  
            return RokidExtensionAPI.RokidOpenXR_API_GetFocalLength(_focalLength) == 1;
        }

        /// <summary>
        /// Gets the camera principal point.
        /// </summary>
        /// <param name="_principalPoint">Output array for principal point [cx, cy].</param>
        /// <returns>True if successful.</returns>
        public bool GetPrincipalPoint(out float[] _principalPoint)
        {
            _principalPoint = null;
            if (Application.isEditor || Application.platform != RuntimePlatform.Android) return false;
            _principalPoint = new float[2]; // 主点 [cx, cy]  
            return RokidExtensionAPI.RokidOpenXR_API_GetPrincipalPoint(_principalPoint) == 1;
        }

        /// <summary>
        /// Gets the camera image dimensions.
        /// </summary>
        /// <param name="_dimensions">Output array for dimensions [width, height].</param>
        /// <returns>True if successful.</returns>
        public bool GetImageDimensions(out int[] _dimensions)
        {
            _dimensions = null;
            if (Application.isEditor || Application.platform != RuntimePlatform.Android) return false;
            _dimensions = new int[2]; // 图像尺寸 [width, height]  
            return RokidExtensionAPI.RokidOpenXR_API_GetImageDimensions(_dimensions) == 1;
        }

        /// <summary>
        /// Gets the camera distortion parameters.
        /// </summary>
        /// <param name="_distortionParams">Output array for distortion coefficients.</param>
        /// <returns>True if successful.</returns>
        public bool GetDistortion(out float[] _distortionParams)
        {
            _distortionParams = null;
            if (Application.isEditor || Application.platform != RuntimePlatform.Android) return false;
            _distortionParams = new float[5]; // 畸变参数，对于pinhole或fisheye相机可能有所不同  
            return RokidExtensionAPI.RokidOpenXR_API_GetDistortion(_distortionParams) == 1;
        }

        /// <summary>
        /// Retrieves the history camera pose for a given timestamp.
        /// </summary>
        /// <param name="_timestamp">The timestamp to query.</param>
        /// <param name="_pose">Output struct containing the position and rotation.</param>
        /// <returns>True if the pose was successfully retrieved.</returns>
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
        /// Retrieves the Rokid Station 2 touchpad (screen) dimensions on Android functionality.
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