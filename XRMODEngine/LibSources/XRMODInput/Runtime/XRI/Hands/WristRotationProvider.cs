// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODInput.Runtime.
// //
// // The UnityRokidLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if USE_XRI && XR_HANDS_1_1_OR_NEWER
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Hands;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    public class WristRotationProvider : MonoBehaviour
    {
        public XRNode XRHand;

        private Transform selfTransform;

        private void Start()
        {
            selfTransform = this.transform;
        }

        private void Update()
        {
            if (!selfTransform) return;
            HandsAggregatorSubsystem.INSTANCE.TryGetJointPose(XRHandJointID.Wrist, XRHand, out Pose _Pose);
            selfTransform.rotation = _Pose.rotation;
        }
    }
}
#endif