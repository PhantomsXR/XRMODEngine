// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.IO;
using System.Threading.Tasks;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class CreateSaveBundleFolderCommand : ProcessHandler
    {
        public override async Task Execute()
        {
            var tmp_SavedBundlePath = Path.Combine(Application.dataPath.Replace("Assets", "ServerData"),
                RuntimePlatformHelper.GetPlatformName().ToLower());

            tmp_SavedBundlePath = Path.Combine(tmp_SavedBundlePath, ProcessShareData.GetInstance.projectName.ToLower());

            if (!Directory.Exists(tmp_SavedBundlePath))
                Directory.CreateDirectory(tmp_SavedBundlePath);
            ProcessShareData.GetInstance.saveBundlePath = tmp_SavedBundlePath;

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            await base.Execute();
        }
    }
}