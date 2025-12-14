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
    unsafe class Phantom_XRMOD_GameServices_Runtime_VoiceNotificationDataArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs);

            field = type.GetField("VoiceParticipant", flag);
            app.RegisterCLRFieldGetter(field, get_VoiceParticipant_0);
            app.RegisterCLRFieldSetter(field, set_VoiceParticipant_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_VoiceParticipant_0, AssignFromStack_VoiceParticipant_0);
            field = type.GetField("Message", flag);
            app.RegisterCLRFieldGetter(field, get_Message_1);
            app.RegisterCLRFieldSetter(field, set_Message_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Message_1, AssignFromStack_Message_1);
            field = type.GetField("VoiceEventKey", flag);
            app.RegisterCLRFieldGetter(field, get_VoiceEventKey_2);
            app.RegisterCLRFieldSetter(field, set_VoiceEventKey_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_VoiceEventKey_2, AssignFromStack_VoiceEventKey_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_VoiceParticipant_0(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs)o).VoiceParticipant;
        }

        static StackObject* CopyToStack_VoiceParticipant_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs)o).VoiceParticipant;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_VoiceParticipant_0(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs)o).VoiceParticipant = (Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)v;
        }

        static StackObject* AssignFromStack_VoiceParticipant_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.GameServices.Runtime.VoiceParticipant @VoiceParticipant = (Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)typeof(Phantom.XRMOD.GameServices.Runtime.VoiceParticipant).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs)o).VoiceParticipant = @VoiceParticipant;
            return ptr_of_this_method;
        }

        static object get_Message_1(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs)o).Message;
        }

        static StackObject* CopyToStack_Message_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs)o).Message;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Message_1(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs)o).Message = (Phantom.XRMOD.GameServices.Runtime.TextMessage)v;
        }

        static StackObject* AssignFromStack_Message_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.GameServices.Runtime.TextMessage @Message = (Phantom.XRMOD.GameServices.Runtime.TextMessage)typeof(Phantom.XRMOD.GameServices.Runtime.TextMessage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs)o).Message = @Message;
            return ptr_of_this_method;
        }

        static object get_VoiceEventKey_2(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs)o).VoiceEventKey;
        }

        static StackObject* CopyToStack_VoiceEventKey_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs)o).VoiceEventKey;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_VoiceEventKey_2(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs)o).VoiceEventKey = (Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey)v;
        }

        static StackObject* AssignFromStack_VoiceEventKey_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey @VoiceEventKey = (Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey)typeof(Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs)o).VoiceEventKey = @VoiceEventKey;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.GameServices.Runtime.VoiceNotificationDataArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
