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
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class CreateScriptCommand : ProcessHandler
    {
        public override async Task Execute()
        {
            var tmp_AutoGenerationPath = ProcessShareData.GetInstance.autoGenerationPath;
            var tmp_Config = ProcessShareData.GetInstance.projectDetailCacheData.Configures;
            var tmp_ProjectName = ProcessShareData.GetInstance.projectName;
            if (tmp_Config.ProgrammableType != ProgrammableType.CSharp) return;
            var tmp_SourceFilePath = Path.Combine(Utility.GetScriptAssembliesFolder,
                $"Runtime/InjectWorkSpace/{tmp_ProjectName}");

            string tmp_DllAssetPath =
                Utility.CopyFileToProject($"{tmp_SourceFilePath}.Runtime.dll", tmp_AutoGenerationPath, "bytes");
            string tmp_PdbAssetPath =
                Utility.CopyFileToProject($"{tmp_SourceFilePath}.Runtime.pdb", tmp_AutoGenerationPath, "bytes");

            //Not allowed to be empty
            if (string.IsNullOrEmpty(tmp_DllAssetPath) || string.IsNullOrEmpty(tmp_PdbAssetPath))
                return;

            var tmp_RenameDllFileToLower = Path.GetFileName(tmp_DllAssetPath).Replace(".bytes", "").ToLower();
            var tmp_RenamePdbFileToLower = Path.GetFileName(tmp_PdbAssetPath).Replace(".bytes", "").ToLower();
            ProcessShareData.GetInstance.addressableName.Add(tmp_RenameDllFileToLower);
            ProcessShareData.GetInstance.addressableName.Add(tmp_RenamePdbFileToLower);
            ProcessShareData.GetInstance.bundlePath.Add(tmp_DllAssetPath);
            ProcessShareData.GetInstance.bundlePath.Add(tmp_PdbAssetPath); 
            await base.Execute();
        }
    }
}