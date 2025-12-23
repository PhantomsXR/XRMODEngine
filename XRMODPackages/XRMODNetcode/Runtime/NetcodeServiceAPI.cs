// /*===============================================================================
// Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
//
// This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
//
// The  XR-MOD cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
//
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using Unity.Services.Multiplayer;
using UnityEngine;
using UnityEngine.Assertions;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// Manages Unity Netcode for GameObjects services, including session creation, joining, and network object spawning.
    /// This class provides a simplified API for common multiplayer operations and integrates with a notification system.
    /// </summary>
    public class NetcodeServiceAPI
    {
        private static NetworkManager _NETWORK_MANAGER;
        private static NetcodeServiceAPI _INSTANCE;
        private static ISession _SESSION;
        private static NetworkObject _PLAYER_PREFAB;
        private static NetworkTopologyTypes _NETWORK_MANAGER_TYPES;
        private static UnityTransport _UNITY_TRANSPORT;

        private List<GameObject> networkPrefabObjects = new List<GameObject>();

        /// <summary>
        /// Gets the currently registered network player prefab.
        /// </summary>
        /// <remarks>
        /// This prefab is used to instantiate the player object for connected clients.
        /// </remarks>
        public NetworkObject GetPlayerPrefab => _PLAYER_PREFAB;

        /// <summary>
        /// Gets the current active multiplayer session.
        /// </summary>
        public ISession GetCurrentSession => _SESSION;

        /// <summary>
        /// Gets the current session name.
        /// </summary>
        public string GetCurrentSessionName => _SESSION.Name;

        /// <summary>
        /// Gets the unique code for the current session.
        /// </summary>
        /// <remarks>
        /// Returns the session code if using Unity Multiplayer Services, or a fixed code based on the address if using Client-Server topology.
        /// </remarks>
        public string GetCurrentSessionCode
        {
            get
            {
                if (_SESSION != null && NetworkTopologyTypes != NetworkTopologyTypes.ClientServer)
                    return _SESSION.Code;
                return _NETWORK_MANAGER.GetFixedCode(_UNITY_TRANSPORT.ConnectionData.Address);
            }
        }

        /// <summary>
        /// Gets a value indicating whether the current instance is acting as a server.
        /// </summary>
        public bool IsServer => _NETWORK_MANAGER.IsServer;

        /// <summary>
        /// Gets a value indicating whether the current instance is acting as a client.
        /// </summary>
        public bool IsClient => _NETWORK_MANAGER.IsClient;

        /// <summary>
        /// Gets a value indicating whether the current instance is acting as a host (both server and client).
        /// </summary>
        public bool IsHost => _NETWORK_MANAGER.IsHost;

        /// <summary>
        /// Gets the current network topology type (e.g., ClientServer, UnityRelay, DistributedAuthority).
        /// </summary>
        public NetworkTopologyTypes NetworkTopologyTypes => _NETWORK_MANAGER_TYPES;

        /// <summary>
        /// Gets the underlying Unity NetworkManager instance.
        /// </summary>
        public NetworkManager GetNetworkManager => _NETWORK_MANAGER;

        /// <summary>
        /// Gets the underlying Unity <see cref="UnityTransport"/> instance.
        /// </summary>
        public UnityTransport GetUnityTransport => _UNITY_TRANSPORT;

        /// <summary>
        /// Gets the singleton instance of the <see cref="NetcodeServiceAPI"/>.
        /// If no instance exists, a new one is created.
        /// </summary>
        public static NetcodeServiceAPI GetInstance => _INSTANCE ??= new();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetcodeServiceAPI"/> class.
        /// This constructor is private to enforce the singleton pattern.
        /// </summary>
        private NetcodeServiceAPI()
        {
            Initialization();
        }

        /// <summary>
        /// Performs the initial setup for the <see cref="NetcodeServiceAPI"/>.
        /// Instantiates the NetworkManager prefab from Resources and subscribes to its lifecycle events.
        /// </summary>
        void Initialization()
        {
            try
            {
                var tmp_NetcodeManager = Resources.Load<GameObject>("Prefabs/NetworkManager");
                _NETWORK_MANAGER = Object.Instantiate(tmp_NetcodeManager).GetComponent<NetworkManager>();
                NetworkManager.Singleton.OnClientStarted += OnClientStarted;
                NetworkManager.Singleton.OnClientStopped += OnClientStopped;
                NetworkManager.Singleton.OnConnectionEvent += OnConnectionEvent;
                NetworkManager.Singleton.OnServerStarted += OnServerStarted;
                NetworkManager.Singleton.OnServerStopped += OnServerStopped;
                NetworkManager.Singleton.OnTransportFailure += OnTransportFailure;
                NetworkManager.Singleton.OnClientConnectedCallback += OnClientConnectedCallback;
                NetworkManager.Singleton.OnClientDisconnectCallback += OnClientDisconnectCallback;
                NetworkManager.Singleton.OnSessionOwnerPromoted += OnSessionOwnerPromoted;
                NetworkManager.Singleton.ConnectionApprovalCallback += OnConnectionApprovalCallback;
            }
            catch (Exception tmp_E)
            {
                Debug.LogException(tmp_E);
                throw;
            }
        }

        /// <summary>
        /// Spawns a network object for all connected clients. This method should only be called on the server or host.
        /// </summary>
        /// <param name="_networkPrefab">The GameObject prefab to spawn, which must have a <see cref="NetworkObject"/> component.</param>
        /// <param name="_position">The world position to spawn the object at.</param>
        /// <param name="_rotation">The world rotation to spawn the object with.</param>
        /// <param name="_parent">The parent Transform(NetworkObject have) for the spawned object. Defaults to null (no parent).</param>
        /// <param name="_destroyWithScene">If true, the object will be destroyed when the scene changes. Defaults to false.</param>
        /// <param name="_onBeforeSpawned">An optional action to invoke on the instantiated GameObject before it is spawned over the network.</param>
        /// <returns>The spawned GameObject, or null if the prefab does not have a <see cref="NetworkObject"/> component or instantiation fails.</returns>
        public GameObject SpawnNetworkGameObject(GameObject _networkPrefab,
            Vector3 _position,
            Quaternion _rotation,
            Transform _parent = null,
            bool _destroyWithScene = false,
            Action<GameObject> _onBeforeSpawned = null)
        {
            try
            {
                var tmp_InstanceObj = Object.Instantiate(_networkPrefab, _position, _rotation, _parent);
                if (tmp_InstanceObj == null) return null;
                var tmp_InstanceNetworkObject = tmp_InstanceObj.GetComponent<NetworkObject>();
                if (tmp_InstanceNetworkObject == null)
                {
                    Debug.LogError(
                        $"SpawnNetworkGameObject: Prefab '{_networkPrefab.name}' does not have a NetworkObject component.");
                    Object.Destroy(tmp_InstanceObj); // Clean up instantiated object if it's not a NetworkObject
                    return null;
                }

                _onBeforeSpawned?.Invoke(tmp_InstanceObj);
                tmp_InstanceNetworkObject.Spawn(_destroyWithScene);
                if (_parent != null)
                {
                    tmp_InstanceNetworkObject.TrySetParent(_parent);
                }

                return tmp_InstanceNetworkObject.gameObject;
            }
            catch (Exception tmp_E)
            {
                Debug.LogError($"Error spawning network GameObject: {tmp_E.Message}");
                throw;
            }
        }


        /// <summary>
        /// Spawns a player network object for a specific client. This method should only be called on the server or host.
        /// </summary>
        /// <param name="_clientId">The client ID for whom to spawn the player object.</param>
        /// <param name="_playerPrefab">The GameObject prefab for the player, which must have a <see cref="NetworkObject"/> component.</param>
        /// <param name="_position">The world position to spawn the player at.</param>
        /// <param name="_rotation">The world rotation to spawn the player with.</param>
        /// <param name="_parent">The parent Transform(NetworkObject have)  for the spawned player object. Defaults to null (no parent).</param>
        /// <param name="_destroyWithScene">If true, the player object will be destroyed when the scene changes. Defaults to false.</param>
        /// <param name="_onBeforeSpawned">An optional action to invoke on the instantiated GameObject before it is spawned as a player object.</param>
        /// <returns>The spawned <see cref="NetworkObject"/> for the player, or null if the prefab does not have a <see cref="NetworkObject"/> component or instantiation fails.</returns>
        public NetworkObject SpawnPlayerGameObject(ulong _clientId,
            GameObject _playerPrefab,
            Vector3 _position,
            Quaternion _rotation,
            Transform _parent = null,
            bool _destroyWithScene = false,
            Action<GameObject> _onBeforeSpawned = null)
        {
            try
            {
                var tmp_InstanceObj = Object.Instantiate(_playerPrefab, _position, _rotation, _parent);
                if (tmp_InstanceObj == null) return null;
                var tmp_MonoBinders = tmp_InstanceObj.GetComponentsInChildren<MonoBinder>(true);
                BinderManager.Instance.DoBind(tmp_MonoBinders);
                var tmp_InstanceNetworkObject = tmp_InstanceObj.GetComponent<NetworkObject>();
                if (tmp_InstanceNetworkObject == null)
                {
                    Debug.LogError(
                        $"SpawnPlayerGameObject: Prefab '{_playerPrefab.name}' does not have a NetworkObject component.");
                    Object.Destroy(tmp_InstanceObj); // Clean up instantiated object if it's not a NetworkObject
                    return null;
                }

                _onBeforeSpawned?.Invoke(tmp_InstanceObj);
                tmp_InstanceNetworkObject.SpawnAsPlayerObject(_clientId, _destroyWithScene);
                if (_parent != null)
                    tmp_InstanceNetworkObject.TrySetParent(_parent);
                return tmp_InstanceNetworkObject;
            }
            catch (Exception tmp_E)
            {
                Debug.LogError($"Error spawning player GameObject: {tmp_E.Message}");
                throw;
            }
        }


        /// <summary>
        /// Despawns and destroys a network object on the server and all connected clients.
        /// The object will be marked to not be destroyed with its owner before despawning.
        /// </summary>
        /// <param name="_networkGameObject">The GameObject to despawn, which must have a <see cref="NetworkObject"/> component.</param>
        public void DespawnNetworkGameObject(GameObject _networkGameObject)
        {
            if (_networkGameObject == null)
            {
                Debug.LogWarning("Attempted to despawn a null GameObject.");
                return;
            }

            var tmp_InstanceNetworkObject = _networkGameObject.GetComponent<NetworkObject>();
            if (tmp_InstanceNetworkObject == null)
            {
                Debug.LogWarning(
                    $"DespawnNetworkGameObject: GameObject '{_networkGameObject.name}' does not have a NetworkObject component. Destroying locally.");
                Object.Destroy(_networkGameObject);
                return;
            }

            // Ensure it's not destroyed prematurely if owner changes
            tmp_InstanceNetworkObject.DontDestroyWithOwner = true;
            tmp_InstanceNetworkObject.Despawn();
        }


        /// <summary>
        /// Registers a network prefab at runtime, allowing it to be spawned over the network.
        /// </summary>
        /// <param name="_networkPrefab">The GameObject prefab to register, which must have a <see cref="NetworkObject"/> component.</param>
        public void RegisterPrefab(GameObject _networkPrefab)
        {
            if (_networkPrefab == null)
            {
                Debug.LogWarning("Attempted to register a null network prefab.");
                return;
            }

            var tmp_NetworkPrefab = _networkPrefab.GetComponent<NetworkObject>();
            if (tmp_NetworkPrefab == null)
            {
                Debug.LogError(
                    $"RegisterPrefab: Prefab '{_networkPrefab.name}' does not have a NetworkObject component. Cannot register.");
                return;
            }

            if (networkPrefabObjects.Contains(_networkPrefab)) return;
            if (NetworkPrefabUtility.IsInNetworkPrefabList(_networkPrefab)) return;
            networkPrefabObjects.Add(_networkPrefab);
            _NETWORK_MANAGER.AddNetworkPrefab(_networkPrefab);
        }

        /// <summary>
        /// Unregisters a network prefab at runtime, preventing it from being spawned over the network.
        /// </summary>
        /// <param name="_networkPrefab">The GameObject prefab to unregister.</param>
        public void UnRegisterPrefab(GameObject _networkPrefab)
        {
            if (_networkPrefab == null)
            {
                Debug.LogWarning("Attempted to unregister a null network prefab.");
                return;
            }

            networkPrefabObjects.Remove(_networkPrefab);
            _NETWORK_MANAGER.RemoveNetworkPrefab(_networkPrefab);
        }


        /// <summary>
        ///  Registers a network player prefab at runtime, allowing it to be spawned over the network.
        /// </summary>
        /// <param name="_networkPlayerPrefab">The Player prefab to register, which must have a <see cref="NetworkObject"/> component.</param>
        public void RegisterPlayerObject(GameObject _networkPlayerPrefab)
        {
            if (_PLAYER_PREFAB) return;
            RegisterPrefab(_networkPlayerPrefab);
            _PLAYER_PREFAB = _networkPlayerPrefab.GetComponent<NetworkObject>();
        }

        /// <summary>
        /// Creates a new multiplayer session or attempts to join an existing one based on the provided configuration.
        /// It first attempts to quick-join a session matching the criteria in <paramref name="_baseSessionConfig"/>.
        /// If quick-join fails, it proceeds to create a new session.
        /// </summary>
        /// <param name="_gameName">A string identifier for the game, used for filtering sessions.</param>
        /// <param name="_baseSessionConfig">The base session configuration containing details like session code, max players, privacy, and custom properties.</param>
        /// <returns>An <see cref="ISession"/> object representing the created or joined session.</returns>
        /// <exception cref="Exception">Thrown if both matchmake and create session operations fail.</exception>
        public async Task<ISession> CreateOrJoinSession(string _gameName, BaseSessionConfig _baseSessionConfig)
        {
            _NETWORK_MANAGER_TYPES = _baseSessionConfig.TopologyTypes;
            if (!_baseSessionConfig.UseUnityMatchmaking &&
                _baseSessionConfig.TopologyTypes == NetworkTopologyTypes.ClientServer)
            {
                _UNITY_TRANSPORT = MakeUnityTransport();

                if (_baseSessionConfig is not HostingBaseSessionConfig tmp_Config) return null;
                _UNITY_TRANSPORT.SetConnectionData(tmp_Config.Host, tmp_Config.Port);

                switch (tmp_Config.ClientServerType)
                {
                    case ClientServerTypeEnum.Host:
                        GetNetworkManager.StartHost();
                        break;
                    case ClientServerTypeEnum.Server:
                        GetNetworkManager.StartServer();
                        break;
                    case ClientServerTypeEnum.Client:
                        GetNetworkManager.StartClient();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                return _SESSION;
            }

            // Prepare filter options for quick-join.
            var tmp_FilterOptions = new List<FilterOption>();
            if (!string.IsNullOrEmpty(_baseSessionConfig.SessionCode))
            {
                tmp_FilterOptions.Add(new(FilterField.Name, _baseSessionConfig.SessionCode, FilterOperation.Equal));
            }

            tmp_FilterOptions.Add(new(FilterField.StringIndex1, _gameName, FilterOperation.Equal));
            tmp_FilterOptions.Add(new(FilterField.AvailableSlots, "1", FilterOperation.GreaterOrEqual));

            var tmp_QuickJoinOptions = new QuickJoinOptions()
            {
                Filters = tmp_FilterOptions,
                // Allows quick-join to create a session if no match is found.
                CreateSession = true,
                Timeout = TimeSpan.FromSeconds(5)
            };

            // Prepare session options for creating a new session.
            var tmp_Options = new SessionOptions
            {
                MaxPlayers = _baseSessionConfig.MaxPlayer,
                IsPrivate = !_baseSessionConfig.Private,
                Password = string.IsNullOrEmpty(_baseSessionConfig.SessionCode)
                    ? null
                    : _baseSessionConfig.SessionCode,
                IsLocked = _baseSessionConfig.Locked,
                SessionProperties =
                    _baseSessionConfig.CustomProperties ?? new Dictionary<string, SessionProperty>(),
                PlayerProperties =
                    _baseSessionConfig.CustomPlayerProperties ?? new Dictionary<string, PlayerProperty>(),
            };

            // Add game name as a session property for discoverability.
            tmp_Options.SessionProperties.Add(_gameName,
                new SessionProperty(_gameName, VisibilityPropertyOptions.Public, PropertyIndex.String1));

            // Configure the network transport based on the session configuration.
            MakeSureNetworkWith(_baseSessionConfig, tmp_Options);

            try
            {
                // Attempt to matchmake (quick-join or create if no match).
                _SESSION = await MultiplayerService.Instance.MatchmakeSessionAsync(tmp_QuickJoinOptions,
                    tmp_Options);
                return _SESSION;
            }
            catch (Exception tmp_Exception)
            {
                // If matchmake fails (e.g., no session found, timeout), try to create a new session directly.
                Debug.LogWarning(
                    $"MatchmakeSessionAsync failed (likely no session found or timeout): {tmp_Exception.Message}. Attempting to create a new session.");
                _SESSION = await MultiplayerService.Instance.CreateSessionAsync(tmp_Options);
                return _SESSION;
            }
        }


        /// <summary>
        /// Attempts to join a random available game session based on the provided game name and session configuration.
        /// It searches for sessions with at least one available slot and matching the specified game name.
        /// </summary>
        /// <param name="_gameName">A string identifier for the game, used for filtering sessions.</param>
        /// <param name="_baseSessionConfig">The base session configuration, primarily used for custom properties and topology type.</param>
        /// <returns>An <see cref="ISession"/> object representing the joined session.</returns>
        /// <exception cref="Exception">Thrown if joining a random session fails.</exception>
        public async Task<ISession> JoinRandomSession(string _gameName, BaseSessionConfig _baseSessionConfig)
        {
            try
            {
                if (!_baseSessionConfig.UseUnityMatchmaking &&
                    _baseSessionConfig.TopologyTypes == NetworkTopologyTypes.ClientServer)
                {
                    _UNITY_TRANSPORT = MakeUnityTransport();

                    if (_baseSessionConfig is not HostingBaseSessionConfig tmp_Config)
                    {
                        Debug.Log(_baseSessionConfig.GetType());
                        return null;
                    }

                    _UNITY_TRANSPORT.SetConnectionData(tmp_Config.Host, tmp_Config.Port);
                    switch (tmp_Config.ClientServerType)
                    {
                        case ClientServerTypeEnum.Host:
                            GetNetworkManager.StartHost();
                            break;
                        case ClientServerTypeEnum.Server:
                            GetNetworkManager.StartServer();
                            break;
                        case ClientServerTypeEnum.Client:
                            GetNetworkManager.StartClient();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    return _SESSION;
                }

                var tmp_QuickJoinOptions = new QuickJoinOptions()
                {
                    Filters = new List<FilterOption>
                    {
                        new(FilterField.AvailableSlots, "1", FilterOperation.GreaterOrEqual),
                        new(FilterField.StringIndex1, _gameName, FilterOperation.Equal)
                    },
                    Timeout = TimeSpan.FromSeconds(5)
                };

                var tmp_Options = new SessionOptions()
                {
                    SessionProperties = _baseSessionConfig.CustomProperties
                };

                // Configure the network transport based on the session configuration.
                MakeSureNetworkWith(_baseSessionConfig, tmp_Options);

                _SESSION = await MultiplayerService.Instance.MatchmakeSessionAsync(tmp_QuickJoinOptions, tmp_Options);
                return _SESSION;
            }
            catch (Exception tmp_E)
            {
                Debug.LogError($"Failed to join random session: {tmp_E.Message}");
                throw;
            }
        }

        /// <summary>
        /// Disconnects from the current game session and shuts down the NetworkManager.
        /// </summary>
        public async void DisconnectSession()
        {
            try
            {
                _PLAYER_PREFAB = null;

                // Clear the session reference
                if (_SESSION != null)
                {
                    await _SESSION.LeaveAsync();
                    _SESSION = null;
                }

                if (_NETWORK_MANAGER)
                    _NETWORK_MANAGER.Shutdown();


                networkPrefabObjects.Clear();

#if UNITY_EDITOR
                Debug.Log("Disconnected from session and NetworkManager shut down.");
#endif
            }
            catch (Exception tmp_E)
            {
                Debug.LogError($"Error disconnecting from session: {tmp_E.Message}");
                throw;
            }
        }

        /// <summary>
        /// Generates a unique application ID based on the provided game name.
        /// </summary>
        /// <param name="_gameName">The name of the game.</param>
        /// <returns>A unique 64-bit application ID.</returns>
        public long GetUniqueApplicationId(string _gameName)
        {
            var tmp_StrHashCode = _gameName.GetHashCode();
            uint tmp_UnsignedHashCode = (uint) tmp_StrHashCode;
            long tmp_UniqueId = tmp_UnsignedHashCode;
            return tmp_UniqueId;
        }

        /// <summary>
        /// Configures the NetworkManager's transport based on the provided session configuration's topology type.
        /// </summary>
        /// <param name="_baseSessionConfig">The base session configuration specifying the network topology.</param>
        /// <param name="_options">The <see cref="SessionOptions"/> to be configured with network settings.</param>
        private static void MakeSureNetworkWith(BaseSessionConfig _baseSessionConfig, SessionOptions _options)
        {
            switch (_baseSessionConfig.TopologyTypes)
            {
                case NetworkTopologyTypes.ClientServer:
                {
                    // Ensure UnityTransport is present for ClientServer topology.
                    _UNITY_TRANSPORT = MakeUnityTransport();

                    if (_baseSessionConfig is HostingBaseSessionConfig tmp_Config)
                    {
                        Assert.IsNotNull(tmp_Config);
                        _options.WithDirectNetwork(tmp_Config.Host, tmp_Config.Host, tmp_Config.Port);
                    }
                    else
                    {
                        _options.WithDirectNetwork();
                    }
                }
                    break;
                case NetworkTopologyTypes.UnityRelay:
                {
                    // For Relay, ensure UnityTransport is present and configure with region.
                    _UNITY_TRANSPORT = MakeUnityTransport();

                    var tmp_Config = (RelayOrDistributedBaseSessionConfig) _baseSessionConfig;
                    var tmp_Region =
                        tmp_Config.Region.ToRegionString(); // Assuming ToRegionString() is an extension method.
                    _options.WithRelayNetwork(region: tmp_Region);
                }
                    break;
                case NetworkTopologyTypes.DistributedAuthority:
                {
                    // For Distributed Authority, UnityTransport might not be needed or might be handled differently.
                    _UNITY_TRANSPORT = MakeUnityTransport();

                    var tmp_Config = (RelayOrDistributedBaseSessionConfig) _baseSessionConfig;
                    var tmp_Region =
                        tmp_Config.Region.ToRegionString(); // Assuming ToRegionString() is an extension method.
                    _options.WithDistributedAuthorityNetwork(region: tmp_Region);
                }
                    break;
                default:
                    Debug.LogWarning(
                        $"Unsupported NetworkTopologyTypes: {_baseSessionConfig.TopologyTypes}. No network configuration applied.");
                    break;
            }
        }


        private static UnityTransport MakeUnityTransport()
        {
            if (!_NETWORK_MANAGER.TryGetComponent<UnityTransport>(out var tmp_Transport))
            {
                tmp_Transport = _NETWORK_MANAGER.gameObject.AddComponent<UnityTransport>();
            }
#if UNITY_WEBGL
                tmp_Transport.UseWebSockets = true;
#endif
            return tmp_Transport;
        }


        #region NetworkManager Callback

        /// <summary>
        /// Callback invoked when the server starts. Posts a <see cref="NetcodeServerStartedEventArgs"/> notification.
        /// </summary>
        private void OnServerStarted()
        {
            UnityFusionMessageBridge.GetInstance.Register();
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.OnEvent), new NetcodeServerStartedEventArgs());
        }

        /// <summary>
        /// Callback invoked when the server stops. Posts a <see cref="NetcodeServerStoppedEventArgs"/> notification.
        /// </summary>
        /// <param name="_obj">True if the server stopped gracefully, false otherwise.</param>
        private void OnServerStopped(bool _obj)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.OnEvent), new NetcodeServerStoppedEventArgs() {Stoped = _obj});
        }

        /// <summary>
        /// Callback invoked when a transport failure occurs. Posts a <see cref="NetcodeTransportFailureEventArgs"/> notification.
        /// </summary>
        private void OnTransportFailure()
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.OnEvent), new NetcodeTransportFailureEventArgs());
            Debug.LogError("NetworkManager: Transport Failure detected.");
        }

        /// <summary>
        /// Callback invoked when a client connects to the server. Posts a <see cref="NetcodeClientConnectedCallbackEventArgs"/> notification.
        /// </summary>
        /// <param name="_obj">The client ID of the newly connected client.</param>
        private void OnClientConnectedCallback(ulong _obj)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.OnEvent), new NetcodeClientConnectedCallbackEventArgs() {UserId = _obj});
        }

        /// <summary>
        /// Callback invoked when a client disconnects from the server. Posts a <see cref="NetcodeClientDisconnectCallbackEventArgs"/> notification.
        /// </summary>
        /// <param name="_obj">The client ID of the disconnected client.</param>
        private void OnClientDisconnectCallback(ulong _obj)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.OnEvent),
                new NetcodeClientDisconnectCallbackEventArgs() {UserId = _obj});
        }

        /// <summary>
        /// Callback invoked when the session owner is promoted to a new client. Posts a <see cref="NetcodeSessionOwnerPromotedEventArgs"/> notification.
        /// </summary>
        /// <param name="_sessionownerpromoted">The client ID of the new session owner.</param>
        private void OnSessionOwnerPromoted(ulong _sessionownerpromoted)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.OnEvent),
                new NetcodeSessionOwnerPromotedEventArgs() {Sessionownerpromoted = _sessionownerpromoted});
        }

        /// <summary>
        /// Callback invoked for general connection events (e.g., client connected, client disconnected, server shutdown).
        /// Posts a <see cref="NetcodeConnectionEventArgs"/> notification.
        /// </summary>
        /// <param name="_networkManager">The <see cref="NetworkManager"/> instance that triggered the event.</param>
        /// <param name="_connectionEventData">Data related to the connection event, including event type and client ID.</param>
        private void OnConnectionEvent(NetworkManager _networkManager, ConnectionEventData _connectionEventData)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.OnEvent),
                new NetcodeConnectionEventArgs()
                    {NetworkManager = _networkManager, ConnectionEventData = _connectionEventData});
        }

        /// <summary>
        /// Callback invoked when the client stops. Posts a <see cref="NetcodeClientStoppedArgs"/> notification.
        /// </summary>
        /// <param name="_obj">True if the client stopped gracefully, false otherwise.</param>
        private void OnClientStopped(bool _obj)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.OnEvent),
                new NetcodeClientStoppedArgs() {Stoped = _obj});
        }

        /// <summary>
        /// Callback invoked when the client starts. Posts a <see cref="NetcodeClientStartedArgs"/> notification.
        /// </summary>
        private void OnClientStarted()
        {
            UnityFusionMessageBridge.GetInstance.Register();
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                new NetcodeClientStartedArgs());
        }

        /// <summary>
        /// Callback invoked for re-anticipation events, typically related to network prediction and interpolation.
        /// Posts a <see cref="NetcodeReanticipateArgs"/> notification.
        /// </summary>
        /// <param name="_lastroundtriptime">The last recorded round trip time in seconds.</param>
        private void OnReanticipate(double _lastroundtriptime)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                new NetcodeReanticipateArgs() {Lastroundtriptime = _lastroundtriptime});
        }

        /// <summary>
        /// Callback invoked when a connection approval request is received. Posts a <see cref="NetcodeApprovalEventArgs"/> notification.
        /// </summary>
        /// <param name="_arg1">The connection approval request data.</param>
        /// <param name="_arg2">The connection approval response data.</param>
        private void OnConnectionApprovalCallback(NetworkManager.ConnectionApprovalRequest _arg1,
            NetworkManager.ConnectionApprovalResponse _arg2)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                new NetcodeApprovalEventArgs
                {
                    ApprovalRequest = _arg1,
                    ApprovalResponse = _arg2
                });
        }

        #endregion
    }
}