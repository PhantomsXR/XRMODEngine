using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class MultiplayerBlock : AbstractBlock
    {
       
        private bool foldoutState = true;

        public MultiplayerBlock(Configures _configures) : base(_configures)
        {
        }

        public override Rect DrawBlock(Rect _area)
        {
            foldoutState =
                EditorGUILayout.BeginFoldoutHeaderGroup(foldoutState, "Multiplayer", null,
                    ShowHeaderContextMenu);
            var tmp_BlockRect = GUILayoutUtility.GetLastRect();
            if (foldoutState)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(15f);
                EditorGUILayout.BeginVertical();
                property.Multiplayer =
                    EditorGUILayout.Toggle("Multiplayer", property.Multiplayer);

                // property.DisplayPing =
                //     EditorGUILayout.Toggle("DisplayPing", property.DisplayPing);
                //
                // property.Discovery =
                //     EditorGUILayout.Toggle("Discovery", property.Discovery);
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
            property.Multiplayer = false;
            return true;
        }

        public override bool OpenReference()
        {
            Application.OpenURL($"{CONST_HELP_BASE_URL}features#multiplayer-feature");
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