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
using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    public static class PlayerListExtensions
    {
        public static GameObject GetPlayer(this PlayerListNetworkVariable _playerList, ulong _playerId)
        {
            var tmp_NgoPlayers =
                Object.FindObjectsByType<NGOPlayerBase>(FindObjectsInactive.Include, FindObjectsSortMode.None);

            foreach (var tmp_NgoPlayer in tmp_NgoPlayers)
            {
                if (!tmp_NgoPlayer.IsValid) continue;
                if (tmp_NgoPlayer.PlayerId == _playerId)
                    return tmp_NgoPlayer.gameObject;
            }

            return null;
        }
    }
}