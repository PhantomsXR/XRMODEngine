/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;
using UnityEngine.Video;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Localizes a <see cref="VideoPlayer"/> component by updating its <see cref="VideoClip"/> in XRMOD V2.
    /// </summary>
    [RequireComponent(typeof(VideoPlayer))]
    public class LocalizedVideo : LocalizedAssetBase<VideoClip>
    {
        [SerializeField] private VideoPlayer videoPlayer;

        private void Awake()
        {
            if (videoPlayer == null)
                videoPlayer = GetComponent<VideoPlayer>();
        }

        /// <summary>
        /// Applies the loaded localized <see cref="VideoClip"/> to the <see cref="VideoPlayer"/> and starts playback.
        /// </summary>
        /// <param name="_asset">The localized video clip.</param>
        protected override void ApplyAsset(VideoClip _asset)
        {
            if (videoPlayer == null) return;
            videoPlayer.clip = _asset;
            videoPlayer.Play();
        }
    }
}