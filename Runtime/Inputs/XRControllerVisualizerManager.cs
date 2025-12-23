// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.QuestModule.Runtime.
// //
// // The UnityXR-MODLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    /// <summary>
    /// Represents a group of visualizers for XR controllers on a specific platform.
    /// </summary>
    [System.Serializable]
    public class XRControllerVisualizerGroup
    {
        /// <summary>
        /// Name of the visualizer group.
        /// </summary>
        public string Name;

        /// <summary>
        /// The platform type this group belongs to.
        /// </summary>
        public PlatformType PlatformType;

        /// <summary>
        /// GameObject for the Left Controller visualizer.
        /// </summary>
        public GameObject LeftXRController;

        /// <summary>
        /// GameObject for the Right Controller visualizer.
        /// </summary>
        public GameObject RightXRController;

        /// <summary>
        /// Initializes a new instance of the <see cref="XRControllerVisualizerGroup"/> class and disables visualizers by default.
        /// </summary>
        public XRControllerVisualizerGroup()
        {
            Disabled();
        }

        /// <summary>
        /// Activates the visualizers for both controllers.
        /// </summary>
        public void Enabled()
        {
            if (LeftXRController)
                LeftXRController.SetActive(true);
            if (RightXRController)
                RightXRController.SetActive(true);
        }

        /// <summary>
        /// Deactivates the visualizers for both controllers.
        /// </summary>
        public void Disabled()
        {
            if (LeftXRController)
                LeftXRController.SetActive(false);
            if (RightXRController)
                RightXRController.SetActive(false);
        }
    }

    /// <summary>
    /// Manages the activation of controller visualizers based on the current platform.
    /// </summary>
    public class XRControllerVisualizerManager : MonoBehaviour
    {
        [SerializeField] private List<XRControllerVisualizerGroup> xrControllerVisualizerGroups = new();

        /// <summary>
        /// Unity Start lifecycle method.
        /// <para>
        /// Disables all groups initially, then enables the group matching the current Quest platform.
        /// </para>
        /// </summary>
        private void Start()
        {
            foreach (XRControllerVisualizerGroup tmp_Group in xrControllerVisualizerGroups)
            {
                tmp_Group.Disabled();
            }
#if !UNITY_EDITOR
            var tmp_QuestPlatform = RuntimePlatformHelper.GetQuestModel();
            var tmp_XRControllerVisualizerGroup =
                xrControllerVisualizerGroups.Find(_controller => _controller.PlatformType == tmp_QuestPlatform);
            if (tmp_XRControllerVisualizerGroup != null)
                tmp_XRControllerVisualizerGroup.Enabled();
#else
            var tmp_XRControllerVisualizerGroup =
                xrControllerVisualizerGroups.Find(_controller => _controller.PlatformType == PlatformType.Quest3);
            if (tmp_XRControllerVisualizerGroup != null)
                tmp_XRControllerVisualizerGroup.Enabled();
#endif
        }
    }
}