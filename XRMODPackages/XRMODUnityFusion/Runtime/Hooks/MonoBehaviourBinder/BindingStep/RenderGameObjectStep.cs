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
using UnityEngine;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    /// <summary>
    /// A binding step responsible for resetting the GameObject state.
    /// It removes old scripts and sets up the initial render state (visible or hidden).
    /// </summary>
    public class RenderGameObjectStep : IBindingStep
    {
        public BindingPhase Phase { get; } = BindingPhase.SetRenderer;

        public Task Execute(MonoBinder _monoBinder)
        {
            if (_monoBinder == null) return Task.CompletedTask; 
            _monoBinder.Remove();
            _monoBinder.SetupGameObjectRenderState(_monoBinder.DefaultRenderState ==
                                                   RenderStateType.Visiable);

            return Task.CompletedTask;
        }
    }
}