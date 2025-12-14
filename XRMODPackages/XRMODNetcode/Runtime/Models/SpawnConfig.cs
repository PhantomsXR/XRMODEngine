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
using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    [System.Serializable]
    public class SpawnConfig
    {
        public ulong ClientId;
        public GameObject PlayerPrefab;
        public Vector3 Position;
        public Quaternion Rotation;
        public Transform Parent = null;
        public bool DestroyWithScene = false;
        public Action<GameObject> OnBeforeSpawned = null;
    }
}