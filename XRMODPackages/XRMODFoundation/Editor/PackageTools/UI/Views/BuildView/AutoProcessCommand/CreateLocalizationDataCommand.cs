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
    public class CreateLocalizationDataCommand : ProcessHandler
    {
        public override async Task Execute()
        {
            // Auto append localizationTable
            var tmp_LocalizationTablePath =
                Path.Combine(ProcessShareData.GetInstance.projectPath, "Artwork/LocalizationTable.csv");
            var tmp_LocalizationTableName = Path.GetFileNameWithoutExtension(tmp_LocalizationTablePath);
            if (File.Exists(tmp_LocalizationTablePath))
            {
                if (!ProcessShareData.GetInstance.addressableName.Contains(tmp_LocalizationTableName))
                {
                    ProcessShareData.GetInstance.addressableName.Add(tmp_LocalizationTableName);
                    ProcessShareData.GetInstance.bundlePath.Add(Utility.ShortenPath(tmp_LocalizationTablePath));
                }
            }

            // Auto append localizationDatabase
            var tmp_LocalizationDatabasePath =
                Path.Combine(ProcessShareData.GetInstance.projectPath, "Artwork/LocalizationDatabase.asset");
            var tmp_DatabaseFileName = Path.GetFileNameWithoutExtension(tmp_LocalizationDatabasePath);
            if (File.Exists(tmp_LocalizationDatabasePath))
            {
                if (ProcessShareData.GetInstance.addressableName.Contains(tmp_DatabaseFileName))
                    return;
                ProcessShareData.GetInstance.addressableName.Add(tmp_DatabaseFileName);
                ProcessShareData.GetInstance.bundlePath.Add(Utility.ShortenPath(tmp_LocalizationDatabasePath));
            }

            await base.Execute();
        }
    }
}