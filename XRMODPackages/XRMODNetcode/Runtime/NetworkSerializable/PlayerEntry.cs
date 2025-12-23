// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The SlingshotMatch cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Unity.Netcode;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// Represents a player entry in a networked list, containing the client ID and player object reference.
    /// </summary>
    public struct PlayerEntry : INetworkSerializable, IEquatable<PlayerEntry>
    {
        /// <summary>
        /// The unique client ID for this player.
        /// </summary>
        public ulong ClientId;
        
        /// <summary>
        /// Reference to the player's NetworkObject.
        /// </summary>
        public NetworkObjectReference PlayerObject;

        /// <summary>
        /// Serializes the player entry for network transmission.
        /// </summary>
        public void NetworkSerialize<T>(BufferSerializer<T> _serializer) where T : IReaderWriter
        {
            _serializer.SerializeValue(ref ClientId);
            _serializer.SerializeValue(ref PlayerObject);
        }

        /// <summary>
        /// Determines whether this player entry equals another.
        /// </summary>
        public bool Equals(PlayerEntry _other) =>
            ClientId == _other.ClientId && PlayerObject.Equals(_other.PlayerObject);
    }
}