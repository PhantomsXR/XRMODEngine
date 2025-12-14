using UnityEditor;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class OcclusionBlock : AbstractBlock
    {
        private bool enabledArAlgorithm = true;
        private string enableARAlgorithmMsg = "Occlusion(Beta)";

        public OcclusionBlock(Configures _property) : base(_property)
        {
        }

        public override Rect DrawBlock(Rect _area)
        {
            enabledArAlgorithm = EditorGUILayout.BeginFoldoutHeaderGroup(enabledArAlgorithm, enableARAlgorithmMsg, null,
                ShowHeaderContextMenu);
            var tmp_HeaderRect = GUILayoutUtility.GetLastRect();
            if (property.SDKDeviceType == SDKDeviceType.VisionOS)
            {
                EditorGUILayout.HelpBox("This feature is not supported on current platform.", MessageType.Error);
            }
            else if (enabledArAlgorithm)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(15f);
                EditorGUILayout.BeginVertical();
                property.AROcclusion = EditorGUILayout.Toggle("Enable AR Occlusion", property.AROcclusion);
                if (property.AROcclusion)
                {
                    property.TemporalSmoothing =
                        EditorGUILayout.Toggle("Temporal Smoothing", property.TemporalSmoothing);

                    property.EnvironmentDepthMode =
                        (EnvironmentDepthMode) EditorGUILayout.EnumPopup(new GUIContent("Environment Depth Mode"),
                            property.EnvironmentDepthMode);

                    property.HumanSegmentationDepthMode =
                        (HumanSegmentationDepthMode) EditorGUILayout.EnumPopup(
                            new GUIContent("Human Segmentation Depth Mode"),
                            property.HumanSegmentationDepthMode);

                    property.HumanSegmentationStencilMode =
                        (HumanSegmentationStencilMode) EditorGUILayout.EnumPopup(
                            new GUIContent("Human Segmentation Stencil Mode"),
                            property.HumanSegmentationStencilMode);

                    property.OcclusionPreferenceMode =
                        (OcclusionPreferenceMode) EditorGUILayout.EnumPopup(new GUIContent("Occlusion Preference Mode"),
                            property.OcclusionPreferenceMode);
                }

                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                Utility.DrawHorizontalDivLine();
            }

            EditorGUILayout.EndFoldoutHeaderGroup();
            return tmp_HeaderRect;
        }

        public override bool OnRemoved()
        {
            return false;
        }

        public override bool OpenReference()
        {
            Application.OpenURL($"{CONST_HELP_BASE_URL}features#occlusionbetan");
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