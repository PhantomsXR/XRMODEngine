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

namespace Phantom.XRMOD.NetcodeModule.Runtime.TableSystem
{
    /// <summary>
    /// Interface for handling player lifecycle events in a tabletop network environment.
    /// </summary>
    public interface IPlayerConnection
    {
        /// <summary>
        /// Called when a player joins the network.
        /// </summary>
        /// <param name="_playerRef">The unique ID/reference of the joining player.</param>
        void PlayerJoin(ulong _playerRef);

        /// <summary>
        /// Called when a player leaves the network.
        /// </summary>
        /// <param name="_playerRef">The unique ID/reference of the departing player.</param>
        void PlayerLeft(ulong _playerRef);
    }
}