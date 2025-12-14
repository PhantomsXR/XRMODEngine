// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fusion;
using UnityEngine;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public static class FusionNetworkAssetLoaderManager
    {
        private static readonly Dictionary<PlayerRef, bool> _READY_MAP = new();
        private static bool _ALL_READY_TRIGGERED = false;
        private static NetworkRunner _RUNNER;
        private static Action _ON_ALL_READY;

        public static void Init(NetworkRunner _runner)
        {
            _RUNNER = _runner;
            _READY_MAP.Clear();
            _ALL_READY_TRIGGERED = false;
        }

        public static async Task ReportReadyAsync(Func<Task> _asyncLoader)
        {
            if (_asyncLoader != null)
                await _asyncLoader?.Invoke();

            if (_RUNNER == null)
            {
                Debug.LogWarning("[FusionReady] Runner is null");
                return;
            }

            var tmp_Player = _RUNNER.LocalPlayer;

            if (_READY_MAP.TryAdd(tmp_Player, true))
            {
                // 只有主控检查是否全体准备
                if (_RUNNER.IsServer || _RUNNER.IsSharedModeMasterClient)
                    CheckAllReady();
            }
        }

        public static void OnAllCompleted(Action _callback)
        {
            _ON_ALL_READY += _callback;
        }

        private static void CheckAllReady()
        {
            if (_ALL_READY_TRIGGERED) return;

            foreach (var tmp_Player in _RUNNER.ActivePlayers)
            {
                if (!_READY_MAP.TryGetValue(tmp_Player, out var tmp_Ready) || !tmp_Ready)
                    return;
            }

            _ALL_READY_TRIGGERED = true;
            _ON_ALL_READY?.Invoke();
        }
    }
}