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
    public class HostingBaseSessionConfig : BaseSessionConfig
    {
        public string Host { get; set; } = "127.0.0.1";
        public ushort Port { get; set; } = 7777;
        public ClientServerTypeEnum ClientServerType { get; set; }
    }

    public enum ClientServerTypeEnum
    {
        Host,
        Server,
        Client
    }
}