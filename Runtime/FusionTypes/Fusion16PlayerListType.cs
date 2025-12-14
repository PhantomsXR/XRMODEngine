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
    public class Fusion16PlayerListType:AbstractFusionType<NetworkDictionary<int,PlayerRef>>
    {
        [Networked, OnChangedRender(nameof(OnChanged)),Capacity(16)]
        public NetworkDictionary<int,PlayerRef> Value { get; }
        
        protected override void OnChanged()
        {
            OnValueChanged?.Invoke(Value);
        }
    }
}
#endif