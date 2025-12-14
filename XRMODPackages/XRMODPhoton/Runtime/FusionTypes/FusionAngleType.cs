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

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public class FusionAngleType : AbstractFusionType<Angle>, IGetInterpolatorValue<float>
    {
        [Networked, OnChangedRender(nameof(OnChanged))]
        public Angle Value { get; set; }

        protected override void OnChanged()
        {
            OnValueChanged?.Invoke(Value);
        }

        public bool TryGetStateSnapshots(out Angle _from, out Tick _fromTick, out Angle _to, out Tick _toTick,
            out float _alpha)
        {
            return base.TryGetStateSnapshots(nameof(Value), out _from, out _fromTick, out _to, out _toTick, out _alpha);
        }

        public float GetInterpolatorValue()
        {
            var tmp_Interpolated = new NetworkBehaviourBufferInterpolator(this);
            return tmp_Interpolated.Angle(nameof(Value));
        }
    }
}
#endif