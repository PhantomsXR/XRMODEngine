// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VisionOSModule.Runtime.
// //
// // The AVPPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using PlaneAlignment = Phantom.XRMOD.ActionNotification.Runtime.PlaneAlignment;
using PlaneClassification = Phantom.XRMOD.ActionNotification.Runtime.PlaneClassification;

namespace Phantom.XRMOD.VisionOSModule.Runtime.ExtensionComponents
{
    public class FocusPlacementExtension : MonoBehaviour
    {
        private Transform mainCameraTransform;

        private OnEventFocusEventArgs onEventFocusNotificationData;

        internal bool Running;
        private RaycastHit hits;


        private void Update()
        {
            //if (Application.isEditor) return;
            if (!Running) return;
            if (!mainCameraTransform) return;


            if (Physics.Raycast(new Ray(mainCameraTransform.position, mainCameraTransform.forward), out hits))
            {
                if (hits.transform.TryGetComponent<ARPlane>(out var tmp_ARPlane))
                {
                    onEventFocusNotificationData.FocusState = FindingType.Found;
                    onEventFocusNotificationData.PlaneAlignment = (PlaneAlignment) tmp_ARPlane.alignment;
                    onEventFocusNotificationData.Size = tmp_ARPlane.size;
                    onEventFocusNotificationData.PlaneClassification = (PlaneClassification) tmp_ARPlane.classification;
                    onEventFocusNotificationData.FocusPos = hits.point;
                    onEventFocusNotificationData.FocusRot = Quaternion.FromToRotation(Vector3.up, hits.normal);
                }
                else
                {
                    onEventFocusNotificationData.FocusState = FindingType.Finding;
                }
            }
            else
            {
                onEventFocusNotificationData.FocusState = FindingType.Limit;
            }

            if (onEventFocusNotificationData.FocusState != FindingType.Found)
            {
                onEventFocusNotificationData.PlaneAlignment = PlaneAlignment.None;
                onEventFocusNotificationData.Size = Vector2.zero;
                onEventFocusNotificationData.PlaneClassification = PlaneClassification.None;
            }

            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT,
                onEventFocusNotificationData);
        }

        private void OnDisable()
        {
            Running = false;
            onEventFocusNotificationData = null;
            ActionNotificationCenter.DefaultCenter.RemoveObserver(ConstKey.CONST_ON_EVENT);
        }


        public void Start()
        {
            mainCameraTransform = IocContainer.GetIoc.Resolve<ARComponentModel>().ARCamera.transform;
            Running = true;
            onEventFocusNotificationData = new() {ActionName = "OnFocusNotify"};
            ActionNotificationCenter.DefaultCenter.AddObserver(AlgorithmSetter,
                ConstKey.CONST_SET_FOCUS_ALGORITHM_STATE);
        }

        private void AlgorithmSetter(BaseNotificationData _data)
        {
            enabled = ((AlgorithmSetterArgs) (_data)).AlgorithmState;
        }

        private void OnDrawGizmos()
        {
            if (Application.isPlaying && Application.isEditor)
                Gizmos.DrawLine(mainCameraTransform.position, mainCameraTransform.forward);
        }
    }
}