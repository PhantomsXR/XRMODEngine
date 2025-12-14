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
    unsafe class Unity_Netcode_Components_NetworkRigidbodyBase_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.Components.NetworkRigidbodyBase);
            args = new Type[]{};
            method = type.GetMethod("get_RigidbodyType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_RigidbodyType_0);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("SetLinearVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLinearVelocity_1);
            args = new Type[]{};
            method = type.GetMethod("GetLinearVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLinearVelocity_2);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("SetAngularVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAngularVelocity_3);
            args = new Type[]{};
            method = type.GetMethod("GetAngularVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAngularVelocity_4);
            args = new Type[]{};
            method = type.GetMethod("GetPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPosition_5);
            args = new Type[]{};
            method = type.GetMethod("GetRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRotation_6);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("MovePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MovePosition_7);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("SetPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPosition_8);
            args = new Type[]{};
            method = type.GetMethod("ApplyCurrentTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyCurrentTransform_9);
            args = new Type[]{typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("MoveRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveRotation_10);
            args = new Type[]{typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("SetRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRotation_11);
            args = new Type[]{};
            method = type.GetMethod("WakeIfSleeping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WakeIfSleeping_12);
            args = new Type[]{};
            method = type.GetMethod("SleepRigidbody", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SleepRigidbody_13);
            args = new Type[]{};
            method = type.GetMethod("IsKinematic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsKinematic_14);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetIsKinematic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetIsKinematic_15);
            args = new Type[]{};
            method = type.GetMethod("ResetInterpolation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetInterpolation_16);
            args = new Type[]{};
            method = type.GetMethod("OnNetworkSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkSpawn_17);
            args = new Type[]{};
            method = type.GetMethod("OnNetworkDespawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkDespawn_18);
            args = new Type[]{};
            method = type.GetMethod("get_FixedJoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_FixedJoint_19);
            args = new Type[]{};
            method = type.GetMethod("get_FixedJoint2D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_FixedJoint2D_20);
            args = new Type[]{typeof(Unity.Netcode.Components.NetworkRigidbodyBase), typeof(UnityEngine.Vector3), typeof(System.Single), typeof(System.Single), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("AttachToFixedJoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AttachToFixedJoint_21);
            args = new Type[]{};
            method = type.GetMethod("DetachFromFixedJoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DetachFromFixedJoint_22);

            field = type.GetField("UseRigidBodyForMotion", flag);
            app.RegisterCLRFieldGetter(field, get_UseRigidBodyForMotion_0);
            app.RegisterCLRFieldSetter(field, set_UseRigidBodyForMotion_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_UseRigidBodyForMotion_0, AssignFromStack_UseRigidBodyForMotion_0);
            field = type.GetField("AutoUpdateKinematicState", flag);
            app.RegisterCLRFieldGetter(field, get_AutoUpdateKinematicState_1);
            app.RegisterCLRFieldSetter(field, set_AutoUpdateKinematicState_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_AutoUpdateKinematicState_1, AssignFromStack_AutoUpdateKinematicState_1);
            field = type.GetField("AutoSetKinematicOnDespawn", flag);
            app.RegisterCLRFieldGetter(field, get_AutoSetKinematicOnDespawn_2);
            app.RegisterCLRFieldSetter(field, set_AutoSetKinematicOnDespawn_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_AutoSetKinematicOnDespawn_2, AssignFromStack_AutoSetKinematicOnDespawn_2);


            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.Components.NetworkRigidbodyBase[s]);


        }


        static StackObject* get_RigidbodyType_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RigidbodyType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetLinearVelocity_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @linearVelocity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLinearVelocity(@linearVelocity);

            return __ret;
        }

        static StackObject* GetLinearVelocity_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLinearVelocity();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetAngularVelocity_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @angularVelocity = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetAngularVelocity(@angularVelocity);

            return __ret;
        }

        static StackObject* GetAngularVelocity_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAngularVelocity();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPosition_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPosition();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRotation_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetRotation();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* MovePosition_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MovePosition(@position);

            return __ret;
        }

        static StackObject* SetPosition_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPosition(@position);

            return __ret;
        }

        static StackObject* ApplyCurrentTransform_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ApplyCurrentTransform();

            return __ret;
        }

        static StackObject* MoveRotation_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveRotation(@rotation);

            return __ret;
        }

        static StackObject* SetRotation_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetRotation(@rotation);

            return __ret;
        }

        static StackObject* WakeIfSleeping_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WakeIfSleeping();

            return __ret;
        }

        static StackObject* SleepRigidbody_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SleepRigidbody();

            return __ret;
        }

        static StackObject* IsKinematic_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsKinematic();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetIsKinematic_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @isKinematic = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetIsKinematic(@isKinematic);

            return __ret;
        }

        static StackObject* ResetInterpolation_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetInterpolation();

            return __ret;
        }

        static StackObject* OnNetworkSpawn_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkSpawn();

            return __ret;
        }

        static StackObject* OnNetworkDespawn_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkDespawn();

            return __ret;
        }

        static StackObject* get_FixedJoint_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FixedJoint;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_FixedJoint2D_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FixedJoint2D;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AttachToFixedJoint_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @teleportObject = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @zeroVelocity = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @useGravity = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @massScale = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @connectedMassScale = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector3 @positionOfConnection = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            Unity.Netcode.Components.NetworkRigidbodyBase @objectToConnectTo = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AttachToFixedJoint(@objectToConnectTo, @positionOfConnection, @connectedMassScale, @massScale, @useGravity, @zeroVelocity, @teleportObject);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* DetachFromFixedJoint_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.NetworkRigidbodyBase instance_of_this_method = (Unity.Netcode.Components.NetworkRigidbodyBase)typeof(Unity.Netcode.Components.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DetachFromFixedJoint();

            return __ret;
        }


        static object get_UseRigidBodyForMotion_0(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkRigidbodyBase)o).UseRigidBodyForMotion;
        }

        static StackObject* CopyToStack_UseRigidBodyForMotion_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkRigidbodyBase)o).UseRigidBodyForMotion;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_UseRigidBodyForMotion_0(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkRigidbodyBase)o).UseRigidBodyForMotion = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_UseRigidBodyForMotion_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @UseRigidBodyForMotion = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkRigidbodyBase)o).UseRigidBodyForMotion = @UseRigidBodyForMotion;
            return ptr_of_this_method;
        }

        static object get_AutoUpdateKinematicState_1(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkRigidbodyBase)o).AutoUpdateKinematicState;
        }

        static StackObject* CopyToStack_AutoUpdateKinematicState_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkRigidbodyBase)o).AutoUpdateKinematicState;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AutoUpdateKinematicState_1(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkRigidbodyBase)o).AutoUpdateKinematicState = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AutoUpdateKinematicState_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AutoUpdateKinematicState = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkRigidbodyBase)o).AutoUpdateKinematicState = @AutoUpdateKinematicState;
            return ptr_of_this_method;
        }

        static object get_AutoSetKinematicOnDespawn_2(ref object o)
        {
            return ((Unity.Netcode.Components.NetworkRigidbodyBase)o).AutoSetKinematicOnDespawn;
        }

        static StackObject* CopyToStack_AutoSetKinematicOnDespawn_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.NetworkRigidbodyBase)o).AutoSetKinematicOnDespawn;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AutoSetKinematicOnDespawn_2(ref object o, object v)
        {
            ((Unity.Netcode.Components.NetworkRigidbodyBase)o).AutoSetKinematicOnDespawn = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AutoSetKinematicOnDespawn_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AutoSetKinematicOnDespawn = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.Components.NetworkRigidbodyBase)o).AutoSetKinematicOnDespawn = @AutoSetKinematicOnDespawn;
            return ptr_of_this_method;
        }




    }
}
