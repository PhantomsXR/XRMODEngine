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
using UnityEngine;

namespace Phantom.XRMOD.RenderAssistant.Editor
{
    public class ShaderVariantData
    {
        public Shader Shader;
        public string[] Keywords;
        public List<string> SourceAssets; // 记录来源(Prefab/Material名)，方便Debug

        public string KeywordString =>
            Keywords == null || Keywords.Length == 0 ? "<No Keywords>" : string.Join(", ", Keywords);

        public ShaderVariantData()
        {
            SourceAssets = new List<string>();
        }
    }
}