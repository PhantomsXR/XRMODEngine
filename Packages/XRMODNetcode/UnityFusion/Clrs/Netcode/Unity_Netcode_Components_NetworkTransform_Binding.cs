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
    unsafe class Unity_Netcode_Components_NetworkTransform_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.Components.NetworkTransform);
            args = new Type[]{};
            method = type.GetMethod("get_CanCommitToTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CanCommitToTransform_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("GetSpaceRelativePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSpaceRelativePosition_1);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("GetSpaceRelativeRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSpaceRelativeRotation_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("GetScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetScale_3);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("SetMaxInterpolationBound", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetMaxInterpolationBound_4);
            args = new Type[]{};
            method = type.GetMethod("OnNetworkSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkSpawn_5);
            args = new Type[]{};
            method = type.GetMethod("OnNetworkDespawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkDespawn_6);
            args = new Type[]{};
            method = type.GetMethod("OnDestroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDestroy_7);
            args = new Type[]{};
            method = type.GetMethod("OnLostOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnLostOwnership_8);
            args = new Type[]{};
            method = type.GetMethod("OnGainedOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnGainedOwnership_9);
            args = new Type[]{typeof(Unity.Netcode.NetworkObject)};
            method = type.GetMethod("OnNetworkObjectParentChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkObjectParentChanged_10);
            args = new Type[]{typeof(System.Nullable<UnityEngine.Vector3>), typeof(System.Nullable<UnityEngine.Quaternion>), typeof(System.Nullable<UnityEngine.Vector3>), typeof(System.Boolean)};
            method = type.GetMethod("SetState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetState_11);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("Teleport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Teleport_12);
            args = new Type[]{};
            method = type.GetMethod("OnUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnUpdate_13);
            args = new Type[]{};
            method = type.GetMethod("OnFixedUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnFixedUpdate_14);
            args = new Type[]{};
            method = type.GetMethod("IsServerAuthoritative", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsServerAuthoritative_15);
            args = new Type[]{};
            method = type.GetMethod("GetTickLatency", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTickLatency_16);
            args = new Type[]{};
            method = type.GetMethod("GetTickLatencyInSeconds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTickLatencyInSeconds_17);

            field = type.GetField("AuthorityMode", flag);
            app.RegisterCLRFieldGetter(field, get_AuthorityMode_0);
            app.RegisterCLRFieldSetter(field, set_AuthorityMode_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_AuthorityMode_0, AssignFromStack_AuthorityMode_0);
            field = type.GetField("TickSyncChildren", flag);
            app.RegisterCLRFieldGetter(field, get_TickSyncChildren_1);
            app.RegisterCLRFieldSetter(field, set_TickSyncChildren_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_TickSyncChildren_1, AssignFromStack_TickSyncChildren_1);
            field = type.GetField("PositionThresholdDefault", flag);
            app.RegisterCLRFieldGetter(field, get_PositionThresholdDefault_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_PositionThresholdDefault_2, null);
            field = type.GetField("RotAngleThresholdDefault", flag);
            app.RegisterCLRFieldGetter(field, get_RotAngleThresholdDefault_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_RotAngleThresholdDefault_3, null);
            field = type.GetField("ScaleThresholdDefault", flag);
            app.RegisterCLRFieldGetter(field, get_ScaleThresholdDefault_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_ScaleThresholdDefault_4, null);
            field = type.GetField("OnClientRequestChange", flag);
            app.RegisterCLRFieldGetter(field, get_OnClientRequestChange_5);
            app.RegisterCLRFieldSetter(field, set_OnClientRequestChange_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnClientRequestChange_5, AssignFromStack_OnClientRequestChange_5);
            field = type.GetField("UseUnreliableDeltas", flag);
            app.RegisterCLRFieldGetter(field, get_UseUnreliableDeltas_6);
            app.RegisterCLRFieldSetter(field, set_UseUnreliableDeltas_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_UseUnreliableDeltas_6, AssignFromStack_UseUnreliableDeltas_6);
            field = type.GetField("SyncPositionX", flag);
            app.RegisterCLRFieldGetter(field, get_SyncPositionX_7);
            app.RegisterCLRFieldSetter(field, set_SyncPositionX_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncPositionX_7, AssignFromStack_SyncPositionX_7);
            field = type.GetField("SyncPositionY", flag);
            app.RegisterCLRFieldGetter(field, get_SyncPositionY_8);
            app.RegisterCLRFieldSetter(field, set_SyncPositionY_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncPositionY_8, AssignFromStack_SyncPositionY_8);
            field = type.GetField("SyncPositionZ", flag);
            app.RegisterCLRFieldGetter(field, get_SyncPositionZ_9);
            app.RegisterCLRFieldSetter(field, set_SyncPositionZ_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncPositionZ_9, AssignFromStack_SyncPositionZ_9);
            field = type.GetField("SyncRotAngleX", flag);
            app.RegisterCLRFieldGetter(field, get_SyncRotAngleX_10);
            app.RegisterCLRFieldSetter(field, set_SyncRotAngleX_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncRotAngleX_10, AssignFromStack_SyncRotAngleX_10);
            field = type.GetField("SyncRotAngleY", flag);
            app.RegisterCLRFieldGetter(field, get_SyncRotAngleY_11);
            app.RegisterCLRFieldSetter(field, set_SyncRotAngleY_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncRotAngleY_11, AssignFromStack_SyncRotAngleY_11);
            field = type.GetField("SyncRotAngleZ", flag);
            app.RegisterCLRFieldGetter(field, get_SyncRotAngleZ_12);
            app.RegisterCLRFieldSetter(field, set_SyncRotAngleZ_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncRotAngleZ_12, AssignFromStack_SyncRotAngleZ_12);
            field = type.GetField("SyncScaleX", flag);
            app.RegisterCLRFieldGetter(field, get_SyncScaleX_13);
            app.RegisterCLRFieldSetter(field, set_SyncScaleX_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncScaleX_13, AssignFromStack_SyncScaleX_13);
            field = type.GetField("SyncScaleY", flag);
            app.RegisterCLRFieldGetter(field, get_SyncScaleY_14);
            app.RegisterCLRFieldSetter(field, set_SyncScaleY_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncScaleY_14, AssignFromStack_SyncScaleY_14);
            field = type.GetField("SyncScaleZ", flag);
            app.RegisterCLRFieldGetter(field, get_SyncScaleZ_15);
            app.RegisterCLRFieldSetter(field, set_SyncScaleZ_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncScaleZ_15, AssignFromStack_SyncScaleZ_15);
            field = type.GetField("PositionThreshold", flag);
            app.RegisterCLRFieldGetter(field, get_PositionThreshold_16);
            app.RegisterCLRFieldSetter(field, set_PositionThreshold_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_PositionThreshold_16, AssignFromStack_PositionThreshold_16);
            field = type.GetField("RotAngleThreshold", flag);
            app.RegisterCLRFieldGetter(field, get_RotAngleThreshold_17);
            app.RegisterCLRFieldSetter(field, set_RotAngleThreshold_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_RotAngleThreshold_17, AssignFromStack_RotAngleThreshold_17);
            field = type.GetField("ScaleThreshold", flag);
            app.RegisterCLRFieldGetter(field, get_ScaleThreshold_18);
            app.RegisterCLRFieldSetter(field, set_ScaleThreshold_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_ScaleThreshold_18, AssignFromStack_ScaleThreshold_18);
            field = type.GetField("UseQuaternionSynchronization", flag);
            app.RegisterCLRFieldGetter(field, get_UseQuaternionSynchronization_19);
            app.RegisterCLRFieldSetter(field, set_UseQuaternionSynchronization_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_UseQuaternionSynchronization_19, AssignFromStack_UseQuaternionSynchronization_19);
            field = type.GetField("UseQuaternionCompression", flag);
            app.RegisterCLRFieldGetter(field, get_UseQuaternionCompression_20);
            app.RegisterCLRFieldSetter(field, set_UseQuaternionCompression_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_UseQuaternionCompression_20, AssignFromStack_UseQuaternionCompression_20);
            field = type.GetField("UseHalfFloatPrecision", flag);
            app.RegisterCLRFieldGetter(field, get_UseHalfFloatPrecision_21);
            app.RegisterCLRFieldSetter(field, set_UseHalfFloatPrecision_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_UseHalfFloatPrecision_21, AssignFromStack_UseHalfFloatPrecision_21);
            field = type.GetField("InLocalSpace", flag);
            app.RegisterCLRFieldGetter(field, get_InLocalSpace_22);
            app.RegisterCLRFieldSetter(field, set_InLocalSpace_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_InLocalSpace_22, AssignFromStack_InLocalSpace_22);
            field = type.GetField("SwitchTransformSpaceWhenParented", flag);
            app.RegisterCLRFieldGetter(field, get_SwitchTransformSpaceWhenParented_23);
            app.RegisterCLRFieldSetter(field, set_SwitchTransformSpaceWhenParented_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_SwitchTransformSpaceWhenParented_23, AssignFromStack_SwitchTransformSpaceWhenParented_23);
            field = type.GetField("Interpolate", flag);
            app.RegisterCLRFieldGetter(field, get_Interpolate_24);
            app.RegisterCLRFieldSetter(field, set_Interpolate_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_Interpolate_24, AssignFromStack_Interpolate_24);
            field = type.GetField("SlerpPosition", flag);
            app.RegisterCLRFieldGetter(field, get_SlerpPosition_25);
            app.RegisterCLRFieldSetter(field, set_SlerpPosition_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_SlerpPosition_25, AssignFromStack_SlerpPosition_25);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.Components.NetworkTransform());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.Components.NetworkTransform[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_CanCommitToTransform_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CanCommitToTransform;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetSpaceRelativePosition_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @getCurrentState = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetSpaceRelativePosition(@getCurrentState);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetSpaceRelativeRotation_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @getCurrentState = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetSpaceRelativeRotation(@getCurrentState);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetScale_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @getCurrentState = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetScale(@getCurrentState);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetMaxInterpolationBound_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxInterpolationBound = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetMaxInterpolationBound(@maxInterpolationBound);

            return __ret;
        }

        static StackObject* OnNetworkSpawn_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkSpawn();

            return __ret;
        }

        static StackObject* OnNetworkDespawn_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkDespawn();

            return __ret;
        }

        static StackObject* OnDestroy_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDestroy();

            return __ret;
        }

        static StackObject* OnLostOwnership_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnLostOwnership();

            return __ret;
        }

        static StackObject* OnGainedOwnership_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnGainedOwnership();

            return __ret;
        }

        static StackObject* OnNetworkObjectParentChanged_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject @parentNetworkObject = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkObjectParentChanged(@parentNetworkObject);

            return __ret;
        }

        static StackObject* SetState_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @teleportDisabled = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Nullable<UnityEngine.Vector3> @scaleIn = (System.Nullable<UnityEngine.Vector3>)typeof(System.Nullable<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Nullable<UnityEngine.Quaternion> @rotIn = (System.Nullable<UnityEngine.Quaternion>)typeof(System.Nullable<UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Nullable<UnityEngine.Vector3> @posIn = (System.Nullable<UnityEngine.Vector3>)typeof(System.Nullable<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetState(@posIn, @rotIn, @scaleIn, @teleportDisabled);

            return __ret;
        }

        static StackObject* Teleport_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @newScale = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @newRotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @newPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Teleport(@newPosition, @newRotation, @newScale);

            return __ret;
        }

        static StackObject* OnUpdate_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnUpdate();

            return __ret;
        }

        static StackObject* OnFixedUpdate_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnFixedUpdate();

            return __ret;
        }

        static StackObject* IsServerAuthoritative_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkTransform instance_of_this_method = (Unity.Netcode.Components.NetworkTransform)typeof(Unity.Netcode.Components.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsServerAuthoritative();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetTickLatency_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Unity.Netcode.Components.NetworkTransform.GetTickLatency();

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetTickLatencyInSeconds_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Unity.Netcode.Components.NetworkTransform.GetTickLatencyInSeconds();

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }


        static object get_AuthorityMode_0(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).AuthorityMode;
        }

        static StackObject* CopyToStack_AuthorityMode_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).AuthorityMode;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AuthorityMode_0(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).AuthorityMode = (Unity.Netcode.Components.NetworkTransform.AuthorityModes)v;
        }

        static StackObject* AssignFromStack_AuthorityMode_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.Components.NetworkTransform.AuthorityModes @AuthorityMode = (Unity.Netcode.Components.NetworkTransform.AuthorityModes)typeof(Unity.Netcode.Components.NetworkTransform.AuthorityModes).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Unity.Netcode.Components.NetworkTransform)o).AuthorityMode = @AuthorityMode;
            return ptr_of_this_method;
        }

        static object get_TickSyncChildren_1(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).TickSyncChildren;
        }

        static StackObject* CopyToStack_TickSyncChildren_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).TickSyncChildren;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_TickSyncChildren_1(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).TickSyncChildren = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_TickSyncChildren_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @TickSyncChildren = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).TickSyncChildren = @TickSyncChildren;
            return ptr_of_this_method;
        }

        static object get_PositionThresholdDefault_2(ref object o)
        {
            return Unity.Netcode.Components.NetworkTransform.PositionThresholdDefault;
        }

        static StackObject* CopyToStack_PositionThresholdDefault_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.Components.NetworkTransform.PositionThresholdDefault;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_RotAngleThresholdDefault_3(ref object o)
        {
            return Unity.Netcode.Components.NetworkTransform.RotAngleThresholdDefault;
        }

        static StackObject* CopyToStack_RotAngleThresholdDefault_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.Components.NetworkTransform.RotAngleThresholdDefault;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_ScaleThresholdDefault_4(ref object o)
        {
            return Unity.Netcode.Components.NetworkTransform.ScaleThresholdDefault;
        }

        static StackObject* CopyToStack_ScaleThresholdDefault_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.Components.NetworkTransform.ScaleThresholdDefault;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_OnClientRequestChange_5(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).OnClientRequestChange;
        }

        static StackObject* CopyToStack_OnClientRequestChange_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).OnClientRequestChange;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnClientRequestChange_5(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).OnClientRequestChange = (Unity.Netcode.Components.NetworkTransform.OnClientRequestChangeDelegate)v;
        }

        static StackObject* AssignFromStack_OnClientRequestChange_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.Components.NetworkTransform.OnClientRequestChangeDelegate @OnClientRequestChange = (Unity.Netcode.Components.NetworkTransform.OnClientRequestChangeDelegate)typeof(Unity.Netcode.Components.NetworkTransform.OnClientRequestChangeDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Unity.Netcode.Components.NetworkTransform)o).OnClientRequestChange = @OnClientRequestChange;
            return ptr_of_this_method;
        }

        static object get_UseUnreliableDeltas_6(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).UseUnreliableDeltas;
        }

        static StackObject* CopyToStack_UseUnreliableDeltas_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).UseUnreliableDeltas;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_UseUnreliableDeltas_6(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).UseUnreliableDeltas = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_UseUnreliableDeltas_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @UseUnreliableDeltas = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).UseUnreliableDeltas = @UseUnreliableDeltas;
            return ptr_of_this_method;
        }

        static object get_SyncPositionX_7(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).SyncPositionX;
        }

        static StackObject* CopyToStack_SyncPositionX_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).SyncPositionX;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncPositionX_7(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).SyncPositionX = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncPositionX_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncPositionX = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).SyncPositionX = @SyncPositionX;
            return ptr_of_this_method;
        }

        static object get_SyncPositionY_8(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).SyncPositionY;
        }

        static StackObject* CopyToStack_SyncPositionY_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).SyncPositionY;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncPositionY_8(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).SyncPositionY = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncPositionY_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncPositionY = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).SyncPositionY = @SyncPositionY;
            return ptr_of_this_method;
        }

        static object get_SyncPositionZ_9(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).SyncPositionZ;
        }

        static StackObject* CopyToStack_SyncPositionZ_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).SyncPositionZ;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncPositionZ_9(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).SyncPositionZ = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncPositionZ_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncPositionZ = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).SyncPositionZ = @SyncPositionZ;
            return ptr_of_this_method;
        }

        static object get_SyncRotAngleX_10(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).SyncRotAngleX;
        }

        static StackObject* CopyToStack_SyncRotAngleX_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).SyncRotAngleX;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncRotAngleX_10(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).SyncRotAngleX = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncRotAngleX_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncRotAngleX = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).SyncRotAngleX = @SyncRotAngleX;
            return ptr_of_this_method;
        }

        static object get_SyncRotAngleY_11(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).SyncRotAngleY;
        }

        static StackObject* CopyToStack_SyncRotAngleY_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).SyncRotAngleY;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncRotAngleY_11(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).SyncRotAngleY = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncRotAngleY_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncRotAngleY = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).SyncRotAngleY = @SyncRotAngleY;
            return ptr_of_this_method;
        }

        static object get_SyncRotAngleZ_12(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).SyncRotAngleZ;
        }

        static StackObject* CopyToStack_SyncRotAngleZ_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).SyncRotAngleZ;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncRotAngleZ_12(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).SyncRotAngleZ = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncRotAngleZ_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncRotAngleZ = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).SyncRotAngleZ = @SyncRotAngleZ;
            return ptr_of_this_method;
        }

        static object get_SyncScaleX_13(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).SyncScaleX;
        }

        static StackObject* CopyToStack_SyncScaleX_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).SyncScaleX;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncScaleX_13(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).SyncScaleX = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncScaleX_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncScaleX = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).SyncScaleX = @SyncScaleX;
            return ptr_of_this_method;
        }

        static object get_SyncScaleY_14(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).SyncScaleY;
        }

        static StackObject* CopyToStack_SyncScaleY_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).SyncScaleY;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncScaleY_14(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).SyncScaleY = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncScaleY_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncScaleY = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).SyncScaleY = @SyncScaleY;
            return ptr_of_this_method;
        }

        static object get_SyncScaleZ_15(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).SyncScaleZ;
        }

        static StackObject* CopyToStack_SyncScaleZ_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).SyncScaleZ;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncScaleZ_15(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).SyncScaleZ = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncScaleZ_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncScaleZ = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).SyncScaleZ = @SyncScaleZ;
            return ptr_of_this_method;
        }

        static object get_PositionThreshold_16(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).PositionThreshold;
        }

        static StackObject* CopyToStack_PositionThreshold_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).PositionThreshold;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_PositionThreshold_16(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).PositionThreshold = (System.Single)v;
        }

        static StackObject* AssignFromStack_PositionThreshold_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @PositionThreshold = *(float*)&ptr_of_this_method->Value;
            ((Unity.Netcode.Components.NetworkTransform)o).PositionThreshold = @PositionThreshold;
            return ptr_of_this_method;
        }

        static object get_RotAngleThreshold_17(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).RotAngleThreshold;
        }

        static StackObject* CopyToStack_RotAngleThreshold_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).RotAngleThreshold;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_RotAngleThreshold_17(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).RotAngleThreshold = (System.Single)v;
        }

        static StackObject* AssignFromStack_RotAngleThreshold_17(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @RotAngleThreshold = *(float*)&ptr_of_this_method->Value;
            ((Unity.Netcode.Components.NetworkTransform)o).RotAngleThreshold = @RotAngleThreshold;
            return ptr_of_this_method;
        }

        static object get_ScaleThreshold_18(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).ScaleThreshold;
        }

        static StackObject* CopyToStack_ScaleThreshold_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).ScaleThreshold;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ScaleThreshold_18(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).ScaleThreshold = (System.Single)v;
        }

        static StackObject* AssignFromStack_ScaleThreshold_18(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @ScaleThreshold = *(float*)&ptr_of_this_method->Value;
            ((Unity.Netcode.Components.NetworkTransform)o).ScaleThreshold = @ScaleThreshold;
            return ptr_of_this_method;
        }

        static object get_UseQuaternionSynchronization_19(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).UseQuaternionSynchronization;
        }

        static StackObject* CopyToStack_UseQuaternionSynchronization_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).UseQuaternionSynchronization;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_UseQuaternionSynchronization_19(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).UseQuaternionSynchronization = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_UseQuaternionSynchronization_19(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @UseQuaternionSynchronization = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).UseQuaternionSynchronization = @UseQuaternionSynchronization;
            return ptr_of_this_method;
        }

        static object get_UseQuaternionCompression_20(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).UseQuaternionCompression;
        }

        static StackObject* CopyToStack_UseQuaternionCompression_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).UseQuaternionCompression;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_UseQuaternionCompression_20(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).UseQuaternionCompression = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_UseQuaternionCompression_20(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @UseQuaternionCompression = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).UseQuaternionCompression = @UseQuaternionCompression;
            return ptr_of_this_method;
        }

        static object get_UseHalfFloatPrecision_21(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).UseHalfFloatPrecision;
        }

        static StackObject* CopyToStack_UseHalfFloatPrecision_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).UseHalfFloatPrecision;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_UseHalfFloatPrecision_21(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).UseHalfFloatPrecision = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_UseHalfFloatPrecision_21(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @UseHalfFloatPrecision = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).UseHalfFloatPrecision = @UseHalfFloatPrecision;
            return ptr_of_this_method;
        }

        static object get_InLocalSpace_22(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).InLocalSpace;
        }

        static StackObject* CopyToStack_InLocalSpace_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).InLocalSpace;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_InLocalSpace_22(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).InLocalSpace = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_InLocalSpace_22(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @InLocalSpace = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).InLocalSpace = @InLocalSpace;
            return ptr_of_this_method;
        }

        static object get_SwitchTransformSpaceWhenParented_23(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).SwitchTransformSpaceWhenParented;
        }

        static StackObject* CopyToStack_SwitchTransformSpaceWhenParented_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).SwitchTransformSpaceWhenParented;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SwitchTransformSpaceWhenParented_23(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).SwitchTransformSpaceWhenParented = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SwitchTransformSpaceWhenParented_23(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SwitchTransformSpaceWhenParented = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).SwitchTransformSpaceWhenParented = @SwitchTransformSpaceWhenParented;
            return ptr_of_this_method;
        }

        static object get_Interpolate_24(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).Interpolate;
        }

        static StackObject* CopyToStack_Interpolate_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).Interpolate;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_Interpolate_24(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).Interpolate = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_Interpolate_24(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @Interpolate = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).Interpolate = @Interpolate;
            return ptr_of_this_method;
        }

        static object get_SlerpPosition_25(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkTransform)o).SlerpPosition;
        }

        static StackObject* CopyToStack_SlerpPosition_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkTransform)o).SlerpPosition;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SlerpPosition_25(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkTransform)o).SlerpPosition = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SlerpPosition_25(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SlerpPosition = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkTransform)o).SlerpPosition = @SlerpPosition;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.Netcode.Components.NetworkTransform();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
