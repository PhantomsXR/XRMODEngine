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
    unsafe class Phantom_XRMOD_GameServices_Runtime_ConfigurationArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs);

            field = type.GetField("AppId", flag);
            app.RegisterCLRFieldGetter(field, get_AppId_0);
            app.RegisterCLRFieldSetter(field, set_AppId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_AppId_0, AssignFromStack_AppId_0);
            field = type.GetField("Server", flag);
            app.RegisterCLRFieldGetter(field, get_Server_1);
            app.RegisterCLRFieldSetter(field, set_Server_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Server_1, AssignFromStack_Server_1);
            field = type.GetField("Token", flag);
            app.RegisterCLRFieldGetter(field, get_Token_2);
            app.RegisterCLRFieldSetter(field, set_Token_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Token_2, AssignFromStack_Token_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_AppId_0(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs)o).AppId;
        }

        static StackObject* CopyToStack_AppId_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs)o).AppId;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AppId_0(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs)o).AppId = (System.String)v;
        }

        static StackObject* AssignFromStack_AppId_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @AppId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs)o).AppId = @AppId;
            return ptr_of_this_method;
        }

        static object get_Server_1(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs)o).Server;
        }

        static StackObject* CopyToStack_Server_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs)o).Server;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Server_1(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs)o).Server = (System.String)v;
        }

        static StackObject* AssignFromStack_Server_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @Server = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs)o).Server = @Server;
            return ptr_of_this_method;
        }

        static object get_Token_2(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs)o).Token;
        }

        static StackObject* CopyToStack_Token_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs)o).Token;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Token_2(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs)o).Token = (System.String)v;
        }

        static StackObject* AssignFromStack_Token_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @Token = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs)o).Token = @Token;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.GameServices.Runtime.ConfigurationArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
