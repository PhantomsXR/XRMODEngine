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
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.ARFoundation;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class InitializeARComponentCommand : ICommand, IReleaseCommand
    {
        public void Execute()
        {
            ARComponentModel tmp_ARComponentData = IocContainer.GetIoc.Resolve<ARComponentModel>();

            tmp_ARComponentData.XROriginGameObject = GameObject.FindWithTag(ConstKey.CONST_AR_SESSION_ORIGIN_NAME);
            tmp_ARComponentData.SessionGameObject = GameObject.FindWithTag(ConstKey.CONST_AR_SESSION_NAME);

            Assert.IsNotNull(tmp_ARComponentData.SessionGameObject);
            Assert.IsNotNull(tmp_ARComponentData.XROriginGameObject);

            tmp_ARComponentData.ARSession = tmp_ARComponentData.SessionGameObject.GetComponentInChildren<ARSession>();
            Assert.IsNotNull(tmp_ARComponentData.ARSession);

            tmp_ARComponentData.ARInputManager =
                tmp_ARComponentData.SessionGameObject.GetComponentInChildren<ARInputManager>();
            Assert.IsNotNull(tmp_ARComponentData.ARInputManager);

            if (!tmp_ARComponentData.XROriginGameObject) return;
            tmp_ARComponentData.XROrigin = tmp_ARComponentData.XROriginGameObject.GetComponent<XROrigin>();

            Assert.IsNotNull(tmp_ARComponentData.XROrigin);

            tmp_ARComponentData.ARCamera = tmp_ARComponentData.XROriginGameObject.GetComponentInChildren<Camera>();
            Assert.IsNotNull(tmp_ARComponentData.ARCamera);

            tmp_ARComponentData.CameraGameObject = tmp_ARComponentData.ARCamera.gameObject;
            Assert.IsNotNull(tmp_ARComponentData.CameraGameObject);

            tmp_ARComponentData.ARPoseDriverExtension = tmp_ARComponentData.ARCamera.GetComponent<TrackedPoseDriver>();
            Assert.IsNotNull(tmp_ARComponentData.ARPoseDriverExtension);
        }

        public void Release(string _projectName = null)
        {
        }
    }
}