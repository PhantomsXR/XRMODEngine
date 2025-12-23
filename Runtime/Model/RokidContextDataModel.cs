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
    /// <summary>
    /// Runtime data model holding context specific to the Rokid module.
    /// Manages settings and references used across different features.
    /// </summary>
    public class RokidContextDataModel : IModel, IReleaseCommand
    {
        /// <summary>
        /// Gets or sets the plane detection mode using ARSubsystems.
        /// </summary>
        public PlaneDetectionMode PlaneDetectionMode { get; set; }

        /// <summary>
        /// Gets or sets the prefab used for visualizing detected planes.
        /// </summary>
        public GameObject PlaneVisualizer { get; set; }

        /// <summary>
        /// Gets or sets the parameters for Immersal localization.
        /// </summary>
        public ImmersalContextDataModel ImmersalParameters { get; set; }

        //visualizer
        /// <summary>
        /// Name of the custom plane visualizer to load.
        /// </summary>
        public string CustomPlaneVisualizerName;

        /// <summary>
        /// Initializes the context data model.
        /// </summary>
        public void Initialize()
        {
        }

        /// <summary>
        /// Releases resources and resets the model.
        /// </summary>
        /// <param name="_projectName">Optional project name.</param>
        public void Release(string _projectName = default)
        {
            ImmersalParameters = null;
        }
    }
}