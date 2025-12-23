// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODUtilites.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Core.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    /// <summary>
    /// Adapter component that adds and manages a billboard effect, specifically for Apple VisionOS via PolySpatial.
    /// </summary>
    public class BillboardComponentAdapter : MonoBehaviour
    {
        [SerializeField] private float blendFactor;

        /// <summary>
        /// The blend factor for the billboard effect.
        /// </summary>
        public BindableProperty<float> BlendFactor = new();

#if VISIONOS_INSTALL
        private Unity.PolySpatial.VisionOSBillboard visionOSBillboard;


        private void Start()
        {
             visionOSBillboard = gameObject.AddComponent<Unity.PolySpatial.VisionOSBillboard>();
            BlendFactor.OnValueChanged = _value => { visionOSBillboard.BlendFactor = _value; };
            BlendFactor.Value = blendFactor;
        }

        private void OnEnable()
        {
            if (visionOSBillboard)
            {
                visionOSBillboard.enabled = true;
            }
        }

        private void OnDisable()
        {
            if (visionOSBillboard)
            {
                visionOSBillboard.enabled = false;
            }
        }
#endif
    }
}