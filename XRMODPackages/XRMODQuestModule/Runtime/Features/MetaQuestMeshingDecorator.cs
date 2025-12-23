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
    /// <summary>
    /// Feature decorator for Meta Quest Meshing.
    /// <para>
    /// Manages the <see cref="ARMeshManager"/> and dispatches notifications when meshes are added, updated, or removed.
    /// </para>
    /// </summary>
    public class MetaQuestMeshingDecorator : BaseMetaQuestFeatureDecorator
    { 
        private OnEventMeshEventArgs onEventMeshEventArgs;
        private ARMeshManager meshManager;
        private ArchitectureComponentsModel architectureComponentsModel;
        private List<XRMeshSubsystem> subsystems = new();

        /// <summary>
        /// Starts the meshing algorithm.
        /// <para>
        /// Activates the Mesh Manager and subscribes to mesh change events.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Callback for mesh changes.
        /// <para>
        /// Posts an <see cref="ActionParameterDataType.OnEvent"/> notification with mesh data.
        /// </para>
        /// </summary>
        /// <param name="_obj">Event arguments containing changed meshes.</param>
        private void OnMeshesChanged(ARMeshesChangedEventArgs _obj)
        {
            onEventMeshEventArgs.Added = _obj.added;
            onEventMeshEventArgs.Updated = _obj.updated;
            onEventMeshEventArgs.Removed = _obj.removed;
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                onEventMeshEventArgs);
        }

        /// <summary>
        /// Determines if this feature is supported.
        /// </summary>
        /// <returns>True if XR Mesh Subsystems are available.</returns>
        public override bool SupportThisFeature()
        {
            return subsystems.Count > 0;
        }

        /// <summary>
        /// Pauses the algorithm.
        /// </summary>
        public override void PauseAlgorithm()
        {
        }

        /// <summary>
        /// Stops the meshing algorithm.
        /// <para>
        /// Destroys all meshes and deactivates the Mesh Manager.
        /// </para>
        /// </summary>
        public override void StopAlgorithm()
        {
            meshManager?.DestroyAllMeshes();
            IocContainer.GetIoc.Resolve<ArchitectureComponentsModel>().MeshManager.gameObject.SetActive(false);
        }
    }
}