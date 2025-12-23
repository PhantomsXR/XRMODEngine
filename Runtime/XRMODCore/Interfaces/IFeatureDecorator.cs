/*===============================================================================
Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XRMODEngineCore.Runtime.

The XRMOD-SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Interface for feature decorators that encapsulate XR algorithms or specific hardware capabilities.
    /// Decorators manage the lifecycle and availability of the features they represent.
    /// </summary>
    public interface IFeatureDecorator
    {
        /// <summary>
        /// Checks if the current hardware or platform supports this feature.
        /// </summary>
        /// <returns>True if supported; otherwise, false.</returns>
        public bool SupportThisFeature();

        /// <summary>
        /// Initializes and starts the feature's core algorithm or logic.
        /// </summary>
        public void StartAlgorithm();

        /// <summary>
        /// Pauses the feature's algorithm without releasing resources.
        /// </summary>
        public void PauseAlgorithm();

        /// <summary>
        /// Stops the feature's algorithm and performs necessary cleanup.
        /// </summary>
        public void StopAlgorithm();
    }
}