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

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public class FusionString128Type : AbstractFusionType<String>
    {
        [Networked, OnChangedRender(nameof(OnChanged))]
        public NetworkString<_128> Value { get; set; }

        protected override void OnChanged()
        {
            OnValueChanged?.Invoke(Value.Value);
        }
    }
}
#endif