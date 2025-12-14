// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineCore.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// The submodule is a system independent of the XR module,
    /// which allows operation independently of the XR module and is not limited to the operating platform.
    /// At the same time, it is a module that can be registered and canceled at any time; when using this module,
    /// it must be registered first, otherwise it cannot be used.
    /// </summary>
    public interface ISubModel
    {
        /// <summary>
        /// Register sub-model
        /// </summary>
        void RegisterSubModel();

        /// <summary>
        /// Unregister sub-model
        /// </summary>
        void UnregisterSubModel();


        /// <summary>
        /// Pause sub-model
        /// </summary>
        void PauseSubModel();
    }
}