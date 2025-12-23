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

using System.Collections.Generic;
using System.Linq;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.OpenXR.Features.Meta;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    /// <summary>
    /// Feature decorator for Meta Quest Occlusion.
    /// <para>
    /// Configures <see cref="AROcclusionManager"/> settings such as environment depth and human segmentation 
    /// based on the runtime configuration.
    /// </para>
    /// </summary>
    public class MetaQuestOcclusionDecorator : BaseMetaQuestFeatureDecorator
    {
        MetaOpenXROcclusionSubsystem metaOpenXROcclusionSubsystem;
        AROcclusionManager occlusionManager;

        /// <summary>
        /// Starts the occlusion algorithm.
        /// <para>
        /// Retrives the Meta OpenXR Occlusion subsystem and applies settings (Depth Mode, Human Segmentation, etc.) 
        /// from the <see cref="XRConfiguresModel"/>.
        /// </para>
        /// </summary>
        public override void StartAlgorithm()
        {
            base.StartAlgorithm();
            var tmp_XRConfiguresModel = IocContainer.GetIoc.Resolve<XRConfiguresModel>();
            List<XROcclusionSubsystem> tmp_Subsystems = new();
            SubsystemManager.GetSubsystems(tmp_Subsystems);
            if (tmp_Subsystems.Count > 0 &&
                tmp_Subsystems.FirstOrDefault() is MetaOpenXROcclusionSubsystem tmp_MetaOpenXROcclusionSubsystem)
            {
                metaOpenXROcclusionSubsystem = tmp_MetaOpenXROcclusionSubsystem;
            }

            if (metaOpenXROcclusionSubsystem != null)
            {
                metaOpenXROcclusionSubsystem.TrySetHandRemovalEnabled(tmp_XRConfiguresModel.EnableHandRemoval);
            }

            occlusionManager = IocContainer.GetIoc.Resolve<ArchitectureComponentsModel>().OcclusionManager;
            occlusionManager.requestedEnvironmentDepthMode = tmp_XRConfiguresModel.EnvironmentDepthMode;
            occlusionManager.requestedHumanDepthMode = tmp_XRConfiguresModel.HumanSegmentationDepthMode;
            occlusionManager.requestedHumanStencilMode = tmp_XRConfiguresModel.HumanSegmentationStencilMode;
            occlusionManager.environmentDepthTemporalSmoothingRequested = tmp_XRConfiguresModel.TemporalSmoothing;
            occlusionManager.requestedOcclusionPreferenceMode = tmp_XRConfiguresModel.OcclusionPreferenceMode;
            occlusionManager.gameObject.SetActive(tmp_XRConfiguresModel.UseOcclusion);
        }

        /// <summary>
        /// Determines if this feature is supported.
        /// </summary>
        /// <returns>True if the Meta OpenXR Occlusion subsystem is available.</returns>
        public override bool SupportThisFeature()
        {
            return metaOpenXROcclusionSubsystem != null;
        }

        /// <summary>
        /// Pauses the algorithm.
        /// </summary>
        public override void PauseAlgorithm()
        {
        }

        /// <summary>
        /// Stops the occlusion algorithm.
        /// </summary>
        public override void StopAlgorithm()
        {
            occlusionManager.gameObject.SetActive(false);
        }
    }
}