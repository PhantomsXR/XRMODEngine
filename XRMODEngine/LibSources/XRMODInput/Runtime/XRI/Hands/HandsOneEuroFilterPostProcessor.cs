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
#if USE_XRI && XR_HANDS_1_1_OR_NEWER

#if XR_HANDS_1_2_OR_NEWER
using System.Collections.Generic;
using UnityEngine.XR.Hands;
using UnityEngine.XR.Hands.Processing;
using UnityEngine;
#endif

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// A post processor for XR hand tracking data, using the One Euro filter to smooth hand positions.
    /// </summary>
#if XR_HANDS_1_2_OR_NEWER
    public class HandsOneEuroFilterPostProcessor : MonoBehaviour, IXRHandProcessor
#else
    public class HandsOneEuroFilterPostProcessor : MonoBehaviour
#endif
    {
        [SerializeField] [Tooltip("Smoothing amount at low speeds.")]
        float filterMinCutoff = 0.1f;

        [SerializeField] [Tooltip("Filter's responsiveness to speed changes.")]
        float filterBeta = 0.2f;

#if XR_HANDS_1_2_OR_NEWER
        /// <inheritdoc />
        public int callbackOrder => 0;

        readonly OneEuroFilterVector3 leftHandFilter = new OneEuroFilterVector3(Vector3.zero);
        readonly OneEuroFilterVector3 rightHandFilter = new OneEuroFilterVector3(Vector3.zero);

        bool wasLeftHandTrackedLastFrame;
        bool wasRightHandTrackedLastFrame;

        XRHandSubsystem subsystem;
        static readonly List<XRHandSubsystem> subsystemsReuse = new List<XRHandSubsystem>();
#endif

#if XR_HANDS_1_2_OR_NEWER
        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        void OnDisable()
        {
            if (subsystem == null) return;
            subsystem.UnregisterProcessor(this);
            subsystem = null;
        }

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        void Update()
        {
            if (subsystem != null && subsystem.running)
                return;

            SubsystemManager.GetSubsystems(subsystemsReuse);
            var tmp_FoundRunningHandSubsystem = false;
            for (var i = 0; i < subsystemsReuse.Count; ++i)
            {
                var handSubsystem = subsystemsReuse[i];
                if (handSubsystem.running)
                {
                    subsystem?.UnregisterProcessor(this);
                    subsystem = handSubsystem;
                    tmp_FoundRunningHandSubsystem = true;
                    break;
                }
            }

            if (!tmp_FoundRunningHandSubsystem)
                return;

            wasLeftHandTrackedLastFrame = false;
            wasRightHandTrackedLastFrame = false;
            subsystem.RegisterProcessor(this);
        }

        /// <inheritdoc />
        public void ProcessJoints(XRHandSubsystem _subsystem, XRHandSubsystem.UpdateSuccessFlags _successFlags,
            XRHandSubsystem.UpdateType _updateType)
        {
            var tmp_LeftHand = _subsystem.leftHand;
            if (tmp_LeftHand.isTracked)
            {
                var tmp_LeftHandPose = tmp_LeftHand.rootPose;
                if (!wasLeftHandTrackedLastFrame)
                {
                    leftHandFilter.Initialize(tmp_LeftHandPose.position);
                }
                else
                {
                    var tmp_NewLeftPosition = leftHandFilter.Filter(tmp_LeftHandPose.position, Time.deltaTime,
                        filterMinCutoff, filterBeta);
                    var tmp_NewLeftPose = new Pose(tmp_NewLeftPosition, tmp_LeftHandPose.rotation);

                    tmp_LeftHand.SetRootPose(tmp_NewLeftPose);
                    _subsystem.SetCorrespondingHand(tmp_LeftHand);
                }
            }

            wasLeftHandTrackedLastFrame = tmp_LeftHand.isTracked;

            var tmp_RightHand = _subsystem.rightHand;
            if (tmp_RightHand.isTracked)
            {
                var tmp_RightHandPose = tmp_RightHand.rootPose;
                if (!wasRightHandTrackedLastFrame)
                {
                    rightHandFilter.Initialize(tmp_RightHandPose.position);
                }
                else
                {
                    var tmp_NewRightPosition = rightHandFilter.Filter(tmp_RightHandPose.position, Time.deltaTime,
                        filterMinCutoff, filterBeta);
                    var tmp_NewRightPose = new Pose(tmp_NewRightPosition, tmp_RightHandPose.rotation);

                    tmp_RightHand.SetRootPose(tmp_NewRightPose);
                    _subsystem.SetCorrespondingHand(tmp_RightHand);
                }
            }

            wasRightHandTrackedLastFrame = tmp_RightHand.isTracked;
        }
#else
        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        void Awake()
        {
            Debug.LogWarning("HandsOneEuroFilterPostProcessor requires XR Hands (com.unity.xr.hands) 1.2.0 or newer. Disabling component.", this);
            enabled = false;
        }
#endif
    }
}

#endif