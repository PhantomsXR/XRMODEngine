// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Setup.Editor
{
    public class XRMODEnginePlatformSettings : ScriptableObject
    {
        public GameObject LaunchPrefab;
        public Vector3Int Version = new Vector3Int(2, 0, 0);
        public string[] ScriptingDefineSymbols;
    }
}