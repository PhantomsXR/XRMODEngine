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

using Phantom.XRMOD.ActionNotification.Runtime;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// Event arguments for custom network messaging events.
    /// </summary>
    public class OnEventCustomNetworkMessagingEventArgs : OnEventBaseArgs
    {
        /// <summary>
        /// The raw message data sent over the network.
        /// </summary>
        public byte[] MessagingData;
    }
}