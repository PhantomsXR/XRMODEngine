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

using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime;
using Phantom.XRMOD.Models.Runtime;
using UnityEngine.XR.ARFoundation;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.DataRequest;
using Phantom.XRMOD.SDKEntry.Runtime.Models;
using Phantom.XRMOD.XRMODUtilites.Runtime;

// ReSharper disable once CheckNamespace
namespace Phantom.XRMOD.SDKEntry.Runtime
{
    public partial class SDKEntryPoint : MonoBehaviour
    {
        private CodesHook codesHook;
        private SDKEntryPointModel sdkEntryPointModel;
        private bool awakeInvoked;

        #region Unity Callback

        /// <summary>
        /// Setup this game object not destroy on load new scene
        /// </summary>
        private void Awake()
        {
            awakeInvoked = true;
            DontDestroyOnLoad(this);

            // Let developer know xr-mod engine was launching
            // Sometimes developer need display the xr module launch UI/UX to tell user XR Module launching
            APICallback.OnXRMODLaunch();

            // Malloc the module
            new ModuleDependenceRegisterHandler().Handle();

            try
            {
                // Caching the sdk entry point model
                sdkEntryPointModel = IocContainer.GetIoc.Resolve<SDKEntryPointModel>();
            }
            catch (Exception tmp_Exception)
            {
                enabled = false;
                Debug.LogError($"[XRMOD] SDKEntryPoint initialized failed:{tmp_Exception}");
                throw;
            }

            // Access the XR-Module and we need to converted to IFetchModule.
            // Because we will add event for query server data.
            ActionNotificationCenter.DefaultCenter.AddObserver(_ =>
                {
                    var tmp_ExperienceUid = IocContainer.GetIoc.Resolve<BaseContextDataModel>().ExperienceUid;
                    // var tmp_BuildLoadingUIHandler = new BuildLoadingUIHandler();
                    // var tmp_RemoveLoadingUIHandler = new ExpericenLoadStateHandler();

                    var tmp_GetARExperienceProjectHandler =
                        new FetchXRResourcesHandler(NetworkRequestType.InfoByUId, tmp_ExperienceUid);
                    var tmp_CacheProjectInformationHandler = new CacheProjectInformationHandler();
                    var tmp_OversizeCheckHandler = new OversizeCheckHandler();
                    var tmp_GetXRPackageConfigHandler = new GetXRPackageConfigHandler();
                    var tmp_SdkVersionCheckHandler = new SdkVersionCheckHandler();
                    var tmp_LaunchXRModuleHandler = new LaunchXRModuleHandler();
                    var tmp_LoadingUIHandler = new ExpericenLoadStateHandler();
                    var tmp_CreateUIEventSystemHandler = new CreateUIEventSystemHandler();

                    tmp_GetARExperienceProjectHandler
                        .SetNext(tmp_CacheProjectInformationHandler)
                        .SetNext(tmp_OversizeCheckHandler)
                        .SetNext(tmp_LoadingUIHandler)
                        .SetNext(tmp_GetXRPackageConfigHandler)
                        .SetNext(tmp_SdkVersionCheckHandler)
                        .SetNext(tmp_LaunchXRModuleHandler)
                        .SetNext(tmp_CreateUIEventSystemHandler);
                    tmp_GetARExperienceProjectHandler.Handle();
                },
                nameof(ActionParameterDataType.FetchProjectDetail));

            // Listen CodeHook allocation status
            IocContainer.GetIoc.Resolve<BaseContextDataModel>().CodeHook.OnValueChanged += _hook =>
            {
                if (_hook != null)
                    codesHook = _hook;
            };

            // Entry main scene
            SceneManager.sceneLoaded += OnSceneLoad;
            SceneManager.LoadScene(nameof(SceneTags.Main), LoadSceneMode.Single);
        }


        /// <summary>
        /// Update event for XR-MOD hot-codes
        /// </summary>
        private void Update()
        {
            codesHook?.OnUpdate();
        }

        #endregion


        /// <summary>
        /// It will executed after scene loaded
        /// </summary>
        /// <param name="_scene">Load scene</param>
        /// <param name="_sceneMode">Load mode</param>
        private void OnSceneLoad(Scene _scene, LoadSceneMode _sceneMode)
        {
            switch (_scene.name)
            {
                case nameof(SceneTags.Main):
                    new SceneInitialization().Executed();
                    break;
                case nameof(SceneTags.Clear):
                    new SceneDeactivated().Executed();
                    SceneManager.sceneLoaded -= OnSceneLoad;
                    LoaderUtility.Deinitialize();
                    break;
                case nameof(SceneTags.Initilizer): break;
            }
        }
    }
}