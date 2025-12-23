// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODInput.Runtime.
// //
// // The UnityXR-MODLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if USE_XRI

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// Specifies the handedness and device type for an interactor.
    /// </summary>
    public enum InteractorHandness
    {
        /// <summary>
        /// Left-hand XR controller.
        /// </summary>
        LeftController,
        /// <summary>
        /// Right-hand XR controller.
        /// </summary>
        RightController,
        /// <summary>
        /// Left hand (tracking).
        /// </summary>
        LeftHand,
        /// <summary>
        /// Right hand (tracking).
        /// </summary>
        RightHand,
    }
}
#endif