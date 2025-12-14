// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

#if FUSION2
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Fusion;
using Fusion.Photon.Realtime;
using Fusion.Sockets;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public class PhotonServerAPI : IDisposable
    {
        public Action<NetworkRunner> OnGameStartCallback;

        private NetworkProjectConfig networkProjectConfig;
        private NetworkEvents networkEvents;

        private NetworkProjectConfigAsset networkProjectConfigAsset;
        private NetworkRunner clientRunner;
        private INetworkSceneManager sceneManager;
        private INetworkObjectProvider objectProvider;

        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationTokenForJoinLobby;
        private CancellationToken cancellationToken;
        private FusionAppSettings fusionAppSettings;

        private static readonly Dictionary<NetworkPrefabId, INetworkPrefabSource> _NETWORK_PREFAB_IDS = new();

        private bool connectingSafeCheck;
        private static PhotonServerAPI _INSTANCE;
        public static PhotonServerAPI GetInstance => _INSTANCE ??= new PhotonServerAPI();

        /// <summary>
        /// The index number used for the last created peer.
        /// </summary>
        public int LastCreatedClientIndex { get; internal set; }

        public NetworkRunner GetNetworkRunner => clientRunner;
        public NetworkEvents GetNetworkEvents => networkEvents;

        /// <summary>
        /// Will automatically enable <see cref="FusionStats"/> once peers have finished connecting.
        /// </summary>
        [InlineHelp] public bool AlwaysShowStats;

        private NetworkObjectBaker _baker;
        public NetworkObjectBaker Baker => _baker ??= new NetworkObjectBaker();

        private PhotonServerAPI()
        {
            foreach ((NetworkPrefabId, INetworkPrefabSource) tmp_Entry in NetworkProjectConfig.Global.PrefabTable
                         .GetEntries())
            {
                _NETWORK_PREFAB_IDS.TryAdd(tmp_Entry.Item1, tmp_Entry.Item2);
            }
        }

        public NetworkRunner Initialize()
        {
            if (networkProjectConfig == null)
            {
                networkProjectConfigAsset = Resources.Load<NetworkProjectConfigAsset>(nameof(NetworkProjectConfig));
                networkProjectConfig = networkProjectConfigAsset.Config;
            }

            if (clientRunner) return clientRunner;

            clientRunner = Object.FindFirstObjectByType<NetworkRunner>();
            if (clientRunner == null)
            {
                var tmp_FusionRunnerPrefab = Resources.Load<GameObject>("Prefabs/FusionRunnerPrefab");
                clientRunner = Object.Instantiate(tmp_FusionRunnerPrefab).GetComponent<NetworkRunner>();
            }

            clientRunner.name = $"Client {(Char) (65 + LastCreatedClientIndex++)}";
            networkEvents = clientRunner.GetBehaviour<NetworkEvents>();
            sceneManager = clientRunner.GetComponent<INetworkSceneManager>();
            objectProvider = clientRunner.GetComponent<INetworkObjectProvider>();
            return clientRunner;
        }


        private void Deinitialize()
        {
            if (clientRunner)
                clientRunner.SafeDestroy();
            sceneManager = null;
            objectProvider = null;
            networkProjectConfigAsset = null;
            networkProjectConfig = null;
            _INSTANCE = null;
        }

        /// <summary>
        /// Returns the player is connect to server.
        /// </summary>
        public bool IsConnected => clientRunner && clientRunner.IsRunning;

        /// <summary>
        /// Returns the player round trip time (ping) in millisecond.
        /// </summary>
        public int Ping => (int) (IsConnected ? clientRunner.GetPlayerRtt(clientRunner.LocalPlayer) * 1000 : 0);

        /// <summary>
        /// Join the lobby.
        /// If you want to get all game session you must joined lobby first.
        /// You could register the <see cref="NetworkEvents.OnSessionListUpdate"/> event to check the game session list.
        /// </summary>
        /// <param name="_lobbyId">Lobby id is necessary. Lobby Id must same as your game session lobby id.</param>
        /// <param name="_lobbyType">Lobby type must same as your game session type</param> 
        /// <returns>The game result of join the lobby</returns>
        public async Task<StartGameResult> JoinLobby(string _lobbyId, SessionLobby _lobbyType)
        {
            if (clientRunner == null)
            {
                Initialize();
            }

            if (cancellationTokenSource != null)
                cancellationTokenSource.Cancel();

            cancellationTokenSource?.Dispose();
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;


            StartGameResult tmp_StartGameResult = null;
            if (fusionAppSettings != null)
            {
                tmp_StartGameResult = await clientRunner.JoinSessionLobby(_lobbyType, _lobbyId,
                    customAppSettings: fusionAppSettings,
                    cancellationToken: cancellationToken);
            }
            else
            {
                tmp_StartGameResult = await clientRunner.JoinSessionLobby(_lobbyType, _lobbyId,
                    cancellationToken: cancellationToken);
            }

            return tmp_StartGameResult;
        }

        /// <summary>
        /// Create or join a session.
        /// </summary>
        /// <param name="_gameName">Your game name</param>
        /// <param name="_sessionCode">The session code</param>
        /// <param name="_customProperties"></param>
        /// <param name="_maxPlayer">The max player in this session</param>
        /// <param name="_isPublic">Anyone can join</param>
        /// <param name="_gameMode"></param>
        /// <param name="_enableClientSessionCreation"></param>
        /// <returns>The ConnectResult of create or join game session</returns>
        public async Task<ConnectResult> CreateOrJoinSession(string _gameName, string _sessionCode = null,
            GameMode _gameMode = GameMode.Shared,
            bool _enableClientSessionCreation = false,
            Dictionary<string, SessionProperty> _customProperties = null,
            int _maxPlayer = 2,
            bool _isPublic = true)
        {
            if (clientRunner == null)
            {
                Initialize();
            }

            if (connectingSafeCheck)
                return new ConnectResult()
                    {CustomResultHandling = true, Success = false, FailReason = ConnectFailReason.None};
            connectingSafeCheck = true;

            cancellationTokenSource?.Dispose();
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;

            _customProperties ??= new Dictionary<string, SessionProperty>();
            _customProperties?.Add("GameType", _gameName);

            var tmp_StartGameArgs = new StartGameArgs
            {
                GameMode = _gameMode,
                Address = NetAddress.Any(),
                PlayerCount = _maxPlayer,
                IsVisible = _isPublic,
                SessionProperties = _customProperties,
                OnGameStarted = OnGameStartCallback,
                StartGameCancellationToken = cancellationToken,
                EnableClientSessionCreation = _enableClientSessionCreation
            };

            tmp_StartGameArgs.SessionName = _sessionCode;

            if (fusionAppSettings != null)
            {
                tmp_StartGameArgs.CustomPhotonAppSettings = fusionAppSettings;
            }

            var tmp_Scene = SceneRef.FromIndex(SceneManager.GetActiveScene().buildIndex);
            var tmp_StartGameResult = await InitializeNetworkRunner(tmp_StartGameArgs, tmp_Scene);
            connectingSafeCheck = false;
            return new ConnectResult()
            {
                Success = tmp_StartGameResult.Ok,
                FailReason = ResolveConnectFailReason(tmp_StartGameResult.ShutdownReason)
            };
        }

        //// ---> Report a new feature: Add game mode for parameters
        /// ----> Report a new feature: Add EnableClientSessionCreation parameters for this fun
        /// <summary>
        /// Join the random game session
        /// </summary>
        /// <returns>Join state. More information <see cref="ConnectResult"/>.</returns>
        public async Task<ConnectResult> JoinRandomSession(string _gameName, GameMode _gameMode = GameMode.Shared,
            bool _enableClientSessionCreation = false, Dictionary<string, SessionProperty> _sessionInfos = null)
        {
            if (clientRunner == null)
            {
                Initialize();
            }

            if (connectingSafeCheck)
                return new ConnectResult()
                    {CustomResultHandling = true, Success = false, FailReason = ConnectFailReason.None};
            connectingSafeCheck = true;

            _sessionInfos ??= new();
            _sessionInfos.Add("GameType", _gameName);

            var tmp_StartGameArgs = new StartGameArgs
            {
                GameMode = _gameMode,
                MatchmakingMode = MatchmakingMode.RandomMatching,
                SessionProperties = _sessionInfos,
                EnableClientSessionCreation = _enableClientSessionCreation,
            };

            if (fusionAppSettings != null)
            {
                tmp_StartGameArgs.CustomPhotonAppSettings = fusionAppSettings;
            }

            var tmp_Scene = SceneRef.FromIndex(SceneManager.GetActiveScene().buildIndex);

            var tmp_StartGameResult = await InitializeNetworkRunner(tmp_StartGameArgs, tmp_Scene);

            connectingSafeCheck = false;

            return new ConnectResult()
            {
                Success = tmp_StartGameResult.ShutdownReason == ShutdownReason.Ok,
                FailReason = ResolveConnectFailReason(tmp_StartGameResult.ShutdownReason)
            };
        }

        /// <summary>
        /// Disconnect to game server
        /// </summary>
        /// <param name="_reason">The disconnect reason. More information see <see cref="ShutdownReason"/>.</param>
        public async void DisconnectAsync(int _reason = 1)
        {
            if (cancellationTokenSource != null)
                cancellationTokenSource.Cancel();
            if (clientRunner)
                await clientRunner.Shutdown(shutdownReason: ResolveShutdownReason(_reason));
            connectingSafeCheck = false;

            for (int tmp_Idx = SceneManager.sceneCount - 1; tmp_Idx > 0; tmp_Idx--)
            {
                _ = SceneManager.UnloadSceneAsync(SceneManager.GetSceneAt(tmp_Idx));
            }

            if (clientRunner)
                clientRunner.gameObject.SafeDestroy();
        }

        /// <summary>
        /// This will register any prefab, but it needs to be loaded first (from whatever the source)
        /// </summary>
        /// <param name="_prefab">The Unity game object</param>
        /// <returns>The network id of game object prefab</returns>
        /// <exception cref="ArgumentException">The register exception</exception>
        public NetworkPrefabId RegisterNetworkPrefab(GameObject _prefab)
        {
            if (!_prefab.TryGetComponent(out NetworkObject tmp_NetworkObject)) return default;


            var tmp_Source = new NetworkPrefabSourceStaticLazy()
            {
                Object = tmp_NetworkObject,
            };

            if (NetworkProjectConfig.Global.PrefabTable.TryAddSource(tmp_Source, out var tmp_NetworkPrefabId))
            {
#if UNITY_EDITOR || UNITY_DEBUG
                Debug.Log($"{tmp_NetworkPrefabId} register into network prefab table.");
#endif
                return tmp_NetworkPrefabId;
            }

            Debug.LogError($"Register Network prefab({_prefab.name}) was failed.");

            return default;
        }


        /// <summary>
        /// Select a region
        /// </summary>
        /// <param name="_region">Server region</param>
        /// <param name="_config"><see cref="NetworkSettingConfig"/></param>
        public void BuildNetworkConfig(RegionEnum _region, NetworkSettingConfig _config = default)
        {
            _config ??= new NetworkSettingConfig();
            fusionAppSettings = BuildCustomAppSetting(_region, _config);
        }

        private int ResolveConnectFailReason(ShutdownReason _reason)
        {
            switch (_reason)
            {
                case ShutdownReason.Ok:
                case ShutdownReason.OperationCanceled:
                    return ConnectFailReason.UserRequest;
                case ShutdownReason.DisconnectedByPluginLogic:
                case ShutdownReason.Error:
                    return ConnectFailReason.Disconnect;
                default:
                    return ConnectFailReason.None;
            }
        }

        private ShutdownReason ResolveShutdownReason(int _reason)
        {
            switch (_reason)
            {
                case ConnectFailReason.UserRequest:
                    return ShutdownReason.Ok;
                case ConnectFailReason.ApplicationQuit:
                    return ShutdownReason.Ok;
                case ConnectFailReason.Disconnect:
                    return ShutdownReason.DisconnectedByPluginLogic;
                default:
                    return ShutdownReason.Error;
            }
        }

        private Task<StartGameResult> InitializeNetworkRunner(StartGameArgs _startGameArgs, SceneRef _scene)
        {
            if (sceneManager == null)
            {
                Debug.Log(
                    $"NetworkRunner does not have any component implementing {nameof(INetworkSceneManager)} interface, adding {nameof(NetworkSceneManagerDefault)}.",
                    clientRunner);
                sceneManager = clientRunner.gameObject.AddComponent<NetworkSceneManagerDefault>();
            }

            if (objectProvider == null)
            {
                Debug.Log(
                    $"NetworkRunner does not have any component implementing {nameof(INetworkObjectProvider)} interface, adding {nameof(NetworkObjectProviderDefault)}.",
                    clientRunner);
                objectProvider = clientRunner.gameObject.AddComponent<BakingObjectProvider>();
            }

            var tmp_SceneInfo = new NetworkSceneInfo();
            if (_scene.IsValid)
            {
                tmp_SceneInfo.AddSceneRef(_scene, LoadSceneMode.Additive);
            }

            _startGameArgs.ObjectProvider = objectProvider;
            _startGameArgs.Scene = tmp_SceneInfo;
            _startGameArgs.SceneManager = sceneManager;
            _startGameArgs.Address = NetAddress.Any();
            var tmp_Task = clientRunner.StartGame(_startGameArgs);
            return tmp_Task;
        }

        private FusionAppSettings BuildCustomAppSetting(RegionEnum _region, NetworkSettingConfig _config)
        {
            var tmp_AppSettings = PhotonAppSettings.Global.AppSettings.GetCopy();
            tmp_AppSettings.UseNameServer = _config.UseNameServer;

            if (!string.IsNullOrEmpty(_config.AppVersion))
                tmp_AppSettings.AppVersion = _config.AppVersion;

            if (!string.IsNullOrEmpty(_config.CustomAppIDFusion))
            {
                tmp_AppSettings.AppIdFusion = _config.CustomAppIDFusion;
            }

            if (!string.IsNullOrEmpty(_config.CustomAppIdVoice))
            {
                tmp_AppSettings.AppIdVoice = _config.CustomAppIdVoice;
            }

            if (!string.IsNullOrEmpty(_config.CustomAppIdChat))
            {
                tmp_AppSettings.AppIdChat = _config.CustomAppIdChat;
            }

            switch (_region)
            {
                case RegionEnum.CN:
                    tmp_AppSettings.FixedRegion = "cn";
                    tmp_AppSettings.Server = "ns.photonengine.cn";
                    break;
                case RegionEnum.BEST:
                    tmp_AppSettings.FixedRegion = string.Empty;
                    tmp_AppSettings.Server = string.Empty;
                    break;
                case RegionEnum.CUSTOM:
                    tmp_AppSettings.FixedRegion = string.Empty;
                    break;
                case RegionEnum.DEDICATED:
                    tmp_AppSettings.Server = _config.CustomServer;
                    tmp_AppSettings.Port = _config.Port;
                    break;
                default:
                    tmp_AppSettings.FixedRegion = _region.ToString().ToLower();
                    break;
            }

            return tmp_AppSettings;
        }

        public void Dispose()
        {
            NetworkProjectConfig.Global.PrefabTable.Clear();

            foreach (KeyValuePair<NetworkPrefabId, INetworkPrefabSource> tmp_Source in _NETWORK_PREFAB_IDS)
            {
                if (NetworkProjectConfig.Global.PrefabTable.TryAddSource(tmp_Source.Value, out var tmp_NetworkPrefabId))
                {
                    Debug.Log($"{tmp_NetworkPrefabId} register into network prefab table.");
                }
            }

            _NETWORK_PREFAB_IDS.Clear();
            Deinitialize();
        }
    }

    public enum RegionEnum
    {
        BEST,
        ASIA,
        AU,
        CAE,
        CN,
        EU,
        HK,
        IN,
        JP,
        SA,
        KR,
        TR,
        UAE,
        US,
        USW,
        USSC,
        CUSTOM,
        DEDICATED
    }

    public class NetworkSettingConfig
    {
        public string CustomAppIDFusion = string.Empty;
        public string CustomAppIdVoice = string.Empty;
        public string CustomAppIdChat = string.Empty;
        public string AppVersion = "0.1.0";
        public string CustomServer = string.Empty;
        public int Port = 0;
        public bool UseNameServer = true;
    }
}
#endif