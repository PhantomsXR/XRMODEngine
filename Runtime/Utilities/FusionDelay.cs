// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The TankBrawl cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Threading.Tasks;
using Fusion;
using UnityEngine;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public static class FusionDelay
    {
        /// <summary>
        /// Delayed execution (based on Runner Tick, synchronization is reliable)
        /// </summary>
        /// <param name="_runner">Fusion Runner</param>
        /// <param name="_seconds">Delay time (seconds)</param>
        public static async Task Await(NetworkRunner _runner, float _seconds)
        {
            if (_runner == null || !_runner.IsRunning)
            {
                Debug.LogWarning("FusionDelay: Runner is not started, skip waiting.");
                return;
            }

            var tmp_Timer = TickTimer.CreateFromSeconds(_runner, _seconds);

            // 等待直到 TickTimer 过期（在 Fusion 的主线程上轮询）
            while (!tmp_Timer.Expired(_runner))
            {
                await Task.Yield(); // 异步挂起一帧，避免卡主线程
            }
        }
    }
}