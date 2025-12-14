// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class SpaceTypeBlock : AbstractBlock
    {
        private bool enabledSpaceTypeBlock = true;
        private const string enableSpaceTypeBlockMsg = "Work Space";

        public SpaceTypeBlock(Configures _property) : base(_property)
        {
        }


        public override Rect DrawBlock(Rect _area)
        {
            enabledSpaceTypeBlock = EditorGUILayout.BeginFoldoutHeaderGroup(enabledSpaceTypeBlock,
                enableSpaceTypeBlockMsg,
                null, ShowHeaderContextMenu);
            var tmp_BlockRect = GUILayoutUtility.GetLastRect();
            if (enabledSpaceTypeBlock)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(15f);
                EditorGUILayout.BeginVertical();
                var tmp_IsVisionOSPlatform = property.SDKDeviceType != SDKDeviceType.VisionOS;
                EditorGUI.BeginDisabledGroup(tmp_IsVisionOSPlatform);
                property.SpaceType = (SpaceType) EditorGUILayout.EnumPopup("Space Type", property.SpaceType);
                EditorGUI.EndDisabledGroup();
                if (tmp_IsVisionOSPlatform)
                {
                    property.SpaceType = SpaceType.ExclusiveSpace;
                    EditorGUILayout.HelpBox("This feature is only valid on VisionOS platform.",
                        MessageType.Warning);
                }

                if (property.SpaceType == SpaceType.Metal && property.SDKDeviceType != SDKDeviceType.VisionOS)
                {
                    EditorGUILayout.HelpBox("This feature not supported on this platform.", MessageType.Error);
                }
                else
                {
                    if (property.SDKDeviceType == SDKDeviceType.VisionOS)
                    {
                        if (property.SpaceType is SpaceType.ExclusiveSpace or SpaceType.SharedSpace or SpaceType.Metal)
                        {
                            var tmp_LayerMask = EditorGUILayout.MaskField(
                                new GUIContent("CullingMask"),
                                InternalEditorUtility.LayerMaskToConcatenatedLayersMask(property.CullingMask),
                                InternalEditorUtility.layers);
                            property.CullingMask =
                                InternalEditorUtility.ConcatenatedLayersMaskToLayerMask(tmp_LayerMask);

                            if (property.SpaceType == SpaceType.Metal)
                            {
                                property.Passthrough =
                                    EditorGUILayout.Toggle(new GUIContent("MR Pass through",
                                            "Allows an app to switch at runtime between allowing pass-through and rendering the skybox."),
                                        property.Passthrough);
                            }
                        }

                        if (property.SpaceType == SpaceType.SharedSpace)
                        {
                            property.BoundResizeMode =
                                (BoundResizeMode) EditorGUILayout.EnumPopup("Bound Resize Mode",
                                    property.BoundResizeMode);
                            property.Dimensions =
                                EditorGUILayout.Vector3Field("Dimensions", property.Dimensions);
                            property.Position =
                                EditorGUILayout.Vector3Field("Bound Position", property.Position);
                        }
                    }


                    string tmp_FullSpaceMsg =
                        "Your app will occupy the entire space and other applications will be suspended.";
                    string tmp_ShareSpaceMsg =
                        "Your app will share the entire space with other apps and your input will be limited.";
                    var tmp_HelpMsg = property.SpaceType is SpaceType.ExclusiveSpace or SpaceType.Metal
                        ? tmp_FullSpaceMsg
                        : tmp_ShareSpaceMsg;
                    EditorGUILayout.HelpBox(tmp_HelpMsg, MessageType.Info);
                }

                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                Utility.DrawHorizontalDivLine();
            }

            EditorGUILayout.EndFoldoutHeaderGroup();
            return tmp_BlockRect;
        }

        public override bool OnRemoved()
        {
            property.SpaceType = SpaceType.ExclusiveSpace;
            property.Dimensions = Vector3.one;
            property.CullingMask = 0;
            return false;
        }

        public override bool OpenReference()
        {
            return false;
        }

        void ShowHeaderContextMenu(Rect _position)
        {
            var tmp_Menu = new GenericMenu();
            tmp_Menu.AddItem(new GUIContent("Reset"), false, () => OnRemoved());
            tmp_Menu.AddItem(new GUIContent(CONST_HELP_BUTTON_TITLE), false, () => OpenReference());
            tmp_Menu.DropDown(_position);
        }
    }
}