using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class PrefabChangeMonitor : AssetModificationProcessor
    {
        private const string _CONST_TEMP_FOLDER = "AutomaticGenerated/TempAssets";
        private static readonly List<string> _PENDING_PREFABS = new();

        public static string[] OnWillSaveAssets(string[] _paths)
        {
            _PENDING_PREFABS.Clear();
            foreach (var tmp_Path in _paths)
            {
                // 忽略其他类型的监听
                if (!tmp_Path.EndsWith(".prefab")) continue;
                // 忽略改路径下的监听
                if (tmp_Path.Contains(_CONST_TEMP_FOLDER)) continue;
                _PENDING_PREFABS.Add(tmp_Path);
            }

            EditorApplication.delayCall -= CopyModifyPrefabs;
            EditorApplication.delayCall += CopyModifyPrefabs;
            return _paths;
        }

        private static async void CopyModifyPrefabs()
        {
            var tmp_DestPathList = new List<string>();
            for (int tmp_Idx = 0; tmp_Idx < _PENDING_PREFABS.Count; tmp_Idx++)
            {
                var tmp_Path = _PENDING_PREFABS[tmp_Idx];
                var tmp_EditingProject = PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData();
                if (tmp_EditingProject == null) return;
                var tmp_CurrentProjectPath = tmp_EditingProject.DetailCacheData.GetProjectPath();
                var tmp_FileName = Path.GetFileName(tmp_Path);
                var tmp_DestPath = Path.Combine(tmp_CurrentProjectPath, _CONST_TEMP_FOLDER, tmp_FileName);
                tmp_DestPath = Utility.ShortenPath(tmp_DestPath);
                AssetDatabase.CopyAsset(tmp_Path, tmp_DestPath);
                tmp_DestPathList.Add(tmp_DestPath);
            }

            _PENDING_PREFABS.Clear();

            await Task.Delay(1000);

            foreach (var tmp_DestPath in tmp_DestPathList)
            {
                BaseNotificationData tmp_NotificationData = new BaseNotificationData();
                var tmp_PrefabGo = AssetDatabase.LoadAssetAtPath<GameObject>(tmp_DestPath);
                tmp_NotificationData.ObjectData = tmp_PrefabGo;
                await EditorNotificationCenter.Center.PostNotificationAsync("ConvertToMonoBinderBatch",
                    tmp_NotificationData);
            }

        }
    }
}