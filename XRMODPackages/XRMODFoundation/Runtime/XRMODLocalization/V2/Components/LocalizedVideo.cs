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
using UnityEngine.Video;

namespace Phantom.XRMOD.Localization.Runtime
{
    public class LocalizedVideo : LocalizedAssetBase<VideoClip>
    {
        [SerializeField] private VideoPlayer videoPlayer;

        private void Awake()
        {
            if (videoPlayer == null)
                videoPlayer = GetComponent<VideoPlayer>();
        }

        protected override void ApplyAsset(VideoClip _asset)
        {
            if (videoPlayer == null) return;
            videoPlayer.clip = _asset;
            videoPlayer.Play();
        }
    }
}