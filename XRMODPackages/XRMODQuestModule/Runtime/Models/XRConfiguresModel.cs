// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.QuestModule.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Models.Runtime;
using UnityEngine.XR.ARSubsystems;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    /// <summary>
    /// Configuration model for Meta Quest specific features.
    /// <para>
    /// Contains settings for mesh visualization, occlusion preferences, depth modes, and hand removal.
    /// </para>
    /// </summary>
    public class XRConfiguresModel : BaseExperienceConfigModel
    {
        /// <summary>
        /// Name of the custom mesh visualizer prefab.
        /// </summary>
        public string CustomMeshVisualizerName;

        //Occlusion
        /// <summary>
        /// Whether to enable occlusion.
        /// </summary>
        public bool UseOcclusion;

        /// <summary>
        /// Whether to enable automatic hand removal in the occlusion map.
        /// </summary>
        public bool EnableHandRemoval = true;

        /// <summary>
        /// Whether to enable temporal smoothing for environment depth.
        /// </summary>
        public bool TemporalSmoothing = true;

        /// <summary>
        /// The requested environment depth mode.
        /// </summary>
        public EnvironmentDepthMode EnvironmentDepthMode;

        /// <summary>
        /// The requested human segmentation depth mode.
        /// </summary>
        public HumanSegmentationDepthMode HumanSegmentationDepthMode;

        /// <summary>
        /// The requested human segmentation stencil mode.
        /// </summary>
        public HumanSegmentationStencilMode HumanSegmentationStencilMode;

        /// <summary>
        /// The requested occlusion preference mode.
        /// </summary>
        public OcclusionPreferenceMode OcclusionPreferenceMode;
    }
}