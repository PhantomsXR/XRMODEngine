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
    /// A binding step responsible for assigning serialized field values to the newly created hot-reload script instances.
    /// </summary>
    public class SetValueStep : IBindingStep
    {
        public BindingPhase Phase { get; } = BindingPhase.SetValue;

        public Task Execute(MonoBinder _monoBinder)
        {
            if (_monoBinder == null) return Task.CompletedTask;

            for (int tmp_Idx = _monoBinder.ScriptList.Count - 1; tmp_Idx >= 0; tmp_Idx--)
            {
                MonoData tmp_MonoScript = _monoBinder.ScriptList[tmp_Idx];
                if (tmp_MonoScript == null || tmp_MonoScript.BoundData)
                    continue;
                _monoBinder.SetValues(tmp_MonoScript);
            }

            return Task.CompletedTask;
        }
    }
}