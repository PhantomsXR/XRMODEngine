// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/


#if UNITY_IOS && !UNITY_EDITOR
using System.Runtime.InteropServices;
#endif
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;


namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    // ReSharper disable once InconsistentNaming

    public class APICallback
    {
        #region Native implement

        public delegate void TryAcquireInformationDelegate(string _data);

        public static TryAcquireInformationDelegate TryAcquireInformationAction;


#if (UNITY_IOS || UNITY_VISIONOS) && ENABLE_NATIVE && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void throwException(string _errorMessage, int _errorCode);

        [DllImport("__Internal")]
        private static extern void deviceNotSupport();

        [DllImport("__Internal")]
        private static extern void experienceLoading(float _progressValue);

        [DllImport("__Internal")]
        private static extern void experienceStartLoad();
        
        [DllImport("__Internal")]
        private static extern void experienceLoadCompleted();
        
        [DllImport("__Internal")]
        private static extern void sdkInitialized();
        
        [DllImport("__Internal")]
        private static extern void openBuiltInBrowser(string _url);
        
        [DllImport("__Internal")]
        private static extern void recognitionStart();

        [DllImport("__Internal")]
        private static extern void recognitionComplete(); 
        
        [DllImport("__Internal")]
        private static extern void packageSizeMoreThanPresetSize(float _currentSize, float _presetSize);
        
        [DllImport("__Internal")]
        private static extern void onXRMODExit();
        
        [DllImport("__Internal")]
        private static extern void onXRMODLaunch();

        [DllImport("__Internal")]
        private static extern void onMessageReceived(string _data);
        
        [DllImport("__Internal")]
        private static extern void tryAcquireInformation(string _tag,TryAcquireInformationDelegate _callback);
        
        
        [AOT.MonoPInvokeCallback(typeof(TryAcquireInformationDelegate))]
        private static void TryAcquireInformationCallback(string _info)
        {
           TryAcquireInformationAction?.Invoke(_info);
        }
#elif UNITY_ANDROID && ENABLE_NATIVE && !UNITY_EDITOR
        private static AndroidJavaObject androidJavaObject;
        private const string CONST_PACKAGE_NAME = "com.phantomsxr.armodplugin.ARMODCallbackAPI";
        private const string CONST_NOT_SUPPORT_ARMODE = "deviceNotSupport";
        private const string CONST_EXPERIENCE_LOAD_COMPLETED = "experienceLoadCompleted";
        private const string CONST_EXPERIENCE_START_LOAD = "experienceStartLoad";
        private const string CONST_EXPERIENCE_LOADING = "experienceLoading";
        private const string CONST_ALERT = "throwException";
        private const string CONST_NEED_INSTALL_ARCORE_SERVICE = "needInstallARCoreService";
        private const string CONST_AR_ALGORITHM_INITIALIZED = "sdkInitialized";
        private const string CONST_OPEN_BUILTIN_BROWSER = "openBuiltInBrowser";
        private const string CONST_RECOGNITION_START = "recognitionStart";
        private const string CONST_RECOGNITION_COMPLETE = "recognitionComplete";
        private const string CONST_TRY_ACQUIRE_INFORMATION = "tryAcquireInformation";
        private const string CONST_PACKAGE_SIZE_MORE_THAN_PRESET_SIZE = "packageSizeMoreThanPresetSize";
        private const string CONST_ON_XRMOD_EXIT = "onXRMODExit";
        private const string CONST_ON_XRMOD_LAUNCH = "onXRMODLaunch";
        private const string CONST_ON_MESSAGE_RECEVIED = "onMessageReceived";

        class AndroidCallback:AndroidJavaProxy
        {
            public AndroidCallback() : base("com.phantomsxr.armodplugin.AndroidCallback") { }



            void TryAcquireInformationCallback(string _info)
            {
                TryAcquireInformationAction?.Invoke(_info);
            }
        }


        public static AndroidJavaObject GetAndroidJavaObject(string _packageNameWithActivity)
        {
            if (androidJavaObject != null) return androidJavaObject;
            AndroidJavaClass tmp_JavaClass = new AndroidJavaClass(_packageNameWithActivity);
            androidJavaObject = tmp_JavaClass.GetStatic<AndroidJavaObject>("instance");

            return androidJavaObject;
        }
#endif

        #endregion


        #region Native Unity Events

#if !ENABLE_NATIVE || UNITY_EDITOR
        public static event Action DeviceNotSupportEventHandle;

        public static event Action ExperienceStartLoadEventHandle;

        public static event Action<float> ExperienceLoadingEventHandle;

        public static event Action ExperienceLoadCompletedEventHandle;

        public static event Action<string, int> ThrowExceptionEventHandle;


        public static event Action SdkInitializedEventHandle;

        public static event Action<string> OpenBuiltInBrowserEventHandle;

        public static event Action RecognitionStartEventHandle;

        public static event Action RecognitionCompleteEventHandle;

        public static event Action<string, TryAcquireInformationDelegate> TryAcquireInformationEventHandle;

#pragma warning disable CS0067
        public static event Action NeedInstallARCoreServicesEventHandle;
#pragma warning restore CS0067

        public static event Action<float, float> PackageSizeMoreThanPresetSizeEventHandle;

        // ReSharper disable once InconsistentNaming
        // ReSharper disable once IdentifierTypo
        public static event Action OnXRMODExitEventHandle;

        // ReSharper disable once InconsistentNaming
        // ReSharper disable once IdentifierTypo
        public static event Action OnXRMODLaunchEventHandle;

        public static event Action<string> OnMessageReceivedHandle;
        public static event Action<ProcessChangeArgs> OnProcessesChangedHandle;
#endif

        #endregion

        public static void DeviceNotSupport()
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            deviceNotSupport();
#elif UNITY_ANDROID && ENABLE_NATIVE && !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_NOT_SUPPORT_ARMODE);
#else
            DeviceNotSupportEventHandle?.Invoke();
#endif
        }

        internal static void ExperienceStartLoad()
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            experienceStartLoad();
#elif UNITY_ANDROID && ENABLE_NATIVE && !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_EXPERIENCE_START_LOAD);
#else
            ExperienceStartLoadEventHandle?.Invoke();
#endif
        }

        internal static void ExperienceLoading(float _progressValue)
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            experienceLoading(_progressValue);
#elif UNITY_ANDROID && ENABLE_NATIVE && !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_EXPERIENCE_LOADING, _progressValue);
#else
            ExperienceLoadingEventHandle?.Invoke(_progressValue);
#endif
        }

        internal static void ExperienceLoadCompleted()
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            experienceLoadCompleted();
#elif UNITY_ANDROID && ENABLE_NATIVE && !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_EXPERIENCE_LOAD_COMPLETED);
#else
            ExperienceLoadCompletedEventHandle?.Invoke();
#endif
        }

        internal static void ThrowException(string _errorMessage, int _errorCode)
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            throwException(_errorMessage,_errorCode);
#elif UNITY_ANDROID && ENABLE_NATIVE && !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_ALERT, _errorMessage, _errorCode);
#else
            ThrowExceptionEventHandle?.Invoke(_errorMessage, _errorCode);
#endif
        }

        internal static void SdkInitialized()
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            sdkInitialized();
#elif UNITY_ANDROID && ENABLE_NATIVE && !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_AR_ALGORITHM_INITIALIZED);
#else
            SdkInitializedEventHandle?.Invoke();
#endif
        }

        internal static void OpenBuiltInBrowser(string _url)
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            openBuiltInBrowser(_url);
#elif UNITY_ANDROID && ENABLE_NATIVE && !UNITY_EDITOR
             GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_OPEN_BUILTIN_BROWSER, _url);
#else
            OpenBuiltInBrowserEventHandle?.Invoke(_url);
#endif
        }

        internal static void RecognitionStart()
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            recognitionStart();
#elif UNITY_ANDROID && ENABLE_NATIVE && !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_RECOGNITION_START);
#else
            RecognitionStartEventHandle?.Invoke();
#endif
        }

        internal static void RecognitionComplete()
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            recognitionComplete();
#elif UNITY_ANDROID && ENABLE_NATIVE&& !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_RECOGNITION_COMPLETE);
#else
            RecognitionCompleteEventHandle?.Invoke();
#endif
        }

        internal static void TryAcquireInformation(string _opCode, TryAcquireInformationDelegate _callback)
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            TryAcquireInformationAction = _callback;
            tryAcquireInformation(_opCode,TryAcquireInformationCallback);
#elif UNITY_ANDROID && ENABLE_NATIVE&& !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_TRY_ACQUIRE_INFORMATION,_opCode,new AndroidCallback());
#else
            TryAcquireInformationEventHandle?.Invoke(_opCode, _callback);
#endif
        }

        internal static void NeedInstallARCoreServices()
        {
#if UNITY_IOS && ENABLE_NATIVE
            //iOS does not use ARCore.
#elif UNITY_ANDROID && ENABLE_NATIVE&& !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_NEED_INSTALL_ARCORE_SERVICE);
#else
            NeedInstallARCoreServicesEventHandle?.Invoke();
#endif
        }

        internal static void PackageSizeMoreThanPresetSize(float _currentSize, float _presetSize)
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            packageSizeMoreThanPresetSize(_currentSize,_presetSize);
#elif UNITY_ANDROID && ENABLE_NATIVE&& !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_PACKAGE_SIZE_MORE_THAN_PRESET_SIZE,_currentSize,_presetSize);
#else
            PackageSizeMoreThanPresetSizeEventHandle?.Invoke(_currentSize, _presetSize);
#endif
        }

        internal static void OnXRMODExit()
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            onXRMODExit();
#elif UNITY_ANDROID && ENABLE_NATIVE&& !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_ON_XRMOD_EXIT);
#else
            OnXRMODExitEventHandle?.Invoke();
#endif
        }

        internal static void OnXRMODLaunch()
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            onXRMODLaunch();
#elif UNITY_ANDROID && ENABLE_NATIVE&& !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_ON_XRMOD_LAUNCH);
#else
            OnXRMODLaunchEventHandle?.Invoke();
#endif
        }

        /// <summary>
        /// Send a data(string) to XR-MOD Launcher
        /// </summary>
        /// <param name="_data">Will send message data</param>
        internal static void SendMessageToSDK(string _data)
        {
#if UNITY_IOS && ENABLE_NATIVE && !UNITY_EDITOR
            onMessageReceived(_data);
#elif UNITY_ANDROID && ENABLE_NATIVE&& !UNITY_EDITOR
            GetAndroidJavaObject(CONST_PACKAGE_NAME).Call(CONST_ON_MESSAGE_RECEVIED,_data);
#else
            OnMessageReceivedHandle?.Invoke(_data);
#endif
        }

        internal static void ProcessesChanged(ProcessChangeArgs _processChangeArgs)
        {
            OnProcessesChangedHandle?.Invoke(_processChangeArgs);
        }
    }
}