// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the UnityFusion.Adapter.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityFusion.Runtime.Enviorment;

namespace UnityFusion.CLRBinding.Adapter
{
    public class UnityFusionBuiltInAdaptorRegister
    {
        [RuntimeInitializeOnLoadMethod]
        public static void Register()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(RegisterAllAdaptor,
                nameof(ActionParameterDataType.RegisterBuiltInAdaptor));
        }

        private static void RegisterAllAdaptor(BaseNotificationData _data)
        {
            if (_data is not UnityFusionArgs tmp_UnityFusionNotificationData) return;
            var tmp_AppDomainOfUnityFusion = tmp_UnityFusionNotificationData.AppDomain as AppDomain;

            Assert.IsNotNull(tmp_AppDomainOfUnityFusion, "The AppDomain is invalid.");

            tmp_AppDomainOfUnityFusion.RegisterCrossBindingAdaptor(new AsyncStateMachineClassInheritanceAdaptor());
            tmp_AppDomainOfUnityFusion.RegisterCrossBindingAdaptor(new CoroutineAdapter());
            tmp_AppDomainOfUnityFusion.RegisterCrossBindingAdaptor(new XRMODBehaviourAdapter()); 
            tmp_AppDomainOfUnityFusion.RegisterCrossBindingAdaptor(new BaseNotificationDataAdapter());
            tmp_AppDomainOfUnityFusion.RegisterCrossBindingAdaptor(new ExceptionAdapter());
            tmp_AppDomainOfUnityFusion.RegisterCrossBindingAdaptor(new IComparer_1_TransformAdapter());
            tmp_AppDomainOfUnityFusion.RegisterCrossBindingAdaptor(new UIBehaviourAdaptor()); 
            tmp_AppDomainOfUnityFusion.RegisterCrossBindingAdaptor(new ScriptableObjectAdapter());
            tmp_AppDomainOfUnityFusion.RegisterCrossBindingAdaptor(new SelectableAdapter());
            tmp_AppDomainOfUnityFusion.RegisterCrossBindingAdaptor(new MaskableGraphicAdapter());

            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.RegisterExtraAdaptor),
                new UnityFusionArgs()
                {
                    AppDomain = tmp_AppDomainOfUnityFusion
                });
        }
    }
}