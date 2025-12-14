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
    public class TextPreview : BaseAssetPreview
    {
        public override void DrawPreview(VisualElement container, Object asset)
        {
            if (!(asset is TextAsset textAsset)) return;

            var textElement = new Label(textAsset.text)
            {
                style =
                {
                    whiteSpace = WhiteSpace.Normal,
                    unityFontStyleAndWeight = FontStyle.Normal,
                    marginBottom = 10
                }
            };
            textElement.AddToClassList("preview-text");
            container.Add(textElement);
        }
    }
}
