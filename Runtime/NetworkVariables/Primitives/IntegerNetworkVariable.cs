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

using Unity.Netcode;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// A MonoBehaviour-based network variable for synchronizing integer values.
    /// </summary>
    /// <remarks>
    /// This class extends AbstractNetworkVariable to provide a simple integer synchronization across the network.
    /// Attach this component to a GameObject to expose a synchronized int value in the Inspector.
    /// </remarks>
    public class IntegerNetworkVariable : AbstractNetworkVariable<int>
    {
    }
}