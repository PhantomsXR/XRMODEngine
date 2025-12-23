// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Unity.Netcode;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// A network-serializable blob for transmitting arbitrary byte arrays over the network.
    /// </summary>
    /// <remarks>
    /// This struct provides a flexible way to serialize any binary data for network transmission.
    /// It automatically handles null or empty arrays and efficiently serializes the length and data.
    /// Use this when you need to send custom binary data that doesn't fit standard serializable types.
    /// </remarks>
    public struct UnityFusionBlob : INetworkSerializable
    {
        private byte[] data;
        
        /// <summary>
        /// Initializes a new UnityFusionBlob with the specified byte array.
        /// </summary>
        /// <param name="_data">The byte array to serialize.</param>
        public UnityFusionBlob(byte[] _data) => data = _data;

        /// <summary>
        /// Serializes the blob data for network transmission.
        /// </summary>
        public void NetworkSerialize<T>(BufferSerializer<T> _serializer) where T : IReaderWriter
        {
            if (_serializer.IsWriter)
            {
                var tmp_Write = _serializer.GetFastBufferWriter();
                tmp_Write.WriteValueSafe(data?.Length ?? 0);
                if (data != null && data.Length > 0)
                    tmp_Write.WriteBytesSafe(data);
            }
            else
            {
                var tmp_Read = _serializer.GetFastBufferReader();
                tmp_Read.ReadValueSafe(out int tmp_Len);
                data = tmp_Len > 0 ? new byte[tmp_Len] : Array.Empty<byte>();
                if (tmp_Len > 0) tmp_Read.ReadBytesSafe(ref data, tmp_Len);
            }
        }
    }
}