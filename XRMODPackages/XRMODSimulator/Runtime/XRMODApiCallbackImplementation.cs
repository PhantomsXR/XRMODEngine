// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODSimulator.Runtime.
// //
// // The UnityXR-MODLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Phantom.XRMOD.XRMODSimulator.Runtime
{
    public class XRMODApiCallbackImplementation : MonoBehaviour
    {
#if UNITY_EDITOR

        public UnityEvent<float> OnExperienceLoading;
        public UnityEvent OnExperienceStartLoading;
        public UnityEvent OnExperienceLoadCompleted;


        private void Start()
        {
            APICallback.TryAcquireInformationEventHandle += OnTryAcquireInformationEventHandle;
            APICallback.ExperienceLoadingEventHandle += OnExperienceLoadingEventHandle;
            APICallback.ExperienceLoadCompletedEventHandle += OnExperienceLoadCompletedEventHandle;
            APICallback.ExperienceStartLoadEventHandle += OnExperienceStartLoadEventHandle;
            APICallback.SdkInitializedEventHandle += () => { Debug.Log("SDK Initialized"); };
            APICallback.OnProcessesChangedHandle += OnProcessesChangedHandle;
        }

        private void OnProcessesChangedHandle(ProcessChangeArgs _obj)
        {
        }


        private void OnExperienceStartLoadEventHandle()
        {
            OnExperienceStartLoading?.Invoke();
        }

        private void OnExperienceLoadCompletedEventHandle()
        {
            OnExperienceLoadCompleted?.Invoke();
        }

        private void OnExperienceLoadingEventHandle(float _progress)
        {
            OnExperienceLoading?.Invoke(_progress);
        }

        private void OnTryAcquireInformationEventHandle(string _opCode,
            APICallback.TryAcquireInformationDelegate _callback)
        {
            switch (_opCode)
            {
                case "RequestAuthorization":
#if USE_XRMOD_GAMESERVICES
                    var tmp_UserInfoModel = GetComponent<Simulator>().UserInfoModel;
                    _callback?.Invoke(JsonUtility.ToJson(tmp_UserInfoModel));
#else
                    Debug.LogError("XRMOD GameServices has not been install yet.");
#endif
                    break;
            }
        }
#endif
    }
}