// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XR-MOD SDK.
// //
// // The XR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class MediaRecorderBlock : AbstractBlock
    {
        private bool mediaRecorderBlockToggle = true;
       
        public MediaRecorderBlock(Configures _property) : base(_property)
        {
           
        }

        public override Rect DrawBlock(Rect _area)
        {
            mediaRecorderBlockToggle =
                EditorGUILayout.BeginFoldoutHeaderGroup(mediaRecorderBlockToggle, "Media Recorder", null,
                    ShowHeaderContextMenu);
            var tmp_BlockRect = GUILayoutUtility.GetLastRect();
            if (mediaRecorderBlockToggle)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(15f);
                EditorGUILayout.BeginVertical();
                property.MediaResolution =
                    (MediaResolution) EditorGUILayout.EnumPopup("Media Resolution", property.MediaResolution);
                property.UseMediaRecorder =
                    EditorGUILayout.Toggle("Use Media Recorder", property.UseMediaRecorder);
                property.UseMicrophone =
                    EditorGUILayout.Toggle("Use Microphone", property.UseMicrophone);
                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                Utility.DrawHorizontalDivLine();
            }

            EditorGUILayout.EndFoldoutHeaderGroup();
            return tmp_BlockRect;
        }

        void ShowHeaderContextMenu(Rect _position)
        {
            var tmp_Menu = new GenericMenu();
            tmp_Menu.AddItem(new GUIContent("Reset"), false, () => OnRemoved());
            tmp_Menu.AddItem(new GUIContent(CONST_HELP_BUTTON_TITLE), false, () => OpenReference());
            tmp_Menu.DropDown(_position);
        }

        public override bool OpenReference()
        {
            Application.OpenURL($"{CONST_HELP_BASE_URL}features#media-recorder");
            return false;
        }

        public override bool OnRemoved()
        {
            property.UseMicrophone = true;
            property.UseMediaRecorder = false;
            return true;
        }
    }
}