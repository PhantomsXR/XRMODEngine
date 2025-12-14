// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Avatar.Runtime.
// //
// // The Avatar cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Fusion;
using UnityEngine;

namespace Phantom.XRMOD.Avatar.Runtime
{
    public struct NetworkVector3 : INetworkStruct
    {
        public float x, y, z;
        public static implicit operator Vector3(NetworkVector3 _nv) => new Vector3(_nv.x, _nv.y, _nv.z);
        public static implicit operator NetworkVector3(Vector3 _v) => new NetworkVector3 {x = _v.x, y = _v.y, z = _v.z};
    }


    public struct NetworkQuaternion : INetworkStruct
    {
        public float x, y, z, w;

        public static implicit operator Quaternion(NetworkQuaternion _nq) => new Quaternion(_nq.x, _nq.y, _nq.z, _nq.w);

        public static implicit operator NetworkQuaternion(Quaternion _q) =>
            new NetworkQuaternion {x = _q.x, y = _q.y, z = _q.z, w = _q.w};
    }


    public struct CompressedVector3 : INetworkStruct
    {
        [Networked] public short x { get; set; }
        [Networked] public short y { get; set; }
        [Networked] public short z { get; set; }

        public static implicit operator Vector3(CompressedVector3 _cv) =>
            new Vector3(_cv.x / 1000f, _cv.y / 1000f, _cv.z / 1000f);

        public static implicit operator CompressedVector3(Vector3 _v) => new CompressedVector3
        {
            x = (short) (_v.x * 1000f),
            y = (short) (_v.y * 1000f),
            z = (short) (_v.z * 1000f)
        };
    }
}