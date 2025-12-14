// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using Unity.Services.Multiplayer;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    public class BaseSessionConfig
    {
        public string SessionCode { get; set; }
        public NetworkTopologyTypes TopologyTypes { get; set; } = NetworkTopologyTypes.ClientServer;
        public int MaxPlayer { get; set; } = 2;
        public Dictionary<string, SessionProperty> CustomProperties { get; set; } = null;
        public Dictionary<string, PlayerProperty> CustomPlayerProperties { get; set; } = null;
        public bool Private = true;
        public bool Locked = false;
        public bool UseUnityMatchmaking = true;
    }
}