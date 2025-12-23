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
    /// A network-serializable string wrapper using FixedString512Bytes (max 512 bytes).
    /// </summary>
    /// <remarks>
    /// Provides implicit conversions between managed strings and network-serializable fixed strings.
    /// Use this for medium-length strings like chat messages or descriptions.
    /// </remarks>
    public struct Fixed512StringSerializable : INetworkSerializable
    {
        FixedString512Bytes value;

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
            return value.Value;
        }

        /// <summary>
        /// Implicit conversion from Fixed512StringSerializable to string.
        /// </summary>
        public static implicit operator string(Fixed512StringSerializable _s) => _s.ToString();

        /// <summary>
        /// Implicit conversion from string to Fixed512StringSerializable.
        /// </summary>
        public static implicit operator Fixed512StringSerializable(string _s) =>
            new Fixed512StringSerializable() {value = new FixedString512Bytes(_s)};
    }
}