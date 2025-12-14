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
    class VisionOSUnityFusionBinding
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
            UnityEngine_XR_VisionOS_ARMeshClassification_Binding.Register(app);
            UnityEngine_XR_VisionOS_VisionOSSpatialPointerPhase_Binding.Register(app);
            UnityEngine_XR_VisionOS_NativeApi_Binding.Register(app);
            UnityEngine_XR_VisionOS_VisionOSAnchorSubsystem_Binding.Register(app);
            UnityEngine_XR_VisionOS_VisionOSHandExtensions_Binding.Register(app);
            UnityEngine_XR_VisionOS_VisionOSImageTrackingSubsystem_Binding.Register(app);
            UnityEngine_XR_VisionOS_VisionOSMeshSubsystemExtensions_Binding.Register(app);
            UnityEngine_XR_VisionOS_InputDevices_VisionOSPlayModeInput_Binding.Register(app);
            UnityEngine_XR_VisionOS_InputDevices_VisionOSSpatialPointerControl_Binding.Register(app);
            UnityEngine_XR_VisionOS_InputDevices_VisionOSSpatialPointerDevice_Binding.Register(app);
            UnityEngine_XR_VisionOS_InputDevices_VisionOSSpatialPointerEvent_Binding.Register(app);
            UnityEngine_XR_VisionOS_InputDevices_VisionOSSpatialPointerKind_Binding.Register(app);
            UnityEngine_XR_VisionOS_InputDevices_VisionOSSpatialPointerModifierKeys_Binding.Register(app);
            UnityEngine_XR_VisionOS_InputDevices_VisionOSSpatialPointerState_Binding.Register(app);
            
             
            
            


            Unity_PolySpatial_MaterialSwapSet_Binding.Register(app);
            Unity_PolySpatial_PolySpatialObjectUtils_Binding.Register(app);
            Unity_PolySpatial_VisionOSGroundingShadow_Binding.Register(app);
            Unity_PolySpatial_VisionOSHoverEffect_Binding.Register(app);
            Unity_PolySpatial_VisionOSImageBasedLight_Binding.Register(app);
            Unity_PolySpatial_VisionOSImageBasedLightReceiver_Binding.Register(app);
            Unity_PolySpatial_VisionOSSortingGroup_Binding.Register(app);
            Unity_PolySpatial_VisionOSVideoComponent_Binding.Register(app);
            Unity_PolySpatial_VolumeCamera_Binding.Register(app);
            Unity_PolySpatial_VolumeCameraWindowConfiguration_Binding.Register(app);

            // poly spatial 2
            Unity_PolySpatial_UniversalRenderPipelineUtils_Binding.Register(app);
            Unity_PolySpatial_VisionOSBillboard_Binding.Register(app);
            Unity_PolySpatial_VisionOSEnvironmentLightingConfiguration_Binding.Register(app); 
            Unity_PolySpatial_WebCamTextureUtils_Binding.Register(app);
            
            
            Unity_PolySpatial_Internals_RKRuntimeFuncs_Binding.Register(app);

            //VisionOSManipulationInteractable_Binding.Register(app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}