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
    unsafe class UnityEngine_JointSpring_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.JointSpring);

            field = type.GetField("spring", flag);
            app.RegisterCLRFieldGetter(field, get_spring_0);
            app.RegisterCLRFieldSetter(field, set_spring_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_spring_0, AssignFromStack_spring_0);
            field = type.GetField("damper", flag);
            app.RegisterCLRFieldGetter(field, get_damper_1);
            app.RegisterCLRFieldSetter(field, set_damper_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_damper_1, AssignFromStack_damper_1);
            field = type.GetField("targetPosition", flag);
            app.RegisterCLRFieldGetter(field, get_targetPosition_2);
            app.RegisterCLRFieldSetter(field, set_targetPosition_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_targetPosition_2, AssignFromStack_targetPosition_2);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.JointSpring());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.JointSpring[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.JointSpring instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
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
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.JointSpring[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_spring_0(ref object o)
        {
            return ((UnityEngine.JointSpring)o).spring;
        }

        static StackObject* CopyToStack_spring_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.JointSpring)o).spring;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_spring_0(ref object o, object v)
        {
            UnityEngine.JointSpring ins =(UnityEngine.JointSpring)o;
            ins.spring = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_spring_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @spring = *(float*)&ptr_of_this_method->Value;
            UnityEngine.JointSpring ins =(UnityEngine.JointSpring)o;
            ins.spring = @spring;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_damper_1(ref object o)
        {
            return ((UnityEngine.JointSpring)o).damper;
        }

        static StackObject* CopyToStack_damper_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.JointSpring)o).damper;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_damper_1(ref object o, object v)
        {
            UnityEngine.JointSpring ins =(UnityEngine.JointSpring)o;
            ins.damper = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_damper_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @damper = *(float*)&ptr_of_this_method->Value;
            UnityEngine.JointSpring ins =(UnityEngine.JointSpring)o;
            ins.damper = @damper;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_targetPosition_2(ref object o)
        {
            return ((UnityEngine.JointSpring)o).targetPosition;
        }

        static StackObject* CopyToStack_targetPosition_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.JointSpring)o).targetPosition;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_targetPosition_2(ref object o, object v)
        {
            UnityEngine.JointSpring ins =(UnityEngine.JointSpring)o;
            ins.targetPosition = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_targetPosition_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @targetPosition = *(float*)&ptr_of_this_method->Value;
            UnityEngine.JointSpring ins =(UnityEngine.JointSpring)o;
            ins.targetPosition = @targetPosition;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.JointSpring();
            ins = (UnityEngine.JointSpring)o;
            return ins;
        }


    }
}
