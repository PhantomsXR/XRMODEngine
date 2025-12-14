// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class MeshVisualizerBlock:AbstractBlock
    {
        private readonly Configures property;
        private bool meshVisualizerToggle = true;
        private string enabledCustomMeshVisualizer = "Custom Mesh Visualizer";
        private const string CONST_DEFAULT_MESH_VISUALIZER = "DefaultMeshVisualizer";
        
        public MeshVisualizerBlock(Configures _property) : base(_property)
        {
            property = _property;
            property.CustomMeshVisualizerName = CONST_DEFAULT_MESH_VISUALIZER;
        }

        public override Rect DrawBlock(Rect _area)
        {
            meshVisualizerToggle =
                EditorGUILayout.BeginFoldoutHeaderGroup(meshVisualizerToggle, enabledCustomMeshVisualizer, null,
                    ShowHeaderContextMenu);
            var tmp_BlockRect = GUILayoutUtility.GetLastRect();
            if (meshVisualizerToggle)
            {
                
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(15f);
                EditorGUILayout.BeginVertical();
                property.CustomMeshVisualizerName =
                    EditorGUILayout.TextField(new GUIContent("Visualizer Name"),
                        property.CustomMeshVisualizerName);
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
            property.CustomMeshVisualizerName = null;
            return true;
        }

        private bool SetToDefault()
        {
            property.CustomMeshVisualizerName = CONST_DEFAULT_MESH_VISUALIZER;
            return true;
        }
        
        public override bool OpenReference()
        {
            Application.OpenURL($"{CONST_HELP_BASE_URL}visualizer#custom-mesh-visualizer");
            return false;
        }
        
        void ShowHeaderContextMenu(Rect _position)
        {
            var tmp_Menu = new GenericMenu();
            tmp_Menu.AddItem(new GUIContent("Default"), false, () => SetToDefault());
            tmp_Menu.AddItem(new GUIContent("Reset"), false, () => OnRemoved());
            tmp_Menu.AddItem(new GUIContent(CONST_HELP_BUTTON_TITLE), false, () => OpenReference());
            tmp_Menu.DropDown(_position);
        }
    }
}