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
    unsafe class UnityEngine_ParticleSystemCurveMode_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ParticleSystemCurveMode);

            field = type.GetField("Constant", flag);
            app.RegisterCLRFieldGetter(field, get_Constant_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Constant_0, null);
            field = type.GetField("Curve", flag);
            app.RegisterCLRFieldGetter(field, get_Curve_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Curve_1, null);
            field = type.GetField("TwoCurves", flag);
            app.RegisterCLRFieldGetter(field, get_TwoCurves_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_TwoCurves_2, null);
            field = type.GetField("TwoConstants", flag);
            app.RegisterCLRFieldGetter(field, get_TwoConstants_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_TwoConstants_3, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ParticleSystemCurveMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ParticleSystemCurveMode[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.ParticleSystemCurveMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ParticleSystemCurveMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Constant_0(ref object o)
        {
            return UnityEngine.ParticleSystemCurveMode.Constant;
        }

        static StackObject* CopyToStack_Constant_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemCurveMode.Constant;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Curve_1(ref object o)
        {
            return UnityEngine.ParticleSystemCurveMode.Curve;
        }

        static StackObject* CopyToStack_Curve_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemCurveMode.Curve;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_TwoCurves_2(ref object o)
        {
            return UnityEngine.ParticleSystemCurveMode.TwoCurves;
        }

        static StackObject* CopyToStack_TwoCurves_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemCurveMode.TwoCurves;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_TwoConstants_3(ref object o)
        {
            return UnityEngine.ParticleSystemCurveMode.TwoConstants;
        }

        static StackObject* CopyToStack_TwoConstants_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemCurveMode.TwoConstants;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ParticleSystemCurveMode();
            ins = (UnityEngine.ParticleSystemCurveMode)o;
            return ins;
        }


    }
}
