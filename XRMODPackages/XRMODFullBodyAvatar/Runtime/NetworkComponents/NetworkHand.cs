// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
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
using UnityEngine;
using UnityEngine.XR.Hands;

namespace Phantom.XRMOD.Avatar.Runtime
{
    public class NetworkHand : NetworkBehaviour
    {
        public Transform[] jointTransforms;
        public Handedness hand;

        public NetworkArray<NetworkHandJointData> JointStates => default;
        [Networked] public NetworkBool IsTracked { get; set; }

        private NetworkHandJointData[] previousSent;


        public override void Spawned()
        {
            previousSent = new NetworkHandJointData[jointTransforms.Length];
        }


        public override void FixedUpdateNetwork()
        {
            if (HasStateAuthority && (Runner.Topology == Topologies.Shared || Runner.IsServer))
            {
                // 手是否跟踪中
                IsTracked = true;

                for (int tmp_Idx = 0; tmp_Idx < jointTransforms.Length; tmp_Idx++)
                {
                    var tmp_JointTransform = jointTransforms[tmp_Idx];
                    if (tmp_JointTransform == null) continue;

                    // 可在此处做delta压缩判定
                    JointStates.Set(tmp_Idx, new NetworkHandJointData()
                    {
                        Position = tmp_JointTransform.localPosition,
                        Rotation = tmp_JointTransform.localRotation
                    });
                }
            }
            else
            {
                // 平滑处理：插值可选
                for (int tmp_Idx = 0; tmp_Idx < jointTransforms.Length; tmp_Idx++)
                {
                    var tmp_RemoteHandJointData = JointStates[tmp_Idx];
                    var tmp_JointTransform = jointTransforms[tmp_Idx];
                    if (tmp_JointTransform == null) continue;

                    tmp_JointTransform.localPosition = Vector3.Lerp(tmp_JointTransform.localPosition,
                        tmp_RemoteHandJointData.Position, 0.5f);
                    tmp_JointTransform.localRotation = Quaternion.Slerp(tmp_JointTransform.localRotation,
                        tmp_RemoteHandJointData.Rotation, 0.5f);
                }
            }
        }
    }
}