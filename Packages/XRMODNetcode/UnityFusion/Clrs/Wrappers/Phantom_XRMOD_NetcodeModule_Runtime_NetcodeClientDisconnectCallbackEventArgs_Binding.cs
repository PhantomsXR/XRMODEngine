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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_NetcodeClientDisconnectCallbackEventArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeClientDisconnectCallbackEventArgs);

            field = type.GetField("UserId", flag);
            app.RegisterCLRFieldGetter(field, get_UserId_0);
            app.RegisterCLRFieldSetter(field, set_UserId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_UserId_0, AssignFromStack_UserId_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.NetcodeModule.Runtime.NetcodeClientDisconnectCallbackEventArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.NetcodeClientDisconnectCallbackEventArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_UserId_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeClientDisconnectCallbackEventArgs)o).UserId;
        }

        static StackObject* CopyToStack_UserId_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeClientDisconnectCallbackEventArgs)o).UserId;
            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_UserId_0(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeClientDisconnectCallbackEventArgs)o).UserId = (System.UInt64)v;
        }

        static StackObject* AssignFromStack_UserId_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt64 @UserId = *(ulong*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeClientDisconnectCallbackEventArgs)o).UserId = @UserId;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.NetcodeClientDisconnectCallbackEventArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
