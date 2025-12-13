using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class VersionBlock : AbstractBlock
    {
        private bool enabledVersionBlock = true;
        private const string enableVersionBlockMsg = "Version Checker";

        public VersionBlock(Configures _property) : base(_property)
        {
        }

        public override Rect DrawBlock(Rect _area)
        {
            enabledVersionBlock = EditorGUILayout.BeginFoldoutHeaderGroup(enabledVersionBlock, enableVersionBlockMsg,
                null,
                ShowHeaderContextMenu);
            var tmp_BlockRect = GUILayoutUtility.GetLastRect();

            if (enabledVersionBlock)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(15f);
                EditorGUILayout.BeginVertical();
                property.Version = EditorGUILayout.TextField(new GUIContent("SDK Version"), property.Version);
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
            property.Version = "0.0.1";
            return false;
        }

        public override bool OpenReference()
        {
            Application.OpenURL($"{CONST_HELP_BASE_URL}version-checker-block");
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