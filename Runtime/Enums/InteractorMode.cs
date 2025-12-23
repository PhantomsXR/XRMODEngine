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
    /// Specifies the interaction range mode.
    /// </summary>
    public enum InteractorMode
    {
        /// <summary>
        /// Distant interaction (e.g., ray casting).
        /// </summary>
        Far,
        /// <summary>
        /// Close-range interaction (e.g., direct touch).
        /// </summary>
        Near,
        /// <summary>
        /// Both far and near interaction modes.
        /// </summary>
        Both,
    }
}
#endif