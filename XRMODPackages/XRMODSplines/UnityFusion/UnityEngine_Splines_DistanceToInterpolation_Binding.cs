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
    unsafe class UnityEngine_Splines_DistanceToInterpolation_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Splines.DistanceToInterpolation);

            field = type.GetField("Distance", flag);
            app.RegisterCLRFieldGetter(field, get_Distance_0);
            app.RegisterCLRFieldSetter(field, set_Distance_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Distance_0, AssignFromStack_Distance_0);
            field = type.GetField("T", flag);
            app.RegisterCLRFieldGetter(field, get_T_1);
            app.RegisterCLRFieldSetter(field, set_T_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_T_1, AssignFromStack_T_1);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Splines.DistanceToInterpolation());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Splines.DistanceToInterpolation[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.Splines.DistanceToInterpolation instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Splines.DistanceToInterpolation[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Distance_0(ref object o)
        {
            return ((UnityEngine.Splines.DistanceToInterpolation)o).Distance;
        }

        static StackObject* CopyToStack_Distance_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Splines.DistanceToInterpolation)o).Distance;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Distance_0(ref object o, object v)
        {
            UnityEngine.Splines.DistanceToInterpolation ins =(UnityEngine.Splines.DistanceToInterpolation)o;
            ins.Distance = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Distance_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Distance = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Splines.DistanceToInterpolation ins =(UnityEngine.Splines.DistanceToInterpolation)o;
            ins.Distance = @Distance;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_T_1(ref object o)
        {
            return ((UnityEngine.Splines.DistanceToInterpolation)o).T;
        }

        static StackObject* CopyToStack_T_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Splines.DistanceToInterpolation)o).T;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_T_1(ref object o, object v)
        {
            UnityEngine.Splines.DistanceToInterpolation ins =(UnityEngine.Splines.DistanceToInterpolation)o;
            ins.T = (System.Single)v;
            o = ins;
        }

        static StackObject* AssignFromStack_T_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @T = *(float*)&ptr_of_this_method->Value;
            UnityEngine.Splines.DistanceToInterpolation ins =(UnityEngine.Splines.DistanceToInterpolation)o;
            ins.T = @T;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Splines.DistanceToInterpolation();
            ins = (UnityEngine.Splines.DistanceToInterpolation)o;
            return ins;
        }


    }
}
