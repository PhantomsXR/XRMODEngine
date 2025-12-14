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
            app.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector3, System.Object>();
                
            LeanAudio_Binding.Register(app);
            LeanAudioOptions_Binding.Register(app);
            LeanSmooth_Binding.Register(app);
            LeanTweenExt_Binding.Register(app);
            LTDescr_Binding.Register(app);
            LeanAudioStream_Binding.Register(app);
            LeanTester_Binding.Register(app);
            LeanTest_Binding.Register(app);
            TweenAction_Binding.Register(app);
            LeanTweenType_Binding.Register(app);
            LeanProp_Binding.Register(app);
            LeanTween_Binding.Register(app);
            LTUtility_Binding.Register(app);
            LTBezier_Binding.Register(app);
            LTBezierPath_Binding.Register(app);
            LTSpline_Binding.Register(app);
            LTRect_Binding.Register(app);
            LTEvent_Binding.Register(app);
            LTGUI_Binding.Register(app);
            LTDescrOptional_Binding.Register(app);
            LTSeq_Binding.Register(app);

            Phantom_XRMOD_XRMODUtilites_Runtime_APICallback_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_GameObjectExtension_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_BatchModeUpdateRendererComponentAdapter_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_BillboardComponentAdapter_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_GroundShadowComponentAdapter_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_HoverEffectComponentAdapter_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_RenderTextureUpdaterComponentAdapter_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_SortingGroupComponentAdapter_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_StaticBatchElementComponentAdapter_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_VideoComponentAdapter_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_ProcessIdComponent_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_PlatformType_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_RuntimePlatformHelper_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_XRMODAnchor_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_LoadEnvironmentParameters_Binding.Register(app);

            Phantom_XRMOD_XRMODUtilites_Runtime_UniPool_PoolCell_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_UniPool_PoolStack_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_UniPool_UniPool_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_UniPool_UniPool_T_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_UniPool_PoolCell_T_Binding.Register(app);
            Phantom_XRMOD_XRMODUtilites_Runtime_UniPool_PoolManager_Binding.Register(app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}