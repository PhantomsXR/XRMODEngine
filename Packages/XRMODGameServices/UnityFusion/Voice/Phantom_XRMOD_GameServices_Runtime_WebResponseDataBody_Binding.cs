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
    unsafe class Phantom_XRMOD_GameServices_Runtime_WebResponseDataBody_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody);

            field = type.GetField("token", flag);
            app.RegisterCLRFieldGetter(field, get_token_0);
            app.RegisterCLRFieldSetter(field, set_token_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_token_0, AssignFromStack_token_0);
            field = type.GetField("channel_name", flag);
            app.RegisterCLRFieldGetter(field, get_channel_name_1);
            app.RegisterCLRFieldSetter(field, set_channel_name_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_channel_name_1, AssignFromStack_channel_name_1);
            field = type.GetField("generate_type", flag);
            app.RegisterCLRFieldGetter(field, get_generate_type_2);
            app.RegisterCLRFieldSetter(field, set_generate_type_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_generate_type_2, AssignFromStack_generate_type_2);
            field = type.GetField("user_info", flag);
            app.RegisterCLRFieldGetter(field, get_user_info_3);
            app.RegisterCLRFieldSetter(field, set_user_info_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_user_info_3, AssignFromStack_user_info_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_token_0(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).token;
        }

        static StackObject* CopyToStack_token_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).token;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_token_0(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).token = (System.String)v;
        }

        static StackObject* AssignFromStack_token_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @token = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).token = @token;
            return ptr_of_this_method;
        }

        static object get_channel_name_1(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).channel_name;
        }

        static StackObject* CopyToStack_channel_name_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).channel_name;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_channel_name_1(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).channel_name = (System.String)v;
        }

        static StackObject* AssignFromStack_channel_name_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @channel_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).channel_name = @channel_name;
            return ptr_of_this_method;
        }

        static object get_generate_type_2(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).generate_type;
        }

        static StackObject* CopyToStack_generate_type_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).generate_type;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_generate_type_2(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).generate_type = (System.String)v;
        }

        static StackObject* AssignFromStack_generate_type_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @generate_type = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).generate_type = @generate_type;
            return ptr_of_this_method;
        }

        static object get_user_info_3(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).user_info;
        }

        static StackObject* CopyToStack_user_info_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).user_info;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_user_info_3(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).user_info = (System.String)v;
        }

        static StackObject* AssignFromStack_user_info_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @user_info = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)o).user_info = @user_info;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
