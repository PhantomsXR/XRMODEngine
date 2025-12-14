// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.NetcodeModule.Runtime.Gameplay;
using Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.Interface;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Assertions;

namespace Phantom.XRMOD.NetcodeModule.Runtime.TableSystem
{
    public class ClientDisconnected : IConnectionCommand
    {
        PlayerListNetworkVariable playerListNetworkVariable;
        NetworkManager networkManager;

        public ClientDisconnected(NetworkManager _networkManager, PlayerListNetworkVariable _playerListNetworkVariable)
        {
            playerListNetworkVariable = _playerListNetworkVariable;
            networkManager = _networkManager;
        }

        public bool Execute(ulong _playerId)
        {
            if (!Application.isPlaying || networkManager.ShutdownInProgress) return false;
            // Sync player list
            bool tmp_PlayerHasBeenLeave = playerListNetworkVariable.LeavePlayer(_playerId);

            // Despawn the avatar
            if (!tmp_PlayerHasBeenLeave) return false;
            if (networkManager.SpawnManager == null) return false;
            var tmp_PlayerObj = networkManager.SpawnManager.GetPlayerNetworkObject(_playerId);
            if (tmp_PlayerObj)
                NetcodeServiceAPI.GetInstance.DespawnNetworkGameObject(tmp_PlayerObj.gameObject);
            return true;
        }
    }


    public class ClientConnected : IConnectionCommand
    {
        PlayerListNetworkVariable playerListNetworkVariable;
        NetworkManager networkManager;

        public ClientConnected(NetworkManager _networkManager, PlayerListNetworkVariable _playerListNetworkVariable)
        {
            playerListNetworkVariable = _playerListNetworkVariable;
            networkManager = _networkManager;
        }

        public bool Execute(ulong _playerId)
        {
            Assert.IsNotNull(NetcodeServiceAPI.GetInstance.GetPlayerPrefab.gameObject);
            // 生成avatar
            NetcodeServiceAPI.GetInstance.SpawnPlayerGameObject(_playerId,
                NetcodeServiceAPI.GetInstance.GetPlayerPrefab.gameObject,
                Vector3.zero, Quaternion.identity, _onBeforeSpawned: (_go) =>
                {
                    var tmp_PlayerBase = _go.GetComponent<NGOPlayerBase>();
                    tmp_PlayerBase.PlayerId = _playerId;
                }
            );

            // 添加到玩家列表
            return playerListNetworkVariable.JoinPlayer(_playerId);
        }
    }
}