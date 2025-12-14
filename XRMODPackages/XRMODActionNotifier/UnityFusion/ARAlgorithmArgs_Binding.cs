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
    unsafe class ARAlgorithmArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs);

            field = type.GetField("ARAlgorithmType", flag);
            app.RegisterCLRFieldGetter(field, get_ARAlgorithmType_0);
            app.RegisterCLRFieldSetter(field, set_ARAlgorithmType_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ARAlgorithmType_0, AssignFromStack_ARAlgorithmType_0);
            field = type.GetField("ARAlgorithmOperator", flag);
            app.RegisterCLRFieldGetter(field, get_ARAlgorithmOperator_1);
            app.RegisterCLRFieldSetter(field, set_ARAlgorithmOperator_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ARAlgorithmOperator_1, AssignFromStack_ARAlgorithmOperator_1);
            field = type.GetField("Mixed", flag);
            app.RegisterCLRFieldGetter(field, get_Mixed_2);
            app.RegisterCLRFieldSetter(field, set_Mixed_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Mixed_2, AssignFromStack_Mixed_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_ARAlgorithmType_0(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)o).ARAlgorithmType;
        }

        static StackObject* CopyToStack_ARAlgorithmType_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)o).ARAlgorithmType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ARAlgorithmType_0(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)o).ARAlgorithmType = (Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmType)v;
        }

        static StackObject* AssignFromStack_ARAlgorithmType_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmType @ARAlgorithmType = (Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmType)typeof(Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)o).ARAlgorithmType = @ARAlgorithmType;
            return ptr_of_this_method;
        }

        static object get_ARAlgorithmOperator_1(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)o).ARAlgorithmOperator;
        }

        static StackObject* CopyToStack_ARAlgorithmOperator_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)o).ARAlgorithmOperator;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ARAlgorithmOperator_1(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)o).ARAlgorithmOperator = (Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmOperator)v;
        }

        static StackObject* AssignFromStack_ARAlgorithmOperator_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmOperator @ARAlgorithmOperator = (Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmOperator)typeof(Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmOperator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)o).ARAlgorithmOperator = @ARAlgorithmOperator;
            return ptr_of_this_method;
        }

        static object get_Mixed_2(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)o).Mixed;
        }

        static StackObject* CopyToStack_Mixed_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)o).Mixed;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_Mixed_2(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)o).Mixed = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_Mixed_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @Mixed = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)o).Mixed = @Mixed;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
