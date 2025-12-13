// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODInput.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if USE_XRI

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Transformers;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    public class XRBaseGrabTransformAdapter : XRBaseGrabTransformer
    {
        public UnityEvent<XRGrabInteractable> OnLinkEvent = new();
        public UnityEvent<XRGrabInteractable> OnUnlinkEvent = new();
        public UnityEvent<XRGrabInteractable> OnGrabEvent = new();
        public UnityEvent<XRGrabInteractable, PoseWrapper, Vector3Wrapper> OnGrabChanged = new();

        public UnityEvent<XRGrabInteractable, XRInteractionUpdateOrder.UpdatePhase, PoseWrapper, Vector3Wrapper>
            OnProcessEvent = new();

        /// <inheritdoc />
        protected override RegistrationMode registrationMode => RegistrationMode.SingleAndMultiple;

        public override void OnLink(XRGrabInteractable _grabInteractable)
        {
            base.OnLink(_grabInteractable);
            OnLinkEvent?.Invoke(_grabInteractable);
        }

        public override void Process(XRGrabInteractable _grabInteractable,
            XRInteractionUpdateOrder.UpdatePhase _updatePhase, ref Pose _targetPose, ref Vector3 _localScale)
        {
            OnProcessEvent?.Invoke(_grabInteractable, _updatePhase, new PoseWrapper(_targetPose),
                new Vector3Wrapper(_localScale));
        }

        public override void OnGrab(XRGrabInteractable _grabInteractable)
        {
            base.OnGrab(_grabInteractable);
            OnGrabEvent?.Invoke(_grabInteractable);
        }

        public override void OnGrabCountChanged(XRGrabInteractable _grabInteractable, Pose _targetPose,
            Vector3 _localScale)
        {
            base.OnGrabCountChanged(_grabInteractable, _targetPose, _localScale);
            OnGrabChanged?.Invoke(_grabInteractable, new PoseWrapper(_targetPose), new Vector3Wrapper(_localScale));
        }

        public override void OnUnlink(XRGrabInteractable _grabInteractable)
        {
            base.OnUnlink(_grabInteractable);
            OnUnlinkEvent?.Invoke(_grabInteractable);
        }
    }

    [Serializable]
    public class PoseWrapper
    {
        public Pose pose;

        public PoseWrapper(Pose _pose)
        {
            this.pose = _pose;
        }
    }

    [Serializable]
    public class Vector3Wrapper
    {
        public Vector3 vector;

        public Vector3Wrapper(Vector3 _vector)
        {
            this.vector = _vector;
        }
    }
}

#endif