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
    /// <summary>
    /// Command to handle client disconnection from a tabletop session.
    /// </summary>
    public class ClientDisconnected : IConnectionCommand
    {
        private PlayerListNetworkVariable playerListNetworkVariable;
        private NetworkManager networkManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDisconnected"/> command.
        /// </summary>
        /// <param name="_networkManager">The NetworkManager instance.</param>
        /// <param name="_playerListNetworkVariable">The network variable tracking the player list.</param>
        public ClientDisconnected(NetworkManager _networkManager, PlayerListNetworkVariable _playerListNetworkVariable)
        {
            playerListNetworkVariable = _playerListNetworkVariable;
            networkManager = _networkManager;
        }

        /// <summary>
        /// Executes the disconnection logic for a specific player.
        /// </summary>
        /// <param name="_playerId">The ID of the player who disconnected.</param>
        /// <returns><c>true</c> if the player was successfully removed and their object despawned, <c>false</c> otherwise.</returns>
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


    /// <summary>
    /// Command to handle client connection to a tabletop session.
    /// </summary>
    public class ClientConnected : IConnectionCommand
    {
        private PlayerListNetworkVariable playerListNetworkVariable;
        private NetworkManager networkManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientConnected"/> command.
        /// </summary>
        /// <param name="_networkManager">The NetworkManager instance.</param>
        /// <param name="_playerListNetworkVariable">The network variable tracking the player list.</param>
        public ClientConnected(NetworkManager _networkManager, PlayerListNetworkVariable _playerListNetworkVariable)
        {
            playerListNetworkVariable = _playerListNetworkVariable;
            networkManager = _networkManager;
        }

        /// <summary>
        /// Executes the connection logic for a specific player, including spawning their avatar.
        /// </summary>
        /// <param name="_playerId">The ID of the player who connected.</param>
        /// <returns><c>true</c> if the player was successfully added to the list, <c>false</c> otherwise.</returns>
        public bool Execute(ulong _playerId)
        {
            Assert.IsNotNull(NetcodeServiceAPI.GetInstance.GetPlayerPrefab.gameObject);
            
            // Spawn avatar
            NetcodeServiceAPI.GetInstance.SpawnPlayerGameObject(_playerId,
                NetcodeServiceAPI.GetInstance.GetPlayerPrefab.gameObject,
                Vector3.zero, Quaternion.identity, _onBeforeSpawned: (_go) =>
                {
                    var tmp_PlayerBase = _go.GetComponent<NGOPlayerBase>();
                    tmp_PlayerBase.PlayerId = _playerId;
                }
            );

            // Add to player list
            return playerListNetworkVariable.JoinPlayer(_playerId);
        }
    }
}