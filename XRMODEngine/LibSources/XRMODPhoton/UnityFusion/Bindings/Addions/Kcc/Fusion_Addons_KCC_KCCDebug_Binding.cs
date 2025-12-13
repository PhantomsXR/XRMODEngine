#if FUSION2 && XRMOD_INSTALL

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
    unsafe class Fusion_Addons_KCC_KCCDebug_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCDebug);
            args = new Type[]{};
            method = type.GetMethod("SetDefaults", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDefaults_0);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCC)};
            method = type.GetMethod("BeforePredictedFixedMove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeforePredictedFixedMove_1);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCC)};
            method = type.GetMethod("AfterPredictedFixedMove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AfterPredictedFixedMove_2);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCC)};
            method = type.GetMethod("AfterRenderUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AfterRenderUpdate_3);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Boolean)};
            method = type.GetMethod("DrawGroundSnapping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawGroundSnapping_4);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCC), typeof(System.Type), typeof(System.Int32)};
            method = type.GetMethod("TraceStage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TraceStage_5);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCC), typeof(System.Type), typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("TraceStage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TraceStage_6);
            args = new Type[]{typeof(Fusion.Addons.KCC.IKCCProcessor), typeof(System.Int32)};
            method = type.GetMethod("TraceProcessor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TraceProcessor_7);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCC)};
            method = type.GetMethod("Dump", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Dump_8);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCC), typeof(System.Single)};
            method = type.GetMethod("EnableLogs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EnableLogs_9);

            field = type.GetField("LogsTime", flag);
            app.RegisterCLRFieldGetter(field, get_LogsTime_0);
            app.RegisterCLRFieldSetter(field, set_LogsTime_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_LogsTime_0, AssignFromStack_LogsTime_0);
            field = type.GetField("ShowPath", flag);
            app.RegisterCLRFieldGetter(field, get_ShowPath_1);
            app.RegisterCLRFieldSetter(field, set_ShowPath_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ShowPath_1, AssignFromStack_ShowPath_1);
            field = type.GetField("ShowSpeed", flag);
            app.RegisterCLRFieldGetter(field, get_ShowSpeed_2);
            app.RegisterCLRFieldSetter(field, set_ShowSpeed_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_ShowSpeed_2, AssignFromStack_ShowSpeed_2);
            field = type.GetField("ShowGrounding", flag);
            app.RegisterCLRFieldGetter(field, get_ShowGrounding_3);
            app.RegisterCLRFieldSetter(field, set_ShowGrounding_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_ShowGrounding_3, AssignFromStack_ShowGrounding_3);
            field = type.GetField("ShowSteppingUp", flag);
            app.RegisterCLRFieldGetter(field, get_ShowSteppingUp_4);
            app.RegisterCLRFieldSetter(field, set_ShowSteppingUp_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_ShowSteppingUp_4, AssignFromStack_ShowSteppingUp_4);
            field = type.GetField("ShowGroundSnapping", flag);
            app.RegisterCLRFieldGetter(field, get_ShowGroundSnapping_5);
            app.RegisterCLRFieldSetter(field, set_ShowGroundSnapping_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_ShowGroundSnapping_5, AssignFromStack_ShowGroundSnapping_5);
            field = type.GetField("ShowGroundNormal", flag);
            app.RegisterCLRFieldGetter(field, get_ShowGroundNormal_6);
            app.RegisterCLRFieldSetter(field, set_ShowGroundNormal_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_ShowGroundNormal_6, AssignFromStack_ShowGroundNormal_6);
            field = type.GetField("ShowGroundTangent", flag);
            app.RegisterCLRFieldGetter(field, get_ShowGroundTangent_7);
            app.RegisterCLRFieldSetter(field, set_ShowGroundTangent_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_ShowGroundTangent_7, AssignFromStack_ShowGroundTangent_7);
            field = type.GetField("ShowMoveDirection", flag);
            app.RegisterCLRFieldGetter(field, get_ShowMoveDirection_8);
            app.RegisterCLRFieldSetter(field, set_ShowMoveDirection_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_ShowMoveDirection_8, AssignFromStack_ShowMoveDirection_8);
            field = type.GetField("TraceExecution", flag);
            app.RegisterCLRFieldGetter(field, get_TraceExecution_9);
            app.RegisterCLRFieldSetter(field, set_TraceExecution_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_TraceExecution_9, AssignFromStack_TraceExecution_9);
            field = type.GetField("TraceInfoCount", flag);
            app.RegisterCLRFieldGetter(field, get_TraceInfoCount_10);
            app.RegisterCLRFieldSetter(field, set_TraceInfoCount_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_TraceInfoCount_10, AssignFromStack_TraceInfoCount_10);
            field = type.GetField("TraceInfos", flag);
            app.RegisterCLRFieldGetter(field, get_TraceInfos_11);
            app.RegisterCLRFieldSetter(field, set_TraceInfos_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_TraceInfos_11, AssignFromStack_TraceInfos_11);
            field = type.GetField("DisplayTime", flag);
            app.RegisterCLRFieldGetter(field, get_DisplayTime_12);
            app.RegisterCLRFieldSetter(field, set_DisplayTime_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_DisplayTime_12, AssignFromStack_DisplayTime_12);
            field = type.GetField("SpeedScale", flag);
            app.RegisterCLRFieldGetter(field, get_SpeedScale_13);
            app.RegisterCLRFieldSetter(field, set_SpeedScale_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_SpeedScale_13, AssignFromStack_SpeedScale_13);
            field = type.GetField("PointSize", flag);
            app.RegisterCLRFieldGetter(field, get_PointSize_14);
            app.RegisterCLRFieldSetter(field, set_PointSize_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_PointSize_14, AssignFromStack_PointSize_14);
            field = type.GetField("FixedPathColor", flag);
            app.RegisterCLRFieldGetter(field, get_FixedPathColor_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_FixedPathColor_15, null);
            field = type.GetField("RenderPathColor", flag);
            app.RegisterCLRFieldGetter(field, get_RenderPathColor_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_RenderPathColor_16, null);
            field = type.GetField("FixedToRenderPathColor", flag);
            app.RegisterCLRFieldGetter(field, get_FixedToRenderPathColor_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_FixedToRenderPathColor_17, null);
            field = type.GetField("PredictionCorrectionColor", flag);
            app.RegisterCLRFieldGetter(field, get_PredictionCorrectionColor_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_PredictionCorrectionColor_18, null);
            field = type.GetField("PredictionErrorColor", flag);
            app.RegisterCLRFieldGetter(field, get_PredictionErrorColor_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_PredictionErrorColor_19, null);
            field = type.GetField("IsGroundedColor", flag);
            app.RegisterCLRFieldGetter(field, get_IsGroundedColor_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsGroundedColor_20, null);
            field = type.GetField("WasGroundedColor", flag);
            app.RegisterCLRFieldGetter(field, get_WasGroundedColor_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_WasGroundedColor_21, null);
            field = type.GetField("SpeedColor", flag);
            app.RegisterCLRFieldGetter(field, get_SpeedColor_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_SpeedColor_22, null);
            field = type.GetField("IsSteppingUpColor", flag);
            app.RegisterCLRFieldGetter(field, get_IsSteppingUpColor_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsSteppingUpColor_23, null);
            field = type.GetField("WasSteppingUpColor", flag);
            app.RegisterCLRFieldGetter(field, get_WasSteppingUpColor_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_WasSteppingUpColor_24, null);
            field = type.GetField("GroundNormalColor", flag);
            app.RegisterCLRFieldGetter(field, get_GroundNormalColor_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_GroundNormalColor_25, null);
            field = type.GetField("GroundTangentColor", flag);
            app.RegisterCLRFieldGetter(field, get_GroundTangentColor_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_GroundTangentColor_26, null);
            field = type.GetField("GroundSnapingColor", flag);
            app.RegisterCLRFieldGetter(field, get_GroundSnapingColor_27);
            app.RegisterCLRFieldBinding(field, CopyToStack_GroundSnapingColor_27, null);
            field = type.GetField("GroundSnapTargetColor", flag);
            app.RegisterCLRFieldGetter(field, get_GroundSnapTargetColor_28);
            app.RegisterCLRFieldBinding(field, CopyToStack_GroundSnapTargetColor_28, null);
            field = type.GetField("GroundSnapPositionColor", flag);
            app.RegisterCLRFieldGetter(field, get_GroundSnapPositionColor_29);
            app.RegisterCLRFieldBinding(field, CopyToStack_GroundSnapPositionColor_29, null);
            field = type.GetField("MoveDirectionColor", flag);
            app.RegisterCLRFieldGetter(field, get_MoveDirectionColor_30);
            app.RegisterCLRFieldBinding(field, CopyToStack_MoveDirectionColor_30, null);
            field = type.GetField("_stringBuilder", flag);
            app.RegisterCLRFieldGetter(field, get__stringBuilder_31);
            app.RegisterCLRFieldSetter(field, set__stringBuilder_31);
            app.RegisterCLRFieldBinding(field, CopyToStack__stringBuilder_31, AssignFromStack__stringBuilder_31);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCDebug());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCDebug[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* SetDefaults_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCDebug instance_of_this_method = (Fusion.Addons.KCC.KCCDebug)typeof(Fusion.Addons.KCC.KCCDebug).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDefaults();

            return __ret;
        }

        static StackObject* BeforePredictedFixedMove_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCDebug instance_of_this_method = (Fusion.Addons.KCC.KCCDebug)typeof(Fusion.Addons.KCC.KCCDebug).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.BeforePredictedFixedMove(@kcc);

            return __ret;
        }

        static StackObject* AfterPredictedFixedMove_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCDebug instance_of_this_method = (Fusion.Addons.KCC.KCCDebug)typeof(Fusion.Addons.KCC.KCCDebug).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AfterPredictedFixedMove(@kcc);

            return __ret;
        }

        static StackObject* AfterRenderUpdate_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCDebug instance_of_this_method = (Fusion.Addons.KCC.KCCDebug)typeof(Fusion.Addons.KCC.KCCDebug).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AfterRenderUpdate(@kcc);

            return __ret;
        }

        static StackObject* DrawGroundSnapping_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @isInFixedUpdate = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @targetSnappedPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @targetGroundedPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector3 @targetPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Fusion.Addons.KCC.KCCDebug instance_of_this_method = (Fusion.Addons.KCC.KCCDebug)typeof(Fusion.Addons.KCC.KCCDebug).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawGroundSnapping(@targetPosition, @targetGroundedPosition, @targetSnappedPosition, @isInFixedUpdate);

            return __ret;
        }

        static StackObject* TraceStage_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @level = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Addons.KCC.KCCDebug instance_of_this_method = (Fusion.Addons.KCC.KCCDebug)typeof(Fusion.Addons.KCC.KCCDebug).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TraceStage(@kcc, @type, @level);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TraceStage_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @level = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Fusion.Addons.KCC.KCCDebug instance_of_this_method = (Fusion.Addons.KCC.KCCDebug)typeof(Fusion.Addons.KCC.KCCDebug).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TraceStage(@kcc, @type, @name, @level);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TraceProcessor_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @level = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.IKCCProcessor @processor = (Fusion.Addons.KCC.IKCCProcessor)typeof(Fusion.Addons.KCC.IKCCProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.KCCDebug instance_of_this_method = (Fusion.Addons.KCC.KCCDebug)typeof(Fusion.Addons.KCC.KCCDebug).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TraceProcessor(@processor, @level);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Dump_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCDebug instance_of_this_method = (Fusion.Addons.KCC.KCCDebug)typeof(Fusion.Addons.KCC.KCCDebug).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Dump(@kcc);

            return __ret;
        }

        static StackObject* EnableLogs_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @duration = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.KCCDebug instance_of_this_method = (Fusion.Addons.KCC.KCCDebug)typeof(Fusion.Addons.KCC.KCCDebug).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.EnableLogs(@kcc, @duration);

            return __ret;
        }


        static object get_LogsTime_0(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).LogsTime;
        }

        static StackObject* CopyToStack_LogsTime_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).LogsTime;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_LogsTime_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).LogsTime = (System.Single)v;
        }

        static StackObject* AssignFromStack_LogsTime_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @LogsTime = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCDebug)o).LogsTime = @LogsTime;
            return ptr_of_this_method;
        }

        static object get_ShowPath_1(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).ShowPath;
        }

        static StackObject* CopyToStack_ShowPath_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).ShowPath;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ShowPath_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).ShowPath = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ShowPath_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ShowPath = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCDebug)o).ShowPath = @ShowPath;
            return ptr_of_this_method;
        }

        static object get_ShowSpeed_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).ShowSpeed;
        }

        static StackObject* CopyToStack_ShowSpeed_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).ShowSpeed;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ShowSpeed_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).ShowSpeed = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ShowSpeed_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ShowSpeed = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCDebug)o).ShowSpeed = @ShowSpeed;
            return ptr_of_this_method;
        }

        static object get_ShowGrounding_3(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).ShowGrounding;
        }

        static StackObject* CopyToStack_ShowGrounding_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).ShowGrounding;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ShowGrounding_3(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).ShowGrounding = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ShowGrounding_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ShowGrounding = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCDebug)o).ShowGrounding = @ShowGrounding;
            return ptr_of_this_method;
        }

        static object get_ShowSteppingUp_4(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).ShowSteppingUp;
        }

        static StackObject* CopyToStack_ShowSteppingUp_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).ShowSteppingUp;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ShowSteppingUp_4(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).ShowSteppingUp = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ShowSteppingUp_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ShowSteppingUp = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCDebug)o).ShowSteppingUp = @ShowSteppingUp;
            return ptr_of_this_method;
        }

        static object get_ShowGroundSnapping_5(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).ShowGroundSnapping;
        }

        static StackObject* CopyToStack_ShowGroundSnapping_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).ShowGroundSnapping;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ShowGroundSnapping_5(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).ShowGroundSnapping = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ShowGroundSnapping_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ShowGroundSnapping = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCDebug)o).ShowGroundSnapping = @ShowGroundSnapping;
            return ptr_of_this_method;
        }

        static object get_ShowGroundNormal_6(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).ShowGroundNormal;
        }

        static StackObject* CopyToStack_ShowGroundNormal_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).ShowGroundNormal;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ShowGroundNormal_6(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).ShowGroundNormal = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ShowGroundNormal_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ShowGroundNormal = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCDebug)o).ShowGroundNormal = @ShowGroundNormal;
            return ptr_of_this_method;
        }

        static object get_ShowGroundTangent_7(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).ShowGroundTangent;
        }

        static StackObject* CopyToStack_ShowGroundTangent_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).ShowGroundTangent;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ShowGroundTangent_7(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).ShowGroundTangent = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ShowGroundTangent_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ShowGroundTangent = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCDebug)o).ShowGroundTangent = @ShowGroundTangent;
            return ptr_of_this_method;
        }

        static object get_ShowMoveDirection_8(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).ShowMoveDirection;
        }

        static StackObject* CopyToStack_ShowMoveDirection_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).ShowMoveDirection;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ShowMoveDirection_8(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).ShowMoveDirection = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ShowMoveDirection_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ShowMoveDirection = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCDebug)o).ShowMoveDirection = @ShowMoveDirection;
            return ptr_of_this_method;
        }

        static object get_TraceExecution_9(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).TraceExecution;
        }

        static StackObject* CopyToStack_TraceExecution_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).TraceExecution;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_TraceExecution_9(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).TraceExecution = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_TraceExecution_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @TraceExecution = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCDebug)o).TraceExecution = @TraceExecution;
            return ptr_of_this_method;
        }

        static object get_TraceInfoCount_10(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).TraceInfoCount;
        }

        static StackObject* CopyToStack_TraceInfoCount_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).TraceInfoCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_TraceInfoCount_10(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).TraceInfoCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_TraceInfoCount_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @TraceInfoCount = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCDebug)o).TraceInfoCount = @TraceInfoCount;
            return ptr_of_this_method;
        }

        static object get_TraceInfos_11(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).TraceInfos;
        }

        static StackObject* CopyToStack_TraceInfos_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).TraceInfos;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TraceInfos_11(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).TraceInfos = (Fusion.Addons.KCC.KCCTraceInfo[])v;
        }

        static StackObject* AssignFromStack_TraceInfos_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.KCCTraceInfo[] @TraceInfos = (Fusion.Addons.KCC.KCCTraceInfo[])typeof(Fusion.Addons.KCC.KCCTraceInfo[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCDebug)o).TraceInfos = @TraceInfos;
            return ptr_of_this_method;
        }

        static object get_DisplayTime_12(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).DisplayTime;
        }

        static StackObject* CopyToStack_DisplayTime_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).DisplayTime;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_DisplayTime_12(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).DisplayTime = (System.Single)v;
        }

        static StackObject* AssignFromStack_DisplayTime_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @DisplayTime = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCDebug)o).DisplayTime = @DisplayTime;
            return ptr_of_this_method;
        }

        static object get_SpeedScale_13(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).SpeedScale;
        }

        static StackObject* CopyToStack_SpeedScale_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).SpeedScale;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_SpeedScale_13(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).SpeedScale = (System.Single)v;
        }

        static StackObject* AssignFromStack_SpeedScale_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @SpeedScale = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCDebug)o).SpeedScale = @SpeedScale;
            return ptr_of_this_method;
        }

        static object get_PointSize_14(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o).PointSize;
        }

        static StackObject* CopyToStack_PointSize_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o).PointSize;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_PointSize_14(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o).PointSize = (System.Single)v;
        }

        static StackObject* AssignFromStack_PointSize_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @PointSize = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCDebug)o).PointSize = @PointSize;
            return ptr_of_this_method;
        }

        static object get_FixedPathColor_15(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.FixedPathColor;
        }

        static StackObject* CopyToStack_FixedPathColor_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.FixedPathColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RenderPathColor_16(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.RenderPathColor;
        }

        static StackObject* CopyToStack_RenderPathColor_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.RenderPathColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_FixedToRenderPathColor_17(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.FixedToRenderPathColor;
        }

        static StackObject* CopyToStack_FixedToRenderPathColor_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.FixedToRenderPathColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_PredictionCorrectionColor_18(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.PredictionCorrectionColor;
        }

        static StackObject* CopyToStack_PredictionCorrectionColor_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.PredictionCorrectionColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_PredictionErrorColor_19(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.PredictionErrorColor;
        }

        static StackObject* CopyToStack_PredictionErrorColor_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.PredictionErrorColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_IsGroundedColor_20(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.IsGroundedColor;
        }

        static StackObject* CopyToStack_IsGroundedColor_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.IsGroundedColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WasGroundedColor_21(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.WasGroundedColor;
        }

        static StackObject* CopyToStack_WasGroundedColor_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.WasGroundedColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SpeedColor_22(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.SpeedColor;
        }

        static StackObject* CopyToStack_SpeedColor_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.SpeedColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_IsSteppingUpColor_23(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.IsSteppingUpColor;
        }

        static StackObject* CopyToStack_IsSteppingUpColor_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.IsSteppingUpColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WasSteppingUpColor_24(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.WasSteppingUpColor;
        }

        static StackObject* CopyToStack_WasSteppingUpColor_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.WasSteppingUpColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GroundNormalColor_25(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.GroundNormalColor;
        }

        static StackObject* CopyToStack_GroundNormalColor_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.GroundNormalColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GroundTangentColor_26(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.GroundTangentColor;
        }

        static StackObject* CopyToStack_GroundTangentColor_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.GroundTangentColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GroundSnapingColor_27(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.GroundSnapingColor;
        }

        static StackObject* CopyToStack_GroundSnapingColor_27(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.GroundSnapingColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GroundSnapTargetColor_28(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.GroundSnapTargetColor;
        }

        static StackObject* CopyToStack_GroundSnapTargetColor_28(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.GroundSnapTargetColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GroundSnapPositionColor_29(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.GroundSnapPositionColor;
        }

        static StackObject* CopyToStack_GroundSnapPositionColor_29(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.GroundSnapPositionColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MoveDirectionColor_30(ref object o)
        {
            return Fusion.Addons.KCC.KCCDebug.MoveDirectionColor;
        }

        static StackObject* CopyToStack_MoveDirectionColor_30(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCDebug.MoveDirectionColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get__stringBuilder_31(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCDebug)o)._stringBuilder;
        }

        static StackObject* CopyToStack__stringBuilder_31(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCDebug)o)._stringBuilder;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set__stringBuilder_31(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCDebug)o)._stringBuilder = (System.Text.StringBuilder)v;
        }

        static StackObject* AssignFromStack__stringBuilder_31(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Text.StringBuilder @_stringBuilder = (System.Text.StringBuilder)typeof(System.Text.StringBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCDebug)o)._stringBuilder = @_stringBuilder;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCDebug();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif