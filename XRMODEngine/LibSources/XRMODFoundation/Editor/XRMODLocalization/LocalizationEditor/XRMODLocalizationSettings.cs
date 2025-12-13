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

using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.Localization.Editor
{
    [FilePath("ProjectSettings/XRMODLocalizationSettings.asset", FilePathAttribute.Location.ProjectFolder)]
    public class XRMODLocalizationSettings : ScriptableSingleton<XRMODLocalizationSettings>
    {
        public string APIKey;
    }
}