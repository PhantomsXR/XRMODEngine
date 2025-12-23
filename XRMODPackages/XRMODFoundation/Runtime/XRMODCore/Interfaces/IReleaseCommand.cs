/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the ARFeatures.Runtime.

The ARMOD-SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Interface for commands that handle the release or disposal of resources.
    /// </summary>
    public interface IReleaseCommand
    {
        /// <summary>
        /// Releases all resources associated with the command or the specified project.
        /// </summary>
        /// <param name="_projectName">Optional name of the project to release resources for.</param>
        void Release(string _projectName = default);
    }
}