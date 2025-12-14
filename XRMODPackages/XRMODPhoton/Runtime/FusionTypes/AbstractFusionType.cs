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
using UnityEngine.Events;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public abstract class AbstractFusionType<T> : BaseFusionType 
    {
        public UnityEvent<T> OnValueChanged = new();
         
        protected abstract void OnChanged();
    }
}
#endif