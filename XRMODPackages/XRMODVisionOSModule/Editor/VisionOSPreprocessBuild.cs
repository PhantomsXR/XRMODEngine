// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VisionOSModule.Editor.
// //
// // The VisionOSPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace Phantom.XRMOD.VisionOSModule.Editor
{
    public class VisionOSPreprocessBuild : IPreprocessBuildWithReport
    {
        private const string _CONST_PROJECT_SETTINGS_PATH = "ProjectSettings/ProjectSettings.asset";

        private void SetLocationUsageDescription()
        {
            if (!File.Exists(_CONST_PROJECT_SETTINGS_PATH))
            {
                Debug.LogError($"Could not find {_CONST_PROJECT_SETTINGS_PATH}");
                return;
            }

            // 读取 ProjectSettings.asset 文件
            string[] tmp_Lines = File.ReadAllLines(_CONST_PROJECT_SETTINGS_PATH);
            bool tmp_Modified = false;

            for (int tmp_Idx = 0; tmp_Idx < tmp_Lines.Length; tmp_Idx++)
            {
                // 查找 locationUsageDescription 参数
                if (tmp_Lines[tmp_Idx].Trim().StartsWith("locationUsageDescription:"))
                {
                    tmp_Lines[tmp_Idx] =
                        "  locationUsageDescription: We need your location to provide better services.";
                    tmp_Modified = true;
                }

                if (tmp_Lines[tmp_Idx].Trim().StartsWith("locationAlwaysUsageDescription:"))
                {
                    tmp_Lines[tmp_Idx] =
                        "  locationAlwaysUsageDescription: We need your location for background functionality.";
                    tmp_Modified = true;
                }
            }

            // 如果没有找到对应字段，则添加
            if (!tmp_Modified)
            {
                using StreamWriter tmp_Writer = File.AppendText(_CONST_PROJECT_SETTINGS_PATH);
                tmp_Writer.WriteLine("  locationUsageDescription: We need your location to provide better services.");
                tmp_Writer.WriteLine(
                    "  locationAlwaysUsageDescription: We need your location for background functionality.");
            }
            else
            {
                // 保存修改
                File.WriteAllLines(_CONST_PROJECT_SETTINGS_PATH, tmp_Lines);
            }

            // 刷新 Asset 数据库以确保更改生效
            AssetDatabase.Refresh();
        }

        public int callbackOrder { get; }

        public void OnPreprocessBuild(BuildReport _report)
        {
#if UNITY_VISIONOS
            SetLocationUsageDescription();
#endif
        }
    }
}