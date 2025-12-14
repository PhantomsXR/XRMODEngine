// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODLocalization.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using Phantom.XRMOD.Localization.Runtime;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEditorInternal;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Editor
{
    public class SettingsPopup : PopupWindowContent
    {
        private readonly LocalizatoinSettings localizationSettings;
        private readonly ReorderableList reorderableList;
        private Action onSave;

        public SettingsPopup(LocalizatoinSettings _localizationSettings, Action _onSave)
        {
            localizationSettings = _localizationSettings;
            onSave = _onSave;

            reorderableList =
                new ReorderableList(localizationSettings.SupportLanguages, typeof(SystemLanguage), true, true, true,
                    true)
                {
                    drawHeaderCallback = _rect => { EditorGUI.LabelField(_rect, "Supported Languages"); },
                    drawElementCallback = (_rect, _index, _, _) =>
                    {
                        _rect.y += 2f;
                        localizationSettings.SupportLanguages[_index] = (SystemLanguage) EditorGUI.EnumPopup(
                            new Rect(_rect.x, _rect.y, _rect.width, EditorGUIUtility.singleLineHeight),
                            localizationSettings.SupportLanguages[_index]);
                    },
                    onAddCallback = _list =>
                    {
                        // 默认添加 English，避免重复
                        var tmp_LangToAdd = SystemLanguage.English;
                        int tmp_Idx = 1;
                        while (localizationSettings.SupportLanguages.Contains(tmp_LangToAdd))
                        {
                            tmp_LangToAdd = (SystemLanguage) ((int) SystemLanguage.English + tmp_Idx);
                            tmp_Idx++;
                        }

                        localizationSettings.SupportLanguages.Add(tmp_LangToAdd);
                    },
                    onRemoveCallback = _list =>
                    {
                        if (_list.index >= 0 && _list.index < localizationSettings.SupportLanguages.Count)
                        {
                            localizationSettings.SupportLanguages.RemoveAt(_list.index);
                        }
                    }
                };
        }

        public override Vector2 GetWindowSize() => new Vector2(300, 300);

        public override void OnGUI(Rect _rect)
        {
            EditorGUILayout.LabelField("Settings");
            localizationSettings.LocalizationScope =
                (LocalizationScope) EditorGUILayout.EnumPopup("Scope", localizationSettings.LocalizationScope);
            EditorGUILayout.Space();

            reorderableList.DoLayoutList();

            GUILayout.FlexibleSpace();

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("Cancel"))
            {
                editorWindow.Close();
            }

            if (GUILayout.Button("Save"))
            {
                EditorUtility.SetDirty(localizationSettings);
                LocalizationEditorWindow.NotifyDataChanged();
                onSave?.Invoke();
                editorWindow.Close();
            }

            EditorGUILayout.EndHorizontal();
        }
    }
}
