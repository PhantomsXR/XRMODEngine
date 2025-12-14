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
#if USE_XRI && XR_PLATFORM

using Unity.Mathematics;
using Unity.XR.CoreUtils.Bindings;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

namespace Phantom.XRMOD.XRMODInput.Runtime
{ 
    public class XRPokeFollowAffordance : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("Transform that will move in the poke direction when this or a parent GameObject is poked." +
                 "\nNote: Should be a direct child GameObject.")]
        Transform pokeFollowTransform;

        /// <summary>
        /// Transform that will animate along the axis of interaction when this interactable is poked.
        /// Note: Must be a direct child GameObject as it moves in local space relative to the poke target's transform.
        /// </summary>
        public Transform PokeFollowTransform
        {
            get => pokeFollowTransform;
            set => pokeFollowTransform = value;
        }

        [SerializeField]
        [Range(0f, 20f)]
        [Tooltip(
            "Multiplies transform position interpolation as a factor of Time.deltaTime. If 0, no smoothing will be applied.")]
        float smoothingSpeed = 16f;

        /// <summary>
        /// Multiplies transform position interpolation as a factor of <see cref="Time.deltaTime"/>. If <c>0</c>, no smoothing will be applied.
        /// </summary>
        public float SmoothingSpeed
        {
            get => smoothingSpeed;
            set => smoothingSpeed = value;
        }

        [SerializeField]
        [Tooltip(
            "When this component is no longer the target of the poke, the Poke Follow Transform returns to the original position.")]
        bool returnToInitialPosition = true;

        /// <summary>
        /// When this component is no longer the target of the poke, the <see cref="PokeFollowTransform"/> returns to the original position.
        /// </summary>
        public bool ReturnToInitialPosition
        {
            get => returnToInitialPosition;
            set => returnToInitialPosition = value;
        }

        [SerializeField]
        [Tooltip("Whether to apply the follow animation if the target of the poke is a child of this transform. " +
                 "This is useful for UI objects that may have child graphics.")]
        bool applyIfChildIsTarget = true;

        /// <summary>
        /// Whether to apply the follow animation if the target of the poke is a child of this transform.
        /// This is useful for UI objects that may have child graphics.
        /// </summary>
        public bool ApplyIfChildIsTarget
        {
            get => applyIfChildIsTarget;
            set => applyIfChildIsTarget = value;
        }

        [SerializeField]
        [Tooltip("Whether to keep the Poke Follow Transform from moving past a maximum distance from the poke target.")]
        bool clampToMaxDistance;

        /// <summary>
        /// Whether to keep the <see cref="PokeFollowTransform"/> from moving past <see cref="MaxDistance"/> from the poke target.
        /// </summary>
        public bool ClampToMaxDistance
        {
            get => clampToMaxDistance;
            set => clampToMaxDistance = value;
        }

        [FormerlySerializedAs("m_MaxDistance")]
        [SerializeField]
        [Tooltip("The maximum distance from this transform that the Poke Follow Transform can move.")]
        float maxDistance;

        /// <summary>
        /// The maximum distance from this transform that the <see cref="PokeFollowTransform"/> can move when
        /// <see cref="ClampToMaxDistance"/> is <see langword="true"/>.
        /// </summary>
        public float MaxDistance
        {
            get => maxDistance;
            set => maxDistance = value;
        }

        /// <summary>
        /// The original position of this interactable before any pushes have been applied.
        /// </summary>
        public Vector3 InitialPosition
        {
            get => initialPosition;
            set => initialPosition = value;
        }

        IPokeStateDataProvider pokeDataProvider;
        IMultiPokeStateDataProvider multiPokeStateDataProvider;

        readonly Vector3TweenableVariable transformTweenableVariable = new();
        readonly BindingsGroup bindingsGroup = new();
        Vector3 initialPosition;
        bool isFirstFrame;

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        protected void Awake()
        {
            multiPokeStateDataProvider = GetComponentInParent<IMultiPokeStateDataProvider>();
            if (multiPokeStateDataProvider == null)
                pokeDataProvider = GetComponentInParent<IPokeStateDataProvider>();
        }

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        protected void Start()
        {
            if (pokeFollowTransform != null)
            {
                initialPosition = pokeFollowTransform.localPosition;
                bindingsGroup.AddBinding(transformTweenableVariable.Subscribe(OnTransformTweenableVariableUpdated));

                if (multiPokeStateDataProvider != null)
                    bindingsGroup.AddBinding(multiPokeStateDataProvider.GetPokeStateDataForTarget(transform)
                        .Subscribe(OnPokeStateDataUpdated));
                else if (pokeDataProvider != null)
                    bindingsGroup.AddBinding(
                        pokeDataProvider.pokeStateData.SubscribeAndUpdate(OnPokeStateDataUpdated));
            }
            else
            {
                enabled = false;
                Debug.LogWarning($"Missing Poke Follow Transform assignment on {this}. Disabling component.", this);
            }
        }

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        protected void OnDestroy()
        {
            bindingsGroup.Clear();
            transformTweenableVariable?.Dispose();
        }

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        protected void LateUpdate()
        {
            if (isFirstFrame)
            {
                transformTweenableVariable.HandleTween(1f);
                isFirstFrame = false;
                return;
            }

            transformTweenableVariable.HandleTween(smoothingSpeed > 0f ? Time.deltaTime * smoothingSpeed : 1f);
        }

        void OnTransformTweenableVariableUpdated(float3 position)
        {
            pokeFollowTransform.localPosition = position;
        }

        void OnPokeStateDataUpdated(PokeStateData data)
        {
            var tmp_PokeTarget = data.target;
            var tmp_ApplyFollow = applyIfChildIsTarget
                ? tmp_PokeTarget != null && tmp_PokeTarget.IsChildOf(transform)
                : tmp_PokeTarget == transform;

            if (tmp_ApplyFollow)
            {
                var tmp_TargetPosition = tmp_PokeTarget.InverseTransformPoint(data.axisAlignedPokeInteractionPoint);
                if (clampToMaxDistance && tmp_TargetPosition.sqrMagnitude > maxDistance * maxDistance)
                    tmp_TargetPosition = Vector3.ClampMagnitude(tmp_TargetPosition, maxDistance);

                transformTweenableVariable.target = tmp_TargetPosition;
            }
            else if (returnToInitialPosition)
            {
                transformTweenableVariable.target = initialPosition;
            }
        }

        public void ResetFollowTransform()
        {
            if (!clampToMaxDistance || pokeFollowTransform == null)
                return;

            pokeFollowTransform.localPosition = initialPosition;
        }
    }
}

#endif