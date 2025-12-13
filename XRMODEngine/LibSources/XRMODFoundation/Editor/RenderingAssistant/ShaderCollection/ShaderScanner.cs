// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.RenderAssistant.Editor.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.RenderAssistant.Editor
{
    public static class ShaderScanner
    {
        public static List<Material> ScanForMaterials(UnityEngine.Object[] droppedObjects)
        {
            HashSet<Material> uniqueMaterials = new HashSet<Material>();

            foreach (var obj in droppedObjects)
            {
                string path = AssetDatabase.GetAssetPath(obj);

                // 1. 处理文件夹
                if (Directory.Exists(path))
                {
                    string[] guids = AssetDatabase.FindAssets("t:Prefab t:Material", new[] {path});
                    foreach (var guid in guids)
                    {
                        string assetPath = AssetDatabase.GUIDToAssetPath(guid);
                        var asset = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(assetPath);
                        ExtractMaterialsFromObject(asset, uniqueMaterials);
                    }
                }
                // 2. 处理单个资源 (Prefab 或 Material)
                else
                {
                    ExtractMaterialsFromObject(obj, uniqueMaterials);
                }
            }

            return uniqueMaterials.ToList();
        }

        private static void ExtractMaterialsFromObject(UnityEngine.Object obj, HashSet<Material> collected)
        {
            if (obj is Material mat)
            {
                collected.Add(mat);
            }
            else if (obj is GameObject go)
            {
                // 递归获取 Prefab 及其子节点上的所有 Renderer
                var renderers = go.GetComponentsInChildren<Renderer>(true);
                foreach (var r in renderers)
                {
                    foreach (var m in r.sharedMaterials)
                    {
                        if (m != null) collected.Add(m);
                    }
                }

                // 处理 UI Image/RawImage 等
                var graphics = go.GetComponentsInChildren<UnityEngine.UI.Graphic>(true);
                foreach (var g in graphics)
                {
                    if (g.material != null) collected.Add(g.material);
                }
            }
        }

        public static List<ShaderVariantData> ProcessVariants(List<Material> materials)
        {
            // 使用 Dictionary Key 来去重：Shader + Keyword组合
            Dictionary<int, ShaderVariantData> variantMap = new Dictionary<int, ShaderVariantData>();

            foreach (var mat in materials)
            {
                if (mat.shader == null) continue;

                // 获取激活的 Keywords
                string[] keywords = mat.shaderKeywords;

                // 简单的 Hash 算法：ShaderHash ^ KeywordsHash
                int hash = mat.shader.GetHashCode();
                if (keywords != null)
                {
                    foreach (var k in keywords) hash ^= k.GetHashCode();
                }

                if (!variantMap.ContainsKey(hash))
                {
                    variantMap[hash] = new ShaderVariantData
                    {
                        Shader = mat.shader,
                        Keywords = keywords
                    };
                }

                variantMap[hash].SourceAssets.Add(mat.name);
            }

            return variantMap.Values.ToList();
        }
    }
}