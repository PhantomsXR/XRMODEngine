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
    unsafe class UnityEngine_ArticulationJacobian_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.ArticulationJacobian);
            args = new Type[] {typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("get_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Item_0);
            args = new Type[] {typeof(System.Int32), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("set_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Item_1);
            args = new Type[] { };
            method = type.GetMethod("get_rows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rows_2);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("set_rows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rows_3);
            args = new Type[] { };
            method = type.GetMethod("get_columns", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_columns_4);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("set_columns", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_columns_5);
            args = new Type[] { };
            method = type.GetMethod("get_elements", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_elements_6);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("set_elements", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_elements_7);


            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ArticulationJacobian());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ArticulationJacobian[s]);

            args = new Type[] {typeof(System.Int32), typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain,
            StackObject* ptr_of_this_method, AutoList __mStack,
            ref UnityEngine.ArticulationJacobian instance_of_this_method)
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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as UnityEngine.ArticulationJacobian[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                }
                    break;
            }
        }

        static StackObject* get_Item_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @col = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @row = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ArticulationJacobian instance_of_this_method =
                (UnityEngine.ArticulationJacobian) typeof(UnityEngine.ArticulationJacobian).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            var result_of_this_method = instance_of_this_method[row, @col];

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_Item_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @col = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @row = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ArticulationJacobian instance_of_this_method =
                (UnityEngine.ArticulationJacobian) typeof(UnityEngine.ArticulationJacobian).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_rows_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ArticulationJacobian instance_of_this_method =
                (UnityEngine.ArticulationJacobian) typeof(UnityEngine.ArticulationJacobian).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            var result_of_this_method = instance_of_this_method.rows;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_rows_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ArticulationJacobian instance_of_this_method =
                (UnityEngine.ArticulationJacobian) typeof(UnityEngine.ArticulationJacobian).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method.rows = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_columns_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ArticulationJacobian instance_of_this_method =
                (UnityEngine.ArticulationJacobian) typeof(UnityEngine.ArticulationJacobian).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            var result_of_this_method = instance_of_this_method.columns;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_columns_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ArticulationJacobian instance_of_this_method =
                (UnityEngine.ArticulationJacobian) typeof(UnityEngine.ArticulationJacobian).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method.columns = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_elements_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ArticulationJacobian instance_of_this_method =
                (UnityEngine.ArticulationJacobian) typeof(UnityEngine.ArticulationJacobian).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            var result_of_this_method = instance_of_this_method.elements;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_elements_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @value =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ArticulationJacobian instance_of_this_method =
                (UnityEngine.ArticulationJacobian) typeof(UnityEngine.ArticulationJacobian).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method.elements = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ArticulationJacobian();
            ins = (UnityEngine.ArticulationJacobian) o;
            return ins;
        }

        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @cols = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @rows = ptr_of_this_method->Value;


            var result_of_this_method = new UnityEngine.ArticulationJacobian(@rows, @cols);

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