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

using UnityEditor;
using UnityEngine;
using static Phantom.XRMOD.UnityFusion.Editor.Shared.InspectorContents;

namespace Phantom.XRMOD.UnityFusion.Editor
{
    [InitializeOnLoad]
    public static class InspectorComponentHeaderWrapper
    {
        static InspectorComponentHeaderWrapper()
        {
            UnityEditor.Editor.finishedDefaultHeaderGUI -= DrawInspectorHeaderGUI;
            UnityEditor.Editor.finishedDefaultHeaderGUI += DrawInspectorHeaderGUI;
        }

        private static void DrawInspectorHeaderGUI(UnityEditor.Editor _rootEditor)
        {
            foreach (var (tmp_ComponentEditor, tmp_ComponentHeader) in GetAllComponentHeaderElements(_rootEditor))
            {
                if (IsMissingComponent(tmp_ComponentEditor))
                {
                    continue;
                }

                if (ComponentHeaderWrapper.IsWrapped(tmp_ComponentHeader))
                {
                    continue;
                }

                _rootEditor.Repaint();

                if (Event.current.type != EventType.Repaint)
                {
                    return;
                }

                ComponentHeaderWrapper.Wrap(tmp_ComponentEditor, tmp_ComponentHeader);
            }
        }

        static bool IsMissingComponent(UnityEditor.Editor _componentEditor) =>
            !_componentEditor.target || _componentEditor.target.GetType() == typeof(MonoBehaviour);
    }
}