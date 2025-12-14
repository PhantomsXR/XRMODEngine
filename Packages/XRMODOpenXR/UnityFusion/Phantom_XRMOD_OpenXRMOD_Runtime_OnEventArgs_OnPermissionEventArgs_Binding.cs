#if QUEST_INSTALL

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
    unsafe class Phantom_XRMOD_OpenXRMOD_Runtime_OnEventArgs_OnPermissionEventArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.OpenXRMOD.Runtime.OnEventArgs.OnPermissionEventArgs);

            field = type.GetField("Granted", flag);
            app.RegisterCLRFieldGetter(field, get_Granted_0);
            app.RegisterCLRFieldSetter(field, set_Granted_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Granted_0, AssignFromStack_Granted_0);


            app.RegisterCLRCreateDefaultInstance(type,
                () => new Phantom.XRMOD.OpenXRMOD.Runtime.OnEventArgs.OnPermissionEventArgs());
            app.RegisterCLRCreateArrayInstance(type,
                s => new Phantom.XRMOD.OpenXRMOD.Runtime.OnEventArgs.OnPermissionEventArgs[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static object get_Granted_0(ref object o)
        {
            return ((Phantom.XRMOD.OpenXRMOD.Runtime.OnEventArgs.OnPermissionEventArgs) o).Granted;
        }

        static StackObject* CopyToStack_Granted_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.OpenXRMOD.Runtime.OnEventArgs.OnPermissionEventArgs) o).Granted;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_Granted_0(ref object o, object v)
        {
            ((Phantom.XRMOD.OpenXRMOD.Runtime.OnEventArgs.OnPermissionEventArgs) o).Granted = (System.Boolean) v;
        }

        static StackObject* AssignFromStack_Granted_0(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @Granted = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.OpenXRMOD.Runtime.OnEventArgs.OnPermissionEventArgs) o).Granted = @Granted;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.OpenXRMOD.Runtime.OnEventArgs.OnPermissionEventArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
#endif