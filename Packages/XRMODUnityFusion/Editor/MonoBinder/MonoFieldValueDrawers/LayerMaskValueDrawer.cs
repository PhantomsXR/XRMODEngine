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

using System.Linq;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace Phantom.XRMOD.Runtime.Editor
{
    public class LayerMaskValueDrawer : IMonoFieldValueDraw
    {
        public bool CanDraw(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.LayerMask;

        public void Draw(SerializedProperty _property, Rect _fieldRect)
        {
            var tmp_LayerMaskProperty = _property.FindPropertyRelative("Value");
            if (!string.IsNullOrEmpty(tmp_LayerMaskProperty.stringValue))
            {
                var tmp_LayerMaskNames = tmp_LayerMaskProperty.stringValue.Split(",");
                tmp_LayerMaskNames = tmp_LayerMaskNames.Where(_e => !string.IsNullOrEmpty(_e)).ToArray(); 
                var tmp_SelectedIdx = EditorGUI.MaskField(_fieldRect, new GUIContent("LayerMask Value"),
                    InternalEditorUtility.LayerMaskToConcatenatedLayersMask(
                        LayerMask.GetMask(tmp_LayerMaskNames)), InternalEditorUtility.layers);
                var tmp_AllLayerOfSelected = Utilities.GetLayerNamesFromMask(tmp_SelectedIdx);
                if (tmp_AllLayerOfSelected.Length != tmp_LayerMaskNames.Length)
                    _property.FindPropertyRelative("Value").stringValue =
                        string.Join(",", tmp_AllLayerOfSelected);
            }
            else
            {
                var tmp_SelectedIdx = EditorGUI.MaskField(_fieldRect, new GUIContent("LayerMask Value"),
                    0, InternalEditorUtility.layers);
                if (tmp_SelectedIdx != 0)
                {
                    var tmp_AllLayerOfSelected = Utilities.GetLayerNamesFromMask(tmp_SelectedIdx);
                    _property.FindPropertyRelative("Value").stringValue =
                        string.Join(",", tmp_AllLayerOfSelected);
                }
            }
        }
    }
}