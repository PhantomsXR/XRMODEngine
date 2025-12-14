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
    unsafe class Unity_Netcode_NetworkManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.NetworkManager);
            args = new Type[]{typeof(System.Action<Unity.Netcode.NetworkManager>)};
            method = type.GetMethod("add_OnInstantiated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnInstantiated_0);
            args = new Type[]{typeof(System.Action<Unity.Netcode.NetworkManager>)};
            method = type.GetMethod("remove_OnInstantiated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnInstantiated_1);
            args = new Type[]{typeof(System.Action<Unity.Netcode.NetworkManager>)};
            method = type.GetMethod("add_OnDestroying", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnDestroying_2);
            args = new Type[]{typeof(System.Action<Unity.Netcode.NetworkManager>)};
            method = type.GetMethod("remove_OnDestroying", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnDestroying_3);
            args = new Type[]{};
            method = type.GetMethod("get_DistributedAuthorityMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DistributedAuthorityMode_4);
            args = new Type[]{};
            method = type.GetMethod("get_CMBServiceConnection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CMBServiceConnection_5);
            args = new Type[]{};
            method = type.GetMethod("get_AutoSpawnPlayerPrefabClientSide", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AutoSpawnPlayerPrefabClientSide_6);
            args = new Type[]{};
            method = type.GetMethod("get_DAHost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DAHost_7);
            args = new Type[]{};
            method = type.GetMethod("get_CurrentSessionOwner", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CurrentSessionOwner_8);
            args = new Type[]{typeof(Unity.Netcode.NetworkManager.OnSessionOwnerPromotedDelegateHandler)};
            method = type.GetMethod("add_OnSessionOwnerPromoted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnSessionOwnerPromoted_9);
            args = new Type[]{typeof(Unity.Netcode.NetworkManager.OnSessionOwnerPromotedDelegateHandler)};
            method = type.GetMethod("remove_OnSessionOwnerPromoted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnSessionOwnerPromoted_10);
            args = new Type[]{typeof(Unity.Netcode.NetworkUpdateStage)};
            method = type.GetMethod("NetworkUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NetworkUpdate_11);
            args = new Type[]{};
            method = type.GetMethod("get_LocalClientId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_LocalClientId_12);
            args = new Type[]{};
            method = type.GetMethod("get_ConnectedClients", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ConnectedClients_13);
            args = new Type[]{};
            method = type.GetMethod("get_ConnectedClientsList", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ConnectedClientsList_14);
            args = new Type[]{};
            method = type.GetMethod("get_ConnectedClientsIds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ConnectedClientsIds_15);
            args = new Type[]{};
            method = type.GetMethod("get_LocalClient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_LocalClient_16);
            args = new Type[]{};
            method = type.GetMethod("get_IsServer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsServer_17);
            args = new Type[]{};
            method = type.GetMethod("get_ServerIsHost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ServerIsHost_18);
            args = new Type[]{};
            method = type.GetMethod("get_IsClient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsClient_19);
            args = new Type[]{};
            method = type.GetMethod("get_IsHost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsHost_20);
            args = new Type[]{};
            method = type.GetMethod("get_DisconnectReason", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DisconnectReason_21);
            args = new Type[]{};
            method = type.GetMethod("get_IsListening", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsListening_22);
            args = new Type[]{};
            method = type.GetMethod("get_IsConnectedClient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsConnectedClient_23);
            args = new Type[]{};
            method = type.GetMethod("get_IsApproved", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsApproved_24);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_OnTransportFailure", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnTransportFailure_25);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_OnTransportFailure", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnTransportFailure_26);
            args = new Type[]{typeof(Unity.Netcode.NetworkManager.ReanticipateDelegate)};
            method = type.GetMethod("add_OnReanticipate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnReanticipate_27);
            args = new Type[]{typeof(Unity.Netcode.NetworkManager.ReanticipateDelegate)};
            method = type.GetMethod("remove_OnReanticipate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnReanticipate_28);
            args = new Type[]{};
            method = type.GetMethod("get_ConnectionApprovalCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ConnectionApprovalCallback_29);
            args = new Type[]{typeof(System.Action<Unity.Netcode.NetworkManager.ConnectionApprovalRequest, Unity.Netcode.NetworkManager.ConnectionApprovalResponse>)};
            method = type.GetMethod("set_ConnectionApprovalCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ConnectionApprovalCallback_30);
            args = new Type[]{typeof(System.Action<System.UInt64>)};
            method = type.GetMethod("add_OnClientConnectedCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnClientConnectedCallback_31);
            args = new Type[]{typeof(System.Action<System.UInt64>)};
            method = type.GetMethod("remove_OnClientConnectedCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnClientConnectedCallback_32);
            args = new Type[]{typeof(System.Action<System.UInt64>)};
            method = type.GetMethod("add_OnClientDisconnectCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnClientDisconnectCallback_33);
            args = new Type[]{typeof(System.Action<System.UInt64>)};
            method = type.GetMethod("remove_OnClientDisconnectCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnClientDisconnectCallback_34);
            args = new Type[]{typeof(System.Action<Unity.Netcode.NetworkManager, Unity.Netcode.ConnectionEventData>)};
            method = type.GetMethod("add_OnConnectionEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnConnectionEvent_35);
            args = new Type[]{typeof(System.Action<Unity.Netcode.NetworkManager, Unity.Netcode.ConnectionEventData>)};
            method = type.GetMethod("remove_OnConnectionEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnConnectionEvent_36);
            args = new Type[]{};
            method = type.GetMethod("get_ConnectedHostname", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ConnectedHostname_37);
            args = new Type[]{};
            method = type.GetMethod("get_ShutdownInProgress", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ShutdownInProgress_38);
            args = new Type[]{};
            method = type.GetMethod("get_LocalTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_LocalTime_39);
            args = new Type[]{};
            method = type.GetMethod("get_ServerTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ServerTime_40);
            args = new Type[]{};
            method = type.GetMethod("get_Singleton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Singleton_41);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_OnServerStarted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnServerStarted_42);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_OnServerStarted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnServerStarted_43);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_OnClientStarted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnClientStarted_44);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_OnClientStarted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnClientStarted_45);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("add_OnServerStopped", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnServerStopped_46);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("remove_OnServerStopped", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnServerStopped_47);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("add_OnClientStopped", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnClientStopped_48);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("remove_OnClientStopped", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnClientStopped_49);
            args = new Type[]{};
            method = type.GetMethod("get_PrefabHandler", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PrefabHandler_50);
            args = new Type[]{};
            method = type.GetMethod("get_SpawnManager", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SpawnManager_51);
            args = new Type[]{};
            method = type.GetMethod("get_CustomMessagingManager", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CustomMessagingManager_52);
            args = new Type[]{};
            method = type.GetMethod("get_SceneManager", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SceneManager_53);
            args = new Type[]{};
            method = type.GetMethod("get_NetworkTimeSystem", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NetworkTimeSystem_54);
            args = new Type[]{};
            method = type.GetMethod("get_NetworkTickSystem", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NetworkTickSystem_55);
            args = new Type[]{};
            method = type.GetMethod("SetSingleton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetSingleton_56);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("GetNetworkPrefabOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNetworkPrefabOverride_57);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("AddNetworkPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddNetworkPrefab_58);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("RemoveNetworkPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveNetworkPrefab_59);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_MaximumTransmissionUnitSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaximumTransmissionUnitSize_60);
            args = new Type[]{};
            method = type.GetMethod("get_MaximumTransmissionUnitSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaximumTransmissionUnitSize_61);
            args = new Type[]{typeof(System.UInt64), typeof(System.Int32)};
            method = type.GetMethod("SetPeerMTU", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPeerMTU_62);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("GetPeerMTU", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPeerMTU_63);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_MaximumFragmentedMessageSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaximumFragmentedMessageSize_64);
            args = new Type[]{};
            method = type.GetMethod("get_MaximumFragmentedMessageSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaximumFragmentedMessageSize_65);
            args = new Type[]{};
            method = type.GetMethod("StartServer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartServer_66);
            args = new Type[]{};
            method = type.GetMethod("StartClient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartClient_67);
            args = new Type[]{};
            method = type.GetMethod("StartHost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartHost_68);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("DisconnectClient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DisconnectClient_69);
            args = new Type[]{typeof(System.UInt64), typeof(System.String)};
            method = type.GetMethod("DisconnectClient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DisconnectClient_70);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Shutdown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Shutdown_71);

            field = type.GetField("OnFetchLocalPlayerPrefabToSpawn", flag);
            app.RegisterCLRFieldGetter(field, get_OnFetchLocalPlayerPrefabToSpawn_3);
            app.RegisterCLRFieldSetter(field, set_OnFetchLocalPlayerPrefabToSpawn_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnFetchLocalPlayerPrefabToSpawn_3, AssignFromStack_OnFetchLocalPlayerPrefabToSpawn_3);
            field = type.GetField("ServerClientId", flag);
            app.RegisterCLRFieldGetter(field, get_ServerClientId_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerClientId_4, null);
            field = type.GetField("PendingClients", flag);
            app.RegisterCLRFieldGetter(field, get_PendingClients_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_PendingClients_5, null);
            field = type.GetField("NetworkConfig", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkConfig_6);
            app.RegisterCLRFieldSetter(field, set_NetworkConfig_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_NetworkConfig_6, AssignFromStack_NetworkConfig_6);
            field = type.GetField("RunInBackground", flag);
            app.RegisterCLRFieldGetter(field, get_RunInBackground_7);
            app.RegisterCLRFieldSetter(field, set_RunInBackground_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_RunInBackground_7, AssignFromStack_RunInBackground_7);
            field = type.GetField("LogLevel", flag);
            app.RegisterCLRFieldGetter(field, get_LogLevel_8);
            app.RegisterCLRFieldSetter(field, set_LogLevel_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_LogLevel_8, AssignFromStack_LogLevel_8);
            field = type.GetField("RpcTarget", flag);
            app.RegisterCLRFieldGetter(field, get_RpcTarget_9);
            app.RegisterCLRFieldSetter(field, set_RpcTarget_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_RpcTarget_9, AssignFromStack_RpcTarget_9);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.NetworkManager());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.NetworkManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* add_OnInstantiated_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Netcode.NetworkManager> @value = (System.Action<Unity.Netcode.NetworkManager>)typeof(System.Action<Unity.Netcode.NetworkManager>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Unity.Netcode.NetworkManager.OnInstantiated += value;

            return __ret;
        }

        static StackObject* remove_OnInstantiated_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Netcode.NetworkManager> @value = (System.Action<Unity.Netcode.NetworkManager>)typeof(System.Action<Unity.Netcode.NetworkManager>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Unity.Netcode.NetworkManager.OnInstantiated -= value;

            return __ret;
        }

        static StackObject* add_OnDestroying_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Netcode.NetworkManager> @value = (System.Action<Unity.Netcode.NetworkManager>)typeof(System.Action<Unity.Netcode.NetworkManager>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Unity.Netcode.NetworkManager.OnDestroying += value;

            return __ret;
        }

        static StackObject* remove_OnDestroying_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Netcode.NetworkManager> @value = (System.Action<Unity.Netcode.NetworkManager>)typeof(System.Action<Unity.Netcode.NetworkManager>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Unity.Netcode.NetworkManager.OnDestroying -= value;

            return __ret;
        }

        static StackObject* get_DistributedAuthorityMode_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DistributedAuthorityMode;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_CMBServiceConnection_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CMBServiceConnection;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_AutoSpawnPlayerPrefabClientSide_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AutoSpawnPlayerPrefabClientSide;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_DAHost_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DAHost;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_CurrentSessionOwner_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CurrentSessionOwner;

            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* add_OnSessionOwnerPromoted_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager.OnSessionOwnerPromotedDelegateHandler @value = (Unity.Netcode.NetworkManager.OnSessionOwnerPromotedDelegateHandler)typeof(Unity.Netcode.NetworkManager.OnSessionOwnerPromotedDelegateHandler).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnSessionOwnerPromoted += value;

            return __ret;
        }

        static StackObject* remove_OnSessionOwnerPromoted_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager.OnSessionOwnerPromotedDelegateHandler @value = (Unity.Netcode.NetworkManager.OnSessionOwnerPromotedDelegateHandler)typeof(Unity.Netcode.NetworkManager.OnSessionOwnerPromotedDelegateHandler).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnSessionOwnerPromoted -= value;

            return __ret;
        }

        static StackObject* NetworkUpdate_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkUpdateStage @updateStage = (Unity.Netcode.NetworkUpdateStage)typeof(Unity.Netcode.NetworkUpdateStage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.NetworkUpdate(@updateStage);

            return __ret;
        }

        static StackObject* get_LocalClientId_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LocalClientId;

            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_ConnectedClients_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ConnectedClients;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_ConnectedClientsList_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ConnectedClientsList;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_ConnectedClientsIds_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ConnectedClientsIds;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_LocalClient_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LocalClient;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_IsServer_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsServer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_ServerIsHost_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ServerIsHost;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsClient_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsClient;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsHost_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsHost;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_DisconnectReason_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DisconnectReason;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_IsListening_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsListening;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsConnectedClient_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsConnectedClient;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsApproved_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsApproved;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* add_OnTransportFailure_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnTransportFailure += value;

            return __ret;
        }

        static StackObject* remove_OnTransportFailure_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnTransportFailure -= value;

            return __ret;
        }

        static StackObject* add_OnReanticipate_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager.ReanticipateDelegate @value = (Unity.Netcode.NetworkManager.ReanticipateDelegate)typeof(Unity.Netcode.NetworkManager.ReanticipateDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnReanticipate += value;

            return __ret;
        }

        static StackObject* remove_OnReanticipate_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager.ReanticipateDelegate @value = (Unity.Netcode.NetworkManager.ReanticipateDelegate)typeof(Unity.Netcode.NetworkManager.ReanticipateDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnReanticipate -= value;

            return __ret;
        }

        static StackObject* get_ConnectionApprovalCallback_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ConnectionApprovalCallback;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_ConnectionApprovalCallback_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Netcode.NetworkManager.ConnectionApprovalRequest, Unity.Netcode.NetworkManager.ConnectionApprovalResponse> @value = (System.Action<Unity.Netcode.NetworkManager.ConnectionApprovalRequest, Unity.Netcode.NetworkManager.ConnectionApprovalResponse>)typeof(System.Action<Unity.Netcode.NetworkManager.ConnectionApprovalRequest, Unity.Netcode.NetworkManager.ConnectionApprovalResponse>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ConnectionApprovalCallback = value;

            return __ret;
        }

        static StackObject* add_OnClientConnectedCallback_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.UInt64> @value = (System.Action<System.UInt64>)typeof(System.Action<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnClientConnectedCallback += value;

            return __ret;
        }

        static StackObject* remove_OnClientConnectedCallback_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.UInt64> @value = (System.Action<System.UInt64>)typeof(System.Action<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnClientConnectedCallback -= value;

            return __ret;
        }

        static StackObject* add_OnClientDisconnectCallback_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.UInt64> @value = (System.Action<System.UInt64>)typeof(System.Action<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnClientDisconnectCallback += value;

            return __ret;
        }

        static StackObject* remove_OnClientDisconnectCallback_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.UInt64> @value = (System.Action<System.UInt64>)typeof(System.Action<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnClientDisconnectCallback -= value;

            return __ret;
        }

        static StackObject* add_OnConnectionEvent_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Netcode.NetworkManager, Unity.Netcode.ConnectionEventData> @value = (System.Action<Unity.Netcode.NetworkManager, Unity.Netcode.ConnectionEventData>)typeof(System.Action<Unity.Netcode.NetworkManager, Unity.Netcode.ConnectionEventData>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnConnectionEvent += value;

            return __ret;
        }

        static StackObject* remove_OnConnectionEvent_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Netcode.NetworkManager, Unity.Netcode.ConnectionEventData> @value = (System.Action<Unity.Netcode.NetworkManager, Unity.Netcode.ConnectionEventData>)typeof(System.Action<Unity.Netcode.NetworkManager, Unity.Netcode.ConnectionEventData>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnConnectionEvent -= value;

            return __ret;
        }

        static StackObject* get_ConnectedHostname_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ConnectedHostname;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_ShutdownInProgress_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ShutdownInProgress;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_LocalTime_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LocalTime;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_ServerTime_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ServerTime;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Singleton_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Unity.Netcode.NetworkManager.Singleton;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* add_OnServerStarted_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnServerStarted += value;

            return __ret;
        }

        static StackObject* remove_OnServerStarted_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnServerStarted -= value;

            return __ret;
        }

        static StackObject* add_OnClientStarted_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnClientStarted += value;

            return __ret;
        }

        static StackObject* remove_OnClientStarted_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnClientStarted -= value;

            return __ret;
        }

        static StackObject* add_OnServerStopped_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> @value = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnServerStopped += value;

            return __ret;
        }

        static StackObject* remove_OnServerStopped_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> @value = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnServerStopped -= value;

            return __ret;
        }

        static StackObject* add_OnClientStopped_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> @value = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnClientStopped += value;

            return __ret;
        }

        static StackObject* remove_OnClientStopped_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> @value = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnClientStopped -= value;

            return __ret;
        }

        static StackObject* get_PrefabHandler_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PrefabHandler;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_SpawnManager_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SpawnManager;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_CustomMessagingManager_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CustomMessagingManager;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_SceneManager_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SceneManager;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_NetworkTimeSystem_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.NetworkTimeSystem;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_NetworkTickSystem_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.NetworkTickSystem;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetSingleton_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetSingleton();

            return __ret;
        }

        static StackObject* GetNetworkPrefabOverride_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @gameObject = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetNetworkPrefabOverride(@gameObject);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AddNetworkPrefab_58(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @prefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddNetworkPrefab(@prefab);

            return __ret;
        }

        static StackObject* RemoveNetworkPrefab_59(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @prefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveNetworkPrefab(@prefab);

            return __ret;
        }

        static StackObject* set_MaximumTransmissionUnitSize_60(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaximumTransmissionUnitSize = value;

            return __ret;
        }

        static StackObject* get_MaximumTransmissionUnitSize_61(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaximumTransmissionUnitSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetPeerMTU_62(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @size = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPeerMTU(@clientId, @size);

            return __ret;
        }

        static StackObject* GetPeerMTU_63(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPeerMTU(@clientId);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaximumFragmentedMessageSize_64(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaximumFragmentedMessageSize = value;

            return __ret;
        }

        static StackObject* get_MaximumFragmentedMessageSize_65(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaximumFragmentedMessageSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* StartServer_66(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.StartServer();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* StartClient_67(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.StartClient();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* StartHost_68(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.StartHost();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* DisconnectClient_69(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DisconnectClient(@clientId);

            return __ret;
        }

        static StackObject* DisconnectClient_70(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @reason = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DisconnectClient(@clientId, @reason);

            return __ret;
        }

        static StackObject* Shutdown_71(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @discardMessageQueue = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkManager instance_of_this_method = (Unity.Netcode.NetworkManager)typeof(Unity.Netcode.NetworkManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Shutdown(@discardMessageQueue);

            return __ret;
        }


       
        static object get_OnFetchLocalPlayerPrefabToSpawn_3(ref object o)
        {
            return ((Unity.Netcode.NetworkManager)o).OnFetchLocalPlayerPrefabToSpawn;
        }

        static StackObject* CopyToStack_OnFetchLocalPlayerPrefabToSpawn_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkManager)o).OnFetchLocalPlayerPrefabToSpawn;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnFetchLocalPlayerPrefabToSpawn_3(ref object o, object v)
        {
            ((Unity.Netcode.NetworkManager)o).OnFetchLocalPlayerPrefabToSpawn = (Unity.Netcode.NetworkManager.OnFetchLocalPlayerPrefabToSpawnDelegateHandler)v;
        }

        static StackObject* AssignFromStack_OnFetchLocalPlayerPrefabToSpawn_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkManager.OnFetchLocalPlayerPrefabToSpawnDelegateHandler @OnFetchLocalPlayerPrefabToSpawn = (Unity.Netcode.NetworkManager.OnFetchLocalPlayerPrefabToSpawnDelegateHandler)typeof(Unity.Netcode.NetworkManager.OnFetchLocalPlayerPrefabToSpawnDelegateHandler).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Unity.Netcode.NetworkManager)o).OnFetchLocalPlayerPrefabToSpawn = @OnFetchLocalPlayerPrefabToSpawn;
            return ptr_of_this_method;
        }

        static object get_ServerClientId_4(ref object o)
        {
            return Unity.Netcode.NetworkManager.ServerClientId;
        }

        static StackObject* CopyToStack_ServerClientId_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.NetworkManager.ServerClientId;
            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_PendingClients_5(ref object o)
        {
            return ((Unity.Netcode.NetworkManager)o).PendingClients;
        }

        static StackObject* CopyToStack_PendingClients_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkManager)o).PendingClients;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_NetworkConfig_6(ref object o)
        {
            return ((Unity.Netcode.NetworkManager)o).NetworkConfig;
        }

        static StackObject* CopyToStack_NetworkConfig_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkManager)o).NetworkConfig;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NetworkConfig_6(ref object o, object v)
        {
            ((Unity.Netcode.NetworkManager)o).NetworkConfig = (Unity.Netcode.NetworkConfig)v;
        }

        static StackObject* AssignFromStack_NetworkConfig_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkConfig @NetworkConfig = (Unity.Netcode.NetworkConfig)typeof(Unity.Netcode.NetworkConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkManager)o).NetworkConfig = @NetworkConfig;
            return ptr_of_this_method;
        }

        static object get_RunInBackground_7(ref object o)
        {
            return ((Unity.Netcode.NetworkManager)o).RunInBackground;
        }

        static StackObject* CopyToStack_RunInBackground_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkManager)o).RunInBackground;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_RunInBackground_7(ref object o, object v)
        {
            ((Unity.Netcode.NetworkManager)o).RunInBackground = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_RunInBackground_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @RunInBackground = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkManager)o).RunInBackground = @RunInBackground;
            return ptr_of_this_method;
        }

        static object get_LogLevel_8(ref object o)
        {
            return ((Unity.Netcode.NetworkManager)o).LogLevel;
        }

        static StackObject* CopyToStack_LogLevel_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkManager)o).LogLevel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LogLevel_8(ref object o, object v)
        {
            ((Unity.Netcode.NetworkManager)o).LogLevel = (Unity.Netcode.LogLevel)v;
        }

        static StackObject* AssignFromStack_LogLevel_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.LogLevel @LogLevel = (Unity.Netcode.LogLevel)typeof(Unity.Netcode.LogLevel).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Unity.Netcode.NetworkManager)o).LogLevel = @LogLevel;
            return ptr_of_this_method;
        }

        static object get_RpcTarget_9(ref object o)
        {
            return ((Unity.Netcode.NetworkManager)o).RpcTarget;
        }

        static StackObject* CopyToStack_RpcTarget_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkManager)o).RpcTarget;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_RpcTarget_9(ref object o, object v)
        {
            ((Unity.Netcode.NetworkManager)o).RpcTarget = (Unity.Netcode.RpcTarget)v;
        }

        static StackObject* AssignFromStack_RpcTarget_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.RpcTarget @RpcTarget = (Unity.Netcode.RpcTarget)typeof(Unity.Netcode.RpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkManager)o).RpcTarget = @RpcTarget;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.Netcode.NetworkManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
