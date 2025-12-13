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
    public class XRConfiguresModel : BaseExperienceConfigModel
    {
        public string CustomMeshVisualizerName;

        //Occlusion
        public bool UseOcclusion;
        public bool EnableHandRemoval = true;
        public bool TemporalSmoothing = true;
        public EnvironmentDepthMode EnvironmentDepthMode;
        public HumanSegmentationDepthMode HumanSegmentationDepthMode;
        public HumanSegmentationStencilMode HumanSegmentationStencilMode;
        public OcclusionPreferenceMode OcclusionPreferenceMode;
    }
}