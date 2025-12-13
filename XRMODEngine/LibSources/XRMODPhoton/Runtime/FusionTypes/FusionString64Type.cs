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
    public class FusionString64Type : AbstractFusionType<string>
    {
        [Networked, OnChangedRender(nameof(OnChanged))]
        [Capacity(64)]
        [UnityMultiline]
        public string Value{ get; set; }

        protected override void OnChanged()
        {
            OnValueChanged?.Invoke(Value);
        }
    }
}
#endif