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
    public class VideoComponentAdapter : MonoBehaviour
    {
        [SerializeField] private MeshRenderer targetMaterialRenderer;
        [SerializeField] private VideoClip clip;
        [SerializeField] private bool isLooping = true;
        [SerializeField] private bool playOnAwake = true;
        [SerializeField] private bool mute;
        [SerializeField] private float volume = 1;

        public BindableProperty<MeshRenderer> TargetMaterialRenderer = new();
        public BindableProperty<VideoClip> Clip = new();
        public BindableProperty<bool> IsLooping = new();
        public BindableProperty<bool> PlayOnAwake = new();
        public BindableProperty<bool> Mute = new();
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