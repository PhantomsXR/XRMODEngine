// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Editor.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Diagnostics.CodeAnalysis;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.UnityFusion.Editor
{
    [InitializeOnLoad]
    internal static class RenameCompnentHeaderHandler
    {
        static RenameCompnentHeaderHandler()
        {
            ComponentHeader.BeforeHeaderGUI -= BeginComponentHeader;
            ComponentHeader.BeforeHeaderGUI += BeginComponentHeader;
        }

        private static void BeginComponentHeader(Component[] _targets, Rect _headerRect, bool _headerIsSelected)
        {
            var tmp_Component = _targets[0];
            var tmp_InspectorTitle = ComponentNameUtils.GetInspectorTitle(tmp_Component); 
            InjectTitleIntoInternalCache(tmp_Component, tmp_InspectorTitle);
        }

        private static void InjectTitleIntoInternalCache([DisallowNull] Component _component, string _title)
        {
            var tmp_ComponentType = _component.GetType();
            ComponentNameUtils.EnsureOriginalInspectorTitleIsCached(_component, tmp_ComponentType);
            ComponentNameUtils.InternalInspectorTitlesCache[tmp_ComponentType] = _title;
        }
    }
}