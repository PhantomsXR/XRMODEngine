// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor.Filter
{
    public class GenericesAssetFilter : IFilter<List<ContentModel>>
    {
        public List<ContentModel> Filter(List<ContentModel> _data)
        {
            var tmp_FilteredItems = _data
                .Where(_item => _item.ItemType == ItemType.AssetSection).ToList();

            for (int tmp_Idx = 0; tmp_Idx < tmp_FilteredItems.Count; tmp_Idx++)
            {
                var tmp_AssetObject =
                    AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(tmp_FilteredItems[tmp_Idx].AssetPathInUnity);

                // Process the scene suffix. Because it will be distinguished by the name of the suffix afterwards,
                // if you do not add a suffix, it will be ignored. 
                if (tmp_AssetObject is not SceneAsset _) continue;
                if (!tmp_FilteredItems[tmp_Idx].DisplayName.EndsWith("unity"))
                    tmp_FilteredItems[tmp_Idx].DisplayName = $"{tmp_FilteredItems[tmp_Idx].DisplayName}.unity";
            }


            return tmp_FilteredItems;
        }
    }
}