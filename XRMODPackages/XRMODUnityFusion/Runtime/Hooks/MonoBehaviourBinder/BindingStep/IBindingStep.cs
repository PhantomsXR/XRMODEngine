// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Threading.Tasks;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    /// <summary>
    /// Interface for a single step in the <see cref="MonoBinder"/> binding process.
    /// </summary>
    public interface IBindingStep
    {
        /// <summary> The phase of the binding process this step belongs to. </summary>
        BindingPhase Phase { get; }
        
        /// <summary>
        /// Executes the specific logic for this binding step.
        /// </summary>
        /// <param name="_monoBinder">The binder instance to operate on.</param>
        /// <returns>A task representing the execution.</returns>
        Task Execute(MonoBinder _monoBinder);
    }
}