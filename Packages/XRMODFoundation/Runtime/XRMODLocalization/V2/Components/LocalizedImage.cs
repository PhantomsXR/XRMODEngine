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

using UnityEngine;
using UnityEngine.UI;

namespace Phantom.XRMOD.Localization.Runtime
{
    public class LocalizedImage : LocalizedAssetBase<Sprite>
    {
        [SerializeField] private Image image;

        private void Awake()
        {
            if (image == null)
                image = GetComponent<Image>();
        }

        
        protected override void ApplyAsset(Sprite _asset)
        {
            if (image != null)
                image.sprite = _asset;
        }
    }
}