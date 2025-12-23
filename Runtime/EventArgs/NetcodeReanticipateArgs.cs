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

using Phantom.XRMOD.ActionNotification.Runtime;
using Unity.Netcode;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// Event arguments for network reanticipation events.
    /// </summary>
    public class NetcodeReanticipateArgs : BaseNotificationData
    {
        /// <summary>
        /// The last measured round-trip time to the server.
        /// </summary>
        public double Lastroundtriptime;
    }


    /// <summary>
    /// Event arguments for when a netcode client starts.
    /// </summary>
    public class NetcodeClientStartedArgs : BaseNotificationData
    {
    }


    /// <summary>
    /// Event arguments for when a netcode client stops.
    /// </summary>
    public class NetcodeClientStoppedArgs : BaseNotificationData
    {
        /// <summary>
        /// Whether the client has stopped.
        /// </summary>
        public bool Stoped;
    }


    /// <summary>
    /// Event arguments for network connection events (client connect/disconnect).
    /// </summary>
    public class NetcodeConnectionEventArgs : BaseNotificationData
    {
        /// <summary>
        /// The NetworkManager instance associated with the connection event.
        /// </summary>
        public NetworkManager NetworkManager;
        
        /// <summary>
        /// Data describing the connection event.
        /// </summary>
        public ConnectionEventData ConnectionEventData;
    }


    /// <summary>
    /// Event arguments for when a netcode server starts.
    /// </summary>
    public class NetcodeServerStartedEventArgs : BaseNotificationData
    {
    }


    /// <summary>
    /// Event arguments for when a netcode server stops.
    /// </summary>
    public class NetcodeServerStoppedEventArgs : BaseNotificationData
    {
        /// <summary>
        /// Whether the server has stopped.
        /// </summary>
        public bool Stoped;
    }


    /// <summary>
    /// Event arguments for transport layer failures.
    /// </summary>
    public class NetcodeTransportFailureEventArgs : BaseNotificationData
    {
    }

    /// <summary>
    /// Event arguments for client connection callbacks.
    /// </summary>
    public class NetcodeClientConnectedCallbackEventArgs : BaseNotificationData
    {
        /// <summary>
        /// The ID of the connected user.
        /// </summary>
        public ulong UserId;
    }

    /// <summary>
    /// Event arguments for client disconnection callbacks.
    /// </summary>
    public class NetcodeClientDisconnectCallbackEventArgs : BaseNotificationData
    {
        /// <summary>
        /// The ID of the disconnected user.
        /// </summary>
        public ulong UserId;
    }

    /// <summary>
    /// Event arguments for session owner promotion events.
    /// </summary>
    public class NetcodeSessionOwnerPromotedEventArgs : BaseNotificationData
    {
        /// <summary>
        /// The ID of the newly promoted session owner.
        /// </summary>
        public ulong Sessionownerpromoted;
    }

    /// <summary>
    /// Event arguments for connection approval events.
    /// </summary>
    public class NetcodeApprovalEventArgs : BaseNotificationData
    {
        /// <summary>
        /// The connection approval request from the client.
        /// </summary>
        public NetworkManager.ConnectionApprovalRequest  ApprovalRequest;
        
        /// <summary>
        /// The connection approval response from the server.
        /// </summary>
        public NetworkManager.ConnectionApprovalResponse  ApprovalResponse;
    }
}