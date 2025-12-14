// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CLRBingding.CLR.UnityEngine.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

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
    unsafe class UnityEngine_Gizmos_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Gizmos);
            args = new Type[] {typeof(UnityEngine.Color)};
            method = type.GetMethod("set_color", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_color_0);
            args = new Type[] {typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("DrawLine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawLine_1);
            args = new Type[] {typeof(UnityEngine.Vector3), typeof(System.Single)};
            method = type.GetMethod("DrawWireSphere", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawWireSphere_2);
        }


        static StackObject* set_color_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = (UnityEngine.Color) typeof(UnityEngine.Color).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Gizmos.color = value;

            return __ret;
        }

        static StackObject* DrawLine_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @to = new UnityEngine.Vector3();
            if (UnityEngineClrBinding.s_UnityEngine_Vector3_Binding_Binder != null)
            {
                UnityEngineClrBinding.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @to, __intp,
                    ptr_of_this_method, __mStack, true);
            }
            else
            {
                @to = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @from = new UnityEngine.Vector3();
            if (UnityEngineClrBinding.s_UnityEngine_Vector3_Binding_Binder != null)
            {
                UnityEngineClrBinding.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @from, __intp,
                    ptr_of_this_method, __mStack, true);
            }
            else
            {
                @from = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
                __intp.Free(ptr_of_this_method);
            }


            UnityEngine.Gizmos.DrawLine(@from, @to);

            return __ret;
        }

        static StackObject* DrawWireSphere_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @center = new UnityEngine.Vector3();
            if (UnityEngineClrBinding.s_UnityEngine_Vector3_Binding_Binder != null)
            {
                UnityEngineClrBinding.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @center,
                    __intp, ptr_of_this_method, __mStack, true);
            }
            else
            {
                @center = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
                __intp.Free(ptr_of_this_method);
            }


            UnityEngine.Gizmos.DrawWireSphere(@center, @radius);

            return __ret;
        }
    }
}