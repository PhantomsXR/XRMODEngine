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

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.UnityFusion.Editor.Shared
{
    public static class InspectorContents
    {
        private static readonly List<(UnityEditor.Editor, IMGUIContainer)> _HEADERS_LIST = new();

        private static
#if UNITY_2023_3_OR_NEWER // GetPropertyEditors was added in Unity 2023.3.0a4
            readonly IEnumerable<PropertyEditor> _ALL_PROPERTY_EDITORS =
                PropertyEditor.GetPropertyEditors();
#else
		    IEnumerable<PropertyEditor> _ALL_PROPERTY_EDITORS => System.Linq.Enumerable.Where(Resources.FindObjectsOfTypeAll<PropertyEditor>(), e => e);
#endif

        internal static List<(UnityEditor.Editor editor, IMGUIContainer header)> GetAllComponentHeaderElements(
            UnityEditor.Editor _editor)
        {
            _HEADERS_LIST.Clear();
            foreach (var tmp_PropertyEditor in _ALL_PROPERTY_EDITORS)
            {
                if (Array.IndexOf(tmp_PropertyEditor.tracker.activeEditors, _editor) == -1)
                {
                    continue;
                }

                if (TryFindEditorElement(tmp_PropertyEditor.rootVisualElement, _editor, out var tmp_EditorElement)
                    // All EditorElements should be parented under the same editors list element
                    && tmp_EditorElement.parent is { } tmp_EditorsListElement)
                {
                    GetAllComponentHeaderElements(tmp_EditorsListElement, _HEADERS_LIST);
                }
            }

            return _HEADERS_LIST;
        }

        private static void GetAllComponentHeaderElements([DisallowNull] VisualElement _editorsListElement,
            List<(UnityEditor.Editor, IMGUIContainer)> _results)
        {
#if DEV_MODE && DEBUG && !SISUS_DISABLE_PROFILING
			using var x = getAllComponentHeaderElementsMarker.Auto();
#endif

            foreach (var tmp_Child in _editorsListElement.Children())
            {
                if (tmp_Child is not EditorElement tmp_EditorElement)
                {
                    continue;
                }

                var tmp_Editor = tmp_EditorElement.editor;
                if (!tmp_Editor || tmp_Editor.target is not Component)
                {
                    continue;
                }

                foreach (var tmp_EditorElementChild in tmp_EditorElement.Children())
                {
                    if (tmp_EditorElementChild is IMGUIContainer tmp_IMGUIContainer &&
                        tmp_IMGUIContainer.name.EndsWith("Header", StringComparison.Ordinal))
                    {
                        _results.Add((tmp_Editor, tmp_IMGUIContainer));
                    }
                }
            }
        }

        private static bool TryFindEditorElement(VisualElement _rootVisualElement, UnityEditor.Editor _editor,
            [MaybeNullWhen(false), NotNullWhen(true)]
            out EditorElement _editorElement)
        {
            _editorElement = _rootVisualElement?.Query<EditorElement>()
                .Where(_element => _element.editor == _editor)
                .First();

            return _editorElement is not null;
        }
    }
}