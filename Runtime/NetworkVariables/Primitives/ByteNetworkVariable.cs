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
    /// A MonoBehaviour-based network variable for synchronizing byte values.
    /// </summary>
    /// <remarks>
    /// Attach this component to a GameObject to expose a synchronized byte value (0-255) in the Inspector.
    /// </remarks>
    public class ByteNetworkVariable : AbstractNetworkVariable<byte>
    {
    }
}