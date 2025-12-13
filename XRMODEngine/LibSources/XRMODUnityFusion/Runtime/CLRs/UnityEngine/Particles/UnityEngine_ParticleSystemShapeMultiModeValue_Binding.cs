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
    unsafe class UnityEngine_ParticleSystemShapeMultiModeValue_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ParticleSystemShapeMultiModeValue);

            field = type.GetField("Random", flag);
            app.RegisterCLRFieldGetter(field, get_Random_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Random_0, null);
            field = type.GetField("Loop", flag);
            app.RegisterCLRFieldGetter(field, get_Loop_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Loop_1, null);
            field = type.GetField("PingPong", flag);
            app.RegisterCLRFieldGetter(field, get_PingPong_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_PingPong_2, null);
            field = type.GetField("BurstSpread", flag);
            app.RegisterCLRFieldGetter(field, get_BurstSpread_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_BurstSpread_3, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ParticleSystemShapeMultiModeValue());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ParticleSystemShapeMultiModeValue[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.ParticleSystemShapeMultiModeValue instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ParticleSystemShapeMultiModeValue[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Random_0(ref object o)
        {
            return UnityEngine.ParticleSystemShapeMultiModeValue.Random;
        }

        static StackObject* CopyToStack_Random_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemShapeMultiModeValue.Random;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Loop_1(ref object o)
        {
            return UnityEngine.ParticleSystemShapeMultiModeValue.Loop;
        }

        static StackObject* CopyToStack_Loop_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemShapeMultiModeValue.Loop;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_PingPong_2(ref object o)
        {
            return UnityEngine.ParticleSystemShapeMultiModeValue.PingPong;
        }

        static StackObject* CopyToStack_PingPong_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemShapeMultiModeValue.PingPong;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_BurstSpread_3(ref object o)
        {
            return UnityEngine.ParticleSystemShapeMultiModeValue.BurstSpread;
        }

        static StackObject* CopyToStack_BurstSpread_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemShapeMultiModeValue.BurstSpread;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ParticleSystemShapeMultiModeValue();
            ins = (UnityEngine.ParticleSystemShapeMultiModeValue)o;
            return ins;
        }


    }
}
