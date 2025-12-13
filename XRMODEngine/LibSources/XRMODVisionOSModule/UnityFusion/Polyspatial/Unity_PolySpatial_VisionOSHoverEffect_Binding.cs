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
    unsafe class Unity_PolySpatial_VisionOSHoverEffect_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.PolySpatial.VisionOSHoverEffect);
            args = new Type[]{};
            method = type.GetMethod("get_Type", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Type_0);
            args = new Type[]{typeof(Unity.PolySpatial.VisionOSHoverEffect.EffectType)};
            method = type.GetMethod("set_Type", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Type_1);
            args = new Type[]{};
            method = type.GetMethod("get_Color", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Color_2);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_Color", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Color_3);
            args = new Type[]{};
            method = type.GetMethod("get_IntensityMultiplier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IntensityMultiplier_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_IntensityMultiplier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_IntensityMultiplier_5);
            args = new Type[]{};
            method = type.GetMethod("get_FadeInDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_FadeInDuration_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_FadeInDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_FadeInDuration_7);
            args = new Type[]{};
            method = type.GetMethod("get_FadeOutDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_FadeOutDuration_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_FadeOutDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_FadeOutDuration_9);



            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.PolySpatial.VisionOSHoverEffect());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.PolySpatial.VisionOSHoverEffect[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Type_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSHoverEffect instance_of_this_method = (Unity.PolySpatial.VisionOSHoverEffect)typeof(Unity.PolySpatial.VisionOSHoverEffect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Type;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Type_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSHoverEffect.EffectType @value = (Unity.PolySpatial.VisionOSHoverEffect.EffectType)typeof(Unity.PolySpatial.VisionOSHoverEffect.EffectType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSHoverEffect instance_of_this_method = (Unity.PolySpatial.VisionOSHoverEffect)typeof(Unity.PolySpatial.VisionOSHoverEffect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Type = value;

            return __ret;
        }

        static StackObject* get_Color_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSHoverEffect instance_of_this_method = (Unity.PolySpatial.VisionOSHoverEffect)typeof(Unity.PolySpatial.VisionOSHoverEffect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Color;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Color_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSHoverEffect instance_of_this_method = (Unity.PolySpatial.VisionOSHoverEffect)typeof(Unity.PolySpatial.VisionOSHoverEffect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Color = value;

            return __ret;
        }

        static StackObject* get_IntensityMultiplier_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSHoverEffect instance_of_this_method = (Unity.PolySpatial.VisionOSHoverEffect)typeof(Unity.PolySpatial.VisionOSHoverEffect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IntensityMultiplier;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_IntensityMultiplier_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSHoverEffect instance_of_this_method = (Unity.PolySpatial.VisionOSHoverEffect)typeof(Unity.PolySpatial.VisionOSHoverEffect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.IntensityMultiplier = value;

            return __ret;
        }

        static StackObject* get_FadeInDuration_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSHoverEffect instance_of_this_method = (Unity.PolySpatial.VisionOSHoverEffect)typeof(Unity.PolySpatial.VisionOSHoverEffect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FadeInDuration;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_FadeInDuration_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSHoverEffect instance_of_this_method = (Unity.PolySpatial.VisionOSHoverEffect)typeof(Unity.PolySpatial.VisionOSHoverEffect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FadeInDuration = value;

            return __ret;
        }

        static StackObject* get_FadeOutDuration_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSHoverEffect instance_of_this_method = (Unity.PolySpatial.VisionOSHoverEffect)typeof(Unity.PolySpatial.VisionOSHoverEffect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FadeOutDuration;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_FadeOutDuration_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSHoverEffect instance_of_this_method = (Unity.PolySpatial.VisionOSHoverEffect)typeof(Unity.PolySpatial.VisionOSHoverEffect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FadeOutDuration = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.PolySpatial.VisionOSHoverEffect();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
