/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XRMODEngineCore.Runtime.

The ARMOD-SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Interface for platform-dependent capability injection.
    /// Implementation should handle platform-specific registrations and feature executions.
    /// </summary>
    public interface IPlatformDependenceInject
    {
        /// <summary>
        /// Injects platform-specific service implementations into the global IOC container.
        /// </summary>
        void Inject();

        /// <summary>
        /// Removes platform-specific service implementations from the global IOC container.
        /// </summary>
        void UnInject();

        /// <summary>
        /// Executes a platform-specific feature by its identified name.
        /// </summary>
        /// <param name="_featureName">The name/ID of the feature to perform.</param>
        void PerformFeature(string _featureName);
    }
}