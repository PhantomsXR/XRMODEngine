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
            ActionNotificationCenter_Binding.Register(app);
            AlgorithmSetterArgs_Binding.Register(app);
            AnchorArgs_Binding.Register(app);
            ARAlgorithmArgs_Binding.Register(app);
            AROcclusionArgs_Binding.Register(app);
            ARRaycastArgs_Binding.Register(app);
            ARWorldMapArgs_Binding.Register(app);
            BaseNotificationData_Binding.Register(app);
            DestroyAnchorArgs_Binding.Register(app);
            DynamicLibraryArgs_Binding.Register(app);
            FaceMeshArgs_Binding.Register(app);
            ImageData_Binding.Register(app);
            ImmersalArgs_Binding.Register(app);
            ImmersalMapperArgs_Binding.Register(app);
            LoadObjectArgs_Binding.Register(app);
            MarkerArgs_Binding.Register(app);
            MessageArgs_Binding.Register(app);
            OpenInBuiltInBrowserArgs_Binding.Register(app);
            ProcessesArgs_Binding.Register(app);
            ResizeARWorldScaleArgs_Binding.Register(app);
            SpaceTypeArgs_Binding.Register(app);
            SpatialAnchorArgs_Binding.Register(app);
            TransformArgs_Binding.Register(app);
            TryAcquireAppInfoArgs_Binding.Register(app);
            TryAcquireCurrentFrameArgs_Binding.Register(app);

            OnEventAnchorEventArgs_Binding.Register(app);
            OnEventBaseArgs_Binding.Register(app);
            OnEventFocusEventArgs_Binding.Register(app);
            OnEventMeshEventArgs_Binding.Register(app);
            OnEventPlaneEventArgs_Binding.Register(app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}