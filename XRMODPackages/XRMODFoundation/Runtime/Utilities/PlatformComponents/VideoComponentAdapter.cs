// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODUtilites.Runtime.
// //
// // The UnityVisionOSLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.Video;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    /// <summary>
    /// Adapter component that adds and manages a video playback component, specifically for Apple VisionOS via PolySpatial.
    /// Allows playing video clips on a target material renderer in spatial environments.
    /// </summary>
    public class VideoComponentAdapter : MonoBehaviour
    {
        [SerializeField] private MeshRenderer targetMaterialRenderer;
        [SerializeField] private VideoClip clip;
        [SerializeField] private bool isLooping = true;
        [SerializeField] private bool playOnAwake = true;
        [SerializeField] private bool mute;
        [SerializeField] private float volume = 1;

        /// <summary>
        /// The renderer whose material will display the video.
        /// </summary>
        public BindableProperty<MeshRenderer> TargetMaterialRenderer = new();

        /// <summary>
        /// The video clip to be played.
        /// </summary>
        public BindableProperty<VideoClip> Clip = new();

        /// <summary>
        /// Whether the video should loop after finishing.
        /// </summary>
        public BindableProperty<bool> IsLooping = new();

        /// <summary>
        /// Whether the video should start playing as soon as it awakes.
        /// </summary>
        public BindableProperty<bool> PlayOnAwake = new();

        /// <summary>
        /// Whether the audio should be muted.
        /// </summary>
        public BindableProperty<bool> Mute = new();

        /// <summary>
        /// The volume level of the video audio (0 to 1).
        /// </summary>
        public BindableProperty<float> Volume = new();


#if VISIONOS_INSTALL
        private Unity.PolySpatial.VisionOSVideoComponent visionOSVideoComponent;


        private void Start()
        {
            visionOSVideoComponent = gameObject.AddComponent<Unity.PolySpatial.VisionOSVideoComponent>();

            TargetMaterialRenderer.OnValueChanged = _value =>
            {
                visionOSVideoComponent.TargetMaterialRenderer = _value;
            };
            Clip.OnValueChanged = _videoClip => { visionOSVideoComponent.Clip = _videoClip; };
            IsLooping.OnValueChanged = _isLooping => { visionOSVideoComponent.IsLooping = _isLooping; };
            PlayOnAwake.OnValueChanged = _playOnAwake => { visionOSVideoComponent.PlayOnAwake = _playOnAwake; };
            Mute.OnValueChanged = _mute => { visionOSVideoComponent.SetDirectAudioMute(0, _mute); };
            Volume.OnValueChanged = _volume => { visionOSVideoComponent.SetDirectAudioVolume(0, _volume); };


            TargetMaterialRenderer.Value = targetMaterialRenderer;
            Clip.Value = clip;
            IsLooping.Value = isLooping;
            PlayOnAwake.Value = playOnAwake;
            Mute.Value = mute;
            Volume.Value = volume;
        }

        private void OnEnable()
        {
            if (visionOSVideoComponent)
            {
                visionOSVideoComponent.enabled = true;
            }
        }

        private void OnDisable()
        {
            if (visionOSVideoComponent)
            {
                visionOSVideoComponent.enabled = false;
            }
        }
#endif
    }
}