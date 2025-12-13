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

using System;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class CreateARPropertyFileCommand : ProcessHandler
    {
        public override async Task Execute()
        {
            var tmp_AutoGenerationPath = ProcessShareData.GetInstance.autoGenerationPath;
            var tmp_Config = ProcessShareData.GetInstance.projectDetailCacheData.Configures;
            try
            {
                // ReSharper disable once InconsistentNaming
                var tmp_ARPropertyJsonFilePath = Path.Combine(tmp_AutoGenerationPath, "ARProperty.json");
                await File.WriteAllTextAsync(tmp_ARPropertyJsonFilePath, JsonUtility.ToJson(tmp_Config));


                // Auto append needed data
                ProcessShareData.GetInstance.addressableName.Add(
                    Path.GetFileNameWithoutExtension(tmp_ARPropertyJsonFilePath));
                ProcessShareData.GetInstance.bundlePath.Add(Utility.ShortenPath(tmp_ARPropertyJsonFilePath));

                await base.Execute();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }
    }
}