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
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace Phantom.XRMOD.RenderAssistant.Editor
{
    public static class ShaderCollectionBuilder
    {
        public static void CreateCollection(List<ShaderVariantData> dataList, string savePath)
        {
            ShaderVariantCollection collection = new ShaderVariantCollection();

            foreach (var data in dataList)
            {
                if (data.Shader == null) continue;

                try
                {
                    // 注意：这里默认添加了 ScriptableRenderPipeline 的 PassType。
                    // 实际项目中，ShaderVariantCollection 比较复杂，因为仅仅知道 Keyword 是不够的，
                    // 还需要知道 PassType。但在非运行态下，通常我们收集所有常用 Pass 或者基于 SRP 的 Pass。
                    
                    // 构建变体结构
                    ShaderVariantCollection.ShaderVariant variant = new ShaderVariantCollection.ShaderVariant
                    {
                        shader = data.Shader,
                        keywords = data.Keywords,
                        passType = PassType.ScriptableRenderPipeline // 针对 URP/HDRP
                    };
                    
                    // 如果不是 SRP，可能需要添加 PassType.Normal, PassType.ShadowCaster 等
                    // 为了演示代码简洁，这里演示添加 SRP Pass。
                    // 实际生产级工具通常会把常用 PassType 都尝试添加进去。
                    
                    collection.Add(variant);
                }
                catch (System.Exception e)
                {
                    Debug.LogWarning($"Could not add variant for {data.Shader.name}: {e.Message}");
                }
            }

            AssetDatabase.CreateAsset(collection, savePath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            
            Selection.activeObject = collection;
            Debug.Log($"<color=#44FFAA>Success:</color> Created ShaderVariantCollection at {savePath} with {collection.shaderCount} shaders and {collection.variantCount} variants.");
        }
    }
}