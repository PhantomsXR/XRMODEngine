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

using Phantom.XRMOD.Models.Runtime;
using UnityEngine.XR.ARSubsystems;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    public class RokidConfiguresModel : BaseExperienceConfigModel
    {
        public PlaneDetectionMode PlaneDetectionMode = PlaneDetectionMode.Horizontal;

        //visualizer
        public string CustomPointCloudVisualizerName;
        public string CustomPlaneVisualizerName;


        //2d features
        public int MaxMovingOfTracking;

        //immersal
        public bool BurstMode;
        public bool AutoStart;
        public string DeveloperToken;
        public float LocalizationInterval;
        public bool UseServerLocalizer;
        public bool StopLocalizedAfterSuccess = true;
        public bool UseFiltering;
        public bool ContinueLocalizer;
    }
}