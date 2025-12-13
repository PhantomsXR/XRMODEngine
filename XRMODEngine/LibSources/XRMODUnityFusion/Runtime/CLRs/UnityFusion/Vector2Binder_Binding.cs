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
public unsafe class Vector2Binder_Binding
{
    public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
    {
        BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                            BindingFlags.DeclaredOnly;
        MethodBase method;
        Type[] args;
        Type type = typeof(global::Vector2Binder);
        args = new Type[] {typeof(UnityFusion.Runtime.Enviorment.AppDomain)};
        method = type.GetMethod("RegisterCLRRedirection", flag, null, args, null);
        app.RegisterCLRMethodRedirection(method, RegisterCLRRedirection_0);


        app.RegisterCLRCreateDefaultInstance(type, () => new global::Vector2Binder());
        app.RegisterCLRCreateArrayInstance(type, s => new global::Vector2Binder[s]);

        args = new Type[] { };
        method = type.GetConstructor(flag, null, args, null);
        app.RegisterCLRMethodRedirection(method, Ctor_0);
    }


    static StackObject* RegisterCLRRedirection_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
        CLRMethod __method, bool isNewObj)
    {
        UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        StackObject* ptr_of_this_method;
        StackObject* __ret = ILIntepreter.Minus(__esp, 2);

        ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        UnityFusion.Runtime.Enviorment.AppDomain @appdomain =
            (UnityFusion.Runtime.Enviorment.AppDomain) typeof(UnityFusion.Runtime.Enviorment.AppDomain).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
        __intp.Free(ptr_of_this_method);

        ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        global::Vector2Binder instance_of_this_method =
            (global::Vector2Binder) typeof(global::Vector2Binder).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
        __intp.Free(ptr_of_this_method);

        instance_of_this_method.RegisterCLRRedirection(@appdomain);

        return __ret;
    }


    static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
        bool isNewObj)
    {
        UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        StackObject* __ret = ILIntepreter.Minus(__esp, 0);

        var result_of_this_method = new global::Vector2Binder();

        return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
    }
}