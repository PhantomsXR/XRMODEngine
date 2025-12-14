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

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class CreateAutomaticGeneratedFolderCommand : ProcessHandler
    {
        public override async Task Execute()
        {
            string tmp_ProjectAutoGenerationPath =
                Path.Combine(ProcessShareData.GetInstance.projectPath, "AutomaticGenerated");
            if (!Directory.Exists(tmp_ProjectAutoGenerationPath))
                Directory.CreateDirectory(tmp_ProjectAutoGenerationPath);
            ProcessShareData.GetInstance.autoGenerationPath = tmp_ProjectAutoGenerationPath;
            await base.Execute();
        }
    }
}