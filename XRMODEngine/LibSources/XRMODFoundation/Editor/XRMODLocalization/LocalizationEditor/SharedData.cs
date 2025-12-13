// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODLocalization.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Localization.Runtime;

namespace Phantom.XRMOD.Localization.Editor
{
    public class SharedData
    {
        private static SharedData _INSTANCE;
        internal static SharedData Instance => _INSTANCE ??= new SharedData();

        internal LocalizationDatabase Database;
        internal LocalizationTable Table;
    }
}