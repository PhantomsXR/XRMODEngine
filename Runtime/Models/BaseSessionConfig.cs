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
    /// <summary>
    /// Base configuration class for creating or joining multiplayer sessions.
    /// </summary>
    public class BaseSessionConfig
    {
        /// <summary>
        /// Gets or sets the session code (optional password or identifier).
        /// </summary>
        public string SessionCode { get; set; }
        
        /// <summary>
        /// Gets or sets the network topology type.
        /// </summary>
        public NetworkTopologyTypes TopologyTypes { get; set; } = NetworkTopologyTypes.ClientServer;
        
        /// <summary>
        /// Gets or sets the maximum number of players allowed in the session.
        /// </summary>
        public int MaxPlayer { get; set; } = 2;
        
        /// <summary>
        /// Gets or sets custom session properties for filtering and discovery.
        /// </summary>
        public Dictionary<string, SessionProperty> CustomProperties { get; set; } = null;
        
        /// <summary>
        /// Gets or sets custom player properties.
        /// </summary>
        public Dictionary<string, PlayerProperty> CustomPlayerProperties { get; set; } = null;
        
        /// <summary>
        /// Whether the session is private (requires code to join).
        /// </summary>
        public bool Private = true;
        
        /// <summary>
        /// Whether the session is locked (no new players can join).
        /// </summary>
        public bool Locked = false;
        
        /// <summary>
        /// Whether to use Unity's matchmaking service.
        /// </summary>
        public bool UseUnityMatchmaking = true;
    }
}