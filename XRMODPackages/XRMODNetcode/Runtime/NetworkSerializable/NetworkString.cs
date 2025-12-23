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
    /// <summary>
    /// A network-serializable string wrapper using FixedString128Bytes.
    /// </summary>
    /// <remarks>
    /// This struct provides automatic conversion between managed strings and Unity's FixedString128Bytes for network serialization.
    /// Maximum capacity is 128 bytes. For longer strings, consider using higher-capacity fixed string types.
    /// </remarks>
    public struct NetworkString : INetworkSerializable, IEquatable<NetworkString>
    {
        /// <summary>
        /// The string value.
        /// </summary>
        public string Value;

        /// <summary>
        /// Initializes a new instance of <see cref="NetworkString"/> with the specified value.
        /// </summary>
        /// <param name="_value">The string value.</param>
        public NetworkString(string _value)
        {
            Value = _value;
        }

        /// <summary>
        /// Serializes the string for network transmission.
        /// </summary>
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

        /// <summary>
        /// Returns the string representation of this NetworkString.
        /// </summary>
        public override string ToString() => Value;

        /// <summary>
        /// Determines whether this NetworkString equals another.
        /// </summary>
        public bool Equals(NetworkString _other) => Value == _other.Value;
    }
}