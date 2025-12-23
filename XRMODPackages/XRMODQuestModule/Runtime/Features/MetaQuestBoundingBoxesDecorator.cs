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
using UnityEngine.XR.ARFoundation;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    /// <summary>
    /// Feature decorator for handling AR Bounding Boxes on Meta Quest.
    /// <para>
    /// Initializes the <see cref="ARBoundingBoxManager"/> and listens for trackable changes, notifying the system via <see cref="ActionNotificationCenter"/>.
    /// </para>
    /// </summary>
    public class MetaQuestBoundingBoxesDecorator : BaseMetaQuestFeatureDecorator
    {
        private ArchitectureComponentsModel architectureComponentsModel;
        private ARBoundingBoxArgs boundingBoxArgs;

        /// <summary>
        /// Starts the bounding box algorithm.
        /// <para>
        /// Sets up the <see cref="ARBoundingBoxManager"/> if missing and subscribes to trackable changes.
        /// </para>
        /// </summary>
        public override void StartAlgorithm()
        {
            base.StartAlgorithm();

            architectureComponentsModel = IocContainer.GetIoc.Resolve<ArchitectureComponentsModel>();
            if (architectureComponentsModel.BoundingBoxManager == null)
            {
                architectureComponentsModel.BoundingBoxManager =
                    architectureComponentsModel.XRRig.AddComponent<ARBoundingBoxManager>();
            }

            boundingBoxArgs = new ARBoundingBoxArgs();
            architectureComponentsModel.BoundingBoxManager.trackablesChanged.AddListener(TrackableChanged);
        }

        /// <summary>
        /// Callback for when AR Bounding Boxes change (added, updated, removed).
        /// <para>
        /// Posts notifications with <see cref="ARBoundingBoxArgs"/> containing updated data.
        /// </para>
        /// </summary>
        /// <param name="_arg0">The event arguments containing changed bounding boxes.</param>
        private void TrackableChanged(ARTrackablesChangedEventArgs<ARBoundingBox> _arg0)
        {
            foreach (var tmp_Updated in _arg0.added)
            {
                boundingBoxArgs.Classification = tmp_Updated.classifications.ToString();
                boundingBoxArgs.Size = tmp_Updated.size;
                ActionNotificationCenter.DefaultCenter.PostNotification("", boundingBoxArgs);
            }

            foreach (var tmp_Updated in _arg0.updated)
            {
                boundingBoxArgs.Classification = tmp_Updated.classifications.ToString();
                boundingBoxArgs.Size = tmp_Updated.size;
                ActionNotificationCenter.DefaultCenter.PostNotification("", boundingBoxArgs);
            }

            foreach (var tmp_Updated in _arg0.removed)
            {
                boundingBoxArgs.TrackingId = tmp_Updated.Key.ToString();
                boundingBoxArgs.Classification = tmp_Updated.Value.classifications.ToString();
                boundingBoxArgs.Size = tmp_Updated.Value.size;
                ActionNotificationCenter.DefaultCenter.PostNotification("", boundingBoxArgs);
            }
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
        /// Pauses the bounding box algorithm.
        /// </summary>
        public override void PauseAlgorithm()
        {
        }

        /// <summary>
        /// Stops the bounding box algorithm.
        /// </summary>
        public override void StopAlgorithm()
        {
        }
    }
}