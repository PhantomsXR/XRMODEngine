// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineCore.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/


namespace Phantom.XRMOD.Core.Runtime
{
    public interface IPlatformDependenceInject
    {
        /// <summary>
        /// Inject special capabilities of the platform into the IOC container
        /// </summary>
        void Inject();

        /// <summary>
        /// Uninject special capabilities of the platform from the IOC container
        /// </summary>
        void UnInject();


        /// <summary>
        /// Add platform-specific capabilities to runtime for execution.
        /// </summary>
        /// <param name="_featureName"></param>
        void PerformFeature(string _featureName);
    }
}