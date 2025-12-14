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
    unsafe class UnityEngine_ArticulationBody_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.ArticulationBody);
            args = new Type[] { };
            method = type.GetMethod("get_jointType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_jointType_0);
            args = new Type[] {typeof(UnityEngine.ArticulationJointType)};
            method = type.GetMethod("set_jointType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_jointType_1);
            args = new Type[] { };
            method = type.GetMethod("get_anchorPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_anchorPosition_2);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_anchorPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_anchorPosition_3);
            args = new Type[] { };
            method = type.GetMethod("get_parentAnchorPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_parentAnchorPosition_4);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_parentAnchorPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_parentAnchorPosition_5);
            args = new Type[] { };
            method = type.GetMethod("get_anchorRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_anchorRotation_6);
            args = new Type[] {typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("set_anchorRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_anchorRotation_7);
            args = new Type[] { };
            method = type.GetMethod("get_parentAnchorRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_parentAnchorRotation_8);
            args = new Type[] {typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("set_parentAnchorRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_parentAnchorRotation_9);
            args = new Type[] { };
            method = type.GetMethod("get_isRoot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isRoot_10);
            args = new Type[] { };
            method = type.GetMethod("get_matchAnchors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_matchAnchors_11);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_matchAnchors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_matchAnchors_12);
            args = new Type[] { };
            method = type.GetMethod("get_linearLockX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_linearLockX_13);
            args = new Type[] {typeof(UnityEngine.ArticulationDofLock)};
            method = type.GetMethod("set_linearLockX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_linearLockX_14);
            args = new Type[] { };
            method = type.GetMethod("get_linearLockY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_linearLockY_15);
            args = new Type[] {typeof(UnityEngine.ArticulationDofLock)};
            method = type.GetMethod("set_linearLockY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_linearLockY_16);
            args = new Type[] { };
            method = type.GetMethod("get_linearLockZ", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_linearLockZ_17);
            args = new Type[] {typeof(UnityEngine.ArticulationDofLock)};
            method = type.GetMethod("set_linearLockZ", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_linearLockZ_18);
            args = new Type[] { };
            method = type.GetMethod("get_swingYLock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_swingYLock_19);
            args = new Type[] {typeof(UnityEngine.ArticulationDofLock)};
            method = type.GetMethod("set_swingYLock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_swingYLock_20);
            args = new Type[] { };
            method = type.GetMethod("get_swingZLock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_swingZLock_21);
            args = new Type[] {typeof(UnityEngine.ArticulationDofLock)};
            method = type.GetMethod("set_swingZLock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_swingZLock_22);
            args = new Type[] { };
            method = type.GetMethod("get_twistLock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_twistLock_23);
            args = new Type[] {typeof(UnityEngine.ArticulationDofLock)};
            method = type.GetMethod("set_twistLock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_twistLock_24);
            args = new Type[] { };
            method = type.GetMethod("get_xDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_xDrive_25);
            args = new Type[] {typeof(UnityEngine.ArticulationDrive)};
            method = type.GetMethod("set_xDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_xDrive_26);
            args = new Type[] { };
            method = type.GetMethod("get_yDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_yDrive_27);
            args = new Type[] {typeof(UnityEngine.ArticulationDrive)};
            method = type.GetMethod("set_yDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_yDrive_28);
            args = new Type[] { };
            method = type.GetMethod("get_zDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_zDrive_29);
            args = new Type[] {typeof(UnityEngine.ArticulationDrive)};
            method = type.GetMethod("set_zDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_zDrive_30);
            args = new Type[] { };
            method = type.GetMethod("get_immovable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_immovable_31);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_immovable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_immovable_32);
            args = new Type[] { };
            method = type.GetMethod("get_useGravity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useGravity_33);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_useGravity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useGravity_34);
            args = new Type[] { };
            method = type.GetMethod("get_linearDamping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_linearDamping_35);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_linearDamping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_linearDamping_36);
            args = new Type[] { };
            method = type.GetMethod("get_angularDamping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularDamping_37);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_angularDamping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularDamping_38);
            args = new Type[] { };
            method = type.GetMethod("get_jointFriction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_jointFriction_39);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_jointFriction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_jointFriction_40);
            args = new Type[] { };
            method = type.GetMethod("get_excludeLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_excludeLayers_41);
            args = new Type[] {typeof(UnityEngine.LayerMask)};
            method = type.GetMethod("set_excludeLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_excludeLayers_42);
            args = new Type[] { };
            method = type.GetMethod("get_includeLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_includeLayers_43);
            args = new Type[] {typeof(UnityEngine.LayerMask)};
            method = type.GetMethod("set_includeLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_includeLayers_44);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("GetAccumulatedForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAccumulatedForce_45);
            args = new Type[] { };
            method = type.GetMethod("GetAccumulatedForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAccumulatedForce_46);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("GetAccumulatedTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAccumulatedTorque_47);
            args = new Type[] { };
            method = type.GetMethod("GetAccumulatedTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAccumulatedTorque_48);
            args = new Type[] {typeof(UnityEngine.Vector3), typeof(UnityEngine.ForceMode)};
            method = type.GetMethod("AddForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddForce_49);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("AddForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddForce_50);
            args = new Type[] {typeof(UnityEngine.Vector3), typeof(UnityEngine.ForceMode)};
            method = type.GetMethod("AddRelativeForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddRelativeForce_51);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("AddRelativeForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddRelativeForce_52);
            args = new Type[] {typeof(UnityEngine.Vector3), typeof(UnityEngine.ForceMode)};
            method = type.GetMethod("AddTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddTorque_53);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("AddTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddTorque_54);
            args = new Type[] {typeof(UnityEngine.Vector3), typeof(UnityEngine.ForceMode)};
            method = type.GetMethod("AddRelativeTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddRelativeTorque_55);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("AddRelativeTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddRelativeTorque_56);
            args = new Type[] {typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.ForceMode)};
            method = type.GetMethod("AddForceAtPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddForceAtPosition_57);
            args = new Type[] {typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("AddForceAtPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddForceAtPosition_58);
            args = new Type[] { };
            method = type.GetMethod("get_velocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_velocity_59);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_velocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_velocity_60);
            args = new Type[] { };
            method = type.GetMethod("get_angularVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularVelocity_61);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_angularVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularVelocity_62);
            args = new Type[] { };
            method = type.GetMethod("get_mass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mass_63);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_mass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_mass_64);
            args = new Type[] { };
            method = type.GetMethod("get_automaticCenterOfMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_automaticCenterOfMass_65);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_automaticCenterOfMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_automaticCenterOfMass_66);
            args = new Type[] { };
            method = type.GetMethod("get_centerOfMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_centerOfMass_67);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_centerOfMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_centerOfMass_68);
            args = new Type[] { };
            method = type.GetMethod("get_worldCenterOfMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_worldCenterOfMass_69);
            args = new Type[] { };
            method = type.GetMethod("get_automaticInertiaTensor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_automaticInertiaTensor_70);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_automaticInertiaTensor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_automaticInertiaTensor_71);
            args = new Type[] { };
            method = type.GetMethod("get_inertiaTensor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inertiaTensor_72);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_inertiaTensor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_inertiaTensor_73);
            args = new Type[] { };
            method = type.GetMethod("get_inertiaTensorRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inertiaTensorRotation_74);
            args = new Type[] {typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("set_inertiaTensorRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_inertiaTensorRotation_75);
            args = new Type[] { };
            method = type.GetMethod("ResetCenterOfMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetCenterOfMass_76);
            args = new Type[] { };
            method = type.GetMethod("ResetInertiaTensor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetInertiaTensor_77);
            args = new Type[] { };
            method = type.GetMethod("Sleep", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sleep_78);
            args = new Type[] { };
            method = type.GetMethod("IsSleeping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsSleeping_79);
            args = new Type[] { };
            method = type.GetMethod("WakeUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WakeUp_80);
            args = new Type[] { };
            method = type.GetMethod("get_sleepThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sleepThreshold_81);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_sleepThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sleepThreshold_82);
            args = new Type[] { };
            method = type.GetMethod("get_solverIterations", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_solverIterations_83);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("set_solverIterations", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_solverIterations_84);
            args = new Type[] { };
            method = type.GetMethod("get_solverVelocityIterations", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_solverVelocityIterations_85);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("set_solverVelocityIterations", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_solverVelocityIterations_86);
            args = new Type[] { };
            method = type.GetMethod("get_maxAngularVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxAngularVelocity_87);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_maxAngularVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxAngularVelocity_88);
            args = new Type[] { };
            method = type.GetMethod("get_maxLinearVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxLinearVelocity_89);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_maxLinearVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxLinearVelocity_90);
            args = new Type[] { };
            method = type.GetMethod("get_maxJointVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxJointVelocity_91);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_maxJointVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxJointVelocity_92);
            args = new Type[] { };
            method = type.GetMethod("get_maxDepenetrationVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxDepenetrationVelocity_93);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_maxDepenetrationVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxDepenetrationVelocity_94);
            args = new Type[] { };
            method = type.GetMethod("get_jointPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_jointPosition_95);
            args = new Type[] {typeof(UnityEngine.ArticulationReducedSpace)};
            method = type.GetMethod("set_jointPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_jointPosition_96);
            args = new Type[] { };
            method = type.GetMethod("get_jointVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_jointVelocity_97);
            args = new Type[] {typeof(UnityEngine.ArticulationReducedSpace)};
            method = type.GetMethod("set_jointVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_jointVelocity_98);
            args = new Type[] { };
            method = type.GetMethod("get_jointAcceleration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_jointAcceleration_99);
            args = new Type[] { };
            method = type.GetMethod("get_jointForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_jointForce_100);
            args = new Type[] {typeof(UnityEngine.ArticulationReducedSpace)};
            method = type.GetMethod("set_jointForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_jointForce_101);
            args = new Type[] { };
            method = type.GetMethod("get_driveForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_driveForce_102);
            args = new Type[] { };
            method = type.GetMethod("get_dofCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_dofCount_103);
            args = new Type[] { };
            method = type.GetMethod("get_index", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_index_104);
            args = new Type[] {typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("TeleportRoot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TeleportRoot_105);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("GetClosestPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetClosestPoint_106);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("GetRelativePointVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRelativePointVelocity_107);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("GetPointVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPointVelocity_108);
            args = new Type[] {typeof(UnityEngine.ArticulationJacobian).MakeByRefType()};
            method = type.GetMethod("GetDenseJacobian", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDenseJacobian_109);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("GetJointPositions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetJointPositions_110);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("SetJointPositions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetJointPositions_111);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("GetJointVelocities", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetJointVelocities_112);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("SetJointVelocities", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetJointVelocities_113);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("GetJointAccelerations", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetJointAccelerations_114);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("GetJointForces", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetJointForces_115);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("SetJointForces", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetJointForces_116);
            args = new Type[] {typeof(UnityEngine.ArticulationReducedSpace)};
            method = type.GetMethod("GetJointForcesForAcceleration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetJointForcesForAcceleration_117);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("GetDriveForces", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDriveForces_118);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("GetJointGravityForces", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetJointGravityForces_119);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("GetJointCoriolisCentrifugalForces", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetJointCoriolisCentrifugalForces_120);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>), typeof(System.Single)};
            method = type.GetMethod("GetJointExternalForces", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetJointExternalForces_121);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("GetDriveTargets", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDriveTargets_122);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("SetDriveTargets", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDriveTargets_123);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("GetDriveTargetVelocities", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDriveTargetVelocities_124);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("SetDriveTargetVelocities", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDriveTargetVelocities_125);
            args = new Type[] {typeof(System.Collections.Generic.List<System.Int32>)};
            method = type.GetMethod("GetDofStartIndices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDofStartIndices_126);
            args = new Type[] {typeof(UnityEngine.ArticulationDriveAxis), typeof(System.Single)};
            method = type.GetMethod("SetDriveTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDriveTarget_127);
            args = new Type[] {typeof(UnityEngine.ArticulationDriveAxis), typeof(System.Single)};
            method = type.GetMethod("SetDriveTargetVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDriveTargetVelocity_128);
            args = new Type[] {typeof(UnityEngine.ArticulationDriveAxis), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetDriveLimits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDriveLimits_129);
            args = new Type[] {typeof(UnityEngine.ArticulationDriveAxis), typeof(System.Single)};
            method = type.GetMethod("SetDriveStiffness", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDriveStiffness_130);
            args = new Type[] {typeof(UnityEngine.ArticulationDriveAxis), typeof(System.Single)};
            method = type.GetMethod("SetDriveDamping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDriveDamping_131);
            args = new Type[] {typeof(UnityEngine.ArticulationDriveAxis), typeof(System.Single)};
            method = type.GetMethod("SetDriveForceLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDriveForceLimit_132);
            args = new Type[] { };
            method = type.GetMethod("get_collisionDetectionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_collisionDetectionMode_133);
            args = new Type[] {typeof(UnityEngine.CollisionDetectionMode)};
            method = type.GetMethod("set_collisionDetectionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_collisionDetectionMode_134);
            args = new Type[] { };
            method = type.GetMethod("SnapAnchorToClosestContact", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SnapAnchorToClosestContact_135);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ArticulationBody());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ArticulationBody[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* get_jointType_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.jointType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_jointType_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationJointType @value =
                (UnityEngine.ArticulationJointType) typeof(UnityEngine.ArticulationJointType).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.jointType = value;

            return __ret;
        }

        static StackObject* get_anchorPosition_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.anchorPosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_anchorPosition_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.anchorPosition = value;

            return __ret;
        }

        static StackObject* get_parentAnchorPosition_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.parentAnchorPosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_parentAnchorPosition_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.parentAnchorPosition = value;

            return __ret;
        }

        static StackObject* get_anchorRotation_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.anchorRotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_anchorRotation_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @value = (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.anchorRotation = value;

            return __ret;
        }

        static StackObject* get_parentAnchorRotation_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.parentAnchorRotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_parentAnchorRotation_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @value = (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.parentAnchorRotation = value;

            return __ret;
        }

        static StackObject* get_isRoot_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isRoot;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_matchAnchors_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.matchAnchors;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_matchAnchors_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.matchAnchors = value;

            return __ret;
        }

        static StackObject* get_linearLockX_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.linearLockX;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_linearLockX_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationDofLock @value =
                (UnityEngine.ArticulationDofLock) typeof(UnityEngine.ArticulationDofLock).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.linearLockX = value;

            return __ret;
        }

        static StackObject* get_linearLockY_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.linearLockY;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_linearLockY_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationDofLock @value =
                (UnityEngine.ArticulationDofLock) typeof(UnityEngine.ArticulationDofLock).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.linearLockY = value;

            return __ret;
        }

        static StackObject* get_linearLockZ_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.linearLockZ;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_linearLockZ_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationDofLock @value =
                (UnityEngine.ArticulationDofLock) typeof(UnityEngine.ArticulationDofLock).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.linearLockZ = value;

            return __ret;
        }

        static StackObject* get_swingYLock_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.swingYLock;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_swingYLock_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationDofLock @value =
                (UnityEngine.ArticulationDofLock) typeof(UnityEngine.ArticulationDofLock).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.swingYLock = value;

            return __ret;
        }

        static StackObject* get_swingZLock_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.swingZLock;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_swingZLock_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationDofLock @value =
                (UnityEngine.ArticulationDofLock) typeof(UnityEngine.ArticulationDofLock).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.swingZLock = value;

            return __ret;
        }

        static StackObject* get_twistLock_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.twistLock;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_twistLock_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationDofLock @value =
                (UnityEngine.ArticulationDofLock) typeof(UnityEngine.ArticulationDofLock).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.twistLock = value;

            return __ret;
        }

        static StackObject* get_xDrive_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.xDrive;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_xDrive_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationDrive @value =
                (UnityEngine.ArticulationDrive) typeof(UnityEngine.ArticulationDrive).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.xDrive = value;

            return __ret;
        }

        static StackObject* get_yDrive_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.yDrive;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_yDrive_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationDrive @value =
                (UnityEngine.ArticulationDrive) typeof(UnityEngine.ArticulationDrive).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.yDrive = value;

            return __ret;
        }

        static StackObject* get_zDrive_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.zDrive;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_zDrive_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationDrive @value =
                (UnityEngine.ArticulationDrive) typeof(UnityEngine.ArticulationDrive).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.zDrive = value;

            return __ret;
        }

        static StackObject* get_immovable_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.immovable;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_immovable_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.immovable = value;

            return __ret;
        }

        static StackObject* get_useGravity_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useGravity;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useGravity_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useGravity = value;

            return __ret;
        }

        static StackObject* get_linearDamping_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.linearDamping;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_linearDamping_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.linearDamping = value;

            return __ret;
        }

        static StackObject* get_angularDamping_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularDamping;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_angularDamping_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularDamping = value;

            return __ret;
        }

        static StackObject* get_jointFriction_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.jointFriction;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_jointFriction_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.jointFriction = value;

            return __ret;
        }

        static StackObject* get_excludeLayers_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.excludeLayers;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_excludeLayers_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.excludeLayers = value;

            return __ret;
        }

        static StackObject* get_includeLayers_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.includeLayers;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_includeLayers_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.includeLayers = value;

            return __ret;
        }

        static StackObject* GetAccumulatedForce_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @step = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAccumulatedForce(@step);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAccumulatedForce_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAccumulatedForce();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAccumulatedTorque_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @step = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAccumulatedTorque(@step);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAccumulatedTorque_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAccumulatedTorque();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AddForce_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ForceMode @mode = (UnityEngine.ForceMode) typeof(UnityEngine.ForceMode).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @force = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddForce(@force, @mode);

            return __ret;
        }

        static StackObject* AddForce_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @force = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddForce(@force);

            return __ret;
        }

        static StackObject* AddRelativeForce_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ForceMode @mode = (UnityEngine.ForceMode) typeof(UnityEngine.ForceMode).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @force = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddRelativeForce(@force, @mode);

            return __ret;
        }

        static StackObject* AddRelativeForce_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @force = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddRelativeForce(@force);

            return __ret;
        }

        static StackObject* AddTorque_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ForceMode @mode = (UnityEngine.ForceMode) typeof(UnityEngine.ForceMode).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @torque = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddTorque(@torque, @mode);

            return __ret;
        }

        static StackObject* AddTorque_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @torque = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddTorque(@torque);

            return __ret;
        }

        static StackObject* AddRelativeTorque_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ForceMode @mode = (UnityEngine.ForceMode) typeof(UnityEngine.ForceMode).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @torque = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddRelativeTorque(@torque, @mode);

            return __ret;
        }

        static StackObject* AddRelativeTorque_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @torque = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddRelativeTorque(@torque);

            return __ret;
        }

        static StackObject* AddForceAtPosition_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ForceMode @mode = (UnityEngine.ForceMode) typeof(UnityEngine.ForceMode).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @force = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddForceAtPosition(@force, @position, @mode);

            return __ret;
        }

        static StackObject* AddForceAtPosition_58(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @force = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddForceAtPosition(@force, @position);

            return __ret;
        }

        static StackObject* get_velocity_59(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
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

        static StackObject* set_velocity_60(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

#if UNITY_6000_0_OR_NEWER
            instance_of_this_method.linearVelocity = value;
#else
            instance_of_this_method.velocity = value;
#endif

            return __ret;
        }

        static StackObject* get_angularVelocity_61(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularVelocity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_angularVelocity_62(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularVelocity = value;

            return __ret;
        }

        static StackObject* get_mass_63(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mass;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_mass_64(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.mass = value;

            return __ret;
        }

        static StackObject* get_automaticCenterOfMass_65(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.automaticCenterOfMass;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_automaticCenterOfMass_66(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.automaticCenterOfMass = value;

            return __ret;
        }

        static StackObject* get_centerOfMass_67(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.centerOfMass;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_centerOfMass_68(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.centerOfMass = value;

            return __ret;
        }

        static StackObject* get_worldCenterOfMass_69(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.worldCenterOfMass;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_automaticInertiaTensor_70(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.automaticInertiaTensor;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_automaticInertiaTensor_71(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.automaticInertiaTensor = value;

            return __ret;
        }

        static StackObject* get_inertiaTensor_72(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.inertiaTensor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_inertiaTensor_73(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.inertiaTensor = value;

            return __ret;
        }

        static StackObject* get_inertiaTensorRotation_74(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.inertiaTensorRotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_inertiaTensorRotation_75(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @value = (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.inertiaTensorRotation = value;

            return __ret;
        }

        static StackObject* ResetCenterOfMass_76(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetCenterOfMass();

            return __ret;
        }

        static StackObject* ResetInertiaTensor_77(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetInertiaTensor();

            return __ret;
        }

        static StackObject* Sleep_78(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Sleep();

            return __ret;
        }

        static StackObject* IsSleeping_79(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsSleeping();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* WakeUp_80(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WakeUp();

            return __ret;
        }

        static StackObject* get_sleepThreshold_81(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sleepThreshold;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_sleepThreshold_82(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sleepThreshold = value;

            return __ret;
        }

        static StackObject* get_solverIterations_83(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.solverIterations;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_solverIterations_84(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.solverIterations = value;

            return __ret;
        }

        static StackObject* get_solverVelocityIterations_85(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.solverVelocityIterations;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_solverVelocityIterations_86(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.solverVelocityIterations = value;

            return __ret;
        }

        static StackObject* get_maxAngularVelocity_87(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxAngularVelocity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxAngularVelocity_88(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxAngularVelocity = value;

            return __ret;
        }

        static StackObject* get_maxLinearVelocity_89(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxLinearVelocity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxLinearVelocity_90(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxLinearVelocity = value;

            return __ret;
        }

        static StackObject* get_maxJointVelocity_91(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxJointVelocity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxJointVelocity_92(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxJointVelocity = value;

            return __ret;
        }

        static StackObject* get_maxDepenetrationVelocity_93(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxDepenetrationVelocity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxDepenetrationVelocity_94(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxDepenetrationVelocity = value;

            return __ret;
        }

        static StackObject* get_jointPosition_95(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.jointPosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_jointPosition_96(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationReducedSpace @value =
                (UnityEngine.ArticulationReducedSpace) typeof(UnityEngine.ArticulationReducedSpace).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.jointPosition = value;

            return __ret;
        }

        static StackObject* get_jointVelocity_97(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.jointVelocity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_jointVelocity_98(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationReducedSpace @value =
                (UnityEngine.ArticulationReducedSpace) typeof(UnityEngine.ArticulationReducedSpace).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.jointVelocity = value;

            return __ret;
        }

        static StackObject* get_jointAcceleration_99(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.jointAcceleration;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_jointForce_100(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.jointForce;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_jointForce_101(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationReducedSpace @value =
                (UnityEngine.ArticulationReducedSpace) typeof(UnityEngine.ArticulationReducedSpace).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.jointForce = value;

            return __ret;
        }

        static StackObject* get_driveForce_102(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.driveForce;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_dofCount_103(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.dofCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_index_104(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.index;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* TeleportRoot_105(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TeleportRoot(@position, @rotation);

            return __ret;
        }

        static StackObject* GetClosestPoint_106(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @point = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetClosestPoint(@point);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRelativePointVelocity_107(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @relativePoint = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetRelativePointVelocity(@relativePoint);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPointVelocity_108(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @worldPoint = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPointVelocity(@worldPoint);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetDenseJacobian_109(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationJacobian @jacobian =
                (UnityEngine.ArticulationJacobian) typeof(UnityEngine.ArticulationJacobian).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);

            var result_of_this_method = instance_of_this_method.GetDenseJacobian(ref @jacobian);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    object ___obj = @jacobian;
                    if (___dst->ObjectType >= ObjectTypes.Object)
                    {
                        if (___obj is CrossBindingAdaptorType)
                            ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                        __mStack[___dst->Value] = ___obj;
                    }
                    else
                    {
                        ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                    }
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @jacobian;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @jacobian);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @jacobian;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @jacobian);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as UnityEngine.ArticulationJacobian[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @jacobian;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetJointPositions_110(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @positions =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetJointPositions(@positions);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetJointPositions_111(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @positions =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetJointPositions(@positions);

            return __ret;
        }

        static StackObject* GetJointVelocities_112(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @velocities =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetJointVelocities(@velocities);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetJointVelocities_113(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @velocities =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetJointVelocities(@velocities);

            return __ret;
        }

        static StackObject* GetJointAccelerations_114(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @accelerations =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetJointAccelerations(@accelerations);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetJointForces_115(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @forces =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetJointForces(@forces);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetJointForces_116(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @forces =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetJointForces(@forces);

            return __ret;
        }

        static StackObject* GetJointForcesForAcceleration_117(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationReducedSpace @acceleration =
                (UnityEngine.ArticulationReducedSpace) typeof(UnityEngine.ArticulationReducedSpace).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetJointForcesForAcceleration(@acceleration);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetDriveForces_118(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @forces =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetDriveForces(@forces);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetJointGravityForces_119(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @forces =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetJointGravityForces(@forces);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetJointCoriolisCentrifugalForces_120(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @forces =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetJointCoriolisCentrifugalForces(@forces);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetJointExternalForces_121(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @step = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Single> @forces =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetJointExternalForces(@forces, @step);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetDriveTargets_122(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @targets =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetDriveTargets(@targets);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetDriveTargets_123(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @targets =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDriveTargets(@targets);

            return __ret;
        }

        static StackObject* GetDriveTargetVelocities_124(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @targetVelocities =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetDriveTargetVelocities(@targetVelocities);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetDriveTargetVelocities_125(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @targetVelocities =
                (System.Collections.Generic.List<System.Single>) typeof(System.Collections.Generic.List<System.Single>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDriveTargetVelocities(@targetVelocities);

            return __ret;
        }

        static StackObject* GetDofStartIndices_126(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Int32> @dofStartIndices =
                (System.Collections.Generic.List<System.Int32>) typeof(System.Collections.Generic.List<System.Int32>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetDofStartIndices(@dofStartIndices);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetDriveTarget_127(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationDriveAxis @axis =
                (UnityEngine.ArticulationDriveAxis) typeof(UnityEngine.ArticulationDriveAxis).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDriveTarget(@axis, @value);

            return __ret;
        }

        static StackObject* SetDriveTargetVelocity_128(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationDriveAxis @axis =
                (UnityEngine.ArticulationDriveAxis) typeof(UnityEngine.ArticulationDriveAxis).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDriveTargetVelocity(@axis, @value);

            return __ret;
        }

        static StackObject* SetDriveLimits_129(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @upper = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @lower = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ArticulationDriveAxis @axis =
                (UnityEngine.ArticulationDriveAxis) typeof(UnityEngine.ArticulationDriveAxis).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDriveLimits(@axis, @lower, @upper);

            return __ret;
        }

        static StackObject* SetDriveStiffness_130(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationDriveAxis @axis =
                (UnityEngine.ArticulationDriveAxis) typeof(UnityEngine.ArticulationDriveAxis).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDriveStiffness(@axis, @value);

            return __ret;
        }

        static StackObject* SetDriveDamping_131(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationDriveAxis @axis =
                (UnityEngine.ArticulationDriveAxis) typeof(UnityEngine.ArticulationDriveAxis).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDriveDamping(@axis, @value);

            return __ret;
        }

        static StackObject* SetDriveForceLimit_132(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationDriveAxis @axis =
                (UnityEngine.ArticulationDriveAxis) typeof(UnityEngine.ArticulationDriveAxis).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDriveForceLimit(@axis, @value);

            return __ret;
        }

        static StackObject* get_collisionDetectionMode_133(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.collisionDetectionMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_collisionDetectionMode_134(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CollisionDetectionMode @value =
                (UnityEngine.CollisionDetectionMode) typeof(UnityEngine.CollisionDetectionMode).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.collisionDetectionMode = value;

            return __ret;
        }

        static StackObject* SnapAnchorToClosestContact_135(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ArticulationBody instance_of_this_method =
                (UnityEngine.ArticulationBody) typeof(UnityEngine.ArticulationBody).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SnapAnchorToClosestContact();

            return __ret;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.ArticulationBody();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}