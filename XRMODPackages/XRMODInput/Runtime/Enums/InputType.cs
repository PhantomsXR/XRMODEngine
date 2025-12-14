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
    public enum InputType : uint
    {
        NatureHands = 0,
        KeyboardNMouse = 1,
        GamePad = 2,
        XRController = 3,
#if HANDHELD_AR_INSTALL || ROKID_INSTALL || CLASSIC_3D_INSTALL || WEB_AR_INSTALL || WEB_VR_INSTALL
        TouchScreen = 4,
#endif
#if ROKID_INSTALL || XREAL_INSTALL
        ThreeDofRay = 5,
#endif
        Unknown = 6,
    }
}