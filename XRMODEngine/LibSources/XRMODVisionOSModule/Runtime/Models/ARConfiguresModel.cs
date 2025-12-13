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

using Phantom.XRMOD.Models.Runtime;
using UnityEngine.XR.ARSubsystems;

namespace Phantom.XRMOD.VisionOSModule.Runtime.Models
{
    public class ARConfiguresModel:BaseExperienceConfigModel
    {
        public PlaneDetectionMode PlaneDetectionMode = PlaneDetectionMode.Horizontal;

        //visualizer
        public string CustomPointCloudVisualizerName;
        public string CustomPlaneVisualizerName;
        public string CustomMeshVisualizerName;


        //2d features
        public int MaxMovingOfTracking;

    }
}