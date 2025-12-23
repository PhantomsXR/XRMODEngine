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
    /// <summary>
    /// Configuration model for Rokid module experiences.
    /// Contains settings for plane detection, visualization, and Immersal integration.
    /// </summary>
    public class RokidConfiguresModel : BaseExperienceConfigModel
    {
        /// <summary>
        /// Gets or sets the plane detection mode.
        /// </summary>
        public PlaneDetectionMode PlaneDetectionMode = PlaneDetectionMode.Horizontal;

        //visualizer
        /// <summary>
        /// Name of the custom point cloud visualizer prefab.
        /// </summary>
        public string CustomPointCloudVisualizerName;

        /// <summary>
        /// Name of the custom plane visualizer prefab.
        /// </summary>
        public string CustomPlaneVisualizerName;


        //2d features
        /// <summary>
        /// Maximum allowed movement for tracking (deprecated or specific to 2D features).
        /// </summary>
        public int MaxMovingOfTracking;

        //immersal
        /// <summary>
        /// Enable or disable Immersal burst mode for faster initial localization.
        /// </summary>
        public bool BurstMode;

        /// <summary>
        /// Automatically start localization on module start.
        /// </summary>
        public bool AutoStart;

        /// <summary>
        /// Developer token for Immersal SDK authentication.
        /// </summary>
        public string DeveloperToken;

        /// <summary>
        /// Interval between localization attempts in seconds.
        /// </summary>
        public float LocalizationInterval;

        /// <summary>
        /// Use the server-side localizer instead of on-device localization.
        /// </summary>
        public bool UseServerLocalizer;

        /// <summary>
        /// Stop localizing after a successful localization.
        /// </summary>
        public bool StopLocalizedAfterSuccess = true;

        /// <summary>
        /// Use filtering to improve localization accuracy.
        /// </summary>
        public bool UseFiltering;

        /// <summary>
        /// Continue localizing even after success (overrides StopLocalizedAfterSuccess if handled logically).
        /// </summary>
        public bool ContinueLocalizer;
    }
}