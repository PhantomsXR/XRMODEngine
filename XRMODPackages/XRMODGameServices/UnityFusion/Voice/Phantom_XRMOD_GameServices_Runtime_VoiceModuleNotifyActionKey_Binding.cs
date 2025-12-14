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
    unsafe class Phantom_XRMOD_GameServices_Runtime_VoiceModuleNotifyActionKey_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.VoiceModuleNotifyActionKey);

            field = type.GetField("CONST_VOICE_EVENT_KEY", flag);
            app.RegisterCLRFieldGetter(field, get_CONST_VOICE_EVENT_KEY_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_CONST_VOICE_EVENT_KEY_0, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.VoiceModuleNotifyActionKey());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.VoiceModuleNotifyActionKey[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_CONST_VOICE_EVENT_KEY_0(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY;
        }

        static StackObject* CopyToStack_CONST_VOICE_EVENT_KEY_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.GameServices.Runtime.VoiceModuleNotifyActionKey();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
