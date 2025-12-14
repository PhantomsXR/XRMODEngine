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
    [System.Serializable]
    public class XRControllerVisualizerGroup
    {
        public string Name;
        public PlatformType PlatformType;
        public GameObject LeftXRController;
        public GameObject RightXRController;

        public XRControllerVisualizerGroup()
        {
            Disabled();
        }

        public void Enabled()
        {
            if (LeftXRController)
                LeftXRController.SetActive(true);
            if (RightXRController)
                RightXRController.SetActive(true);
        }

        public void Disabled()
        {
            if (LeftXRController)
                LeftXRController.SetActive(false);
            if (RightXRController)
                RightXRController.SetActive(false);
        }
    }

    public class XRControllerVisualizerManager : MonoBehaviour
    {
        [SerializeField] private List<XRControllerVisualizerGroup> xrControllerVisualizerGroups = new();

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