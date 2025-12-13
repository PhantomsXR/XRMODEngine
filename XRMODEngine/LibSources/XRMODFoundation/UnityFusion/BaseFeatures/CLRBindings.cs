using System;
using System.Collections.Generic;
using System.Reflection;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif
namespace UnityFusion.Runtime.Generated
{
    class CLRBindings
    {

//will auto register in unity
#if UNITY_5_3_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#endif
        static private void RegisterBindingAction()
        {
            UnityFusion.Runtime.CLRBinding.CLRBindingUtils.RegisterBindingAction(Initialize);
        }
        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            Phantom_XRMOD_BaseFeatures_Runtime_BaseFeatureModule_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_ActionBasedControllerManager_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_DynamicMoveProvider_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildEventSystemCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildGltfLoaderCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildGraphQualityCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildNetworkMeshDownloadCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildOpenBuiltInBrowserCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildPostProcessingCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildProcessesManagerCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildRuntimeDebugConsoleCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildScriptRuntimeEnvironmentCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildSendMessageToSDKCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildTryAcquireInformationCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildTryAcquireLoadObjectCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildTryAcquireProjectInfoCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_BuildTryAcquireTemporaryCachePathCommand_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_Models_BaseFeatureModel_Binding.Register(app);
            Phantom_XRMOD_BaseFeatures_Runtime_Models_ImmersalContextDataModel_Binding.Register(app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}
