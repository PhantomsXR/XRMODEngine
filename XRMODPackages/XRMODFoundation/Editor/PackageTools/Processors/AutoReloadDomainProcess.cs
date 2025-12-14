// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.PackageTools.Editor.
// //
// // The ARMOD-DevelopmentKit cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor.Views
{
    public class AutoReloadDomainProcess
    {
        [UnityEditor.Callbacks.DidReloadScripts]
        private static async void OnScriptsReloaded()
        {
            //Wait to refresh Unity Interface
            await Task.Delay(1000);

            if (!Utility.GetProjectScriptAssemblyFullNameLowerCase(out string tmp_AssemblyPathLowerCase)) return;
            if (!Utility.GetProjectScriptAssemblyFullNameNormal(out string tmp_AssemblyPathNormal)) return;
            if (!Utility.GetAutomaticGeneratedPath(out string tmp_Dest)) return;
            if (PackageToolsEditor.ALL_PROJECT_CACHE == null) return;
            var tmp_ProjectData = PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData();
            if (tmp_ProjectData == null || tmp_ProjectData.Project.IsBuilding) return;

            var tmp_EditorDllFolder = $"{Utility.GetScriptAssembliesFolder}/Editor";
            if (!Directory.Exists(tmp_EditorDllFolder))
            {
                Directory.CreateDirectory(tmp_EditorDllFolder);
            }

            var tmp_AssemblyFileName = new DirectoryInfo(tmp_AssemblyPathNormal).Name;
            var tmp_AssemblyDest = $"{tmp_EditorDllFolder}/{tmp_AssemblyFileName}";
            if (File.Exists(tmp_AssemblyPathNormal))
            {
                File.Copy(tmp_AssemblyPathNormal, tmp_AssemblyDest, true);
            }

            var tmp_PdbPath = tmp_AssemblyPathNormal.Replace("dll", "pdb");
            var tmp_PdbFileName = new DirectoryInfo(tmp_PdbPath).Name;
            var tmp_PdbDestPath = $"{tmp_EditorDllFolder}/{tmp_PdbFileName}";
            if (File.Exists(tmp_PdbPath))
            {
                File.Copy(tmp_PdbPath, tmp_PdbDestPath, true);
            }

            var tmp_Result = await EditorNotificationCenter.Center.PostNotificationAsync(
                "PlayModeInjectPostProcessor",
                new BaseNotificationData());

            if (tmp_Result?.FirstOrDefault() is not bool tmp_Bool) return;
            if (!tmp_Bool) return;

            Utility.CopyFileToProject(tmp_AssemblyDest, tmp_Dest, "bytes");
            Utility.CopyFileToProject(tmp_PdbDestPath, tmp_Dest, "bytes");
        }
    }
}