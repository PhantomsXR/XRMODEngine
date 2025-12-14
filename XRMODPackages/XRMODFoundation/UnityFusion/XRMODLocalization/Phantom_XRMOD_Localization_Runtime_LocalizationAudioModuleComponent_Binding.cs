using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityFusion.Reflection;
using UnityFusion.CLR.Utils;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace UnityFusion.Runtime.Generated
{
#if USE_AUDIO_MODULE
    unsafe class Phantom_XRMOD_Localization_Runtime_LocalizationAudioModuleComponent_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.Localization.Runtime.LocalizationAudioModuleComponent);
            args = new Type[] {typeof(Phantom.XRMOD.AudioModule.Runtime.AudioClipData)};
            method = type.GetMethod("UpdateContent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateContent_0);


            app.RegisterCLRCreateDefaultInstance(type,
                () => new Phantom.XRMOD.Localization.Runtime.LocalizationAudioModuleComponent());
            app.RegisterCLRCreateArrayInstance(type,
                s => new Phantom.XRMOD.Localization.Runtime.LocalizationAudioModuleComponent[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* UpdateContent_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.AudioModule.Runtime.AudioClipData @_value =
                (Phantom.XRMOD.AudioModule.Runtime.AudioClipData)
                typeof(Phantom.XRMOD.AudioModule.Runtime.AudioClipData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.Localization.Runtime.LocalizationAudioModuleComponent instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationAudioModuleComponent)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationAudioModuleComponent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UpdateContent(@_value);

            return __ret;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.Localization.Runtime.LocalizationAudioModuleComponent();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
#endif
}