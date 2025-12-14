// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODSimulator.Editor.
// //
// // The UnityVisionOSLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using Phantom.XRMOD.XRMODSimulator.Runtime;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODSimulator.Editor
{
    static class XRMODSimulatorSettingsRegister
    {
        [SettingsProvider]
        public static SettingsProvider CreateSettingProvider()
        {
            var tmp_Provider = new SettingsProvider($"Project/PhantomsXR/XRMODSimulatorSetting", SettingsScope.Project)
            {
                label = "XRMOD Simulator",
                guiHandler = (_searchContext) =>
                {
                    var tmp_Settings = XRMODSimulatorSettings.GetSerializedSettings;
                    EditorGUILayout.PropertyField(tmp_Settings.FindProperty("projectName"),
                        new GUIContent("Project Name"));
                    EditorGUILayout.Slider(tmp_Settings.FindProperty("loadDelayTime"), 0, 2,
                        new GUIContent("Load Delay Time(s)"));

                    EditorGUILayout.PropertyField(tmp_Settings.FindProperty("systemLanguage"),
                        new GUIContent("System Language"));

                    EditorGUILayout.PropertyField(tmp_Settings.FindProperty("useXRMODGameServices"),
                        new GUIContent("Use Game Services"));

                    tmp_Settings.ApplyModifiedProperties();
                }
            };

            return tmp_Provider;
        }
    }
}