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

using System;
using Fusion;
using ReadyPlayerMe.Core;
using UnityEngine;
using Pose = UnityEngine.Pose;

namespace Phantom.XRMOD.Avatar.Runtime
{
    [RequireComponent(typeof(AvatarDriver), typeof(NetworkObject))]
    public class NetworkAvatar : NetworkBehaviour
    {
        [SerializeField] private AvatarConfig config;
        [SerializeField] private AvatarDriver avatarDriver;
        private Transform leftEye;
        private Transform rightEye;


        [Networked, Capacity(700)] private NetworkArray<byte> leftHandPalmPose => default;
        [Networked, Capacity(700)] private NetworkArray<byte> rightHandPalmPose => default;

        private void Awake()
        {
            if (!avatarDriver)
                avatarDriver = GetComponent<AvatarDriver>();

            leftEye = AvatarBoneHelper.GetLeftEyeBone(transform, true);
            rightEye = AvatarBoneHelper.GetRightEyeBone(transform, true);
        }


        public override void Spawned()
        {
            base.Spawned();

            if (Runner.Topology == Topologies.Shared && HasStateAuthority)
            {
                avatarDriver.Init();
            }
            else if (HasInputAuthority)
            {
                avatarDriver.Init();
            }
        }


        public override void Render()
        {
            base.Render();
            if (!HasStateAuthority)
            {
                var tmp_DeserializedLeftHandPalmPoses =
                    NetworkSerializerUtility.DeserializePosesCustom(leftHandPalmPose.ToArray());
                var tmp_DeserializedRightHandPalmPoses =
                    NetworkSerializerUtility.DeserializePosesCustom(rightHandPalmPose.ToArray());
                avatarDriver.SyncHandPalmJoint(tmp_DeserializedLeftHandPalmPoses, tmp_DeserializedRightHandPalmPoses);
            }
        }

        /// <summary>
        ///  Only work on local.
        /// </summary>
        public override void FixedUpdateNetwork()
        {
            if (!HasStateAuthority)
            {
                return;
            }

            avatarDriver.SyncHeadJoint(avatarDriver.GetHeadJointPose.position,
                avatarDriver.GetHeadJointPose.rotation);

            avatarDriver.SyncLeftHandJoint(avatarDriver.GetLeftHeadJointPose.position,
                avatarDriver.GetLeftHeadJointPose.rotation);

            avatarDriver.SyncRightHandJoint(avatarDriver.GetRightHeadJointPose.position,
                avatarDriver.GetRightHeadJointPose.rotation);

            Pose[] tmp_LeftPalmPose = new Pose[avatarDriver.GetLeftHandPalmJoints.Count];
            Pose[] tmp_RightPalmPose = new Pose[avatarDriver.GetLeftHandPalmJoints.Count];

            for (int tmp_Idx = 0; tmp_Idx < avatarDriver.GetLeftHandPalmJoints.Count; tmp_Idx++)
            {
                var tmp_LeftPalmJoint = avatarDriver.GetLeftHandPalmJoints[tmp_Idx];
                tmp_LeftPalmPose[tmp_Idx].position = tmp_LeftPalmJoint.localPosition;
                tmp_LeftPalmPose[tmp_Idx].rotation = tmp_LeftPalmJoint.localRotation;
                var tmp_RightPalmJoint = avatarDriver.GetRightHandPalmJoints[tmp_Idx];
                tmp_RightPalmPose[tmp_Idx].position = tmp_RightPalmJoint.localPosition;
                tmp_RightPalmPose[tmp_Idx].rotation = tmp_RightPalmJoint.localRotation;
            }

            leftHandPalmPose.CopyFrom(NetworkSerializerUtility.SerializePosesCustom(tmp_LeftPalmPose), 0, 700);
            rightHandPalmPose.CopyFrom(NetworkSerializerUtility.SerializePosesCustom(tmp_RightPalmPose), 0, 700);
        }


        /// <summary>
        ///     Calls PunRPC with the avatar URL as paramater to load the local and remote avatars.
        /// </summary>
        /// <param name="_url">Avatar URL</param>
        public void LoadAvatar(string _url)
        {
            if (!HasStateAuthority) return;
            RpcSetAvatar(_url);
        }


        [Rpc(RpcSources.StateAuthority, RpcTargets.All)]
        private void RpcSetAvatar(string _incomingUrl)
        {
            AvatarObjectLoader tmp_Loader = new AvatarObjectLoader
            {
                AvatarConfig = config
            };
            tmp_Loader.LoadAvatar(_incomingUrl);
            tmp_Loader.OnCompleted += (_sender, _args) =>
            {
                leftEye.transform.localPosition =
                    AvatarBoneHelper.GetLeftEyeBone(_args.Avatar.transform, true).localPosition;
                rightEye.transform.localPosition =
                    AvatarBoneHelper.GetRightEyeBone(_args.Avatar.transform, true).localPosition;
                AvatarMeshHelper.TransferMesh(_args.Avatar, gameObject);
                Destroy(_args.Avatar);
            };
        }


        [ContextMenu("Load Avatar")]
        private void TestAvatarLoad()
        {
            LoadAvatar("https://models.readyplayer.me/670262fc33ccd199246642e2.glb");
        }
    }
}