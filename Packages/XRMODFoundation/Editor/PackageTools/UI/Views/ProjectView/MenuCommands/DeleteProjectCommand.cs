// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System.IO;
using UnityEditor;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class DeleteProjectCommand : BaseGenericMenuItemCommand
    {
        private readonly int deleteId;

        public DeleteProjectCommand(GenericMenuItemCommandData _commandData) : base(_commandData)
        {
            allProjectsCache = _commandData.AllProjectsCache;
            deleteId = _commandData.SelectedId;
        }

        public override void Execute()
        {
            var tmp_ProjectCache = allProjectsCache.GetEditingProjectData();
            if (tmp_ProjectCache && tmp_ProjectCache.Project.Id.Equals(deleteId))
            {
                EditorUtility.DisplayDialog("Error!", "Your project is opening! You can not to delete it!",
                    "OK");
                return;
            }

            var tmp_ProjectData = allProjectsCache.Find(deleteId);
            if (tmp_ProjectData == null) return;
            
            var tmp_Path = tmp_ProjectData.DetailCacheData.GetProjectPath();
            if (string.IsNullOrEmpty(tmp_ProjectData.DetailCacheData.SubPath) || !tmp_Path.Contains("Assets"))
            {
                EditorUtility.DisplayDialog("Error", "Invalid project path!", "OK");
                return;
            }

            if (Directory.Exists(tmp_Path))
            {
                Directory.Delete(tmp_Path, true);
                File.Delete($"{tmp_Path}.meta");
            }

            allProjectsCache.RemoveProject(deleteId);

            //Re-sort all id
            int tmp_CurrentId = 0;
            foreach (ProjectCacheData tmp_CacheData in allProjectsCache.ProjectCacheDataList)
            {
                tmp_CacheData.UpdateId(tmp_CurrentId);
                tmp_CurrentId++;
            }
            
            AssetDatabase.Refresh();
        }
    }
}
