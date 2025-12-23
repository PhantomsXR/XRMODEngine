/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XRMODEngineCore.Runtime.

The XRMODEngineCore.Runtime cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Base interface for data models within the XRMOD framework.
    /// Models are responsible for state management and data persistence.
    /// </summary>
    public interface IModel
    {
        /// <summary>
        /// Initializes the data model with default values or from a persistent state.
        /// </summary>
        void Initialize();
    }
}