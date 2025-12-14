// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODSimulator.Runtime.
// //
// // The UnityVisionOSLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

#if UNITY_EDITOR
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEditor;
#endif
using UnityEngine;

namespace Phantom.XRMOD.XRMODSimulator.Runtime
{
    public class XRMODSimulatorSettings : ScriptableObject
    {
        public const string CONST_XRMOD_Simualtor_SETTINGS_PATH = "Assets/XR/Settings/XRMODSimulatorSettings.asset";

        [SerializeField] internal string projectName;
        [SerializeField] internal float loadDelayTime = 1;
        [SerializeField] internal bool useXRMODGameServices = false;
        [SerializeField] internal SystemLanguage systemLanguage;
        [SerializeField] internal bool loadFromRemote = false;
        [SerializeField] internal string gateway;
        [SerializeField] internal string token;
        private SystemLanguage previousLanguage;
#if UNITY_EDITOR
        internal static XRMODSimulatorSettings GetOrCreateSettings()
        {
            var tmp_Settings =
                AssetDatabase.LoadAssetAtPath<XRMODSimulatorSettings>(CONST_XRMOD_Simualtor_SETTINGS_PATH);
            if (tmp_Settings == null)
            {
                tmp_Settings = CreateInstance<XRMODSimulatorSettings>();
                tmp_Settings.projectName = "Project Name or Project Id";
                tmp_Settings.loadDelayTime = 1;
                tmp_Settings.systemLanguage = Application.systemLanguage;
                AssetDatabase.CreateAsset(tmp_Settings, CONST_XRMOD_Simualtor_SETTINGS_PATH);
                AssetDatabase.SaveAssets();
            }

            return tmp_Settings;
        }

        private void OnValidate()
        {
            if (previousLanguage == systemLanguage) return;
            previousLanguage = systemLanguage;
            ActionNotificationCenter.DefaultCenter.PostNotification("SetLanguage", new BaseNotificationData()
            {
                BaseData = systemLanguage.ToString(),
            });
        }

        public static SerializedObject GetSerializedSettings => new(GetOrCreateSettings()); 
#endif
    }
}