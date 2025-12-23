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

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// Defines the available network topology types for multiplayer sessions.
    /// </summary>
    public enum NetworkTopologyTypes
    {
        /// <summary>
        /// Traditional client-server architecture with a dedicated server or host.
        /// </summary>
        ClientServer,
        
        /// <summary>
        /// Unity Relay-based peer-to-peer networking.
        /// </summary>
        UnityRelay,
        
        /// <summary>
        /// Distributed authority with no single authoritative server.
        /// </summary>
        DistributedAuthority,
    }
}