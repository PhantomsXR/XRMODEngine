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
    public class BindingOrchestrator
    {
        private IReadOnlyDictionary<BindingPhase, IBindingStep> bindingSteps;

        public BindingOrchestrator(IReadOnlyList<IBindingStep> _bindingSteps)
        {
            bindingSteps = _bindingSteps.ToDictionary(_s => _s.Phase, _s => _s);
        }

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