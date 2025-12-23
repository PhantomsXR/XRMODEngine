// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.RokidModule.Runtime.
// //
// // The RokidPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Threading.Tasks;
using Phantom.XRMOD.XRMODInput.Runtime;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.OpenXR.Features;
using CommonUsages = UnityEngine.XR.CommonUsages;
using InputDevice = UnityEngine.XR.InputDevice;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    /// <summary>
    /// Provides 3-DOF pose data for the ray interactor on Rokid devices.
    /// Handles pose synchronization with the controller or phone input and supports vibration feedback.
    /// </summary>
    public class ThreeDRayPoseProvider : MonoBehaviour
    {
        private Transform selfTransform;

        [FormerlySerializedAs("offsetPosition")] [SerializeField]
        private float horizontalOffset;

        [SerializeField] private float verticalOffset;
        [SerializeField] private InputActionProperty inputActionProperty; 
        private InputDevice controllerDevice;
        private Transform mainCameraTransform;
        private Vector3 aimPosition;
        private Quaternion aimRotation;

        private async void Start()
        {
            mainCameraTransform = Camera.main.transform;
            selfTransform = transform;
            Vibration.Init();
            inputActionProperty.action.Enable();
            inputActionProperty.action.performed += _context => { Recenter(); };
            await Task.Delay(500);
            Recenter();
        }

        /// <summary>
        /// Recalibrates the phone pose when the corresponding input action is performed.
        /// Invokes the Rokid OpenXR API to recenter the pose.
        /// </summary>
        private void Recenter()
        {
            if (Application.platform == RuntimePlatform.Android && !Application.isEditor)
                RokidExtensionAPI.RokidOpenXR_API_RecenterPhonePose();
        }


        private void LateUpdate()
        {
#if UNITY_EDITOR

            aimPosition = mainCameraTransform.localPosition;
            aimRotation = mainCameraTransform.localRotation;

            selfTransform.localPosition = aimPosition + horizontalOffset * mainCameraTransform.right.normalized +
                                          verticalOffset * mainCameraTransform.up;
            selfTransform.localRotation = aimRotation;

 
#else
            if (!controllerDevice.isValid)
            {
                controllerDevice =
                    RokidUtils.FindRokidDevice(InputDeviceCharacteristics.HeldInHand |
                                               InputDeviceCharacteristics.Controller);
            }


            if (controllerDevice.isValid)
            {
                controllerDevice.TryGetFeatureValue(CommonUsages.devicePosition, out aimPosition);
                controllerDevice.TryGetFeatureValue(CommonUsages.deviceRotation, out aimRotation);
            }
 
            selfTransform.localPosition = aimPosition + horizontalOffset * mainCameraTransform.right.normalized +
                                          verticalOffset * mainCameraTransform.up;
            selfTransform.localRotation = aimRotation;
#endif
        }

        /// <summary>
        /// Triggers a haptic vibration feedback on the device.
        /// </summary>
        public void Vibrate()
        {
            Vibration.VibratePeek();
        }
    }
}