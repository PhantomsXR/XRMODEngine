// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODInput.Runtime.
// //
// // The UnityXR-MODLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if USE_XRI

using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Hands;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    public partial class UniversalXRInput
    {
        // Right XRController
        private InputAction rightGrabAction;
        private InputAction rightTriggerAction;
        private InputAction rightAButtonAction;
        private InputAction rightBButtonAction;
        private InputAction rightJoystickAction;
        private InputAction rightControllerPositionAction;
        private InputAction rightControllerRotationAction;

        // Left XRController
        private InputAction leftGrabAction;
        private InputAction leftTriggerAction;
        private InputAction leftXButtonAction;
        private InputAction leftYButtonAction;
        private InputAction leftJoystickAction;
        private InputAction leftControllerPositionAction;
        private InputAction leftControllerRotationAction;


        private void MappingXRControllerInteractors()
        {
            var tmp_LeftControllerRayInteractor = cameraOffset.Find("Left Controller/Near-Far Interactor");
            var tmp_RightControllerRayInteractor = cameraOffset.Find("Right Controller/Near-Far Interactor");
            rayInteractorDict.Add(InteractorHandness.RightController, tmp_RightControllerRayInteractor);
            rayInteractorDict.Add(InteractorHandness.LeftController, tmp_LeftControllerRayInteractor);


            var tmp_LeftHandRayInteractor = cameraOffset.Find("Left Hand/Near-Far Interactor");
            var tmp_RightHandRayInteractor = cameraOffset.Find("Right Hand/Near-Far Interactor");
            rayInteractorDict.Add(InteractorHandness.RightHand, tmp_RightHandRayInteractor);
            rayInteractorDict.Add(InteractorHandness.LeftHand, tmp_LeftHandRayInteractor);
        }

        private void MappingXRControllerInputKeyActions()
        {
            if (!inputActionManager)
            {
                Debug.LogError("Binding XR controller input failed.");
                return;
            }

            var tmp_LeftInteractionActionMap =
                inputActionManager.actionAssets[0].FindActionMap("XRI Left Interaction", true);
            var tmp_LeftActionMap = inputActionManager.actionAssets[0].FindActionMap("XRI Left", true);

            leftGrabAction = tmp_LeftInteractionActionMap.FindAction("Select Value", true);
            leftTriggerAction = tmp_LeftInteractionActionMap.FindAction("Activate Value", true);
            leftXButtonAction = tmp_LeftInteractionActionMap.FindAction("XButton", true);
            leftYButtonAction = tmp_LeftInteractionActionMap.FindAction("YButton", true);
            leftJoystickAction = tmp_LeftActionMap.FindAction("Thumbstick", true);
            leftControllerPositionAction = tmp_LeftActionMap.FindAction("Position", true);
            leftControllerRotationAction = tmp_LeftActionMap.FindAction("Rotation", true);

            var tmp_RightInteractionActionMap =
                inputActionManager.actionAssets[0].FindActionMap("XRI Right Interaction", true);
            var tmp_RightActionMap = inputActionManager.actionAssets[0].FindActionMap("XRI Right", true);

            rightGrabAction = tmp_RightInteractionActionMap.FindAction("Select Value", true);
            rightTriggerAction = tmp_RightInteractionActionMap.FindAction("Activate Value", true);
            rightAButtonAction = tmp_RightInteractionActionMap.FindAction("AButton", true);
            rightBButtonAction = tmp_RightInteractionActionMap.FindAction("BButton", true);
            rightJoystickAction = tmp_RightActionMap.FindAction("Thumbstick", true);
            rightControllerPositionAction = tmp_RightActionMap.FindAction("Position", true);
            rightControllerRotationAction = tmp_LeftActionMap.FindAction("Rotation", true);
        }


        /// <summary>
        /// Attempts to get the button input state from an XR controller.
        /// </summary>
        /// <param name="_handedness">The handedness (Left or Right) of the controller to query.</param>
        /// <param name="_controllerKey">The specific button/key on the controller.</param>
        /// <param name="_value">The resulting input value (0.0 to 1.0).</param>
        /// <returns><c>true</c> if the button is determined to be pressed (value > 0.9), <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if an invalid controller key is provided.</exception>
        public bool TryGetXRControllerButtonInput(Handedness _handedness, XRControllerKey _controllerKey,
            out float _value)
        {
            _value = 0;
            if (GetCurrentInputType() != InputType.XRController) return false;
            var tmp_IsLeftHand = _handedness == Handedness.Left;
            switch (_controllerKey)
            {
                case XRControllerKey.AButton:
                    if (rightAButtonAction == null) return false;
                    _value = rightAButtonAction.ReadValue<float>();
                    return _value > 0.9f;
                case XRControllerKey.BButton:
                    if (rightBButtonAction == null) return false;
                    _value = rightBButtonAction.ReadValue<float>();
                    return _value > 0.9f;
                case XRControllerKey.XButton:
                    if (leftXButtonAction == null) return false;
                    _value = leftXButtonAction.ReadValue<float>();
                    return _value > 0.9f;
                case XRControllerKey.YButton:
                    if (leftYButtonAction == null) return false;
                    _value = leftYButtonAction.ReadValue<float>();
                    return _value > 0.9f;
                case XRControllerKey.Trigger:
                    if (leftTriggerAction == null && tmp_IsLeftHand) return false;
                    if (rightTriggerAction == null && !tmp_IsLeftHand) return false;
                    _value = tmp_IsLeftHand
                        ? leftTriggerAction.ReadValue<float>()
                        : rightTriggerAction.ReadValue<float>();
                    return _value > 0.9f;

                case XRControllerKey.Grip:
                    if (leftGrabAction == null && tmp_IsLeftHand) return false;
                    if (rightGrabAction == null && !tmp_IsLeftHand) return false;
                    _value = tmp_IsLeftHand
                        ? leftGrabAction.ReadValue<float>()
                        : rightGrabAction.ReadValue<float>();
                    return _value > 0.9f;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_controllerKey), _controllerKey, null);
            }
        }

        /// <summary>
        /// Attempts to get the joystick/thumbstick axis value from an XR controller.
        /// </summary>
        /// <param name="_handedness">The handedness (Left or Right) of the controller to query.</param>
        /// <param name="_axis">The resulting 2D axis value.</param>
        /// <returns><c>true</c> if the axis value was successfully retrieved, <c>false</c> otherwise (e.g., if the current input modality is not XRController).</returns>
        public bool TryGetXRControllerAxis(Handedness _handedness, out Vector2 _axis)
        {
            _axis = Vector2.zero;
            if (GetCurrentInputType() != InputType.XRController) return false;
            _axis = _handedness == Handedness.Left
                ? leftJoystickAction.ReadValue<Vector2>()
                : rightJoystickAction.ReadValue<Vector2>();
            return true;
        }


        /// <summary>
        /// Attempts to get the world space position and rotation (pose) of an XR controller.
        /// </summary>
        /// <param name="_handedness">The handedness (Left or Right) of the controller to query.</param>
        /// <param name="_position">The resulting world position of the controller.</param>
        /// <param name="_rotation">The resulting world rotation of the controller.</param>
        /// <returns><c>true</c> if the pose was successfully retrieved, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if an invalid handedness is provided.</exception>
        public bool TryGetXRControllerPose(Handedness _handedness, out Vector3 _position, out Quaternion _rotation)
        {
            _position = Vector3.zero;
            _rotation = Quaternion.identity;
            if (GetCurrentInputType() != InputType.XRController) return false;
            switch (_handedness)
            {
                case Handedness.Invalid:
                    break;
                case Handedness.Left:
                    _position = leftControllerPositionAction.ReadValue<Vector3>();
                    _rotation = leftControllerRotationAction.ReadValue<Quaternion>();
                    return true;
                case Handedness.Right:
                    _position = rightControllerPositionAction.ReadValue<Vector3>();
                    _rotation = rightControllerRotationAction.ReadValue<Quaternion>();
                    return true;

                default:
                    throw new ArgumentOutOfRangeException(nameof(_handedness), _handedness, null);
            }

            return false;
        }
    }
}

#endif