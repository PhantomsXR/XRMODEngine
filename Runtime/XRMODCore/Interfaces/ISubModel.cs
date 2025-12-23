/*===============================================================================
Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XRMODEngineCore.Runtime.

The  XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Interface for sub-modules that operate independently of the primary XR module.
    /// Sub-models can be dynamically registered, paused, and unregistered to manage resource usage.
    /// </summary>
    public interface ISubModel
    {
        /// <summary>
        /// Registers the sub-model with the system, making its functionality available.
        /// </summary>
        void RegisterSubModel();

        /// <summary>
        /// Unregisters the sub-model and releases its resources.
        /// </summary>
        void UnregisterSubModel();

        /// <summary>
        /// Pauses the sub-model's internal logic processing.
        /// </summary>
        void PauseSubModel();
    }
}