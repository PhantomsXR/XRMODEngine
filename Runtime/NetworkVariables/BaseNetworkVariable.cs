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

using Unity.Netcode;
using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    [RequireComponent(typeof(XRMODNetworkBehaviour))]
    public abstract class BaseNetworkVariable : NetworkBehaviour
    {
        public NetworkVariableWritePermission WritePermission = NetworkVariableWritePermission.Server;
        public NetworkVariableReadPermission ReadPermission = NetworkVariableReadPermission.Everyone;
        public bool UseChangeEvent;
        public string Key;
    }
}