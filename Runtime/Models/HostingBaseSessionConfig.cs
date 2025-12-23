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

using System;
using System.Net;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// Configuration for client-server sessions with direct IP hosting.
    /// </summary>
    public class HostingBaseSessionConfig : BaseSessionConfig
    {
        /// <summary>
        /// Gets or sets the host IP address or hostname.
        /// </summary>
        public string Host { get; set; } = "127.0.0.1";
        
        /// <summary>
        /// Gets or sets the port number for the connection.
        /// </summary>
        public ushort Port { get; set; } = 7777;
        
        /// <summary>
        /// Gets or sets the client-server role type.
        /// </summary>
        public ClientServerTypeEnum ClientServerType { get; set; }
    }

    /// <summary>
    /// Defines the role a participant takes in a client-server session.
    /// </summary>
    public enum ClientServerTypeEnum
    {
        /// <summary>
        /// Acts as both server and client (listen server).
        /// </summary>
        Host,
        
        /// <summary>
        /// Acts as a dedicated server only.
        /// </summary>
        Server,
        
        /// <summary>
        /// Acts as a client connecting to a server.
        /// </summary>
        Client
    }
}