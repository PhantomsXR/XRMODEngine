// /*===============================================================================
// Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
//
// This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
//
// The VisionOSPlatform cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
//
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Serialization;
#if USE_XR_HAND
using Unity.XR.CoreUtils;
using UnityEngine.XR.Hands;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

#endif

namespace Phantom.XRMOD.XRMODAvatar.Runtime.XR
{
    /// <summary>
    /// Replicates XR hand poses and controller input across a network using Unity Netcode.
    /// This class supports different levels of fidelity for hand tracking and can switch
    /// between tracked hand and motion controller input modes to animate an avatar's hands.
    /// </summary>
    public class NetworkXRHandPoseReplicator : NetworkBehaviour
    {
#if USE_XR_HAND && USE_XRI && (QUEST_INSTALL || PICO_INSTALL || ROKID_INSTALL || ANDROID_XR_INSTALL)
        /// <summary>
        /// Determines the level of detail for hand tracking replication.
        /// <list type="bullet">
        /// <item><description>0: High fidelity (all finger joint rotations).</description></item>
        /// <item><description>1: Medium fidelity (average finger curl per finger).</description></item>
        /// <item><description>2: Low fidelity (average finger curl for thumb, index, and combined other fingers).</description></item>
        /// </list>
        /// </summary>
        [FormerlySerializedAs("m_FidelityLevel")]
        [Header("Hands and Fingers"), Tooltip("0 is highest, 2 is lowest")]
        [Range(0, 2), SerializeField]
        int fidelityLevel;

        /// <summary>
        /// The minimum value threshold for updating finger rotations or curls.
        /// This helps reduce network traffic by only sending updates when changes are significant.
        /// </summary>
        [FormerlySerializedAs("m_MinUpdateDelta")]
        [SerializeField, Tooltip("Determines minimum value threshold for updating finger rotations")]
        float minUpdateDelta = .1f;

        /// <summary>
        /// An array of <see cref="JointBasedHandForAvatar"/> components, used to animate the avatar's hands
        /// based on the replicated hand tracking or controller input data.
        /// </summary>
        [FormerlySerializedAs("m_HandCurler")] [SerializeField]
        JointBasedHandForAvatar[] handCurler;

        /// <summary>
        /// The interpolation speed used when applying received finger rotations or curls to the avatar's hands.
        /// </summary>
        [FormerlySerializedAs("m_FingerLerpSpeed")] [SerializeField]
        float fingerLerpSpeed = 20.0f;

        /// <summary>
        /// If true, the owner of this network object will also update their local hands
        /// based on the networked data. This can be useful for ensuring visual consistency.
        /// </summary>
        [FormerlySerializedAs("m_UpdateHandsLocally")] [SerializeField]
        bool updateHandsLocally;

        /// <summary>
        /// An array of <see cref="Vector3"/> representing the local position offsets
        /// to apply to the avatar's hands when using motion controllers.
        /// </summary>
        [FormerlySerializedAs("m_HandControllerOffsets")] [Header("Offsets")] [SerializeField]
        Vector3[] handControllerOffsets;

        /// <summary>
        /// An array of <see cref="Vector3"/> representing the local Euler angle offsets
        /// to apply to the avatar's hands when using motion controllers.
        /// </summary>
        [FormerlySerializedAs("m_HandControllerEulerOffsets")] [SerializeField]
        Vector3[] handControllerEulerOffsets;

        HandFidelityOption[] localHandFidelityOptions;

        /// <summary>
        /// Gets the current input modality being tracked (e.g., TrackedHand or MotionController).
        /// This value is synchronized across the network.
        /// </summary>
        public XRInputModalityManager.InputMode TrackingType => trackingType.Value;

        readonly NetworkVariable<XRInputModalityManager.InputMode> trackingType =
            new(XRInputModalityManager.InputMode.None, NetworkVariableReadPermission.Everyone,
                NetworkVariableWritePermission.Owner);

        XRInputModalityManager xRModalityManager;
        XROrigin xROrigin;

        Transform leftHandTransformReference;
        Transform rightHandTransformReference;

        Transform leftControllerTransformReference;
        Transform rightControllerTransformReference;

        InputAction[] gripInputProperties;
        InputAction[] triggerInputProperties;
        InputAction[] thumbTouchProperties;

        NetworkList<Vector3> fingerRotationsLeft;
        NetworkList<Vector3> fingerRotationsRight;

        NetworkList<float> fingerCurlLeft;
        NetworkList<float> fingerCurlRight;

        NetworkVariable<bool> isInitialized = new NetworkVariable<bool>(false, NetworkVariableReadPermission.Everyone,
            NetworkVariableWritePermission.Owner);

        Pose[] handTrackedStartPose = new Pose[2];

        /// <summary>
        /// Internal reference to the active local player's left hand origin transform.
        /// This will be either the tracked hand's root or the controller's transform.
        /// </summary>
        protected Transform leftHandOrigin;

        /// <summary>
        /// Internal reference to the active local player's right hand origin transform.
        /// This will be either the tracked hand's root or the controller's transform.
        /// </summary>
        protected Transform rightHandOrigin;

        /// <summary>
        /// Called when the script instance is being loaded.
        /// Initializes the NetworkList instances for finger rotations and curls,
        /// and stores the initial local poses of the hand curler components.
        /// </summary>
        private void Awake()
        {
            fingerRotationsLeft = new NetworkList<Vector3>(new List<Vector3>(),
                NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
            fingerRotationsRight = new NetworkList<Vector3>(new List<Vector3>(),
                NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

            fingerCurlLeft = new NetworkList<float>(new List<float>(), NetworkVariableReadPermission.Everyone,
                NetworkVariableWritePermission.Owner);
            fingerCurlRight = new NetworkList<float>(new List<float>(), NetworkVariableReadPermission.Everyone,
                NetworkVariableWritePermission.Owner);

            BuildXRControllerInputAction();

            for (int tmp_I = 0; tmp_I < handCurler.Length; tmp_I++)
            {
                handTrackedStartPose[tmp_I].position = handCurler[tmp_I].transform.localPosition;
                handTrackedStartPose[tmp_I].rotation = handCurler[tmp_I].transform.localRotation;
            }
        }

        /// <summary>
        /// Retrieves and assigns the necessary XR controller input actions from the <see cref="InputActionManager"/>.
        /// </summary>
        private void BuildXRControllerInputAction()
        {
            var tmp_XriDefaultInputActionMap = FindFirstObjectByType<InputActionManager>().actionAssets[0];
            if (tmp_XriDefaultInputActionMap == null) return;
            var tmp_LeftController = tmp_XriDefaultInputActionMap.FindActionMap("XRI Left Interaction");
            var tmp_RightController = tmp_XriDefaultInputActionMap.FindActionMap("XRI Right Interaction");

            if (tmp_LeftController == null || tmp_RightController == null) return;

            triggerInputProperties = new[]
            {
                tmp_LeftController.FindAction("Activate Value", true),
                tmp_RightController.FindAction("Activate Value", true),
            };

            gripInputProperties = new[]
            {
                tmp_LeftController.FindAction("Select Value", true),
                tmp_RightController.FindAction("Select Value", true),
            };

            var tmp_ThumbLeftController = tmp_XriDefaultInputActionMap.FindActionMap("LeftController", true);
            var tmp_ThumbRightController = tmp_XriDefaultInputActionMap.FindActionMap("RightController", true);
            thumbTouchProperties = new[]
            {
                tmp_ThumbLeftController.FindAction("ThumbTouched", true),
                tmp_ThumbRightController.FindAction("ThumbTouched", true),
            };
        }

        /// <summary>
        /// Called when the object becomes enabled and active.
        /// Subscribes to the <see cref="trackingType"/>'s <see cref="NetworkVariable{T}.OnValueChanged"/> event.
        /// </summary>
        private void OnEnable()
        {
            trackingType.OnValueChanged += UpdateTrackingType;
        }

        /// <summary>
        /// Called when the object becomes disabled or inactive.
        /// Unsubscribes from the <see cref="trackingType"/>'s <see cref="NetworkVariable{T}.OnValueChanged"/> event.
        /// </summary>
        private void OnDisable()
        {
            trackingType.OnValueChanged -= UpdateTrackingType;
        }

        /// <summary>
        /// Called when the MonoBehaviour will be destroyed.
        /// Cleans up event listeners for modality changes if this is the owner.
        /// </summary>
        public override void OnDestroy()
        {
            base.OnDestroy();
            if (IsOwner)
            {
                xRModalityManager.trackedHandModeStarted.RemoveListener(SwapToHands);
                xRModalityManager.motionControllerModeStarted.RemoveListener(SwapToControllers);
            }
        }

        /// <summary>
        /// Called once per frame.
        /// Synchronizes hand or controller data based on the current <see cref="TrackingType"/>
        /// and <see cref="fidelityLevel"/> if initialized and connected to the network.
        /// </summary>
        private void Update()
        {
            if (!isInitialized.Value || !NetworkManager.IsConnectedClient ||
                NetworkManager.ShutdownInProgress) return;

            if (TrackingType == XRInputModalityManager.InputMode.TrackedHand)
            {
                switch (fidelityLevel)
                {
                    case 0:
                        SyncAllFingerData();
                        break;
                    case 1:
                        SyncFingerCurl();
                        break;
                    case 2:
                        SyncFingerCurlLimited();
                        break;
                }
            }
            else
            {
                SyncControllerTracking();
            }
        }

        /// <summary>
        /// Called when the network object is spawned.
        /// If this is the owner, it finds and sets up local XR components and finger references.
        /// Otherwise, it changes the controller type based on the synchronized tracking type.
        /// </summary>
        public override void OnNetworkSpawn()
        {
            base.OnNetworkSpawn();

            if (IsOwner)
            {
                xROrigin = FindFirstObjectByType<XROrigin>();
                if (xROrigin.TryGetComponent(out xRModalityManager))
                {
                    SetupLocalHands();
                }

                SetupLocalFingerReferences();
            }
            else
            {
                ChangeControllerType(trackingType.Value);
            }
        }

        /// <summary>
        /// Callback method invoked when the <see cref="trackingType"/> NetworkVariable changes.
        /// Triggers a change in the controller type based on the new value.
        /// </summary>
        /// <param name="_old">The previous <see cref="XRInputModalityManager.InputMode"/> value.</param>
        /// <param name="_current">The current <see cref="XRInputModalityManager.InputMode"/> value.</param>
        void UpdateTrackingType(XRInputModalityManager.InputMode _old, XRInputModalityManager.InputMode _current)
        {
            ChangeControllerType(_current);
        }

        /// <summary>
        /// Initializes references to local XR hands and controllers.
        /// Sets up listeners for modality changes (tracked hand to controller and vice-versa).
        /// If hands are not set up on the rig, it defaults to motion controller tracking.
        /// </summary>
        void SetupLocalHands()
        {
            if (xRModalityManager.leftController)
                leftControllerTransformReference = xRModalityManager.leftController.transform;
            if (xRModalityManager.rightController)
                rightControllerTransformReference = xRModalityManager.rightController.transform;
            if (xRModalityManager.leftHand == null) //Rig doesn't have hands setup
            {
                leftHandTransformReference = xRModalityManager.leftController.transform;
                rightHandTransformReference = xRModalityManager.rightController.transform;
                SetTrackingType(XRInputModalityManager.InputMode.MotionController);
            }
            else //Setup Hands and modality change listeners
            {
                leftHandTransformReference = xRModalityManager.leftHand
                    .GetComponentInChildren<XRHandSkeletonDriver>(true).rootTransform;
                rightHandTransformReference = xRModalityManager.rightHand
                    .GetComponentInChildren<XRHandSkeletonDriver>(true).rootTransform; 
                if (!xRModalityManager.leftController || !xRModalityManager.rightController)
                    SetTrackingType(XRInputModalityManager.InputMode.TrackedHand);
                else
                    SetTrackingType(XRInputModalityManager.currentInputMode.Value);

                xRModalityManager.trackedHandModeStarted.AddListener(SwapToHands);
                xRModalityManager.motionControllerModeStarted.AddListener(SwapToControllers);
            }
        }

        /// <summary>
        /// Populates the <see cref="localHandFidelityOptions"/> with references to local hand skeleton joints.
        /// Initializes the <see cref="NetworkList{T}"/> instances for finger rotations and curls.
        /// If hands are not set up, it initializes default curl values and sets the tracking type to motion controller.
        /// </summary>
        void SetupLocalFingerReferences()
        {
            XRInputModalityManager tmp_ModalityMangager = FindFirstObjectByType<XRInputModalityManager>();

            // Early out if hands are not setup
            if (tmp_ModalityMangager.leftHand == null)
            {
                // Set Default values for finger rotations
                for (int tmp_I = 0; tmp_I < 3; tmp_I++)
                {
                    fingerCurlLeft.Add(0.0f);
                    fingerCurlRight.Add(0.0f);
                }

                isInitialized.Value = true;
                ChangeControllerType(XRInputModalityManager.InputMode.MotionController);
                return;
            }


            XRHandSkeletonDriver tmp_LocalLeftHandSkeleton =
                tmp_ModalityMangager.leftHand.GetComponentInChildren<XRHandSkeletonDriver>();
            XRHandSkeletonDriver tmp_LocalRightHandSkeleton =
                tmp_ModalityMangager.rightHand.GetComponentInChildren<XRHandSkeletonDriver>();


            localHandFidelityOptions = new HandFidelityOption[2];
            for (int tmp_I = 0; tmp_I < localHandFidelityOptions.Length; tmp_I++)
            {
                localHandFidelityOptions[tmp_I].FingerJoints = new FingerJoints[5];

                // Loop through each finger and setup name and joints
                for (int tmp_J = 0; tmp_J < localHandFidelityOptions[tmp_I].FingerJoints.Length; tmp_J++)
                {
                    localHandFidelityOptions[tmp_I].FingerJoints[tmp_J].FingerName =
                        handCurler[tmp_I].handFidelityOptions[0].FingerJoints[tmp_J].FingerName;
                    localHandFidelityOptions[tmp_I].FingerJoints[tmp_J].JointTransformReferences =
                        new List<JointToTransformReference>();

                    // Loop through each joint in the finger and setup the joint references
                    for (int tmp_K = 0;
                         tmp_K < handCurler[tmp_I].handFidelityOptions[0].FingerJoints[tmp_J].JointTransformReferences
                             .Count;
                         tmp_K++)
                    {
                        XRHandSkeletonDriver tmp_CurrentHandSkeletonDriver =
                            tmp_I % 2 == 0 ? tmp_LocalLeftHandSkeleton : tmp_LocalRightHandSkeleton;
                        // Loop through each local hand and look up the joint reference
                        foreach (var tmp_LocalJoint in tmp_CurrentHandSkeletonDriver.jointTransformReferences)
                        {
                            if (handCurler[tmp_I].handFidelityOptions[0].FingerJoints[tmp_J]
                                    .JointTransformReferences[tmp_K]
                                    .xrHandJointID != tmp_LocalJoint.xrHandJointID) continue;
                            localHandFidelityOptions[tmp_I].FingerJoints[tmp_J].JointTransformReferences
                                .Add(tmp_LocalJoint);
                            break;
                        }
                    }
                }
            }

            foreach (var tmp_FingerSync in localHandFidelityOptions[0].FingerJoints)
            {
                foreach (var tmp_Joint in tmp_FingerSync.JointTransformReferences)
                {
                    fingerRotationsLeft.Add(tmp_Joint.jointTransform.eulerAngles);
                }
            }

            foreach (var tmp_FingerSync in localHandFidelityOptions[1].FingerJoints)
            {
                foreach (var tmp_Joint in tmp_FingerSync.JointTransformReferences)
                {
                    fingerRotationsRight.Add(tmp_Joint.jointTransform.eulerAngles);
                }
            }


            // Set Default values for finger curl
            foreach (var _ in localHandFidelityOptions[0].FingerJoints)
            {
                fingerCurlLeft.Add(0.0f);
            }

            foreach (var _ in localHandFidelityOptions[1].FingerJoints)
            {
                fingerCurlRight.Add(0.0f);
            }


            isInitialized.Value = true;

            SetFidelity(fidelityLevel);
        }

        /// <summary>
        /// Switches the avatar's hand representation between tracked hands and motion controllers.
        /// </summary>
        /// <param name="_inputMode">The new input mode to use (e.g., TrackedHand, MotionController).</param>
        /// <remarks>
        /// When using controllers, the fidelity is automatically set to level 2 (lowest) 
        /// and predefined offsets are applied to the hand visuals.
        /// </remarks>
        public void ChangeControllerType(XRInputModalityManager.InputMode _inputMode)
        {
            if (_inputMode == XRInputModalityManager.InputMode.MotionController)
            {
                SetFidelity(2);
                SetHandsToControllerOffset();
            }
            else
            {
                SetFidelity(fidelityLevel);
                ResetHandsToStart();
            }
        }

        /// <summary>
        /// Sets the fidelity level for the <see cref="handCurler"/> components.
        /// Also enables or disables finger curl animation based on the fidelity level.
        /// </summary>
        /// <param name="_fidelity">The target fidelity level (0, 1, or 2).</param>
        void SetFidelity(int _fidelity)
        {
            _fidelity = Mathf.Clamp(_fidelity, 0, 2);

            handCurler[0].fidelityLevel = _fidelity;
            handCurler[1].fidelityLevel = _fidelity;

            handCurler[0].useCurl = _fidelity > 0;
            handCurler[1].useCurl = _fidelity > 0;
        }

        /// <summary>
        /// Synchronizes all individual finger joint rotations across the network.
        /// If this is the owner, it sets the network variables. If <see cref="updateHandsLocally"/> is true,
        /// it also applies the rotations locally. Otherwise, it gets the rotations from the network.
        /// </summary>
        void SyncAllFingerData()
        {
            if (IsOwner)
            {
                SetNetworkFingerRotations();

                if (updateHandsLocally)
                {
                    GetNetworkFingerRotations();
                }
            }
            else
            {
                GetNetworkFingerRotations();
            }
        }

        /// <summary>
        /// Populates the <see cref="fingerRotationsLeft"/> and <see cref="fingerRotationsRight"/>
        /// NetworkLists with the current local Euler angles of all finger joints.
        /// </summary>
        void SetNetworkFingerRotations()
        {
            int tmp_CurrentIdx = 0;
            for (int tmp_I = 0; tmp_I < localHandFidelityOptions[0].FingerJoints.Length; tmp_I++)
            {
                for (int tmp_J = 0;
                     tmp_J < localHandFidelityOptions[0].FingerJoints[tmp_I].JointTransformReferences.Count;
                     tmp_J++)
                {
                    fingerRotationsLeft[tmp_CurrentIdx++] =
                        localHandFidelityOptions[0].FingerJoints[tmp_I].JointTransformReferences[tmp_J].jointTransform
                            .eulerAngles;
                }
            }

            tmp_CurrentIdx = 0;
            for (int tmp_I = 0; tmp_I < localHandFidelityOptions[1].FingerJoints.Length; tmp_I++)
            {
                for (int tmp_J = 0;
                     tmp_J < localHandFidelityOptions[1].FingerJoints[tmp_I].JointTransformReferences.Count;
                     tmp_J++)
                {
                    fingerRotationsRight[tmp_CurrentIdx++] =
                        localHandFidelityOptions[1].FingerJoints[tmp_I].JointTransformReferences[tmp_J].jointTransform
                            .eulerAngles;
                }
            }
        }

        /// <summary>
        /// Applies the received <see cref="fingerRotationsLeft"/> and <see cref="fingerRotationsRight"/>
        /// to the corresponding finger joints of the <see cref="handCurler"/> components using Slerp
        /// for smooth interpolation.
        /// </summary>
        void GetNetworkFingerRotations()
        {
            int tmp_CurrentIdx = 0;
            int tmp_Hand = 0;
            for (int i = 0; i < handCurler[tmp_Hand].handFidelityOptions[0].FingerJoints.Length; i++)
            {
                for (int tmp_J = 0;
                     tmp_J < handCurler[tmp_Hand].handFidelityOptions[0].FingerJoints[i].JointTransformReferences.Count;
                     tmp_J++)
                {
                    handCurler[tmp_Hand].handFidelityOptions[0].FingerJoints[i].JointTransformReferences[tmp_J]
                            .jointTransform
                            .rotation =
                        Quaternion.Slerp(
                            handCurler[tmp_Hand].handFidelityOptions[0].FingerJoints[i].JointTransformReferences[tmp_J]
                                .jointTransform.rotation,
                            Quaternion.Euler(fingerRotationsLeft[tmp_CurrentIdx++]),
                            Time.deltaTime * fingerLerpSpeed);
                }
            }

            tmp_CurrentIdx = 0;
            tmp_Hand = 1;
            for (int tmp_I = 0; tmp_I < handCurler[tmp_Hand].handFidelityOptions[0].FingerJoints.Length; tmp_I++)
            {
                for (int tmp_J = 0;
                     tmp_J < handCurler[tmp_Hand].handFidelityOptions[0].FingerJoints[tmp_I].JointTransformReferences
                         .Count;
                     tmp_J++)
                {
                    handCurler[tmp_Hand].handFidelityOptions[0].FingerJoints[tmp_I].JointTransformReferences[tmp_J]
                            .jointTransform
                            .rotation =
                        Quaternion.Slerp(
                            handCurler[tmp_Hand].handFidelityOptions[0].FingerJoints[tmp_I]
                                .JointTransformReferences[tmp_J]
                                .jointTransform.rotation,
                            Quaternion.Euler(fingerRotationsRight[tmp_CurrentIdx++]),
                            Time.deltaTime * fingerLerpSpeed);
                }
            }
        }

        /// <summary>
        /// Synchronizes average finger curl values for each finger across the network.
        /// If this is the owner, it sets the network variables. If <see cref="updateHandsLocally"/> is true,
        /// it also applies the curls locally. Otherwise, it gets the curls from the network.
        /// </summary>
        void SyncFingerCurl()
        {
            if (IsOwner)
            {
                SetNetworkCurl();

                if (updateHandsLocally)
                {
                    GetNetworkCurl();
                }
            }
            else
            {
                GetNetworkCurl();
            }
        }

        /// <summary>
        /// Calculates the average X-axis local Euler angle for each finger and sets it
        /// into the <see cref="fingerCurlLeft"/> and <see cref="fingerCurlRight"/> NetworkLists.
        /// </summary>
        void SetNetworkCurl()
        {
            for (int tmp_I = 0; tmp_I < localHandFidelityOptions[0].FingerJoints.Length; tmp_I++)
            {
                SetLocalNetworkFingerCurl(0, tmp_I, GetAverageX(0, tmp_I));
            }

            for (int tmp_I = 0; tmp_I < localHandFidelityOptions[1].FingerJoints.Length; tmp_I++)
            {
                SetLocalNetworkFingerCurl(1, tmp_I, GetAverageX(1, tmp_I));
            }
        }

        /// <summary>
        /// Applies the received <see cref="fingerCurlLeft"/> and <see cref="fingerCurlRight"/>
        /// values to the <see cref="handCurler"/> components to animate finger curl.
        /// </summary>
        void GetNetworkCurl()
        {
            for (int tmp_I = 0; tmp_I < handCurler[0].handFidelityOptions[0].FingerJoints.Length; tmp_I++)
            {
                handCurler[0].SetCurl(tmp_I, fingerCurlLeft[tmp_I]);
            }

            for (int tmp_I = 0; tmp_I < handCurler[1].handFidelityOptions[0].FingerJoints.Length; tmp_I++)
            {
                handCurler[1].SetCurl(tmp_I, fingerCurlRight[tmp_I]);
            }
        }

        /// <summary>
        /// Calculates the average X-axis local Euler angle for a specific finger's joints.
        /// This is used to derive a single curl value for the entire finger.
        /// </summary>
        /// <param name="_hand">The hand index (0 for left, 1 for right).</param>
        /// <param name="_finger">The finger index (0 for thumb, 1 for index, etc.).</param>
        /// <returns>The normalized average X-axis rotation for the specified finger.</returns>
        float GetAverageX(int _hand, int _finger)
        {
            float tmp_X = 0;
            int tmp_DigitCount = 4;

            if (_finger == 0) //Thumbs have 1 less joint
            {
                tmp_DigitCount--;
            }

            for (int tmp_I = 1; tmp_I < tmp_DigitCount; tmp_I++)
            {
                float tmp_CurrentX = localHandFidelityOptions[_hand].FingerJoints[_finger]
                    .JointTransformReferences[tmp_I]
                    .jointTransform.localEulerAngles.x;
                if (tmp_CurrentX < 0 || tmp_CurrentX > 180)
                {
                    tmp_CurrentX = 0;
                }

                tmp_X += tmp_CurrentX;
            }

            float tmp_Avg = Mathf.Clamp(tmp_X / (tmp_DigitCount - 1), 0, 100);

            return tmp_Avg / 100;
        }

        /// <summary>
        /// Synchronizes a limited set of finger curl values across the network.
        /// This typically includes thumb, index, and a combined curl for the remaining fingers.
        /// If this is the owner, it sets the network variables. If <see cref="updateHandsLocally"/> is true,
        /// it also applies the curls locally. Otherwise, it gets the curls from the network.
        /// </summary>
        void SyncFingerCurlLimited()
        {
            if (IsOwner)
            {
                SetNetworkCurlLimited();

                if (updateHandsLocally)
                {
                    GetNetworkCurlLimited();
                }
            }
            else
            {
                GetNetworkCurlLimited();
            }
        }

        /// <summary>
        /// Calculates and sets limited finger curl values into the <see cref="fingerCurlLeft"/>
        /// and <see cref="fingerCurlRight"/> NetworkLists. This includes individual curls for
        /// the first two fingers and a combined curl for the rest.
        /// </summary>
        void SetNetworkCurlLimited()
        {
            for (int tmp_I = 0; tmp_I < 2; tmp_I++)
            {
                SetLocalNetworkFingerCurl(0, tmp_I, GetAverageX(0, tmp_I));
            }

            for (int tmp_I = 0; tmp_I < 2; tmp_I++)
            {
                SetLocalNetworkFingerCurl(1, tmp_I, GetAverageX(1, tmp_I));
            }

            SetLocalNetworkFingerCurl(0, 2, GetAverageXCombined(0));
            SetLocalNetworkFingerCurl(1, 2, GetAverageXCombined(1));
        }

        /// <summary>
        /// Applies the received limited finger curl values to the <see cref="handCurler"/> components.
        /// </summary>
        void GetNetworkCurlLimited()
        {
            for (int tmp_I = 0; tmp_I < 3; tmp_I++)
            {
                handCurler[0].SetCurl(tmp_I, fingerCurlLeft[tmp_I]);
            }

            for (int tmp_I = 0; tmp_I < 3; tmp_I++)
            {
                handCurler[1].SetCurl(tmp_I, fingerCurlRight[tmp_I]);
            }
        }

        /// <summary>
        /// Calculates a combined average X-axis local Euler angle for a group of fingers (e.g., ring and pinky).
        /// </summary>
        /// <param name="_hand">The hand index (0 for left, 1 for right).</param>
        /// <returns>The normalized combined average X-axis rotation for the specified fingers.</returns>
        float GetAverageXCombined(int _hand)
        {
            float tmp_X = 0;

            const int tmp_const_DigitCount = 4;
            const int tmp_const_StartFinger = 2;
            const int tmp_const_EndFinger = 5;

            int tmp_Count = 0;
            for (int tmp_I = tmp_const_StartFinger; tmp_I < tmp_const_EndFinger; tmp_I++)
            {
                for (int tmp_J = 1; tmp_J < tmp_const_DigitCount; tmp_J++)
                {
                    float tmp_CurrentX = localHandFidelityOptions[_hand].FingerJoints[tmp_I]
                        .JointTransformReferences[tmp_J]
                        .jointTransform.localEulerAngles.x;
                    if (tmp_CurrentX < 0 || tmp_CurrentX > 180)
                    {
                        tmp_CurrentX = 0;
                    }

                    tmp_X += tmp_CurrentX;
                    tmp_Count++;
                }
            }

            float tmp_Avg = Mathf.Clamp(tmp_X / tmp_Count, 0, 100);

            return tmp_Avg / 100;
        }

        /// <summary>
        /// Synchronizes controller input (grip, trigger, thumb touch) to hand poses.
        /// If this is the owner, it reads local input and sets network variables. If <see cref="updateHandsLocally"/> is true,
        /// it also applies the poses locally. Otherwise, it gets the poses from the network.
        /// </summary>
        void SyncControllerTracking()
        {
            //TODO: Sync Controller Input and map to hand poses
            if (IsOwner)
            {
                SetNetworkControllerFingerSync();
                if (updateHandsLocally)
                {
                    GetNetworkedControllerFingerSync();
                }
            }
            else
            {
                GetNetworkedControllerFingerSync();
            }
        }

        /// <summary>
        /// Reads the current values from local controller input actions (thumb touch, trigger, grip)
        /// and sets the corresponding finger curl values in the network lists.
        /// </summary>
        void SetNetworkControllerFingerSync()
        {
            // if (thumbTouchProperties.Length > 0)
            //     SetLocalNetworkFingerCurl(0, 0, thumbTouchProperties[0]?.ReadValue<float>() ?? 0.0f);
            // if (triggerInputProperties.Length > 0)
            //     SetLocalNetworkFingerCurl(0, 1, triggerInputProperties[0]?.ReadValue<float>() ?? 0.0f);
            if (gripInputProperties.Length > 0)
            {
                SetLocalNetworkFingerCurl(0, 0, gripInputProperties[0]?.ReadValue<float>() ?? 0.0f);
                SetLocalNetworkFingerCurl(0, 1, gripInputProperties[0]?.ReadValue<float>() ?? 0.0f);
                SetLocalNetworkFingerCurl(0, 2, gripInputProperties[0]?.ReadValue<float>() ?? 0.0f);
            }


            if (gripInputProperties.Length > 0)
            {
                SetLocalNetworkFingerCurl(1, 0, gripInputProperties[1]?.ReadValue<float>() ?? 0.0f);
                SetLocalNetworkFingerCurl(1, 1, gripInputProperties[1]?.ReadValue<float>() ?? 0.0f);
                SetLocalNetworkFingerCurl(1, 2, gripInputProperties[1]?.ReadValue<float>() ?? 0.0f);
            }

            // if (thumbTouchProperties.Length >= 1)
            //     SetLocalNetworkFingerCurl(1, 0, thumbTouchProperties[1]?.ReadValue<float>() ?? 0.0f);
            // if (triggerInputProperties.Length >= 1)
            //     SetLocalNetworkFingerCurl(1, 1, triggerInputProperties[1]?.ReadValue<float>() ?? 0.0f);
            // if (gripInputProperties.Length >= 1)
            //     SetLocalNetworkFingerCurl(1, 2, gripInputProperties[1]?.ReadValue<float>() ?? 0.0f);
        }

        /// <summary>
        /// Updates a specific finger curl value in the appropriate <see cref="NetworkList{T}"/>
        /// (<see cref="fingerCurlLeft"/> or <see cref="fingerCurlRight"/>) only if the change
        /// exceeds the <see cref="minUpdateDelta"/> threshold.
        /// </summary>
        /// <param name="_hand">The hand index (0 for left, 1 for right).</param>
        /// <param name="_finger">The finger index.</param>
        /// <param name="_value">The new curl value.</param>
        void SetLocalNetworkFingerCurl(int _hand, int _finger, float _value)
        {
            if (_hand == 0)
            {
                if (Mathf.Abs(fingerCurlLeft[_finger] - _value) > minUpdateDelta)
                    fingerCurlLeft[_finger] = _value;
            }
            else
            {
                if (Mathf.Abs(fingerCurlRight[_finger] - _value) > minUpdateDelta)
                    fingerCurlRight[_finger] = _value;
            }
        }

        /// <summary>
        /// Applies the networked controller-derived finger curl values to the avatar's hands.
        /// This method essentially calls <see cref="GetNetworkCurlLimited"/> as controller input
        /// typically maps to a limited set of hand poses.
        /// </summary>
        void GetNetworkedControllerFingerSync()
        {
            GetNetworkCurlLimited();
        }

        /// <summary>
        /// Event listener for when the XR input modality switches to tracked hands.
        /// Calls <see cref="SetTrackingType"/> to update the network variable and local hand origins.
        /// </summary>
        void SwapToHands()
        {
            SetTrackingType(XRInputModalityManager.InputMode.TrackedHand);
        }

        /// <summary>
        /// Event listener for when the XR input modality switches to motion controllers.
        /// Calls <see cref="SetTrackingType"/> to update the network variable and local hand origins.
        /// </summary>
        void SwapToControllers()
        {
            SetTrackingType(XRInputModalityManager.InputMode.MotionController);
        }

        /// <summary>
        /// Sets the current XR input tracking type for this network object.
        /// This updates the <see cref="trackingType"/> NetworkVariable and
        /// adjusts the <see cref="leftHandOrigin"/> and <see cref="rightHandOrigin"/>
        /// references to point to either the tracked hands or the controllers.
        /// It also informs the <see cref="XRNetworkPlayerAvatar.LocalPlayerAvatar"/> of the new hand origins.
        /// </summary>
        /// <param name="_trackingType">The new <see cref="XRInputModalityManager.InputMode"/> to set.</param>
        public void SetTrackingType(XRInputModalityManager.InputMode _trackingType)
        {
            this.trackingType.Value = _trackingType;
            if (_trackingType == XRInputModalityManager.InputMode.MotionController)
            {
                leftHandOrigin = leftControllerTransformReference;
                rightHandOrigin = rightControllerTransformReference;
            }
            else
            {
                leftHandOrigin = leftHandTransformReference;
                rightHandOrigin = rightHandTransformReference;
            }

            GetComponentInParent<XRNetworkPlayerAvatar>().SetHandOrigins(leftHandOrigin, rightHandOrigin);
        }

        /// <summary>
        /// Resets the local position and rotation of the <see cref="handCurler"/> components
        /// to their initial recorded start poses. This is typically used when switching from
        /// controller mode back to tracked hand mode.
        /// </summary>
        void ResetHandsToStart()
        {
            for (int tmp_I = 0; tmp_I < handCurler.Length; tmp_I++)
            {
                handCurler[tmp_I].transform.localPosition = handTrackedStartPose[tmp_I].position;
                handCurler[tmp_I].transform.localRotation = handTrackedStartPose[tmp_I].rotation;
            }
        }

        /// <summary>
        /// Applies predefined local position and Euler angle offsets to the <see cref="handCurler"/> components.
        /// This is typically used when switching to motion controller mode to adjust hand placement relative to controllers.
        /// </summary>
        void SetHandsToControllerOffset()
        {
            for (int tmp_I = 0; tmp_I < handCurler.Length; tmp_I++)
            {
                handCurler[tmp_I].transform.localPosition = handControllerOffsets[tmp_I];
                handCurler[tmp_I].transform.localRotation = Quaternion.Euler(handControllerEulerOffsets[tmp_I]);
            }
        }
#endif
    }
}