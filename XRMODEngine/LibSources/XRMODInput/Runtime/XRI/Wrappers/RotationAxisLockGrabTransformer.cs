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

using UnityEngine; 
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Transformers;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// An XR grab transformer that allows for the locking of specific rotation axes. When an object is grabbed and manipulated,
    /// this class ensures that rotations are only applied to the specified axes, preserving the initial rotation for the others.
    /// </summary>
    public class RotationAxisLockGrabTransformer : XRBaseGrabTransformer
    {
        [SerializeField]
        [Tooltip(
            "Defines which rotation axes are allowed when an object is grabbed. Axes not selected will maintain their initial rotation.")]
        XRGeneralGrabTransformer.ManipulationAxes permittedRotationAxis = XRGeneralGrabTransformer.ManipulationAxes.All;

        /// <inheritdoc />
        protected override RegistrationMode registrationMode => RegistrationMode.SingleAndMultiple;

        Vector3 initialEulerRotation;

        /// <inheritdoc />
        public override void OnLink(XRGrabInteractable _grabInteractable)
        {
            base.OnLink(_grabInteractable);
            initialEulerRotation = _grabInteractable.transform.rotation.eulerAngles;
        }

        /// <inheritdoc />
        public override void Process(XRGrabInteractable _grabInteractable,
            XRInteractionUpdateOrder.UpdatePhase _updatePhase, ref Pose _targetPose, ref Vector3 _localScale)
        {
            Vector3 tmp_NewRotationEuler = _targetPose.rotation.eulerAngles;

            if ((permittedRotationAxis & XRGeneralGrabTransformer.ManipulationAxes.X) == 0)
                tmp_NewRotationEuler.x = initialEulerRotation.x;

            if ((permittedRotationAxis & XRGeneralGrabTransformer.ManipulationAxes.Y) == 0)
                tmp_NewRotationEuler.y = initialEulerRotation.y;

            if ((permittedRotationAxis & XRGeneralGrabTransformer.ManipulationAxes.Z) == 0)
                tmp_NewRotationEuler.z = initialEulerRotation.z;

            _targetPose.rotation = Quaternion.Euler(tmp_NewRotationEuler);
        }
    }
}

#endif