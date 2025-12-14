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
    public class AnimationCurveValueDrawer : IMonoFieldValueDraw
    {
        public bool CanDraw(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.AnimationCurve;

        public void Draw(SerializedProperty _property,Rect _fieldRect)
        {
            try
            {
                var tmp_AnimationCurveProperty = _property.FindPropertyRelative("Value");

                AnimationCurve tmp_AnimationCurveData =
                    string.IsNullOrEmpty(tmp_AnimationCurveProperty.stringValue)
                        ? new AnimationCurve()
                        : tmp_AnimationCurveProperty.stringValue.DeserializeAnimationCurve();

                tmp_AnimationCurveData = EditorGUI.CurveField(_fieldRect, tmp_AnimationCurveData);
                tmp_AnimationCurveProperty.stringValue = tmp_AnimationCurveData.SerializeAnimationCurve();
            }
            catch (Exception tmp_E)
            {
                Debug.LogError(tmp_E);
            }
        }
    }
}