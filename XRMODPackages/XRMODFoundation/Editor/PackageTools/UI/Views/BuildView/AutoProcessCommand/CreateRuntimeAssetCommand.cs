// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class CreateRuntimeAssetCommand : ProcessHandler
    {
        public override async Task Execute()
        {
            string[] dontCopyFilter = new[]
            {
                $"{ProcessShareData.GetInstance.projectName}.runtime.dll.bytes".ToLower(),
                $"{ProcessShareData.GetInstance.projectName}.runtime.pdb.bytes".ToLower(),
                "ARProperty.json",
                "LocalizationTable.csv",
                "LocalizationDatabase.asset",
                "RuntimeAssetReferenceDatabase.asset"
            };

            string[] dontCopyFilterSuffix = new[] {".json"};
            // Create a temp folder to save the temp assets
            var tmp_CacheFolderPath = ProcessShareData.GetInstance.projectPath;
            var tmp_TempAssetFolderPath = Path.Combine(tmp_CacheFolderPath, "AutomaticGenerated/TempAssets");
            if (!Directory.Exists(tmp_TempAssetFolderPath))
            {
                Directory.CreateDirectory(tmp_TempAssetFolderPath);
            }
            else
            {
                // Delete all temp assets
                // AssetDatabase.DeleteAsset(Utility.ShortenPath(tmp_TempAssetFolderPath));
                Directory.CreateDirectory(tmp_TempAssetFolderPath);
            }

            // Copy all assets to temp folder
            Dictionary<string, string> tmp_NeedToCopyAssetsPathFilter = new();
            foreach (var tmp_AssetPath in ProcessShareData.GetInstance.bundlePath)
            {
                var tmp_FileName = Path.GetFileName(tmp_AssetPath);
                var tmp_AbsoluteDestPath = Path.Combine(tmp_TempAssetFolderPath, tmp_FileName);
                var tmp_DestFilePath = Utility.ShortenPath(tmp_AbsoluteDestPath);

                // Exclude these files
                if (dontCopyFilter.Contains(tmp_FileName))
                {
                    ProcessShareData.GetInstance.tempAssetsPath.Add(tmp_AssetPath);
                    continue;
                }

                if (dontCopyFilterSuffix.Contains(Path.GetExtension(tmp_FileName)))
                {
                    ProcessShareData.GetInstance.tempAssetsPath.Add(tmp_AssetPath);
                    continue;
                }

                if (File.Exists(tmp_AbsoluteDestPath))
                {
                    var tmp_SrcTime = File.GetLastWriteTime(tmp_AssetPath);
                    var tmp_DestTime = File.GetLastWriteTime(tmp_AbsoluteDestPath);
                    if (tmp_SrcTime <= tmp_DestTime)
                    {
                        ProcessShareData.GetInstance.tempAssetsPath.Add(tmp_DestFilePath);
                        continue;
                    }
                }

                tmp_NeedToCopyAssetsPathFilter.Add(tmp_AssetPath, tmp_DestFilePath);
                ProcessShareData.GetInstance.tempAssetsPath.Add(tmp_DestFilePath);
            }

            var tmp_SourcePaths = tmp_NeedToCopyAssetsPathFilter.Keys.ToArray();
            var tmp_DestAssetPaths = tmp_NeedToCopyAssetsPathFilter.Values.ToArray();

            foreach (var tmp_DestPath in tmp_DestAssetPaths)
            {
                AssetDatabase.DeleteAsset(tmp_DestPath);
            }

            bool tmp_CopyResult = true;
            if (tmp_SourcePaths.Length > 0)
            {
                tmp_CopyResult = AssetDatabase.CopyAssets(tmp_SourcePaths, tmp_DestAssetPaths);
            }

            if (tmp_CopyResult)
            {
                if (tmp_SourcePaths.Length > 0)
                {
                    // Check the prefabs
                    // Remove components when Enable state is dissabled 
                    // Add all temp assets to build list
                    // Convert XRMODBehaviour to MonoBinder
                    var tmp_AllDestPrefabPaths = tmp_DestAssetPaths
                        .Where(_path => _path.EndsWith("prefab")).ToArray();
                    BaseNotificationData tmp_NotificationData = new BaseNotificationData();
                    foreach (var tmp_PrefabPath in tmp_AllDestPrefabPaths)
                    {
                        var tmp_PrefabGo = AssetDatabase.LoadAssetAtPath<GameObject>(tmp_PrefabPath);
                        tmp_NotificationData.ObjectData = tmp_PrefabGo;
                        if (ProcessShareData.GetInstance.projectDetailCacheData.BuildSettingData.AutoConvertOptions)
                            await EditorNotificationCenter.Center.PostNotificationAsync("ConvertToMonoBinderBatch",
                                tmp_NotificationData);
                    }

                    await Task.Delay(100);

                    // Cleanup all XRMODBehaviour components
                    foreach (string tmp_PrefabPath in tmp_AllDestPrefabPaths)
                    {
                        var tmp_PrefabGo = AssetDatabase.LoadAssetAtPath<GameObject>(tmp_PrefabPath);
                        var tmp_AllScripts = tmp_PrefabGo.GetComponentsInChildren<XRMODBehaviour>(true);
                        foreach (XRMODBehaviour tmp_Script in tmp_AllScripts)
                        {
                            if (tmp_Script == null || tmp_Script.enabled) continue;
                            Object.DestroyImmediate(tmp_Script, true);
                            EditorUtility.SetDirty(tmp_PrefabGo);
                        }
                    }

                    var tmp_AllScenePaths = tmp_DestAssetPaths
                        .Where(_path => _path.EndsWith("unity"))
                        .ToArray();
                    foreach (var tmp_ScenePath in tmp_AllScenePaths)
                    {
                        var tmp_OpenScene = EditorSceneManager.OpenScene(tmp_ScenePath, OpenSceneMode.Additive);
                        var tmp_AllXRMODBehaviour =
                            Object.FindObjectsByType<XRMODBehaviour>(FindObjectsInactive.Include,
                                FindObjectsSortMode.None);
                        var tmp_DisabledComponent =
                            tmp_AllXRMODBehaviour.Where(_component => !_component.enabled).ToArray();
                        foreach (XRMODBehaviour tmp_Script in tmp_DisabledComponent)
                        {
                            if (tmp_Script == null || tmp_Script.enabled) continue;
                            var tmp_CurrentGo = tmp_Script.gameObject;
                            Object.DestroyImmediate(tmp_Script, true);
                            EditorUtility.SetDirty(tmp_CurrentGo);
                        }

                        EditorSceneManager.SaveScene(tmp_OpenScene);
                        EditorSceneManager.CloseScene(tmp_OpenScene, true);
                    }
                }

                await base.Execute();
            }
        }
    }
}