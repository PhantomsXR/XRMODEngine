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
using UnityEditor;
using UnityEditor.Callbacks; 

namespace Phantom.XRMOD.Localization.Editor
{
    public class LocalizationAssetOpener : AssetPostprocessor
    {
        [OnOpenAsset(0)]
        static bool OnOpenAsset(int _instanceID, int _line)
        {
            var tmp_Obj = EditorUtility.InstanceIDToObject(_instanceID);
            if (tmp_Obj is LocalizationDatabase tmp_DB)
            {
                LocalizationEditorWindow.OpenWithDatabase(tmp_DB);
                return true;
            }

            return false;
        }
    }
}