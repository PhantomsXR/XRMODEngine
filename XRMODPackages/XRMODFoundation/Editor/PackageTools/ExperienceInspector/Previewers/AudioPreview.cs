/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.PackageTools.Editor.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODPackageTools.Editor.Previewers
{
    public class AudioPreview : BaseAssetPreview
    {
        private bool _isPlaying = false;

        public override void DrawPreview(VisualElement container, Object asset)
        {
            if (!(asset is AudioClip audioClip)) return;

            var btnContainer = new VisualElement
            {
                style =
                {
                    flexDirection = FlexDirection.Row,
                    justifyContent = Justify.Center,
                    marginBottom = 10,
                }
            };

            var playButton = new Button(() =>
            {
                Type audioUtilType = typeof(AudioImporter).Assembly.GetType("UnityEditor.AudioUtil");
                var playClipMethod = audioUtilType.GetMethod("PlayClip",
                                         BindingFlags.Static | BindingFlags.Public, null,
                                         new Type[] {typeof(AudioClip)}, null)
                                     ?? audioUtilType.GetMethod("PlayPreviewClip",
                                         BindingFlags.Static | BindingFlags.Public, null,
                                         new Type[] {typeof(AudioClip), typeof(int), typeof(bool)}, null);
                if (!_isPlaying)
                {
                    playClipMethod.Invoke(null, new object[] {audioClip, 0, false});
                    _isPlaying = true;
                }
            })
            {
                text = $"▶ Play Audio: {audioClip.name}"
            };

            var stopButton = new Button(() =>
            {
                StopAudio();
            })
            {
                text = "■ Stop Audio"
            };

            playButton.AddToClassList("preview-button");
            stopButton.AddToClassList("preview-button");

            btnContainer.Add(playButton);
            btnContainer.Add(stopButton);
            container.Add(btnContainer);
        }

        private void StopAudio()
        {
            Type audioUtilType = typeof(AudioImporter).Assembly.GetType("UnityEditor.AudioUtil");
            var stopMethod = audioUtilType.GetMethod("StopPreviewClip",
                                 BindingFlags.Static | BindingFlags.Public, null,
                                 new Type[] {typeof(AudioClip)}, null)
                             ?? audioUtilType.GetMethod("StopAllPreviewClips",
                                 BindingFlags.Static | BindingFlags.Public);
            stopMethod?.Invoke(null, null);
            _isPlaying = false;
        }

        public override void Cleanup()
        {
            if (_isPlaying)
            {
                StopAudio();
            }
        }
    }
}
