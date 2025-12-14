using System;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class AlgorithmBlock : AbstractBlock
    {
        private readonly Configures property;
        private bool enabledArAlgorithm = true;
        private string enableARAlgorithmMsg = "XR Algorithm";
        private SDKDeviceType sdkDeviceType;

        public AlgorithmBlock(Configures _property) : base(_property)
        {
            property = _property;
        }

        public override Rect DrawBlock(Rect _area)
        {
            enabledArAlgorithm = EditorGUILayout.BeginFoldoutHeaderGroup(enabledArAlgorithm, enableARAlgorithmMsg, null,
                ShowHeaderContextMenu);
            var tmp_HeaderRect = GUILayoutUtility.GetLastRect();

            if (enabledArAlgorithm)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(15f);
                EditorGUILayout.BeginVertical();
                property.SDKDeviceType =
                    (SDKDeviceType) EditorGUILayout.EnumPopup("Device Type", property.SDKDeviceType);

                if (sdkDeviceType != property.SDKDeviceType)
                {
                    sdkDeviceType = property.SDKDeviceType;
                    GenericMenuItemCommandData tmp_Data = new GenericMenuItemCommandData()
                    {
                        CommandId = nameof(RefreshCommand),
                        AllProjectsCache = PackageToolsEditor.ALL_PROJECT_CACHE,
                    };
                    CommandFactory.CreateAndExecuteCommand(tmp_Data);
                }

                if (property.SDKDeviceType == SDKDeviceType.HandheldAR
                    || property.SDKDeviceType == SDKDeviceType.VisionOS
                    || property.SDKDeviceType == SDKDeviceType.Rokid)
                {
#if HANDHELD_ARMODULE_INSTALL || VISIONOS_INSTALL || ROKID_INSTALL
                    property.Algorithm =
                        (AlgorithmType) EditorGUILayout.EnumPopup("XR Algorithm", property.Algorithm);
                    switch (property.Algorithm)
                    {
                        case AlgorithmType.ImageTracker:
                            property.MaxMovingOfTracking =
                                EditorGUILayout.IntField(
                                    new GUIContent("Max Moving Of Tracking",
                                        "You can specify the number of moving images to track simultaneously. "),
                                    property.MaxMovingOfTracking);
                            break;
#if HANDHELD_ARMODULE_INSTALL
                        case AlgorithmType.FocusSlam:
#endif
                        case AlgorithmType.Anchor:
                            property.PlaneDetectionMode =
                                (PlaneDetectionMode) EditorGUILayout.EnumFlagsField("Plane Detection Mode",
                                    property.PlaneDetectionMode);
                            break;
                    }

                    if (property.SDKDeviceType== SDKDeviceType.VisionOS && property.Algorithm != AlgorithmType.None &&
                        property.SpaceType != SpaceType.ExclusiveSpace)
                    {
                        EditorGUILayout.HelpBox("This algorithm only work in Exclusive space mode.",
                            MessageType.Error);
                    }
#endif
                }
                else if (property.SDKDeviceType == SDKDeviceType.Pico)
                {
                    property.MixedReality = EditorGUILayout.Toggle("Mixed Reality", property.MixedReality);
                }
                else if (property.SDKDeviceType == SDKDeviceType.XReal)
                {
#if XREAL_INSTALL
                    property.Algorithm =
                        (AlgorithmType) EditorGUILayout.EnumPopup("XR Algorithm", property.Algorithm);
                    switch (property.Algorithm)
                    {
                        case AlgorithmType.ImageTracker:
                            property.MaxMovingOfTracking =
                                EditorGUILayout.IntField(
                                    new GUIContent("Max Moving Of Tracking",
                                        "You can specify the number of moving images to track simultaneously. "),
                                    property.MaxMovingOfTracking);
                            break;
                        case AlgorithmType.FocusSlam:
                        case AlgorithmType.Anchor:
                            property.PlaneDetectionMode =
                                (PlaneDetectionMode) EditorGUILayout.EnumFlagsField("Plane Detection Mode",
                                    property.PlaneDetectionMode);
                            break;
#if HANDHELD_ARMODULE_INSTALL
                        case AlgorithmType.FaceMesh:
                            EditorGUILayout.HelpBox("Not support this feature on XReal platform", MessageType.Error);
                            break;
#endif
                    }
#endif
                }
                else if (property.SDKDeviceType == SDKDeviceType.Quest)
                {
#if QUEST_INSTALL
                    property.Algorithm =
                        (AlgorithmType) EditorGUILayout.EnumPopup("XR Algorithm", property.Algorithm);
                    property.MixedReality = EditorGUILayout.Toggle("Mixed Reality", property.MixedReality);
                    switch (property.Algorithm)
                    {
                        case AlgorithmType.Meshing:
                            property.MaxMovingOfTracking =
                                EditorGUILayout.IntField(
                                    new GUIContent("Max Moving Of Tracking",
                                        "You can specify the number of moving images to track simultaneously. "),
                                    property.MaxMovingOfTracking);
                            break;
                        case AlgorithmType.Anchor:
                            property.PlaneDetectionMode =
                                (PlaneDetectionMode) EditorGUILayout.EnumFlagsField("Plane Detection Mode",
                                    property.PlaneDetectionMode);
                            break;
                    }
#endif
                }

                property.AlgorithmAutoStart =
                    EditorGUILayout.Toggle(new GUIContent("Algorithm Auto Start",
                            "Toggling this on/off will enable/disable the automatic startup of algorithm at runtime"),
                        property.AlgorithmAutoStart);
                if (!property.AlgorithmAutoStart)
                    EditorGUILayout.HelpBox(
                        "If `algorithm auto start` is disabled, you need to start it manually by script.",
                        MessageType.Warning);

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
            property.PlaneDetectionMode = PlaneDetectionMode.None;
            property.Algorithm = AlgorithmType.None;
            return false;
        }

        public override bool OpenReference()
        {
            Application.OpenURL($"{CONST_HELP_BASE_URL}ar-algorithm-block#ar-algorithm");
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