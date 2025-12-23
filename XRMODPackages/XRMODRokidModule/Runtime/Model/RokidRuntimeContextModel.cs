// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.RokidModule.Runtime.
// //
// // The RokidPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Core.Runtime;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    /// <summary>
    /// Holds references to runtime objects in the Rokid scene hierarchy.
    /// Manages access to hands, controllers, visualizers, and AR subsystems.
    /// </summary>
    public class RokidRuntimeContextModel : IModel
    {
        internal GameObject RightHand, LeftHand, HandVisualizer, HandPostProcessor, ThreeDRay;
        private Transform xrmodRigTransform;
        internal ARSession XRSession;
        internal XROrigin XROrigin;
        internal XRInputModalityManager XRInputModalityManager;


        internal ARPlaneManager arPlaneManager;
        internal ARTrackedImageManager arTrackedImageManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="RokidRuntimeContextModel"/>.
        /// </summary>
        /// <param name="_xrmodRigTransform">The transform of the XRMOD Rig.</param>
        public RokidRuntimeContextModel(Transform _xrmodRigTransform)
        {
            xrmodRigTransform = _xrmodRigTransform;
        }

        /// <summary>
        /// Initializes the runtime context by finding and assigning references to scene objects.
        /// </summary>
        public void Initialize()
        {
            xrmodRigTransform.TryGetComponent(out XROrigin);
            XRSession = Object.FindFirstObjectByType<ARSession>();

            var tmp_CameraOffsetTransform = xrmodRigTransform.Find("Camera Offset");
            RightHand = tmp_CameraOffsetTransform.Find("Right Hand").gameObject;
            LeftHand = tmp_CameraOffsetTransform.Find("Left Hand").gameObject;
            ThreeDRay = tmp_CameraOffsetTransform.Find("3DofRay").gameObject;
            HandVisualizer = tmp_CameraOffsetTransform.Find("Hand Visualizer").gameObject;
            HandPostProcessor = xrmodRigTransform.Find("Hands Smoothing Post Processor").gameObject;
            XRInputModalityManager = Object.FindAnyObjectByType<XRInputModalityManager>(FindObjectsInactive.Include);
        }
    }
}