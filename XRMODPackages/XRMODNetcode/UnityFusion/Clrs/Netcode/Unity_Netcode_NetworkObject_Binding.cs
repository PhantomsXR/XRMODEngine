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
    unsafe class Unity_Netcode_NetworkObject_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.NetworkObject);
            args = new Type[]{};
            method = type.GetMethod("get_PrefabIdHash", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PrefabIdHash_0);
            args = new Type[]{};
            method = type.GetMethod("get_NetworkTransforms", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NetworkTransforms_1);
            args = new Type[]{};
            method = type.GetMethod("get_NetworkRigidbodies", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NetworkRigidbodies_2);
            args = new Type[]{};
            method = type.GetMethod("get_CurrentParent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CurrentParent_3);
            args = new Type[]{};
            method = type.GetMethod("get_NetworkManager", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NetworkManager_4);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("DeferDespawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeferDespawn_5);
            args = new Type[]{};
            method = type.GetMethod("get_IsOwnershipDistributable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsOwnershipDistributable_6);
            args = new Type[]{};
            method = type.GetMethod("get_IsOwnershipSessionOwner", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsOwnershipSessionOwner_7);
            args = new Type[]{};
            method = type.GetMethod("get_IsOwnershipLocked", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsOwnershipLocked_8);
            args = new Type[]{};
            method = type.GetMethod("get_IsOwnershipTransferable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsOwnershipTransferable_9);
            args = new Type[]{};
            method = type.GetMethod("get_IsOwnershipRequestRequired", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsOwnershipRequestRequired_10);
            args = new Type[]{};
            method = type.GetMethod("get_IsRequestInProgress", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsRequestInProgress_11);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetOwnershipLock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetOwnershipLock_12);
            args = new Type[]{};
            method = type.GetMethod("RequestOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestOwnership_13);
            args = new Type[]{typeof(Unity.Netcode.NetworkObject.OwnershipStatus), typeof(System.Boolean), typeof(Unity.Netcode.NetworkObject.OwnershipLockActions)};
            method = type.GetMethod("SetOwnershipStatus", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetOwnershipStatus_14);
            args = new Type[]{typeof(Unity.Netcode.NetworkObject.OwnershipStatus)};
            method = type.GetMethod("RemoveOwnershipStatus", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveOwnershipStatus_15);
            args = new Type[]{typeof(Unity.Netcode.NetworkObject.OwnershipStatus)};
            method = type.GetMethod("HasOwnershipStatus", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasOwnershipStatus_16);
            args = new Type[]{};
            method = type.GetMethod("get_HasAuthority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_HasAuthority_17);
            args = new Type[]{};
            method = type.GetMethod("get_NetworkObjectId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NetworkObjectId_18);
            args = new Type[]{};
            method = type.GetMethod("get_OwnerClientId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_OwnerClientId_19);
            args = new Type[]{};
            method = type.GetMethod("get_IsPlayerObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsPlayerObject_20);
            args = new Type[]{};
            method = type.GetMethod("get_IsLocalPlayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsLocalPlayer_21);
            args = new Type[]{};
            method = type.GetMethod("get_IsOwner", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsOwner_22);
            args = new Type[]{};
            method = type.GetMethod("get_IsOwnedByServer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsOwnedByServer_23);
            args = new Type[]{};
            method = type.GetMethod("get_IsSpawned", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsSpawned_24);
            args = new Type[]{};
            method = type.GetMethod("get_IsSceneObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsSceneObject_25);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetSceneObjectStatus", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetSceneObjectStatus_26);
            args = new Type[]{};
            method = type.GetMethod("get_DestroyWithScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DestroyWithScene_27);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_DestroyWithScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_DestroyWithScene_28);
            args = new Type[]{};
            method = type.GetMethod("GetObservers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetObservers_29);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("IsNetworkVisibleTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsNetworkVisibleTo_30);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("NetworkShow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NetworkShow_31);
            args = new Type[]{typeof(System.Collections.Generic.List<Unity.Netcode.NetworkObject>), typeof(System.UInt64)};
            method = type.GetMethod("NetworkShow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NetworkShow_32);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("NetworkHide", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NetworkHide_33);
            args = new Type[]{typeof(System.Collections.Generic.List<Unity.Netcode.NetworkObject>), typeof(System.UInt64)};
            method = type.GetMethod("NetworkHide", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NetworkHide_34);
            args = new Type[]{typeof(UnityEngine.GameObject), typeof(Unity.Netcode.NetworkManager), typeof(System.UInt64), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("InstantiateAndSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InstantiateAndSpawn_35);
            args = new Type[]{typeof(Unity.Netcode.NetworkManager), typeof(System.UInt64), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("InstantiateAndSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InstantiateAndSpawn_36);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Spawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Spawn_37);
            args = new Type[]{typeof(System.UInt64), typeof(System.Boolean)};
            method = type.GetMethod("SpawnWithOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SpawnWithOwnership_38);
            args = new Type[]{typeof(System.UInt64), typeof(System.Boolean)};
            method = type.GetMethod("SpawnAsPlayerObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SpawnAsPlayerObject_39);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Despawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Despawn_40);
            args = new Type[]{};
            method = type.GetMethod("RemoveOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveOwnership_41);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("ChangeOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ChangeOwnership_42);
            args = new Type[]{};
            method = type.GetMethod("WorldPositionStays", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WorldPositionStays_43);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Boolean)};
            method = type.GetMethod("TrySetParent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TrySetParent_44);
            args = new Type[]{typeof(UnityEngine.GameObject), typeof(System.Boolean)};
            method = type.GetMethod("TrySetParent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TrySetParent_45);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("TryRemoveParent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryRemoveParent_46);
            args = new Type[]{typeof(Unity.Netcode.NetworkObject), typeof(System.Boolean)};
            method = type.GetMethod("TrySetParent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TrySetParent_47);
            args = new Type[]{typeof(Unity.Netcode.NetworkBehaviour)};
            method = type.GetMethod("GetNetworkBehaviourOrderIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNetworkBehaviourOrderIndex_48);

            field = type.GetField("DeferredDespawnTick", flag);
            app.RegisterCLRFieldGetter(field, get_DeferredDespawnTick_0);
            app.RegisterCLRFieldSetter(field, set_DeferredDespawnTick_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_DeferredDespawnTick_0, AssignFromStack_DeferredDespawnTick_0);
            field = type.GetField("OnDeferredDespawnComplete", flag);
            app.RegisterCLRFieldGetter(field, get_OnDeferredDespawnComplete_1);
            app.RegisterCLRFieldSetter(field, set_OnDeferredDespawnComplete_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnDeferredDespawnComplete_1, AssignFromStack_OnDeferredDespawnComplete_1);
            field = type.GetField("OnOwnershipPermissionsFailure", flag);
            app.RegisterCLRFieldGetter(field, get_OnOwnershipPermissionsFailure_2);
            app.RegisterCLRFieldSetter(field, set_OnOwnershipPermissionsFailure_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnOwnershipPermissionsFailure_2, AssignFromStack_OnOwnershipPermissionsFailure_2);
            field = type.GetField("OnOwnershipRequested", flag);
            app.RegisterCLRFieldGetter(field, get_OnOwnershipRequested_3);
            app.RegisterCLRFieldSetter(field, set_OnOwnershipRequested_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnOwnershipRequested_3, AssignFromStack_OnOwnershipRequested_3);
            field = type.GetField("OnOwnershipRequestResponse", flag);
            app.RegisterCLRFieldGetter(field, get_OnOwnershipRequestResponse_4);
            app.RegisterCLRFieldSetter(field, set_OnOwnershipRequestResponse_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnOwnershipRequestResponse_4, AssignFromStack_OnOwnershipRequestResponse_4);
            field = type.GetField("AlwaysReplicateAsRoot", flag);
            app.RegisterCLRFieldGetter(field, get_AlwaysReplicateAsRoot_5);
            app.RegisterCLRFieldSetter(field, set_AlwaysReplicateAsRoot_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_AlwaysReplicateAsRoot_5, AssignFromStack_AlwaysReplicateAsRoot_5);
            field = type.GetField("SynchronizeTransform", flag);
            app.RegisterCLRFieldGetter(field, get_SynchronizeTransform_6);
            app.RegisterCLRFieldSetter(field, set_SynchronizeTransform_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_SynchronizeTransform_6, AssignFromStack_SynchronizeTransform_6);
            field = type.GetField("ActiveSceneSynchronization", flag);
            app.RegisterCLRFieldGetter(field, get_ActiveSceneSynchronization_7);
            app.RegisterCLRFieldSetter(field, set_ActiveSceneSynchronization_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_ActiveSceneSynchronization_7, AssignFromStack_ActiveSceneSynchronization_7);
            field = type.GetField("SceneMigrationSynchronization", flag);
            app.RegisterCLRFieldGetter(field, get_SceneMigrationSynchronization_8);
            app.RegisterCLRFieldSetter(field, set_SceneMigrationSynchronization_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_SceneMigrationSynchronization_8, AssignFromStack_SceneMigrationSynchronization_8);
            field = type.GetField("OnMigratedToNewScene", flag);
            app.RegisterCLRFieldGetter(field, get_OnMigratedToNewScene_9);
            app.RegisterCLRFieldSetter(field, set_OnMigratedToNewScene_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnMigratedToNewScene_9, AssignFromStack_OnMigratedToNewScene_9);
            field = type.GetField("SpawnWithObservers", flag);
            app.RegisterCLRFieldGetter(field, get_SpawnWithObservers_10);
            app.RegisterCLRFieldSetter(field, set_SpawnWithObservers_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_SpawnWithObservers_10, AssignFromStack_SpawnWithObservers_10);
            field = type.GetField("CheckObjectVisibility", flag);
            app.RegisterCLRFieldGetter(field, get_CheckObjectVisibility_11);
            app.RegisterCLRFieldSetter(field, set_CheckObjectVisibility_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_CheckObjectVisibility_11, AssignFromStack_CheckObjectVisibility_11);
            field = type.GetField("IncludeTransformWhenSpawning", flag);
            app.RegisterCLRFieldGetter(field, get_IncludeTransformWhenSpawning_12);
            app.RegisterCLRFieldSetter(field, set_IncludeTransformWhenSpawning_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_IncludeTransformWhenSpawning_12, AssignFromStack_IncludeTransformWhenSpawning_12);
            field = type.GetField("DontDestroyWithOwner", flag);
            app.RegisterCLRFieldGetter(field, get_DontDestroyWithOwner_13);
            app.RegisterCLRFieldSetter(field, set_DontDestroyWithOwner_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_DontDestroyWithOwner_13, AssignFromStack_DontDestroyWithOwner_13);
            field = type.GetField("AutoObjectParentSync", flag);
            app.RegisterCLRFieldGetter(field, get_AutoObjectParentSync_14);
            app.RegisterCLRFieldSetter(field, set_AutoObjectParentSync_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_AutoObjectParentSync_14, AssignFromStack_AutoObjectParentSync_14);
            field = type.GetField("SyncOwnerTransformWhenParented", flag);
            app.RegisterCLRFieldGetter(field, get_SyncOwnerTransformWhenParented_15);
            app.RegisterCLRFieldSetter(field, set_SyncOwnerTransformWhenParented_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncOwnerTransformWhenParented_15, AssignFromStack_SyncOwnerTransformWhenParented_15);
            field = type.GetField("AllowOwnerToParent", flag);
            app.RegisterCLRFieldGetter(field, get_AllowOwnerToParent_16);
            app.RegisterCLRFieldSetter(field, set_AllowOwnerToParent_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_AllowOwnerToParent_16, AssignFromStack_AllowOwnerToParent_16);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.NetworkObject());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.NetworkObject[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_PrefabIdHash_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PrefabIdHash;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_NetworkTransforms_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.NetworkTransforms;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_NetworkRigidbodies_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.NetworkRigidbodies;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_CurrentParent_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CurrentParent;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_NetworkManager_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.NetworkManager;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DeferDespawn_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @destroy = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @tickOffset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DeferDespawn(@tickOffset, @destroy);

            return __ret;
        }

        static StackObject* get_IsOwnershipDistributable_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsOwnershipDistributable;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsOwnershipSessionOwner_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsOwnershipSessionOwner;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsOwnershipLocked_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsOwnershipLocked;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsOwnershipTransferable_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsOwnershipTransferable;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsOwnershipRequestRequired_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsOwnershipRequestRequired;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsRequestInProgress_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsRequestInProgress;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetOwnershipLock_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @lockOwnership = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SetOwnershipLock(@lockOwnership);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RequestOwnership_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RequestOwnership();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetOwnershipStatus_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject.OwnershipLockActions @lockAction = (Unity.Netcode.NetworkObject.OwnershipLockActions)typeof(Unity.Netcode.NetworkObject.OwnershipLockActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @clearAndSet = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.NetworkObject.OwnershipStatus @status = (Unity.Netcode.NetworkObject.OwnershipStatus)typeof(Unity.Netcode.NetworkObject.OwnershipStatus).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SetOwnershipStatus(@status, @clearAndSet, @lockAction);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RemoveOwnershipStatus_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject.OwnershipStatus @status = (Unity.Netcode.NetworkObject.OwnershipStatus)typeof(Unity.Netcode.NetworkObject.OwnershipStatus).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RemoveOwnershipStatus(@status);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* HasOwnershipStatus_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject.OwnershipStatus @status = (Unity.Netcode.NetworkObject.OwnershipStatus)typeof(Unity.Netcode.NetworkObject.OwnershipStatus).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HasOwnershipStatus(@status);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_HasAuthority_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HasAuthority;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_NetworkObjectId_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.NetworkObjectId;

            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_OwnerClientId_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.OwnerClientId;

            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_IsPlayerObject_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsPlayerObject;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsLocalPlayer_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsLocalPlayer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsOwner_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsOwner;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsOwnedByServer_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsOwnedByServer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsSpawned_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsSpawned;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsSceneObject_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsSceneObject;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetSceneObjectStatus_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @isSceneObject = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetSceneObjectStatus(@isSceneObject);

            return __ret;
        }

        static StackObject* get_DestroyWithScene_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DestroyWithScene;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_DestroyWithScene_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DestroyWithScene = value;

            return __ret;
        }

        static StackObject* GetObservers_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetObservers();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsNetworkVisibleTo_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsNetworkVisibleTo(@clientId);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* NetworkShow_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.NetworkShow(@clientId);

            return __ret;
        }

        static StackObject* NetworkShow_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<Unity.Netcode.NetworkObject> @networkObjects = (System.Collections.Generic.List<Unity.Netcode.NetworkObject>)typeof(System.Collections.Generic.List<Unity.Netcode.NetworkObject>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Unity.Netcode.NetworkObject.NetworkShow(@networkObjects, @clientId);

            return __ret;
        }

        static StackObject* NetworkHide_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.NetworkHide(@clientId);

            return __ret;
        }

        static StackObject* NetworkHide_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<Unity.Netcode.NetworkObject> @networkObjects = (System.Collections.Generic.List<Unity.Netcode.NetworkObject>)typeof(System.Collections.Generic.List<Unity.Netcode.NetworkObject>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Unity.Netcode.NetworkObject.NetworkHide(@networkObjects, @clientId);

            return __ret;
        }

        static StackObject* InstantiateAndSpawn_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @forceOverride = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @isPlayerObject = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean @destroyWithScene = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.UInt64 @ownerClientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            Unity.Netcode.NetworkManager @networkManager = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.GameObject @networkPrefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Unity.Netcode.NetworkObject.InstantiateAndSpawn(@networkPrefab, @networkManager, @ownerClientId, @destroyWithScene, @isPlayerObject, @forceOverride, @position, @rotation);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* InstantiateAndSpawn_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @forceOverride = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @isPlayerObject = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean @destroyWithScene = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.UInt64 @ownerClientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            Unity.Netcode.NetworkManager @networkManager = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.InstantiateAndSpawn(@networkManager, @ownerClientId, @destroyWithScene, @isPlayerObject, @forceOverride, @position, @rotation);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Spawn_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @destroyWithScene = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Spawn(@destroyWithScene);

            return __ret;
        }

        static StackObject* SpawnWithOwnership_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @destroyWithScene = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SpawnWithOwnership(@clientId, @destroyWithScene);

            return __ret;
        }

        static StackObject* SpawnAsPlayerObject_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @destroyWithScene = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SpawnAsPlayerObject(@clientId, @destroyWithScene);

            return __ret;
        }

        static StackObject* Despawn_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @destroy = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Despawn(@destroy);

            return __ret;
        }

        static StackObject* RemoveOwnership_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveOwnership();

            return __ret;
        }

        static StackObject* ChangeOwnership_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @newOwnerClientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ChangeOwnership(@newOwnerClientId);

            return __ret;
        }

        static StackObject* WorldPositionStays_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.WorldPositionStays();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TrySetParent_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @worldPositionStays = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @parent = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TrySetParent(@parent, @worldPositionStays);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TrySetParent_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @worldPositionStays = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @parent = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TrySetParent(@parent, @worldPositionStays);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryRemoveParent_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @worldPositionStays = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryRemoveParent(@worldPositionStays);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TrySetParent_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @worldPositionStays = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject @parent = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TrySetParent(@parent, @worldPositionStays);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetNetworkBehaviourOrderIndex_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkBehaviour @instance = (Unity.Netcode.NetworkBehaviour)typeof(Unity.Netcode.NetworkBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject instance_of_this_method = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetNetworkBehaviourOrderIndex(@instance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }


        static object get_DeferredDespawnTick_0(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).DeferredDespawnTick;
        }

        static StackObject* CopyToStack_DeferredDespawnTick_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).DeferredDespawnTick;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_DeferredDespawnTick_0(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).DeferredDespawnTick = (System.Int32)v;
        }

        static StackObject* AssignFromStack_DeferredDespawnTick_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @DeferredDespawnTick = ptr_of_this_method->Value;
            ((Unity.Netcode.NetworkObject)o).DeferredDespawnTick = @DeferredDespawnTick;
            return ptr_of_this_method;
        }

        static object get_OnDeferredDespawnComplete_1(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).OnDeferredDespawnComplete;
        }

        static StackObject* CopyToStack_OnDeferredDespawnComplete_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).OnDeferredDespawnComplete;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnDeferredDespawnComplete_1(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).OnDeferredDespawnComplete = (Unity.Netcode.NetworkObject.OnDeferedDespawnCompleteDelegateHandler)v;
        }

        static StackObject* AssignFromStack_OnDeferredDespawnComplete_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkObject.OnDeferedDespawnCompleteDelegateHandler @OnDeferredDespawnComplete = (Unity.Netcode.NetworkObject.OnDeferedDespawnCompleteDelegateHandler)typeof(Unity.Netcode.NetworkObject.OnDeferedDespawnCompleteDelegateHandler).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Unity.Netcode.NetworkObject)o).OnDeferredDespawnComplete = @OnDeferredDespawnComplete;
            return ptr_of_this_method;
        }

        static object get_OnOwnershipPermissionsFailure_2(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).OnOwnershipPermissionsFailure;
        }

        static StackObject* CopyToStack_OnOwnershipPermissionsFailure_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).OnOwnershipPermissionsFailure;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnOwnershipPermissionsFailure_2(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).OnOwnershipPermissionsFailure = (Unity.Netcode.NetworkObject.OnOwnershipPermissionsFailureDelegateHandler)v;
        }

        static StackObject* AssignFromStack_OnOwnershipPermissionsFailure_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkObject.OnOwnershipPermissionsFailureDelegateHandler @OnOwnershipPermissionsFailure = (Unity.Netcode.NetworkObject.OnOwnershipPermissionsFailureDelegateHandler)typeof(Unity.Netcode.NetworkObject.OnOwnershipPermissionsFailureDelegateHandler).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Unity.Netcode.NetworkObject)o).OnOwnershipPermissionsFailure = @OnOwnershipPermissionsFailure;
            return ptr_of_this_method;
        }

        static object get_OnOwnershipRequested_3(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).OnOwnershipRequested;
        }

        static StackObject* CopyToStack_OnOwnershipRequested_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).OnOwnershipRequested;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnOwnershipRequested_3(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).OnOwnershipRequested = (Unity.Netcode.NetworkObject.OnOwnershipRequestedDelegateHandler)v;
        }

        static StackObject* AssignFromStack_OnOwnershipRequested_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkObject.OnOwnershipRequestedDelegateHandler @OnOwnershipRequested = (Unity.Netcode.NetworkObject.OnOwnershipRequestedDelegateHandler)typeof(Unity.Netcode.NetworkObject.OnOwnershipRequestedDelegateHandler).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Unity.Netcode.NetworkObject)o).OnOwnershipRequested = @OnOwnershipRequested;
            return ptr_of_this_method;
        }

        static object get_OnOwnershipRequestResponse_4(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).OnOwnershipRequestResponse;
        }

        static StackObject* CopyToStack_OnOwnershipRequestResponse_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).OnOwnershipRequestResponse;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnOwnershipRequestResponse_4(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).OnOwnershipRequestResponse = (Unity.Netcode.NetworkObject.OnOwnershipRequestResponseDelegateHandler)v;
        }

        static StackObject* AssignFromStack_OnOwnershipRequestResponse_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkObject.OnOwnershipRequestResponseDelegateHandler @OnOwnershipRequestResponse = (Unity.Netcode.NetworkObject.OnOwnershipRequestResponseDelegateHandler)typeof(Unity.Netcode.NetworkObject.OnOwnershipRequestResponseDelegateHandler).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Unity.Netcode.NetworkObject)o).OnOwnershipRequestResponse = @OnOwnershipRequestResponse;
            return ptr_of_this_method;
        }

        static object get_AlwaysReplicateAsRoot_5(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).AlwaysReplicateAsRoot;
        }

        static StackObject* CopyToStack_AlwaysReplicateAsRoot_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).AlwaysReplicateAsRoot;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AlwaysReplicateAsRoot_5(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).AlwaysReplicateAsRoot = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AlwaysReplicateAsRoot_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AlwaysReplicateAsRoot = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkObject)o).AlwaysReplicateAsRoot = @AlwaysReplicateAsRoot;
            return ptr_of_this_method;
        }

        static object get_SynchronizeTransform_6(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).SynchronizeTransform;
        }

        static StackObject* CopyToStack_SynchronizeTransform_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).SynchronizeTransform;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SynchronizeTransform_6(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).SynchronizeTransform = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SynchronizeTransform_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SynchronizeTransform = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkObject)o).SynchronizeTransform = @SynchronizeTransform;
            return ptr_of_this_method;
        }

        static object get_ActiveSceneSynchronization_7(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).ActiveSceneSynchronization;
        }

        static StackObject* CopyToStack_ActiveSceneSynchronization_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).ActiveSceneSynchronization;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ActiveSceneSynchronization_7(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).ActiveSceneSynchronization = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ActiveSceneSynchronization_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ActiveSceneSynchronization = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkObject)o).ActiveSceneSynchronization = @ActiveSceneSynchronization;
            return ptr_of_this_method;
        }

        static object get_SceneMigrationSynchronization_8(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).SceneMigrationSynchronization;
        }

        static StackObject* CopyToStack_SceneMigrationSynchronization_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).SceneMigrationSynchronization;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SceneMigrationSynchronization_8(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).SceneMigrationSynchronization = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SceneMigrationSynchronization_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SceneMigrationSynchronization = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkObject)o).SceneMigrationSynchronization = @SceneMigrationSynchronization;
            return ptr_of_this_method;
        }

        static object get_OnMigratedToNewScene_9(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).OnMigratedToNewScene;
        }

        static StackObject* CopyToStack_OnMigratedToNewScene_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).OnMigratedToNewScene;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnMigratedToNewScene_9(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).OnMigratedToNewScene = (System.Action)v;
        }

        static StackObject* AssignFromStack_OnMigratedToNewScene_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @OnMigratedToNewScene = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Unity.Netcode.NetworkObject)o).OnMigratedToNewScene = @OnMigratedToNewScene;
            return ptr_of_this_method;
        }

        static object get_SpawnWithObservers_10(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).SpawnWithObservers;
        }

        static StackObject* CopyToStack_SpawnWithObservers_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).SpawnWithObservers;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SpawnWithObservers_10(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).SpawnWithObservers = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SpawnWithObservers_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SpawnWithObservers = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkObject)o).SpawnWithObservers = @SpawnWithObservers;
            return ptr_of_this_method;
        }

        static object get_CheckObjectVisibility_11(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).CheckObjectVisibility;
        }

        static StackObject* CopyToStack_CheckObjectVisibility_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).CheckObjectVisibility;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CheckObjectVisibility_11(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).CheckObjectVisibility = (Unity.Netcode.NetworkObject.VisibilityDelegate)v;
        }

        static StackObject* AssignFromStack_CheckObjectVisibility_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkObject.VisibilityDelegate @CheckObjectVisibility = (Unity.Netcode.NetworkObject.VisibilityDelegate)typeof(Unity.Netcode.NetworkObject.VisibilityDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Unity.Netcode.NetworkObject)o).CheckObjectVisibility = @CheckObjectVisibility;
            return ptr_of_this_method;
        }

        static object get_IncludeTransformWhenSpawning_12(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).IncludeTransformWhenSpawning;
        }

        static StackObject* CopyToStack_IncludeTransformWhenSpawning_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).IncludeTransformWhenSpawning;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_IncludeTransformWhenSpawning_12(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).IncludeTransformWhenSpawning = (Unity.Netcode.NetworkObject.SpawnDelegate)v;
        }

        static StackObject* AssignFromStack_IncludeTransformWhenSpawning_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkObject.SpawnDelegate @IncludeTransformWhenSpawning = (Unity.Netcode.NetworkObject.SpawnDelegate)typeof(Unity.Netcode.NetworkObject.SpawnDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Unity.Netcode.NetworkObject)o).IncludeTransformWhenSpawning = @IncludeTransformWhenSpawning;
            return ptr_of_this_method;
        }

        static object get_DontDestroyWithOwner_13(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).DontDestroyWithOwner;
        }

        static StackObject* CopyToStack_DontDestroyWithOwner_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).DontDestroyWithOwner;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_DontDestroyWithOwner_13(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).DontDestroyWithOwner = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_DontDestroyWithOwner_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @DontDestroyWithOwner = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkObject)o).DontDestroyWithOwner = @DontDestroyWithOwner;
            return ptr_of_this_method;
        }

        static object get_AutoObjectParentSync_14(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).AutoObjectParentSync;
        }

        static StackObject* CopyToStack_AutoObjectParentSync_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).AutoObjectParentSync;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AutoObjectParentSync_14(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).AutoObjectParentSync = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AutoObjectParentSync_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AutoObjectParentSync = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkObject)o).AutoObjectParentSync = @AutoObjectParentSync;
            return ptr_of_this_method;
        }

        static object get_SyncOwnerTransformWhenParented_15(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).SyncOwnerTransformWhenParented;
        }

        static StackObject* CopyToStack_SyncOwnerTransformWhenParented_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).SyncOwnerTransformWhenParented;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncOwnerTransformWhenParented_15(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).SyncOwnerTransformWhenParented = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncOwnerTransformWhenParented_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncOwnerTransformWhenParented = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkObject)o).SyncOwnerTransformWhenParented = @SyncOwnerTransformWhenParented;
            return ptr_of_this_method;
        }

        static object get_AllowOwnerToParent_16(ref object o)
        {
            return ((Unity.Netcode.NetworkObject)o).AllowOwnerToParent;
        }

        static StackObject* CopyToStack_AllowOwnerToParent_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkObject)o).AllowOwnerToParent;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AllowOwnerToParent_16(ref object o, object v)
        {
            ((Unity.Netcode.NetworkObject)o).AllowOwnerToParent = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AllowOwnerToParent_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AllowOwnerToParent = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkObject)o).AllowOwnerToParent = @AllowOwnerToParent;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.Netcode.NetworkObject();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
