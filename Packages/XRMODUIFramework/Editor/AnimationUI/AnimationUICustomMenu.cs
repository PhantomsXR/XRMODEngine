// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIExtension.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.UIFramework.Runtime;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.UIFramework.Editor
{
    public class AnimationUICustomMenu
    {
        //[MenuItem("GameObject/UI/Create AnimationUI")]
        private static void CreateAnimationUI(MenuCommand _menuCommand)
        {
            GameObject tmp_Selected = Selection.activeGameObject;
            GameObject tmp_CreatedGo = new GameObject("AnimationUI");
            tmp_CreatedGo.AddComponent<AnimationUI>();
            GameObjectUtility.SetParentAndAlign(tmp_CreatedGo, tmp_Selected);
            Undo.RegisterCreatedObjectUndo(tmp_CreatedGo, $"Created +{tmp_CreatedGo.name}");
        }
    }
}