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
    public class FusionVector3Type : BaseFusionTypeWithChangeDetector<Vector3>,IGetInterpolatorValue<Vector3>
    {
        [Networked, OnChangedRender(nameof(OnChanged))]
        public Vector3 Value { get; set; }

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

        public bool TryGetStateSnapshots(out Vector3 _from, out Tick _fromTick, out Vector3 _to, out Tick _toTick,
            out float _alpha)
        {
            return base.TryGetStateSnapshots(nameof(Value), out _from, out _fromTick, out _to, out _toTick, out _alpha);
        }
        
        public Vector3 GetInterpolatorValue()
        {
            var tmp_Interpolated = new NetworkBehaviourBufferInterpolator(this);
            return tmp_Interpolated.Vector3(nameof(Value));
        }
    }
}
#endif