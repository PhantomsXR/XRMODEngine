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
    public struct Fixed128StringSerializable : INetworkSerializable
    {
        FixedString128Bytes value;

        public void NetworkSerialize<T>(BufferSerializer<T> _serializer) where T : IReaderWriter
        {
            _serializer.SerializeValue(ref value);
        }

        public override string ToString()
        {
            return value.Value.ToString();
        }

        public static implicit operator string(Fixed128StringSerializable _s) => _s.ToString();

        public static implicit operator Fixed128StringSerializable(string _s) =>
            new Fixed128StringSerializable() {value = new FixedString128Bytes(_s)};
    }
}