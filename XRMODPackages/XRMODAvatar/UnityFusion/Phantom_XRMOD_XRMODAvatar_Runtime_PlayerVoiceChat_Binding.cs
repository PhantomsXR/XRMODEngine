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
    unsafe class Phantom_XRMOD_XRMODAvatar_Runtime_PlayerVoiceChat_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat);
            args = new Type[]{};
            method = type.GetMethod("get_GetPlayerVoiceId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetPlayerVoiceId_0);
            args = new Type[]{};
            method = type.GetMethod("get_GetVoiceAudioEnergy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetVoiceAudioEnergy_1);
            args = new Type[]{};
            method = type.GetMethod("get_AutoEnableVoiceChat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AutoEnableVoiceChat_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_AutoEnableVoiceChat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_AutoEnableVoiceChat_3);
            args = new Type[]{};
            method = type.GetMethod("get_VoiceChannelType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_VoiceChannelType_4);
            args = new Type[]{typeof(Phantom.XRMOD.GameServices.Runtime.JoinChannelType)};
            method = type.GetMethod("set_VoiceChannelType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_VoiceChannelType_5);
            args = new Type[]{};
            method = type.GetMethod("OnDestroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDestroy_6);
            args = new Type[]{};
            method = type.GetMethod("OnNetworkSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkSpawn_7);
            args = new Type[]{};
            method = type.GetMethod("SetUpPlayerVoice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetUpPlayerVoice_8);
            args = new Type[]{};
            method = type.GetMethod("ToggleSquelch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToggleSquelch_9);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("SetVoiceId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetVoiceId_10);



            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_GetPlayerVoiceId_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPlayerVoiceId;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_GetVoiceAudioEnergy_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetVoiceAudioEnergy;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_AutoEnableVoiceChat_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AutoEnableVoiceChat;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_AutoEnableVoiceChat_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AutoEnableVoiceChat = value;

            return __ret;
        }

        static StackObject* get_VoiceChannelType_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.VoiceChannelType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_VoiceChannelType_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.GameServices.Runtime.JoinChannelType @value = (Phantom.XRMOD.GameServices.Runtime.JoinChannelType)typeof(Phantom.XRMOD.GameServices.Runtime.JoinChannelType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.VoiceChannelType = value;

            return __ret;
        }

        static StackObject* OnDestroy_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDestroy();

            return __ret;
        }

        static StackObject* OnNetworkSpawn_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkSpawn();

            return __ret;
        }

        static StackObject* SetUpPlayerVoice_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetUpPlayerVoice();

            return __ret;
        }

        static StackObject* ToggleSquelch_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ToggleSquelch();

            return __ret;
        }

        static StackObject* SetVoiceId_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_voiceId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetVoiceId(@_voiceId);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODAvatar.Runtime.PlayerVoiceChat();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
