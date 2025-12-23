// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the UnityFusion.Runtime.CodeHook.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook.ICommand
{
    /// <summary>
    /// Interface for commands that initialize an adapter for a specific component.
    /// </summary>
    /// <typeparam name="T">The type of adapter instance created and returned.</typeparam>
    public interface ICommandForInitAdapter<T> where T : class,new()
    {
        /// <summary>
        /// Executes the initialization command.
        /// </summary>
        /// <returns>The created adapter instance.</returns>
        T Execute();
    }
}