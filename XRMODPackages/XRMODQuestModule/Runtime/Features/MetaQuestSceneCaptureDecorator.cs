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

using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine.XR.OpenXR.Features.Meta;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    /// <summary>
    /// Feature decorator for triggering Meta Quest Scene Capture (Spatial Setup).
    /// <para>
    /// Listens for a capture environment notification to request scene capture from the system.
    /// </para>
    /// </summary>
    public class MetaQuestSceneCaptureDecorator : BaseMetaQuestFeatureDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaQuestSceneCaptureDecorator"/> class.
        /// <para>
        /// Subscribes to the "CaptureEnvironment" notification.
        /// </para>
        /// </summary>
        public MetaQuestSceneCaptureDecorator()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(CaptureEnvironment, nameof(CaptureEnvironment));
        }

        /// <summary>
        /// Requests scene capture via <see cref="MetaOpenXRSessionSubsystem"/>.
        /// </summary>
        /// <param name="_obj">Notification data (unused).</param>
        private void CaptureEnvironment(BaseNotificationData _obj)
        {
            var tmp_ArchitectureComponentsModel = IocContainer.GetIoc.Resolve<ArchitectureComponentsModel>();
            if (tmp_ArchitectureComponentsModel.ARSession.subsystem is MetaOpenXRSessionSubsystem tmp_SceneCapture)
                tmp_SceneCapture.TryRequestSceneCapture();
        }


        /// <summary>
        /// Determines if this feature is supported.
        /// </summary>
        /// <returns>Always returns true.</returns>
        public override bool SupportThisFeature()
        {
            return true;
        }

        /// <summary>
        /// Pauses the algorithm.
        /// </summary>
        public override void PauseAlgorithm()
        {
        }

        /// <summary>
        /// Stops the algorithm and unsubscribes from notifications.
        /// </summary>
        public override void StopAlgorithm()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(CaptureEnvironment));
        }
    }
}