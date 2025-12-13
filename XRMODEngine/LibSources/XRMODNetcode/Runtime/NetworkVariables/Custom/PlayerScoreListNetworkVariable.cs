// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    public class PlayerScoreListNetworkVariable : BaseNetworkVariable, IDisposable
    {
        [HideInInspector] public NetworkDictionary<ulong, int> PlayerScoreList = new();
        [HideInInspector] public UnityEvent<NetworkDictionaryEvent<ulong, int>> OnValueChanged = new();

        private Dictionary<ulong, int> sortedPlayerList = new();

        private void Awake()
        {
            if (UseChangeEvent)
                PlayerScoreList.OnDictionaryChanged += OnScoreListChanged;
        }

        public override void OnNetworkDespawn()
        {
            base.OnNetworkDespawn();
            if (UseChangeEvent)
                PlayerScoreList.OnDictionaryChanged -= OnScoreListChanged;
        }

        private void OnScoreListChanged(NetworkDictionaryEvent<ulong, int> _changeevent)
        {
            OnValueChanged?.Invoke(_changeevent);
            sortedPlayerList[_changeevent.Key] = _changeevent.Value;
        }

        public NetworkDictionary<ulong, int> GetPlayerScoreList => PlayerScoreList;

        public void Add(ulong _playerId, int _playerScore)
        {
            if (PlayerScoreList.ContainsKey(_playerId)) return;
            PlayerScoreList.Add(_playerId, _playerScore);
        }

        public void Remove(ulong _id)
        {
            if (PlayerScoreList.Remove(_id))
            {
                sortedPlayerList.Remove(_id);
            }
        }

        public int GetRankingWithPlayerId(ulong _playerId)
        {
            if (sortedPlayerList.Count < 1) return -1;
            var tmp_SortedResult = sortedPlayerList
                .OrderByDescending(_kv => _kv.Value)
                .ToList();

            var tmp_Index = tmp_SortedResult.FindIndex(_entry => _entry.Key == _playerId) + 1;
            return tmp_Index;
        }

        public void ChangedScore(ulong _playerId, int _score)
        {
            if (PlayerScoreList.ContainsKey(_playerId))
                PlayerScoreList[_playerId] += _score;
        }

        public void Clear()
        {
            PlayerScoreList.Clear();
            sortedPlayerList.Clear();
        }

        public void Dispose()
        {
            PlayerScoreList?.Dispose();
        }
    }

    public class PlayerScoreEntry
    {
        public ulong PlayerId;
        public int Score;
    }
}