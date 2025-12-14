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

using System;
using Phantom.XRMOD.Localization.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Editor
{
    public class LocalizationDbEditor
    {
        private const string _CONST_TITLE = "Create LocalizationDatabase";
        private const string _CONST_LOCALIZATION_DB = "LocalizationDatabase";
        private const string _CONST_MESSAGE = "Select path to save the LocalizationDatabas";

        [MenuItem("Tools/XR-MOD/Tools/Localization/New Database(In-Launcher)")]
        public static void CreateLocalizationDatabaseInLauncher()
        {
            string tmp_Path =
                EditorUtility.SaveFilePanelInProject(_CONST_TITLE,
                    $"{_CONST_LOCALIZATION_DB}_{LocalizationScope.InLauncher}", "asset",
                    _CONST_MESSAGE);
            CreateDbAsset(tmp_Path);
        }


        [MenuItem("Tools/XR-MOD/Tools/Localization/New Database(In-Experience)")]
        public static void CreateLocalizationDatabaseInExperience()
        {
            string tmp_Path =
                EditorUtility.SaveFilePanelInProject(_CONST_TITLE,
                    $"{_CONST_LOCALIZATION_DB}_{LocalizationScope.InExperiences}", "asset",
                    _CONST_MESSAGE);
            CreateDbAsset(_path: tmp_Path, _scope: LocalizationScope.InExperiences);
        }

        public static void CreateDbAsset(string _path, string _name = "LocalizationDatabase",
            LocalizationScope _scope = LocalizationScope.InExperiences)
        {
            if (string.IsNullOrEmpty(_path))
                return;

            var tmp_DB = ScriptableObject.CreateInstance<LocalizationDatabase>();
            AssetDatabase.CreateAsset(tmp_DB, _path);

            foreach (var tmp_XrmodPlatform in Enum.GetNames(typeof(XRMODPlatform)))
            {
                CreateAndAttachTable(tmp_DB, _scope, tmp_XrmodPlatform);
            }

            var tmp_LocalizationSettings = ScriptableObject.CreateInstance<LocalizatoinSettings>();
            tmp_LocalizationSettings.name = _name;
            Utilities.CreateAndAttachTable(tmp_DB, tmp_LocalizationSettings);

            EditorUtility.SetDirty(tmp_DB);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            Selection.activeObject = tmp_DB;
        }

        private static void CreateAndAttachTable(LocalizationDatabase _db, LocalizationScope _scope,
            string _platform)
        {
            var tmp_Table = ScriptableObject.CreateInstance<LocalizationTable>();
            tmp_Table.name = $"{_scope}_{_platform}";
            tmp_Table.Scope = _scope;
            tmp_Table.Platform = Enum.Parse<XRMODPlatform>(_platform);

            // Add to main asset as sub-asset
            AssetDatabase.AddObjectToAsset(tmp_Table, _db);
            _db.Tables.Add(tmp_Table);
        }
    }
}