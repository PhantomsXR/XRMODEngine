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
    /// <summary>
    /// A network-serializable string wrapper using FixedString128Bytes (max 128 bytes).
    /// </summary>
    /// <remarks>
    /// Provides implicit conversions between managed strings and network-serializable fixed strings.
    /// Use this when you need to serialize strings up to 128 bytes in length.
    /// </remarks>
    public struct Fixed128StringSerializable : INetworkSerializable
    {
        FixedString128Bytes value;

        /// <summary>
        /// Serializes the string for network transmission.
        /// </summary>
        public void NetworkSerialize<T>(BufferSerializer<T> _serializer) where T : IReaderWriter
        {
            _serializer.SerializeValue(ref value);
        }

        /// <summary>
        /// Returns the string representation.
        /// </summary>
        public override string ToString()
        {
            return value.Value.ToString();
        }

        /// <summary>
        /// Implicit conversion from Fixed128StringSerializable to string.
        /// </summary>
        public static implicit operator string(Fixed128StringSerializable _s) => _s.ToString();

        /// <summary>
        /// Implicit conversion from string to Fixed128StringSerializable.
        /// </summary>
        public static implicit operator Fixed128StringSerializable(string _s) =>
            new Fixed128StringSerializable() {value = new FixedString128Bytes(_s)};
    }
}