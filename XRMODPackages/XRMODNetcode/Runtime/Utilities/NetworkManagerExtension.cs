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

using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Phantom.XRMOD.NetcodeModule.Runtime.Gameplay;
using Unity.Netcode;
using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    public static class NetworkManagerExtension
    {
        private static ulong _LOCAL_PLAYER_REF = ulong.MaxValue;

        public static ulong LocalPlayerRef(this NetworkManager _networkManager)
        {
            if (_LOCAL_PLAYER_REF == ulong.MaxValue)
                _LOCAL_PLAYER_REF = NetworkManager.Singleton.LocalClientId;
            return _LOCAL_PLAYER_REF;
        }

        public static ulong SetLocalPlayerRef(this NetworkManager _networkManager, ulong _playerRef)
        {
            _LOCAL_PLAYER_REF = _playerRef;
            return _LOCAL_PLAYER_REF;
        }

        public static bool TryGetPlayerById(this NetworkManager _networkManager, ulong _playerID,
            out NGOPlayerBase _player)
        {
            _player = null;
            if (!_networkManager.ConnectedClients.TryGetValue(_playerID, out var tmp_Client)) return false;
            if (tmp_Client.PlayerObject != null) return tmp_Client.PlayerObject.TryGetComponent(out _player);
            _player = FindPlayerByReference(_playerID);
            return _player != null;
        }


        private static NGOPlayerBase FindPlayerByReference(ulong _playerID)
        {
            var tmp_AllPlayers =
                Object.FindObjectsByType<NGOPlayerBase>(FindObjectsInactive.Include, FindObjectsSortMode.None);
            foreach (var tmp_Client in tmp_AllPlayers)
            {
                if (tmp_Client.NetworkObject.OwnerClientId == _playerID) return tmp_Client;
            }

            Debug.LogError($"Player with id {_playerID} not found");

            return null;
        }


        public static string GetFixedCode(this NetworkManager _manager, string _input)
        {
            const string tmp_const_ConstCharSet = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            using var tmp_MD5 = MD5.Create();
            byte[] tmp_HashBytes = tmp_MD5.ComputeHash(Encoding.UTF8.GetBytes(_input));
            var tmp_Sb = new StringBuilder();
            for (int tmp_I = 0; tmp_I < 6; tmp_I++)
            {
                tmp_Sb.Append(tmp_const_ConstCharSet[tmp_HashBytes[tmp_I] % tmp_const_ConstCharSet.Length]);
            }

            return tmp_Sb.ToString();
        }
    }
}