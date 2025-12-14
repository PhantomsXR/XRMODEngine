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
#if UNITY_6000_0_OR_NEWER && UNITY_6000_0_34
    unsafe class UnityEngine_InstantiateParameters_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.InstantiateParameters);

            field = type.GetField("parent", flag);
            app.RegisterCLRFieldGetter(field, get_parent_0);
            app.RegisterCLRFieldSetter(field, set_parent_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_parent_0, AssignFromStack_parent_0);
            field = type.GetField("worldSpace", flag);
            app.RegisterCLRFieldGetter(field, get_worldSpace_1);
            app.RegisterCLRFieldSetter(field, set_worldSpace_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_worldSpace_1, AssignFromStack_worldSpace_1);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InstantiateParameters());
        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain,
            StackObject* ptr_of_this_method, AutoList __mStack,
            ref UnityEngine.InstantiateParameters instance_of_this_method)
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
                        __mStack[ptr_of_this_method->Value] as UnityEngine.InstantiateParameters[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                }
                    break;
            }
        }


        static object get_parent_0(ref object o)
        {
            return ((UnityEngine.InstantiateParameters) o).parent;
        }

        static StackObject* CopyToStack_parent_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.InstantiateParameters) o).parent;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_parent_0(ref object o, object v)
        {
            UnityEngine.InstantiateParameters ins = (UnityEngine.InstantiateParameters) o;
            ins.parent = (UnityEngine.Transform) v;
            o = ins;
        }

        static StackObject* AssignFromStack_parent_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method,
            AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @parent = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            UnityEngine.InstantiateParameters ins = (UnityEngine.InstantiateParameters) o;
            ins.parent = @parent;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_worldSpace_1(ref object o)
        {
            return ((UnityEngine.InstantiateParameters) o).worldSpace;
        }

        static StackObject* CopyToStack_worldSpace_1(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.InstantiateParameters) o).worldSpace;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_worldSpace_1(ref object o, object v)
        {
            UnityEngine.InstantiateParameters ins = (UnityEngine.InstantiateParameters) o;
            ins.worldSpace = (System.Boolean) v;
            o = ins;
        }

        static StackObject* AssignFromStack_worldSpace_1(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @worldSpace = ptr_of_this_method->Value == 1;
            UnityEngine.InstantiateParameters ins = (UnityEngine.InstantiateParameters) o;
            ins.worldSpace = @worldSpace;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.InstantiateParameters();
            ins = (UnityEngine.InstantiateParameters) o;
            return ins;
        }
    }
#endif
}