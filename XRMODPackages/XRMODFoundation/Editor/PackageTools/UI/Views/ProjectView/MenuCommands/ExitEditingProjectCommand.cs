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

using Phantom.XRMOD.ActionNotification.Runtime;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class ExitEditingProjectCommand : BaseGenericMenuItemCommand
    {

        public ExitEditingProjectCommand(GenericMenuItemCommandData _commandData) : base(_commandData)
        {
        }

        public override void Execute()
        {
            var tmp_ProjectCacheData = allProjectsCache.Find(GenericMenuItemCommandData.SelectedId);
            tmp_ProjectCacheData.EntryEditing(true);
            EditorNotificationCenter.Center.PostNotification(nameof(ExitEditingProjectCommand), null);

        }
    }
}