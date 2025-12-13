// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the StackAR.Runtime.
// //
// // The AVPPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/


using System;
using UnityEngine;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    [Obsolete("This component has been deprecated.", true)]
    public class VisionOSRenderTextureUpdater : MonoBehaviour
    {
        [SerializeField] private RenderTexture texture;

        private void Start()
        {
            if (texture == null)
                texture = GetComponent<MeshRenderer>().material.mainTexture as RenderTexture;
        }

        void Update()
        {
            if (texture)
                Unity.PolySpatial.PolySpatialObjectUtils.MarkDirty(texture);
        }
    }
}