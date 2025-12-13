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
    unsafe class UnityEngine_InputSystem_Haptics_IHaptics_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.Haptics.IHaptics);
            args = new Type[]{};
            method = type.GetMethod("PauseHaptics", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PauseHaptics_0);
            args = new Type[]{};
            method = type.GetMethod("ResumeHaptics", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResumeHaptics_1);
            args = new Type[]{};
            method = type.GetMethod("ResetHaptics", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetHaptics_2);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.Haptics.IHaptics[s]);


        }


        static StackObject* PauseHaptics_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Haptics.IHaptics instance_of_this_method = (UnityEngine.InputSystem.Haptics.IHaptics)typeof(UnityEngine.InputSystem.Haptics.IHaptics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PauseHaptics();

            return __ret;
        }

        static StackObject* ResumeHaptics_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Haptics.IHaptics instance_of_this_method = (UnityEngine.InputSystem.Haptics.IHaptics)typeof(UnityEngine.InputSystem.Haptics.IHaptics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResumeHaptics();

            return __ret;
        }

        static StackObject* ResetHaptics_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Haptics.IHaptics instance_of_this_method = (UnityEngine.InputSystem.Haptics.IHaptics)typeof(UnityEngine.InputSystem.Haptics.IHaptics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetHaptics();

            return __ret;
        }





    }
}
