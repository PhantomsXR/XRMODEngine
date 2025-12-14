// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODLocalization.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/


using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using SettingsProvider = UnityEditor.SettingsProvider;

namespace Phantom.XRMOD.Localization.Editor
{
    public class XRMODLocalizationSettingsProvider : SettingsProvider
    {
        XRMODLocalizationSettings settings;
        private bool showAPIKey;
        GUIContent showIcon = EditorGUIUtility.IconContent("d_VisibilityOff", "Show Password");
        GUIContent hideIcon = EditorGUIUtility.IconContent("d_VisibilityOn", "Hide Password");

        public XRMODLocalizationSettingsProvider(string _path, SettingsScope _scopes = SettingsScope.User) : base(_path,
            _scopes)
        {
            settings = XRMODLocalizationSettings.instance;
        }


        [SettingsProvider]
        public static SettingsProvider CreateSettingsProvider()
        {
            return new XRMODLocalizationSettingsProvider("Project/PhantomsXR/XRMOD Localization", SettingsScope.Project);
        }

        public override void OnGUI(string _searchContext)
        {
            if (settings == null)
            {
                EditorGUILayout.HelpBox("Settings not initialized.", MessageType.Error);
                return;
            }

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel("API Key:");
            settings.APIKey = showAPIKey
                ? EditorGUILayout.TextField(settings.APIKey)
                : EditorGUILayout.PasswordField(settings.APIKey);

            if (GUILayout.Button(showAPIKey ? hideIcon : showIcon, GUILayout.Width(30)))
            {
                showAPIKey = !showAPIKey;
            }

            EditorGUILayout.EndHorizontal();
        }
    }
}