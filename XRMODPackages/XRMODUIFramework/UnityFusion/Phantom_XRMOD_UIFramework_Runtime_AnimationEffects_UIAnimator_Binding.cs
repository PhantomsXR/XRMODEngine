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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_AnimationEffects_UIAnimator_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator);
            args = new Type[]{};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_0);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationType)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_1);
            args = new Type[]{};
            method = type.GetMethod("Reverse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Reverse_2);

            field = type.GetField("Preset", flag);
            app.RegisterCLRFieldGetter(field, get_Preset_0);
            app.RegisterCLRFieldSetter(field, set_Preset_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Preset_0, AssignFromStack_Preset_0);
            field = type.GetField("Duration", flag);
            app.RegisterCLRFieldGetter(field, get_Duration_1);
            app.RegisterCLRFieldSetter(field, set_Duration_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Duration_1, AssignFromStack_Duration_1);
            field = type.GetField("ReducedMotion", flag);
            app.RegisterCLRFieldGetter(field, get_ReducedMotion_2);
            app.RegisterCLRFieldSetter(field, set_ReducedMotion_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_ReducedMotion_2, AssignFromStack_ReducedMotion_2);
            field = type.GetField("AutoPlay", flag);
            app.RegisterCLRFieldGetter(field, get_AutoPlay_3);
            app.RegisterCLRFieldSetter(field, set_AutoPlay_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_AutoPlay_3, AssignFromStack_AutoPlay_3);
            field = type.GetField("animationType", flag);
            app.RegisterCLRFieldGetter(field, get_animationType_4);
            app.RegisterCLRFieldSetter(field, set_animationType_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_animationType_4, AssignFromStack_animationType_4);
            field = type.GetField("customCurve", flag);
            app.RegisterCLRFieldGetter(field, get_customCurve_5);
            app.RegisterCLRFieldSetter(field, set_customCurve_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_customCurve_5, AssignFromStack_customCurve_5);
            field = type.GetField("OnAnimationComplete", flag);
            app.RegisterCLRFieldGetter(field, get_OnAnimationComplete_6);
            app.RegisterCLRFieldSetter(field, set_OnAnimationComplete_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnAnimationComplete_6, AssignFromStack_OnAnimationComplete_6);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Play_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play();

            return __ret;
        }

        static StackObject* Play_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationType @_animationType = (Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationType)typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(@_animationType);

            return __ret;
        }

        static StackObject* Reverse_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Reverse();

            return __ret;
        }


        static object get_Preset_0(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).Preset;
        }

        static StackObject* CopyToStack_Preset_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).Preset;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Preset_0(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).Preset = (Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationPreset)v;
        }

        static StackObject* AssignFromStack_Preset_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationPreset @Preset = (Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationPreset)typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationPreset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).Preset = @Preset;
            return ptr_of_this_method;
        }

        static object get_Duration_1(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).Duration;
        }

        static StackObject* CopyToStack_Duration_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).Duration;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Duration_1(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).Duration = (System.Single)v;
        }

        static StackObject* AssignFromStack_Duration_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Duration = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).Duration = @Duration;
            return ptr_of_this_method;
        }

        static object get_ReducedMotion_2(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).ReducedMotion;
        }

        static StackObject* CopyToStack_ReducedMotion_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).ReducedMotion;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ReducedMotion_2(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).ReducedMotion = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ReducedMotion_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ReducedMotion = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).ReducedMotion = @ReducedMotion;
            return ptr_of_this_method;
        }

        static object get_AutoPlay_3(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).AutoPlay;
        }

        static StackObject* CopyToStack_AutoPlay_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).AutoPlay;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AutoPlay_3(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).AutoPlay = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AutoPlay_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AutoPlay = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).AutoPlay = @AutoPlay;
            return ptr_of_this_method;
        }

        static object get_animationType_4(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).animationType;
        }

        static StackObject* CopyToStack_animationType_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).animationType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_animationType_4(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).animationType = (Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationType)v;
        }

        static StackObject* AssignFromStack_animationType_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationType @animationType = (Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationType)typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimationType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).animationType = @animationType;
            return ptr_of_this_method;
        }

        static object get_customCurve_5(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).customCurve;
        }

        static StackObject* CopyToStack_customCurve_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).customCurve;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_customCurve_5(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).customCurve = (UnityEngine.AnimationCurve)v;
        }

        static StackObject* AssignFromStack_customCurve_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.AnimationCurve @customCurve = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).customCurve = @customCurve;
            return ptr_of_this_method;
        }

        static object get_OnAnimationComplete_6(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).OnAnimationComplete;
        }

        static StackObject* CopyToStack_OnAnimationComplete_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).OnAnimationComplete;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnAnimationComplete_6(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).OnAnimationComplete = (System.Action)v;
        }

        static StackObject* AssignFromStack_OnAnimationComplete_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @OnAnimationComplete = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator)o).OnAnimationComplete = @OnAnimationComplete;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.UIFramework.Runtime.AnimationEffects.UIAnimator();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
