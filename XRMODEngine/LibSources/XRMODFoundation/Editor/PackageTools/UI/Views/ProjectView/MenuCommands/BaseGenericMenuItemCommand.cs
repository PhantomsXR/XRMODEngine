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
    public abstract class BaseGenericMenuItemCommand
    {
        protected AllProjectsCache allProjectsCache;
        protected readonly GenericMenuItemCommandData GenericMenuItemCommandData;

        public BaseGenericMenuItemCommand(GenericMenuItemCommandData _commandData )
        {
            GenericMenuItemCommandData = _commandData;
            allProjectsCache = _commandData.AllProjectsCache;
        }

        public abstract void Execute();
    }
}