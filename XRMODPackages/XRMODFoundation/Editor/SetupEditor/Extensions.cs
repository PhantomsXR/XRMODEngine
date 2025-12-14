// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineSettings.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Phantom.XRMOD.Core.Runtime; 
using UnityEditor;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime.Enums;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

namespace Phantom.XRMOD.Setup.Editor
{
    public static class Extensions
    {
        public static XRMODEnginePlatformSettings GetPlatformSettings(this XRMODSetupConfigure _settings,
            int _devicesId, string _suffix = "UnityStandalone")
        {
            var tmp_SettingName = $"{(SDKDeviceType) _devicesId}{_suffix}";

            if (_settings == null)
                _settings =
                    AssetDatabase.LoadAssetAtPath<XRMODSetupConfigure>(ConstKey.CONST_SETTING_CONFIGURE_FILE_PATH);
            var tmp_PlatformSettings = _settings.PlatformSettingValue.Find(_platformSettings =>
                _platformSettings.name.Contains(tmp_SettingName));
            return tmp_PlatformSettings;
        }


        public static void DrawPlatformSettings(this XRMODEnginePlatformSettings _platformSettings,
            SerializedObject _serialized)
        {
            EditorGUILayout.Space();
            var tmp_Tooltips =
                "Given a version number MAJOR.MINOR.PATCH, increment the:"
                + "\n1.MAJOR version when you make incompatible API changes,"
                + "\n2.MINOR version when you add functionality in a backwards compatible manner, and"
                + "\n3.PATCH version when you make backwards compatible bug fixes."
                + "\nAdditional labels for pre-release and build metadata are available as extensions to the MAJOR.MINOR.PATCH format.";
            // _platformSettings.Version = EditorGUILayout.TextField("SDK Version", _platformSettings.Version);
            _platformSettings.Version = EditorGUILayout.Vector3IntField(new GUIContent("SDK Version", tmp_Tooltips),
                _platformSettings.Version);
            var tmp_SerializedProperty = _serialized.FindProperty("ScriptingDefineSymbols");
            if (tmp_SerializedProperty == null) return;
            EditorGUILayout.PropertyField(tmp_SerializedProperty, new GUIContent("Scripting Define Symbols"), true);
            if (tmp_SerializedProperty.isExpanded)
            {
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.Space();
                if (GUILayout.Button("Sync Symbols", GUILayout.Width(100)))
                {
                    var tmp_ScriptDefineSymbols = PlayerSettings
                        .GetScriptingDefineSymbols(XRMODEnginePreferences.GetNamedTarget()).Split(";");
                    tmp_SerializedProperty.ClearArray();
                    tmp_SerializedProperty.arraySize = tmp_ScriptDefineSymbols.Length;
                    for (int tmp_Idx = 0; tmp_Idx < tmp_SerializedProperty.arraySize; tmp_Idx++)
                    {
                        var tmp_NewElement = tmp_SerializedProperty.GetArrayElementAtIndex(tmp_Idx);
                        tmp_NewElement.stringValue = tmp_ScriptDefineSymbols[tmp_Idx];
                    }
                }

                EditorGUILayout.EndHorizontal();
            }

            _serialized.ApplyModifiedProperties();
        }

        public static VisualElement CreatePlatformSettingsUI(this XRMODEnginePlatformSettings _platformSettings,
            SerializedObject _serialized)
        {
            var tmp_Root = new VisualElement();
            tmp_Root.style.marginTop = 10;

            var tmp_Tooltips =
                "Given a version number MAJOR.MINOR.PATCH, increment the:"
                + "\n1.MAJOR version when you make incompatible API changes,"
                + "\n2.MINOR version when you add functionality in a backwards compatible manner, and"
                + "\n3.PATCH version when you make backwards compatible bug fixes."
                + "\nAdditional labels for pre-release and build metadata are available as extensions to the MAJOR.MINOR.PATCH format.";
            
            var tmp_VersionField = new Vector3IntField("SDK Version");
            tmp_VersionField.tooltip = tmp_Tooltips;
            tmp_VersionField.bindingPath = "Version";
            tmp_Root.Add(tmp_VersionField);

            var tmp_SerializedProperty = _serialized.FindProperty("ScriptingDefineSymbols");
            if (tmp_SerializedProperty != null)
            {
                var tmp_PropertyField = new PropertyField(tmp_SerializedProperty);
                tmp_PropertyField.label = "Scripting Define Symbols";
                tmp_Root.Add(tmp_PropertyField);
                
                var tmp_SyncBtn = new Button(() => {
                    var tmp_Target = XRMODEnginePreferences.GetNamedTarget();
                    var tmp_ScriptDefineSymbols = PlayerSettings
                        .GetScriptingDefineSymbols(tmp_Target).Split(new []{';'}, StringSplitOptions.RemoveEmptyEntries);
                        
                    tmp_SerializedProperty.ClearArray();
                    tmp_SerializedProperty.arraySize = tmp_ScriptDefineSymbols.Length;
                    for (int tmp_Idx = 0; tmp_Idx < tmp_SerializedProperty.arraySize; tmp_Idx++)
                    {
                        var tmp_NewElement = tmp_SerializedProperty.GetArrayElementAtIndex(tmp_Idx);
                        tmp_NewElement.stringValue = tmp_ScriptDefineSymbols[tmp_Idx];
                    }
                    _serialized.ApplyModifiedProperties();
                }) { text = "Sync Symbols", tooltip = "Sync from current player settings"};
                
                tmp_SyncBtn.style.width = 100;
                tmp_SyncBtn.style.alignSelf = Align.FlexEnd;
                tmp_Root.Add(tmp_SyncBtn);
            }
            
            tmp_Root.Bind(_serialized);
            return tmp_Root;
        }

        public static SerializedProperty GetScriptingDefineSymbolsSetting(SerializedObject _serialized)
        {
            return _serialized.FindProperty("ScriptingDefineSymbols");
        }


        public static String GetHandheldARPlatform
        {
            get
            {
#if UNITY_IOS
                return "iOS";
#elif UNITY_ANDROID
                return "Android";
#else
                return "";
#endif
            }
        }

        public static SDKInformation CreateSDKInformation()
        {
            var tmp_DefaultResourceFolderPath = Path.Combine(Application.dataPath, "XR", nameof(Resources));
            var tmp_ResourceFolderInUnityPath =
                $"{GetPathInUnityProject(tmp_DefaultResourceFolderPath)}/{nameof(SDKInformation)}.asset";

            var tmp_SDKInformation = ScriptableObject.CreateInstance<SDKInformation>();
            if (!Directory.Exists(tmp_DefaultResourceFolderPath))
                Directory.CreateDirectory(tmp_DefaultResourceFolderPath);
            AssetDatabase.CreateAsset(tmp_SDKInformation, tmp_ResourceFolderInUnityPath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            return tmp_SDKInformation;
        }

        private static string GetPathInUnityProject(string _path)
        {
            var tmp_AssetIdx = _path.IndexOf("Assets", StringComparison.Ordinal);
            var tmp_End = _path.Length - tmp_AssetIdx;
            return _path.Substring(tmp_AssetIdx, tmp_End);
            ;
        }
    }
}