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
using System.Net;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using UnityEngine;
using UnityEngine.Events;

namespace Phantom.XRMOD.NetcodeModule.Runtime.NetworkDiscovery
{
    public class LANNetworkDiscovery : NetworkDiscovery<DiscoveryBroadcastData, DiscoveryResponseData>
    {
 
        NetworkManager networkManager;

        [SerializeField]
        [Tooltip(
            "If true NetworkDiscovery will make the server visible and answer to client broadcasts as soon as netcode starts running as server.")]
        bool startWithServer = false;

        public string ServerName = "EnterName";

        public UnityEvent<IPEndPoint, DiscoveryResponseData> OnServerFound;

        private bool hasStartedWithServer = false;

        public void Awake()
        {
            networkManager = GetComponent<NetworkManager>();
        }

        public void Update()
        {
            if (!startWithServer || hasStartedWithServer != false || IsRunning != false) return;
            if (!networkManager.IsServer) return;
            StartServer();
            hasStartedWithServer = true;
        }

        protected override bool ProcessBroadcast(IPEndPoint _sender, DiscoveryBroadcastData _broadCast,
            out DiscoveryResponseData _response)
        {
            _response = new DiscoveryResponseData()
            {
                ServerName = ServerName,
                Port = ((UnityTransport) networkManager.NetworkConfig.NetworkTransport).ConnectionData.Port,
            };
            return true;
        }

        protected override void ResponseReceived(IPEndPoint _sender, DiscoveryResponseData _response)
        { 
            OnServerFound.Invoke(_sender, _response);
        }
    }
}