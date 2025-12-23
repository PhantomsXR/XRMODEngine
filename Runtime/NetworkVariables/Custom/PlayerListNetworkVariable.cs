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
using Phantom.XRMOD.NetcodeModule.Runtime.Gameplay;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// A network list that manages player entries and provides caching for efficient player lookups.
    /// </summary>
    /// <remarks>
    /// This class maintains a synchronized list of players across the network and provides:
    /// - Automatic caching of NGOPlayerBase components for quick access
    /// - Events for player add/remove
    /// - Ready state tracking for all players
    /// - Automatic cache rebuilding when the network list changes
    /// </remarks>
    public class PlayerListNetworkVariable : BaseNetworkVariable, IDisposable
    {
        public readonly NetworkList<PlayerEntry> PlayerList = new();
        [HideInInspector] public UnityEvent<NetworkListEvent<PlayerEntry>> OnValueChanged = new();
        private readonly Dictionary<ulong, NGOPlayerBase> cache = new();
        private readonly List<NGOPlayerBase> ngoPlayerBases = new(16);
        public int Count => PlayerList.Count;
        public int AtLestForPrepare = 1;

        public int ReadyCount { get; private set; } = 0;

        public event Action<NGOPlayerBase> OnPlayerAdded;
        public event Action<ulong> OnPlayerRemoved;

        private void Awake()
        {
            if (!enabled) return;
            if (UseChangeEvent)
                PlayerList.OnListChanged += OnPlayerListChanged;
        }

        public override void OnNetworkDespawn()
        {
            base.OnNetworkDespawn();
            if (UseChangeEvent)
                PlayerList.OnListChanged -= OnPlayerListChanged;
        }


        public NetworkList<PlayerEntry> GetPlayerList => PlayerList;

        public PlayerEntry GetPlayer(ulong _playerId)
        {
            foreach (var tmp_Player in PlayerList)
            {
                if (tmp_Player.ClientId == _playerId)
                    return tmp_Player;
            }

            return default;
        }


        public bool JoinPlayer(ulong _playerId)
        {
            if (!IsServer) return false;
            var tmp_PlayerObject = NetworkManager.Singleton.SpawnManager.GetPlayerNetworkObject(_playerId);
            var tmp_PlayerEntry = new PlayerEntry()
            {
                ClientId = _playerId,
                PlayerObject = tmp_PlayerObject
            };
            AddOrReplace(tmp_PlayerEntry);
            return true;
        }

        public bool LeavePlayer(ulong _playerId)
        {
            if (!IsServer) return false;
            var tmp_Idx = IndexOfClient(_playerId);
            if (tmp_Idx < 0) return false;
            PlayerList.RemoveAt(tmp_Idx);
            return true;
        }

        public IReadOnlyList<NGOPlayerBase> AllNgoPlayers
        {
            get
            {
                RebuildCacheIfNeeded();
                ngoPlayerBases.Clear();
                ngoPlayerBases.AddRange(cache.Values);
                return ngoPlayerBases;
            }
        }

        public bool AllPlayersReady
        {
            get
            {
                if (AllNgoPlayers.Count == 1)
                    return true;

                int tmp_ReadyCount = 0;
                foreach (NGOPlayerBase tmp_NgoPlayerBase in AllNgoPlayers)
                {
                    if (tmp_NgoPlayerBase.IsReady)
                    {
                        tmp_ReadyCount++;
                    }
                }

                ReadyCount = tmp_ReadyCount;
                return tmp_ReadyCount == AllNgoPlayers.Count && tmp_ReadyCount > AtLestForPrepare;
            }
        }

        public void Dispose()
        {
            PlayerList?.Dispose();
        }


        #region Private methods

        private void OnPlayerListChanged(NetworkListEvent<PlayerEntry> _changeevent)
        {
            switch (_changeevent.Type)
            {
                case NetworkListEvent<PlayerEntry>.EventType.Add:
                case NetworkListEvent<PlayerEntry>.EventType.Insert:
                case NetworkListEvent<PlayerEntry>.EventType.Value:
                    ResolveAndCache(_changeevent.Value);
                    break;

                case NetworkListEvent<PlayerEntry>.EventType.Remove:
                case NetworkListEvent<PlayerEntry>.EventType.RemoveAt:
                case NetworkListEvent<PlayerEntry>.EventType.Clear:
                    // Rebuild 更稳妥（保持简洁可靠）
                    RebuildCacheFromSyncedList();
                    break;
            }

            OnValueChanged?.Invoke(_changeevent);
        }

        internal int IndexOfClient(ulong _clientId)
        {
            for (int tmp_I = 0; tmp_I < PlayerList.Count; tmp_I++)
                if (PlayerList[tmp_I].ClientId == _clientId)
                    return tmp_I;
            return -1;
        }


        private void RebuildCacheIfNeeded()
        {
            // 如果数量不一致或存在空引用，重建一次
            if (cache.Count != PlayerList.Count)
            {
                RebuildCacheFromSyncedList();
                return;
            }

            foreach (var tmp_Kv in cache)
            {
                if (tmp_Kv.Value != null) continue;
                RebuildCacheFromSyncedList();
                return;
            }
        }

        private void AddOrReplace(PlayerEntry _entry)
        {
            var tmp_Idx = IndexOfClient(_entry.ClientId);
            if (tmp_Idx >= 0)
                PlayerList[tmp_Idx] = _entry;
            else
                PlayerList.Add(_entry);
        }


        private void RebuildCacheFromSyncedList()
        {
            var tmp_Previous = new HashSet<ulong>(cache.Keys);
            var tmp_Added = new List<NGOPlayerBase>();
            var tmp_Removed = new List<ulong>();

            // 清点新的
            foreach (var tmp_Entry in PlayerList)
            {
                if (!TryResolve(tmp_Entry, out var tmp_Comp)) continue;

                cache[tmp_Entry.ClientId] = tmp_Comp;
                if (!tmp_Previous.Remove(tmp_Entry.ClientId))
                    tmp_Added.Add(tmp_Comp);
            }

            // 之前有，但现在没了的
            foreach (var tmp_Gone in tmp_Previous)
            {
                cache.Remove(tmp_Gone);
                tmp_Removed.Add(tmp_Gone);
            }

            // 事件
            foreach (var tmp_A in tmp_Added) OnPlayerAdded?.Invoke(tmp_A);
            foreach (var tmp_R in tmp_Removed) OnPlayerRemoved?.Invoke(tmp_R);
        }

        private void ResolveAndCache(PlayerEntry _entry)
        {
            if (TryResolve(_entry, out var tmp_Comp))
            {
                var tmp_IsNew = !cache.ContainsKey(_entry.ClientId);
                cache[_entry.ClientId] = tmp_Comp;
                if (tmp_IsNew) OnPlayerAdded?.Invoke(tmp_Comp);
            }
            else
            {
                // 解析失败：等下一次回调或 Rebuild 时再尝试
            }
        }

        private bool TryResolve(PlayerEntry _entry, out NGOPlayerBase _comp)
        {
            _comp = null;

            if (!_entry.PlayerObject.TryGet(out var tmp_NetObj)) return false;
            if (tmp_NetObj == null) return false;

            _comp = tmp_NetObj.GetComponent<NGOPlayerBase>();
            return _comp != null;
        }

        #endregion
    }
}