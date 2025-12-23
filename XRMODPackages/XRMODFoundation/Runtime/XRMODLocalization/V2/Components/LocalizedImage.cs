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
    /// Localizes a UGUI <see cref="Image"/> component by updating its <see cref="Sprite"/> in XRMOD V2.
    /// </summary>
    [RequireComponent(typeof(Image))]
    public class LocalizedImage : LocalizedAssetBase<Sprite>
    {
        [SerializeField] private Image image;

        private void Awake()
        {
            if (image == null)
                image = GetComponent<Image>();
        }

        /// <summary>
        /// Applies the loaded localized <see cref="Sprite"/> to the <see cref="Image"/> component.
        /// </summary>
        /// <param name="_asset">The localized sprite.</param>
        protected override void ApplyAsset(Sprite _asset)
        {
            if (image != null)
                image.sprite = _asset;
        }
    }
}