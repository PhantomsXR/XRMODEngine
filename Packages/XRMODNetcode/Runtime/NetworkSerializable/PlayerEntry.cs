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
    public struct PlayerEntry : INetworkSerializable, IEquatable<PlayerEntry>
    {
        public ulong ClientId;
        public NetworkObjectReference PlayerObject;

        public void NetworkSerialize<T>(BufferSerializer<T> _serializer) where T : IReaderWriter
        {
            _serializer.SerializeValue(ref ClientId);
            _serializer.SerializeValue(ref PlayerObject);
        }

        public bool Equals(PlayerEntry _other) =>
            ClientId == _other.ClientId && PlayerObject.Equals(_other.PlayerObject);
    }
}