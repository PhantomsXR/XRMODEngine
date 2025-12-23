// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODUtilites.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// Specifies the type of input modality being used.
    /// </summary>
    public enum InputType : uint
    {
        /// <summary>
        /// Natural hand tracking.
        /// </summary>
        NatureHands = 0,
        /// <summary>
        /// Standard keyboard and mouse input.
        /// </summary>
        KeyboardNMouse = 1,
        /// <summary>
        /// Standard gamepad controller.
        /// </summary>
        GamePad = 2,
        /// <summary>
        /// Specialized XR controllers (e.g., Quest or Vive controllers).
        /// </summary>
        XRController = 3,
#if HANDHELD_AR_INSTALL || ROKID_INSTALL || CLASSIC_3D_INSTALL || WEB_AR_INSTALL || WEB_VR_INSTALL
        /// <summary>
        /// Mobile touchscreen input.
        /// </summary>
        TouchScreen = 4,
#endif
#if ROKID_INSTALL || XREAL_INSTALL
        /// <summary>
        /// 3-degrees-of-freedom ray interactor (common in some AR glasses).
        /// </summary>
        ThreeDofRay = 5,
#endif
        /// <summary>
        /// An unknown or unspecified input type.
        /// </summary>
        Unknown = 6,
    }
}