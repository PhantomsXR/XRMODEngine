/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.PackageTools.Editor.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;
using UnityEngine.Video;

namespace Phantom.XRMOD.XRMODPackageTools.Editor.Previewers
{
    public static class AssetPreviewFactory
    {
        public static IAssetPreview CreatePreview(Object asset)
        {
            switch (asset)
            {
                case GameObject:
                case Material:
                    return new GameObjectPreview();
                case AudioClip:
                    return new AudioPreview();
                case Texture2D:
                    return new TexturePreview();
                case TextAsset:
                    return new TextPreview();
                case VideoClip:
                    // For now, VideoClip just shows a label in the original code, 
                    // but we can make a simple previewer or just return null to handle default.
                    // Let's implement a simple one inline or separate if needed.
                    // For simplicity, we can treat it as a special case or add a GenericLabelPreview.
                    return null; 
                default:
                    return null;
            }
        }
    }
}
