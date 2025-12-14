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
    unsafe class ImmersalMapperArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs);

            field = type.GetField("IsTracking", flag);
            app.RegisterCLRFieldGetter(field, get_IsTracking_0);
            app.RegisterCLRFieldSetter(field, set_IsTracking_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsTracking_0, AssignFromStack_IsTracking_0);
            field = type.GetField("Message", flag);
            app.RegisterCLRFieldGetter(field, get_Message_1);
            app.RegisterCLRFieldSetter(field, set_Message_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Message_1, AssignFromStack_Message_1);
            field = type.GetField("Progress", flag);
            app.RegisterCLRFieldGetter(field, get_Progress_2);
            app.RegisterCLRFieldSetter(field, set_Progress_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Progress_2, AssignFromStack_Progress_2);
            field = type.GetField("Uploading", flag);
            app.RegisterCLRFieldGetter(field, get_Uploading_3);
            app.RegisterCLRFieldSetter(field, set_Uploading_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Uploading_3, AssignFromStack_Uploading_3);
            field = type.GetField("IsConnected", flag);
            app.RegisterCLRFieldGetter(field, get_IsConnected_4);
            app.RegisterCLRFieldSetter(field, set_IsConnected_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsConnected_4, AssignFromStack_IsConnected_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_IsTracking_0(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).IsTracking;
        }

        static StackObject* CopyToStack_IsTracking_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).IsTracking;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsTracking_0(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).IsTracking = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsTracking_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsTracking = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).IsTracking = @IsTracking;
            return ptr_of_this_method;
        }

        static object get_Message_1(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).Message;
        }

        static StackObject* CopyToStack_Message_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).Message;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Message_1(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).Message = (System.String)v;
        }

        static StackObject* AssignFromStack_Message_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @Message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).Message = @Message;
            return ptr_of_this_method;
        }

        static object get_Progress_2(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).Progress;
        }

        static StackObject* CopyToStack_Progress_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).Progress;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Progress_2(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).Progress = (System.Single)v;
        }

        static StackObject* AssignFromStack_Progress_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Progress = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).Progress = @Progress;
            return ptr_of_this_method;
        }

        static object get_Uploading_3(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).Uploading;
        }

        static StackObject* CopyToStack_Uploading_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).Uploading;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_Uploading_3(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).Uploading = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_Uploading_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @Uploading = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).Uploading = @Uploading;
            return ptr_of_this_method;
        }

        static object get_IsConnected_4(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).IsConnected;
        }

        static StackObject* CopyToStack_IsConnected_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).IsConnected;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsConnected_4(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).IsConnected = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsConnected_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsConnected = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs)o).IsConnected = @IsConnected;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.ActionNotification.Runtime.ImmersalMapperArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
