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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    /// <summary>
    /// Orchestrates the binding process by executing a series of <see cref="IBindingStep"/> in order.
    /// Manages both single and batch binding requests for <see cref="MonoBinder"/> instances.
    /// </summary>
    public class BindingOrchestrator
    {
        private IReadOnlyDictionary<BindingPhase, IBindingStep> bindingSteps;

        /// <summary>
        /// Initializes a new instance of the <see cref="BindingOrchestrator"/> with the provided steps.
        /// </summary>
        /// <param name="_bindingSteps">The list of steps to execute during binding.</param>
        public BindingOrchestrator(IReadOnlyList<IBindingStep> _bindingSteps)
        {
            bindingSteps = _bindingSteps.ToDictionary(_s => _s.Phase, _s => _s);
        }

        /// <summary>
        /// Executes the binding steps for a single <see cref="MonoBinder"/>.
        /// </summary>
        /// <param name="_monoBinder">The binder to process.</param>
        /// <returns>A task representing the binding process.</returns>
        public async Task BindScript(MonoBinder _monoBinder)
        {
            try
            {
                foreach (var tmp_Step in bindingSteps.Values.OrderBy(s => s.Phase))
                {
                    await tmp_Step.Execute(_monoBinder);
                }
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogException(tmp_Exception);
                throw;
            }
        }


        /// <summary>
        /// Executes the binding steps for a batch of <see cref="MonoBinder"/> instances.
        /// Each step is executed for all binders before moving to the next step.
        /// </summary>
        /// <param name="_monoBinders">The array of binders to process.</param>
        /// <returns>A task representing the batch binding process.</returns>
        public async Task BindScriptBatch(MonoBinder[] _monoBinders)
        {
            if (_monoBinders == null)
                throw new ArgumentNullException(nameof(_monoBinders),
                    "The MonoBinder array to be batch-bound cannot be null");

            // Empty sets return directly to avoid subsequent invalid loops
            if (_monoBinders.Length == 0 || bindingSteps.Count == 0)
                return;

            foreach (var tmp_Step in bindingSteps.Values.OrderBy(s => s.Phase))
            {
                var tmp_Tasks = _monoBinders.Select(_b => tmp_Step.Execute(_b));
                try
                {
                    await Task.WhenAll(tmp_Tasks);
                }
                catch (Exception ex)
                {
                    Debug.LogError($"[Batch] Error during {tmp_Step.Phase}: {ex}");
                }
            }
        }
    }
}