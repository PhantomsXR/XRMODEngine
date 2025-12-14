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
    unsafe class UnityEngine_Rigidbody2D_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Rigidbody2D);
            args = new Type[] { };
            method = type.GetMethod("get_position", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_position_0);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_position", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_position_1);
            args = new Type[] { };
            method = type.GetMethod("get_rotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rotation_2);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_rotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rotation_3);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("SetRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRotation_4);
            args = new Type[] {typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("SetRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRotation_5);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("MovePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MovePosition_6);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("MoveRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveRotation_7);
            args = new Type[] {typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("MoveRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveRotation_8);
            args = new Type[] { };
            method = type.GetMethod("get_velocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_velocity_9);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_velocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_velocity_10);
            args = new Type[] { };
            method = type.GetMethod("get_angularVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularVelocity_11);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_angularVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularVelocity_12);
            args = new Type[] { };
            method = type.GetMethod("get_useAutoMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useAutoMass_13);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_useAutoMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useAutoMass_14);
            args = new Type[] { };
            method = type.GetMethod("get_mass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mass_15);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_mass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_mass_16);
            args = new Type[] { };
            method = type.GetMethod("get_sharedMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sharedMaterial_17);
            args = new Type[] {typeof(UnityEngine.PhysicsMaterial2D)};
            method = type.GetMethod("set_sharedMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sharedMaterial_18);
            args = new Type[] { };
            method = type.GetMethod("get_centerOfMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_centerOfMass_19);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_centerOfMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_centerOfMass_20);
            args = new Type[] { };
            method = type.GetMethod("get_worldCenterOfMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_worldCenterOfMass_21);
            args = new Type[] { };
            method = type.GetMethod("get_inertia", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inertia_22);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_inertia", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_inertia_23);
            args = new Type[] { };
            method = type.GetMethod("get_drag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_drag_24);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_drag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_drag_25);
            args = new Type[] { };
            method = type.GetMethod("get_angularDrag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularDrag_26);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_angularDrag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularDrag_27);
            args = new Type[] { };
            method = type.GetMethod("get_gravityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_gravityScale_28);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_gravityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_gravityScale_29);
            args = new Type[] { };
            method = type.GetMethod("get_bodyType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bodyType_30);
            args = new Type[] {typeof(UnityEngine.RigidbodyType2D)};
            method = type.GetMethod("set_bodyType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bodyType_31);
            args = new Type[] { };
            method = type.GetMethod("get_useFullKinematicContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useFullKinematicContacts_32);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_useFullKinematicContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useFullKinematicContacts_33);
            args = new Type[] { };
            method = type.GetMethod("get_isKinematic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isKinematic_34);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_isKinematic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_isKinematic_35);
            args = new Type[] { };
            method = type.GetMethod("get_freezeRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_freezeRotation_36);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_freezeRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_freezeRotation_37);
            args = new Type[] { };
            method = type.GetMethod("get_constraints", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_constraints_38);
            args = new Type[] {typeof(UnityEngine.RigidbodyConstraints2D)};
            method = type.GetMethod("set_constraints", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_constraints_39);
            args = new Type[] { };
            method = type.GetMethod("IsSleeping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsSleeping_40);
            args = new Type[] { };
            method = type.GetMethod("IsAwake", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsAwake_41);
            args = new Type[] { };
            method = type.GetMethod("Sleep", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sleep_42);
            args = new Type[] { };
            method = type.GetMethod("WakeUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WakeUp_43);
            args = new Type[] { };
            method = type.GetMethod("get_simulated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_simulated_44);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_simulated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_simulated_45);
            args = new Type[] { };
            method = type.GetMethod("get_interpolation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interpolation_46);
            args = new Type[] {typeof(UnityEngine.RigidbodyInterpolation2D)};
            method = type.GetMethod("set_interpolation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_interpolation_47);
            args = new Type[] { };
            method = type.GetMethod("get_sleepMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sleepMode_48);
            args = new Type[] {typeof(UnityEngine.RigidbodySleepMode2D)};
            method = type.GetMethod("set_sleepMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sleepMode_49);
            args = new Type[] { };
            method = type.GetMethod("get_collisionDetectionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_collisionDetectionMode_50);
            args = new Type[] {typeof(UnityEngine.CollisionDetectionMode2D)};
            method = type.GetMethod("set_collisionDetectionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_collisionDetectionMode_51);
            args = new Type[] { };
            method = type.GetMethod("get_attachedColliderCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_attachedColliderCount_52);
            args = new Type[] { };
            method = type.GetMethod("get_totalForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_totalForce_53);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_totalForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_totalForce_54);
            args = new Type[] { };
            method = type.GetMethod("get_totalTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_totalTorque_55);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_totalTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_totalTorque_56);
            args = new Type[] { };
            method = type.GetMethod("get_excludeLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_excludeLayers_57);
            args = new Type[] {typeof(UnityEngine.LayerMask)};
            method = type.GetMethod("set_excludeLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_excludeLayers_58);
            args = new Type[] { };
            method = type.GetMethod("get_includeLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_includeLayers_59);
            args = new Type[] {typeof(UnityEngine.LayerMask)};
            method = type.GetMethod("set_includeLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_includeLayers_60);
            args = new Type[] {typeof(UnityEngine.Collider2D)};
            method = type.GetMethod("IsTouching", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouching_61);
            args = new Type[] {typeof(UnityEngine.Collider2D), typeof(UnityEngine.ContactFilter2D)};
            method = type.GetMethod("IsTouching", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouching_62);
            args = new Type[] {typeof(UnityEngine.ContactFilter2D)};
            method = type.GetMethod("IsTouching", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouching_63);
            args = new Type[] { };
            method = type.GetMethod("IsTouchingLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouchingLayers_64);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("IsTouchingLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouchingLayers_65);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("OverlapPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPoint_66);
            args = new Type[] {typeof(UnityEngine.Collider2D)};
            method = type.GetMethod("Distance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Distance_67);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("ClosestPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClosestPoint_68);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("AddForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddForce_69);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.ForceMode2D)};
            method = type.GetMethod("AddForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddForce_70);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("AddRelativeForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddRelativeForce_71);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.ForceMode2D)};
            method = type.GetMethod("AddRelativeForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddRelativeForce_72);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("AddForceAtPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddForceAtPosition_73);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.ForceMode2D)};
            method = type.GetMethod("AddForceAtPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddForceAtPosition_74);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("AddTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddTorque_75);
            args = new Type[] {typeof(System.Single), typeof(UnityEngine.ForceMode2D)};
            method = type.GetMethod("AddTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddTorque_76);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("GetPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPoint_77);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("GetRelativePoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRelativePoint_78);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("GetVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetVector_79);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("GetRelativeVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRelativeVector_80);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("GetPointVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPointVelocity_81);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("GetRelativePointVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRelativePointVelocity_82);
            args = new Type[] {typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("OverlapCollider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCollider_83);
            args = new Type[]
                {typeof(UnityEngine.ContactFilter2D), typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)};
            method = type.GetMethod("OverlapCollider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCollider_84);
            args = new Type[] {typeof(UnityEngine.ContactPoint2D[])};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_85);
            args = new Type[] {typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>)};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_86);
            args = new Type[] {typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.ContactPoint2D[])};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_87);
            args = new Type[]
            {
                typeof(UnityEngine.ContactFilter2D), typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>)
            };
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_88);
            args = new Type[] {typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_89);
            args = new Type[] {typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_90);
            args = new Type[] {typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_91);
            args = new Type[]
                {typeof(UnityEngine.ContactFilter2D), typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_92);
            args = new Type[] {typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("GetAttachedColliders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAttachedColliders_93);
            args = new Type[] {typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)};
            method = type.GetMethod("GetAttachedColliders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAttachedColliders_94);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[])};
            method = type.GetMethod("Cast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Cast_95);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single)};
            method = type.GetMethod("Cast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Cast_96);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>),
                typeof(System.Single)
            };
            method = type.GetMethod("Cast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Cast_97);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.RaycastHit2D[])};
            method = type.GetMethod("Cast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Cast_98);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.RaycastHit2D[]),
                typeof(System.Single)
            };
            method = type.GetMethod("Cast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Cast_99);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>), typeof(System.Single)
            };
            method = type.GetMethod("Cast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Cast_100);
            args = new Type[] {typeof(UnityEngine.PhysicsShapeGroup2D)};
            method = type.GetMethod("GetShapes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetShapes_101);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Rigidbody2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Rigidbody2D[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* get_position_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.position;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_position_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @value = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.position = value;

            return __ret;
        }

        static StackObject* get_rotation_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rotation;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_rotation_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rotation = value;

            return __ret;
        }

        static StackObject* SetRotation_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetRotation(@angle);

            return __ret;
        }

        static StackObject* SetRotation_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetRotation(@rotation);

            return __ret;
        }

        static StackObject* MovePosition_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @position = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MovePosition(@position);

            return __ret;
        }

        static StackObject* MoveRotation_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveRotation(@angle);

            return __ret;
        }

        static StackObject* MoveRotation_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveRotation(@rotation);

            return __ret;
        }

        static StackObject* get_velocity_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method =
#if UNITY_6000_0_OR_NEWER
                instance_of_this_method.linearVelocity;
#else
                instance_of_this_method.velocity;
#endif

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_velocity_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @value = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

#if UNITY_6000_0_OR_NEWER
            instance_of_this_method.linearVelocity = value;
#else
            instance_of_this_method.velocity = value;
#endif

            return __ret;
        }

        static StackObject* get_angularVelocity_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularVelocity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_angularVelocity_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularVelocity = value;

            return __ret;
        }

        static StackObject* get_useAutoMass_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useAutoMass;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useAutoMass_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useAutoMass = value;

            return __ret;
        }

        static StackObject* get_mass_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mass;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_mass_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.mass = value;

            return __ret;
        }

        static StackObject* get_sharedMaterial_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sharedMaterial;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sharedMaterial_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicsMaterial2D @value =
                (UnityEngine.PhysicsMaterial2D) typeof(UnityEngine.PhysicsMaterial2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sharedMaterial = value;

            return __ret;
        }

        static StackObject* get_centerOfMass_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.centerOfMass;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_centerOfMass_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @value = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.centerOfMass = value;

            return __ret;
        }

        static StackObject* get_worldCenterOfMass_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.worldCenterOfMass;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_inertia_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.inertia;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_inertia_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.inertia = value;

            return __ret;
        }

        static StackObject* get_drag_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method =
#if UNITY_6000_0_OR_NEWER
                instance_of_this_method.linearDamping;
#else
                instance_of_this_method.drag;
#endif
            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_drag_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);
#if UNITY_6000_0_OR_NEWER
            instance_of_this_method.linearDamping = value;
#else
            instance_of_this_method.drag = value;
#endif
            return __ret;
        }

        static StackObject* get_angularDrag_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);
#if UNITY_6000_0_OR_NEWER
            var result_of_this_method = instance_of_this_method.angularDamping;
#else
            var result_of_this_method = instance_of_this_method.angularDrag;

#endif
            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_angularDrag_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);
#if UNITY_6000_0_OR_NEWER
            instance_of_this_method.angularDamping = value;
#else
            instance_of_this_method.angularDrag = value;
#endif


            return __ret;
        }

        static StackObject* get_gravityScale_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.gravityScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_gravityScale_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.gravityScale = value;

            return __ret;
        }

        static StackObject* get_bodyType_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bodyType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_bodyType_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RigidbodyType2D @value =
                (UnityEngine.RigidbodyType2D) typeof(UnityEngine.RigidbodyType2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bodyType = value;

            return __ret;
        }

        static StackObject* get_useFullKinematicContacts_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useFullKinematicContacts;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useFullKinematicContacts_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useFullKinematicContacts = value;

            return __ret;
        }

        static StackObject* get_isKinematic_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isKinematic;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_isKinematic_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.isKinematic = value;

            return __ret;
        }

        static StackObject* get_freezeRotation_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.freezeRotation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_freezeRotation_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.freezeRotation = value;

            return __ret;
        }

        static StackObject* get_constraints_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.constraints;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_constraints_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RigidbodyConstraints2D @value =
                (UnityEngine.RigidbodyConstraints2D) typeof(UnityEngine.RigidbodyConstraints2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.constraints = value;

            return __ret;
        }

        static StackObject* IsSleeping_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsSleeping();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsAwake_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsAwake();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Sleep_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Sleep();

            return __ret;
        }

        static StackObject* WakeUp_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WakeUp();

            return __ret;
        }

        static StackObject* get_simulated_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.simulated;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_simulated_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.simulated = value;

            return __ret;
        }

        static StackObject* get_interpolation_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interpolation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_interpolation_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RigidbodyInterpolation2D @value =
                (UnityEngine.RigidbodyInterpolation2D) typeof(UnityEngine.RigidbodyInterpolation2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interpolation = value;

            return __ret;
        }

        static StackObject* get_sleepMode_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sleepMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sleepMode_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RigidbodySleepMode2D @value =
                (UnityEngine.RigidbodySleepMode2D) typeof(UnityEngine.RigidbodySleepMode2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sleepMode = value;

            return __ret;
        }

        static StackObject* get_collisionDetectionMode_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.collisionDetectionMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_collisionDetectionMode_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CollisionDetectionMode2D @value =
                (UnityEngine.CollisionDetectionMode2D) typeof(UnityEngine.CollisionDetectionMode2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.collisionDetectionMode = value;

            return __ret;
        }

        static StackObject* get_attachedColliderCount_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.attachedColliderCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_totalForce_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.totalForce;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_totalForce_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @value = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.totalForce = value;

            return __ret;
        }

        static StackObject* get_totalTorque_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.totalTorque;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_totalTorque_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.totalTorque = value;

            return __ret;
        }

        static StackObject* get_excludeLayers_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.excludeLayers;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_excludeLayers_58(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LayerMask @value = (UnityEngine.LayerMask) typeof(UnityEngine.LayerMask).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.excludeLayers = value;

            return __ret;
        }

        static StackObject* get_includeLayers_59(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.includeLayers;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_includeLayers_60(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LayerMask @value = (UnityEngine.LayerMask) typeof(UnityEngine.LayerMask).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.includeLayers = value;

            return __ret;
        }

        static StackObject* IsTouching_61(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsTouching(@collider);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsTouching_62(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ContactFilter2D @contactFilter =
                (UnityEngine.ContactFilter2D) typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsTouching(@collider, @contactFilter);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsTouching_63(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ContactFilter2D @contactFilter =
                (UnityEngine.ContactFilter2D) typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsTouching(@contactFilter);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsTouchingLayers_64(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsTouchingLayers();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsTouchingLayers_65(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsTouchingLayers(@layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* OverlapPoint_66(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.OverlapPoint(@point);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Distance_67(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Distance(@collider);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ClosestPoint_68(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @position = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ClosestPoint(@position);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AddForce_69(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @force = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddForce(@force);

            return __ret;
        }

        static StackObject* AddForce_70(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ForceMode2D @mode = (UnityEngine.ForceMode2D) typeof(UnityEngine.ForceMode2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @force = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddForce(@force, @mode);

            return __ret;
        }

        static StackObject* AddRelativeForce_71(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @relativeForce = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddRelativeForce(@relativeForce);

            return __ret;
        }

        static StackObject* AddRelativeForce_72(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ForceMode2D @mode = (UnityEngine.ForceMode2D) typeof(UnityEngine.ForceMode2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @relativeForce = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddRelativeForce(@relativeForce, @mode);

            return __ret;
        }

        static StackObject* AddForceAtPosition_73(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @position = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @force = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddForceAtPosition(@force, @position);

            return __ret;
        }

        static StackObject* AddForceAtPosition_74(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ForceMode2D @mode = (UnityEngine.ForceMode2D) typeof(UnityEngine.ForceMode2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @position = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @force = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddForceAtPosition(@force, @position, @mode);

            return __ret;
        }

        static StackObject* AddTorque_75(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @torque = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddTorque(@torque);

            return __ret;
        }

        static StackObject* AddTorque_76(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ForceMode2D @mode = (UnityEngine.ForceMode2D) typeof(UnityEngine.ForceMode2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @torque = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddTorque(@torque, @mode);

            return __ret;
        }

        static StackObject* GetPoint_77(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPoint(@point);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRelativePoint_78(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @relativePoint = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetRelativePoint(@relativePoint);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetVector_79(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @vector = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetVector(@vector);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRelativeVector_80(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @relativeVector = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetRelativeVector(@relativeVector);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPointVelocity_81(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPointVelocity(@point);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRelativePointVelocity_82(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @relativePoint = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetRelativePointVelocity(@relativePoint);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCollider_83(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ContactFilter2D @contactFilter =
                (UnityEngine.ContactFilter2D) typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method =

#if UNITY_6000_0_OR_NEWER
                instance_of_this_method.Overlap(@contactFilter, @results);
#else
                instance_of_this_method.OverlapCollider(@contactFilter, @results);
#endif


            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCollider_84(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Collider2D> @results =
                (System.Collections.Generic.List<UnityEngine.Collider2D>)
                typeof(System.Collections.Generic.List<UnityEngine.Collider2D>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ContactFilter2D @contactFilter =
                (UnityEngine.ContactFilter2D) typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method =

#if UNITY_6000_0_OR_NEWER
                instance_of_this_method.Overlap(@contactFilter, @results);
#else
                instance_of_this_method.OverlapCollider(@contactFilter, @results);
#endif


            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_85(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ContactPoint2D[] @contacts =
                (UnityEngine.ContactPoint2D[]) typeof(UnityEngine.ContactPoint2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetContacts(@contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_86(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.ContactPoint2D> @contacts =
                (System.Collections.Generic.List<UnityEngine.ContactPoint2D>)
                typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetContacts(@contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_87(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ContactPoint2D[] @contacts =
                (UnityEngine.ContactPoint2D[]) typeof(UnityEngine.ContactPoint2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ContactFilter2D @contactFilter =
                (UnityEngine.ContactFilter2D) typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetContacts(@contactFilter, @contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_88(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.ContactPoint2D> @contacts =
                (System.Collections.Generic.List<UnityEngine.ContactPoint2D>)
                typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ContactFilter2D @contactFilter =
                (UnityEngine.ContactFilter2D) typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetContacts(@contactFilter, @contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_89(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D[] @colliders =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetContacts(@colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_90(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Collider2D> @colliders =
                (System.Collections.Generic.List<UnityEngine.Collider2D>)
                typeof(System.Collections.Generic.List<UnityEngine.Collider2D>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetContacts(@colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_91(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D[] @colliders =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ContactFilter2D @contactFilter =
                (UnityEngine.ContactFilter2D) typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetContacts(@contactFilter, @colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_92(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Collider2D> @colliders =
                (System.Collections.Generic.List<UnityEngine.Collider2D>)
                typeof(System.Collections.Generic.List<UnityEngine.Collider2D>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ContactFilter2D @contactFilter =
                (UnityEngine.ContactFilter2D) typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetContacts(@contactFilter, @colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetAttachedColliders_93(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAttachedColliders(@results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetAttachedColliders_94(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Collider2D> @results =
                (System.Collections.Generic.List<UnityEngine.Collider2D>)
                typeof(System.Collections.Generic.List<UnityEngine.Collider2D>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAttachedColliders(@results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Cast_95(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Cast(@direction, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Cast_96(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Cast(@direction, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Cast_97(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.RaycastHit2D> @results =
                (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)
                typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Cast(@direction, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Cast_98(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ContactFilter2D @contactFilter =
                (UnityEngine.ContactFilter2D) typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Cast(@direction, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Cast_99(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ContactFilter2D @contactFilter =
                (UnityEngine.ContactFilter2D) typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Cast(@direction, @contactFilter, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Cast_100(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.RaycastHit2D> @results =
                (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)
                typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ContactFilter2D @contactFilter =
                (UnityEngine.ContactFilter2D) typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Cast(@direction, @contactFilter, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetShapes_101(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicsShapeGroup2D @physicsShapeGroup =
                (UnityEngine.PhysicsShapeGroup2D) typeof(UnityEngine.PhysicsShapeGroup2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetShapes(@physicsShapeGroup);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Rigidbody2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}