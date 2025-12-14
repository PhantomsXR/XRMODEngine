using Phantom.XRMOD.XRMODPackageTools.Editor;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class EnvironmentProbeBlock : AbstractBlock
    {
        private bool environmentProbeToggle = true;

        public EnvironmentProbeBlock(Configures _property) : base(_property)
        {
        }

        public override Rect DrawBlock(Rect _area)
        {
            environmentProbeToggle =
                EditorGUILayout.BeginFoldoutHeaderGroup(environmentProbeToggle, "Environment Probe", null,
                    ShowHeaderContextMenu);
            var tmp_BlockRect = GUILayoutUtility.GetLastRect();
            if (property.SDKDeviceType == SDKDeviceType.VisionOS)
            {
                EditorGUILayout.HelpBox("This feature is not supported on current platform.", MessageType.Error);
            }
            else if (environmentProbeToggle)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(15f);
                EditorGUILayout.BeginVertical();
                property.EnvironmentProbe =
                    EditorGUILayout.Toggle("Environment Probe(iOS Only)", property.EnvironmentProbe);
                property.AutoPlacementOfEnvironmentProbe =
                    EditorGUILayout.Toggle("Auto Placement Probe(iOS Only)", property.AutoPlacementOfEnvironmentProbe);
                property.UseEnvironmentHDRTexture =
                    EditorGUILayout.Toggle("Use Environment HDR Texture", property.UseEnvironmentHDRTexture);
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
            Application.OpenURL($"{CONST_HELP_BASE_URL}features#environment-probe");
            return false;
        }

        public override bool OnRemoved()
        {
            property.EnvironmentProbe = false;
            property.AutoPlacementOfEnvironmentProbe = false;
            return true;
        }
    }
}