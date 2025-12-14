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
    public class NetcodeReanticipateArgs : BaseNotificationData
    {
        public double Lastroundtriptime;
    }


    public class NetcodeClientStartedArgs : BaseNotificationData
    {
    }


    public class NetcodeClientStoppedArgs : BaseNotificationData
    {
        public bool Stoped;
    }


    public class NetcodeConnectionEventArgs : BaseNotificationData
    {
        public NetworkManager NetworkManager;
        public ConnectionEventData ConnectionEventData;
    }


    public class NetcodeServerStartedEventArgs : BaseNotificationData
    {
    }


    public class NetcodeServerStoppedEventArgs : BaseNotificationData
    {
        public bool Stoped;
    }


    public class NetcodeTransportFailureEventArgs : BaseNotificationData
    {
    }

    public class NetcodeClientConnectedCallbackEventArgs : BaseNotificationData
    {
        public ulong UserId;
    }

    public class NetcodeClientDisconnectCallbackEventArgs : BaseNotificationData
    {
        public ulong UserId;
    }

    public class NetcodeSessionOwnerPromotedEventArgs : BaseNotificationData
    {
        public ulong Sessionownerpromoted;
    }

    public class NetcodeApprovalEventArgs : BaseNotificationData
    {
        public NetworkManager.ConnectionApprovalRequest  ApprovalRequest;
        public NetworkManager.ConnectionApprovalResponse  ApprovalResponse;
    }
}