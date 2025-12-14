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

using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class ProjectCacheData : ScriptableObject
    {
        public ProjectDetailCacheData DetailCacheData;
        public ProjectModel Project;

        public void UpdateId(int _id)
        {
            DetailCacheData.Id = _id;
            Project.Id = _id;
        }

        public void EntryEditing(bool _exit)
        {
            Project.ProjectStatus =
                _exit ? ProjectModel.ProjectStatusEnum.Close : ProjectModel.ProjectStatusEnum.Opening;
        }

        private void OnEnable()
        {
            DetailCacheData?.CheckAndMigrate();
        }
    }
}