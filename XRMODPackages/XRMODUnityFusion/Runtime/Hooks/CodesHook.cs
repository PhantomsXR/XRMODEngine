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
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime;
using UnityFusion.CLR.Method;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.Runtime.Intepreter;
using UnityEngine;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using UnityFusion.CLRBinding.Adapter;
using UnityEngine.Assertions;
using Phantom.XRMOD.Core.Runtime;
using Object = UnityEngine.Object;


namespace Phantom.XRMOD.UnityFusion.Runtime
{
    /// <summary>
    /// The core hook class for the XR-MOD runtime.
    /// Manages the ILRuntime/CLR AppDomain, assembly loading, and hooks into Unity's lifecycle and event system.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class CodesHook
    {
        /// <summary> Gets or sets whether debug mode is enabled. </summary>
        public bool debug { get; set; }

        private static bool _INITIALIZED;

        private IDllLoaderProvider dllLoaderProvider;
        // private static AppDomain GetAppDomain;

        // private MemoryStream SharedData.Instance.dllStream;
        // private MemoryStream SharedData.Instance.symbolStream;

        // For multi-XR Experiences
        private List<IMethod> updateMethods;

        private IMethod onReleaseMethod;
        private IMethod onEventMethod;

        // Parameters
        private readonly object[] onEventData = new object[1];


        // private IMethod onMultiplayerMethod;
        private ILTypeInstance ilTypeInstance;
        private string projectName;

        /// <summary>
        /// Gets the current active AppDomain.
        /// </summary>
        public static AppDomain GetAppDomain => SharedData.Instance.appDomain;

        /// <summary>
        /// Gets the cached runtime asset reference databases by project name.
        /// </summary>
        public static Dictionary<string, RuntimeAssetReferenceDatabase> AssetReferences { get; private set; } = new();

        /// <summary>
        /// Initializes the hook for a specific project and entry point.
        /// </summary>
        /// <param name="_projectName">The name of the project.</param>
        /// <param name="_domainName">The domain/namespace name.</param>
        /// <param name="_mainEntryPoint">The main class entry point.</param>
        /// <param name="_jitFlag">The JIT flag for the AppDomain.</param>
        public void InitializeHook(string _projectName, string _domainName, string _mainEntryPoint, int _jitFlag)
        {
            _INITIALIZED = SharedData.Instance.appDomain != null;
            SharedData.Instance.appDomain ??= new AppDomain(_jitFlag);
            projectName = _projectName;
            LoadExpandDllAsync(_projectName, _domainName, _mainEntryPoint);

            IocContainer.GetIoc.Register(new UserInstantiatedObjects());
        }

        private async void LoadExpandDllAsync(string _projectName, string _domainName, string _mainEntryPoint)
        {
            try
            {
                dllLoaderProvider = Application.isEditor || debug
                    ? new DebugDllLoaderProvider()
                    : new ReleaseDllLoaderProvider();
                await dllLoaderProvider.LoadAssembly(SharedData.Instance.appDomain, _projectName);

                if (!_INITIALIZED)
                {
                    InitializeUnityFusion();
                }

                // Fix null exception after second load.
                // Since the release of AR Experience, the notification list will be cleaned up.
                // So we need to warm it.
                ActionNotificationCenter.DefaultCenter.AddObserver(InstantiatingNotificationAction,
                    nameof(ActionParameterDataType.Instantiate));


                try
                {
                    var tmp_ProjectName = _domainName.Split(".")[0];
                    var tmp_Db = await LoadRuntimeReferenceDatabase(tmp_ProjectName);
                    if (tmp_Db)
                    {
                        AssetReferences.TryAdd(tmp_ProjectName, tmp_Db);
                    }
                }
                catch (Exception tmp_Exception)
                {
                    Debug.LogError($"Load runtime reference database failed: {tmp_Exception.Message}");
                }


                StartHookingCode($"{_domainName}.{_mainEntryPoint}");
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError($"Load expand dll failed: {tmp_Exception.Message}\n{tmp_Exception.StackTrace}");
            }
        }

        private void InitializeUnityFusion()
        {
#if DEBUG && (UNITY_EDITOR || UNITY_ANDROID || UNITY_IPHONE)
            GetAppDomain.UnityMainThreadID = System.Threading.Thread.CurrentThread.ManagedThreadId;
#endif

            Singleton<RegisterCrossBindingAdaptor>.GetInstance.Register(GetAppDomain);
            Singleton<RegisterDelegate>.GetInstance.Register(GetAppDomain);
            Singleton<RegisterDelegateConvertor>.GetInstance.Register(GetAppDomain);
            Singleton<RegisterValueBinding>.GetInstance.Register(GetAppDomain);
            Singleton<RegisterClrMethodRedirection>.GetInstance.Register(GetAppDomain);
            GetAppDomain.InitializeBindings();

            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.RegisterBuiltInCLR),
                new UnityFusionArgs()
                {
                    AppDomain = GetAppDomain
                });

            // Send register clr command to every modules(Extra CLR).
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.RegisterExtraCLR), new UnityFusionArgs
                {
                    AppDomain = GetAppDomain
                });

            _INITIALIZED = true;
        }


        private void StartHookingCode(string _runtimeEntryPoint)
        {
            var tmp_MethodDirectory = GetAppDomain.LoadedTypes[_runtimeEntryPoint];
            ilTypeInstance = ((ILType) tmp_MethodDirectory).Instantiate();
            var tmp_Constructor = ilTypeInstance.Type.GetConstructor(new List<IType>());
            if (tmp_Constructor != null)
            {
                GetAppDomain.Invoke(tmp_Constructor, ilTypeInstance, null);
            }

            try
            {
                GetAppDomain.Invoke(_runtimeEntryPoint, MethodKey.ONLOAD, ilTypeInstance, null);
                if (tmp_MethodDirectory == null) return;
                onEventMethod = tmp_MethodDirectory.GetMethod(MethodKey.ONEVENT, 1);
                onReleaseMethod = tmp_MethodDirectory.GetMethod(MethodKey.RELEASEMEMORY, 1);
                updateMethods ??= new List<IMethod>();
                updateMethods.Add(tmp_MethodDirectory.GetMethod(MethodKey.ONUPDATE, 0));
            }
            catch (Exception tmp_Exception)
            {
                throw new Exception($"Start hooking code failed: {tmp_Exception.Message}", tmp_Exception);
            }
        }


        #region Unity Life cycle methods

        ////////////////////////
        //Call back function////
        ////////////////////////
        /// <summary>
        /// Called during the Unity Update cycle.
        /// Invokes the 'OnUpdate' method in the hot-reload assembly for all active instances.
        /// </summary>
        public void OnUpdate()
        {
            if (!_INITIALIZED || updateMethods == null || SharedData.Instance.dllStream == null) return;
            foreach (var tmp_UpdateMethod in updateMethods)
            {
                GetAppDomain.Invoke(tmp_UpdateMethod, ilTypeInstance);
            }
        }


        /// <summary>
        ///  Only work XR-MOD not work in XR-Widgets
        /// </summary>
        /// <param name="_data"></param>
        public void OnEvent(BaseNotificationData _data)
        {
            if (!_INITIALIZED || onEventMethod == null || SharedData.Instance.dllStream == null) return;
            onEventData[0] = _data;
            GetAppDomain.Invoke(onEventMethod, ilTypeInstance, onEventData);
        }

        /// <summary>
        ///  Only work XR-MOD not work in XR-Widgets
        /// </summary>
        /// <param name="_data"></param>
        public void ReleaseMemory(string _projectName)
        {
            if (!_INITIALIZED || SharedData.Instance.dllStream == null || onReleaseMethod == null) return;
            GetAppDomain.Invoke(onReleaseMethod, ilTypeInstance, _projectName ?? projectName);
        }

        /// <summary>
        /// Disposes of the hook, releases memory, and cleans up the AppDomain and asset references.
        /// </summary>
        /// <param name="_projectName">The project to clean up (optional).</param>
        public async void Dispose(string _projectName = null)
        {
            try
            {
                ReleaseMemory(_projectName);

                //Release MonoBehaviour and XRMODBehaviour
                List<XRMODBehaviourAdapter.Adapter> tmp_AllMonoAdaptors = new List<XRMODBehaviourAdapter.Adapter>();
                tmp_AllMonoAdaptors.AddRange(
                    Object.FindObjectsByType<XRMODBehaviourAdapter.Adapter>(FindObjectsInactive.Include,
                        FindObjectsSortMode.None));
                foreach (var tmp_MonoBehaviour in tmp_AllMonoAdaptors)
                {
                    if (tmp_MonoBehaviour == null) continue;
                    tmp_MonoBehaviour.enabled = false;
                    Object.DestroyImmediate(tmp_MonoBehaviour, true);
                }

                IocContainer.GetIoc.UnRegister<UserInstantiatedObjects>();

                ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.OnEvent));

                updateMethods = null;
                onEventMethod = null;


                ilTypeInstance = null;
                GetAppDomain?.Dispose();
                await Task.Delay(500);
                SharedData.Instance.dllStream?.Dispose();
                SharedData.Instance.symbolStream?.Dispose();
                SharedData.Instance.dllStream = SharedData.Instance.symbolStream = null;
                AssetReferences.Clear();

#if UNITY_EDITOR
                SharedData.Instance.appDomain = null;
#endif
            }
            catch (Exception tmp_Exception)
            {
                throw new Exception($"CodesHook dispose error:{tmp_Exception.Message}");
            }
        }

        #endregion


        private object InstantiatingNotificationAction(BaseNotificationData _arg)
        {
            if (_arg is not InstantiateArgs tmp_Data) return null;
            if (GetAppDomain == null)
            {
                Assert.IsNotNull(tmp_Data.Prefab);
                return tmp_Data.Parent
                    ? Object.Instantiate(tmp_Data.Prefab, tmp_Data.Parent)
                    : Object.Instantiate(tmp_Data.Prefab);
            }

            Utility.CheckoutIlTypeInstance(tmp_Data.Prefab, out var tmp_Go, out var tmp_Type);

            var tmp_ResultOfThisMethod = tmp_Data.Parent
                ? Object.Instantiate(tmp_Data.Prefab, tmp_Data.Parent)
                : Object.Instantiate(tmp_Data.Prefab);

            var tmp_Res = Utility.DoBinding(tmp_Go, tmp_ResultOfThisMethod, GetAppDomain, tmp_Type);

            if (tmp_Type == null && tmp_Res is GameObject tmp_GameObject &&
                tmp_GameObject.GetType() != tmp_Data.Prefab.GetType())
            {
                return tmp_GameObject.GetComponent(tmp_Data.Prefab.GetType());
            }

            return tmp_Res;
        }

        private async Task<RuntimeAssetReferenceDatabase> LoadRuntimeReferenceDatabase(string _projectName)
        {
            var tmp_RuntimeAssetDb =
                await BasePackageLoaderUtility.LoadAssetFromPackage<RuntimeAssetReferenceDatabase>(_projectName,
                    nameof(RuntimeAssetReferenceDatabase));
            await tmp_RuntimeAssetDb.Initialize(_projectName);
            return tmp_RuntimeAssetDb;
        }
    }
}