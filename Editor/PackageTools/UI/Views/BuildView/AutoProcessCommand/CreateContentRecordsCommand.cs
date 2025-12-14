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

using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Phantom.XRMOD.XRMODPackageTools.Editor.Filter;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class CreateContentRecordsCommand : ProcessHandler
    {
        public override async Task Execute()
        {
            var tmp_AllAssets = new List<ContentModel>();
            if (ProcessShareData.GetInstance.projectDetailCacheData.Groups != null)
            {
                foreach (var group in ProcessShareData.GetInstance.projectDetailCacheData.Groups)
                {
                    tmp_AllAssets.AddRange(group.Assets);
                }
            }

            var tmp_GenericesFilter = new GenericesAssetFilter();
            var tmp_GenericesData =
                tmp_GenericesFilter.Filter(tmp_AllAssets);
 
            foreach (var tmp_ContentData in tmp_GenericesData)
            {
                if (string.IsNullOrEmpty(tmp_ContentData.AssetPathInUnity))
                {
                    Debug.LogError(
                        $"Missing the asset with {tmp_ContentData.DisplayName} at {tmp_ContentData.AssetPathInUnity}");
                    continue;
                }

                if (string.IsNullOrEmpty(tmp_ContentData.DisplayName)) continue;

                ProcessShareData.GetInstance.addressableName.Add(Path.GetFileName(tmp_ContentData.DisplayName));
                ProcessShareData.GetInstance.bundlePath.Add(tmp_ContentData.AssetPathInUnity);
            }

            await base.Execute();
        }
    }
}