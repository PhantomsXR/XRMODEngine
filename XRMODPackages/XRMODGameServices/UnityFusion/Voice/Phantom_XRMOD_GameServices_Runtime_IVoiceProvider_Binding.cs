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
    unsafe class Phantom_XRMOD_GameServices_Runtime_IVoiceProvider_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.IVoiceProvider);
            args = new Type[]{typeof(System.String), typeof(Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)};
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_0);
            args = new Type[]{};
            method = type.GetMethod("DeInitialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeInitialize_1);
            args = new Type[]{typeof(System.String), typeof(Phantom.XRMOD.GameServices.Runtime.JoinChannelType)};
            method = type.GetMethod("JoinVoiceChannel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, JoinVoiceChannel_2);
            args = new Type[]{};
            method = type.GetMethod("LeaveVoiceChannel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LeaveVoiceChannel_3);
            args = new Type[]{typeof(System.String), typeof(Phantom.XRMOD.GameServices.Runtime.JoinChannelType)};
            method = type.GetMethod("CreateVoiceChannel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateVoiceChannel_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("MuteSelfMicrophone", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MuteSelfMicrophone_5);
            args = new Type[]{typeof(System.Boolean), typeof(System.String), typeof(System.String)};
            method = type.GetMethod("MuteOtherMicrophone", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MuteOtherMicrophone_6);
            args = new Type[]{typeof(System.Boolean), typeof(System.String), typeof(System.String)};
            method = type.GetMethod("BlockUser", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BlockUser_7);
            args = new Type[]{};
            method = type.GetMethod("GetParticipants", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetParticipants_8);



            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.IVoiceProvider[s]);


        }


        static StackObject* Initialize_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.GameServices.Runtime.Voice3DProperties @_voice3DProperties = (Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)typeof(Phantom.XRMOD.GameServices.Runtime.Voice3DProperties).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_configuration = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.GameServices.Runtime.IVoiceProvider instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.IVoiceProvider)typeof(Phantom.XRMOD.GameServices.Runtime.IVoiceProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize(@_configuration, @_voice3DProperties);

            return __ret;
        }

        static StackObject* DeInitialize_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.GameServices.Runtime.IVoiceProvider instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.IVoiceProvider)typeof(Phantom.XRMOD.GameServices.Runtime.IVoiceProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DeInitialize();

            return __ret;
        }

        static StackObject* JoinVoiceChannel_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.GameServices.Runtime.JoinChannelType @_joinChannelType = (Phantom.XRMOD.GameServices.Runtime.JoinChannelType)typeof(Phantom.XRMOD.GameServices.Runtime.JoinChannelType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_channelName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.GameServices.Runtime.IVoiceProvider instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.IVoiceProvider)typeof(Phantom.XRMOD.GameServices.Runtime.IVoiceProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.JoinVoiceChannel(@_channelName, @_joinChannelType);

            return __ret;
        }

        static StackObject* LeaveVoiceChannel_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.GameServices.Runtime.IVoiceProvider instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.IVoiceProvider)typeof(Phantom.XRMOD.GameServices.Runtime.IVoiceProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LeaveVoiceChannel();

            return __ret;
        }

        static StackObject* CreateVoiceChannel_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.GameServices.Runtime.JoinChannelType @_joinChannelType = (Phantom.XRMOD.GameServices.Runtime.JoinChannelType)typeof(Phantom.XRMOD.GameServices.Runtime.JoinChannelType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_channelName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.GameServices.Runtime.IVoiceProvider instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.IVoiceProvider)typeof(Phantom.XRMOD.GameServices.Runtime.IVoiceProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CreateVoiceChannel(@_channelName, @_joinChannelType);

            return __ret;
        }

        static StackObject* MuteSelfMicrophone_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_muted = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.GameServices.Runtime.IVoiceProvider instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.IVoiceProvider)typeof(Phantom.XRMOD.GameServices.Runtime.IVoiceProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MuteSelfMicrophone(@_muted);

            return __ret;
        }

        static StackObject* MuteOtherMicrophone_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_userId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_channleId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @_muted = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.GameServices.Runtime.IVoiceProvider instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.IVoiceProvider)typeof(Phantom.XRMOD.GameServices.Runtime.IVoiceProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MuteOtherMicrophone(@_muted, @_channleId, @_userId);

            return __ret;
        }

        static StackObject* BlockUser_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_userId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_channelId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @_block = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.GameServices.Runtime.IVoiceProvider instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.IVoiceProvider)typeof(Phantom.XRMOD.GameServices.Runtime.IVoiceProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.BlockUser(@_block, @_channelId, @_userId);

            return __ret;
        }

        static StackObject* GetParticipants_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.GameServices.Runtime.IVoiceProvider instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.IVoiceProvider)typeof(Phantom.XRMOD.GameServices.Runtime.IVoiceProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetParticipants();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
