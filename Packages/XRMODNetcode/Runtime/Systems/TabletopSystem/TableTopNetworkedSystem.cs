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
    [RequireComponent(typeof(PlayerListNetworkVariable))]
    public class TableTopNetworkedSystem : NetworkBehaviour
    {
        private static TableTopNetworkedSystem _INSTANCE;
        private NetworkList<NetworkedSeat> networkedSeats;


        public static TableTopNetworkedSystem GetInstance => _INSTANCE;
        public PlayerListNetworkVariable PlayerListNetworkVariable;
        public UnityEvent OnJoinSeat;
        public UnityEvent<int> OnLeaveSeat;
        public UnityEvent<NetworkedSeat, NetworkedSeat> OnOccupiedSeatsChange;

        public int MaxSeat
        {
            get => maxSeats;
            set => maxSeats = value;
        }

        [SerializeField] private int maxSeats = 4;
        [SerializeField] private TableSeatSystem tableSeatSystem;
        [SerializeField] private TableTop tableTop;

        public TableSeatSystem TableSeatSystem => tableSeatSystem;
        public TableTop TableTop => tableTop;

        /// <summary>
        /// Action for when a player connects or disconnects.
        /// </summary>
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

        public void RequestAnySeat(ulong _playerId)
        {
            if (!IsValidPlayerId(_playerId))
            {
                Debug.LogError($"Player {_playerId} not exists");
                return;
            }

            RequestSeatServerRpc(_playerId, tableTop.CurrentSeatId);
        }

        public void RequestSeat(int _newSeatChoice)
        {
            RequestSeatServerRpc(NetworkManager.LocalClientId, tableTop.CurrentSeatId, _newSeatChoice);
        }

        public PlayerEntry GetPlayerBySeatId(int _seatId) => PlayerListNetworkVariable.GetPlayerList[_seatId];


        private bool IsValidPlayerId(ulong _playerId)
        {
            return _playerId != ulong.MaxValue;
        }

        #region AssignSeat Methods

        public bool IsSeatOccupied(int _seatId)
        {
            if (_seatId < 0) return false;
            if (_seatId >= maxSeats) return true;
            return networkedSeats[_seatId].isOccupied;
        }

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