// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UXCore.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if USE_XRI

using UnityEngine;
using Unity.Mathematics;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// Affordance receiver applying a Vector3 (Float3) affordance theme to a Transform local position.
    /// Broadcasts new affordance value with Unity Event.
    /// </summary>
    [AddComponentMenu("Affordance System/Receiver/Transformation/Local Position Offset Affordance Receiver", 12)]
    public class LocalPositionOffsetAffordanceReceiver : Vector3AffordanceReceiver
    {
        [SerializeField] [Tooltip("Transform on which to apply a local translation value.")]
        Transform transformToTranslate;

        /// <summary>
        /// Transform on which to apply a local translation value.
        /// </summary>
        public Transform TransformToTranslate
        {
            get => transformToTranslate;
            set
            {
                transformToTranslate = value;
                hasTransformToTranslate = transformToTranslate != null;
            }
        }

        bool hasTransformToTranslate;
        float3 initialOffset = float3.zero;

        /// <inheritdoc/>
        protected override void OnEnable()
        {
            base.OnEnable();
            hasTransformToTranslate = transformToTranslate != null;
        }

        /// <inheritdoc/>
        protected override float3 GetCurrentValueForCapture()
        {
            if (hasTransformToTranslate)
            {
                initialOffset = transformToTranslate.localPosition;
            }

            return float3.zero;
        }

        /// <inheritdoc/>
        protected override void OnAffordanceValueUpdated(float3 newValue)
        {
            if (hasTransformToTranslate)
            {
                transformToTranslate.localPosition = initialOffset + newValue;
            }

            base.OnAffordanceValueUpdated(newValue);
        }

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        void OnValidate()
        {
            if (transformToTranslate == null)
                transformToTranslate = transform;
        }
    }
}

#endif