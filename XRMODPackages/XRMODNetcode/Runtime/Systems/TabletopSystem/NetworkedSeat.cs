// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the NetCodeTest.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Unity.Netcode;

namespace Phantom.XRMOD.NetcodeModule.Runtime.TableSystem
{
    /// <summary>
    /// Represents the state of a seat in a networked environment.
    /// </summary>
    [Serializable]
    public struct NetworkedSeat : INetworkSerializable, IEquatable<NetworkedSeat>
    {
        /// <summary>
        /// Whether the seat is currently occupied.
        /// </summary>
        public bool isOccupied;

        /// <summary>
        /// The ID of the player occupying the seat.
        /// </summary>
        public ulong playerId;

        /// <summary>
        /// Serializes the seat data for network transmission.
        /// </summary>
        /// <typeparam name="T">The type of reader/writer.</typeparam>
        /// <param name="_serializer">The serializer instance.</param>
        public void NetworkSerialize<T>(BufferSerializer<T> _serializer) where T : IReaderWriter
        {
            _serializer.SerializeValue(ref isOccupied);
            _serializer.SerializeValue(ref playerId);
        }

        /// <summary>
        /// Checks if this seat state is equal to another.
        /// </summary>
        /// <param name="_other">The other seat state to compare with.</param>
        /// <returns><c>true</c> if both are equal, <c>false</c> otherwise.</returns>
        public readonly bool Equals(NetworkedSeat _other)
        {
            return isOccupied == _other.isOccupied && playerId == _other.playerId;
        }
    }
}