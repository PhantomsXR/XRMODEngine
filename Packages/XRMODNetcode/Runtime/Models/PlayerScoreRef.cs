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

using System;
using Unity.Collections;
using Unity.Netcode;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    [System.Serializable]
    public struct PlayerScoreRef : INetworkSerializable, IEquatable<PlayerScoreRef>
    {
        public ulong PlayerId;
        public int Score;

        public void NetworkSerialize<T>(BufferSerializer<T> _serializer) where T : IReaderWriter
        {
            _serializer.SerializeValue(ref PlayerId);
            _serializer.SerializeValue(ref Score);
        }

        public bool Equals(PlayerScoreRef _other)
        {
            return PlayerId == _other.PlayerId && Score == _other.Score;
        }

        public PlayerScoreRef(ulong _playerId, int _score)
        {
            PlayerId = _playerId;
            Score = _score;
        }
    }
}