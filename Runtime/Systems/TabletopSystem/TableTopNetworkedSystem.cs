// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the NetCodeTest.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/


using System;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;

namespace Phantom.XRMOD.NetcodeModule.Runtime.TableSystem
{
    /// <summary>
    /// Manages the networked tabletop system, including seat assignment and player connection events.
    /// </summary>
    [RequireComponent(typeof(PlayerListNetworkVariable))]
    public class TableTopNetworkedSystem : NetworkBehaviour
    {
        private static TableTopNetworkedSystem _INSTANCE;
        private NetworkList<NetworkedSeat> networkedSeats;


        /// <summary>
        /// Gets the singleton instance of the TableTopNetworkedSystem.
        /// </summary>
        public static TableTopNetworkedSystem GetInstance => _INSTANCE;
        
        /// <summary>
        /// The network variable tracking the list of connected players.
        /// </summary>
        public PlayerListNetworkVariable PlayerListNetworkVariable;
        
        /// <summary>
        /// Event triggered when a local player joins a seat.
        /// </summary>
        public UnityEvent OnJoinSeat;
        
        /// <summary>
        /// Event triggered when a player leaves a seat.
        /// </summary>
        public UnityEvent<int> OnLeaveSeat;
        
        /// <summary>
        /// Event triggered when seat occupancy changes.
        /// </summary>
        public UnityEvent<NetworkedSeat, NetworkedSeat> OnOccupiedSeatsChange;

        /// <summary>
        /// Gets or sets the maximum number of seats available at the table.
        /// </summary>
        public int MaxSeat
        {
            get => maxSeats;
            set => maxSeats = value;
        }

        [SerializeField] private int maxSeats = 4;
        [SerializeField] private TableSeatSystem tableSeatSystem;
        [SerializeField] private TableTop tableTop;

        /// <summary>
        /// Gets the associated TableSeatSystem instance.
        /// </summary>
        public TableSeatSystem TableSeatSystem => tableSeatSystem;
        
        /// <summary>
        /// Gets the associated TableTop instance.
        /// </summary>
        public TableTop TableTop => tableTop;

        /// <summary>
        /// Action invoked when a player connects or disconnects.
        /// </summary>
        /// <remarks>
        /// Parameters: (playerId, isConnected)
        /// </remarks>
        public Action<ulong, bool> OnPlayerStateChanged;

        private void Awake()
        {
            _INSTANCE = this;
            if (tableTop == null)
                tableTop = FindFirstObjectByType<TableTop>(FindObjectsInactive.Include);

            if (tableSeatSystem == null)
                tableSeatSystem = FindFirstObjectByType<TableSeatSystem>(FindObjectsInactive.Include);

            networkedSeats = new NetworkList<NetworkedSeat>();
            PlayerListNetworkVariable = GetComponent<PlayerListNetworkVariable>();
            NetworkManager.OnConnectionEvent += ConnectionCallback;
        }

        private void ConnectionCallback(NetworkManager _arg1, ConnectionEventData _arg2)
        {
            if (!_arg1.IsServer) return;

            switch (_arg2.EventType)
            {
                case ConnectionEvent.ClientConnected:
                    if (new ClientConnected(_arg1, PlayerListNetworkVariable).Execute(_arg2.ClientId))
                        OnPlayerStateChanged?.Invoke(_arg2.ClientId, true);
                    break;
                case ConnectionEvent.PeerConnected:
                    break;
                case ConnectionEvent.ClientDisconnected:
                    if (new ClientDisconnected(_arg1, PlayerListNetworkVariable).Execute(_arg2.ClientId))
                        OnPlayerStateChanged?.Invoke(_arg2.ClientId, false);
                    break;
                case ConnectionEvent.PeerDisconnected:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Called when the network object spawns.
        /// </summary>
        public override void OnNetworkSpawn()
        {
            if (IsServer)
            {
                networkedSeats.Clear();
                for (int tmp_SeatIdx = 0; tmp_SeatIdx < maxSeats; tmp_SeatIdx++)
                {
                    networkedSeats.Add(new NetworkedSeat() {isOccupied = false, playerId = ulong.MaxValue});
                }

                OnPlayerStateChanged += OnPlayerStateChangedCallBack;
            }

            networkedSeats.OnListChanged += OnOccupiedSeatsChanged;
            RequestAnySeat(NetworkManager.LocalClientId);
        }

        /// <summary>
        /// Called when the network object despawns.
        /// </summary>
        public override void OnNetworkDespawn()
        {
            base.OnNetworkDespawn();
            OnPlayerStateChanged -= OnPlayerStateChangedCallBack;
            networkedSeats.OnListChanged -= OnOccupiedSeatsChanged;
            NetworkManager.OnConnectionEvent -= ConnectionCallback;

            // Reset table seat system
            tableSeatSystem.TableTop.CurrentSeatId = -1;
            tableSeatSystem.ResetToSeatDefault();
        }

        /// <summary>
        /// Requests any available seat for the specified player.
        /// </summary>
        /// <param name="_playerId">The ID of the player requesting a seat.</param>
        public void RequestAnySeat(ulong _playerId)
        {
            if (!IsValidPlayerId(_playerId))
            {
                Debug.LogError($"Player {_playerId} not exists");
                return;
            }

            RequestSeatServerRpc(_playerId, tableTop.CurrentSeatId);
        }

        /// <summary>
        /// Requests a specific seat for the local player.
        /// </summary>
        /// <param name="_newSeatChoice">The ID of the desired seat.</param>
        public void RequestSeat(int _newSeatChoice)
        {
            RequestSeatServerRpc(NetworkManager.LocalClientId, tableTop.CurrentSeatId, _newSeatChoice);
        }

        /// <summary>
        /// Gets the player entry for a specific seat.
        /// </summary>
        /// <param name="_seatId">The seat ID to query.</param>
        /// <returns>The player entry occupying that seat.</returns>
        public PlayerEntry GetPlayerBySeatId(int _seatId) => PlayerListNetworkVariable.GetPlayerList[_seatId];


        private bool IsValidPlayerId(ulong _playerId)
        {
            return _playerId != ulong.MaxValue;
        }

        #region AssignSeat Methods

        /// <summary>
        /// Checks if a specific seat is occupied.
        /// </summary>
        /// <param name="_seatId">The seat ID to check.</param>
        /// <returns><c>true</c> if the seat is occupied, <c>false</c> otherwise.</returns>
        public bool IsSeatOccupied(int _seatId)
        {
            if (_seatId < 0) return false;
            if (_seatId >= maxSeats) return true;
            return networkedSeats[_seatId].isOccupied;
        }

        /// <summary>
        /// Checks if a specific seat is occupied by a specific player.
        /// </summary>
        /// <param name="_seatId">The seat ID to check.</param>
        /// <param name="_playerId">The player ID to verify.</param>
        /// <returns><c>true</c> if the seat is occupied by the specified player, <c>false</c> otherwise.</returns>
        public bool IsSeatOccupied(int _seatId, ulong _playerId)
        {
            if (_seatId < 0) return false;
            if (_seatId >= maxSeats) return true;
            return networkedSeats[_seatId].isOccupied && networkedSeats[_seatId].playerId == _playerId;
        }

        private void OnPlayerStateChangedCallBack(ulong _playerId, bool _connected)
        {
            if (_connected) return;
            for (int tmp_Idx = 0; tmp_Idx < networkedSeats.Count; tmp_Idx++)
            {
                if (networkedSeats[tmp_Idx].playerId == _playerId)
                    ServerRemoveSeat(tmp_Idx);
            }
        }

        private void OnOccupiedSeatsChanged(NetworkListEvent<NetworkedSeat> _changeEvent)
        {
            OnOccupiedSeatsChange?.Invoke(_changeEvent.PreviousValue, _changeEvent.Value);
        }

        private int GetAnyAvailableSeats()
        {
            int tmp_AvailableSeatId = -1;
            for (int tmp_Idx = 0; tmp_Idx < networkedSeats.Count; tmp_Idx++)
            {
                if (networkedSeats[tmp_Idx].isOccupied)
                {
                    continue;
                }

                tmp_AvailableSeatId = tmp_Idx;
                return tmp_AvailableSeatId;
            }

            return tmp_AvailableSeatId;
        }

        private void ServerRemoveSeat(int _seatId)
        {
            if (!Application.isPlaying) return;
            networkedSeats[_seatId] = new NetworkedSeat() {isOccupied = false, playerId = ulong.MaxValue};
            RemovePlayerFromSeatToEveryoneRpc(_seatId);
        }

        private void ServerAssignSeat(int _currentSeatId, int _newSeatId, ulong _playerId)
        {
            if (_currentSeatId >= 0)
            {
                ServerRemoveSeat(_currentSeatId);
            }

            if (_newSeatId >= 0)
            {
                networkedSeats[_newSeatId] = new NetworkedSeat {isOccupied = true, playerId = _playerId};
            }

            AssignSeatToEveryoneRpc(_newSeatId, _playerId);
        }

        #endregion

        #region RPC Methods

        [Rpc(SendTo.Server)]
        private void RequestSeatServerRpc(ulong _playerId, int _currentSeatId, int _newSeatId = -2)
        {
            if (!Application.isPlaying) return;
            if (_newSeatId <= -2)
                _newSeatId = GetAnyAvailableSeats();
            if (!IsSeatOccupied(_newSeatId))
            {
                ServerAssignSeat(_currentSeatId, _newSeatId, _playerId);
            }
            else
            {
                Debug.Log("User tried to join an occupied seat.");
            }
        }

        [Rpc(SendTo.Everyone)]
        private void AssignSeatToEveryoneRpc(int _seatId, ulong _playerId)
        {
            if (!Application.isPlaying) return;
            if (!NetworkManager.ConnectedClients.ContainsKey(_playerId))
            {
                Debug.LogError($"Player with ID {_playerId} not found");
                return;
            }

            if (_playerId != NetworkManager.Singleton.LocalClientId) return;
            tableSeatSystem.TeleportToSeat(_seatId);
            OnJoinSeat?.Invoke();
        }

        [Rpc(SendTo.Everyone)]
        private void RemovePlayerFromSeatToEveryoneRpc(int _seatId)
        {
            if (!Application.isPlaying) return;
            OnLeaveSeat?.Invoke(_seatId);
        }

        #endregion
    }
}