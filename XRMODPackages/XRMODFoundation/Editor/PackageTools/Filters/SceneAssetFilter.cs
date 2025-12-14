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
using UnityEditor;

namespace Phantom.XRMOD.XRMODPackageTools.Editor.Filter
{
    public class SceneAssetFilter : IFilter<List<ContentModel>>
    {
        public List<ContentModel> Filter(List<ContentModel> _data)
        {
            List<ContentModel> tmp_Data = new List<ContentModel>();
            foreach (var tmp_AssetContentModel in _data)
            {
                var tmp_AssetObject =
                    AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(tmp_AssetContentModel.AssetPathInUnity);
                if (tmp_AssetObject is SceneAsset _)
                {
                    tmp_Data.Add(tmp_AssetContentModel);
                }
            }

            return tmp_Data;
        }
    }
}