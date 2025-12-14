using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class XRWorldScaleBlock : AbstractBlock
    {
        private bool enabledArAlgorithm = true;
        private const string enableARAlgorithmMsg = "XR World Scale";

        public override Rect DrawBlock(Rect _area)
        {
            enabledArAlgorithm = EditorGUILayout.BeginFoldoutHeaderGroup(enabledArAlgorithm, enableARAlgorithmMsg, null,
                ShowHeaderContextMenu);
            var tmp_BlockRect = GUILayoutUtility.GetLastRect();
            if (property.SDKDeviceType == SDKDeviceType.VisionOS)
            {
                EditorGUILayout.HelpBox("This feature is not supported on current platform.", MessageType.Error);
            }
            else if (enabledArAlgorithm)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(15f);
                var tmp_IsHandheldARPlatform = property.SDKDeviceType != SDKDeviceType.HandheldAR;
                EditorGUILayout.BeginVertical();
                EditorGUI.BeginDisabledGroup(tmp_IsHandheldARPlatform);
                property.ARWorldScale =
                    EditorGUILayout.FloatField(new GUIContent("XR World Scale"), property.ARWorldScale);
                EditorGUI.EndDisabledGroup();

                if (tmp_IsHandheldARPlatform)
                {
                    property.ARWorldScale = 1;
                    EditorGUILayout.HelpBox("This property is only valid on handheld AR platform.",
                        MessageType.Warning);
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
            property.ARWorldScale = 1f;
            return false;
        }

        public override bool OpenReference()
        {
            Application.OpenURL($"{CONST_HELP_BASE_URL}/features#arworld-scale-block");
            return false;
        }

        void ShowHeaderContextMenu(Rect _position)
        {
            var tmp_Menu = new GenericMenu();
            tmp_Menu.AddItem(new GUIContent("Reset"), false, () => OnRemoved());
            tmp_Menu.AddItem(new GUIContent(CONST_HELP_BUTTON_TITLE), false, () => OpenReference());
            tmp_Menu.DropDown(_position);
        }

        public XRWorldScaleBlock(Configures _property) : base(_property)
        {
        }
    }
}