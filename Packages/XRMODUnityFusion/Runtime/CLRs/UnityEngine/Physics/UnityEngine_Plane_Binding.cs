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
    unsafe class UnityEngine_Plane_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Plane);
            args = new Type[] {typeof(UnityEngine.Ray), typeof(System.Single).MakeByRefType()};
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_0);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Plane());

            args = new Type[] {typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain,
            StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.Plane instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                {
                    __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    else
                    {
                        var t = __domain.GetType(___obj.GetType()) as CLRType;
                        t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var t = __domain.GetType(ptr_of_this_method->Value);
                    if (t is ILType)
                    {
                        ((ILType) t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    else
                    {
                        ((CLRType) t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Plane[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                }
                    break;
            }
        }

        static StackObject* Raycast_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @enter = __intp.RetriveFloat(ptr_of_this_method, __mStack);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Ray @ray = (UnityEngine.Ray) typeof(UnityEngine.Ray).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Plane instance_of_this_method =
                (UnityEngine.Plane) typeof(UnityEngine.Plane).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            var result_of_this_method = instance_of_this_method.Raycast(@ray, out @enter);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    ___dst->ObjectType = ObjectTypes.Float;
                    *(float*) &___dst->Value = @enter;
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @enter;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @enter);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @enter;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @enter);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Single[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @enter;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @inPoint = new UnityEngine.Vector3();
            if (UnityEngineClrBinding.s_UnityEngine_Vector3_Binding_Binder != null)
            {
                UnityEngineClrBinding.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @inPoint, __intp,
                    ptr_of_this_method, __mStack, true);
            }
            else
            {
                @inPoint = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
                __intp.Free(ptr_of_this_method);
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @inNormal = new UnityEngine.Vector3();
            if (UnityEngineClrBinding.s_UnityEngine_Vector3_Binding_Binder != null)
            {
                UnityEngineClrBinding.s_UnityEngine_Vector3_Binding_Binder.ParseValue(ref @inNormal, __intp,
                    ptr_of_this_method, __mStack, true);
            }
            else
            {
                @inNormal = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
                __intp.Free(ptr_of_this_method);
            }


            var result_of_this_method = new UnityEngine.Plane(@inNormal, @inPoint);

            if (!isNewObj)
            {
                __ret--;
                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                return __ret;
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}