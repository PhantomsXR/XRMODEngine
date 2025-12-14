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
    public class ActivateStep : IBindingStep
    {
        public BindingPhase Phase { get; } = BindingPhase.Activate;

        public Task Execute(MonoBinder _monoBinder)
        {
            if (_monoBinder == null) return Task.CompletedTask;
            for (int tmp_Idx = _monoBinder.ScriptList.Count - 1; tmp_Idx >= 0; tmp_Idx--)
            {
                MonoData tmp_MonoScript = _monoBinder.ScriptList[tmp_Idx];
                if (tmp_MonoScript == null || tmp_MonoScript.Activated)
                    continue;
                _monoBinder.ActiveScript(tmp_MonoScript);
            }

            return Task.CompletedTask;
        }
    }
}