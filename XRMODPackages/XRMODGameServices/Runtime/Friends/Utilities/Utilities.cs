// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.GameServices.Runtime.
// //
// // The Infiniplay_visionOS cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Linq;
using Unity.Services.Friends;
using Unity.Services.Friends.Models;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public static class Utilities
    {
        /// <summary>
        /// Returns a list of members that are not blocked by the active user.
        /// </summary>
        /// <param name="_relationships">The list of relationships to filter.</param>
        /// <returns>Filtered list of members.</returns>
        internal static List<Member> GetNonBlockedMembers(IReadOnlyList<Relationship> _relationships)
        {
            var tmp_Blocks = FriendsService.Instance.Blocks;
            return _relationships
                .Where(_relationship => tmp_Blocks.All(_blockedRelationship =>
                    _blockedRelationship.Member.Id != _relationship.Member.Id))
                .Select(_relationship => _relationship.Member)
                .ToList();
        }
        
        internal static string GetPlayerNameFirstWord(string _playerName)
        {
            if (string.IsNullOrEmpty(_playerName)) return "N";
            return _playerName[0].ToString();
        }
    }
}