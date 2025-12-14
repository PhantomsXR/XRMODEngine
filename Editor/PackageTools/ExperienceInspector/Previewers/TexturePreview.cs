/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.PackageTools.Editor.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.XRMODPackageTools.Editor.Previewers
{
    public class TexturePreview : BaseAssetPreview
    {
        public override void DrawPreview(VisualElement container, Object asset)
        {
            if (!(asset is Texture2D texture)) return;

            var image = new Image
            {
                image = texture,
                scaleMode = ScaleMode.ScaleToFit
            };
            image.style.height = 300;
            image.style.marginBottom = 10;
            image.style.alignSelf = Align.Center;
            container.Add(image);
        }
    }
}
