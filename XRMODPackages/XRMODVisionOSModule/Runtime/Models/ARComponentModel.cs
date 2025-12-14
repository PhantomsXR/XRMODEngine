// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VisionOSModule.Runtime.
// //
// // The AVPPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Core.Runtime;
using Unity.PolySpatial;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using UnityEngine.XR.ARFoundation;

namespace Phantom.XRMOD.VisionOSModule.Runtime.Models
{
    [Preserve]
    public class ARComponentModel : IModel, IReleaseCommand
    {
        public GameObject CameraGameObject;
        public GameObject SessionGameObject;
        public GameObject XROriginGameObject;
        public XROrigin XROrigin;

        public Camera ARCamera;
        public ARSession ARSession;
        public ARInputManager ARInputManager;
        public VolumeCamera VolumeCamera;

        public ARRaycastManager ARRaycastManager;

        // public ARPoseDriver ARPoseDriverExtension;
        public TrackedPoseDriver ARPoseDriverExtension;
        public ARCameraBackground ARCameraBackground;
        public ARAnchorManager ARAnchorManager;
        public AROcclusionManager AROcclusionManager;
        public ARTrackedImageManager ARTrackedImageManager;
        public ARMeshManager ARMeshManager;
        public ARPlaneManager ARPlaneManager;
        public ARPointCloudManager ARPointCloudManager;

        //public readonly Dictionary<Type, AbstractDecorator> AbstractDecorators = new();

        public void Initialize()
        {
            throw new System.NotImplementedException();
        }

        public void Release(string _projectName = default)
        {
            // foreach (KeyValuePair<Type, AbstractDecorator> tmp_Decorator in AbstractDecorators)
            // {
            //     tmp_Decorator.Value.StopAlgorithm();
            // }
            //
            // AbstractDecorators.Clear();

            FeatureManager.CleanUpFeatures();

            CameraGameObject = null;
            SessionGameObject = null;
            XROriginGameObject = null;
            ARCamera = null;
            ARSession = null;
            ARInputManager = null;
            VolumeCamera = null;
            ARPoseDriverExtension = null;
            ARCameraBackground = null;
            AROcclusionManager = null;
            ARTrackedImageManager = null;
            ARMeshManager = null;
            ARPlaneManager = null;
            ARPointCloudManager = null;
        }
    }
}