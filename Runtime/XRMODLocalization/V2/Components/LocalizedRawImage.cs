/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;
using UnityEngine.UI;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Localizes a UGUI <see cref="RawImage"/> component by updating its <see cref="Texture"/> in XRMOD V2.
    /// </summary>
    [RequireComponent(typeof(RawImage))]
    public class LocalizedRawImage : LocalizedAssetBase<Texture>
    {
        [SerializeField] private RawImage rawImage;

        private void Awake()
        {
            if (rawImage == null)
                rawImage = GetComponent<RawImage>();
        }
        
        /// <summary>
        /// Applies the loaded localized <see cref="Texture"/> to the <see cref="RawImage"/> component.
        /// </summary>
        /// <param name="_asset">The localized texture.</param>
        protected override void ApplyAsset(Texture _asset)
        {
            if (rawImage != null)
                rawImage.texture = _asset;
        }
    }
}