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
    unsafe class System_Collections_Generic_Dictionary_2_String_PhysicsMaterial_Binding_Enumerator_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
#if UNITY_6000_0_OR_NEWER
            Type type =
                typeof(System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>.Enumerator);
#else
            Type type =
                typeof(System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>.Enumerator);
#endif

            args = new Type[] { };
            method = type.GetMethod("get_Current", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Current_0);
            args = new Type[] { };
            method = type.GetMethod("MoveNext", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveNext_1);
#if UNITY_6000_0_OR_NEWER
            app.RegisterCLRCreateDefaultInstance(type,
                () => new System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>.
                    Enumerator());
#else
            app.RegisterCLRCreateDefaultInstance(type,
                () => new System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>.
                    Enumerator());
#endif
        }
#if UNITY_6000_0_OR_NEWER
        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain,
            StackObject* ptr_of_this_method, AutoList __mStack,
            ref System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>.Enumerator
                instance_of_this_method)
#else
        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain,
            StackObject* ptr_of_this_method, AutoList __mStack,
            ref System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>.Enumerator
                instance_of_this_method)
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
#if UNITY_6000_0_OR_NEWER
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as System.Collections.Generic.Dictionary<System.String,
                            UnityEngine.PhysicsMaterial>.Enumerator[];
#else
                      var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as System.Collections.Generic.Dictionary<System.String,
                            UnityEngine.PhysicMaterial>.Enumerator[];
#endif


                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                }
                    break;
            }
        }

        static StackObject* get_Current_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
#if UNITY_6000_0_OR_NEWER
            System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>.Enumerator
                instance_of_this_method =
                    (System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>.Enumerator)
                    typeof(System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>.Enumerator)
                        .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                            (CLR.Utils.Extensions.TypeFlags) 16);
#else
            System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>.Enumerator
                instance_of_this_method =
                    (System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>.Enumerator)
                    typeof(System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>.Enumerator)
                        .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                            (CLR.Utils.Extensions.TypeFlags) 16);
#endif


            var result_of_this_method = instance_of_this_method.Current;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* MoveNext_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
#if UNITY_6000_0_OR_NEWER
            System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>.Enumerator
                instance_of_this_method =
                    (System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>.Enumerator)
                    typeof(System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>.Enumerator)
                        .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                            (CLR.Utils.Extensions.TypeFlags) 16);
#else
            System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>.Enumerator
                instance_of_this_method =
                    (System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>.Enumerator)
                    typeof(System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>.Enumerator)
                        .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                            (CLR.Utils.Extensions.TypeFlags) 16);
#endif


            var result_of_this_method = instance_of_this_method.MoveNext();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }
    }
}