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

using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.Runtime.Editor
{
    public class ColorValueDrawer : IMonoFieldValueDraw
    {
        public bool CanDraw(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Color;

        public void Draw(SerializedProperty _property, Rect _fieldRect)
        {
            var tmp_ColorProperty = _property.FindPropertyRelative("Value");
            if (ColorUtility.TryParseHtmlString($"#{tmp_ColorProperty.stringValue}", out var tmp_Color))
            {
                var tmp_CachedColor = EditorGUI.ColorField(_fieldRect, tmp_Color);
                tmp_ColorProperty.stringValue = ColorUtility.ToHtmlStringRGBA(tmp_CachedColor);
            }
            else
            {
                EditorGUI.PropertyField(_fieldRect, tmp_ColorProperty, new GUIContent("Color Value"));
            }
        }
    }
}