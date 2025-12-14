using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class CoachingOverlayBlock : AbstractBlock
    {
        private bool coachingOverlayToggle = true;


        public CoachingOverlayBlock(Configures _property) : base(_property)
        {
        }

        public override Rect DrawBlock(Rect _area)
        {
            coachingOverlayToggle =
                EditorGUILayout.BeginFoldoutHeaderGroup(coachingOverlayToggle, "Coaching Overlay Feature", null,
                    ShowHeaderContextMenu);
            var tmp_BlockRect = GUILayoutUtility.GetLastRect();
            if (property.SDKDeviceType == SDKDeviceType.VisionOS)
            {
                EditorGUILayout.HelpBox("This feature is not supported on current platform.", MessageType.Error);
            }
            else if (coachingOverlayToggle)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(15f);
                EditorGUILayout.BeginVertical();
                property.CoachingOverlay =
                    EditorGUILayout.Toggle("Coaching Overlay(iOS Only)", property.CoachingOverlay);
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
            Application.OpenURL($"{CONST_HELP_BASE_URL}features#coaching-overlay-feature");
            return false;
        }

        public override bool OnRemoved()
        {
            property.CoachingOverlay = false;
            return true;
        }
    }
}