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
using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    public class PlaneDetectorFeature : IFeatureDecorator
    {
        private ARPlaneManager arPlaneManager;
        private RokidContextDataModel context;


        public PlaneDetectorFeature()
        {
            context = IocContainer.GetIoc.Resolve<RokidContextDataModel>();
            var tmp_RokidRuntimeContext = IocContainer.GetIoc.Resolve<RokidRuntimeContextModel>();
            arPlaneManager = tmp_RokidRuntimeContext.XROrigin.gameObject.AddComponent<ARPlaneManager>();
            tmp_RokidRuntimeContext.arPlaneManager = arPlaneManager;
        }

        public bool SupportThisFeature()
        {
            return SystemInfo.deviceModel.Contains("Max Pro");
        }

        public void StartAlgorithm()
        {
            arPlaneManager.requestedDetectionMode = context.PlaneDetectionMode;
            arPlaneManager.planePrefab = context.PlaneVisualizer;
            arPlaneManager.enabled = true;
        }

        public void PauseAlgorithm()
        {
            arPlaneManager.enabled = false;
        }

        public void StopAlgorithm()
        {
            arPlaneManager.enabled = false;
            arPlaneManager.subsystem?.Stop();
            arPlaneManager.subsystem?.Destroy();
            Object.Destroy(arPlaneManager);
            arPlaneManager = null;
        }
    }
}