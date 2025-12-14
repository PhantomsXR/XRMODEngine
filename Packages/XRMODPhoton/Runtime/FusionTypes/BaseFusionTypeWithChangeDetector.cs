// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

#if FUSION2
using System;
using Fusion;
using UnityEngine;
using UnityEngine.Events;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public abstract class BaseFusionTypeWithChangeDetector<T> : BaseFusionType
    {
        public bool UseChangeDetector = false;

        /// <summary>
        /// Work on value changed. include flow-state.
        /// </summary>
        public UnityEvent<string, T, T> OnChangeDetector = new();

        /// <summary>
        /// Only work on value changed. Not a flow-state.
        /// </summary>
        public UnityEvent<T> OnValueChanged = new();

        public ChangeDetector.Source Source = ChangeDetector.Source.SimulationState;

        protected ChangeDetector changeDetector;

        protected abstract void OnChanged();

        public override void Spawned()
        {
            base.Spawned();
            if (UseChangeDetector)
                changeDetector = GetChangeDetector(Source);
        }

        protected void UpdateChangeDetector<TYpe>(NetworkBehaviour _b, string _key,
            UnityEvent<string, TYpe, TYpe> _callback)
            where TYpe : unmanaged
        {
            foreach (var tmp_Change in changeDetector.DetectChanges(_b, out var tmp_PreviousBuffer,
                         out var tmp_CurrentBuffer))
            {
                if (tmp_Change != "Value") continue;
                var tmp_Reader = GetPropertyReader<TYpe>(tmp_Change);
                _callback?.Invoke(_key, tmp_PreviousBuffer.Read(tmp_Reader), tmp_CurrentBuffer.Read(tmp_Reader));
            }


            // foreach (var tmp_Change in changeDetector.DetectChanges(this, out var tmp_PreviousBuffer,
            //              out var tmp_CurrentBuffer))
            // {
            //     if (tmp_Change != "Value") continue;
            //     var tmp_Reader = GetPropertyReader<int>(tmp_Change);
            //     OnChangeDetector?.Invoke(Key, tmp_PreviousBuffer.Read(tmp_Reader),
            //         tmp_CurrentBuffer.Read(tmp_Reader));
            //     Debug.Log($"{tmp_PreviousBuffer},{tmp_CurrentBuffer}");
            //
            // }
        }
    }
}
#endif