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
    unsafe class UnityEngine_ParticleSystemGradientMode_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ParticleSystemGradientMode);

            field = type.GetField("Color", flag);
            app.RegisterCLRFieldGetter(field, get_Color_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Color_0, null);
            field = type.GetField("Gradient", flag);
            app.RegisterCLRFieldGetter(field, get_Gradient_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Gradient_1, null);
            field = type.GetField("TwoColors", flag);
            app.RegisterCLRFieldGetter(field, get_TwoColors_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_TwoColors_2, null);
            field = type.GetField("TwoGradients", flag);
            app.RegisterCLRFieldGetter(field, get_TwoGradients_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_TwoGradients_3, null);
            field = type.GetField("RandomColor", flag);
            app.RegisterCLRFieldGetter(field, get_RandomColor_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_RandomColor_4, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ParticleSystemGradientMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ParticleSystemGradientMode[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.ParticleSystemGradientMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ParticleSystemGradientMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Color_0(ref object o)
        {
            return UnityEngine.ParticleSystemGradientMode.Color;
        }

        static StackObject* CopyToStack_Color_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemGradientMode.Color;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Gradient_1(ref object o)
        {
            return UnityEngine.ParticleSystemGradientMode.Gradient;
        }

        static StackObject* CopyToStack_Gradient_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemGradientMode.Gradient;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_TwoColors_2(ref object o)
        {
            return UnityEngine.ParticleSystemGradientMode.TwoColors;
        }

        static StackObject* CopyToStack_TwoColors_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemGradientMode.TwoColors;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_TwoGradients_3(ref object o)
        {
            return UnityEngine.ParticleSystemGradientMode.TwoGradients;
        }

        static StackObject* CopyToStack_TwoGradients_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemGradientMode.TwoGradients;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RandomColor_4(ref object o)
        {
            return UnityEngine.ParticleSystemGradientMode.RandomColor;
        }

        static StackObject* CopyToStack_RandomColor_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.ParticleSystemGradientMode.RandomColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ParticleSystemGradientMode();
            ins = (UnityEngine.ParticleSystemGradientMode)o;
            return ins;
        }


    }
}
