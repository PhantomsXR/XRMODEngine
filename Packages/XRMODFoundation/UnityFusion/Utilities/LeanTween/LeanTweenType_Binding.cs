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
    unsafe class LeanTweenType_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::LeanTweenType);

            field = type.GetField("notUsed", flag);
            app.RegisterCLRFieldGetter(field, get_notUsed_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_notUsed_0, null);
            field = type.GetField("linear", flag);
            app.RegisterCLRFieldGetter(field, get_linear_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_linear_1, null);
            field = type.GetField("easeOutQuad", flag);
            app.RegisterCLRFieldGetter(field, get_easeOutQuad_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeOutQuad_2, null);
            field = type.GetField("easeInQuad", flag);
            app.RegisterCLRFieldGetter(field, get_easeInQuad_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInQuad_3, null);
            field = type.GetField("easeInOutQuad", flag);
            app.RegisterCLRFieldGetter(field, get_easeInOutQuad_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInOutQuad_4, null);
            field = type.GetField("easeInCubic", flag);
            app.RegisterCLRFieldGetter(field, get_easeInCubic_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInCubic_5, null);
            field = type.GetField("easeOutCubic", flag);
            app.RegisterCLRFieldGetter(field, get_easeOutCubic_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeOutCubic_6, null);
            field = type.GetField("easeInOutCubic", flag);
            app.RegisterCLRFieldGetter(field, get_easeInOutCubic_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInOutCubic_7, null);
            field = type.GetField("easeInQuart", flag);
            app.RegisterCLRFieldGetter(field, get_easeInQuart_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInQuart_8, null);
            field = type.GetField("easeOutQuart", flag);
            app.RegisterCLRFieldGetter(field, get_easeOutQuart_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeOutQuart_9, null);
            field = type.GetField("easeInOutQuart", flag);
            app.RegisterCLRFieldGetter(field, get_easeInOutQuart_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInOutQuart_10, null);
            field = type.GetField("easeInQuint", flag);
            app.RegisterCLRFieldGetter(field, get_easeInQuint_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInQuint_11, null);
            field = type.GetField("easeOutQuint", flag);
            app.RegisterCLRFieldGetter(field, get_easeOutQuint_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeOutQuint_12, null);
            field = type.GetField("easeInOutQuint", flag);
            app.RegisterCLRFieldGetter(field, get_easeInOutQuint_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInOutQuint_13, null);
            field = type.GetField("easeInSine", flag);
            app.RegisterCLRFieldGetter(field, get_easeInSine_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInSine_14, null);
            field = type.GetField("easeOutSine", flag);
            app.RegisterCLRFieldGetter(field, get_easeOutSine_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeOutSine_15, null);
            field = type.GetField("easeInOutSine", flag);
            app.RegisterCLRFieldGetter(field, get_easeInOutSine_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInOutSine_16, null);
            field = type.GetField("easeInExpo", flag);
            app.RegisterCLRFieldGetter(field, get_easeInExpo_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInExpo_17, null);
            field = type.GetField("easeOutExpo", flag);
            app.RegisterCLRFieldGetter(field, get_easeOutExpo_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeOutExpo_18, null);
            field = type.GetField("easeInOutExpo", flag);
            app.RegisterCLRFieldGetter(field, get_easeInOutExpo_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInOutExpo_19, null);
            field = type.GetField("easeInCirc", flag);
            app.RegisterCLRFieldGetter(field, get_easeInCirc_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInCirc_20, null);
            field = type.GetField("easeOutCirc", flag);
            app.RegisterCLRFieldGetter(field, get_easeOutCirc_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeOutCirc_21, null);
            field = type.GetField("easeInOutCirc", flag);
            app.RegisterCLRFieldGetter(field, get_easeInOutCirc_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInOutCirc_22, null);
            field = type.GetField("easeInBounce", flag);
            app.RegisterCLRFieldGetter(field, get_easeInBounce_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInBounce_23, null);
            field = type.GetField("easeOutBounce", flag);
            app.RegisterCLRFieldGetter(field, get_easeOutBounce_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeOutBounce_24, null);
            field = type.GetField("easeInOutBounce", flag);
            app.RegisterCLRFieldGetter(field, get_easeInOutBounce_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInOutBounce_25, null);
            field = type.GetField("easeInBack", flag);
            app.RegisterCLRFieldGetter(field, get_easeInBack_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInBack_26, null);
            field = type.GetField("easeOutBack", flag);
            app.RegisterCLRFieldGetter(field, get_easeOutBack_27);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeOutBack_27, null);
            field = type.GetField("easeInOutBack", flag);
            app.RegisterCLRFieldGetter(field, get_easeInOutBack_28);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInOutBack_28, null);
            field = type.GetField("easeInElastic", flag);
            app.RegisterCLRFieldGetter(field, get_easeInElastic_29);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInElastic_29, null);
            field = type.GetField("easeOutElastic", flag);
            app.RegisterCLRFieldGetter(field, get_easeOutElastic_30);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeOutElastic_30, null);
            field = type.GetField("easeInOutElastic", flag);
            app.RegisterCLRFieldGetter(field, get_easeInOutElastic_31);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeInOutElastic_31, null);
            field = type.GetField("easeSpring", flag);
            app.RegisterCLRFieldGetter(field, get_easeSpring_32);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeSpring_32, null);
            field = type.GetField("easeShake", flag);
            app.RegisterCLRFieldGetter(field, get_easeShake_33);
            app.RegisterCLRFieldBinding(field, CopyToStack_easeShake_33, null);
            field = type.GetField("punch", flag);
            app.RegisterCLRFieldGetter(field, get_punch_34);
            app.RegisterCLRFieldBinding(field, CopyToStack_punch_34, null);
            field = type.GetField("once", flag);
            app.RegisterCLRFieldGetter(field, get_once_35);
            app.RegisterCLRFieldBinding(field, CopyToStack_once_35, null);
            field = type.GetField("clamp", flag);
            app.RegisterCLRFieldGetter(field, get_clamp_36);
            app.RegisterCLRFieldBinding(field, CopyToStack_clamp_36, null);
            field = type.GetField("pingPong", flag);
            app.RegisterCLRFieldGetter(field, get_pingPong_37);
            app.RegisterCLRFieldBinding(field, CopyToStack_pingPong_37, null);
            field = type.GetField("animationCurve", flag);
            app.RegisterCLRFieldGetter(field, get_animationCurve_38);
            app.RegisterCLRFieldBinding(field, CopyToStack_animationCurve_38, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new global::LeanTweenType());
            app.RegisterCLRCreateArrayInstance(type, s => new global::LeanTweenType[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref global::LeanTweenType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as global::LeanTweenType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_notUsed_0(ref object o)
        {
            return global::LeanTweenType.notUsed;
        }

        static StackObject* CopyToStack_notUsed_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.notUsed;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_linear_1(ref object o)
        {
            return global::LeanTweenType.linear;
        }

        static StackObject* CopyToStack_linear_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.linear;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeOutQuad_2(ref object o)
        {
            return global::LeanTweenType.easeOutQuad;
        }

        static StackObject* CopyToStack_easeOutQuad_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeOutQuad;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInQuad_3(ref object o)
        {
            return global::LeanTweenType.easeInQuad;
        }

        static StackObject* CopyToStack_easeInQuad_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInQuad;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInOutQuad_4(ref object o)
        {
            return global::LeanTweenType.easeInOutQuad;
        }

        static StackObject* CopyToStack_easeInOutQuad_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInOutQuad;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInCubic_5(ref object o)
        {
            return global::LeanTweenType.easeInCubic;
        }

        static StackObject* CopyToStack_easeInCubic_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInCubic;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeOutCubic_6(ref object o)
        {
            return global::LeanTweenType.easeOutCubic;
        }

        static StackObject* CopyToStack_easeOutCubic_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeOutCubic;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInOutCubic_7(ref object o)
        {
            return global::LeanTweenType.easeInOutCubic;
        }

        static StackObject* CopyToStack_easeInOutCubic_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInOutCubic;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInQuart_8(ref object o)
        {
            return global::LeanTweenType.easeInQuart;
        }

        static StackObject* CopyToStack_easeInQuart_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInQuart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeOutQuart_9(ref object o)
        {
            return global::LeanTweenType.easeOutQuart;
        }

        static StackObject* CopyToStack_easeOutQuart_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeOutQuart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInOutQuart_10(ref object o)
        {
            return global::LeanTweenType.easeInOutQuart;
        }

        static StackObject* CopyToStack_easeInOutQuart_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInOutQuart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInQuint_11(ref object o)
        {
            return global::LeanTweenType.easeInQuint;
        }

        static StackObject* CopyToStack_easeInQuint_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInQuint;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeOutQuint_12(ref object o)
        {
            return global::LeanTweenType.easeOutQuint;
        }

        static StackObject* CopyToStack_easeOutQuint_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeOutQuint;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInOutQuint_13(ref object o)
        {
            return global::LeanTweenType.easeInOutQuint;
        }

        static StackObject* CopyToStack_easeInOutQuint_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInOutQuint;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInSine_14(ref object o)
        {
            return global::LeanTweenType.easeInSine;
        }

        static StackObject* CopyToStack_easeInSine_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInSine;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeOutSine_15(ref object o)
        {
            return global::LeanTweenType.easeOutSine;
        }

        static StackObject* CopyToStack_easeOutSine_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeOutSine;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInOutSine_16(ref object o)
        {
            return global::LeanTweenType.easeInOutSine;
        }

        static StackObject* CopyToStack_easeInOutSine_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInOutSine;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInExpo_17(ref object o)
        {
            return global::LeanTweenType.easeInExpo;
        }

        static StackObject* CopyToStack_easeInExpo_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInExpo;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeOutExpo_18(ref object o)
        {
            return global::LeanTweenType.easeOutExpo;
        }

        static StackObject* CopyToStack_easeOutExpo_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeOutExpo;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInOutExpo_19(ref object o)
        {
            return global::LeanTweenType.easeInOutExpo;
        }

        static StackObject* CopyToStack_easeInOutExpo_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInOutExpo;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInCirc_20(ref object o)
        {
            return global::LeanTweenType.easeInCirc;
        }

        static StackObject* CopyToStack_easeInCirc_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInCirc;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeOutCirc_21(ref object o)
        {
            return global::LeanTweenType.easeOutCirc;
        }

        static StackObject* CopyToStack_easeOutCirc_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeOutCirc;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInOutCirc_22(ref object o)
        {
            return global::LeanTweenType.easeInOutCirc;
        }

        static StackObject* CopyToStack_easeInOutCirc_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInOutCirc;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInBounce_23(ref object o)
        {
            return global::LeanTweenType.easeInBounce;
        }

        static StackObject* CopyToStack_easeInBounce_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInBounce;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeOutBounce_24(ref object o)
        {
            return global::LeanTweenType.easeOutBounce;
        }

        static StackObject* CopyToStack_easeOutBounce_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeOutBounce;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInOutBounce_25(ref object o)
        {
            return global::LeanTweenType.easeInOutBounce;
        }

        static StackObject* CopyToStack_easeInOutBounce_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInOutBounce;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInBack_26(ref object o)
        {
            return global::LeanTweenType.easeInBack;
        }

        static StackObject* CopyToStack_easeInBack_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInBack;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeOutBack_27(ref object o)
        {
            return global::LeanTweenType.easeOutBack;
        }

        static StackObject* CopyToStack_easeOutBack_27(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeOutBack;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInOutBack_28(ref object o)
        {
            return global::LeanTweenType.easeInOutBack;
        }

        static StackObject* CopyToStack_easeInOutBack_28(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInOutBack;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInElastic_29(ref object o)
        {
            return global::LeanTweenType.easeInElastic;
        }

        static StackObject* CopyToStack_easeInElastic_29(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInElastic;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeOutElastic_30(ref object o)
        {
            return global::LeanTweenType.easeOutElastic;
        }

        static StackObject* CopyToStack_easeOutElastic_30(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeOutElastic;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeInOutElastic_31(ref object o)
        {
            return global::LeanTweenType.easeInOutElastic;
        }

        static StackObject* CopyToStack_easeInOutElastic_31(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeInOutElastic;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeSpring_32(ref object o)
        {
            return global::LeanTweenType.easeSpring;
        }

        static StackObject* CopyToStack_easeSpring_32(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeSpring;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_easeShake_33(ref object o)
        {
            return global::LeanTweenType.easeShake;
        }

        static StackObject* CopyToStack_easeShake_33(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.easeShake;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_punch_34(ref object o)
        {
            return global::LeanTweenType.punch;
        }

        static StackObject* CopyToStack_punch_34(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.punch;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_once_35(ref object o)
        {
            return global::LeanTweenType.once;
        }

        static StackObject* CopyToStack_once_35(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.once;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_clamp_36(ref object o)
        {
            return global::LeanTweenType.clamp;
        }

        static StackObject* CopyToStack_clamp_36(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.clamp;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_pingPong_37(ref object o)
        {
            return global::LeanTweenType.pingPong;
        }

        static StackObject* CopyToStack_pingPong_37(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.pingPong;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_animationCurve_38(ref object o)
        {
            return global::LeanTweenType.animationCurve;
        }

        static StackObject* CopyToStack_animationCurve_38(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTweenType.animationCurve;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new global::LeanTweenType();
            ins = (global::LeanTweenType)o;
            return ins;
        }


    }
}
