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

using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.OpenXRMOD.Runtime;
using Phantom.XRMOD.XRMODInput.Runtime;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.XR.Interaction.Toolkit.Locomotion;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    /// <summary>
    /// Holds references to the essential architectural components of the Quest XR rig.
    /// <para>
    /// This model is responsible for locating and caching references to cameras, managers (AR, Input, Occlusion),
    /// providers (Locomotion, Turn, Climb), and controller transforms. It acts as a central registry for accessing these components.
    /// </para>
    /// </summary>
    public class ArchitectureComponentsModel : IModel, IReleaseCommand
    {
        internal Camera ARCamera;
        internal GameObject XRRig;
        internal ARSession ARSession;
        internal CharacterController CharacterController;
        internal ARCameraManager CameraManager;
        internal ARMeshManager MeshManager;
        internal AROcclusionManager OcclusionManager;
        internal ARBoundingBoxManager BoundingBoxManager;
        internal XRInputModalityManager XRInputModalityManager;
        internal OpenXRPermissionManager OpenXRPermissionManager { get; private set; }

        // Locomotion
        internal LocomotionProvider LocomotionProvider;
        internal ContinuousTurnProvider ContinuousTurnProvider;
        internal DynamicMoveProvider DynamicMoveProvider;
        internal GrabMoveProvider GrabMoveProvider;
        internal ClimbProvider ClimbProvider;
        internal TeleportationProvider TeleportationProvider;

        // Controllers
        internal Transform LeftController;
        internal Transform LeftControllerPoke;
        internal Transform LeftControllerNearFar;
        internal Transform LeftControllerTeleport;
        internal Transform LeftControllerVisualizer;

        internal Transform RightController;
        internal Transform RightControllerPoke;
        internal Transform RightControllerNearFar;
        internal Transform RightControllerTeleport;
        internal Transform RightControllerVisualizer;


        // Hands
        internal Transform LeftHandController;
        internal Transform LeftHandControllerPoke;
        internal Transform LeftHandControllerNearFar;
        internal Transform LeftHandControllerVisualizer;


        internal Transform RightHandController;
        internal Transform RightHandControllerPoke;
        internal Transform RightHandControllerNearFar;
        internal Transform RightHandControllerVisualizer;

        private GameObject defaultQuestLauncherGo;


        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectureComponentsModel"/> class.
        /// <para>
        /// automatically calls <see cref="Initialize"/> to find and cache component references.
        /// </para>
        /// </summary>
        public ArchitectureComponentsModel()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes the model by finding the "DefaultQuestLauncher(Clone)" GameObject and caching its child components.
        /// </summary>
        public void Initialize()
        {
            defaultQuestLauncherGo = GameObject.Find("DefaultQuestLauncher(Clone)");
            Assert.IsNotNull(defaultQuestLauncherGo);
            XRRig = defaultQuestLauncherGo.transform.GetChild(0).gameObject;
            Assert.IsNotNull(XRRig);
            OpenXRPermissionManager = defaultQuestLauncherGo.GetComponent<OpenXRPermissionManager>();
            MeshManager = defaultQuestLauncherGo.GetComponentInChildren<ARMeshManager>(true);
            Assert.IsNotNull(MeshManager);
            CameraManager = defaultQuestLauncherGo.GetComponentInChildren<ARCameraManager>(true);
            LocomotionProvider = defaultQuestLauncherGo.GetComponentInChildren<LocomotionProvider>(true);
            ContinuousTurnProvider = defaultQuestLauncherGo.GetComponentInChildren<ContinuousTurnProvider>(true);
            DynamicMoveProvider = defaultQuestLauncherGo.GetComponentInChildren<DynamicMoveProvider>(true);
            GrabMoveProvider = defaultQuestLauncherGo.GetComponentInChildren<GrabMoveProvider>(true);
            ClimbProvider = defaultQuestLauncherGo.GetComponentInChildren<ClimbProvider>(true);
            TeleportationProvider = defaultQuestLauncherGo.GetComponentInChildren<TeleportationProvider>(true);

            CharacterController = defaultQuestLauncherGo.GetComponentInChildren<CharacterController>(true);
            OcclusionManager = defaultQuestLauncherGo.GetComponentInChildren<AROcclusionManager>(true);
            XRInputModalityManager = defaultQuestLauncherGo.GetComponentInChildren<XRInputModalityManager>(true);

            ARCamera = Camera.main;
            Assert.IsNotNull(ARCamera);

            ARSession = Object.FindFirstObjectByType<ARSession>(FindObjectsInactive.Include);

            var tmp_Transform = defaultQuestLauncherGo.transform;

            LeftController = tmp_Transform.Find("XRMODRig/Camera Offset/Left Controller");
            LeftControllerPoke = LeftController.Find("Poke Interactor");
            LeftControllerNearFar = LeftController.Find("Near-Far Interactor");
            LeftControllerTeleport = LeftController.Find("Teleport Interactor");
            LeftControllerVisualizer = LeftController.Find("Left Controller Visualizer");


            RightController = tmp_Transform.Find("XRMODRig/Camera Offset/Right Controller");
            RightControllerPoke = RightController.Find("Poke Interactor");
            RightControllerNearFar = RightController.Find("Near-Far Interactor");
            RightControllerTeleport = RightController.Find("Teleport Interactor");
            RightControllerVisualizer = RightController.Find("Right Controller Visualizer");


            LeftHandController = tmp_Transform.Find("XRMODRig/Camera Offset/Left Hand");
            LeftHandControllerPoke = LeftHandController.Find("Poke Interactor");
            LeftHandControllerNearFar = LeftHandController.Find("Near-Far Interactor");
            LeftHandControllerVisualizer = LeftHandController.Find("Left Hand Visualizer");


            RightHandController = tmp_Transform.Find("XRMODRig/Camera Offset/Right Hand");
            RightHandControllerPoke = RightHandController.Find("Poke Interactor");
            RightHandControllerNearFar = RightHandController.Find("Near-Far Interactor");
            RightHandControllerVisualizer = RightHandController.Find("Right Hand Visualizer");
        }

        /// <summary>
        /// Releases resources. (Currently empty).
        /// </summary>
        /// <param name="_projectName">Optional project name context.</param>
        public void Release(string _projectName = default)
        {
        }
    }
}