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
    /// <summary>
    /// Extension methods for <see cref="PlayerListNetworkVariable"/>.
    /// </summary>
    public static class PlayerListExtensions
    {
        /// <summary>
        /// Retrieves a player GameObject by player ID.
        /// </summary>
        /// <param name="_playerList">The player list to search.</param>
        /// <param name="_playerId">The unique player ID to find.</param>
        /// <returns>The player's GameObject if found, otherwise null.</returns>
        /// <remarks>
        /// This method searches through all NGOPlayerBase components in the scene (including inactive objects)
        /// to find the matching player. For performance-critical scenarios, consider caching player references.
        /// </remarks>
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