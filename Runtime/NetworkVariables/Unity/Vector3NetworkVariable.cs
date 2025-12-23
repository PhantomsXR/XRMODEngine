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

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// A MonoBehaviour-based network variable for synchronizing Vector3 values.
    /// </summary>
    /// <remarks>
    /// This class extends AbstractNetworkVariable to provide Vector3 synchronization across the network.
    /// Useful for synchronizing positions, directions, or any 3D vector data.
    /// Attach this component to a GameObject to expose a synchronized Vector3 value in the Inspector.
    /// </remarks>
    public class Vector3NetworkVariable:AbstractNetworkVariable<UnityEngine.Vector3>
    {
        
    }
}