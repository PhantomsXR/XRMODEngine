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
    /// <summary>
    /// Defines the lifecycle and core functionality of an XRMOD module.
    /// Modules represent high-level system components such as AR algorithms,
    /// tracking systems, or feature managers.
    /// </summary>
    public interface IModule
    {
        /// <summary>
        /// Initializes and starts the module's core logic.
        /// Useful for setting up resources after dependencies are resolved.
        /// </summary>
        /// <returns>True if the module started successfully; otherwise, false.</returns>
        bool StartModule();

        /// <summary>
        /// Pauses the module's execution without disposing of its resources.
        /// Allows for quick resumption later.
        /// </summary>
        /// <returns>True if the module was successfully paused; otherwise, false.</returns>
        bool PauseModule();

        /// <summary>
        /// Stops the module and releases all associated resources.
        /// This should be called when the module is no longer needed.
        /// </summary>
        /// <returns>Typically returns true after successful disposal.</returns>
        bool StopModule();

        /// <summary>
        /// Checks if the module is compatible and available on the current device.
        /// </summary>
        /// <returns>True if available; otherwise, false.</returns>
        bool IsModuleAvailability();

        /// <summary>
        /// Ensures all necessary dependencies for the module are loaded and ready.
        /// </summary>
        void MakeSureDependencies();
    }
}