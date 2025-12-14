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

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public enum MenuType
    {
        CreateProjectFromTemplate,
        CreateProjectWithBlank
    }

    public class GenericMenuItemCommandData
    {
        public string CommandId;
        public AllProjectsCache AllProjectsCache;
        public int SelectedId;
        public string DestinationPath;
        public MenuType MenuType;
        public string GenericParameter;
    }

    public static class CommandFactory
    {
        public static void CreateAndExecuteCommand(GenericMenuItemCommandData _commandData)
        {
            BaseGenericMenuItemCommand tmp_BaseGenericMenuItemCommand = null;
            switch (_commandData.CommandId)
            {
                case nameof(CreateProjectCommand):
                    tmp_BaseGenericMenuItemCommand = new CreateProjectCommand(_commandData);
                    break;
                case nameof(OpenProjectCommand):
                    tmp_BaseGenericMenuItemCommand = new OpenProjectCommand(_commandData);
                    break;
                case nameof(RemoveProjectCommand):
                    tmp_BaseGenericMenuItemCommand = new RemoveProjectCommand(_commandData);
                    break;
                case nameof(EditingProjectCommand):
                    tmp_BaseGenericMenuItemCommand = new EditingProjectCommand(_commandData);

                    break;
                case nameof(ExitEditingProjectCommand):
                    tmp_BaseGenericMenuItemCommand = new ExitEditingProjectCommand(_commandData);
                    break;
                case nameof(RefreshCommand):
                    tmp_BaseGenericMenuItemCommand = new RefreshCommand(_commandData);
                    break;
                case nameof(DeleteProjectCommand):
                    tmp_BaseGenericMenuItemCommand = new DeleteProjectCommand(_commandData);
                    break;
            }

            tmp_BaseGenericMenuItemCommand?.Execute();
        }
    }
}