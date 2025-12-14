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
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    public class MetaQuestMeshingDecorator : BaseMetaQuestFeatureDecorator
    { 
        private OnEventMeshEventArgs onEventMeshEventArgs;
        private ARMeshManager meshManager;
        private ArchitectureComponentsModel architectureComponentsModel;
        private List<XRMeshSubsystem> subsystems = new();

        public override void StartAlgorithm()
        {
            base.StartAlgorithm();
            SubsystemManager.GetSubsystems(subsystems);
            architectureComponentsModel = IocContainer.GetIoc.Resolve<ArchitectureComponentsModel>();
            meshManager = architectureComponentsModel.MeshManager;
            onEventMeshEventArgs = new OnEventMeshEventArgs();
            meshManager.meshesChanged += OnMeshesChanged;
            meshManager.gameObject.SetActive(true);
        }

        private void OnMeshesChanged(ARMeshesChangedEventArgs _obj)
        {
            onEventMeshEventArgs.Added = _obj.added;
            onEventMeshEventArgs.Updated = _obj.updated;
            onEventMeshEventArgs.Removed = _obj.removed;
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                onEventMeshEventArgs);
        }

        public override bool SupportThisFeature()
        {
            return subsystems.Count > 0;
        }

        public override void PauseAlgorithm()
        {
        }

        public override void StopAlgorithm()
        {
            meshManager?.DestroyAllMeshes();
            IocContainer.GetIoc.Resolve<ArchitectureComponentsModel>().MeshManager.gameObject.SetActive(false);
        }
    }
}