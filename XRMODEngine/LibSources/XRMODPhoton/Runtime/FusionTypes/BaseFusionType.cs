// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if FUSION2
using Fusion;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public class BaseFusionType:NetworkBehaviour
    {
        public string Key;
        protected bool TryGetStateSnapshots<T>(string _key,out T _from,out Tick _fromTick,out T _to,out Tick _toTick,out float _alpha) where T : unmanaged
        {
            if (TryGetSnapshotsBuffers(out var tmp_FromBuffer, out var tmp_ToBuffer, out _alpha))
            {
                var tmp_Reader = GetPropertyReader<T>(_key);
                _from = tmp_FromBuffer.Read(tmp_Reader);
                _to = tmp_ToBuffer.Read(tmp_Reader);
                _fromTick = tmp_FromBuffer.Tick;
                _toTick = tmp_ToBuffer.Tick;
                return true;
            }

            _from = default;
            _to = default;
            _fromTick = default;
            _toTick = default;
            return false;
        }
    }
}
#endif