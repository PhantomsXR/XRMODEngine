/*===============================================================================
Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Core.Runtime.

The  XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Interface for components that require regular "tick" updates.
    /// Provides an alternative to Unity's <c>Update</c> for decoupled logic processing.
    /// </summary>
    public interface ITick
    {
        /// <summary>
        /// Method called periodically to perform logic updates.
        /// </summary>
        void OnTick();
    }
}