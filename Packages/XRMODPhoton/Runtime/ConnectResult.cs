// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Threading.Tasks;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public partial class ConnectResult {
        /// <summary>
        /// Is successful
        /// </summary>
        public bool Success;
        /// <summary>
        /// The fail reason code <see cref="ConnectFailReason"/>
        /// </summary>
        public int FailReason;
        /// <summary>
        /// Another custom code that can be filled by out by RealtimeClient.DisconnectCause for example.
        /// </summary>
        public int DisconnectCause;
        /// <summary>
        /// A debug message.
        /// </summary>
        public string DebugMessage;
        /// <summary>
        /// Set to true to disable all error handling by the menu.
        /// </summary>
        public bool CustomResultHandling;
        /// <summary>
        /// An optional task to signal the menu to wait until cleanup operation have completed (e.g. level unloading).
        /// </summary>
        public Task WaitForCleanup;
    }
    
    public partial class ConnectFailReason {
        /// <summary>
        /// No reason code available.
        /// </summary>
        public const int None = 0;
        /// <summary>
        /// User requested cancellation or disconnect.
        /// </summary>
        public const int UserRequest = 1;
        /// <summary>
        /// App or Editor closed
        /// </summary>
        public const int ApplicationQuit = 2;
        /// <summary>
        /// Connection disconnected.
        /// </summary>
        public const int Disconnect = 3;
    }
}