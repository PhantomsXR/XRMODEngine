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
    unsafe class LeanTester_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::LeanTester);
            args = new Type[]{};
            method = type.GetMethod("Start", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Start_0);

            field = type.GetField("timeout", flag);
            app.RegisterCLRFieldGetter(field, get_timeout_0);
            app.RegisterCLRFieldSetter(field, set_timeout_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_timeout_0, AssignFromStack_timeout_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new global::LeanTester());
            app.RegisterCLRCreateArrayInstance(type, s => new global::LeanTester[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Start_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LeanTester instance_of_this_method = (global::LeanTester)typeof(global::LeanTester).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Start();

            return __ret;
        }


        static object get_timeout_0(ref object o)
        {
            return ((global::LeanTester)o).timeout;
        }

        static StackObject* CopyToStack_timeout_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LeanTester)o).timeout;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_timeout_0(ref object o, object v)
        {
            ((global::LeanTester)o).timeout = (System.Single)v;
        }

        static StackObject* AssignFromStack_timeout_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @timeout = *(float*)&ptr_of_this_method->Value;
            ((global::LeanTester)o).timeout = @timeout;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new global::LeanTester();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
