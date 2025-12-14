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
using Fusion;
using UnityEngine;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public class FusionIntegerType : BaseFusionTypeWithChangeDetector<int>,IGetInterpolatorValue<int>
    {
        [Networked, OnChangedRender(nameof(OnChanged))]
        public int Value { get; set; }
        


        protected override void OnChanged()
        {
            OnValueChanged?.Invoke(Value);
        }

        public override void Render()
        {
            base.Render();
            if (!UseChangeDetector ) return;
            changeDetector ??= GetChangeDetector(Source);
            UpdateChangeDetector(this,Key,OnChangeDetector);
            // OnChangeDetector?.Invoke(Key,tmp_PreviousBuffer, tmp_CurrentBuffer);
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
        public bool TryGetStateSnapshots(out int _from,out Tick _fromTick,out int _to,out Tick _toTick,out float _alpha)
        {
            return base.TryGetStateSnapshots(nameof(Value), out _from, out _fromTick, out _to, out _toTick, out _alpha);
        }
        
        public int GetInterpolatorValue()
        {
            var tmp_Interpolated = new NetworkBehaviourBufferInterpolator(this);
            return tmp_Interpolated.Int(nameof(Value));
        }
    }
}
#endif