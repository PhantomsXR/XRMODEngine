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
    public class Vector3ValueDrawer : IMonoFieldValueDraw
    {
        public bool CanDraw(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Vector3;

        public void Draw(SerializedProperty _property, Rect _fieldRect)
        {
            var tmp_Vector3Property = _property.FindPropertyRelative("Value");
            try
            {
                if (string.IsNullOrEmpty(tmp_Vector3Property.stringValue) ||
                    tmp_Vector3Property.stringValue.Split(",").Length != 3)
                {
                    tmp_Vector3Property.stringValue = new Vector3(0, 0, 0).Serializer();
                }

                var tmp_CurVec3 = JsonUtility.FromJson<SerializableVector3>(tmp_Vector3Property.stringValue)
                    .ToVector3();
                tmp_Vector3Property.stringValue =
                    JsonUtility.ToJson(
                        new SerializableVector3(EditorGUI.Vector3Field(_fieldRect, "Vector3", tmp_CurVec3)));
            }
            catch (Exception)
            {
                tmp_Vector3Property.stringValue = new Vector3(0, 0, 0).Serializer();
            }
        }
    }
}