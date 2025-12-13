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
    unsafe class System_Threading_Tasks_Task_1_PhysicsMaterial_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
#if UNITY_6000_0_OR_NEWER
            Type type = typeof(System.Threading.Tasks.Task<UnityEngine.PhysicsMaterial>);
#else
            Type type = typeof(System.Threading.Tasks.Task<UnityEngine.PhysicMaterial>);
#endif

            args = new Type[] { };
            method = type.GetMethod("GetAwaiter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAwaiter_0);
        }


        static StackObject* GetAwaiter_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
#if UNITY_6000_0_OR_NEWER
            System.Threading.Tasks.Task<UnityEngine.PhysicsMaterial> instance_of_this_method =
                (System.Threading.Tasks.Task<UnityEngine.PhysicsMaterial>)
                typeof(System.Threading.Tasks.Task<UnityEngine.PhysicsMaterial>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);

#else
            System.Threading.Tasks.Task<UnityEngine.PhysicMaterial> instance_of_this_method =
                (System.Threading.Tasks.Task<UnityEngine.PhysicMaterial>)
                typeof(System.Threading.Tasks.Task<UnityEngine.PhysicMaterial>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);

#endif

            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAwaiter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}