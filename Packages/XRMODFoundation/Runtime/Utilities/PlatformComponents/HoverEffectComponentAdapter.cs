// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODUtilites.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
 
using Phantom.XRMOD.Core.Runtime;
using UnityEngine; 

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    public class HoverEffectComponentAdapter : MonoBehaviour
    {
        public enum HoverEffectType : int
        {
            /// <summary>
            /// A hover effect that shows a spotlight around the hovered position.
            /// </summary>
            Spotlight,

            /// <summary>
            /// A hover effect that shows a spotlight plus a uniform highlight.
            /// </summary>
            Highlight,

            /// <summary>
            /// A hover effect driven by a shader.
            /// </summary>
            Shader,
        }

        private Color color;
        private float intensityMultiplier;
        private float fadeInDuration;
        private float fadeOutDuration;
        private HoverEffectType effectType;

        public BindableProperty<Color> Color = new();
        public BindableProperty<float> IntensityMultiplier = new();
        public BindableProperty<float> FadeInDuration = new();
        public BindableProperty<float> FadeOutDuration = new();
        public BindableProperty<HoverEffectType> EffectType = new();


#if VISIONOS_INSTALL

        private Unity.PolySpatial.VisionOSHoverEffect hoverEffect;

        private void Start()
        {
            hoverEffect = gameObject.AddComponent<Unity.PolySpatial.VisionOSHoverEffect>();
            IntensityMultiplier.OnValueChanged = _value => { hoverEffect.IntensityMultiplier = _value; };
            EffectType.OnValueChanged = _value =>
            {
                hoverEffect.Type = (Unity.PolySpatial.VisionOSHoverEffect.EffectType) _value;
            };
            Color.OnValueChanged = _value => { hoverEffect.Color = _value; };
            FadeInDuration.OnValueChanged = _value => { hoverEffect.FadeInDuration = _value; };
            FadeOutDuration.OnValueChanged = _value => { hoverEffect.FadeOutDuration = _value; };
        }

        private void OnEnable()
        {
            if (hoverEffect)
                hoverEffect.enabled = true;
        }

        private void OnDisable()
        {
            if (hoverEffect)
                hoverEffect.enabled = false;
        }
#endif
    }
}