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
    unsafe class UnityEngine_Physics2D_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Physics2D);
            args = new Type[] { };
            method = type.GetMethod("get_defaultPhysicsScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultPhysicsScene_0);
            args = new Type[] { };
            method = type.GetMethod("get_velocityIterations", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_velocityIterations_1);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("set_velocityIterations", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_velocityIterations_2);
            args = new Type[] { };
            method = type.GetMethod("get_positionIterations", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_positionIterations_3);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("set_positionIterations", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_positionIterations_4);
            args = new Type[] { };
            method = type.GetMethod("get_gravity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_gravity_5);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_gravity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_gravity_6);
            args = new Type[] { };
            method = type.GetMethod("get_queriesHitTriggers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_queriesHitTriggers_7);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_queriesHitTriggers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_queriesHitTriggers_8);
            args = new Type[] { };
            method = type.GetMethod("get_queriesStartInColliders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_queriesStartInColliders_9);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_queriesStartInColliders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_queriesStartInColliders_10);
            args = new Type[] { };
            method = type.GetMethod("get_callbacksOnDisable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_callbacksOnDisable_11);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_callbacksOnDisable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_callbacksOnDisable_12);
            args = new Type[] { };
            method = type.GetMethod("get_reuseCollisionCallbacks", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reuseCollisionCallbacks_13);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_reuseCollisionCallbacks", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reuseCollisionCallbacks_14);
            args = new Type[] { };
            method = type.GetMethod("get_autoSyncTransforms", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autoSyncTransforms_15);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_autoSyncTransforms", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_autoSyncTransforms_16);
            args = new Type[] { };
            method = type.GetMethod("get_simulationMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_simulationMode_17);
            args = new Type[] {typeof(UnityEngine.SimulationMode2D)};
            method = type.GetMethod("set_simulationMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_simulationMode_18);
            args = new Type[] { };
            method = type.GetMethod("get_jobOptions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_jobOptions_19);
            args = new Type[] {typeof(UnityEngine.PhysicsJobOptions2D)};
            method = type.GetMethod("set_jobOptions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_jobOptions_20);
            args = new Type[] { };
            method = type.GetMethod("get_velocityThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_velocityThreshold_21);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_velocityThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_velocityThreshold_22);
            args = new Type[] { };
            method = type.GetMethod("get_maxLinearCorrection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxLinearCorrection_23);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_maxLinearCorrection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxLinearCorrection_24);
            args = new Type[] { };
            method = type.GetMethod("get_maxAngularCorrection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxAngularCorrection_25);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_maxAngularCorrection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxAngularCorrection_26);
            args = new Type[] { };
            method = type.GetMethod("get_maxTranslationSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxTranslationSpeed_27);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_maxTranslationSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxTranslationSpeed_28);
            args = new Type[] { };
            method = type.GetMethod("get_maxRotationSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxRotationSpeed_29);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_maxRotationSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxRotationSpeed_30);
            args = new Type[] { };
            method = type.GetMethod("get_defaultContactOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultContactOffset_31);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_defaultContactOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultContactOffset_32);
            args = new Type[] { };
            method = type.GetMethod("get_baumgarteScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_baumgarteScale_33);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_baumgarteScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_baumgarteScale_34);
            args = new Type[] { };
            method = type.GetMethod("get_baumgarteTOIScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_baumgarteTOIScale_35);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_baumgarteTOIScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_baumgarteTOIScale_36);
            args = new Type[] { };
            method = type.GetMethod("get_timeToSleep", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_timeToSleep_37);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_timeToSleep", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_timeToSleep_38);
            args = new Type[] { };
            method = type.GetMethod("get_linearSleepTolerance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_linearSleepTolerance_39);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_linearSleepTolerance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_linearSleepTolerance_40);
            args = new Type[] { };
            method = type.GetMethod("get_angularSleepTolerance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularSleepTolerance_41);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_angularSleepTolerance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularSleepTolerance_42);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("Simulate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Simulate_43);
            args = new Type[] { };
            method = type.GetMethod("SyncTransforms", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SyncTransforms_44);
            args = new Type[] {typeof(UnityEngine.Collider2D), typeof(UnityEngine.Collider2D)};
            method = type.GetMethod("IgnoreCollision", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IgnoreCollision_45);
            args = new Type[] {typeof(UnityEngine.Collider2D), typeof(UnityEngine.Collider2D), typeof(System.Boolean)};
            method = type.GetMethod("IgnoreCollision", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IgnoreCollision_46);
            args = new Type[] {typeof(UnityEngine.Collider2D), typeof(UnityEngine.Collider2D)};
            method = type.GetMethod("GetIgnoreCollision", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetIgnoreCollision_47);
            args = new Type[] {typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("IgnoreLayerCollision", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IgnoreLayerCollision_48);
            args = new Type[] {typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("IgnoreLayerCollision", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IgnoreLayerCollision_49);
            args = new Type[] {typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("GetIgnoreLayerCollision", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetIgnoreLayerCollision_50);
            args = new Type[] {typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetLayerCollisionMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLayerCollisionMask_51);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("GetLayerCollisionMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLayerCollisionMask_52);
            args = new Type[] {typeof(UnityEngine.Collider2D), typeof(UnityEngine.Collider2D)};
            method = type.GetMethod("IsTouching", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouching_53);
            args = new Type[]
                {typeof(UnityEngine.Collider2D), typeof(UnityEngine.Collider2D), typeof(UnityEngine.ContactFilter2D)};
            method = type.GetMethod("IsTouching", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouching_54);
            args = new Type[] {typeof(UnityEngine.Collider2D), typeof(UnityEngine.ContactFilter2D)};
            method = type.GetMethod("IsTouching", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouching_55);
            args = new Type[] {typeof(UnityEngine.Collider2D)};
            method = type.GetMethod("IsTouchingLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouchingLayers_56);
            args = new Type[] {typeof(UnityEngine.Collider2D), typeof(System.Int32)};
            method = type.GetMethod("IsTouchingLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouchingLayers_57);
            args = new Type[] {typeof(UnityEngine.Collider2D), typeof(UnityEngine.Collider2D)};
            method = type.GetMethod("Distance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Distance_58);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Collider2D)};
            method = type.GetMethod("ClosestPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClosestPoint_59);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Rigidbody2D)};
            method = type.GetMethod("ClosestPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClosestPoint_60);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("Linecast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Linecast_61);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32)};
            method = type.GetMethod("Linecast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Linecast_62);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("Linecast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Linecast_63);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Single),
                typeof(System.Single)
            };
            method = type.GetMethod("Linecast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Linecast_64);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D),
                typeof(UnityEngine.RaycastHit2D[])
            };
            method = type.GetMethod("Linecast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Linecast_65);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>)
            };
            method = type.GetMethod("Linecast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Linecast_66);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("LinecastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LinecastAll_67);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32)};
            method = type.GetMethod("LinecastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LinecastAll_68);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("LinecastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LinecastAll_69);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Single),
                typeof(System.Single)
            };
            method = type.GetMethod("LinecastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LinecastAll_70);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[])};
            method = type.GetMethod("LinecastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LinecastNonAlloc_71);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]),
                typeof(System.Int32)
            };
            method = type.GetMethod("LinecastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LinecastNonAlloc_72);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]),
                typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("LinecastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LinecastNonAlloc_73);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]),
                typeof(System.Int32), typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("LinecastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LinecastNonAlloc_74);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_75);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single)};
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_76);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_77);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32),
                typeof(System.Single)
            };
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_78);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32),
                typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_79);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D),
                typeof(UnityEngine.RaycastHit2D[])
            };
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_80);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D),
                typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single)
            };
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_81);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>), typeof(System.Single)
            };
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_82);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[])};
            method = type.GetMethod("RaycastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RaycastNonAlloc_83);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]),
                typeof(System.Single)
            };
            method = type.GetMethod("RaycastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RaycastNonAlloc_84);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]),
                typeof(System.Single), typeof(System.Int32)
            };
            method = type.GetMethod("RaycastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RaycastNonAlloc_85);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]),
                typeof(System.Single), typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("RaycastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RaycastNonAlloc_86);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]),
                typeof(System.Single), typeof(System.Int32), typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("RaycastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RaycastNonAlloc_87);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("RaycastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RaycastAll_88);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single)};
            method = type.GetMethod("RaycastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RaycastAll_89);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("RaycastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RaycastAll_90);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32),
                typeof(System.Single)
            };
            method = type.GetMethod("RaycastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RaycastAll_91);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32),
                typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("RaycastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RaycastAll_92);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("CircleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCast_93);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single)
            };
            method = type.GetMethod("CircleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCast_94);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(System.Int32)
            };
            method = type.GetMethod("CircleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCast_95);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("CircleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCast_96);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(System.Int32), typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("CircleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCast_97);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2),
                typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.RaycastHit2D[])
            };
            method = type.GetMethod("CircleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCast_98);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2),
                typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single)
            };
            method = type.GetMethod("CircleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCast_99);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2),
                typeof(UnityEngine.ContactFilter2D), typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>),
                typeof(System.Single)
            };
            method = type.GetMethod("CircleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCast_100);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("CircleCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCastAll_101);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single)
            };
            method = type.GetMethod("CircleCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCastAll_102);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(System.Int32)
            };
            method = type.GetMethod("CircleCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCastAll_103);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("CircleCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCastAll_104);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(System.Int32), typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("CircleCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCastAll_105);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2),
                typeof(UnityEngine.RaycastHit2D[])
            };
            method = type.GetMethod("CircleCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCastNonAlloc_106);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2),
                typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single)
            };
            method = type.GetMethod("CircleCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCastNonAlloc_107);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2),
                typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single), typeof(System.Int32)
            };
            method = type.GetMethod("CircleCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCastNonAlloc_108);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2),
                typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single), typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("CircleCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCastNonAlloc_109);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Vector2),
                typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single), typeof(System.Int32), typeof(System.Single),
                typeof(System.Single)
            };
            method = type.GetMethod("CircleCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CircleCastNonAlloc_110);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2)
            };
            method = type.GetMethod("BoxCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCast_111);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(System.Single)
            };
            method = type.GetMethod("BoxCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCast_112);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32)
            };
            method = type.GetMethod("BoxCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCast_113);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("BoxCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCast_114);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32), typeof(System.Single),
                typeof(System.Single)
            };
            method = type.GetMethod("BoxCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCast_115);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.RaycastHit2D[])
            };
            method = type.GetMethod("BoxCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCast_116);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.RaycastHit2D[]),
                typeof(System.Single)
            };
            method = type.GetMethod("BoxCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCast_117);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>), typeof(System.Single)
            };
            method = type.GetMethod("BoxCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCast_118);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2)
            };
            method = type.GetMethod("BoxCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCastAll_119);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(System.Single)
            };
            method = type.GetMethod("BoxCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCastAll_120);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32)
            };
            method = type.GetMethod("BoxCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCastAll_121);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("BoxCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCastAll_122);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32), typeof(System.Single),
                typeof(System.Single)
            };
            method = type.GetMethod("BoxCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCastAll_123);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[])
            };
            method = type.GetMethod("BoxCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCastNonAlloc_124);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single)
            };
            method = type.GetMethod("BoxCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCastNonAlloc_125);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single),
                typeof(System.Int32)
            };
            method = type.GetMethod("BoxCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCastNonAlloc_126);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single),
                typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("BoxCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCastNonAlloc_127);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single),
                typeof(System.Int32), typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("BoxCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxCastNonAlloc_128);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2)
            };
            method = type.GetMethod("CapsuleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCast_129);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single)
            };
            method = type.GetMethod("CapsuleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCast_130);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32)
            };
            method = type.GetMethod("CapsuleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCast_131);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32),
                typeof(System.Single)
            };
            method = type.GetMethod("CapsuleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCast_132);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32),
                typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("CapsuleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCast_133);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D),
                typeof(UnityEngine.RaycastHit2D[])
            };
            method = type.GetMethod("CapsuleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCast_134);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D),
                typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single)
            };
            method = type.GetMethod("CapsuleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCast_135);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>), typeof(System.Single)
            };
            method = type.GetMethod("CapsuleCast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCast_136);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2)
            };
            method = type.GetMethod("CapsuleCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCastAll_137);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single)
            };
            method = type.GetMethod("CapsuleCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCastAll_138);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32)
            };
            method = type.GetMethod("CapsuleCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCastAll_139);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32),
                typeof(System.Single)
            };
            method = type.GetMethod("CapsuleCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCastAll_140);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32),
                typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("CapsuleCastAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCastAll_141);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[])
            };
            method = type.GetMethod("CapsuleCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCastNonAlloc_142);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]),
                typeof(System.Single)
            };
            method = type.GetMethod("CapsuleCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCastNonAlloc_143);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]),
                typeof(System.Single), typeof(System.Int32)
            };
            method = type.GetMethod("CapsuleCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCastNonAlloc_144);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]),
                typeof(System.Single), typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("CapsuleCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCastNonAlloc_145);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]),
                typeof(System.Single), typeof(System.Int32), typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("CapsuleCastNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CapsuleCastNonAlloc_146);
            args = new Type[] {typeof(UnityEngine.Ray)};
            method = type.GetMethod("GetRayIntersection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRayIntersection_147);
            args = new Type[] {typeof(UnityEngine.Ray), typeof(System.Single)};
            method = type.GetMethod("GetRayIntersection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRayIntersection_148);
            args = new Type[] {typeof(UnityEngine.Ray), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("GetRayIntersection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRayIntersection_149);
            args = new Type[] {typeof(UnityEngine.Ray)};
            method = type.GetMethod("GetRayIntersectionAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRayIntersectionAll_150);
            args = new Type[] {typeof(UnityEngine.Ray), typeof(System.Single)};
            method = type.GetMethod("GetRayIntersectionAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRayIntersectionAll_151);
            args = new Type[] {typeof(UnityEngine.Ray), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("GetRayIntersectionAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRayIntersectionAll_152);
            args = new Type[] {typeof(UnityEngine.Ray), typeof(UnityEngine.RaycastHit2D[])};
            method = type.GetMethod("GetRayIntersectionNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRayIntersectionNonAlloc_153);
            args = new Type[] {typeof(UnityEngine.Ray), typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single)};
            method = type.GetMethod("GetRayIntersectionNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRayIntersectionNonAlloc_154);
            args = new Type[]
            {
                typeof(UnityEngine.Ray), typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single), typeof(System.Int32)
            };
            method = type.GetMethod("GetRayIntersectionNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRayIntersectionNonAlloc_155);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("OverlapPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPoint_156);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(System.Int32)};
            method = type.GetMethod("OverlapPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPoint_157);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("OverlapPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPoint_158);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("OverlapPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPoint_159);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("OverlapPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPoint_160);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)
            };
            method = type.GetMethod("OverlapPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPoint_161);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("OverlapPointAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPointAll_162);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(System.Int32)};
            method = type.GetMethod("OverlapPointAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPointAll_163);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("OverlapPointAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPointAll_164);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("OverlapPointAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPointAll_165);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("OverlapPointNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPointNonAlloc_166);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Collider2D[]), typeof(System.Int32)};
            method = type.GetMethod("OverlapPointNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPointNonAlloc_167);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Collider2D[]), typeof(System.Int32),
                typeof(System.Single)
            };
            method = type.GetMethod("OverlapPointNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPointNonAlloc_168);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Collider2D[]), typeof(System.Int32),
                typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("OverlapPointNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPointNonAlloc_169);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(System.Single)};
            method = type.GetMethod("OverlapCircle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircle_170);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("OverlapCircle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircle_171);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("OverlapCircle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircle_172);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32), typeof(System.Single),
                typeof(System.Single)
            };
            method = type.GetMethod("OverlapCircle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircle_173);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.ContactFilter2D),
                typeof(UnityEngine.Collider2D[])
            };
            method = type.GetMethod("OverlapCircle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircle_174);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)
            };
            method = type.GetMethod("OverlapCircle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircle_175);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(System.Single)};
            method = type.GetMethod("OverlapCircleAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircleAll_176);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("OverlapCircleAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircleAll_177);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("OverlapCircleAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircleAll_178);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32), typeof(System.Single),
                typeof(System.Single)
            };
            method = type.GetMethod("OverlapCircleAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircleAll_179);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("OverlapCircleNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircleNonAlloc_180);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Collider2D[]),
                typeof(System.Int32)
            };
            method = type.GetMethod("OverlapCircleNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircleNonAlloc_181);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Collider2D[]),
                typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("OverlapCircleNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircleNonAlloc_182);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Collider2D[]),
                typeof(System.Int32), typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("OverlapCircleNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCircleNonAlloc_183);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single)};
            method = type.GetMethod("OverlapBox", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBox_184);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("OverlapBox", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBox_185);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32),
                typeof(System.Single)
            };
            method = type.GetMethod("OverlapBox", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBox_186);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32),
                typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("OverlapBox", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBox_187);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.Collider2D[])
            };
            method = type.GetMethod("OverlapBox", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBox_188);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.ContactFilter2D), typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)
            };
            method = type.GetMethod("OverlapBox", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBox_189);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single)};
            method = type.GetMethod("OverlapBoxAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBoxAll_190);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("OverlapBoxAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBoxAll_191);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32),
                typeof(System.Single)
            };
            method = type.GetMethod("OverlapBoxAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBoxAll_192);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32),
                typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("OverlapBoxAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBoxAll_193);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Collider2D[])
            };
            method = type.GetMethod("OverlapBoxNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBoxNonAlloc_194);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Collider2D[]), typeof(System.Int32)
            };
            method = type.GetMethod("OverlapBoxNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBoxNonAlloc_195);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Collider2D[]), typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("OverlapBoxNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBoxNonAlloc_196);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single),
                typeof(UnityEngine.Collider2D[]), typeof(System.Int32), typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("OverlapBoxNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapBoxNonAlloc_197);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("OverlapArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapArea_198);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32)};
            method = type.GetMethod("OverlapArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapArea_199);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("OverlapArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapArea_200);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Single),
                typeof(System.Single)
            };
            method = type.GetMethod("OverlapArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapArea_201);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D),
                typeof(UnityEngine.Collider2D[])
            };
            method = type.GetMethod("OverlapArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapArea_202);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)
            };
            method = type.GetMethod("OverlapArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapArea_203);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("OverlapAreaAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapAreaAll_204);
            args = new Type[] {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32)};
            method = type.GetMethod("OverlapAreaAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapAreaAll_205);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("OverlapAreaAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapAreaAll_206);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Single),
                typeof(System.Single)
            };
            method = type.GetMethod("OverlapAreaAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapAreaAll_207);
            args = new Type[]
                {typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("OverlapAreaNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapAreaNonAlloc_208);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Collider2D[]),
                typeof(System.Int32)
            };
            method = type.GetMethod("OverlapAreaNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapAreaNonAlloc_209);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Collider2D[]),
                typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("OverlapAreaNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapAreaNonAlloc_210);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Collider2D[]),
                typeof(System.Int32), typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("OverlapAreaNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapAreaNonAlloc_211);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single)
            };
            method = type.GetMethod("OverlapCapsule", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsule_212);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(System.Int32)
            };
            method = type.GetMethod("OverlapCapsule", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsule_213);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("OverlapCapsule", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsule_214);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(System.Int32), typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("OverlapCapsule", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsule_215);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.Collider2D[])
            };
            method = type.GetMethod("OverlapCapsule", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsule_216);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)
            };
            method = type.GetMethod("OverlapCapsule", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsule_217);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single)
            };
            method = type.GetMethod("OverlapCapsuleAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsuleAll_218);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(System.Int32)
            };
            method = type.GetMethod("OverlapCapsuleAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsuleAll_219);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("OverlapCapsuleAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsuleAll_220);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(System.Int32), typeof(System.Single), typeof(System.Single)
            };
            method = type.GetMethod("OverlapCapsuleAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsuleAll_221);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Collider2D[])
            };
            method = type.GetMethod("OverlapCapsuleNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsuleNonAlloc_222);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Collider2D[]), typeof(System.Int32)
            };
            method = type.GetMethod("OverlapCapsuleNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsuleNonAlloc_223);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Collider2D[]), typeof(System.Int32), typeof(System.Single)
            };
            method = type.GetMethod("OverlapCapsuleNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsuleNonAlloc_224);
            args = new Type[]
            {
                typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.CapsuleDirection2D),
                typeof(System.Single), typeof(UnityEngine.Collider2D[]), typeof(System.Int32), typeof(System.Single),
                typeof(System.Single)
            };
            method = type.GetMethod("OverlapCapsuleNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCapsuleNonAlloc_225);
            args = new Type[]
                {typeof(UnityEngine.Collider2D), typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("OverlapCollider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCollider_226);
            args = new Type[]
            {
                typeof(UnityEngine.Collider2D), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)
            };
            method = type.GetMethod("OverlapCollider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCollider_227);
            args = new Type[]
            {
                typeof(UnityEngine.Collider2D), typeof(UnityEngine.Collider2D), typeof(UnityEngine.ContactFilter2D),
                typeof(UnityEngine.ContactPoint2D[])
            };
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_228);
            args = new Type[] {typeof(UnityEngine.Collider2D), typeof(UnityEngine.ContactPoint2D[])};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_229);
            args = new Type[]
            {
                typeof(UnityEngine.Collider2D), typeof(UnityEngine.ContactFilter2D),
                typeof(UnityEngine.ContactPoint2D[])
            };
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_230);
            args = new Type[] {typeof(UnityEngine.Collider2D), typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_231);
            args = new Type[]
                {typeof(UnityEngine.Collider2D), typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_232);
            args = new Type[] {typeof(UnityEngine.Rigidbody2D), typeof(UnityEngine.ContactPoint2D[])};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_233);
            args = new Type[]
            {
                typeof(UnityEngine.Rigidbody2D), typeof(UnityEngine.ContactFilter2D),
                typeof(UnityEngine.ContactPoint2D[])
            };
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_234);
            args = new Type[] {typeof(UnityEngine.Rigidbody2D), typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_235);
            args = new Type[]
            {
                typeof(UnityEngine.Rigidbody2D), typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.Collider2D[])
            };
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_236);
            args = new Type[]
            {
                typeof(UnityEngine.Collider2D), typeof(UnityEngine.Collider2D), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>)
            };
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_237);
            args = new Type[]
                {typeof(UnityEngine.Collider2D), typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>)};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_238);
            args = new Type[]
            {
                typeof(UnityEngine.Collider2D), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>)
            };
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_239);
            args = new Type[]
                {typeof(UnityEngine.Collider2D), typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_240);
            args = new Type[]
            {
                typeof(UnityEngine.Collider2D), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)
            };
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_241);
            args = new Type[]
                {typeof(UnityEngine.Rigidbody2D), typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>)};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_242);
            args = new Type[]
            {
                typeof(UnityEngine.Rigidbody2D), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>)
            };
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_243);
            args = new Type[]
                {typeof(UnityEngine.Rigidbody2D), typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_244);
            args = new Type[]
            {
                typeof(UnityEngine.Rigidbody2D), typeof(UnityEngine.ContactFilter2D),
                typeof(System.Collections.Generic.List<UnityEngine.Collider2D>)
            };
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_245);

            field = type.GetField("IgnoreRaycastLayer", flag);
            app.RegisterCLRFieldGetter(field, get_IgnoreRaycastLayer_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_IgnoreRaycastLayer_0, null);
            field = type.GetField("DefaultRaycastLayers", flag);
            app.RegisterCLRFieldGetter(field, get_DefaultRaycastLayers_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_DefaultRaycastLayers_1, null);
            field = type.GetField("AllLayers", flag);
            app.RegisterCLRFieldGetter(field, get_AllLayers_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_AllLayers_2, null);
            field = type.GetField("MaxPolygonShapeVertices", flag);
            app.RegisterCLRFieldGetter(field, get_MaxPolygonShapeVertices_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxPolygonShapeVertices_3, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Physics2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Physics2D[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* get_defaultPhysicsScene_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.defaultPhysicsScene;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_velocityIterations_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.velocityIterations;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_velocityIterations_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.Physics2D.velocityIterations = value;

            return __ret;
        }

        static StackObject* get_positionIterations_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.positionIterations;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_positionIterations_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.Physics2D.positionIterations = value;

            return __ret;
        }

        static StackObject* get_gravity_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.gravity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_gravity_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @value = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Physics2D.gravity = value;

            return __ret;
        }

        static StackObject* get_queriesHitTriggers_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.queriesHitTriggers;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_queriesHitTriggers_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Physics2D.queriesHitTriggers = value;

            return __ret;
        }

        static StackObject* get_queriesStartInColliders_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.queriesStartInColliders;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_queriesStartInColliders_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Physics2D.queriesStartInColliders = value;

            return __ret;
        }

        static StackObject* get_callbacksOnDisable_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.callbacksOnDisable;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_callbacksOnDisable_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Physics2D.callbacksOnDisable = value;

            return __ret;
        }

        static StackObject* get_reuseCollisionCallbacks_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.reuseCollisionCallbacks;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_reuseCollisionCallbacks_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Physics2D.reuseCollisionCallbacks = value;

            return __ret;
        }

        static StackObject* get_autoSyncTransforms_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.autoSyncTransforms;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_autoSyncTransforms_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Physics2D.autoSyncTransforms = value;

            return __ret;
        }

        static StackObject* get_simulationMode_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.simulationMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_simulationMode_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SimulationMode2D @value =
                (UnityEngine.SimulationMode2D) typeof(UnityEngine.SimulationMode2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Physics2D.simulationMode = value;

            return __ret;
        }

        static StackObject* get_jobOptions_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.jobOptions;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_jobOptions_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicsJobOptions2D @value =
                (UnityEngine.PhysicsJobOptions2D) typeof(UnityEngine.PhysicsJobOptions2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Physics2D.jobOptions = value;

            return __ret;
        }

        static StackObject* get_velocityThreshold_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method =
#if UNITY_6000_0_OR_NEWER
                UnityEngine.Physics2D.bounceThreshold;
#else
                UnityEngine.Physics2D.velocityThreshold;
#endif
            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_velocityThreshold_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

#if UNITY_6000_0_OR_NEWER
            UnityEngine.Physics2D.bounceThreshold = value;
#else
            UnityEngine.Physics2D.velocityThreshold = value;
#endif


            return __ret;
        }

        static StackObject* get_maxLinearCorrection_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.maxLinearCorrection;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxLinearCorrection_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;


            UnityEngine.Physics2D.maxLinearCorrection = value;

            return __ret;
        }

        static StackObject* get_maxAngularCorrection_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.maxAngularCorrection;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxAngularCorrection_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;


            UnityEngine.Physics2D.maxAngularCorrection = value;

            return __ret;
        }

        static StackObject* get_maxTranslationSpeed_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.maxTranslationSpeed;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxTranslationSpeed_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;


            UnityEngine.Physics2D.maxTranslationSpeed = value;

            return __ret;
        }

        static StackObject* get_maxRotationSpeed_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.maxRotationSpeed;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxRotationSpeed_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;


            UnityEngine.Physics2D.maxRotationSpeed = value;

            return __ret;
        }

        static StackObject* get_defaultContactOffset_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.defaultContactOffset;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_defaultContactOffset_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;


            UnityEngine.Physics2D.defaultContactOffset = value;

            return __ret;
        }

        static StackObject* get_baumgarteScale_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.baumgarteScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_baumgarteScale_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;


            UnityEngine.Physics2D.baumgarteScale = value;

            return __ret;
        }

        static StackObject* get_baumgarteTOIScale_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.baumgarteTOIScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_baumgarteTOIScale_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;


            UnityEngine.Physics2D.baumgarteTOIScale = value;

            return __ret;
        }

        static StackObject* get_timeToSleep_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.timeToSleep;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_timeToSleep_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;


            UnityEngine.Physics2D.timeToSleep = value;

            return __ret;
        }

        static StackObject* get_linearSleepTolerance_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.linearSleepTolerance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_linearSleepTolerance_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;


            UnityEngine.Physics2D.linearSleepTolerance = value;

            return __ret;
        }

        static StackObject* get_angularSleepTolerance_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Physics2D.angularSleepTolerance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_angularSleepTolerance_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;


            UnityEngine.Physics2D.angularSleepTolerance = value;

            return __ret;
        }

        static StackObject* Simulate_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @step = *(float*) &ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Physics2D.Simulate(@step);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SyncTransforms_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.Physics2D.SyncTransforms();

            return __ret;
        }

        static StackObject* IgnoreCollision_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D @collider2 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider2D @collider1 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Physics2D.IgnoreCollision(@collider1, @collider2);

            return __ret;
        }

        static StackObject* IgnoreCollision_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ignore = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider2D @collider2 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Collider2D @collider1 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Physics2D.IgnoreCollision(@collider1, @collider2, @ignore);

            return __ret;
        }

        static StackObject* GetIgnoreCollision_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D @collider2 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider2D @collider1 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetIgnoreCollision(@collider1, @collider2);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IgnoreLayerCollision_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer2 = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layer1 = ptr_of_this_method->Value;


            UnityEngine.Physics2D.IgnoreLayerCollision(@layer1, @layer2);

            return __ret;
        }

        static StackObject* IgnoreLayerCollision_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ignore = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layer2 = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layer1 = ptr_of_this_method->Value;


            UnityEngine.Physics2D.IgnoreLayerCollision(@layer1, @layer2, @ignore);

            return __ret;
        }

        static StackObject* GetIgnoreLayerCollision_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer2 = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layer1 = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Physics2D.GetIgnoreLayerCollision(@layer1, @layer2);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetLayerCollisionMask_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layer = ptr_of_this_method->Value;


            UnityEngine.Physics2D.SetLayerCollisionMask(@layer, @layerMask);

            return __ret;
        }

        static StackObject* GetLayerCollisionMask_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Physics2D.GetLayerCollisionMask(@layer);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* IsTouching_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D @collider2 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider2D @collider1 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.IsTouching(@collider1, @collider2);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsTouching_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Collider2D @collider2 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Collider2D @collider1 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.IsTouching(@collider1, @collider2, @contactFilter);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsTouching_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.IsTouching(@collider, @contactFilter);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsTouchingLayers_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.IsTouchingLayers(@collider);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsTouchingLayers_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.IsTouchingLayers(@collider, @layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Distance_58(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D @colliderB = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider2D @colliderA = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.Distance(@colliderA, @colliderB);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ClosestPoint_59(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Vector2 @position = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.ClosestPoint(@position, @collider);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ClosestPoint_60(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D @rigidbody =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @position = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.ClosestPoint(@position, @rigidbody);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Linecast_61(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.Linecast(@start, @end);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Linecast_62(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.Linecast(@start, @end, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Linecast_63(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.Linecast(@start, @end, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Linecast_64(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.Linecast(@start, @end, @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Linecast_65(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
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
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.Linecast(@start, @end, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Linecast_66(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.RaycastHit2D> @results =
                (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)
                typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ContactFilter2D @contactFilter =
                (UnityEngine.ContactFilter2D) typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.Linecast(@start, @end, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* LinecastAll_67(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.LinecastAll(@start, @end);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LinecastAll_68(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.LinecastAll(@start, @end, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LinecastAll_69(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.LinecastAll(@start, @end, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LinecastAll_70(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.LinecastAll(@start, @end, @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LinecastNonAlloc_71(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
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
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.LinecastNonAlloc(@start, @end, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* LinecastNonAlloc_72(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.LinecastNonAlloc(@start, @end, @results, @layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* LinecastNonAlloc_73(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.LinecastNonAlloc(@start, @end, @results, @layerMask, @minDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* LinecastNonAlloc_74(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @end = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @start = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.LinecastNonAlloc(@start, @end, @results, @layerMask, @minDepth, @maxDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Raycast_75(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.Raycast(@origin, @direction);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Raycast_76(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.Raycast(@origin, @direction, @distance);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Raycast_77(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.Raycast(@origin, @direction, @distance, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Raycast_78(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.Raycast(@origin, @direction, @distance, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Raycast_79(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.Raycast(@origin, @direction, @distance, @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Raycast_80(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
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
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.Raycast(@origin, @direction, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Raycast_81(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
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
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.Raycast(@origin, @direction, @contactFilter, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Raycast_82(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
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
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.Raycast(@origin, @direction, @contactFilter, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* RaycastNonAlloc_83(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
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
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.RaycastNonAlloc(@origin, @direction, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* RaycastNonAlloc_84(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
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
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.RaycastNonAlloc(@origin, @direction, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* RaycastNonAlloc_85(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.RaycastNonAlloc(@origin, @direction, @results, @distance, @layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* RaycastNonAlloc_86(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.RaycastNonAlloc(@origin, @direction, @results, @distance, @layerMask, @minDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* RaycastNonAlloc_87(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.RaycastNonAlloc(@origin, @direction, @results, @distance,
                @layerMask, @minDepth, @maxDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* RaycastAll_88(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.RaycastAll(@origin, @direction);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RaycastAll_89(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.RaycastAll(@origin, @direction, @distance);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RaycastAll_90(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.RaycastAll(@origin, @direction, @distance, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RaycastAll_91(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.RaycastAll(@origin, @direction, @distance, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RaycastAll_92(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.RaycastAll(@origin, @direction, @distance, @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CircleCast_93(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CircleCast(@origin, @radius, @direction);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CircleCast_94(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CircleCast(@origin, @radius, @direction, @distance);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CircleCast_95(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CircleCast(@origin, @radius, @direction, @distance, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CircleCast_96(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CircleCast(@origin, @radius, @direction, @distance, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CircleCast_97(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CircleCast(@origin, @radius, @direction, @distance,
                @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CircleCast_98(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

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
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CircleCast(@origin, @radius, @direction, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CircleCast_99(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

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
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CircleCast(@origin, @radius, @direction, @contactFilter, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CircleCast_100(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

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
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CircleCast(@origin, @radius, @direction, @contactFilter, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CircleCastAll_101(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CircleCastAll(@origin, @radius, @direction);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CircleCastAll_102(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CircleCastAll(@origin, @radius, @direction, @distance);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CircleCastAll_103(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CircleCastAll(@origin, @radius, @direction, @distance, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CircleCastAll_104(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CircleCastAll(@origin, @radius, @direction, @distance, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CircleCastAll_105(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CircleCastAll(@origin, @radius, @direction, @distance,
                @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CircleCastNonAlloc_106(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
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
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CircleCastNonAlloc(@origin, @radius, @direction, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CircleCastNonAlloc_107(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
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
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CircleCastNonAlloc(@origin, @radius, @direction, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CircleCastNonAlloc_108(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CircleCastNonAlloc(@origin, @radius, @direction, @results, @distance, @layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CircleCastNonAlloc_109(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CircleCastNonAlloc(@origin, @radius, @direction, @results,
                @distance, @layerMask, @minDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CircleCastNonAlloc_110(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CircleCastNonAlloc(@origin, @radius, @direction, @results,
                @distance, @layerMask, @minDepth, @maxDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* BoxCast_111(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.BoxCast(@origin, @size, @angle, @direction);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BoxCast_112(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.BoxCast(@origin, @size, @angle, @direction, @distance);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BoxCast_113(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.BoxCast(@origin, @size, @angle, @direction, @distance, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BoxCast_114(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.BoxCast(@origin, @size, @angle, @direction, @distance, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BoxCast_115(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.BoxCast(@origin, @size, @angle, @direction, @distance,
                @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BoxCast_116(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.BoxCast(@origin, @size, @angle, @direction, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* BoxCast_117(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.BoxCast(@origin, @size, @angle, @direction,
                @contactFilter, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* BoxCast_118(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.BoxCast(@origin, @size, @angle, @direction,
                @contactFilter, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* BoxCastAll_119(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.BoxCastAll(@origin, @size, @angle, @direction);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BoxCastAll_120(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.BoxCastAll(@origin, @size, @angle, @direction, @distance);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BoxCastAll_121(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.BoxCastAll(@origin, @size, @angle, @direction, @distance, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BoxCastAll_122(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.BoxCastAll(@origin, @size, @angle, @direction, @distance, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BoxCastAll_123(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.BoxCastAll(@origin, @size, @angle, @direction, @distance,
                @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BoxCastNonAlloc_124(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.BoxCastNonAlloc(@origin, @size, @angle, @direction, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* BoxCastNonAlloc_125(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.BoxCastNonAlloc(@origin, @size, @angle, @direction, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* BoxCastNonAlloc_126(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.BoxCastNonAlloc(@origin, @size, @angle, @direction,
                @results, @distance, @layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* BoxCastNonAlloc_127(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.BoxCastNonAlloc(@origin, @size, @angle, @direction,
                @results, @distance, @layerMask, @minDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* BoxCastNonAlloc_128(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.BoxCastNonAlloc(@origin, @size, @angle, @direction,
                @results, @distance, @layerMask, @minDepth, @maxDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CapsuleCast_129(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CapsuleCast(@origin, @size, @capsuleDirection, @angle, @direction);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CapsuleCast_130(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CapsuleCast(@origin, @size, @capsuleDirection, @angle, @direction, @distance);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CapsuleCast_131(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CapsuleCast(@origin, @size, @capsuleDirection, @angle,
                @direction, @distance, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CapsuleCast_132(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CapsuleCast(@origin, @size, @capsuleDirection, @angle,
                @direction, @distance, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CapsuleCast_133(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CapsuleCast(@origin, @size, @capsuleDirection, @angle,
                @direction, @distance, @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CapsuleCast_134(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CapsuleCast(@origin, @size, @capsuleDirection, @angle,
                @direction, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CapsuleCast_135(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CapsuleCast(@origin, @size, @capsuleDirection, @angle,
                @direction, @contactFilter, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CapsuleCast_136(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CapsuleCast(@origin, @size, @capsuleDirection, @angle,
                @direction, @contactFilter, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CapsuleCastAll_137(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CapsuleCastAll(@origin, @size, @capsuleDirection, @angle, @direction);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CapsuleCastAll_138(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CapsuleCastAll(@origin, @size, @capsuleDirection, @angle, @direction, @distance);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CapsuleCastAll_139(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CapsuleCastAll(@origin, @size, @capsuleDirection, @angle,
                @direction, @distance, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CapsuleCastAll_140(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CapsuleCastAll(@origin, @size, @capsuleDirection, @angle,
                @direction, @distance, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CapsuleCastAll_141(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CapsuleCastAll(@origin, @size, @capsuleDirection, @angle,
                @direction, @distance, @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CapsuleCastNonAlloc_142(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.CapsuleCastNonAlloc(@origin, @size, @capsuleDirection, @angle, @direction,
                    @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CapsuleCastNonAlloc_143(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CapsuleCastNonAlloc(@origin, @size, @capsuleDirection,
                @angle, @direction, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CapsuleCastNonAlloc_144(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CapsuleCastNonAlloc(@origin, @size, @capsuleDirection,
                @angle, @direction, @results, @distance, @layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CapsuleCastNonAlloc_145(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CapsuleCastNonAlloc(@origin, @size, @capsuleDirection,
                @angle, @direction, @results, @distance, @layerMask, @minDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CapsuleCastNonAlloc_146(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @direction = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.CapsuleDirection2D @capsuleDirection =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Vector2 @origin = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.CapsuleCastNonAlloc(@origin, @size, @capsuleDirection,
                @angle, @direction, @results, @distance, @layerMask, @minDepth, @maxDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetRayIntersection_147(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Ray @ray = (UnityEngine.Ray) typeof(UnityEngine.Ray).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetRayIntersection(@ray);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRayIntersection_148(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Ray @ray = (UnityEngine.Ray) typeof(UnityEngine.Ray).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetRayIntersection(@ray, @distance);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRayIntersection_149(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Ray @ray = (UnityEngine.Ray) typeof(UnityEngine.Ray).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetRayIntersection(@ray, @distance, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRayIntersectionAll_150(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Ray @ray = (UnityEngine.Ray) typeof(UnityEngine.Ray).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetRayIntersectionAll(@ray);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRayIntersectionAll_151(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Ray @ray = (UnityEngine.Ray) typeof(UnityEngine.Ray).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetRayIntersectionAll(@ray, @distance);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRayIntersectionAll_152(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Ray @ray = (UnityEngine.Ray) typeof(UnityEngine.Ray).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetRayIntersectionAll(@ray, @distance, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRayIntersectionNonAlloc_153(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Ray @ray = (UnityEngine.Ray) typeof(UnityEngine.Ray).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetRayIntersectionNonAlloc(@ray, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetRayIntersectionNonAlloc_154(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Ray @ray = (UnityEngine.Ray) typeof(UnityEngine.Ray).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetRayIntersectionNonAlloc(@ray, @results, @distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetRayIntersectionNonAlloc_155(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RaycastHit2D[] @results =
                (UnityEngine.RaycastHit2D[]) typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Ray @ray = (UnityEngine.Ray) typeof(UnityEngine.Ray).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.GetRayIntersectionNonAlloc(@ray, @results, @distance, @layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapPoint_156(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapPoint(@point);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapPoint_157(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapPoint(@point, @layerMask);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapPoint_158(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapPoint(@point, @layerMask, @minDepth);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapPoint_159(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapPoint(@point, @layerMask, @minDepth, @maxDepth);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapPoint_160(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapPoint(@point, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapPoint_161(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapPoint(@point, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapPointAll_162(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapPointAll(@point);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapPointAll_163(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapPointAll(@point, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapPointAll_164(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapPointAll(@point, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapPointAll_165(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapPointAll(@point, @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapPointNonAlloc_166(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapPointNonAlloc(@point, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapPointNonAlloc_167(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapPointNonAlloc(@point, @results, @layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapPointNonAlloc_168(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapPointNonAlloc(@point, @results, @layerMask, @minDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapPointNonAlloc_169(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapPointNonAlloc(@point, @results, @layerMask, @minDepth, @maxDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCircle_170(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCircle(@point, @radius);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCircle_171(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCircle(@point, @radius, @layerMask);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCircle_172(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCircle(@point, @radius, @layerMask, @minDepth);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCircle_173(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCircle(@point, @radius, @layerMask, @minDepth, @maxDepth);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCircle_174(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

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
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCircle(@point, @radius, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCircle_175(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

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
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCircle(@point, @radius, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCircleAll_176(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCircleAll(@point, @radius);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCircleAll_177(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCircleAll(@point, @radius, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCircleAll_178(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCircleAll(@point, @radius, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCircleAll_179(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCircleAll(@point, @radius, @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCircleNonAlloc_180(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCircleNonAlloc(@point, @radius, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCircleNonAlloc_181(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCircleNonAlloc(@point, @radius, @results, @layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCircleNonAlloc_182(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCircleNonAlloc(@point, @radius, @results, @layerMask, @minDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCircleNonAlloc_183(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @radius = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCircleNonAlloc(@point, @radius, @results, @layerMask, @minDepth,
                    @maxDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapBox_184(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapBox(@point, @size, @angle);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapBox_185(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapBox(@point, @size, @angle, @layerMask);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapBox_186(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapBox(@point, @size, @angle, @layerMask, @minDepth);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapBox_187(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapBox(@point, @size, @angle, @layerMask, @minDepth, @maxDepth);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapBox_188(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapBox(@point, @size, @angle, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapBox_189(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapBox(@point, @size, @angle, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapBoxAll_190(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapBoxAll(@point, @size, @angle);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapBoxAll_191(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapBoxAll(@point, @size, @angle, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapBoxAll_192(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapBoxAll(@point, @size, @angle, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapBoxAll_193(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapBoxAll(@point, @size, @angle, @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapBoxNonAlloc_194(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapBoxNonAlloc(@point, @size, @angle, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapBoxNonAlloc_195(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapBoxNonAlloc(@point, @size, @angle, @results, @layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapBoxNonAlloc_196(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapBoxNonAlloc(@point, @size, @angle, @results, @layerMask, @minDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapBoxNonAlloc_197(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapBoxNonAlloc(@point, @size, @angle, @results, @layerMask, @minDepth,
                    @maxDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapArea_198(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapArea(@pointA, @pointB);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapArea_199(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapArea(@pointA, @pointB, @layerMask);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapArea_200(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapArea(@pointA, @pointB, @layerMask, @minDepth);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapArea_201(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapArea(@pointA, @pointB, @layerMask, @minDepth, @maxDepth);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapArea_202(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

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
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapArea(@pointA, @pointB, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapArea_203(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

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
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapArea(@pointA, @pointB, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapAreaAll_204(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapAreaAll(@pointA, @pointB);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapAreaAll_205(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapAreaAll(@pointA, @pointB, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapAreaAll_206(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapAreaAll(@pointA, @pointB, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapAreaAll_207(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapAreaAll(@pointA, @pointB, @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapAreaNonAlloc_208(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapAreaNonAlloc(@pointA, @pointB, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapAreaNonAlloc_209(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapAreaNonAlloc(@pointA, @pointB, @results, @layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapAreaNonAlloc_210(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapAreaNonAlloc(@pointA, @pointB, @results, @layerMask, @minDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapAreaNonAlloc_211(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @pointB = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @pointA = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapAreaNonAlloc(@pointA, @pointB, @results, @layerMask, @minDepth, @maxDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCapsule_212(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCapsule(@point, @size, @direction, @angle);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCapsule_213(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCapsule(@point, @size, @direction, @angle, @layerMask);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCapsule_214(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCapsule(@point, @size, @direction, @angle, @layerMask, @minDepth);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCapsule_215(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCapsule(@point, @size, @direction, @angle, @layerMask, @minDepth,
                    @maxDepth);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCapsule_216(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCapsule(@point, @size, @direction, @angle, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCapsule_217(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

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
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCapsule(@point, @size, @direction, @angle, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCapsuleAll_218(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCapsuleAll(@point, @size, @direction, @angle);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCapsuleAll_219(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCapsuleAll(@point, @size, @direction, @angle, @layerMask);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCapsuleAll_220(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCapsuleAll(@point, @size, @direction, @angle, @layerMask, @minDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCapsuleAll_221(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCapsuleAll(@point, @size, @direction, @angle,
                @layerMask, @minDepth, @maxDepth);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OverlapCapsuleNonAlloc_222(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCapsuleNonAlloc(@point, @size, @direction, @angle, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCapsuleNonAlloc_223(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.OverlapCapsuleNonAlloc(@point, @size, @direction, @angle, @results, @layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCapsuleNonAlloc_224(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCapsuleNonAlloc(@point, @size, @direction, @angle,
                @results, @layerMask, @minDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCapsuleNonAlloc_225(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minDepth = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layerMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Collider2D[] @results =
                (UnityEngine.Collider2D[]) typeof(UnityEngine.Collider2D[]).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @angle = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.CapsuleDirection2D @direction =
                (UnityEngine.CapsuleDirection2D) typeof(UnityEngine.CapsuleDirection2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector2 @size = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector2 @point = (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCapsuleNonAlloc(@point, @size, @direction, @angle,
                @results, @layerMask, @minDepth, @maxDepth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCollider_226(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCollider(@collider, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OverlapCollider_227(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.OverlapCollider(@collider, @contactFilter, @results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_228(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

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
            UnityEngine.Collider2D @collider2 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Collider2D @collider1 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.GetContacts(@collider1, @collider2, @contactFilter, @contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_229(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@collider, @contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_230(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@collider, @contactFilter, @contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_231(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@collider, @colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_232(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@collider, @contactFilter, @colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_233(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Rigidbody2D @rigidbody =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@rigidbody, @contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_234(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Rigidbody2D @rigidbody =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@rigidbody, @contactFilter, @contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_235(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Rigidbody2D @rigidbody =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@rigidbody, @colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_236(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Rigidbody2D @rigidbody =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@rigidbody, @contactFilter, @colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_237(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

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
            UnityEngine.Collider2D @collider2 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Collider2D @collider1 = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Physics2D.GetContacts(@collider1, @collider2, @contactFilter, @contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_238(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@collider, @contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_239(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@collider, @contactFilter, @contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_240(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@collider, @colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_241(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Collider2D @collider = (UnityEngine.Collider2D) typeof(UnityEngine.Collider2D).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@collider, @contactFilter, @colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_242(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Rigidbody2D @rigidbody =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@rigidbody, @contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_243(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Rigidbody2D @rigidbody =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@rigidbody, @contactFilter, @contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_244(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Rigidbody2D @rigidbody =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@rigidbody, @colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_245(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.Rigidbody2D @rigidbody =
                (UnityEngine.Rigidbody2D) typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Physics2D.GetContacts(@rigidbody, @contactFilter, @colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }


        static object get_IgnoreRaycastLayer_0(ref object o)
        {
            return UnityEngine.Physics2D.IgnoreRaycastLayer;
        }

        static StackObject* CopyToStack_IgnoreRaycastLayer_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Physics2D.IgnoreRaycastLayer;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_DefaultRaycastLayers_1(ref object o)
        {
            return UnityEngine.Physics2D.DefaultRaycastLayers;
        }

        static StackObject* CopyToStack_DefaultRaycastLayers_1(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Physics2D.DefaultRaycastLayers;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_AllLayers_2(ref object o)
        {
            return UnityEngine.Physics2D.AllLayers;
        }

        static StackObject* CopyToStack_AllLayers_2(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Physics2D.AllLayers;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_MaxPolygonShapeVertices_3(ref object o)
        {
            return UnityEngine.Physics2D.MaxPolygonShapeVertices;
        }

        static StackObject* CopyToStack_MaxPolygonShapeVertices_3(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Physics2D.MaxPolygonShapeVertices;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Physics2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}