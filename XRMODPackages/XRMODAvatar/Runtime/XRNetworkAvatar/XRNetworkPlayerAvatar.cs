// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The VisionOSPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.NetcodeModule.Runtime.Gameplay;
using UnityEngine;
#if USE_XR_HAND
using Unity.XR.CoreUtils;
#endif

namespace Phantom.XRMOD.XRMODAvatar.Runtime.XR
{
    /// <summary>
    /// Represents a networked human avatar. Handles the replication of head and hand transforms 
    /// from the local player to remote clients using Unity Netcode.
    /// </summary>
    public class XRNetworkPlayerAvatar : NGOPlayerBase
    {
#if USE_XR_HAND
        [Header("Avatar Transform References"), Tooltip("Assign to local avatar transform.")]
        /// <summary>
        /// The transform representing the avatar's head. Used for tracking replication.
        /// </summary>
        public Transform head;

        /// <summary>
        /// The transform representing the avatar's left hand.
        /// </summary>
        public Transform leftHand;

        /// <summary>
        /// The transform representing the avatar's right hand.
        /// </summary>
        public Transform rightHand;


        // /// <summary>
        // /// Head Renderers to change rendering mode for local players.
        // /// </summary>
        // [SerializeField, Tooltip("Head Renderers to change rendering mode for local players.")] protected Renderer[] m_HeadRends;

        /// <summary>
        /// Array of hand objects that should be disabled on the local player to avoid obstructing the view.
        /// </summary>
        [Header("Networked Hands"), SerializeField, Tooltip("Hand Objects to be disabled for the local player.")]
        protected GameObject[] m_handsObjects;


        /// <summary>
        /// Internal references to the Local Player Transforms.
        /// </summary>
        protected Transform m_LeftHandOrigin, m_RightHandOrigin, m_HeadOrigin;

        /// <summary>
        /// Reference to the local player XR Origin
        /// </summary>
        protected XROrigin m_XROrigin;

        private UpdateBatchOptimization updateBatchOptimization;
        private Coroutine waitForRenderAvatarCoroutine;

        protected override void Awake()
        {
            base.Awake();
            updateBatchOptimization = GetComponentInParent<UpdateBatchOptimization>();
            updateBatchOptimization.RegisterUpdate(DoBatchLateUpdate);
            OnSpawned.AddListener(OnSpawnedCallback);
        }

        public override void OnNetworkDespawn()
        {
            base.OnNetworkDespawn();
            if (waitForRenderAvatarCoroutine == null) return;
            StopCoroutine(waitForRenderAvatarCoroutine);
            waitForRenderAvatarCoroutine = null;
        }

        private void OnSpawnedCallback(bool _isOwner)
        { 
            SetupPlayerAvatarRenderState();

            // Get Origin and set head.
            m_XROrigin = FindFirstObjectByType<XROrigin>();
            if (m_XROrigin != null)
            {
                m_HeadOrigin = m_XROrigin.Camera.transform;
            }
            else
            {
                Debug.Log("No XR Rig Available");
            }

            if (_isOwner) return;
            waitForRenderAvatarCoroutine = StartCoroutine(WaitToRenderAvatar());
        }

        private IEnumerator WaitToRenderAvatar()
        {
            yield return new WaitForSeconds(1);
            SetupPlayerAvatarRenderState(true);
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
            updateBatchOptimization.UnregisterUpdate(DoBatchLateUpdate);
            OnSpawned.RemoveListener(OnSpawnedCallback);
        }


        ///<inheritdoc/>
        protected virtual void DoBatchLateUpdate()
        {
            if (!IsOwner) return;

            // Set transforms to be replicated with ClientNetworkTransforms
            if (leftHand)
                leftHand.SetPositionAndRotation(m_LeftHandOrigin.position, m_LeftHandOrigin.rotation);
            if (rightHand)
                rightHand.SetPositionAndRotation(m_RightHandOrigin.position, m_RightHandOrigin.rotation);
            head.SetPositionAndRotation(m_HeadOrigin.position, m_HeadOrigin.rotation);
        }

        /// <summary>
        /// Updates the local hand origins used for transform replication.
        /// This is typically called from the <see cref="NetworkXRHandPoseReplicator"/> when switching input modes.
        /// </summary>
        /// <param name="_left">The transform of the local left hand source.</param>
        /// <param name="_right">The transform of the local right hand source.</param>
        public void SetHandOrigins(Transform _left, Transform _right)
        {
            m_LeftHandOrigin = _left;
            m_RightHandOrigin = _right;
        }

        /// <summary>
        /// Configures the visibility of avatar parts based on whether it is the local player.
        /// Local players usually see their own hands but not their own head/body to prevent clipping.
        /// </summary>
        /// <param name="_renderState">True to show parts, False to hide.</param>
        protected virtual void SetupPlayerAvatarRenderState(bool _renderState = false)
        {
            var tmp_AvatarVisualizer = GetComponent<AvatarVisualizer>();
            if (!tmp_AvatarVisualizer) return;
            tmp_AvatarVisualizer.SetAvatarPartsVisualizer(_renderState);
            tmp_AvatarVisualizer.SetHandsVisualizer(_renderState);
            tmp_AvatarVisualizer.SetHeadTrackVisualizer(_renderState);
        }
#endif
    }
}