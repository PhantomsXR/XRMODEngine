// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Unity.Collections;
using Unity.Netcode;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    public struct Fixed512StringSerializable : INetworkSerializable
    {
        FixedString512Bytes value;

        public void NetworkSerialize<T>(BufferSerializer<T> _serializer) where T : IReaderWriter
        {
            _serializer.SerializeValue(ref value);
        }

        public override string ToString()
        {
            return value.Value;
        }

        public static implicit operator string(Fixed512StringSerializable _s) => _s.ToString();

        public static implicit operator Fixed512StringSerializable(string _s) =>
            new Fixed512StringSerializable() {value = new FixedString512Bytes(_s)};
    }
}