// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Localization.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    public class LocalizedRendererTexture : LocalizedAssetBase<Texture>
    {
        [SerializeField] private Renderer targetRenderer;

        private void Awake()
        {
            if (targetRenderer == null)
                targetRenderer = GetComponent<Renderer>();
        }

        protected override void ApplyAsset(Texture _asset)
        {
            if (targetRenderer != null)
                targetRenderer.material.mainTexture = _asset;
        }
    }
}