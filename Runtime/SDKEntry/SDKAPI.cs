// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.SDKEntry.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using UnityEngine; 
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.Logic;


namespace Phantom.XRMOD.SDKEntry.Runtime
{
    public partial class SDKEntryPoint
    {
        #region SDK Interface

        /// <summary>
        /// Initialize sdk through configure data
        /// </summary>
        /// <param name="_config">The <see cref="SDKConfiguration"/> json format string value.</param>
        public void InitSDK(string _config)
        {
            try
            {
                if (!awakeInvoked)
                    Awake();

                var tmp_SDKConfig = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration;
                tmp_SDKConfig.OnValueChanged += _ =>
                {
                    if (tmp_SDKConfig.Value.AppModel == AppModel.Offline)
                    {
                        IocContainer.GetIoc.Resolve<OfflineLicenseValidator>().Execute();
                    }

                    if (sdkKernel.Model.SdkInitialed == null) return;
                    sdkKernel.Model.SdkInitialed.Value = true;
                };

                tmp_SDKConfig.Value = JsonUtility.FromJson<SDKConfiguration>(_config);
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                APICallback.ThrowException(nameof(ErrorCode.INIT_SDK_FAILED),
                    (int) ErrorCode.INIT_SDK_FAILED);
                throw;
            }
        }


        /// <summary>
        /// Initialize sdk through configure data
        /// </summary>
        /// <param name="_config">Parameters required to initialize the SDK. See <see cref="SDKConfiguration"/>.</param>
        
        public void InitSDK(SDKConfiguration _config)
        {
            try
            {
                if (!awakeInvoked)
                    Awake();

                var tmp_SDKConfig = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration;
                tmp_SDKConfig.OnValueChanged += _ =>
                {
                    if (tmp_SDKConfig.Value.AppModel == AppModel.Offline)
                    {
                        IocContainer.GetIoc.Resolve<OfflineLicenseValidator>().Execute();
                    }

                    if (sdkKernel.Model.SdkInitialed == null) return;
                    sdkKernel.Model.SdkInitialed.Value = true;
                };

                tmp_SDKConfig.Value = _config;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                APICallback.ThrowException(nameof(ErrorCode.INIT_SDK_FAILED),
                    (int) ErrorCode.INIT_SDK_FAILED);
                throw;
            }
        }


        /// <summary>
        /// Query XR experiences content with id
        /// </summary>
        /// <param name="_experiencesId">The experiences id</param>
        
        public void LaunchXRQuery(string _experiencesId)
        {
            try
            {
                Assert.IsNotNull(sdkKernel.Model.SdkInitialed, "sdkEntryPointModel == null");
                if (!sdkKernel.Model.SdkInitialed.Value)
                {
                    Debug.LogError($"SDK is not initialized. [{nameof(LaunchXRQuery)}] will be not working!");
                    return;
                }

                var tmp_BaseContextDataModel = IocContainer.GetIoc.Resolve<BaseContextDataModel>();
                Assert.IsNotNull(tmp_BaseContextDataModel, "BaseContextDataModel is Null");
                tmp_BaseContextDataModel.ExperienceUid = _experiencesId;
                var tmp_Module = IocContainer.GetIoc.Resolve<IModule>();
                Assert.IsNotNull(tmp_Module, "XRMOD Platform Moduleis Null");
                tmp_Module.StartModule();
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                throw;
            }
        }

        #region Image recognization

        /// <summary>
        /// API for native app, querying project through pictures. It's a loop.
        /// </summary>
        
        public void LaunchARScanner()
        {
            if (!sdkKernel.Model.SdkInitialed.Value) return;
            // StartCoroutine(AlgorithmCreator.CheckAvailability(_state =>
            // {
            //     CheckAvailabilityCallback(_state);
            //     if (imageCloudRecognizer == null)
            //     {
            //         CreateImageCloudRecognizerHandler();
            //         NativeAPI.RecognitionStart();
            //     }
            //
            //     InvokeRepeating(nameof(RepeatRecognizer), 3f,
            //         sdkConfiguration.imageCloudRecognizerConfig.frequencyOfScan);
            // }));
        }

        /// <summary>
        /// Querying project through pictures
        /// </summary>
        private void RepeatRecognizer()
        {
            var tmp_MaximumOfRetries = IocContainer.GetIoc.Resolve<SDKConfiguration>().imageCloudRecognizerConfig
                .maximumOfRetries;
            if (sdkKernel.Model.MaximumOfRetries.Value >= tmp_MaximumOfRetries)
            {
                StopRecognizer();
                APICallback.ThrowException(nameof(ErrorCode.REACHED_MAXIMUM_OF_RETRIES),
                    (int) ErrorCode.REACHED_MAXIMUM_OF_RETRIES);
                return;
            }


            // imageCloudRecognizer.StartAlgorithm();
            sdkKernel.Model.MaximumOfRetries.Value++;
        }

        /// <summary>
        /// Create a handler for querying project through pictures
        /// </summary>
        private void CreateImageCloudRecognizerHandler()
        {
            // imageCloudRecognizer = AlgorithmCreator.ImageCloudRecognizer(_tag =>
            // {
            //     StopRecognizer(true);
            //     NativeAPI.RecognitionComplete();
            //     TryAcquireDataOperation(_tag, NetworkRequestType.ProjectInfoQueryByMarker);
            // }, sdkConfiguration.imageCloudRecognizerConfig.gateway);
        }

        /// <summary>
        /// Stop auto recognize 
        /// </summary>
        /// <param name="_stopAll">Stop all recognition processes</param>
        private void StopRecognizer(bool _stopAll = false)
        {
            CancelInvoke(nameof(RepeatRecognizer));

            if (_stopAll)
            {
                // imageCloudRecognizer?.StopAlgorithm();
                // imageCloudRecognizer = null;
            }

            sdkKernel.Model.MaximumOfRetries.Value = 0;
        }

        #endregion

        /// <summary>
        /// Close SDK
        /// </summary>
        
        public bool Dispose()
        {
            try
            {
                // Avoid crashes caused by coroutines or calls
                foreach (MonoBehaviour tmp_Behaviour in FindObjectsOfType<MonoBehaviour>())
                {
                    tmp_Behaviour.CancelInvoke();
                    tmp_Behaviour.StopAllCoroutines();
                }

                StopRecognizer(true);

                new DisposeXRMODEngineHandler().Handle();

                //Broken the AR session
                SceneManager.LoadScene(nameof(SceneTags.Clear), LoadSceneMode.Single);

                awakeInvoked = false;
                return true;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                throw;
                //return false;
            }
        }


        /// <summary>
        /// Set the display direction of the AR view
        /// </summary>
        /// <param name="_orientation">Display direction enumeration. See <see cref="ScreenOrientation"/>.</param>
        // ReSharper disable once InconsistentNaming
        
        public void SetUIInterfaceOrientation(string _orientation)
        {
            Screen.orientation = (ScreenOrientation) int.Parse(_orientation);
        }

        /// <summary>
        /// clean all cache
        /// </summary>
        
        public void CleanCache()
        {
            if (Caching.ClearCache())
            {
                Debug.Log("Cache was cleaned");
            }
        }

        /// <summary>
        /// Call this method will continue to download the assets
        /// </summary>
        
        public void ContinueToDownloadAssets()
        {
            if (!sdkKernel.Model.BreakDownloadWhenGreaterPresetSize.Value) return;
            sdkKernel.Model.BreakDownloadWhenGreaterPresetSize.Value = false;
            new ProjectLoadingPipeline(null).ExecuteContinueDownload();
        }


        /// <summary>
        /// Receive the message data from Native App
        /// </summary>
        /// <param name="_data">Will receive message data</param>
        
        protected void OnMessageReceived(string _data)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                new MessageArgs()
                {
                    Message = _data,
                    ActionName = nameof(OnMessageReceived),
                });
        }

        /// <summary>
        /// Send the message data to XR experiences
        /// </summary>
        /// <param name="_data">Will send message data</param>
        
        public void SendMessageToXRExperience(string _data)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                new MessageArgs()
                {
                    Message = _data,
                    ActionName = nameof(SendMessageToXRExperience),
                });
        }


        /// <summary>
        /// Get all running experience processes 
        /// </summary>
        /// <returns>All processes</returns>
        
        public Dictionary<string, List<string>> GetAllProcesses()
        {
            var tmp_Results = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.GetAllProcesses),
                new ProcessesArgs());

            if (tmp_Results == null) return new Dictionary<string, List<string>>();

            if (tmp_Results.Count <= 0 || tmp_Results[0] is not Dictionary<string, List<string>> tmp_AllProcess)
                return new Dictionary<string, List<string>>();

            return tmp_AllProcess.Count == 0 ? new Dictionary<string, List<string>>() : tmp_AllProcess;
        }

        /// <summary>
        /// Release the specified process
        /// </summary>
        /// <param name="_processId">The unique ID of the process to be released</param>
        
        public void ReleaseProcess(string _processId)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.ReleaseProject),
                new ProcessesArgs {ProcessId = _processId});
        }

        /// <summary>
        /// Change current experience space type
        /// </summary>
        /// <param name="_spaceType">Space type to switch. See <see cref="SpaceType"/></param>
        /// <param name="_processId">The process to switch</param>
        /// <param name="_boundResizeMode">Resize mode of the bounded. See <see cref="BoundResizeMode"/></param>
        /// <param name="_dimensions">The bounded dimensions</param>
        /// <param name="_boundPosition">The position of bounded</param>
        /// <param name="_cullingMask">Render mask. See <see cref="LayerMask"/></param>
        
        public void ChangeSpaceType(SpaceType _spaceType, string _processId, BoundResizeMode _boundResizeMode,
            Vector3 _dimensions, Vector3 _boundPosition, LayerMask _cullingMask)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.SwitchSpaceType),
                new SpaceTypeActionArgs()
                {
                    ProcessId = _processId,
                    SpaceTypeValue = _spaceType,
                    Dimensions = _dimensions,
                    BoundPosition = _boundPosition,
                    BoundResizeMode = _boundResizeMode,
                    CullingMask = _cullingMask
                });
        }

        /// <summary>
        /// Get current App space type
        /// </summary>
        /// <returns>Current App space type. See <see cref="SpaceType"/>.</returns>
        
        public SpaceType GetAppSpaceType()
        {
            return IocContainer.GetIoc.Resolve<BaseContextDataModel>().AppSpaceType;
        }

        #endregion
    }
}