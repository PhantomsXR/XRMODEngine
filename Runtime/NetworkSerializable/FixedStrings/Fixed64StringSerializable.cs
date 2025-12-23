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
    /// A network-serializable string wrapper using FixedString64Bytes (max 64 bytes).
    /// </summary>
    /// <remarks>
    /// Provides implicit conversions between managed strings and network-serializable fixed strings.
    /// Use this for short strings like player names or short messages.
    /// </remarks>
    public struct Fixed64StringSerializable : INetworkSerializable
    {
        FixedString64Bytes value;

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
        /// Implicit conversion from Fixed64StringSerializable to string.
        /// </summary>
        public static implicit operator string(Fixed64StringSerializable _s) => _s.ToString();

        /// <summary>
        /// Implicit conversion from string to Fixed64StringSerializable.
        /// </summary>
        public static implicit operator Fixed64StringSerializable(string _s) =>
            new Fixed64StringSerializable() {value = new FixedString64Bytes(_s)};
    }
}