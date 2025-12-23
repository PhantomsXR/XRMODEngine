// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The VisionOSPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using UnityEngine;

namespace Phantom.XRMOD.XRMODAvatar.Runtime.XR
{
#if USE_XR_HAND 
    /// <summary>
    /// Configuration options for different hand fidelity levels.
    /// </summary>
    [System.Serializable]
    public struct HandFidelityOption
    {
        /// <summary>
        /// Array of finger joint configurations for this fidelity level.
        /// </summary>
        public FingerJoints[] FingerJoints;
    }

    [System.Serializable]
    public struct FingerJoints
    {
        public string FingerName;
        [Range(0.0f, 1.0f)] public float CurlAmount;
        public List<UnityEngine.XR.Hands.JointToTransformReference> JointTransformReferences;
    }
#endif
}