// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace Phantom.XRMOD.Runtime.Editor
{
    public class MonoBinderFieldEditor : UnityEditor.Editor
    {
        private Dictionary<int, ReorderableList> fieldsReorderableList = new();

        private readonly Dictionary<MonoField.FieldTypeEnum, IMonoFieldValueDraw> monoFieldValueDraws = new()
        {
            {MonoField.FieldTypeEnum.Number, new NumberValueDrawer()},
            {MonoField.FieldTypeEnum.Bool, new BoolValueDrawer()},
            {MonoField.FieldTypeEnum.String, new StringValueDrawer()},
            {MonoField.FieldTypeEnum.Enum, new EnumValueDrawer()},
            {MonoField.FieldTypeEnum.Vector2, new Vector2ValueDrawer()},
            {MonoField.FieldTypeEnum.Vector2Array, new Vector2ArrayValueDrawer()},
            {MonoField.FieldTypeEnum.Vector3, new Vector3ValueDrawer()},
            {MonoField.FieldTypeEnum.Vector3Array, new Vector3ArrayValueDrawer()},
            {MonoField.FieldTypeEnum.Vector4, new Vector4ValueDrawer()},
            {MonoField.FieldTypeEnum.Vector4Array, new Vector4ArrayValueDrawer()},
            {MonoField.FieldTypeEnum.Quaternion, new QuaternionValueDrawer()},
            {MonoField.FieldTypeEnum.QuaternionArray, new QuaternionArrayValueDrawer()},
            {MonoField.FieldTypeEnum.Color, new ColorValueDrawer()},
            {MonoField.FieldTypeEnum.ColorArray, new ColorArrayValueDrawer()},
            {MonoField.FieldTypeEnum.LayerMask, new LayerMaskValueDrawer()},
            {MonoField.FieldTypeEnum.AssetReference, new AssetReferenceValueDrawer()},
            {MonoField.FieldTypeEnum.AssetReferenceArray, new AssetReferenceArrayDrawer()},
            {MonoField.FieldTypeEnum.AnimationCurve, new AnimationCurveValueDrawer()},
            {MonoField.FieldTypeEnum.AnimationCurveArray, new AnimationCurveArrayValueDrawer()},
            {MonoField.FieldTypeEnum.UnityComponent, new UnityComponentValueDrawer()},
            {MonoField.FieldTypeEnum.Components, new ComponentArrayValueDrawer()},
            {MonoField.FieldTypeEnum.Primitives, new PrimitivesValueDrawer()},
            {MonoField.FieldTypeEnum.GameObject, new GameObjectValueDrawer()},
            {MonoField.FieldTypeEnum.GameObjectArray, new GameObjectArrayValueDrawer()},
            {MonoField.FieldTypeEnum.DataProperty, new DataPropertyValueDrawer()},
            {MonoField.FieldTypeEnum.NotSupported, new NotSupportDrawer()},
            {MonoField.FieldTypeEnum.AudioMixerSnapshot, new AudioMixerSnapshotDrawer()}
        };


        public void EnsureReorderableList(Rect _rect, int _idx, SerializedProperty _fieldsProperty)
        {
            var tmp_FieldsReorderList =
                new ReorderableList(serializedObject, _fieldsProperty, true, true, true, true);
            fieldsReorderableList.TryAdd(_idx, tmp_FieldsReorderList);

            tmp_FieldsReorderList.drawElementCallback += (_rect, _index, _active, _focused) =>
            {
                if (_fieldsProperty.arraySize <= 0) return;

                var tmp_FieldProperty = _fieldsProperty.GetArrayElementAtIndex(_index);
                var tmp_ColRect = new Rect(_rect.x, _rect.y, _rect.width, EditorGUIUtility.singleLineHeight);

                EditorGUI.PropertyField(tmp_ColRect, tmp_FieldProperty.FindPropertyRelative("FieldName"));
                tmp_ColRect.y += Utilities.MakeSureHeight;
                EditorGUI.PropertyField(tmp_ColRect, tmp_FieldProperty.FindPropertyRelative("FieldType"));
                tmp_ColRect.y += Utilities.MakeSureHeight;
                DrawField(tmp_FieldProperty.FindPropertyRelative("FieldType"), tmp_FieldProperty, tmp_ColRect);
            };


            tmp_FieldsReorderList.elementHeightCallback += _index =>
            {
                float tmp_OffsetHeight = 0;
                SerializedProperty tmp_Element = _fieldsProperty.GetArrayElementAtIndex(_index);
                var tmp_EnumIndex =
                    (MonoField.FieldTypeEnum) tmp_Element.FindPropertyRelative("FieldType").enumValueFlag;
                switch (tmp_EnumIndex)
                {
                    case MonoField.FieldTypeEnum.ColorArray:
                    case MonoField.FieldTypeEnum.QuaternionArray:
                    case MonoField.FieldTypeEnum.Vector2Array:
                    case MonoField.FieldTypeEnum.Vector3Array:
                    case MonoField.FieldTypeEnum.Vector4Array:
                    case MonoField.FieldTypeEnum.AnimationCurveArray:
                    case MonoField.FieldTypeEnum.Components:
                    case MonoField.FieldTypeEnum.GameObjectArray:
                        var tmp_ArrayProperty = tmp_Element.FindPropertyRelative($"{tmp_EnumIndex}");
                        if (tmp_ArrayProperty.isExpanded)
                        {
                            tmp_OffsetHeight += EditorGUI.GetPropertyHeight(tmp_ArrayProperty)
                                                + tmp_FieldsReorderList.headerHeight
                                                + tmp_FieldsReorderList.footerHeight;
                        }
                        else
                        {
                            tmp_OffsetHeight = EditorGUI.GetPropertyHeight(tmp_Element) * 3
                                               + EditorGUIUtility.standardVerticalSpacing;
                        }

                        break;

                    default:
                        tmp_OffsetHeight = EditorGUI.GetPropertyHeight(tmp_Element) * 3
                                           + EditorGUIUtility.standardVerticalSpacing;
                        break;
                }

                return tmp_OffsetHeight;
            };

            tmp_FieldsReorderList.onChangedCallback += _list =>
            {
                if (_list.count != 0) return;
                fieldsReorderableList.Clear();
                _list.serializedProperty.ClearArray();
            };

            tmp_FieldsReorderList.onAddCallback += _list =>
            {
                var tmp_SerializedProperty = _list.serializedProperty;
                var tmp_InsertIdx = tmp_SerializedProperty.arraySize;
                tmp_SerializedProperty.InsertArrayElementAtIndex(tmp_InsertIdx);
            };

            tmp_FieldsReorderList.drawHeaderCallback += _rect =>
            {
                EditorGUI.LabelField(_rect, $"Binding Fields(Count:{_fieldsProperty.arraySize})");
            };
        }

        public void DrawLayout(Rect _rect, int _index)
        {
            if (fieldsReorderableList.TryGetValue(_index, out var tmp_FieldsReorderList))
                tmp_FieldsReorderList.DoList(_rect);
        }

        public void RemoveElement(int _index)
        {
            if (fieldsReorderableList.ContainsKey(_index))
            {
                fieldsReorderableList[_index] = null;
                fieldsReorderableList.Remove(_index);
            }
        }

        private void DrawField(SerializedProperty _fieldType, SerializedProperty _property, Rect _fieldRect)
        {
            var tmp_FieldType = (MonoField.FieldTypeEnum) _fieldType.enumValueFlag;
            if (!monoFieldValueDraws.TryGetValue(tmp_FieldType, out var tmp_Draw)) return;
            if (tmp_Draw.CanDraw(tmp_FieldType))
            {
                tmp_Draw.Draw(_property, _fieldRect);
            }
        }
    }
}