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

using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.Runtime.Editor
{
    public static class DrawerUtils
    {
        internal static void MakeSureUnityObjectField(Rect _rect, ref SerializedProperty _unityObjectsProperty)
        {
            EditorGUI.indentLevel = 1;
            EditorGUI.PropertyField(new Rect(_rect.x, _rect.y, _rect.width, EditorGUIUtility.singleLineHeight),
                _unityObjectsProperty);
            EditorGUI.indentLevel = 0;
        }
    }
}