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
using UnityEngine.Serialization;

namespace Phantom.XRMOD.NetcodeModule.Runtime.TableSystem
{
    [Serializable]
    public struct NetworkedSeat : INetworkSerializable, IEquatable<NetworkedSeat>
    {
        public bool isOccupied;
        public ulong playerId;

        public void NetworkSerialize<T>(BufferSerializer<T> _serializer) where T : IReaderWriter
        {
            _serializer.SerializeValue(ref isOccupied);
            _serializer.SerializeValue(ref playerId);
        }

        public readonly bool Equals(NetworkedSeat _other)
        {
            return isOccupied == _other.isOccupied && playerId == _other.playerId;
        }
    }
}