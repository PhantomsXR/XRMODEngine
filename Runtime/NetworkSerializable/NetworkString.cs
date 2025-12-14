// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The VisionOSPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Unity.Collections;
using Unity.Netcode;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    public struct NetworkString : INetworkSerializable, IEquatable<NetworkString>
    {
        public string Value;

        public NetworkString(string _value)
        {
            Value = _value;
        }

        public void NetworkSerialize<T>(BufferSerializer<T> _serializer) where T : IReaderWriter
        {
            if (_serializer.IsWriter)
            {
                var tmp_FixedStr = new FixedString128Bytes(Value);
                _serializer.SerializeValue(ref tmp_FixedStr);
            }
            else
            {
                FixedString128Bytes tmp_FixedStr = default;
                _serializer.SerializeValue(ref tmp_FixedStr);
                Value = tmp_FixedStr.ToString();
            }
        }

        public override string ToString() => Value;

        public bool Equals(NetworkString _other) => Value == _other.Value;
    }
}