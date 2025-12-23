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
    /// <summary>
    /// Adapter component that provides hover interaction effects, specifically for Apple VisionOS via PolySpatial.
    /// </summary>
    public class HoverEffectComponentAdapter : MonoBehaviour
    {
        /// <summary>
        /// Defines the types of hover effects available.
        /// </summary>
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

        /// <summary>
        /// The color of the hover effect.
        /// </summary>
        public BindableProperty<Color> Color = new();

        /// <summary>
        /// Multiplier for the effect's intensity.
        /// </summary>
        public BindableProperty<float> IntensityMultiplier = new();

        /// <summary>
        /// Duration of the fade-in animation.
        /// </summary>
        public BindableProperty<float> FadeInDuration = new();

        /// <summary>
        /// Duration of the fade-out animation.
        /// </summary>
        public BindableProperty<float> FadeOutDuration = new();

        /// <summary>
        /// The type of hover effect to apply.
        /// </summary>
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