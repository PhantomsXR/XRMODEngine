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
    public class FusionTickTimerType : BaseFusionTypeWithChangeDetector<TickTimer>
    {
        [Networked, OnChangedRender(nameof(OnChanged))]
        public TickTimer Value { get; set; }

        public bool Expired => Value.Expired(Runner);
        public bool ExpiredOrNotRunning => Value.ExpiredOrNotRunning(Runner);
        public int? RemainingTicks => Value.RemainingTicks(Runner);
        public float? RemainingTime => Value.RemainingTime(Runner);
        public void CreateFromTicks(int _ticks) => Value = TickTimer.CreateFromTicks(Runner, _ticks);

        public void CreateFromSeconds(float _delayInSeconds) =>
            Value = TickTimer.CreateFromSeconds(Runner, _delayInSeconds);


        protected override void OnChanged()
        {
            OnValueChanged?.Invoke(Value);
        }

        public override void Render()
        {
            base.Render();
            if (!UseChangeDetector) return;

            changeDetector ??= GetChangeDetector(Source);
            UpdateChangeDetector(this,Key,OnChangeDetector);
        }
        
        public bool TryGetStateSnapshots(out TickTimer _from,out Tick _fromTick,out TickTimer _to,out Tick _toTick,out float _alpha)
        {
            return base.TryGetStateSnapshots(nameof(Value), out _from, out _fromTick, out _to, out _toTick, out _alpha);
        }
    }
}
#endif