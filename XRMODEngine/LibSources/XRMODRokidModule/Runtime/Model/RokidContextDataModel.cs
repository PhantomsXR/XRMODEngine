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
using Phantom.XRMOD.Models.Runtime;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    public class RokidContextDataModel : IModel, IReleaseCommand
    {
        public PlaneDetectionMode PlaneDetectionMode { get; set; }
        public GameObject PlaneVisualizer { get; set; }

        public ImmersalContextDataModel ImmersalParameters { get; set; }

        //visualizer
        public string CustomPlaneVisualizerName;

        public void Initialize()
        {
        }

        public void Release(string _projectName = default)
        {
            ImmersalParameters = null;
        }
    }
}