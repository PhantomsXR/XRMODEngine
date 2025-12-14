using System;
using System.Collections.Generic;
using System.Reflection;
using UnityFusion.CLRBinding.Adapter;
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
            app.RegisterCrossBindingAdaptor(new IInjectorAdapter());

            VContainer_IObjectResolver_Binding.Register(app);
            VContainer_ContainerBuilder_Binding.Register(app);
            VContainer_RegistrationBuilder_Binding.Register(app);
            VContainer_ScopedContainerBuilder_Binding.Register(app);
            VContainer_IObjectResolverExtensions_Binding.Register(app);
            VContainer_ContainerBuilderExtensions_Binding.Register(app);
            VContainer_Unity_ObjectResolverUnityExtensions_Binding.Register(app);
            VContainer_Unity_ContainerBuilderUnityExtensions_Binding.Register(app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}