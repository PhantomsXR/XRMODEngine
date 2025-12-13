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
    unsafe class UnityEngine_PhysicMaterialCombine_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type =
#if UNITY_6000
                typeof(UnityEngine.PhysicsMaterialCombine);
#else
                typeof(UnityEngine.PhysicMaterialCombine);
#endif

            field = type.GetField("Average", flag);
            app.RegisterCLRFieldGetter(field, get_Average_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Average_0, null);
            field = type.GetField("Minimum", flag);
            app.RegisterCLRFieldGetter(field, get_Minimum_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Minimum_1, null);
            field = type.GetField("Multiply", flag);
            app.RegisterCLRFieldGetter(field, get_Multiply_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Multiply_2, null);
            field = type.GetField("Maximum", flag);
            app.RegisterCLRFieldGetter(field, get_Maximum_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Maximum_3, null);


            app.RegisterCLRCreateDefaultInstance(type, () =>
#if UNITY_6000
                new UnityEngine.PhysicsMaterialCombine());
#else
                new UnityEngine.PhysicMaterialCombine());
#endif
            app.RegisterCLRCreateArrayInstance(type, s =>
#if UNITY_6000
                new UnityEngine.PhysicsMaterialCombine[s]);

#else
                new UnityEngine.PhysicMaterialCombine[s]);
#endif
        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain,
            StackObject* ptr_of_this_method, AutoList __mStack,
#if UNITY_6000
            ref UnityEngine.PhysicsMaterialCombine instance_of_this_method)
#else
            ref UnityEngine.PhysicMaterialCombine instance_of_this_method)
#endif
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
#if UNITY_6000
                        __mStack[ptr_of_this_method->Value] as UnityEngine.PhysicsMaterialCombine[];
#else
                        __mStack[ptr_of_this_method->Value] as UnityEngine.PhysicMaterialCombine[];
#endif
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                }
                    break;
            }
        }


        static object get_Average_0(ref object o)
        {
#if UNITY_6000
            return UnityEngine.PhysicsMaterialCombine.Average;
#else
            return UnityEngine.PhysicMaterialCombine.Average;
#endif
        }

        static StackObject* CopyToStack_Average_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
#if UNITY_6000
                UnityEngine.PhysicsMaterialCombine.Average;
#else
            UnityEngine.PhysicMaterialCombine.Average;
#endif
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Minimum_1(ref object o)
        {
#if UNITY_6000
            return UnityEngine.PhysicsMaterialCombine.Minimum;
#else
            return UnityEngine.PhysicMaterialCombine.Minimum;
#endif
        }

        static StackObject* CopyToStack_Minimum_1(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
#if UNITY_6000
                UnityEngine.PhysicsMaterialCombine.Minimum;
#else
                UnityEngine.PhysicMaterialCombine.Minimum;
#endif
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Multiply_2(ref object o)
        {
#if UNITY_6000
            return UnityEngine.PhysicsMaterialCombine.Multiply;
#else
            return UnityEngine.PhysicMaterialCombine.Multiply;
#endif
        }

        static StackObject* CopyToStack_Multiply_2(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
#if UNITY_6000
                UnityEngine.PhysicsMaterialCombine.Multiply;
#else
                UnityEngine.PhysicMaterialCombine.Multiply;
#endif
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Maximum_3(ref object o)
        {
#if UNITY_6000
            return UnityEngine.PhysicsMaterialCombine.Maximum;
#else
            return UnityEngine.PhysicMaterialCombine.Maximum;
#endif
        }

        static StackObject* CopyToStack_Maximum_3(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
#if UNITY_6000
                UnityEngine.PhysicsMaterialCombine.Maximum;
#else
            UnityEngine.PhysicMaterialCombine.Maximum;
#endif
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
#if UNITY_6000
            var ins = new UnityEngine.PhysicsMaterialCombine();
            ins = (UnityEngine.PhysicsMaterialCombine) o;
#else
            var ins = new UnityEngine.PhysicMaterialCombine();
            ins = (UnityEngine.PhysicMaterialCombine) o;
#endif
            return ins;
        }
    }
}