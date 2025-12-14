// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODUtilites.Runtime.
// //
// // The VisionOSPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    public class WebCameraUpdateDirtyAdapter : MonoBehaviour
    {
#if POLYSPATIAL_ENABLE_WEBCAM && VISIONOS_INSTALL
    public WebCamTexture texture;
#endif

        void Update()
        {
#if POLYSPATIAL_ENABLE_WEBCAM && VISIONOS_INSTALL
        // Texture may be null if the web camera isn't actively recording
        // into it.
        if (texture != null &&  texture.isPlaying)
            Unity.PolySpatial.PolySpatialObjectUtils.MarkDirty(texture);
#endif
        }
    } 
}