using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;
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
    unsafe class UnityEngine_LayerMask_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.LayerMask);
            MethodInfo[] methods = type.GetMethods(flag).Where(t => !t.IsGenericMethod).ToArray();
            args = new Type[] {typeof(UnityEngine.LayerMask)};
            method = methods
                .Single(t =>
                    t.Name.Equals("op_Implicit") && t.ReturnType == typeof(Int32) && t.CheckMethodParams(args));
            app.RegisterCLRMethodRedirection(method, op_Implicit_0);
            args = new Type[] {typeof(System.Int32)};
            method = methods.Single(t => t.Name.Equals("op_Implicit") && t.ReturnType == typeof(LayerMask) &&
                                         t.CheckMethodParams(args));
            app.RegisterCLRMethodRedirection(method, op_Implicit_1);
            args = new Type[] { };
            method = type.GetMethod("get_value", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_value_2);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("set_value", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_value_3);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("LayerToName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LayerToName_4);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("NameToLayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NameToLayer_5);
            args = new Type[] {typeof(System.String[])};
            method = type.GetMethod("GetMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMask_6);


            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.LayerMask());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.LayerMask[s]);
        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain,
            StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.LayerMask instance_of_this_method)
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
                    var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.LayerMask[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                }
                    break;
            }
        }

        static StackObject* op_Implicit_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            var tmp_LayerMaskNames =
                Utility.GetLayerNamesFromMask((int) StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            UnityEngine.LayerMask @mask = Utility.CreateLayerMaskFromNames(tmp_LayerMaskNames);

            var result_of_this_method = (System.Int32) mask;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* op_Implicit_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @intVal = ptr_of_this_method->Value;


            var result_of_this_method = (UnityEngine.LayerMask) intVal;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_value_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);

            var tmp_Result = StackObject.ToObject(ptr_of_this_method, __domain, __mStack);
            int result_of_this_method = -1;
            LayerMask tmp_LayerMask;
            if (tmp_Result is LayerMask _layerMask)
            {
                tmp_LayerMask = _layerMask;
                result_of_this_method = _layerMask.value;
            }
            else
            {
                int tmp_LayerId = (int) StackObject.ToObject(ptr_of_this_method, __domain, __mStack);
                tmp_LayerMask = tmp_LayerId;
                result_of_this_method = tmp_LayerMask.value;
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref tmp_LayerMask);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_value_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.LayerMask instance_of_this_method =
                (UnityEngine.LayerMask) typeof(UnityEngine.LayerMask).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method.value = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* LayerToName_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.LayerMask.LayerToName(@layer);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* NameToLayer_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @layerName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.LayerMask.NameToLayer(@layerName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetMask_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String[] @layerNames = (System.String[]) typeof(System.String[]).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.LayerMask.GetMask(@layerNames);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.LayerMask();
            ins = (UnityEngine.LayerMask) o;
            return ins;
        }
    }
}