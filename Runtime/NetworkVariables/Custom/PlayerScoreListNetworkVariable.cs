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
    /// <summary>
    /// A network variable that manages player scores in a dictionary, with ranking support.
    /// </summary>
    /// <remarks>
    /// This class provides:
    /// - Synchronized score tracking across the network
    /// - Automatic ranking calculation based on scores
    /// - Events for score changes
    /// - Efficient add, remove, and update operations
    /// </remarks>
    public class PlayerScoreListNetworkVariable : BaseNetworkVariable, IDisposable
    {
        /// <summary>
        /// The network-synchronized dictionary mapping player IDs to scores.
        /// </summary>
        [HideInInspector] public NetworkDictionary<ulong, int> PlayerScoreList = new();
        
        /// <summary>
        /// Event invoked when the score list changes.
        /// </summary>
        [HideInInspector] public UnityEvent<NetworkDictionaryEvent<ulong, int>> OnValueChanged = new();

        private Dictionary<ulong, int> sortedPlayerList = new();

        private void Awake()
        {
            if (UseChangeEvent)
                PlayerScoreList.OnDictionaryChanged += OnScoreListChanged;
        }

        /// <summary>
        /// Called when the network object despawns.
        /// </summary>
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

        /// <summary>
        /// Gets the player score dictionary.
        /// </summary>
        public NetworkDictionary<ulong, int> GetPlayerScoreList => PlayerScoreList;

        /// <summary>
        /// Adds a new player with an initial score.
        /// </summary>
        /// <param name="_playerId">The unique player ID.</param>
        /// <param name="_playerScore">The initial score for the player.</param>
        public void Add(ulong _playerId, int _playerScore)
        {
            if (PlayerScoreList.ContainsKey(_playerId)) return;
            PlayerScoreList.Add(_playerId, _playerScore);
        }

        /// <summary>
        /// Removes a player from the score list.
        /// </summary>
        /// <param name="_id">The player ID to remove.</param>
        public void Remove(ulong _id)
        {
            if (PlayerScoreList.Remove(_id))
            {
                sortedPlayerList.Remove(_id);
            }
        }

        /// <summary>
        /// Gets the ranking position of a player based on their score.
        /// </summary>
        /// <param name="_playerId">The player ID to get ranking for.</param>
        /// <returns>The 1-based ranking position, or -1 if the player is not found.</returns>
        /// <remarks>
        /// Rankings are calculated in descending score order (highest score = rank 1).
        /// </remarks>
        public int GetRankingWithPlayerId(ulong _playerId)
        {
            if (sortedPlayerList.Count < 1) return -1;
            var tmp_SortedResult = sortedPlayerList
                .OrderByDescending(_kv => _kv.Value)
                .ToList();

            var tmp_Index = tmp_SortedResult.FindIndex(_entry => _entry.Key == _playerId) + 1;
            return tmp_Index;
        }

        /// <summary>
        /// Changes (adds to) a player's score.
        /// </summary>
        /// <param name="_playerId">The player ID whose score to change.</param>
        /// <param name="_score">The score delta to add (can be negative).</param>
        public void ChangedScore(ulong _playerId, int _score)
        {
            if (PlayerScoreList.ContainsKey(_playerId))
                PlayerScoreList[_playerId] += _score;
        }

        /// <summary>
        /// Clears all player scores.
        /// </summary>
        public void Clear()
        {
            PlayerScoreList.Clear();
            sortedPlayerList.Clear();
        }

        /// <summary>
        /// Disposes of the player score list.
        /// </summary>
        public void Dispose()
        {
            PlayerScoreList?.Dispose();
        }
    }

    /// <summary>
    /// Represents a player score entry with ID and score.
    /// </summary>
    public class PlayerScoreEntry
    {
        /// <summary>
        /// The unique player ID.
        /// </summary>
        public ulong PlayerId;
        
        /// <summary>
        /// The player's score.
        /// </summary>
        public int Score;
    }
}