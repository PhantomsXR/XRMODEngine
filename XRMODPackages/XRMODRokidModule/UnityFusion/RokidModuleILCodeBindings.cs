using System;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif
namespace UnityFusion.Runtime.Generated
{
    class RokidModuleILCodeBindings
    {
//will auto register in unity
#if UNITY_5_3_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#endif
        static private void RegisterBindingAction()
        {
            UnityFusion.Runtime.CLRBinding.CLRBindingUtils.RegisterBindingAction(Initialize);

            ActionNotificationCenter.DefaultCenter.AddObserver(_data =>
            {
                if (_data is UnityFusionArgs tmp_Args)
                {
                    var tmp_AppDomain = tmp_Args.AppDomain as UnityFusion.Runtime.Enviorment.AppDomain;
                    tmp_AppDomain.DelegateManager
                        .RegisterMethodDelegate<System.Byte[], System.UInt16, System.UInt16, System.Int64>();
                }
            }, nameof(ActionParameterDataType.RegisterExtraCLR));
        }

        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            Phantom_XRMOD_RokidModule_Runtime_RokidNativeAPI_Binding.Register(app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}