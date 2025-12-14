// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UXCore.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if USE_XRI

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using InputDevice = UnityEngine.XR.InputDevice;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// Manages input fallback for <see cref="XRGazeInteractor"/> when eye tracking is not available.
    /// </summary>
    public class GazeInputManager : MonoBehaviour
    {
        // This is the name of the layout that is registered by EyeGazeInteraction in the OpenXR Plugin package
        const string _CONST_K_EYE_GAZE_LAYOUT_NAME = "EyeGaze";

        [SerializeField] [Tooltip("Enable fallback to head tracking if eye tracking is unavailable.")]
        bool fallbackIfEyeTrackingUnavailable = true;

        /// <summary>
        /// Enable fallback to head tracking if eye tracking is unavailable.
        /// </summary>
        public bool FallbackIfEyeTrackingUnavailable
        {
            get => fallbackIfEyeTrackingUnavailable;
            set => fallbackIfEyeTrackingUnavailable = value;
        }


        bool eyeTrackingDeviceFound;

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        protected void Awake()
        {
            // Check if we have eye tracking support
            var tmp_InputDeviceList = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.EyeTracking, tmp_InputDeviceList);
            if (tmp_InputDeviceList.Count > 0)
            {
                Debug.Log("Eye tracking device found!", this);
                eyeTrackingDeviceFound = true;
                return;
            }

            foreach (var tmp_Device in InputSystem.devices)
            {
                if (tmp_Device.layout == _CONST_K_EYE_GAZE_LAYOUT_NAME)
                {
                    Debug.Log("Eye gaze device found!", this);
                    eyeTrackingDeviceFound = true;
                    return;
                }
            }

            Debug.LogWarning(
                $"Could not find a device that supports eye tracking on Awake. {this} has subscribed to device connected events and will activate the GameObject when an eye tracking device is connected.",
                this);

            InputDevices.deviceConnected += OnDeviceConnected;
            InputSystem.onDeviceChange += OnDeviceChange;

            gameObject.SetActive(fallbackIfEyeTrackingUnavailable);
        }

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        protected void OnDestroy()
        {
            InputDevices.deviceConnected -= OnDeviceConnected;
            InputSystem.onDeviceChange -= OnDeviceChange;
        }

        void OnDeviceConnected(InputDevice inputDevice)
        {
            if (eyeTrackingDeviceFound ||
                !inputDevice.characteristics.HasFlag(InputDeviceCharacteristics.EyeTracking))
                return;

            Debug.Log("Eye tracking device found!", this);
            eyeTrackingDeviceFound = true;
            gameObject.SetActive(true);
        }

        void OnDeviceChange(UnityEngine.InputSystem.InputDevice _device, InputDeviceChange _change)
        {
            if (eyeTrackingDeviceFound || _change != InputDeviceChange.Added)
                return;

            if (_device.layout != _CONST_K_EYE_GAZE_LAYOUT_NAME) return;
            Debug.Log("Eye gaze device found!", this);
            eyeTrackingDeviceFound = true;
            gameObject.SetActive(true);
        }
    }
}
#endif