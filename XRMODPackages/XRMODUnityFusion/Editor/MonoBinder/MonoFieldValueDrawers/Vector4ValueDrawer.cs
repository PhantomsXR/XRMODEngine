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
    public class Vector4ValueDrawer : IMonoFieldValueDraw
    {
        public bool CanDraw(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Vector4;

        public void Draw(SerializedProperty _property, Rect _fieldRect)
        {
            var tmp_Vector4Property = _property.FindPropertyRelative("Value");
            try
            {
                if (string.IsNullOrEmpty(tmp_Vector4Property.stringValue) ||
                    tmp_Vector4Property.stringValue.Split(",").Length != 4)
                {
                    tmp_Vector4Property.stringValue = new Vector4(0, 0, 0).Serializer();
                }

                var tmp_CurVec4 = JsonUtility.FromJson<SerializableVector4>(tmp_Vector4Property.stringValue)
                    .ToVector4();
                tmp_Vector4Property.stringValue =
                    JsonUtility.ToJson(
                        new SerializableVector4(EditorGUI.Vector4Field(_fieldRect, "Vector4", tmp_CurVec4)));
            }
            catch (Exception)
            {
                tmp_Vector4Property.stringValue = new Vector4(0, 0, 0).Serializer();
            }
        }
    }
}