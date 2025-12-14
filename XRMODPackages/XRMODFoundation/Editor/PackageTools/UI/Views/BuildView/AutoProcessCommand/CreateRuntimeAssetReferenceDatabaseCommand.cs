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
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class CreateRuntimeAssetReferenceDatabaseCommand : ProcessHandler
    {
        public override async Task Execute()
        {
            // Auto append RuntimeAssetReferenceDatabase
            var tmp_RuntimeReferenceAssetDbPath = Path.Combine(ProcessShareData.GetInstance.projectPath,
                $"Cache/{nameof(RuntimeAssetReferenceDatabase)}.asset");

            if (!File.Exists(tmp_RuntimeReferenceAssetDbPath))
            {
                var tmp_RuntimeAssetReferenceDatabase =
                    ScriptableObject.CreateInstance<RuntimeAssetReferenceDatabase>();
                AssetDatabase.CreateAsset(tmp_RuntimeAssetReferenceDatabase,
                    Utility.ShortenPath(tmp_RuntimeReferenceAssetDbPath));
            }

            var tmp_RraNameWithoutExtension = Path.GetFileNameWithoutExtension(tmp_RuntimeReferenceAssetDbPath);
            if (ProcessShareData.GetInstance.addressableName.Contains(tmp_RraNameWithoutExtension)) return;
            ProcessShareData.GetInstance.addressableName.Add(
                Path.GetFileNameWithoutExtension(tmp_RuntimeReferenceAssetDbPath));
            ProcessShareData.GetInstance.bundlePath.Add(Utility.ShortenPath(tmp_RuntimeReferenceAssetDbPath));
            await base.Execute();
        }
    }
}