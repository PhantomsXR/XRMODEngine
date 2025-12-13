#if USE_TIMELINE
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
    unsafe class UnityEngine_Timeline_TimelineClip_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Timeline.TimelineClip);
            args = new Type[]{};
            method = type.GetMethod("get_hasPreExtrapolation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasPreExtrapolation_0);
            args = new Type[]{};
            method = type.GetMethod("get_hasPostExtrapolation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasPostExtrapolation_1);
            args = new Type[]{};
            method = type.GetMethod("get_timeScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_timeScale_2);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("set_timeScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_timeScale_3);
            args = new Type[]{};
            method = type.GetMethod("get_start", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_start_4);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("set_start", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_start_5);
            args = new Type[]{};
            method = type.GetMethod("get_duration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_duration_6);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("set_duration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_duration_7);
            args = new Type[]{};
            method = type.GetMethod("get_end", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_end_8);
            args = new Type[]{};
            method = type.GetMethod("get_clipIn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_clipIn_9);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("set_clipIn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_clipIn_10);
            args = new Type[]{};
            method = type.GetMethod("get_displayName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_displayName_11);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_displayName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_displayName_12);
            args = new Type[]{};
            method = type.GetMethod("get_clipAssetDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_clipAssetDuration_13);
            args = new Type[]{};
            method = type.GetMethod("get_curves", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_curves_14);
            args = new Type[]{};
            method = type.GetMethod("get_hasCurves", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasCurves_15);
            args = new Type[]{};
            method = type.GetMethod("get_asset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_asset_16);
            args = new Type[]{typeof(UnityEngine.Object)};
            method = type.GetMethod("set_asset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_asset_17);
            args = new Type[]{};
            method = type.GetMethod("GetParentTrack", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetParentTrack_18);
            args = new Type[]{};
            method = type.GetMethod("get_easeInDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_easeInDuration_19);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("set_easeInDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_easeInDuration_20);
            args = new Type[]{};
            method = type.GetMethod("get_easeOutDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_easeOutDuration_21);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("set_easeOutDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_easeOutDuration_22);
            args = new Type[]{};
            method = type.GetMethod("get_easeOutTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_easeOutTime_23);
            args = new Type[]{};
            method = type.GetMethod("get_blendInDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_blendInDuration_24);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("set_blendInDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_blendInDuration_25);
            args = new Type[]{};
            method = type.GetMethod("get_blendOutDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_blendOutDuration_26);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("set_blendOutDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_blendOutDuration_27);
            args = new Type[]{};
            method = type.GetMethod("get_blendInCurveMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_blendInCurveMode_28);
            args = new Type[]{typeof(UnityEngine.Timeline.TimelineClip.BlendCurveMode)};
            method = type.GetMethod("set_blendInCurveMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_blendInCurveMode_29);
            args = new Type[]{};
            method = type.GetMethod("get_blendOutCurveMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_blendOutCurveMode_30);
            args = new Type[]{typeof(UnityEngine.Timeline.TimelineClip.BlendCurveMode)};
            method = type.GetMethod("set_blendOutCurveMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_blendOutCurveMode_31);
            args = new Type[]{};
            method = type.GetMethod("get_hasBlendIn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasBlendIn_32);
            args = new Type[]{};
            method = type.GetMethod("get_hasBlendOut", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasBlendOut_33);
            args = new Type[]{};
            method = type.GetMethod("get_mixInCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mixInCurve_34);
            args = new Type[]{typeof(UnityEngine.AnimationCurve)};
            method = type.GetMethod("set_mixInCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_mixInCurve_35);
            args = new Type[]{};
            method = type.GetMethod("get_mixInPercentage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mixInPercentage_36);
            args = new Type[]{};
            method = type.GetMethod("get_mixInDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mixInDuration_37);
            args = new Type[]{};
            method = type.GetMethod("get_mixOutCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mixOutCurve_38);
            args = new Type[]{typeof(UnityEngine.AnimationCurve)};
            method = type.GetMethod("set_mixOutCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_mixOutCurve_39);
            args = new Type[]{};
            method = type.GetMethod("get_mixOutTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mixOutTime_40);
            args = new Type[]{};
            method = type.GetMethod("get_mixOutDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mixOutDuration_41);
            args = new Type[]{};
            method = type.GetMethod("get_mixOutPercentage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mixOutPercentage_42);
            args = new Type[]{};
            method = type.GetMethod("get_recordable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_recordable_43);
            args = new Type[]{};
            method = type.GetMethod("get_clipCaps", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_clipCaps_44);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("EvaluateMixOut", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EvaluateMixOut_45);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("EvaluateMixIn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EvaluateMixIn_46);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("ToLocalTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToLocalTime_47);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("ToLocalTimeUnbound", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToLocalTimeUnbound_48);
            args = new Type[]{};
            method = type.GetMethod("get_animationClip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_animationClip_49);
            args = new Type[]{};
            method = type.GetMethod("get_postExtrapolationMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_postExtrapolationMode_50);
            args = new Type[]{};
            method = type.GetMethod("get_preExtrapolationMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_preExtrapolationMode_51);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("IsExtrapolatedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsExtrapolatedTime_52);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("IsPreExtrapolatedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsPreExtrapolatedTime_53);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("IsPostExtrapolatedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsPostExtrapolatedTime_54);
            args = new Type[]{};
            method = type.GetMethod("get_extrapolatedStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_extrapolatedStart_55);
            args = new Type[]{};
            method = type.GetMethod("get_extrapolatedDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_extrapolatedDuration_56);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("CreateCurves", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateCurves_57);
            args = new Type[]{};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_58);
            args = new Type[]{};
            method = type.GetMethod("ConformEaseValues", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ConformEaseValues_59);

            field = type.GetField("kDefaultClipCaps", flag);
            app.RegisterCLRFieldGetter(field, get_kDefaultClipCaps_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_kDefaultClipCaps_0, null);
            field = type.GetField("kDefaultClipDurationInSeconds", flag);
            app.RegisterCLRFieldGetter(field, get_kDefaultClipDurationInSeconds_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_kDefaultClipDurationInSeconds_1, null);
            field = type.GetField("kTimeScaleMin", flag);
            app.RegisterCLRFieldGetter(field, get_kTimeScaleMin_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_kTimeScaleMin_2, null);
            field = type.GetField("kTimeScaleMax", flag);
            app.RegisterCLRFieldGetter(field, get_kTimeScaleMax_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_kTimeScaleMax_3, null);


            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Timeline.TimelineClip[s]);


        }


        static StackObject* get_hasPreExtrapolation_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasPreExtrapolation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_hasPostExtrapolation_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasPostExtrapolation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_timeScale_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.timeScale;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_timeScale_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @value = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.timeScale = value;

            return __ret;
        }

        static StackObject* get_start_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.start;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_start_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @value = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.start = value;

            return __ret;
        }

        static StackObject* get_duration_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.duration;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_duration_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @value = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.duration = value;

            return __ret;
        }

        static StackObject* get_end_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.end;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_clipIn_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.clipIn;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_clipIn_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @value = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.clipIn = value;

            return __ret;
        }

        static StackObject* get_displayName_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.displayName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_displayName_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.displayName = value;

            return __ret;
        }

        static StackObject* get_clipAssetDuration_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.clipAssetDuration;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_curves_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.curves;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_hasCurves_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasCurves;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_asset_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.asset;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_asset_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Object @value = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.asset = value;

            return __ret;
        }

        static StackObject* GetParentTrack_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetParentTrack();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_easeInDuration_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.easeInDuration;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_easeInDuration_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @value = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.easeInDuration = value;

            return __ret;
        }

        static StackObject* get_easeOutDuration_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.easeOutDuration;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_easeOutDuration_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @value = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.easeOutDuration = value;

            return __ret;
        }

        static StackObject* get_easeOutTime_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.easeOutTime;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_blendInDuration_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.blendInDuration;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_blendInDuration_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @value = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.blendInDuration = value;

            return __ret;
        }

        static StackObject* get_blendOutDuration_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.blendOutDuration;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_blendOutDuration_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @value = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.blendOutDuration = value;

            return __ret;
        }

        static StackObject* get_blendInCurveMode_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.blendInCurveMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_blendInCurveMode_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip.BlendCurveMode @value = (UnityEngine.Timeline.TimelineClip.BlendCurveMode)typeof(UnityEngine.Timeline.TimelineClip.BlendCurveMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.blendInCurveMode = value;

            return __ret;
        }

        static StackObject* get_blendOutCurveMode_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.blendOutCurveMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_blendOutCurveMode_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip.BlendCurveMode @value = (UnityEngine.Timeline.TimelineClip.BlendCurveMode)typeof(UnityEngine.Timeline.TimelineClip.BlendCurveMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.blendOutCurveMode = value;

            return __ret;
        }

        static StackObject* get_hasBlendIn_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasBlendIn;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_hasBlendOut_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasBlendOut;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_mixInCurve_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mixInCurve;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_mixInCurve_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationCurve @value = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.mixInCurve = value;

            return __ret;
        }

        static StackObject* get_mixInPercentage_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mixInPercentage;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_mixInDuration_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mixInDuration;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_mixOutCurve_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mixOutCurve;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_mixOutCurve_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationCurve @value = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.mixOutCurve = value;

            return __ret;
        }

        static StackObject* get_mixOutTime_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mixOutTime;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_mixOutDuration_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mixOutDuration;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_mixOutPercentage_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mixOutPercentage;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_recordable_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.recordable;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_clipCaps_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.clipCaps;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* EvaluateMixOut_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @time = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.EvaluateMixOut(@time);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* EvaluateMixIn_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @time = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.EvaluateMixIn(@time);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ToLocalTime_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @time = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToLocalTime(@time);

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ToLocalTimeUnbound_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @time = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToLocalTimeUnbound(@time);

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_animationClip_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.animationClip;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_postExtrapolationMode_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.postExtrapolationMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_preExtrapolationMode_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.preExtrapolationMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsExtrapolatedTime_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @sequenceTime = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsExtrapolatedTime(@sequenceTime);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsPreExtrapolatedTime_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @sequenceTime = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsPreExtrapolatedTime(@sequenceTime);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsPostExtrapolatedTime_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @sequenceTime = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsPostExtrapolatedTime(@sequenceTime);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_extrapolatedStart_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.extrapolatedStart;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_extrapolatedDuration_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.extrapolatedDuration;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CreateCurves_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @curvesClipName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CreateCurves(@curvesClipName);

            return __ret;
        }

        static StackObject* ToString_58(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToString();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ConformEaseValues_59(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.TimelineClip instance_of_this_method = (UnityEngine.Timeline.TimelineClip)typeof(UnityEngine.Timeline.TimelineClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ConformEaseValues();

            return __ret;
        }


        static object get_kDefaultClipCaps_0(ref object o)
        {
            return UnityEngine.Timeline.TimelineClip.kDefaultClipCaps;
        }

        static StackObject* CopyToStack_kDefaultClipCaps_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.TimelineClip.kDefaultClipCaps;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_kDefaultClipDurationInSeconds_1(ref object o)
        {
            return UnityEngine.Timeline.TimelineClip.kDefaultClipDurationInSeconds;
        }

        static StackObject* CopyToStack_kDefaultClipDurationInSeconds_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.TimelineClip.kDefaultClipDurationInSeconds;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_kTimeScaleMin_2(ref object o)
        {
            return UnityEngine.Timeline.TimelineClip.kTimeScaleMin;
        }

        static StackObject* CopyToStack_kTimeScaleMin_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.TimelineClip.kTimeScaleMin;
            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_kTimeScaleMax_3(ref object o)
        {
            return UnityEngine.Timeline.TimelineClip.kTimeScaleMax;
        }

        static StackObject* CopyToStack_kTimeScaleMax_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.TimelineClip.kTimeScaleMax;
            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }




    }
}
#endif