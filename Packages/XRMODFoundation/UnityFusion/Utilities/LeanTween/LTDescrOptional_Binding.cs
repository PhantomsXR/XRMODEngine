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
    unsafe class LTDescrOptional_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::LTDescrOptional);
            args = new Type[]{};
            method = type.GetMethod("get_toTrans", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_toTrans_0);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_toTrans", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_toTrans_1);
            args = new Type[]{};
            method = type.GetMethod("get_point", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_point_2);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_point", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_point_3);
            args = new Type[]{};
            method = type.GetMethod("get_axis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_axis_4);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_axis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_axis_5);
            args = new Type[]{};
            method = type.GetMethod("get_lastVal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lastVal_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_lastVal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lastVal_7);
            args = new Type[]{};
            method = type.GetMethod("get_origRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_origRotation_8);
            args = new Type[]{typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("set_origRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_origRotation_9);
            args = new Type[]{};
            method = type.GetMethod("get_path", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_path_10);
            args = new Type[]{typeof(global::LTBezierPath)};
            method = type.GetMethod("set_path", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_path_11);
            args = new Type[]{};
            method = type.GetMethod("get_spline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_spline_12);
            args = new Type[]{typeof(global::LTSpline)};
            method = type.GetMethod("set_spline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_spline_13);
            args = new Type[]{};
            method = type.GetMethod("get_ltRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ltRect_14);
            args = new Type[]{typeof(global::LTRect)};
            method = type.GetMethod("set_ltRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ltRect_15);
            args = new Type[]{};
            method = type.GetMethod("get_onUpdateFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onUpdateFloat_16);
            args = new Type[]{typeof(System.Action<System.Single>)};
            method = type.GetMethod("set_onUpdateFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onUpdateFloat_17);
            args = new Type[]{};
            method = type.GetMethod("get_onUpdateFloatRatio", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onUpdateFloatRatio_18);
            args = new Type[]{typeof(System.Action<System.Single, System.Single>)};
            method = type.GetMethod("set_onUpdateFloatRatio", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onUpdateFloatRatio_19);
            args = new Type[]{};
            method = type.GetMethod("get_onUpdateFloatObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onUpdateFloatObject_20);
            args = new Type[]{typeof(System.Action<System.Single, System.Object>)};
            method = type.GetMethod("set_onUpdateFloatObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onUpdateFloatObject_21);
            args = new Type[]{};
            method = type.GetMethod("get_onUpdateVector2", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onUpdateVector2_22);
            args = new Type[]{typeof(System.Action<UnityEngine.Vector2>)};
            method = type.GetMethod("set_onUpdateVector2", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onUpdateVector2_23);
            args = new Type[]{};
            method = type.GetMethod("get_onUpdateVector3", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onUpdateVector3_24);
            args = new Type[]{typeof(System.Action<UnityEngine.Vector3>)};
            method = type.GetMethod("set_onUpdateVector3", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onUpdateVector3_25);
            args = new Type[]{};
            method = type.GetMethod("get_onUpdateVector3Object", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onUpdateVector3Object_26);
            args = new Type[]{typeof(System.Action<UnityEngine.Vector3, System.Object>)};
            method = type.GetMethod("set_onUpdateVector3Object", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onUpdateVector3Object_27);
            args = new Type[]{};
            method = type.GetMethod("get_onUpdateColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onUpdateColor_28);
            args = new Type[]{typeof(System.Action<UnityEngine.Color>)};
            method = type.GetMethod("set_onUpdateColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onUpdateColor_29);
            args = new Type[]{};
            method = type.GetMethod("get_onUpdateColorObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onUpdateColorObject_30);
            args = new Type[]{typeof(System.Action<UnityEngine.Color, System.Object>)};
            method = type.GetMethod("set_onUpdateColorObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onUpdateColorObject_31);
            args = new Type[]{};
            method = type.GetMethod("get_onComplete", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onComplete_32);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("set_onComplete", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onComplete_33);
            args = new Type[]{};
            method = type.GetMethod("get_onCompleteObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onCompleteObject_34);
            args = new Type[]{typeof(System.Action<System.Object>)};
            method = type.GetMethod("set_onCompleteObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onCompleteObject_35);
            args = new Type[]{};
            method = type.GetMethod("get_onCompleteParam", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onCompleteParam_36);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("set_onCompleteParam", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onCompleteParam_37);
            args = new Type[]{};
            method = type.GetMethod("get_onUpdateParam", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onUpdateParam_38);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("set_onUpdateParam", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onUpdateParam_39);
            args = new Type[]{};
            method = type.GetMethod("get_onStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onStart_40);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("set_onStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onStart_41);
            args = new Type[]{};
            method = type.GetMethod("reset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, reset_42);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("callOnUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, callOnUpdate_43);

            field = type.GetField("animationCurve", flag);
            app.RegisterCLRFieldGetter(field, get_animationCurve_0);
            app.RegisterCLRFieldSetter(field, set_animationCurve_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_animationCurve_0, AssignFromStack_animationCurve_0);
            field = type.GetField("initFrameCount", flag);
            app.RegisterCLRFieldGetter(field, get_initFrameCount_1);
            app.RegisterCLRFieldSetter(field, set_initFrameCount_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_initFrameCount_1, AssignFromStack_initFrameCount_1);
            field = type.GetField("color", flag);
            app.RegisterCLRFieldGetter(field, get_color_2);
            app.RegisterCLRFieldSetter(field, set_color_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_color_2, AssignFromStack_color_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new global::LTDescrOptional());
            app.RegisterCLRCreateArrayInstance(type, s => new global::LTDescrOptional[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_toTrans_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.toTrans;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_toTrans_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.toTrans = value;

            return __ret;
        }

        static StackObject* get_point_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.point;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_point_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.point = value;

            return __ret;
        }

        static StackObject* get_axis_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.axis;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_axis_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.axis = value;

            return __ret;
        }

        static StackObject* get_lastVal_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lastVal;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_lastVal_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lastVal = value;

            return __ret;
        }

        static StackObject* get_origRotation_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.origRotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_origRotation_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @value = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.origRotation = value;

            return __ret;
        }

        static StackObject* get_path_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.path;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_path_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTBezierPath @value = (global::LTBezierPath)typeof(global::LTBezierPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.path = value;

            return __ret;
        }

        static StackObject* get_spline_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.spline;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_spline_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTSpline @value = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.spline = value;

            return __ret;
        }

        static StackObject* get_ltRect_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ltRect;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_ltRect_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTRect @value = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ltRect = value;

            return __ret;
        }

        static StackObject* get_onUpdateFloat_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onUpdateFloat;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onUpdateFloat_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Single> @value = (System.Action<System.Single>)typeof(System.Action<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onUpdateFloat = value;

            return __ret;
        }

        static StackObject* get_onUpdateFloatRatio_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onUpdateFloatRatio;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onUpdateFloatRatio_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Single, System.Single> @value = (System.Action<System.Single, System.Single>)typeof(System.Action<System.Single, System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onUpdateFloatRatio = value;

            return __ret;
        }

        static StackObject* get_onUpdateFloatObject_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onUpdateFloatObject;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onUpdateFloatObject_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Single, System.Object> @value = (System.Action<System.Single, System.Object>)typeof(System.Action<System.Single, System.Object>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onUpdateFloatObject = value;

            return __ret;
        }

        static StackObject* get_onUpdateVector2_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onUpdateVector2;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onUpdateVector2_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Vector2> @value = (System.Action<UnityEngine.Vector2>)typeof(System.Action<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onUpdateVector2 = value;

            return __ret;
        }

        static StackObject* get_onUpdateVector3_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onUpdateVector3;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onUpdateVector3_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Vector3> @value = (System.Action<UnityEngine.Vector3>)typeof(System.Action<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onUpdateVector3 = value;

            return __ret;
        }

        static StackObject* get_onUpdateVector3Object_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onUpdateVector3Object;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onUpdateVector3Object_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Vector3, System.Object> @value = (System.Action<UnityEngine.Vector3, System.Object>)typeof(System.Action<UnityEngine.Vector3, System.Object>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onUpdateVector3Object = value;

            return __ret;
        }

        static StackObject* get_onUpdateColor_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onUpdateColor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onUpdateColor_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Color> @value = (System.Action<UnityEngine.Color>)typeof(System.Action<UnityEngine.Color>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onUpdateColor = value;

            return __ret;
        }

        static StackObject* get_onUpdateColorObject_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onUpdateColorObject;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onUpdateColorObject_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Color, System.Object> @value = (System.Action<UnityEngine.Color, System.Object>)typeof(System.Action<UnityEngine.Color, System.Object>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onUpdateColorObject = value;

            return __ret;
        }

        static StackObject* get_onComplete_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onComplete;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onComplete_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onComplete = value;

            return __ret;
        }

        static StackObject* get_onCompleteObject_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onCompleteObject;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onCompleteObject_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Object> @value = (System.Action<System.Object>)typeof(System.Action<System.Object>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onCompleteObject = value;

            return __ret;
        }

        static StackObject* get_onCompleteParam_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onCompleteParam;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance, true);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method, true);
        }

        static StackObject* set_onCompleteParam_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @value = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onCompleteParam = value;

            return __ret;
        }

        static StackObject* get_onUpdateParam_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onUpdateParam;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance, true);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method, true);
        }

        static StackObject* set_onUpdateParam_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @value = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onUpdateParam = value;

            return __ret;
        }

        static StackObject* get_onStart_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onStart;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onStart_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onStart = value;

            return __ret;
        }

        static StackObject* reset_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reset();

            return __ret;
        }

        static StackObject* callOnUpdate_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @ratioPassed = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @val = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            global::LTDescrOptional instance_of_this_method = (global::LTDescrOptional)typeof(global::LTDescrOptional).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.callOnUpdate(@val, @ratioPassed);

            return __ret;
        }


        static object get_animationCurve_0(ref object o)
        {
            return ((global::LTDescrOptional)o).animationCurve;
        }

        static StackObject* CopyToStack_animationCurve_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTDescrOptional)o).animationCurve;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_animationCurve_0(ref object o, object v)
        {
            ((global::LTDescrOptional)o).animationCurve = (UnityEngine.AnimationCurve)v;
        }

        static StackObject* AssignFromStack_animationCurve_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.AnimationCurve @animationCurve = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::LTDescrOptional)o).animationCurve = @animationCurve;
            return ptr_of_this_method;
        }

        static object get_initFrameCount_1(ref object o)
        {
            return ((global::LTDescrOptional)o).initFrameCount;
        }

        static StackObject* CopyToStack_initFrameCount_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTDescrOptional)o).initFrameCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_initFrameCount_1(ref object o, object v)
        {
            ((global::LTDescrOptional)o).initFrameCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_initFrameCount_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @initFrameCount = ptr_of_this_method->Value;
            ((global::LTDescrOptional)o).initFrameCount = @initFrameCount;
            return ptr_of_this_method;
        }

        static object get_color_2(ref object o)
        {
            return ((global::LTDescrOptional)o).color;
        }

        static StackObject* CopyToStack_color_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTDescrOptional)o).color;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_color_2(ref object o, object v)
        {
            ((global::LTDescrOptional)o).color = (UnityEngine.Color)v;
        }

        static StackObject* AssignFromStack_color_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((global::LTDescrOptional)o).color = @color;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new global::LTDescrOptional();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
