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
 
using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    public class GroundShadowComponentAdapter : MonoBehaviour
    {
#if VISIONOS_INSTALL

        private Unity.PolySpatial.VisionOSGroundingShadow visionOSGroundingShadow;

        private void Start()
        {
            visionOSGroundingShadow = gameObject.AddComponent<Unity.PolySpatial.VisionOSGroundingShadow>();
        }

        private void OnEnable()
        {
            if (visionOSGroundingShadow)
                visionOSGroundingShadow.enabled = true;
        }

        private void OnDisable()
        {
            if (visionOSGroundingShadow)
                visionOSGroundingShadow.enabled = false;
        }
#endif
    }
}