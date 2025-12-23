using System;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.Models;
using Phantom.XRMOD.UnityFusion.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Phantom.XRMOD.SDKEntry.Runtime.Logic
{
    /// <summary>
    /// Kernel logic for SDK Entry, managing state and high-level operations.
    /// Acts as a bridge between the Unity MonoBehaviour Facade and the internal system.
    /// </summary>
    public class SDKKernel : IDisposable
    {
        private CodesHook codesHook;
        private SDKEntryPointModel sdkEntryPointModel;

        public SDKEntryPointModel Model => sdkEntryPointModel;
        public CodesHook CodesHook => codesHook;

        public SDKKernel()
        {
        }

        /// <summary>
        /// Initializes the kernel, notifies the application, and prepares project loading logic.
        /// </summary>
        public void Initialize()
        {
            // Let developer know xr-mod engine was launching
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
                Debug.LogError($"[XRMOD] SDKEntryPoint initialized failed:{tmp_Exception}");
                throw;
            }

            ActionNotificationCenter.DefaultCenter.AddObserver(OnFetchProjectDetail,
                nameof(ActionParameterDataType.FetchProjectDetail));

            // Listen CodeHook allocation status
            var tmp_BaseContextDataModel = IocContainer.GetIoc.Resolve<BaseContextDataModel>();
            if (tmp_BaseContextDataModel != null)
            {
                tmp_BaseContextDataModel.CodeHook.OnValueChanged += OnCodeHookChanged;
            }
        }
 
        private void OnFetchProjectDetail(BaseNotificationData _data)
        {
            var tmp_ExperienceUid = IocContainer.GetIoc.Resolve<BaseContextDataModel>().ExperienceUid;
            new ProjectLoadingPipeline(tmp_ExperienceUid).Execute();
        }

        private void OnCodeHookChanged(CodesHook _hook)
        {
            if (_hook != null)
                codesHook = _hook;
        }

        /// <summary>
        /// Updates the kernel state, primarily forwarding updates to active code hooks.
        /// </summary>
        public void OnUpdate()
        {
            codesHook?.OnUpdate();
        }

        /// <summary>
        /// Disposes of the kernel, unregistering observers and cleaning up hooks.
        /// </summary>
        public void Dispose()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.FetchProjectDetail));
             var tmp_BaseContextDataModel = IocContainer.GetIoc.Resolve<BaseContextDataModel>();
            if (tmp_BaseContextDataModel != null)
            {
                tmp_BaseContextDataModel.CodeHook.OnValueChanged -= OnCodeHookChanged;
            }
            codesHook = null;
            sdkEntryPointModel = null;
        }
    }
}
