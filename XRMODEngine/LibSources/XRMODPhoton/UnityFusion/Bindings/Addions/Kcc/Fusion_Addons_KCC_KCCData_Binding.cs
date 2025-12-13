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
    unsafe class Fusion_Addons_KCC_KCCData_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCData);
            args = new Type[]{};
            method = type.GetMethod("get_LookPitch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_LookPitch_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_LookPitch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_LookPitch_1);
            args = new Type[]{};
            method = type.GetMethod("get_LookYaw", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_LookYaw_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_LookYaw", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_LookYaw_3);
            args = new Type[]{};
            method = type.GetMethod("get_LookRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_LookRotation_4);
            args = new Type[]{};
            method = type.GetMethod("get_LookDirection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_LookDirection_5);
            args = new Type[]{};
            method = type.GetMethod("get_TransformRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_TransformRotation_6);
            args = new Type[]{};
            method = type.GetMethod("get_TransformDirection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_TransformDirection_7);
            args = new Type[]{};
            method = type.GetMethod("get_DesiredVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DesiredVelocity_8);
            args = new Type[]{};
            method = type.GetMethod("get_HasJumped", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_HasJumped_9);
            args = new Type[]{};
            method = type.GetMethod("get_IsOnEdge", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsOnEdge_10);
            args = new Type[]{typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("GetLookRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLookRotation_11);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("AddLookRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddLookRotation_12);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("AddLookRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddLookRotation_13);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("AddLookRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddLookRotation_14);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("AddLookRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddLookRotation_15);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetLookRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLookRotation_16);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetLookRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLookRotation_17);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("SetLookRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLookRotation_18);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetLookRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLookRotation_19);
            args = new Type[]{typeof(UnityEngine.Quaternion), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("SetLookRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLookRotation_20);
            args = new Type[]{};
            method = type.GetMethod("ClearTransientProperties", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearTransientProperties_21);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_22);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCCData)};
            method = type.GetMethod("CopyFromOther", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyFromOther_23);

            field = type.GetField("Frame", flag);
            app.RegisterCLRFieldGetter(field, get_Frame_0);
            app.RegisterCLRFieldSetter(field, set_Frame_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Frame_0, AssignFromStack_Frame_0);
            field = type.GetField("Tick", flag);
            app.RegisterCLRFieldGetter(field, get_Tick_1);
            app.RegisterCLRFieldSetter(field, set_Tick_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Tick_1, AssignFromStack_Tick_1);
            field = type.GetField("Alpha", flag);
            app.RegisterCLRFieldGetter(field, get_Alpha_2);
            app.RegisterCLRFieldSetter(field, set_Alpha_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Alpha_2, AssignFromStack_Alpha_2);
            field = type.GetField("Time", flag);
            app.RegisterCLRFieldGetter(field, get_Time_3);
            app.RegisterCLRFieldSetter(field, set_Time_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Time_3, AssignFromStack_Time_3);
            field = type.GetField("DeltaTime", flag);
            app.RegisterCLRFieldGetter(field, get_DeltaTime_4);
            app.RegisterCLRFieldSetter(field, set_DeltaTime_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_DeltaTime_4, AssignFromStack_DeltaTime_4);
            field = type.GetField("UpdateDeltaTime", flag);
            app.RegisterCLRFieldGetter(field, get_UpdateDeltaTime_5);
            app.RegisterCLRFieldSetter(field, set_UpdateDeltaTime_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_UpdateDeltaTime_5, AssignFromStack_UpdateDeltaTime_5);
            field = type.GetField("IsActive", flag);
            app.RegisterCLRFieldGetter(field, get_IsActive_6);
            app.RegisterCLRFieldSetter(field, set_IsActive_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsActive_6, AssignFromStack_IsActive_6);
            field = type.GetField("BasePosition", flag);
            app.RegisterCLRFieldGetter(field, get_BasePosition_7);
            app.RegisterCLRFieldSetter(field, set_BasePosition_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_BasePosition_7, AssignFromStack_BasePosition_7);
            field = type.GetField("DesiredPosition", flag);
            app.RegisterCLRFieldGetter(field, get_DesiredPosition_8);
            app.RegisterCLRFieldSetter(field, set_DesiredPosition_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_DesiredPosition_8, AssignFromStack_DesiredPosition_8);
            field = type.GetField("TargetPosition", flag);
            app.RegisterCLRFieldGetter(field, get_TargetPosition_9);
            app.RegisterCLRFieldSetter(field, set_TargetPosition_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetPosition_9, AssignFromStack_TargetPosition_9);
            field = type.GetField("InputDirection", flag);
            app.RegisterCLRFieldGetter(field, get_InputDirection_10);
            app.RegisterCLRFieldSetter(field, set_InputDirection_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_InputDirection_10, AssignFromStack_InputDirection_10);
            field = type.GetField("JumpImpulse", flag);
            app.RegisterCLRFieldGetter(field, get_JumpImpulse_11);
            app.RegisterCLRFieldSetter(field, set_JumpImpulse_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_JumpImpulse_11, AssignFromStack_JumpImpulse_11);
            field = type.GetField("Gravity", flag);
            app.RegisterCLRFieldGetter(field, get_Gravity_12);
            app.RegisterCLRFieldSetter(field, set_Gravity_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_Gravity_12, AssignFromStack_Gravity_12);
            field = type.GetField("MaxGroundAngle", flag);
            app.RegisterCLRFieldGetter(field, get_MaxGroundAngle_13);
            app.RegisterCLRFieldSetter(field, set_MaxGroundAngle_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxGroundAngle_13, AssignFromStack_MaxGroundAngle_13);
            field = type.GetField("MaxWallAngle", flag);
            app.RegisterCLRFieldGetter(field, get_MaxWallAngle_14);
            app.RegisterCLRFieldSetter(field, set_MaxWallAngle_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxWallAngle_14, AssignFromStack_MaxWallAngle_14);
            field = type.GetField("MaxHangAngle", flag);
            app.RegisterCLRFieldGetter(field, get_MaxHangAngle_15);
            app.RegisterCLRFieldSetter(field, set_MaxHangAngle_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxHangAngle_15, AssignFromStack_MaxHangAngle_15);
            field = type.GetField("MaxPenetrationSteps", flag);
            app.RegisterCLRFieldGetter(field, get_MaxPenetrationSteps_16);
            app.RegisterCLRFieldSetter(field, set_MaxPenetrationSteps_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxPenetrationSteps_16, AssignFromStack_MaxPenetrationSteps_16);
            field = type.GetField("ExternalVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_ExternalVelocity_17);
            app.RegisterCLRFieldSetter(field, set_ExternalVelocity_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_ExternalVelocity_17, AssignFromStack_ExternalVelocity_17);
            field = type.GetField("ExternalAcceleration", flag);
            app.RegisterCLRFieldGetter(field, get_ExternalAcceleration_18);
            app.RegisterCLRFieldSetter(field, set_ExternalAcceleration_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_ExternalAcceleration_18, AssignFromStack_ExternalAcceleration_18);
            field = type.GetField("ExternalImpulse", flag);
            app.RegisterCLRFieldGetter(field, get_ExternalImpulse_19);
            app.RegisterCLRFieldSetter(field, set_ExternalImpulse_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_ExternalImpulse_19, AssignFromStack_ExternalImpulse_19);
            field = type.GetField("ExternalForce", flag);
            app.RegisterCLRFieldGetter(field, get_ExternalForce_20);
            app.RegisterCLRFieldSetter(field, set_ExternalForce_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_ExternalForce_20, AssignFromStack_ExternalForce_20);
            field = type.GetField("ExternalDelta", flag);
            app.RegisterCLRFieldGetter(field, get_ExternalDelta_21);
            app.RegisterCLRFieldSetter(field, set_ExternalDelta_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_ExternalDelta_21, AssignFromStack_ExternalDelta_21);
            field = type.GetField("KinematicSpeed", flag);
            app.RegisterCLRFieldGetter(field, get_KinematicSpeed_22);
            app.RegisterCLRFieldSetter(field, set_KinematicSpeed_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_KinematicSpeed_22, AssignFromStack_KinematicSpeed_22);
            field = type.GetField("KinematicTangent", flag);
            app.RegisterCLRFieldGetter(field, get_KinematicTangent_23);
            app.RegisterCLRFieldSetter(field, set_KinematicTangent_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_KinematicTangent_23, AssignFromStack_KinematicTangent_23);
            field = type.GetField("KinematicDirection", flag);
            app.RegisterCLRFieldGetter(field, get_KinematicDirection_24);
            app.RegisterCLRFieldSetter(field, set_KinematicDirection_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_KinematicDirection_24, AssignFromStack_KinematicDirection_24);
            field = type.GetField("KinematicVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_KinematicVelocity_25);
            app.RegisterCLRFieldSetter(field, set_KinematicVelocity_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_KinematicVelocity_25, AssignFromStack_KinematicVelocity_25);
            field = type.GetField("DynamicVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_DynamicVelocity_26);
            app.RegisterCLRFieldSetter(field, set_DynamicVelocity_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_DynamicVelocity_26, AssignFromStack_DynamicVelocity_26);
            field = type.GetField("RealSpeed", flag);
            app.RegisterCLRFieldGetter(field, get_RealSpeed_27);
            app.RegisterCLRFieldSetter(field, set_RealSpeed_27);
            app.RegisterCLRFieldBinding(field, CopyToStack_RealSpeed_27, AssignFromStack_RealSpeed_27);
            field = type.GetField("RealVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_RealVelocity_28);
            app.RegisterCLRFieldSetter(field, set_RealVelocity_28);
            app.RegisterCLRFieldBinding(field, CopyToStack_RealVelocity_28, AssignFromStack_RealVelocity_28);
            field = type.GetField("JumpFrames", flag);
            app.RegisterCLRFieldGetter(field, get_JumpFrames_29);
            app.RegisterCLRFieldSetter(field, set_JumpFrames_29);
            app.RegisterCLRFieldBinding(field, CopyToStack_JumpFrames_29, AssignFromStack_JumpFrames_29);
            field = type.GetField("HasTeleported", flag);
            app.RegisterCLRFieldGetter(field, get_HasTeleported_30);
            app.RegisterCLRFieldSetter(field, set_HasTeleported_30);
            app.RegisterCLRFieldBinding(field, CopyToStack_HasTeleported_30, AssignFromStack_HasTeleported_30);
            field = type.GetField("IsGrounded", flag);
            app.RegisterCLRFieldGetter(field, get_IsGrounded_31);
            app.RegisterCLRFieldSetter(field, set_IsGrounded_31);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsGrounded_31, AssignFromStack_IsGrounded_31);
            field = type.GetField("WasGrounded", flag);
            app.RegisterCLRFieldGetter(field, get_WasGrounded_32);
            app.RegisterCLRFieldSetter(field, set_WasGrounded_32);
            app.RegisterCLRFieldBinding(field, CopyToStack_WasGrounded_32, AssignFromStack_WasGrounded_32);
            field = type.GetField("IsSteppingUp", flag);
            app.RegisterCLRFieldGetter(field, get_IsSteppingUp_33);
            app.RegisterCLRFieldSetter(field, set_IsSteppingUp_33);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsSteppingUp_33, AssignFromStack_IsSteppingUp_33);
            field = type.GetField("WasSteppingUp", flag);
            app.RegisterCLRFieldGetter(field, get_WasSteppingUp_34);
            app.RegisterCLRFieldSetter(field, set_WasSteppingUp_34);
            app.RegisterCLRFieldBinding(field, CopyToStack_WasSteppingUp_34, AssignFromStack_WasSteppingUp_34);
            field = type.GetField("IsSnappingToGround", flag);
            app.RegisterCLRFieldGetter(field, get_IsSnappingToGround_35);
            app.RegisterCLRFieldSetter(field, set_IsSnappingToGround_35);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsSnappingToGround_35, AssignFromStack_IsSnappingToGround_35);
            field = type.GetField("WasSnappingToGround", flag);
            app.RegisterCLRFieldGetter(field, get_WasSnappingToGround_36);
            app.RegisterCLRFieldSetter(field, set_WasSnappingToGround_36);
            app.RegisterCLRFieldBinding(field, CopyToStack_WasSnappingToGround_36, AssignFromStack_WasSnappingToGround_36);
            field = type.GetField("GroundNormal", flag);
            app.RegisterCLRFieldGetter(field, get_GroundNormal_37);
            app.RegisterCLRFieldSetter(field, set_GroundNormal_37);
            app.RegisterCLRFieldBinding(field, CopyToStack_GroundNormal_37, AssignFromStack_GroundNormal_37);
            field = type.GetField("GroundTangent", flag);
            app.RegisterCLRFieldGetter(field, get_GroundTangent_38);
            app.RegisterCLRFieldSetter(field, set_GroundTangent_38);
            app.RegisterCLRFieldBinding(field, CopyToStack_GroundTangent_38, AssignFromStack_GroundTangent_38);
            field = type.GetField("GroundPosition", flag);
            app.RegisterCLRFieldGetter(field, get_GroundPosition_39);
            app.RegisterCLRFieldSetter(field, set_GroundPosition_39);
            app.RegisterCLRFieldBinding(field, CopyToStack_GroundPosition_39, AssignFromStack_GroundPosition_39);
            field = type.GetField("GroundDistance", flag);
            app.RegisterCLRFieldGetter(field, get_GroundDistance_40);
            app.RegisterCLRFieldSetter(field, set_GroundDistance_40);
            app.RegisterCLRFieldBinding(field, CopyToStack_GroundDistance_40, AssignFromStack_GroundDistance_40);
            field = type.GetField("GroundAngle", flag);
            app.RegisterCLRFieldGetter(field, get_GroundAngle_41);
            app.RegisterCLRFieldSetter(field, set_GroundAngle_41);
            app.RegisterCLRFieldBinding(field, CopyToStack_GroundAngle_41, AssignFromStack_GroundAngle_41);
            field = type.GetField("Collisions", flag);
            app.RegisterCLRFieldGetter(field, get_Collisions_42);
            app.RegisterCLRFieldBinding(field, CopyToStack_Collisions_42, null);
            field = type.GetField("Modifiers", flag);
            app.RegisterCLRFieldGetter(field, get_Modifiers_43);
            app.RegisterCLRFieldBinding(field, CopyToStack_Modifiers_43, null);
            field = type.GetField("Ignores", flag);
            app.RegisterCLRFieldGetter(field, get_Ignores_44);
            app.RegisterCLRFieldBinding(field, CopyToStack_Ignores_44, null);
            field = type.GetField("Hits", flag);
            app.RegisterCLRFieldGetter(field, get_Hits_45);
            app.RegisterCLRFieldBinding(field, CopyToStack_Hits_45, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCData());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_LookPitch_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LookPitch;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_LookPitch_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LookPitch = value;

            return __ret;
        }

        static StackObject* get_LookYaw_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LookYaw;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_LookYaw_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LookYaw = value;

            return __ret;
        }

        static StackObject* get_LookRotation_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LookRotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_LookDirection_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LookDirection;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_TransformRotation_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TransformRotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_TransformDirection_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TransformDirection;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_DesiredVelocity_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DesiredVelocity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_HasJumped_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HasJumped;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsOnEdge_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsOnEdge;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetLookRotation_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @yaw = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @pitch = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLookRotation(@pitch, @yaw);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AddLookRotation_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @yawDelta = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @pitchDelta = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddLookRotation(@pitchDelta, @yawDelta);

            return __ret;
        }

        static StackObject* AddLookRotation_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxPitch = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minPitch = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @yawDelta = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @pitchDelta = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddLookRotation(@pitchDelta, @yawDelta, @minPitch, @maxPitch);

            return __ret;
        }

        static StackObject* AddLookRotation_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @lookRotationDelta = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddLookRotation(@lookRotationDelta);

            return __ret;
        }

        static StackObject* AddLookRotation_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxPitch = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minPitch = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @lookRotationDelta = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddLookRotation(@lookRotationDelta, @minPitch, @maxPitch);

            return __ret;
        }

        static StackObject* SetLookRotation_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @yaw = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @pitch = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLookRotation(@pitch, @yaw);

            return __ret;
        }

        static StackObject* SetLookRotation_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxPitch = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minPitch = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @yaw = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @pitch = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLookRotation(@pitch, @yaw, @minPitch, @maxPitch);

            return __ret;
        }

        static StackObject* SetLookRotation_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @lookRotation = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLookRotation(@lookRotation);

            return __ret;
        }

        static StackObject* SetLookRotation_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxPitch = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minPitch = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @lookRotation = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLookRotation(@lookRotation, @minPitch, @maxPitch);

            return __ret;
        }

        static StackObject* SetLookRotation_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @preserveYaw = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @preservePitch = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Quaternion @lookRotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLookRotation(@lookRotation, @preservePitch, @preserveYaw);

            return __ret;
        }

        static StackObject* ClearTransientProperties_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearTransientProperties();

            return __ret;
        }

        static StackObject* Clear_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* CopyFromOther_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCData @other = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCData instance_of_this_method = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyFromOther(@other);

            return __ret;
        }


        static object get_Frame_0(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).Frame;
        }

        static StackObject* CopyToStack_Frame_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).Frame;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Frame_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).Frame = (System.Int32)v;
        }

        static StackObject* AssignFromStack_Frame_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @Frame = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).Frame = @Frame;
            return ptr_of_this_method;
        }

        static object get_Tick_1(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).Tick;
        }

        static StackObject* CopyToStack_Tick_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).Tick;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Tick_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).Tick = (System.Int32)v;
        }

        static StackObject* AssignFromStack_Tick_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @Tick = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).Tick = @Tick;
            return ptr_of_this_method;
        }

        static object get_Alpha_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).Alpha;
        }

        static StackObject* CopyToStack_Alpha_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).Alpha;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Alpha_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).Alpha = (System.Single)v;
        }

        static StackObject* AssignFromStack_Alpha_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Alpha = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).Alpha = @Alpha;
            return ptr_of_this_method;
        }

        static object get_Time_3(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).Time;
        }

        static StackObject* CopyToStack_Time_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).Time;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Time_3(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).Time = (System.Single)v;
        }

        static StackObject* AssignFromStack_Time_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Time = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).Time = @Time;
            return ptr_of_this_method;
        }

        static object get_DeltaTime_4(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).DeltaTime;
        }

        static StackObject* CopyToStack_DeltaTime_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).DeltaTime;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_DeltaTime_4(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).DeltaTime = (System.Single)v;
        }

        static StackObject* AssignFromStack_DeltaTime_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @DeltaTime = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).DeltaTime = @DeltaTime;
            return ptr_of_this_method;
        }

        static object get_UpdateDeltaTime_5(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).UpdateDeltaTime;
        }

        static StackObject* CopyToStack_UpdateDeltaTime_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).UpdateDeltaTime;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_UpdateDeltaTime_5(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).UpdateDeltaTime = (System.Single)v;
        }

        static StackObject* AssignFromStack_UpdateDeltaTime_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @UpdateDeltaTime = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).UpdateDeltaTime = @UpdateDeltaTime;
            return ptr_of_this_method;
        }

        static object get_IsActive_6(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).IsActive;
        }

        static StackObject* CopyToStack_IsActive_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).IsActive;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsActive_6(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).IsActive = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsActive_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsActive = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCData)o).IsActive = @IsActive;
            return ptr_of_this_method;
        }

        static object get_BasePosition_7(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).BasePosition;
        }

        static StackObject* CopyToStack_BasePosition_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).BasePosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BasePosition_7(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).BasePosition = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_BasePosition_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @BasePosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).BasePosition = @BasePosition;
            return ptr_of_this_method;
        }

        static object get_DesiredPosition_8(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).DesiredPosition;
        }

        static StackObject* CopyToStack_DesiredPosition_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).DesiredPosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_DesiredPosition_8(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).DesiredPosition = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_DesiredPosition_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @DesiredPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).DesiredPosition = @DesiredPosition;
            return ptr_of_this_method;
        }

        static object get_TargetPosition_9(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).TargetPosition;
        }

        static StackObject* CopyToStack_TargetPosition_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).TargetPosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetPosition_9(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).TargetPosition = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_TargetPosition_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @TargetPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).TargetPosition = @TargetPosition;
            return ptr_of_this_method;
        }

        static object get_InputDirection_10(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).InputDirection;
        }

        static StackObject* CopyToStack_InputDirection_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).InputDirection;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_InputDirection_10(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).InputDirection = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_InputDirection_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @InputDirection = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).InputDirection = @InputDirection;
            return ptr_of_this_method;
        }

        static object get_JumpImpulse_11(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).JumpImpulse;
        }

        static StackObject* CopyToStack_JumpImpulse_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).JumpImpulse;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_JumpImpulse_11(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).JumpImpulse = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_JumpImpulse_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @JumpImpulse = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).JumpImpulse = @JumpImpulse;
            return ptr_of_this_method;
        }

        static object get_Gravity_12(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).Gravity;
        }

        static StackObject* CopyToStack_Gravity_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).Gravity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Gravity_12(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).Gravity = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_Gravity_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Gravity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).Gravity = @Gravity;
            return ptr_of_this_method;
        }

        static object get_MaxGroundAngle_13(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).MaxGroundAngle;
        }

        static StackObject* CopyToStack_MaxGroundAngle_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).MaxGroundAngle;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MaxGroundAngle_13(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).MaxGroundAngle = (System.Single)v;
        }

        static StackObject* AssignFromStack_MaxGroundAngle_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @MaxGroundAngle = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).MaxGroundAngle = @MaxGroundAngle;
            return ptr_of_this_method;
        }

        static object get_MaxWallAngle_14(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).MaxWallAngle;
        }

        static StackObject* CopyToStack_MaxWallAngle_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).MaxWallAngle;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MaxWallAngle_14(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).MaxWallAngle = (System.Single)v;
        }

        static StackObject* AssignFromStack_MaxWallAngle_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @MaxWallAngle = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).MaxWallAngle = @MaxWallAngle;
            return ptr_of_this_method;
        }

        static object get_MaxHangAngle_15(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).MaxHangAngle;
        }

        static StackObject* CopyToStack_MaxHangAngle_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).MaxHangAngle;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MaxHangAngle_15(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).MaxHangAngle = (System.Single)v;
        }

        static StackObject* AssignFromStack_MaxHangAngle_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @MaxHangAngle = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).MaxHangAngle = @MaxHangAngle;
            return ptr_of_this_method;
        }

        static object get_MaxPenetrationSteps_16(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).MaxPenetrationSteps;
        }

        static StackObject* CopyToStack_MaxPenetrationSteps_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).MaxPenetrationSteps;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MaxPenetrationSteps_16(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).MaxPenetrationSteps = (System.Int32)v;
        }

        static StackObject* AssignFromStack_MaxPenetrationSteps_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @MaxPenetrationSteps = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).MaxPenetrationSteps = @MaxPenetrationSteps;
            return ptr_of_this_method;
        }

        static object get_ExternalVelocity_17(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).ExternalVelocity;
        }

        static StackObject* CopyToStack_ExternalVelocity_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).ExternalVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ExternalVelocity_17(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).ExternalVelocity = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_ExternalVelocity_17(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @ExternalVelocity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).ExternalVelocity = @ExternalVelocity;
            return ptr_of_this_method;
        }

        static object get_ExternalAcceleration_18(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).ExternalAcceleration;
        }

        static StackObject* CopyToStack_ExternalAcceleration_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).ExternalAcceleration;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ExternalAcceleration_18(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).ExternalAcceleration = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_ExternalAcceleration_18(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @ExternalAcceleration = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).ExternalAcceleration = @ExternalAcceleration;
            return ptr_of_this_method;
        }

        static object get_ExternalImpulse_19(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).ExternalImpulse;
        }

        static StackObject* CopyToStack_ExternalImpulse_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).ExternalImpulse;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ExternalImpulse_19(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).ExternalImpulse = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_ExternalImpulse_19(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @ExternalImpulse = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).ExternalImpulse = @ExternalImpulse;
            return ptr_of_this_method;
        }

        static object get_ExternalForce_20(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).ExternalForce;
        }

        static StackObject* CopyToStack_ExternalForce_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).ExternalForce;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ExternalForce_20(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).ExternalForce = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_ExternalForce_20(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @ExternalForce = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).ExternalForce = @ExternalForce;
            return ptr_of_this_method;
        }

        static object get_ExternalDelta_21(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).ExternalDelta;
        }

        static StackObject* CopyToStack_ExternalDelta_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).ExternalDelta;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ExternalDelta_21(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).ExternalDelta = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_ExternalDelta_21(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @ExternalDelta = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).ExternalDelta = @ExternalDelta;
            return ptr_of_this_method;
        }

        static object get_KinematicSpeed_22(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).KinematicSpeed;
        }

        static StackObject* CopyToStack_KinematicSpeed_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).KinematicSpeed;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_KinematicSpeed_22(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).KinematicSpeed = (System.Single)v;
        }

        static StackObject* AssignFromStack_KinematicSpeed_22(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @KinematicSpeed = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).KinematicSpeed = @KinematicSpeed;
            return ptr_of_this_method;
        }

        static object get_KinematicTangent_23(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).KinematicTangent;
        }

        static StackObject* CopyToStack_KinematicTangent_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).KinematicTangent;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_KinematicTangent_23(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).KinematicTangent = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_KinematicTangent_23(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @KinematicTangent = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).KinematicTangent = @KinematicTangent;
            return ptr_of_this_method;
        }

        static object get_KinematicDirection_24(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).KinematicDirection;
        }

        static StackObject* CopyToStack_KinematicDirection_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).KinematicDirection;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_KinematicDirection_24(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).KinematicDirection = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_KinematicDirection_24(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @KinematicDirection = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).KinematicDirection = @KinematicDirection;
            return ptr_of_this_method;
        }

        static object get_KinematicVelocity_25(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).KinematicVelocity;
        }

        static StackObject* CopyToStack_KinematicVelocity_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).KinematicVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_KinematicVelocity_25(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).KinematicVelocity = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_KinematicVelocity_25(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @KinematicVelocity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).KinematicVelocity = @KinematicVelocity;
            return ptr_of_this_method;
        }

        static object get_DynamicVelocity_26(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).DynamicVelocity;
        }

        static StackObject* CopyToStack_DynamicVelocity_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).DynamicVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_DynamicVelocity_26(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).DynamicVelocity = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_DynamicVelocity_26(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @DynamicVelocity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).DynamicVelocity = @DynamicVelocity;
            return ptr_of_this_method;
        }

        static object get_RealSpeed_27(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).RealSpeed;
        }

        static StackObject* CopyToStack_RealSpeed_27(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).RealSpeed;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_RealSpeed_27(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).RealSpeed = (System.Single)v;
        }

        static StackObject* AssignFromStack_RealSpeed_27(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @RealSpeed = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).RealSpeed = @RealSpeed;
            return ptr_of_this_method;
        }

        static object get_RealVelocity_28(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).RealVelocity;
        }

        static StackObject* CopyToStack_RealVelocity_28(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).RealVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_RealVelocity_28(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).RealVelocity = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_RealVelocity_28(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @RealVelocity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).RealVelocity = @RealVelocity;
            return ptr_of_this_method;
        }

        static object get_JumpFrames_29(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).JumpFrames;
        }

        static StackObject* CopyToStack_JumpFrames_29(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).JumpFrames;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_JumpFrames_29(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).JumpFrames = (System.Int32)v;
        }

        static StackObject* AssignFromStack_JumpFrames_29(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @JumpFrames = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).JumpFrames = @JumpFrames;
            return ptr_of_this_method;
        }

        static object get_HasTeleported_30(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).HasTeleported;
        }

        static StackObject* CopyToStack_HasTeleported_30(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).HasTeleported;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_HasTeleported_30(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).HasTeleported = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_HasTeleported_30(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @HasTeleported = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCData)o).HasTeleported = @HasTeleported;
            return ptr_of_this_method;
        }

        static object get_IsGrounded_31(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).IsGrounded;
        }

        static StackObject* CopyToStack_IsGrounded_31(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).IsGrounded;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsGrounded_31(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).IsGrounded = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsGrounded_31(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsGrounded = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCData)o).IsGrounded = @IsGrounded;
            return ptr_of_this_method;
        }

        static object get_WasGrounded_32(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).WasGrounded;
        }

        static StackObject* CopyToStack_WasGrounded_32(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).WasGrounded;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_WasGrounded_32(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).WasGrounded = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_WasGrounded_32(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @WasGrounded = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCData)o).WasGrounded = @WasGrounded;
            return ptr_of_this_method;
        }

        static object get_IsSteppingUp_33(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).IsSteppingUp;
        }

        static StackObject* CopyToStack_IsSteppingUp_33(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).IsSteppingUp;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsSteppingUp_33(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).IsSteppingUp = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsSteppingUp_33(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsSteppingUp = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCData)o).IsSteppingUp = @IsSteppingUp;
            return ptr_of_this_method;
        }

        static object get_WasSteppingUp_34(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).WasSteppingUp;
        }

        static StackObject* CopyToStack_WasSteppingUp_34(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).WasSteppingUp;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_WasSteppingUp_34(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).WasSteppingUp = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_WasSteppingUp_34(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @WasSteppingUp = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCData)o).WasSteppingUp = @WasSteppingUp;
            return ptr_of_this_method;
        }

        static object get_IsSnappingToGround_35(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).IsSnappingToGround;
        }

        static StackObject* CopyToStack_IsSnappingToGround_35(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).IsSnappingToGround;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsSnappingToGround_35(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).IsSnappingToGround = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsSnappingToGround_35(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsSnappingToGround = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCData)o).IsSnappingToGround = @IsSnappingToGround;
            return ptr_of_this_method;
        }

        static object get_WasSnappingToGround_36(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).WasSnappingToGround;
        }

        static StackObject* CopyToStack_WasSnappingToGround_36(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).WasSnappingToGround;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_WasSnappingToGround_36(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).WasSnappingToGround = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_WasSnappingToGround_36(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @WasSnappingToGround = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCData)o).WasSnappingToGround = @WasSnappingToGround;
            return ptr_of_this_method;
        }

        static object get_GroundNormal_37(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).GroundNormal;
        }

        static StackObject* CopyToStack_GroundNormal_37(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).GroundNormal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_GroundNormal_37(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).GroundNormal = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_GroundNormal_37(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @GroundNormal = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).GroundNormal = @GroundNormal;
            return ptr_of_this_method;
        }

        static object get_GroundTangent_38(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).GroundTangent;
        }

        static StackObject* CopyToStack_GroundTangent_38(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).GroundTangent;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_GroundTangent_38(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).GroundTangent = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_GroundTangent_38(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @GroundTangent = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).GroundTangent = @GroundTangent;
            return ptr_of_this_method;
        }

        static object get_GroundPosition_39(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).GroundPosition;
        }

        static StackObject* CopyToStack_GroundPosition_39(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).GroundPosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_GroundPosition_39(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).GroundPosition = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_GroundPosition_39(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @GroundPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCData)o).GroundPosition = @GroundPosition;
            return ptr_of_this_method;
        }

        static object get_GroundDistance_40(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).GroundDistance;
        }

        static StackObject* CopyToStack_GroundDistance_40(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).GroundDistance;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_GroundDistance_40(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).GroundDistance = (System.Single)v;
        }

        static StackObject* AssignFromStack_GroundDistance_40(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @GroundDistance = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).GroundDistance = @GroundDistance;
            return ptr_of_this_method;
        }

        static object get_GroundAngle_41(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).GroundAngle;
        }

        static StackObject* CopyToStack_GroundAngle_41(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).GroundAngle;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_GroundAngle_41(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCData)o).GroundAngle = (System.Single)v;
        }

        static StackObject* AssignFromStack_GroundAngle_41(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @GroundAngle = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCData)o).GroundAngle = @GroundAngle;
            return ptr_of_this_method;
        }

        static object get_Collisions_42(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).Collisions;
        }

        static StackObject* CopyToStack_Collisions_42(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).Collisions;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Modifiers_43(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).Modifiers;
        }

        static StackObject* CopyToStack_Modifiers_43(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).Modifiers;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Ignores_44(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).Ignores;
        }

        static StackObject* CopyToStack_Ignores_44(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).Ignores;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Hits_45(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCData)o).Hits;
        }

        static StackObject* CopyToStack_Hits_45(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCData)o).Hits;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif