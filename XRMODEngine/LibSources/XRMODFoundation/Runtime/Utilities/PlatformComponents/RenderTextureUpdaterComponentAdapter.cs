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

using System;
using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    public class RenderTextureUpdaterComponentAdapter : MonoBehaviour
    {
        [SerializeField] private RenderTexture renderTexture;
        public RenderTexture RenderTexture
        {
            get => renderTexture;

            set => renderTexture = value;
        }
#if VISIONOS_INSTALL
        private void Start()
        {
            if (renderTexture == null)
                renderTexture = GetComponent<MeshRenderer>().material.mainTexture as RenderTexture;
        }


        void Update()
        {
            if (renderTexture)
                Unity.PolySpatial.PolySpatialObjectUtils.MarkDirty(renderTexture);
        }
#endif
    }
}