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
    /// <summary>
    /// Implementation of <see cref="IFeatureDecorator"/> for plane detection on Rokid devices.
    /// Manages the <see cref="ARPlaneManager"/> lifecycle and its visualizer.
    /// </summary>
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

        /// <summary>
        /// Checks if plane detection is supported on the current device.
        /// Currently restricts support to "Station Pro" models (checked via "Max Pro" substring).
        /// </summary>
        /// <returns>True if supported.</returns>
        public bool SupportThisFeature()
        {
            return SystemInfo.deviceModel.Contains("Max Pro");
        }

        /// <summary>
        /// Starts the plane detection algorithm.
        /// Configures the detection mode and visualizer, then enables the plane manager.
        /// </summary>
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

        /// <summary>
        /// Stops the plane detection algorithm.
        /// Disables and destroys the plane manager and its subsystems.
        /// </summary>
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