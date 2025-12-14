using System;
using System.Collections.Generic;
using System.Reflection;
using Phantom.XRMOD.NetcodeModule.Runtime;
using Phantom.XRMOD.NetcodeModule.Runtime.TableSystem;
using Unity.Netcode;
using UnityFusion.CLRBinding.Adapter;
using UnityFusion.Runtime.Intepreter;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif
namespace UnityFusion.Runtime.Generated
{
    class CLRBindings
    {
//will auto register in unity
#if UNITY_5_3_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#endif
        static private void RegisterBindingAction()
        {
            UnityFusion.Runtime.CLRBinding.CLRBindingUtils.RegisterBindingAction(Initialize);
        }

        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            app.RegisterCrossBindingAdaptor(new NetworkBehaviourAdapter());
            app.DelegateManager.RegisterFunctionDelegate<ILTypeInstance>();
            app.DelegateManager.RegisterMethodDelegate<String, RpcParams>();
            app.DelegateManager.RegisterMethodDelegate<ulong, bool>();
            app.DelegateManager.RegisterMethodDelegate<PlayerScoreEntry>();
            app.DelegateManager.RegisterMethodDelegate<NetworkedSeat>();
            app.DelegateManager.RegisterMethodDelegate<NetworkManager, ConnectionEventData>();
            app.DelegateManager
                .RegisterMethodDelegate<NetworkManager.ConnectionApprovalRequest,
                    NetworkManager.ConnectionApprovalResponse>();

            RegisterUnityAction<UnityEngine.Color32, UnityEngine.Color32>(app);
            RegisterUnityAction<UnityEngine.Quaternion, UnityEngine.Quaternion>(app);
            RegisterUnityAction<UnityEngine.Ray, UnityEngine.Ray>(app);
            RegisterUnityAction<UnityEngine.Ray2D, UnityEngine.Ray2D>(app);
            RegisterUnityAction<UnityEngine.Rect, UnityEngine.Rect>(app);
            RegisterUnityAction<UnityEngine.Vector2, UnityEngine.Vector2>(app);
            RegisterUnityAction<UnityEngine.Vector3, UnityEngine.Vector3>(app);
            RegisterUnityAction<UnityEngine.Vector4, UnityEngine.Vector4>(app);
            RegisterUnityAction<UnityEngine.Vector3Int, UnityEngine.Vector3Int>(app);
            RegisterUnityAction<UnityEngine.Vector2Int, UnityEngine.Vector2Int>(app);
            RegisterUnityAction<NetworkedSeat, NetworkedSeat>(app);
            RegisterUnityAction<int, int>(app);
            RegisterUnityAction<uint, uint>(app);
            RegisterUnityAction<float, float>(app);
            RegisterUnityAction<byte, byte>(app);
            RegisterUnityAction<bool, bool>(app);
            RegisterUnityAction<char, char>(app);
            RegisterUnityAction<decimal, decimal>(app);
            RegisterUnityAction<double, double>(app);
            RegisterUnityAction<sbyte, sbyte>(app);
            RegisterUnityAction<short, short>(app);
            RegisterUnityAction<ulong, ulong>(app);
            RegisterUnityAction<ushort, ushort>(app);
            RegisterUnityAction<long, long>(app);
            RegisterUnityAction<Fixed32StringSerializable, Fixed32StringSerializable>(app);
            RegisterUnityAction<Fixed64StringSerializable, Fixed64StringSerializable>(app);
            RegisterUnityAction<Fixed128StringSerializable, Fixed128StringSerializable>(app);
            RegisterUnityAction<Fixed512StringSerializable, Fixed512StringSerializable>(app);
            RegisterUnityAction<Fixed4096StringSerializable, Fixed4096StringSerializable>(app);
            RegisterUnityAction<System.Net.IPEndPoint,
                Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery.DiscoveryResponseData>(app);
            RegisterUnityAction<int>(app);

            RegisterUnityAction<Unity.Netcode.NetworkBehaviour>(app);
            RegisterUnityAction<Unity.Netcode.NetworkObject>(app);
            RegisterNetworkVariable<int>(app);


            Unity_Netcode_NetworkConfig_Binding.Register(app);
            Unity_Netcode_NetworkPrefab_Binding.Register(app);
            Unity_Netcode_NetworkPrefabs_Binding.Register(app);
            Unity_Netcode_NetworkPrefabsList_Binding.Register(app);
            Unity_Netcode_NetworkBehaviour_Binding.Register(app);
            Unity_Netcode_NetworkManager_Binding.Register(app);
            Unity_Netcode_NetworkObject_Binding.Register(app);
            Unity_Netcode_CustomMessagingManager_Binding.Register(app);
            Unity_Netcode_RpcDelivery_Binding.Register(app);
            Unity_Netcode_ServerRpcAttribute_Binding.Register(app);
            Unity_Netcode_ClientRpcAttribute_Binding.Register(app);
            Unity_Netcode_RpcSendParams_Binding.Register(app);
            Unity_Netcode_RpcReceiveParams_Binding.Register(app);
            Unity_Netcode_RpcParams_Binding.Register(app);
            Unity_Netcode_ServerRpcSendParams_Binding.Register(app);
            Unity_Netcode_ServerRpcReceiveParams_Binding.Register(app);
            Unity_Netcode_ServerRpcParams_Binding.Register(app);
            Unity_Netcode_ClientRpcSendParams_Binding.Register(app);
            Unity_Netcode_ClientRpcReceiveParams_Binding.Register(app);
            Unity_Netcode_ClientRpcParams_Binding.Register(app);
            Unity_Netcode_BaseRpcTarget_Binding.Register(app);
            Unity_Netcode_SendTo_Binding.Register(app);
            Unity_Netcode_RpcTargetUse_Binding.Register(app);
            Unity_Netcode_RpcTarget_Binding.Register(app);
            Unity_Netcode_NetworkVariableBase_Binding.Register(app);
            Unity_Netcode_NetworkVariableReadPermission_Binding.Register(app);
            Unity_Netcode_NetworkVariableWritePermission_Binding.Register(app);
            Unity_Netcode_SceneEvent_Binding.Register(app);
            Unity_Netcode_NetworkBehaviourReference_Binding.Register(app);
            Unity_Netcode_NetworkObjectReference_Binding.Register(app);
            Unity_Netcode_NetworkPrefabHandler_Binding.Register(app);
            Unity_Netcode_NetworkSpawnManager_Binding.Register(app);
            Unity_Netcode_NetworkTickSystem_Binding.Register(app);
            Unity_Netcode_NetworkTime_Binding.Register(app);
            Unity_Netcode_NetworkTimeSystem_Binding.Register(app);
            Unity_Netcode_NetworkDelivery_Binding.Register(app);
            Unity_Netcode_NetworkEvent_Binding.Register(app);
            Unity_Netcode_NetworkTransport_Binding.Register(app);
            Unity_Netcode_NetworkTopologyTypes_Binding.Register(app);
            Unity_Netcode_Components_AnticipatedNetworkTransform_Binding.Register(app);
            Unity_Netcode_Components_NetworkAnimator_Binding.Register(app);
            Unity_Netcode_Components_NetworkRigidbody_Binding.Register(app);
            Unity_Netcode_Components_NetworkRigidbody2D_Binding.Register(app);
            Unity_Netcode_Components_NetworkRigidbodyBase_Binding.Register(app);
            Unity_Netcode_Components_NetworkTransform_Binding.Register(app);
            Unity_Netcode_NetworkVariable_1_Int32_Binding.Register(app);
            Unity_Services_Multiplayer_ISession_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_NetworkDiscovery_LANNetworkDiscovery_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_LagCompensation_TrackedObject_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_LagCompensation_LagCompensationManager_Binding.Register(app);

            Phantom_XRMOD_NetcodeModule_Runtime_Fixed128StringSerializable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Fixed32StringSerializable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Fixed4096StringSerializable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Fixed512StringSerializable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Fixed64StringSerializable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_NetcodeServiceAPI_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_NetworkObjectPool_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_PoolConfigObject_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_BooleanNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_ByteNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_CharNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Color32NetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_ColorNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_DecimalNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_DoubleNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Fixed128StringNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Fixed32StringNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Fixed4096StringNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Fixed512StringNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Fixed64StringNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_FloatNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_IntegerNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_LongNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_QuaternionNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Ray2DNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_RayNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_SbyteNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_ShortNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_UintNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_UlongNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_UShortNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Vector2IntNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Vector2NetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Vector3IntNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Vector3NetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Vector4NetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_PlayerListNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_PlayerScoreListNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_PlayerScoreRef_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_XRMODNetworkBehaviour_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_BaseNetworkVariable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_NetcodeClientConnectedCallbackEventArgs_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_NetcodeApprovalEventArgs_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_RegionType_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_RegionTypeExtensions_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_UnityFusionMessageBridge_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_PacketWriter_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_PacketReader_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_OnEventCustomNetworkMessagingEventArgs_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_PlayerEntry_Binding.Register(app);

            System_Collections_Generic_List_1_NetworkVariableBase_Binding.Register(app);
            UnityEngine_Events_UnityEvent_2_Int32_Int32_Binding.Register(app);


            // Tabletop system
            Phantom_XRMOD_NetcodeModule_Runtime_TableSystem_TableTopPlayer_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_TableSystem_TableTop_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_TableSystem_TableSeat_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_TableSystem_TableSeatSystem_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_TableSystem_NetworkTableTopManager_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_TableSystem_IPlayerConnection_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_TableSystem_NetworkedSeat_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_NetworkInteractions_NetworkSocketInteractor_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_NetworkInteractions_NetworkBaseInteractable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_NetworkInteractions_NetworkPhysicsInteractable_Binding.Register(app);
            Phantom_XRMOD_NetcodeModule_Runtime_Gameplay_NGOPlayerBase_Binding.Register(app);
        }

        private static void RegisterUnityAction<T1, T2>(AppDomain app)
        {
            app.DelegateManager.RegisterMethodDelegate<T1, T2>();

            app.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<T1, T2>>((act) =>
                {
                    return new UnityEngine.Events.UnityAction<T1, T2>((arg0, arg1) =>
                    {
                        ((Action<T1, T2>) act)(arg0, arg1);
                    });
                });
        }


        private static void RegisterUnityAction<T>(AppDomain app)
        {
            app.DelegateManager.RegisterMethodDelegate<T>();
            app.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<T>>(act =>
                {
                    return new UnityEngine.Events.UnityAction<T>(arg0 => { ((Action<T>) act)(arg0); });
                });
        }


        private static void RegisterNetworkVariable<T>(AppDomain app)
        {
            app.DelegateManager
                .RegisterDelegateConvertor<Unity.Netcode.NetworkVariable<T>.OnValueChangedDelegate>((act) =>
                {
                    return new Unity.Netcode.NetworkVariable<T>.OnValueChangedDelegate((_previousValue,
                        _newValue) =>
                    {
                        ((Action<T, T>) act)(_previousValue, _newValue);
                    });
                });
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}