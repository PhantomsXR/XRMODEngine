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
    public class MetaQuestBoundingBoxesDecorator : BaseMetaQuestFeatureDecorator
    {
        private ArchitectureComponentsModel architectureComponentsModel;
        private ARBoundingBoxArgs boundingBoxArgs;

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

        public override bool SupportThisFeature()
        {
            return true;
        }

        public override void PauseAlgorithm()
        {
        }

        public override void StopAlgorithm()
        {
        }
    }
}