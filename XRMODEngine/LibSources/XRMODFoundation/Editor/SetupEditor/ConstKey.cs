// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Setup.Editor.
// //
// // The XRMODValidationProjects cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Setup.Editor
{
    public class ConstKey
    {
        public const string CONST_PACKAGE_NAME_KEY = "com.phantomsxr.foundation";
        public static readonly string CONST_PACKAGE_PATH = $"Packages/{CONST_PACKAGE_NAME_KEY}";
        public static readonly string CONST_SETTING_CONFIGURE_FILE_PATH = $"Assets/XR/{nameof(XRMODSetupConfigure)}.asset";
    }
}