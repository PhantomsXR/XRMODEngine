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
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.Runtime.Editor
{
    public class Vector2ValueDrawer:IMonoFieldValueDraw
    {
        public bool CanDraw(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Vector2;

        public void Draw(SerializedProperty _property, Rect _fieldRect)
        {
            var tmp_VectorProperty = _property.FindPropertyRelative("Value");
            try
            {
                if (string.IsNullOrEmpty(tmp_VectorProperty.stringValue))
                {
                    tmp_VectorProperty.stringValue = new Vector2(0, 0).Serializer();
                }

                var tmp_CurVec2 = JsonUtility.FromJson<SerializableVector2>(tmp_VectorProperty.stringValue)
                    .ToVector2();
                tmp_VectorProperty.stringValue = JsonUtility.ToJson(
                    new SerializableVector2(EditorGUI.Vector2Field(_fieldRect, "Vector2", tmp_CurVec2)));
            }
            catch (Exception)
            {
                tmp_VectorProperty.stringValue = new Vector2(0, 0).Serializer();
            }

        }
    }
}