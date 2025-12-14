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
    unsafe class UnityEngine_AI_ObstacleAvoidanceType_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.AI.ObstacleAvoidanceType);

            field = type.GetField("NoObstacleAvoidance", flag);
            app.RegisterCLRFieldGetter(field, get_NoObstacleAvoidance_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_NoObstacleAvoidance_0, null);
            field = type.GetField("LowQualityObstacleAvoidance", flag);
            app.RegisterCLRFieldGetter(field, get_LowQualityObstacleAvoidance_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_LowQualityObstacleAvoidance_1, null);
            field = type.GetField("MedQualityObstacleAvoidance", flag);
            app.RegisterCLRFieldGetter(field, get_MedQualityObstacleAvoidance_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_MedQualityObstacleAvoidance_2, null);
            field = type.GetField("GoodQualityObstacleAvoidance", flag);
            app.RegisterCLRFieldGetter(field, get_GoodQualityObstacleAvoidance_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_GoodQualityObstacleAvoidance_3, null);
            field = type.GetField("HighQualityObstacleAvoidance", flag);
            app.RegisterCLRFieldGetter(field, get_HighQualityObstacleAvoidance_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_HighQualityObstacleAvoidance_4, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AI.ObstacleAvoidanceType());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AI.ObstacleAvoidanceType[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.AI.ObstacleAvoidanceType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AI.ObstacleAvoidanceType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_NoObstacleAvoidance_0(ref object o)
        {
            return UnityEngine.AI.ObstacleAvoidanceType.NoObstacleAvoidance;
        }

        static StackObject* CopyToStack_NoObstacleAvoidance_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.ObstacleAvoidanceType.NoObstacleAvoidance;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_LowQualityObstacleAvoidance_1(ref object o)
        {
            return UnityEngine.AI.ObstacleAvoidanceType.LowQualityObstacleAvoidance;
        }

        static StackObject* CopyToStack_LowQualityObstacleAvoidance_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.ObstacleAvoidanceType.LowQualityObstacleAvoidance;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MedQualityObstacleAvoidance_2(ref object o)
        {
            return UnityEngine.AI.ObstacleAvoidanceType.MedQualityObstacleAvoidance;
        }

        static StackObject* CopyToStack_MedQualityObstacleAvoidance_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.ObstacleAvoidanceType.MedQualityObstacleAvoidance;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GoodQualityObstacleAvoidance_3(ref object o)
        {
            return UnityEngine.AI.ObstacleAvoidanceType.GoodQualityObstacleAvoidance;
        }

        static StackObject* CopyToStack_GoodQualityObstacleAvoidance_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.ObstacleAvoidanceType.GoodQualityObstacleAvoidance;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_HighQualityObstacleAvoidance_4(ref object o)
        {
            return UnityEngine.AI.ObstacleAvoidanceType.HighQualityObstacleAvoidance;
        }

        static StackObject* CopyToStack_HighQualityObstacleAvoidance_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.AI.ObstacleAvoidanceType.HighQualityObstacleAvoidance;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.AI.ObstacleAvoidanceType();
            ins = (UnityEngine.AI.ObstacleAvoidanceType)o;
            return ins;
        }


    }
}
