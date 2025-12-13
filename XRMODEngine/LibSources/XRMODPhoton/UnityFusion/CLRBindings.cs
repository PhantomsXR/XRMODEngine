#if FUSION2 && XRMOD_INSTALL
using System;
using System.Collections.Generic;
using System.Reflection;
using Fusion;
using Fusion.Sockets;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;
using UnityFusion.CLRBinding.Adapter;
using UnityFusion.Runtime.Generated.Adapters;
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
        internal static Enviorment.ValueTypeBinder<Vector3> s_UnityEngine_Vector3_Binding_Binder = null;
        internal static AppDomain AppDomain;
//will auto register in unity
#if UNITY_5_3_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#endif
        static private void RegisterBindingAction()
        {
            UnityFusion.Runtime.CLRBinding.CLRBindingUtils.RegisterBindingAction(Initialize);

            ActionNotificationCenter.DefaultCenter.AddObserver(RegisterDelegate,
                nameof(ActionParameterDataType.RegisterExtraCLR));

            ActionNotificationCenter.DefaultCenter.AddObserver(_baseData =>
            {
                if (_baseData is not UnityFusionArgs tmp_UnityFusionArgs) return;
                var tmp_AppDomain = (tmp_UnityFusionArgs.AppDomain as AppDomain);
                tmp_AppDomain.RegisterCrossBindingAdaptor(new NetworkBehaviourAdapter());
                tmp_AppDomain.RegisterCrossBindingAdaptor(new SimulationBehaviourAdapter());
            }, nameof(ActionParameterDataType.RegisterExtraAdaptor));
        }

        private static void RegisterDelegate(BaseNotificationData _args)
        {
            if (_args is not UnityFusionArgs tmp_FusionArgs) return;
            var tmp_Domain = tmp_FusionArgs.AppDomain as AppDomain;
            tmp_Domain?.DelegateManager
                .RegisterMethodDelegate<Fusion.NetworkRunner, Fusion.NetworkObject>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<Fusion.NetworkRunner, Fusion.PlayerRef>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<UnityEngine.Color>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<Fusion.TickTimer>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<UnityEngine.Quaternion>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector2>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector3>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector4>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<string>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<float>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<int>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<byte>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<System.String, Fusion.RpcInfo>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<Fusion.NetworkRunner, Fusion.NetworkInput>();
            tmp_Domain?.DelegateManager
                .RegisterMethodDelegate<Fusion.NetworkRunner, Fusion.NetworkRunnerCallbackArgs.ConnectRequest,
                    System.Byte[]>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<Fusion.NetworkRunner>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<Fusion.NetworkRunner, Fusion.ShutdownReason>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<Fusion.NetworkRunner, NetDisconnectReason>();
            tmp_Domain?.DelegateManager
                .RegisterMethodDelegate<Fusion.NetworkRunner, NetAddress, NetConnectFailedReason>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<Fusion.NetworkRunner, Fusion.SimulationMessagePtr>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<Fusion.NetworkRunner, List<Fusion.SessionInfo>>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<Fusion.NetworkRunner, Dictionary<string, object>>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<Fusion.NetworkRunner, Fusion.HostMigrationToken>();
            tmp_Domain?.DelegateManager
                .RegisterMethodDelegate<Fusion.NetworkRunner, Fusion.PlayerRef, ReliableKey, ArraySegment<byte>>();
            tmp_Domain?.DelegateManager
                .RegisterMethodDelegate<Fusion.NetworkRunner, Fusion.PlayerRef, ReliableKey, float>();
            tmp_Domain?.DelegateManager
                .RegisterMethodDelegate<Fusion.NetworkRunner, Fusion.NetworkObject, Fusion.PlayerRef>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<Fusion.NetworkRunner, Fusion.PlayerRef>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<Fusion.NetworkRunner, System.Boolean>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<System.String, Fusion.TickTimer, Fusion.TickTimer>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<System.String, int, int>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<System.String, byte, byte>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<System.String, Vector2, Vector2>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<System.String, Vector3, Vector3>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<System.String, Vector4, Vector4>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<System.String, Quaternion, Quaternion>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<System.String, Color, Color>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<System.String, bool, bool>();
            tmp_Domain?.DelegateManager.RegisterFunctionDelegate<System.Threading.Tasks.Task>();
            tmp_Domain?.DelegateManager.RegisterMethodDelegate<NetworkArray<int>>();


            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<NetworkArray<int>>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<NetworkArray<int>>(
                            (arg0) => { ((Action<NetworkArray<int>>) act)(arg0); });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<System.String, Color, Color>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<System.String, Color, Color>(
                            (arg0, arg1, arg2) => { ((Action<System.String, Color, Color>) act)(arg0, arg1, arg2); });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<System.String, Quaternion, Quaternion>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<System.String, Quaternion, Quaternion>(
                            (arg0, arg1, arg2) =>
                            {
                                ((Action<System.String, Quaternion, Quaternion>) act)(arg0, arg1, arg2);
                            });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<System.String, Vector4, Vector4>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<System.String, Vector4, Vector4>(
                            (arg0, arg1, arg2) =>
                            {
                                ((Action<System.String, Vector4, Vector4>) act)(arg0, arg1, arg2);
                            });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<System.String, Vector3, Vector3>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<System.String, Vector3, Vector3>(
                            (arg0, arg1, arg2) =>
                            {
                                ((Action<System.String, Vector3, Vector3>) act)(arg0, arg1, arg2);
                            });
                    });


            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<System.String, Vector2, Vector2>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<System.String, Vector2, Vector2>(
                            (arg0, arg1, arg2) =>
                            {
                                ((Action<System.String, Vector2, Vector2>) act)(arg0, arg1, arg2);
                            });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<System.String, bool, bool>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<System.String, bool, bool>(
                            (arg0, arg1, arg2) => { ((Action<System.String, bool, bool>) act)(arg0, arg1, arg2); });
                    });
            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<System.String, byte, byte>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<System.String, byte, byte>(
                            (arg0, arg1, arg2) => { ((Action<System.String, byte, byte>) act)(arg0, arg1, arg2); });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<System.String, int, int>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<System.String, int, int>(
                            (arg0, arg1, arg2) => { ((Action<System.String, int, int>) act)(arg0, arg1, arg2); });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<System.String, Fusion.TickTimer, Fusion.TickTimer>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<System.String, Fusion.TickTimer, Fusion.TickTimer>(
                            (arg0, arg1, arg2) =>
                            {
                                ((Action<System.String, Fusion.TickTimer, Fusion.TickTimer>) act)(arg0, arg1, arg2);
                            });
                    });


            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<Fusion.NetworkRunner, System.Boolean>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, System.Boolean>(
                            (arg0, arg1) => { ((Action<Fusion.NetworkRunner, System.Boolean>) act)(arg0, arg1); });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<Fusion.NetworkRunner, List<Fusion.SessionInfo>>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, List<Fusion.SessionInfo>>(
                            (arg0, arg1) =>
                            {
                                ((Action<Fusion.NetworkRunner, List<Fusion.SessionInfo>>) act)(arg0, arg1);
                            });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Fusion.NetworkRunner,
                    Fusion.NetworkRunnerCallbackArgs.ConnectRequest,
                    System.Byte[]>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner,
                            Fusion.NetworkRunnerCallbackArgs.ConnectRequest,
                            System.Byte[]>(
                            (arg0, arg1, arg3) =>
                            {
                                ((Action<Fusion.NetworkRunner, Fusion.NetworkRunnerCallbackArgs.ConnectRequest,
                                    System.Byte[]>) act)(arg0, arg1,
                                    arg3);
                            });
                    });


            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Fusion.NetworkRunner>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner>(
                            (arg0) => { ((Action<Fusion.NetworkRunner>) act)(arg0); });
                    });


            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.ShutdownReason>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.ShutdownReason>(
                            (arg0, arg1) =>
                            {
                                ((Action<Fusion.NetworkRunner, Fusion.ShutdownReason>) act)(arg0, arg1);
                            });
                    });


            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Fusion.NetworkRunner, NetDisconnectReason>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, NetDisconnectReason>(
                            (arg0, arg1) => { ((Action<Fusion.NetworkRunner, NetDisconnectReason>) act)(arg0, arg1); });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Fusion.NetworkRunner, NetAddress,
                    NetConnectFailedReason>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, NetAddress,
                            NetConnectFailedReason>(
                            (arg0, arg1, arg3) =>
                            {
                                ((Action<Fusion.NetworkRunner, NetAddress, NetConnectFailedReason>) act)(arg0, arg1,
                                    arg3);
                            });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.SimulationMessagePtr>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.SimulationMessagePtr>(
                            (arg0, arg1) =>
                            {
                                ((Action<Fusion.NetworkRunner, Fusion.SimulationMessagePtr>) act)(arg0, arg1);
                            });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Dictionary<string, object>>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Dictionary<string, object>>(
                            (arg0, arg1) =>
                            {
                                ((Action<Fusion.NetworkRunner, Dictionary<string, object>>) act)(arg0, arg1);
                            });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.PlayerRef>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.PlayerRef>(
                            (arg0, arg1) => { ((Action<Fusion.NetworkRunner, Fusion.PlayerRef>) act)(arg0, arg1); });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.HostMigrationToken>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.HostMigrationToken>(
                            (arg0, arg1) =>
                            {
                                ((Action<Fusion.NetworkRunner, Fusion.HostMigrationToken>) act)(arg0, arg1);
                            });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.PlayerRef,
                    ReliableKey, float>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.PlayerRef, ReliableKey,
                            float>(
                            (arg0, arg1, arg2, arg3) =>
                            {
                                ((Action<Fusion.NetworkRunner, Fusion.PlayerRef, ReliableKey, float>) act)(
                                    arg0, arg1, arg2, arg3);
                            });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.PlayerRef,
                    ReliableKey, ArraySegment<byte>>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.PlayerRef, ReliableKey,
                            ArraySegment<byte>>(
                            (arg0, arg1, arg2, arg3) =>
                            {
                                ((Action<Fusion.NetworkRunner, Fusion.PlayerRef, ReliableKey, ArraySegment<byte>>) act)(
                                    arg0, arg1, arg2, arg3);
                            });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.NetworkObject,
                    Fusion.PlayerRef>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.NetworkObject,
                            Fusion.PlayerRef>(
                            (arg0, arg1, arg2) =>
                            {
                                ((Action<Fusion.NetworkRunner, Fusion.NetworkObject, Fusion.PlayerRef>) act)(arg0, arg1,
                                    arg2);
                            });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Fusion.NetworkRunner,
                    Fusion.NetworkRunnerCallbackArgs.ConnectRequest, System.Byte[]>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner,
                            Fusion.NetworkRunnerCallbackArgs.ConnectRequest, System.Byte[]>(
                            (arg0, arg1, arg2) =>
                            {
                                ((Action<Fusion.NetworkRunner, Fusion.NetworkRunnerCallbackArgs.ConnectRequest,
                                    System.Byte[]>) act)(arg0, arg1, arg2);
                            });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.NetworkInput>>(
                    (act) =>
                    {
                        return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.NetworkInput>(
                            (arg0, arg1) => { ((Action<Fusion.NetworkRunner, Fusion.NetworkInput>) act)(arg0, arg1); });
                    });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<byte>>((act) =>
                {
                    return new UnityEngine.Events.UnityAction<byte>((arg0) => { ((Action<byte>) act)(arg0); });
                });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<int>>((act) =>
                {
                    return new UnityEngine.Events.UnityAction<int>((arg0) => { ((Action<int>) act)(arg0); });
                });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<float>>((act) =>
                {
                    return new UnityEngine.Events.UnityAction<float>((arg0) => { ((Action<float>) act)(arg0); });
                });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<string>>((act) =>
                {
                    return new UnityEngine.Events.UnityAction<string>((arg0) => { ((Action<string>) act)(arg0); });
                });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Vector2>>((act) =>
                {
                    return new UnityEngine.Events.UnityAction<Vector2>((arg0) =>
                    {
                        ((Action<Vector2>) act)(arg0);
                    });
                });
            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Vector3>>((act) =>
                {
                    return new UnityEngine.Events.UnityAction<Vector3>((arg0) =>
                    {
                        ((Action<Vector3>) act)(arg0);
                    });
                });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Vector4>>((act) =>
                {
                    return new UnityEngine.Events.UnityAction<Vector4>((arg0) =>
                    {
                        ((Action<Vector4>) act)(arg0);
                    });
                });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Quaternion>>((act) =>
                {
                    return new UnityEngine.Events.UnityAction<Quaternion>((arg0) =>
                    {
                        ((Action<Quaternion>) act)(arg0);
                    });
                });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<Fusion.TickTimer>>((act) =>
                {
                    return new UnityEngine.Events.UnityAction<Fusion.TickTimer>((arg0) =>
                    {
                        ((Action<Fusion.TickTimer>) act)(arg0);
                    });
                });


            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<UnityEngine.Events.UnityAction<UnityEngine.Color>>((act) =>
                {
                    return new UnityEngine.Events.UnityAction<UnityEngine.Color>((arg0) =>
                    {
                        ((Action<UnityEngine.Color>) act)(arg0);
                    });
                });

            tmp_Domain?.DelegateManager.RegisterDelegateConvertor<Fusion.NetworkRunner.OnBeforeSpawned>(
                (act) =>
                {
                    return new Fusion.NetworkRunner.OnBeforeSpawned((runner, obj) =>
                    {
                        ((Action<Fusion.NetworkRunner, Fusion.NetworkObject>) act)(runner, obj);
                    });
                });

            tmp_Domain?.DelegateManager
                .RegisterDelegateConvertor<
                    UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.PlayerRef>>((act) =>
                {
                    return new UnityEngine.Events.UnityAction<Fusion.NetworkRunner, Fusion.PlayerRef>(
                        (arg0, arg1) => { ((Action<Fusion.NetworkRunner, Fusion.PlayerRef>) act)(arg0, arg1); });
                });
        }

        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            AppDomain = app;
            Phantom_XRMOD_PhotonModule_Runtime_AuthorityTransferManager_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionNetworkAssetLoaderManager_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionDelay_Binding.Register(app);
            Fusion_FusionGlobalScriptableObjectAddressAttribute_Binding.Register(app);
            Fusion_FusionGlobalScriptableObjectResourceAttribute_Binding.Register(app);
            Fusion_FusionCoroutine_Binding.Register(app);
            Fusion_FusionRuntimeCheck_Binding.Register(app);
            Fusion_NetworkObjectBaker_Binding.Register(app);
            Fusion_NetworkPrefabSourceStatic_Binding.Register(app);
            Fusion_NetworkPrefabSourceStaticLazy_Binding.Register(app);
            Fusion_NetworkPrefabSourceResource_Binding.Register(app);
            Fusion_FusionScalableIMGUI_Binding.Register(app);
            Fusion_NetworkRunnerVisibilityExtensions_Binding.Register(app);
            Fusion_FusionAddressablePrefabsPreloader_Binding.Register(app);
            Fusion_FusionBootstrap_Binding.Register(app);
            Fusion_FusionBootstrapDebugGUI_Binding.Register(app);
            Fusion_NetworkCCData_Binding.Register(app);
            Fusion_NetworkCharacterController_Binding.Register(app);
            Fusion_NetworkObjectProviderDefault_Binding.Register(app);
            Fusion_NetworkSceneManagerDefault_Binding.Register(app);
            Fusion_EnableOnSingleRunner_Binding.Register(app);
            Fusion_RunnerEnableVisibility_Binding.Register(app);
            Fusion_RunnerLagCompensationGizmos_Binding.Register(app);
            Fusion_IRunnerVisibilityRecognizedType_Binding.Register(app);
            Fusion_RunnerVisibilityLink_Binding.Register(app);
            Fusion_Addons_Physics_NetworkRigidbody2D_Binding.Register(app);
            Fusion_Addons_Physics_NetworkRigidbody3D_Binding.Register(app);
            Fusion_Addons_Physics_NetworkRigidbodyBase_Binding.Register(app);
            Fusion_Addons_Physics_NetworkRBData_Binding.Register(app);
            Fusion_Addons_Physics_NetworkRigidbodyFlags_Binding.Register(app);
            Fusion_Addons_Physics_TRSThresholds_Binding.Register(app);
            Fusion_Addons_Physics_RunnerSimulatePhysics2D_Binding.Register(app);
            Fusion_Addons_Physics_RunnerSimulatePhysics3D_Binding.Register(app);
            Fusion_Addons_Physics_RunnerSimulatePhysicsBase_Binding.Register(app);
            Fusion_Addons_Physics_PhysicsAuthorities_Binding.Register(app);
            Fusion_Addons_Physics_PhysicsTimings_Binding.Register(app);
            Fusion_Addons_Physics_ClientPhysicsSimulation_Binding.Register(app);

            Fusion_Addons_KCC_DisabledInPlayModeAttribute_Binding.Register(app);
            Fusion_Addons_KCC_KCCLayerAttribute_Binding.Register(app);
            Fusion_Addons_KCC_KCCProcessorReferenceAttribute_Binding.Register(app);
            Fusion_Addons_KCC_KCCNetworkContext_Binding.Register(app);
            Fusion_Addons_KCC_KCCCollider_Binding.Register(app);
            Fusion_Addons_KCC_KCCInterestProxy_Binding.Register(app);
            Fusion_Addons_KCC_KCCCollision_Binding.Register(app);
            Fusion_Addons_KCC_KCCCollisions_Binding.Register(app);
            Fusion_Addons_KCC_KCCHit_Binding.Register(app);
            Fusion_Addons_KCC_KCCHits_Binding.Register(app);
            Fusion_Addons_KCC_KCCIgnore_Binding.Register(app);
            Fusion_Addons_KCC_KCCIgnores_Binding.Register(app);
            Fusion_Addons_KCC_KCCModifier_Binding.Register(app);
            Fusion_Addons_KCC_KCCModifiers_Binding.Register(app);
            Fusion_Addons_KCC_KCCData_Binding.Register(app);
            Fusion_Addons_KCC_KCCDebug_Binding.Register(app);
            Fusion_Addons_KCC_KCCOverlapHit_Binding.Register(app);
            Fusion_Addons_KCC_KCCOverlapInfo_Binding.Register(app);
            Fusion_Addons_KCC_KCCSettings_Binding.Register(app);
            Fusion_Addons_KCC_KCCShapeCastHit_Binding.Register(app);
            Fusion_Addons_KCC_KCCShapeCastInfo_Binding.Register(app);
            Fusion_Addons_KCC_EKCCTrace_Binding.Register(app);
            Fusion_Addons_KCC_KCCTraceInfo_Binding.Register(app);
            Fusion_Addons_KCC_EKCCAuthorityBehavior_Binding.Register(app);
            Fusion_Addons_KCC_EKCCInterpolationMode_Binding.Register(app);
            Fusion_Addons_KCC_EKCCShape_Binding.Register(app);
            Fusion_Addons_KCC_EKCCFeature_Binding.Register(app);
            Fusion_Addons_KCC_EKCCFeatures_Binding.Register(app);
            Fusion_Addons_KCC_EColliderType_Binding.Register(app);
            Fusion_Addons_KCC_ECollisionType_Binding.Register(app);
            Fusion_Addons_KCC_EKCCHitsOverlapQuery_Binding.Register(app);
            Fusion_Addons_KCC_EKCCLogType_Binding.Register(app);
            Fusion_Addons_KCC_KCCTypes_Binding.Register(app);
            Fusion_Addons_KCC_KCCArrayExtensions_Binding.Register(app);
            Fusion_Addons_KCC_KCCComponentExtensions_Binding.Register(app);
            Fusion_Addons_KCC_KCCFloatExtensions_Binding.Register(app);
            Fusion_Addons_KCC_KCCGameObjectExtensions_Binding.Register(app);
            Fusion_Addons_KCC_KCCIListExtensions_Binding.Register(app);
            Fusion_Addons_KCC_KCCQuaternionExtensions_Binding.Register(app);
            Fusion_Addons_KCC_KCCTypesExtensions_Binding.Register(app);
            Fusion_Addons_KCC_KCCVector2Extensions_Binding.Register(app);
            Fusion_Addons_KCC_KCCVector3Extensions_Binding.Register(app);
            Fusion_Addons_KCC_KCCNetworkID_Binding.Register(app);
            Fusion_Addons_KCC_GenericKCCProcessorProvider_Binding.Register(app);
            Fusion_Addons_KCC_IKCCProcessor_Binding.Register(app);
            Fusion_Addons_KCC_IKCCProcessorProvider_Binding.Register(app);
            Fusion_Addons_KCC_KCCProcessor_Binding.Register(app);
            Fusion_Addons_KCC_KCCProcessorProvider_Binding.Register(app);
            Fusion_Addons_KCC_NetworkKCCProcessor_Binding.Register(app);
            Fusion_Addons_KCC_NetworkKCCProcessorProvider_Binding.Register(app);
            Fusion_Addons_KCC_NetworkTRSPProcessor_Binding.Register(app);
            Fusion_Addons_KCC_NetworkTRSPProcessorProvider_Binding.Register(app);
            Fusion_Addons_KCC_ScriptableKCCProcessor_Binding.Register(app);
            Fusion_Addons_KCC_ScriptableKCCProcessorProvider_Binding.Register(app);
            Fusion_Addons_KCC_ISetGravity_Binding.Register(app);
            Fusion_Addons_KCC_ISetDynamicVelocity_Binding.Register(app);
            Fusion_Addons_KCC_ISetKinematicDirection_Binding.Register(app);
            Fusion_Addons_KCC_ISetKinematicTangent_Binding.Register(app);
            Fusion_Addons_KCC_ISetKinematicSpeed_Binding.Register(app);
            Fusion_Addons_KCC_ISetKinematicVelocity_Binding.Register(app);
            Fusion_Addons_KCC_EnvironmentProcessor_Binding.Register(app);
            Fusion_Addons_KCC_GroundSnapProcessor_Binding.Register(app);
            Fusion_Addons_KCC_IPlatform_Binding.Register(app);
            Fusion_Addons_KCC_IPlatformListener_Binding.Register(app);
            Fusion_Addons_KCC_PlatformProcessor_Binding.Register(app);
            Fusion_Addons_KCC_PlatformProcessorUpdater_Binding.Register(app);
            Fusion_Addons_KCC_StepUpProcessor_Binding.Register(app);
            Fusion_Addons_KCC_IAfterMoveStep_Binding.Register(app);
            Fusion_Addons_KCC_AfterMoveStep_Binding.Register(app);
            Fusion_Addons_KCC_IBeginMove_Binding.Register(app);
            Fusion_Addons_KCC_BeginMove_Binding.Register(app);
            Fusion_Addons_KCC_IKCCStage_Binding.Register(app);
            Fusion_Addons_KCC_IBeforeStage_Binding.Register(app);
            Fusion_Addons_KCC_IAfterStage_Binding.Register(app);
            Fusion_Addons_KCC_KCCStageInfo_Binding.Register(app);
            Fusion_Addons_KCC_IEndMove_Binding.Register(app);
            Fusion_Addons_KCC_EndMove_Binding.Register(app);
            Fusion_Addons_KCC_IPrepareData_Binding.Register(app);
            Fusion_Addons_KCC_PrepareData_Binding.Register(app);
            Fusion_Addons_KCC_FloatAccumulator_Binding.Register(app);
            Fusion_Addons_KCC_Vector2Accumulator_Binding.Register(app);
            Fusion_Addons_KCC_Vector3Accumulator_Binding.Register(app);
            Fusion_Addons_KCC_CallbackLogger_Binding.Register(app);
            Fusion_Addons_KCC_KCCPhysicsUtility_Binding.Register(app);
            Fusion_Addons_KCC_KCCResolver_Binding.Register(app);
            Fusion_Addons_KCC_KCCTimer_Binding.Register(app);
            Fusion_Addons_KCC_KCCTransformSampler_Binding.Register(app);
            Fusion_Addons_KCC_KCCUtility_Binding.Register(app);
            Fusion_Addons_KCC_CameraRecorder_Binding.Register(app);
            Fusion_Addons_KCC_KCCRecorder_Binding.Register(app);
            Fusion_Addons_KCC_PlayerRecorder_Binding.Register(app);
            Fusion_Addons_KCC_ERecorderType_Binding.Register(app);
            Fusion_Addons_KCC_StatsRecorder_Binding.Register(app);
            Fusion_Addons_KCC_StatsWriter_Binding.Register(app);
            Fusion_Addons_KCC_TransformRecorder_Binding.Register(app);
            Fusion_Addons_KCC_SmoothDouble_Binding.Register(app);
            Fusion_Addons_KCC_SmoothFloat_Binding.Register(app);
            Fusion_Addons_KCC_IKCCInteractionProvider_Binding.Register(app);
            Fusion_NetworkBehaviour_Binding.Register(app);
            Fusion_SimulationBehaviour_Binding.Register(app);
            Fusion_NetworkRunner_Binding.Register(app);
            Fusion_PlayerRef_Binding.Register(app);

            OnEventFusionBaseArgs_Binding.Register(app);
            OnEventFusionConnectedToServerArgs_Binding.Register(app);
            OnEventFusionConnectFailedArgs_Binding.Register(app);
            OnEventFusionConnectRequestArgs_Binding.Register(app);
            OnEventFusionCustomAuthenticationResponseArgs_Binding.Register(app);
            OnEventFusionDisconnectedFromServerArgs_Binding.Register(app);
            OnEventFusionHostMigrationArgs_Binding.Register(app);
            OnEventFusionInputArgs_Binding.Register(app);
            OnEventFusionInputMissingArgs_Binding.Register(app);
            OnEventFusionObjectEnterAOIArgs_Binding.Register(app);
            OnEventFusionObjectExitAOIArgs_Binding.Register(app);
            OnEventFusionPlayerJoinedArgs_Binding.Register(app);
            OnEventFusionPlayerLeftArgs_Binding.Register(app);
            OnEventFusionReliableDataArgs_Binding.Register(app);
            OnEventFusionReliableProgressArgs_Binding.Register(app);
            OnEventFusionSessionListUpdateArgs_Binding.Register(app);
            OnEventFusionShutdownArgs_Binding.Register(app);
            OnEventFusionSimulationMessageArgs_Binding.Register(app);


            EPPZ_Persistence_BinarySerializer_Binding.Register(app);
            EPPZ_Persistence_Files_Binding.Register(app);
            EPPZ_Persistence_JSONSerializer_Binding.Register(app);
            EPPZ_Persistence_JSONSerializer_Binding_Mode_Binding.Register(app);
            EPPZ_Persistence_Serializer_Binding.Register(app);
            EPPZ_Persistence_Extensions_Bytes_Extensions_Binding.Register(app);
            EPPZ_Persistence_Extensions_Object_Extensions_Binding.Register(app);
            EPPZ_Persistence_Extensions_Stream_Extensions_Binding.Register(app);
            EPPZ_Persistence_Extensions_String_Extensions_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_ConnectResult_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_ConnectFailReason_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_BaseFusionType_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionBooleanType_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionAngleType_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionByteType_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionColorType_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionFloatType_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionIntegerType_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionQuaternionType_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionString128Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionString16Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionString32Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionString512Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionString64Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionTickTimerType_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionVector2Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionVector3Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionVector4Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_PartyCodeGenerator_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_PhotonServerAPI_Binding.Register(app);
            XRMODNetworkBehaviour_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionScore16Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionScore2Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionScore32Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionScore4Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionScore64Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionScore8Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_FusionString128Type_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_NetworkInputData_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_AbstractFusionType_1_NetworkArray_1_Int32_Binding.Register(app); 

            Fusion_NetworkPrefabTable_Binding.Register(app);
            Fusion_NetworkObject_Binding.Register(app);
            Fusion_Behaviour_Binding.Register(app);
            Fusion_RenderTimeline_Binding.Register(app);
            Fusion_Sockets_ReliableKey_Binding.Register(app);
            Fusion_Statistics_RenderSimStats_Binding.Register(app);
            Fusion_Statistics_FusionStatsWorldAnchor_Binding.Register(app);
            Fusion_Statistics_FusionStatsPanelHeader_Binding.Register(app);
            Fusion_Statistics_FusionStatsGraphDefault_Binding.Register(app);
            Fusion_Statistics_FusionStatsGraphBase_Binding.Register(app);
            Fusion_Statistics_FusionStatsConfig_Binding.Register(app);
            Fusion_Statistics_FusionStatistics_Binding.Register(app);
            Fusion_Statistics_FusionNetworkObjectStatsGraphCombine_Binding.Register(app);
            Fusion_Statistics_FusionNetworkObjectStatsGraph_Binding.Register(app);
            Fusion_Statistics_FusionNetworkObjectStatistics_Binding.Register(app);
            Fusion_Statistics_CanvasAnchor_Binding.Register(app);
            Fusion_JsonUtilityExtensions_Binding.Register(app);
            Fusion_FusionBasicBillboard_Binding.Register(app);
            Fusion_NetworkedAttribute_Binding.Register(app);
            Fusion_OnChangedRenderAttribute_Binding.Register(app);
            Fusion_NetworkPrefabAttribute_Binding.Register(app);
            Fusion_RenderAttribute_Binding.Register(app);
            Fusion_LobbyInfo_Binding.Register(app);
            Fusion_SessionLobby_Binding.Register(app);
            Fusion_SessionInfo_Binding.Register(app);
            Fusion_NetworkBehaviour_Binding.Register(app);
            Fusion_NetworkBehaviourId_Binding.Register(app);
            Fusion_NetworkBehaviourUtils_Binding.Register(app);
            Fusion_NetworkMecanimAnimator_Binding.Register(app);
            Fusion_SimulationBehaviour_Binding.Register(app);
            Fusion_SimulationBehaviourAttribute_Binding.Register(app);
            Fusion_SimulationBehaviourListScope_Binding.Register(app);
            Fusion_NetworkTransform_Binding.Register(app);
            Fusion_INetworkTRSPTeleport_Binding.Register(app);
            Fusion_NetworkTRSP_Binding.Register(app);
            Fusion_NetworkTRSPData_Binding.Register(app);
            Fusion_NestedComponentUtilities_Binding.Register(app);
            NetworkCharacterControllerLocalPositionSync_Binding.Register(app);


            BaseFusionTypeWithChangeDetector_1_Int32_Binding.Register(app);
            BaseFusionTypeWithChangeDetector_1_Boolean_Binding.Register(app);
            BaseFusionTypeWithChangeDetector_1_Byte_Binding.Register(app);
            BaseFusionTypeWithChangeDetector_1_TickTimer_Binding.Register(app);
            Fusion_NetworkArray_1_Int32_Binding.Register(app);
            Fusion_NetworkRunner_Binding.Register(app);
            Fusion_NetworkDictionary_2_Int32_PlayerRef_Binding.Register(app);
            Fusion_NetworkObject_Binding.Register(app);
            Fusion_NetworkBehaviour_Binding.Register(app);
            Fusion_NetworkDictionary_2_Int32_PlayerRef_Binding_Enumerator_Binding.Register(app);
            Fusion_NetworkProjectConfig_Binding.Register(app);
            Fusion_NetworkArray_1_Int32_Binding_Enumerator_Binding.Register(app);
            Phantom_XRMOD_PhotonModule_Runtime_NetworkCharacterControllerLocalPositionSync_Binding.Register(app);
            Dictionary_2_PlayerRef_XRMODBehaviourAdapter_Binding_Adapter_Binding.Register(app);
            Dictionary_2_PlayerRef_XRMODBehaviourAdapter_Binding_Adapter_Binding_Enumerator_Binding.Register(app);
            Dictionary_2_PlayerRef_XRMODBehaviourAdapter_Binding_ValueCollection_Binding.Register(app);
            Dictionary_2_PlayerRef_XRMODBehaviourAdapter_ValueCollection_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_Int32_PlayerRef_Binding.Register(app);
            System_Collections_Generic_List_1_PlayerRef_Binding.Register(app);
            System_Nullable_1_PlayerRef_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_ConnectResult_Binding.Register(app);
            System_Threading_Tasks_Task_1_ConnectResult_Binding.Register(app);
            Fusion_Tick_Binding.Register(app);
            Fusion_SimulationConfig_Binding.Register(app);
            Fusion_SessionProperty_Binding.Register(app);
            UnityEngine_Events_UnityEvent_2_NetworkRunner_Boolean_Binding.Register(app);
            UnityEngine_Events_UnityEvent_1_NetworkArray_1_Int32_Binding.Register(app);
            UnityEngine_Events_UnityEvent_3_String_TickTimer_TickTimer_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_PlayerRef_XRMODBehaviour_Binding.Register(app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}
#endif