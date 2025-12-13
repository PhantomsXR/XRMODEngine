// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Linq;
using Newtonsoft.Json.Linq;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.Runtime.Editor
{
    public static class DataPropertyDrawing
    {
        private static readonly float _LINE_HEIGHT = EditorGUIUtility.singleLineHeight + 2f;

        internal static void Draw(Rect _drawRect, SerializedProperty _serializedProperty)
        {
            _serializedProperty.isExpanded =
                EditorGUI.BeginFoldoutHeaderGroup(_drawRect, _serializedProperty.isExpanded,
                    _serializedProperty.displayName);

            if (_serializedProperty.isExpanded)
            {
                int tmp_Idx = 1;
                if (string.IsNullOrEmpty(_serializedProperty.stringValue))
                {
                    Rect tmp_LabelRect = new Rect(_drawRect.x, _drawRect.y + tmp_Idx * _LINE_HEIGHT,
                        _drawRect.width, EditorGUIUtility.singleLineHeight);
                    EditorGUI.HelpBox(tmp_LabelRect, "Object is null", MessageType.Error);
                }
                else
                {
                    Rect tmp_LabelRect = new Rect(_drawRect.x, _drawRect.y + tmp_Idx * _LINE_HEIGHT,
                        _drawRect.width, EditorGUIUtility.singleLineHeight);
                    _serializedProperty.stringValue =
                        EditorGUI.TextField(tmp_LabelRect, "Value", _serializedProperty.stringValue);
                }
            }

            EditorGUI.EndFoldoutHeaderGroup();
        }

        internal static float GetHeight(SerializedProperty _serializedProperty)
        {
            return (EditorGUI.GetPropertyHeight(_serializedProperty) +
                                EditorGUIUtility.standardVerticalSpacing) * 2;
        }
    }
}