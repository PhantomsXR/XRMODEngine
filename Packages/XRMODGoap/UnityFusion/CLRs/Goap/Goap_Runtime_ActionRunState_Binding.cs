using System;
using System.Collections.Generic;
using System.Linq;
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
    unsafe class Goap_Runtime_ActionRunState_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Goap.Runtime.ActionRunState);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("StopAndLog", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StopAndLog_0);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean)};
            method = type.GetMethod("WaitThenComplete", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WaitThenComplete_1);

            field = type.GetField("Completed", flag);
            app.RegisterCLRFieldGetter(field, get_Completed_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Completed_0, null);
            field = type.GetField("Continue", flag);
            app.RegisterCLRFieldGetter(field, get_Continue_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Continue_1, null);
            field = type.GetField("Stop", flag);
            app.RegisterCLRFieldGetter(field, get_Stop_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Stop_2, null);


        }


        static StackObject* StopAndLog_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Goap.Runtime.ActionRunState.StopAndLog(@message);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WaitThenComplete_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @mayResolve = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @time = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Goap.Runtime.ActionRunState.WaitThenComplete(@time, @mayResolve);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_Completed_0(ref object o)
        {
            return Goap.Runtime.ActionRunState.Completed;
        }

        static StackObject* CopyToStack_Completed_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Goap.Runtime.ActionRunState.Completed;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Continue_1(ref object o)
        {
            return Goap.Runtime.ActionRunState.Continue;
        }

        static StackObject* CopyToStack_Continue_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Goap.Runtime.ActionRunState.Continue;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Stop_2(ref object o)
        {
            return Goap.Runtime.ActionRunState.Stop;
        }

        static StackObject* CopyToStack_Stop_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Goap.Runtime.ActionRunState.Stop;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}
