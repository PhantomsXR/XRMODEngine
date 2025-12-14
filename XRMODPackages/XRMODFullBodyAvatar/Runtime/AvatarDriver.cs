// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Avatar.Runtime.
// //
// // The Avatar cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using Fusion;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.XR.Hands;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

namespace Phantom.XRMOD.Avatar.Runtime
{
    [DefaultExecutionOrder(100)]
    public class AvatarDriver : MonoBehaviour
    {
        private Transform selfTransform;
        private NetworkObject networkObject;
        [SerializeField] private VRIK ik;


        [Header("XR Hand Driver")] [SerializeField]
        private AvatarHandDriver leftAvatarHandDriver;

        [SerializeField] private AvatarHandDriver rightAvatarHandDriver;

        [Header("Target Joints")] [SerializeField]
        private List<Transform> leftHandPalmTargetJoints;

        [SerializeField] private List<Transform> rightHandPalmTargetJoints;

        [SerializeField] private Transform headTargetJoint;
        [SerializeField] private Transform leftHandTargetJoint;
        [SerializeField] private Transform rightHandTargetJoint;


        [Header("Source Joints")] [SerializeField]
        private List<Transform> leftHandPalmJoints;

        [SerializeField] private List<Transform> rightHandPalmJoints;

        [SerializeField] private Transform headJoint;
        [SerializeField] private Transform leftHandJoint;
        [SerializeField] private Transform rightHandJoint;


        internal Transform GetHeadJointPose => headTargetJoint;
        internal Transform GetLeftHeadJointPose => leftHandTargetJoint;
        internal Transform GetRightHeadJointPose => rightHandTargetJoint;

        internal List<Transform> GetLeftHandPalmJoints => leftHandPalmTargetJoints;
        internal List<Transform> GetRightHandPalmJoints => rightHandPalmTargetJoints;

        private XRInputModalityManager xrInputModalityManager;


        private void Awake()
        {
            selfTransform = transform;
            networkObject = GetComponent<NetworkObject>();
            if (ik == null)
                ik = GetComponentInChildren<VRIK>();
            new CalibrateHeight(ik).StartCalibrateHeight();
            Init();
        }


        internal void Init()
        {
            var tmp_MainCamTransform = Camera.main.transform;
            var tmp_HeadFollowTarget = new GameObject("HeadFollowTarget").transform;
            tmp_HeadFollowTarget.SetParent(tmp_MainCamTransform);
            tmp_HeadFollowTarget.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
            headTargetJoint = tmp_HeadFollowTarget;


            xrInputModalityManager = FindAnyObjectByType<XRInputModalityManager>(FindObjectsInactive.Include);
            xrInputModalityManager.motionControllerModeStarted.AddListener(OnMotionControllerStarted);
            xrInputModalityManager.trackedHandModeStarted.AddListener(OnHandStarted);

            if (xrInputModalityManager.leftController || xrInputModalityManager.rightController)
            {
                OnMotionControllerStarted();
            }
            else
            {
                OnHandStarted();
            }

            ik.solver.leftArm.target = leftHandJoint;
            ik.solver.rightArm.target = rightHandJoint;
            ik.solver.spine.headTarget = headJoint;
        }
#if UNITY_EDITOR
        public Handedness handedness;
        public Transform HandRoot;
        public bool IsSource;

        [ContextMenu("Set Bone References")]
        internal void SetBoneReferences()
        {
            var handMap = handedness == Handedness.Left
                ? AvatarHandDriver._JOINT_ID_BONE_PATH_MAP_LEFT
                : AvatarHandDriver._JOINT_ID_BONE_PATH_MAP_RIGHT;

            foreach (var kvp in handMap)
            {
                var joint = HandRoot.Find(kvp.Value);
                if (joint == null)
                {
                    Debug.LogWarning($"Joint transform not found: {kvp.Value}");
                    continue;
                }


                if (handedness == Handedness.Left)
                {
                    if (IsSource)
                        leftHandPalmJoints.Add(joint);
                    else
                        leftHandPalmTargetJoints.Add(joint);
                }
                else
                {
                    if (IsSource)
                        rightHandPalmJoints.Add(joint);
                    else
                        rightHandPalmTargetJoints.Add(joint);
                }
            }
        }

#endif
        internal void SyncHeadJoint(Vector3 _position, Quaternion _rotation)
        {
            headJoint.position = Vector3.Lerp(headJoint.position, _position, networkObject.RenderTime);
            headJoint.rotation = Quaternion.Lerp(headJoint.rotation, _rotation, networkObject.RenderTime); 
        }

        internal void SyncRightHandJoint(Vector3 _position, Quaternion _rotation)
        {
            rightHandJoint.SetPositionAndRotation(_position, _rotation);
        }

        internal void SyncLeftHandJoint(Vector3 _position, Quaternion _rotation)
        {
            leftHandJoint.SetPositionAndRotation(_position, _rotation);
        }

        internal void SyncHandPalmJoint(Pose[] _leftPalmJoints, Pose[] _rightPalmJoints)
        {
            for (int tmp_Idx = 0; tmp_Idx < _leftPalmJoints.Length; tmp_Idx++)
            {
                leftHandPalmTargetJoints[tmp_Idx].localPosition = _leftPalmJoints[tmp_Idx].position;
                leftHandPalmTargetJoints[tmp_Idx].localRotation = _leftPalmJoints[tmp_Idx].rotation;

                rightHandPalmTargetJoints[tmp_Idx].localPosition = _rightPalmJoints[tmp_Idx].position;
                rightHandPalmTargetJoints[tmp_Idx].localRotation = _rightPalmJoints[tmp_Idx].rotation;
            }
        }

        private void OnMotionControllerStarted()
        {
            leftAvatarHandDriver.gameObject.SetActive(false);
            rightAvatarHandDriver.gameObject.SetActive(false);
            leftHandTargetJoint = xrInputModalityManager.leftController.transform;
            rightHandTargetJoint = xrInputModalityManager.rightController.transform;
        }


        private void OnHandStarted()
        {
            if (networkObject.Runner.Topology == Topologies.Shared && !networkObject.HasStateAuthority) return;
            if ((networkObject.Runner.IsClient || networkObject.Runner.IsServer) &&
                !networkObject.HasInputAuthority) return;
            leftAvatarHandDriver.handTrackingEvents =
                xrInputModalityManager.leftHand.GetComponentInChildren<XRHandTrackingEvents>();
            rightAvatarHandDriver.handTrackingEvents =
                xrInputModalityManager.rightHand.GetComponentInChildren<XRHandTrackingEvents>();

            var tmp_LeftHandSkeltonDriver =
                xrInputModalityManager.leftHand.GetComponentInChildren<XRHandSkeletonDriver>();
            var tmp_RightHandSkeltonDriver =
                xrInputModalityManager.rightHand.GetComponentInChildren<XRHandSkeletonDriver>();

            // Setup vrik follow target
            leftHandTargetJoint =
                tmp_LeftHandSkeltonDriver.jointTransformReferences[(int) XRHandJointID.Wrist].jointTransform;
            rightHandTargetJoint =
                tmp_RightHandSkeltonDriver.jointTransformReferences[(int) XRHandJointID.Wrist].jointTransform;

            // Activated hand pose
            leftAvatarHandDriver.gameObject.SetActive(true);
            rightAvatarHandDriver.gameObject.SetActive(true);
        }
    }
}