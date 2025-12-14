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

using UnityEngine.XR.Hands;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    public static class GestureUtilities
    {
        /// <summary>
        /// Returns true if the given hand's index finger tip is farther from the wrist than the index intermediate joint.
        /// </summary>
        /// <param name="_hand">Hand to check for the required pose.</param>
        /// <returns>True if the given hand's index finger tip is farther from the wrist than the index intermediate joint, false otherwise.</returns>
        public static bool IsIndexExtended(XRHand _hand)
        {
            if (!(_hand.GetJoint(XRHandJointID.Wrist).TryGetPose(out var tmp_WristPose) &&
                  _hand.GetJoint(XRHandJointID.IndexTip).TryGetPose(out var tmp_TipPose) &&
                  _hand.GetJoint(XRHandJointID.IndexIntermediate).TryGetPose(out var tmp_IntermediatePose)))
            {
                return false;
            }

            var tmp_WristToTip = tmp_TipPose.position - tmp_WristPose.position;
            var tmp_WristToIntermediate = tmp_IntermediatePose.position - tmp_WristPose.position;
            return tmp_WristToTip.sqrMagnitude > tmp_WristToIntermediate.sqrMagnitude;
        }

        /// <summary>
        /// Returns true if the given hand's middle finger tip is closer to the wrist than the middle proximal joint.
        /// </summary>
        /// <param name="_hand">Hand to check for the required pose.</param>
        /// <returns>True if the given hand's middle finger tip is closer to the wrist than the middle proximal joint, false otherwise.</returns>
        public static bool IsMiddleGrabbing(XRHand _hand)
        {
            if (!(_hand.GetJoint(XRHandJointID.Wrist).TryGetPose(out var tmp_wristPose) &&
                  _hand.GetJoint(XRHandJointID.MiddleTip).TryGetPose(out var tmp_TipPose) &&
                  _hand.GetJoint(XRHandJointID.MiddleProximal).TryGetPose(out var tmp_ProximalPose)))
            {
                return false;
            }

            var tmp_WristToTip = tmp_TipPose.position - tmp_wristPose.position;
            var tmp_WristToProximal = tmp_ProximalPose.position - tmp_wristPose.position;
            return tmp_WristToProximal.sqrMagnitude >= tmp_WristToTip.sqrMagnitude;
        }

        /// <summary>
        /// Returns true if the given hand's ring finger tip is closer to the wrist than the ring proximal joint.
        /// </summary>
        /// <param name="_hand">Hand to check for the required pose.</param>
        /// <returns>True if the given hand's ring finger tip is closer to the wrist than the ring proximal joint, false otherwise.</returns>
        public static bool IsRingGrabbing(XRHand _hand)
        {
            if (!(_hand.GetJoint(XRHandJointID.Wrist).TryGetPose(out var tmp_WristPose) &&
                  _hand.GetJoint(XRHandJointID.RingTip).TryGetPose(out var tmp_TipPose) &&
                  _hand.GetJoint(XRHandJointID.RingProximal).TryGetPose(out var tmp_ProximalPose)))
            {
                return false;
            }

            var tmp_WristToTip = tmp_TipPose.position - tmp_WristPose.position;
            var tmp_WristToProximal = tmp_ProximalPose.position - tmp_WristPose.position;
            return tmp_WristToProximal.sqrMagnitude >= tmp_WristToTip.sqrMagnitude;
        }

        /// <summary>
        /// Returns true if the given hand's little finger tip is closer to the wrist than the little proximal joint.
        /// </summary>
        /// <param name="_hand">Hand to check for the required pose.</param>
        /// <returns>True if the given hand's little finger tip is closer to the wrist than the little proximal joint, false otherwise.</returns>
        public static bool IsLittleGrabbing(XRHand _hand)
        {
            if (!(_hand.GetJoint(XRHandJointID.Wrist).TryGetPose(out var tmp_WristPose) &&
                  _hand.GetJoint(XRHandJointID.LittleTip).TryGetPose(out var tmp_TipPose) &&
                  _hand.GetJoint(XRHandJointID.LittleProximal).TryGetPose(out var tmp_ProximalPose)))
            {
                return false;
            }

            var tmp_WristToTip = tmp_TipPose.position - tmp_WristPose.position;
            var tmp_WristToProximal = tmp_ProximalPose.position - tmp_WristPose.position;
            return tmp_WristToProximal.sqrMagnitude >= tmp_WristToTip.sqrMagnitude;
        }
    }
}

#endif