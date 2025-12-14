// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime.Enums;

namespace Phantom.XRMOD.Setup.Editor
{
    public class XRMODEngineInitializer
    {
        private static string[] SDKTypeSuffix = new[]
        {
            "NativeLibrary",
            "UnityStandalone"
        };

        private static string[] HandheldPlatform = new[]
        {
            "Android",
            "iOS"
        };

        public static void CreateProjectSettings()
        {
            if (File.Exists(ConstKey.CONST_SETTING_CONFIGURE_FILE_PATH)) return;

            var tmp_SDKInformation = Extensions.CreateSDKInformation();

            var tmp_Settings = ScriptableObject.CreateInstance<XRMODSetupConfigure>();
            tmp_Settings.SDKInformation = tmp_SDKInformation;

            var tmp_XRFolderPath = Path.Combine(Application.dataPath, "XR");
            if (!Directory.Exists(tmp_XRFolderPath))
            {
                Directory.CreateDirectory(tmp_XRFolderPath);
            }

            AssetDatabase.CreateAsset(tmp_Settings, ConstKey.CONST_SETTING_CONFIGURE_FILE_PATH);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            var tmp_AllDevices = Enum.GetNames(typeof(SDKDeviceType));
            foreach (string tmp_Device in tmp_AllDevices)
            {
                foreach (string tmp_SdkTypeName in SDKTypeSuffix)
                {
                    string tmp_PlatformSettingName = string.Empty;
                    if (tmp_Device == "HandheldAR")
                    {
                        foreach (string tmp_HandheldPlatform in HandheldPlatform)
                        {
                            tmp_PlatformSettingName = $"{tmp_Device}{tmp_SdkTypeName}_{tmp_HandheldPlatform}";
                            CreateAndCachePlatformSettings(tmp_PlatformSettingName, tmp_Settings);
                        }
                    }
                    else
                    {
                        tmp_PlatformSettingName = $"{tmp_Device}{tmp_SdkTypeName}";
                        CreateAndCachePlatformSettings(tmp_PlatformSettingName, tmp_Settings);
                    }
                }
            }

            AssetDatabase.Refresh();
            AssetDatabase.SaveAssets();
            EditorUtility.SetDirty(tmp_Settings);
        }

        private static void CreateAndCachePlatformSettings(string _platformSettingName, XRMODSetupConfigure _settings)
        {
            var tmp_PlatformSettings = CreatePlatformSettings(_platformSettingName);
            AssetDatabase.AddObjectToAsset(tmp_PlatformSettings, _settings);
            _settings.PlatformSettingValue.Add(tmp_PlatformSettings);
            _settings.RuntimePlatformKey.Add(_platformSettingName);
        }

        private static XRMODEnginePlatformSettings CreatePlatformSettings(string _settingsName)
        {
            var tmp_PlatformSettings = ScriptableObject.CreateInstance<XRMODEnginePlatformSettings>();
            tmp_PlatformSettings.name = _settingsName;
            var tmp_FilePath = Path.Combine(ConstKey.CONST_PACKAGE_PATH,
                $"Editor/SetupEditor/Assets/DefinesJson/{tmp_PlatformSettings.name}.json");
            var tmp_JsonText = AssetDatabase.LoadAssetAtPath<TextAsset>(tmp_FilePath);
            var tmp_Defines = JsonUtility.FromJson<DefinesJson>(tmp_JsonText.text).Json;
            tmp_PlatformSettings.ScriptingDefineSymbols = tmp_Defines;

            return tmp_PlatformSettings;
        }


        public static void AddMissedPlatformSettings(SDKDeviceType _sdkType)
        {
            foreach (string tmp_SdkTypeName in SDKTypeSuffix)
            {
                var tmp_PlatformSettingName = $"{_sdkType}{tmp_SdkTypeName}";
                XRMODSetupConfigure tmp_XrmodSetupConfigure =
                    AssetDatabase.LoadAssetAtPath<XRMODSetupConfigure>(ConstKey.CONST_SETTING_CONFIGURE_FILE_PATH);
                CreateAndCachePlatformSettings(tmp_PlatformSettingName, tmp_XrmodSetupConfigure);
            }
        }


        public class DefinesJson
        {
            public string[] Json = new string[] { };
        }
    }
}