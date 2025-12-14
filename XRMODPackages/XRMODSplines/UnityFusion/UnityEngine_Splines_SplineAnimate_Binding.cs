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
    unsafe class UnityEngine_Splines_SplineAnimate_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Splines.SplineAnimate);
            args = new Type[]{};
            method = type.GetMethod("get_Container", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Container_0);
            args = new Type[]{typeof(UnityEngine.Splines.SplineContainer)};
            method = type.GetMethod("set_Container", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Container_1);
            args = new Type[]{};
            method = type.GetMethod("get_PlayOnAwake", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PlayOnAwake_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_PlayOnAwake", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_PlayOnAwake_3);
            args = new Type[]{};
            method = type.GetMethod("get_Loop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Loop_4);
            args = new Type[]{typeof(UnityEngine.Splines.SplineAnimate.LoopMode)};
            method = type.GetMethod("set_Loop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Loop_5);
            args = new Type[]{};
            method = type.GetMethod("get_AnimationMethod", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AnimationMethod_6);
            args = new Type[]{typeof(UnityEngine.Splines.SplineAnimate.Method)};
            method = type.GetMethod("set_AnimationMethod", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_AnimationMethod_7);
            args = new Type[]{};
            method = type.GetMethod("get_Duration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Duration_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_Duration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Duration_9);
            args = new Type[]{};
            method = type.GetMethod("get_MaxSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxSpeed_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_MaxSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxSpeed_11);
            args = new Type[]{};
            method = type.GetMethod("get_Easing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Easing_12);
            args = new Type[]{typeof(UnityEngine.Splines.SplineAnimate.EasingMode)};
            method = type.GetMethod("set_Easing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Easing_13);
            args = new Type[]{};
            method = type.GetMethod("get_Alignment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Alignment_14);
            args = new Type[]{typeof(UnityEngine.Splines.SplineAnimate.AlignmentMode)};
            method = type.GetMethod("set_Alignment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Alignment_15);
            args = new Type[]{};
            method = type.GetMethod("get_ObjectForwardAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ObjectForwardAxis_16);
            args = new Type[]{typeof(UnityEngine.Splines.SplineComponent.AlignAxis)};
            method = type.GetMethod("set_ObjectForwardAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ObjectForwardAxis_17);
            args = new Type[]{};
            method = type.GetMethod("get_ObjectUpAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ObjectUpAxis_18);
            args = new Type[]{typeof(UnityEngine.Splines.SplineComponent.AlignAxis)};
            method = type.GetMethod("set_ObjectUpAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ObjectUpAxis_19);
            args = new Type[]{};
            method = type.GetMethod("get_NormalizedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NormalizedTime_20);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_NormalizedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_NormalizedTime_21);
            args = new Type[]{};
            method = type.GetMethod("get_ElapsedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ElapsedTime_22);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_ElapsedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ElapsedTime_23);
            args = new Type[]{};
            method = type.GetMethod("get_StartOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_StartOffset_24);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_StartOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_StartOffset_25);
            args = new Type[]{};
            method = type.GetMethod("get_IsPlaying", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsPlaying_26);
            args = new Type[]{typeof(System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>)};
            method = type.GetMethod("add_onUpdated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onUpdated_27);
            args = new Type[]{typeof(System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>)};
            method = type.GetMethod("remove_onUpdated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onUpdated_28);
            args = new Type[]{typeof(System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>)};
            method = type.GetMethod("add_Updated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_Updated_29);
            args = new Type[]{typeof(System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>)};
            method = type.GetMethod("remove_Updated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_Updated_30);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_Completed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_Completed_31);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_Completed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_Completed_32);
            args = new Type[]{};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_33);
            args = new Type[]{};
            method = type.GetMethod("Pause", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Pause_34);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Restart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Restart_35);
            args = new Type[]{};
            method = type.GetMethod("Update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Update_36);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Splines.SplineAnimate());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Splines.SplineAnimate[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Container_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Container;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Container_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineContainer @value = (UnityEngine.Splines.SplineContainer)typeof(UnityEngine.Splines.SplineContainer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Container = value;

            return __ret;
        }

        static StackObject* get_PlayOnAwake_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PlayOnAwake;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_PlayOnAwake_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlayOnAwake = value;

            return __ret;
        }

        static StackObject* get_Loop_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Loop;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Loop_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate.LoopMode @value = (UnityEngine.Splines.SplineAnimate.LoopMode)typeof(UnityEngine.Splines.SplineAnimate.LoopMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Loop = value;

            return __ret;
        }

        static StackObject* get_AnimationMethod_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AnimationMethod;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_AnimationMethod_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate.Method @value = (UnityEngine.Splines.SplineAnimate.Method)typeof(UnityEngine.Splines.SplineAnimate.Method).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AnimationMethod = value;

            return __ret;
        }

        static StackObject* get_Duration_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Duration;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_Duration_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Duration = value;

            return __ret;
        }

        static StackObject* get_MaxSpeed_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxSpeed;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaxSpeed_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxSpeed = value;

            return __ret;
        }

        static StackObject* get_Easing_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Easing;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Easing_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate.EasingMode @value = (UnityEngine.Splines.SplineAnimate.EasingMode)typeof(UnityEngine.Splines.SplineAnimate.EasingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Easing = value;

            return __ret;
        }

        static StackObject* get_Alignment_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Alignment;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Alignment_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate.AlignmentMode @value = (UnityEngine.Splines.SplineAnimate.AlignmentMode)typeof(UnityEngine.Splines.SplineAnimate.AlignmentMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Alignment = value;

            return __ret;
        }

        static StackObject* get_ObjectForwardAxis_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ObjectForwardAxis;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_ObjectForwardAxis_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineComponent.AlignAxis @value = (UnityEngine.Splines.SplineComponent.AlignAxis)typeof(UnityEngine.Splines.SplineComponent.AlignAxis).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ObjectForwardAxis = value;

            return __ret;
        }

        static StackObject* get_ObjectUpAxis_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ObjectUpAxis;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_ObjectUpAxis_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineComponent.AlignAxis @value = (UnityEngine.Splines.SplineComponent.AlignAxis)typeof(UnityEngine.Splines.SplineComponent.AlignAxis).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ObjectUpAxis = value;

            return __ret;
        }

        static StackObject* get_NormalizedTime_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.NormalizedTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_NormalizedTime_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.NormalizedTime = value;

            return __ret;
        }

        static StackObject* get_ElapsedTime_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ElapsedTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_ElapsedTime_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ElapsedTime = value;

            return __ret;
        }

        static StackObject* get_StartOffset_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.StartOffset;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_StartOffset_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartOffset = value;

            return __ret;
        }

        static StackObject* get_IsPlaying_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsPlaying;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* add_onUpdated_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Vector3, UnityEngine.Quaternion> @value = (System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>)typeof(System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onUpdated += value;

            return __ret;
        }

        static StackObject* remove_onUpdated_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Vector3, UnityEngine.Quaternion> @value = (System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>)typeof(System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onUpdated -= value;

            return __ret;
        }

        static StackObject* add_Updated_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Vector3, UnityEngine.Quaternion> @value = (System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>)typeof(System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Updated += value;

            return __ret;
        }

        static StackObject* remove_Updated_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Vector3, UnityEngine.Quaternion> @value = (System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>)typeof(System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Updated -= value;

            return __ret;
        }

        static StackObject* add_Completed_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Completed += value;

            return __ret;
        }

        static StackObject* remove_Completed_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Completed -= value;

            return __ret;
        }

        static StackObject* Play_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play();

            return __ret;
        }

        static StackObject* Pause_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Pause();

            return __ret;
        }

        static StackObject* Restart_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @autoplay = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Restart(@autoplay);

            return __ret;
        }

        static StackObject* Update_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineAnimate instance_of_this_method = (UnityEngine.Splines.SplineAnimate)typeof(UnityEngine.Splines.SplineAnimate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Update();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Splines.SplineAnimate();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
