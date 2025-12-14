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
    public class AnimationCurveArrayValueDrawer : IMonoFieldValueDraw
    {
        public bool CanDraw(MonoField.FieldTypeEnum _fieldType) =>
            _fieldType == MonoField.FieldTypeEnum.AnimationCurveArray;

        public void Draw(SerializedProperty _property, Rect _fieldRect)
        {
            var tmp_AnimationCurvesProperty =
                _property.FindPropertyRelative(nameof(MonoField.FieldTypeEnum.AnimationCurveArray));
            DrawerUtils.MakeSureUnityObjectField(_fieldRect, ref tmp_AnimationCurvesProperty);
        }
    }
}