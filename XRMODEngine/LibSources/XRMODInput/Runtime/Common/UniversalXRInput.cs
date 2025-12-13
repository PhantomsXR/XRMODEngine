/*===============================================================================
Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Input.Runtime.

The  XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/
#if USE_XRI 

using System;
using System.Collections.Generic;
using System.Linq;
using Phantom.XRMOD.ActionNotification.Runtime;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Hands;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using InputDevice = UnityEngine.XR.InputDevice;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// Manages universal XR input across different platforms, providing a unified API for hands, controllers, and other input modalities.
    /// </summary>
    public partial class UniversalXRInput
    {
        private Transform xrOrigin;
        private Transform cameraOffset;
        private PlayerInput playerInput;
        private HandsAggregatorSubsystem handsAggregatorSubsystem;
        private XRInputModalityManager xrInputModalityManager;
        private InputActionManager inputActionManager;
        private InputType currentInputType = InputType.Unknown;


        private Dictionary<InteractorHandness, Transform> rayInteractorDict;

        private SpaceType spaceType
        {
            get
            {
                var tmp_Result = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                    nameof(ActionParameterDataType.GetSpaceType),
                    null).FirstOrDefault();
                return tmp_Result != null ? Enum.Parse<SpaceType>(tmp_Result.ToString()) : SpaceType.ExclusiveSpace;
            }
        }

        private static UniversalXRInput _UNIVERSAL_XR_INPUT;

        /// <summary>
        /// Gets the singleton instance of the <see cref="UniversalXRInput"/> class.
        /// </summary>
        /// <returns>The singleton instance.</returns>
        public static UniversalXRInput GetInstance => _UNIVERSAL_XR_INPUT ??= new UniversalXRInput();

        /// <summary>
        /// Gets a dictionary mapping interactor handedness to their respective transforms.
        /// </summary>
        public Dictionary<InteractorHandness, Transform> HandnessDict;


        private UniversalXRInput()
        {
            var tmp_XROriginScript = Object.FindAnyObjectByType<XROrigin>();
            if (tmp_XROriginScript)
            {
                xrOrigin = tmp_XROriginScript.transform;
                handsAggregatorSubsystem = HandsAggregatorSubsystem.INSTANCE;
                cameraOffset = xrOrigin.GetChild(0);
                rayInteractorDict = new();
                HandnessDict = new();
                playerInput = Object.FindAnyObjectByType<PlayerInput>();
                xrInputModalityManager = Object.FindAnyObjectByType<XRInputModalityManager>();
                inputActionManager = xrOrigin.GetComponent<InputActionManager>();

                HandnessDict.Add(InteractorHandness.LeftController, cameraOffset.Find("Left Controller"));
                HandnessDict.Add(InteractorHandness.RightController, cameraOffset.Find("Right Controller"));
                HandnessDict.Add(InteractorHandness.LeftHand, cameraOffset.Find("Left Hand"));
                HandnessDict.Add(InteractorHandness.RightHand, cameraOffset.Find("Right Hand"));


#if XRMOD_INSTALL && ROKID_INSTALL
                MappingRokidInteractors();
#elif XRMOD_INSTALL && (QUEST_INSTALL || PICO_INSTALL)
                MappingXRControllerInteractors();
                MappingXRControllerInputKeyActions();
#endif
            }

#if VISIONOS_INSTALL || CLASSIC_3D_INSTALL
            UnityEngine.InputSystem.EnhancedTouch.EnhancedTouchSupport.Enable();
#endif
        }

        private void MappingRokidInteractors()
        {
            var tmp_RokidRayInteractor = xrOrigin.Find("3DofRay/Aim Pose");
            rayInteractorDict.Add(InteractorHandness.RightController, tmp_RokidRayInteractor);
            rayInteractorDict.Add(InteractorHandness.LeftController, tmp_RokidRayInteractor);
            var tmp_LeftHandRayInteractor = xrOrigin.Find("Camera Offset/Left Hand/Near-Far Interactor");
            var tmp_RightHandRayInteractor = xrOrigin.Find("Camera Offset/Right Hand/Near-Far Interactor");
            rayInteractorDict.Add(InteractorHandness.RightHand, tmp_RightHandRayInteractor);
            rayInteractorDict.Add(InteractorHandness.LeftHand, tmp_LeftHandRayInteractor);
        }


        /// <summary>
        /// Sets up the state of interactors (Far, Near, or Both) to be enabled or disabled.
        /// </summary>
        /// <param name="_interactorMode">The interactor type: Far, Near, or Both.</param>
        /// <param name="_enable">True to enable the interactor, false to disable.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if an incorrect interactor mode is provided.</exception>
        public void SetupInteractorState(InteractorMode _interactorMode, bool _enable)
        {
            var tmp_NearFarInteractors =
                Object.FindObjectsByType<NearFarInteractor>(FindObjectsInactive.Include, FindObjectsSortMode.None);

            var tmp_Pokes = Object.FindObjectsByType<PokeGestureDetector>(FindObjectsInactive.Include,
                FindObjectsSortMode.None);
            foreach (PokeGestureDetector tmp_GestureDetector in tmp_Pokes)
            {
                tmp_GestureDetector.enabled = _enable;
            }

            switch (_interactorMode)
            {
                case InteractorMode.Far:
                    foreach (NearFarInteractor tmp_Interactor in tmp_NearFarInteractors)
                    {
                        tmp_Interactor.enableFarCasting = _enable;
                    }

                    break;
                case InteractorMode.Near:
                    foreach (NearFarInteractor tmp_Interactor in tmp_NearFarInteractors)
                    {
                        tmp_Interactor.enableNearCasting = _enable;
                    }

                    break;
                case InteractorMode.Both:
                    foreach (NearFarInteractor tmp_Interactor in tmp_NearFarInteractors)
                    {
                        tmp_Interactor.enableFarCasting = _enable;
                        tmp_Interactor.enableNearCasting = _enable;
                    }

                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_interactorMode), _interactorMode, null);
            }
        }

        /// <summary>
        /// Checks if a pinch gesture is currently active on either hand.
        /// Only supported in <see cref="SpaceType.SharedSpace"/>.
        /// </summary>
        /// <returns><see langword="true"/> if a pinch gesture is detected on either hand, <see langword="false"/> otherwise.</returns>
        public bool TryGetPinch()
        {
#if VISIONOS_INSTALL
            var tmp_ActiveTouches = UnityEngine.InputSystem.EnhancedTouch.Touch.activeTouches;
            if (tmp_ActiveTouches.Count <= 0) return false;
            UnityEngine.InputSystem.LowLevel.SpatialPointerState tmp_PrimaryTouchData =
                Unity.PolySpatial.InputDevices.EnhancedSpatialPointerSupport.GetPointerState(tmp_ActiveTouches[0]);
            return tmp_PrimaryTouchData.Kind == UnityEngine.InputSystem.LowLevel.SpatialPointerKind.IndirectPinch;

#else
            return handsAggregatorSubsystem.TryGetPinchProgress(XRNode.RightHand, out _, out _,
                out _) || handsAggregatorSubsystem.TryGetPinchProgress(XRNode.LeftHand, out _, out _,
                out _);
#endif
        }


        /// <summary>
        /// Checks if a pinch gesture is currently active on the specified hand.
        /// Only supported in <see cref="SpaceType.SharedSpace"/>.
        /// </summary>
        /// <param name="_handedness">The handedness (Left or Right) to check for a pinch gesture.</param>
        /// <returns><see langword="true"/> if a pinch gesture is detected on the specified hand, <see langword="false"/> otherwise.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if an invalid handedness is provided.</exception>
        public bool TryGetPinch(Handedness _handedness)
        {
            switch (_handedness)
            {
                case Handedness.Invalid:
                    break;
                case Handedness.Left:
                    return handsAggregatorSubsystem.TryGetPinchProgress(XRNode.LeftHand, out _, out _,
                        out _);
                case Handedness.Right:
                    return handsAggregatorSubsystem.TryGetPinchProgress(XRNode.RightHand, out _, out _,
                        out _);
                default:
                    throw new ArgumentOutOfRangeException(nameof(_handedness), _handedness, null);
            }

            return false;
        }


        /// <summary>
        /// Registers a custom hand gesture for recognition.
        /// </summary>
        /// <param name="_handedness">The handedness (Left or Right) for which to register the gesture.</param>
        /// <param name="_customGestureData">The custom gesture data to register.</param>
        public void RegisterHandGesture(Handedness _handedness, CustomGestureData _customGestureData)
        {
            handsAggregatorSubsystem.RegisterGestureRecognition(_handedness, _customGestureData);
        }

        /// <summary>
        /// Unregisters a custom hand gesture.
        /// </summary>
        /// <param name="_handedness">The handedness (Left or Right) for which to unregister the gesture.</param>
        /// <param name="_customGestureData">The custom gesture data to unregister.</param>
        public void UnregisterHandGesture(Handedness _handedness, CustomGestureData _customGestureData)
        {
            handsAggregatorSubsystem.UnregisterGestureRecognition(_handedness, _customGestureData);
        }

        /// <summary>
        /// Queries the pinch progress for a specific hand.
        /// Only supported in <see cref="SpaceType.FullSpace"/> or Metal.
        /// </summary>
        /// <param name="_handNode">The XRNode (LeftHand or RightHand) to query.</param>
        /// <param name="_isReadyToPinch">Outputs <see langword="true"/> if the hand is in a state ready to pinch, <see langword="false"/> otherwise.</param>
        /// <param name="_isPinching">Outputs <see langword="true"/> if the hand is currently pinching, <see langword="false"/> otherwise.</param>
        /// <param name="_pinchAmount">Outputs the normalized pinch amount (0.0 to 1.0).</param>
        /// <returns><see langword="true"/> if pinch progress data was successfully retrieved, <see langword="false"/> otherwise.</returns>
        public bool TryGetPinchProgress(XRNode _handNode, out bool _isReadyToPinch, out bool _isPinching,
            out float _pinchAmount)
        {
            _isReadyToPinch = _isPinching = false;
            _pinchAmount = 0;

            if (spaceType == SpaceType.SharedSpace) return false;
            return handsAggregatorSubsystem.TryGetPinchProgress(_handNode, out _isReadyToPinch, out _isPinching,
                out _pinchAmount);
        }


        /// <summary>
        /// Queries the pose of a specific hand joint.
        /// Only supported in <see cref="SpaceType.FullSpace"/> or Metal.
        /// </summary>
        /// <param name="_joint">The identifier of the requested joint.</param>
        /// <param name="_hand">The hand node (LeftHand or RightHand) being queried.</param>
        /// <param name="_jointPose">Outputs the resulting joint pose if found.</param>
        /// <param name="_convertToWorldPose">If <see langword="true"/>, the joint pose will be transformed into world space.</param>
        /// <returns><see langword="true"/> if the joint pose was found, and <see langword="false"/> otherwise.</returns>
        public bool TryGetJointPose(XRHandJointID _joint, XRNode _hand, out Pose _jointPose,
            bool _convertToWorldPose = false)
        {
            _jointPose = Pose.identity;
            var tmp_ShareSpace = spaceType == SpaceType.SharedSpace;

            // Break hand data in here.
            if (tmp_ShareSpace) return false;
            if (_convertToWorldPose)
            {
                if (!handsAggregatorSubsystem.TryGetJointPose(_joint, _hand, out _jointPose)) return false;
                _jointPose = _jointPose.GetTransformedBy(cameraOffset);
                return true;
            }
            else
            {
                return handsAggregatorSubsystem.TryGetJointPose(_joint, _hand, out _jointPose);
            }
        }

        /// <summary>
        /// Gets the transform of a specific hand joint visualizer.
        /// </summary>
        /// <param name="_xrNode">The XR node (LeftHand or RightHand) for which to get the joint transform.</param>
        /// <param name="_jointId">The identifier of the hand joint.</param>
        /// <param name="_jointTransform">Outputs the joint transform if found.</param>
        /// <returns><see langword="true"/> if the joint transform was found, <see langword="false"/> otherwise.</returns>
        public bool TryGetJointTransform(XRNode _xrNode, XRHandJointID _jointId, out Transform _jointTransform)
        {
            _jointTransform = null;
            return handsAggregatorSubsystem.TryGetJointTransform(_xrNode, _jointId, out _jointTransform);
        }

        /// <summary>
        /// Determines whether the palm of the given hand is facing away from the user.
        /// Only supported in <see cref="SpaceType.FullSpace"/>.
        /// </summary>
        /// <param name="_hand">The hand node (LeftHand or RightHand) being queried.</param>
        /// <param name="_palmFacingAway">Outputs <see langword="true"/> if the palm is facing away, <see langword="false"/> otherwise.</param>
        public void TryGetPalmFacingAway(XRNode _hand, out bool _palmFacingAway)
        {
            _ = handsAggregatorSubsystem.TryGetJointPose(XRHandJointID.Palm, _hand, out var tmp_Pose);
            _palmFacingAway = handsAggregatorSubsystem.IsPalmFacingAway(tmp_Pose) &&
                              spaceType == SpaceType.ExclusiveSpace;
        }

        /// <summary>
        /// Switches the active user input modality to the specified type.
        /// </summary>
        /// <param name="_inputType">The desired <see cref="InputType"/> (e.g., XR Hand, Controller, Keyboard&Mouse, Gamepad).</param>
        public void SwitchInput(InputType _inputType)
        {
            currentInputType = _inputType;
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(SwitchInput), new BaseNotificationData()
            {
                ObjectData = _inputType
            });
        }

        /// <summary>
        /// Gets the current position and rotation of the 3DoF ray interactor for the specified handedness.
        /// </summary>
        /// <param name="_handedness">The handedness (LeftController, RightController, LeftHand, RightHand) of the interactor.</param>
        /// <param name="_position">Outputs the current world position of the ray interactor.</param>
        /// <param name="_rotation">Outputs the current world rotation of the ray interactor.</param>
        public void GetRayInteractorPose(InteractorHandness _handedness, out Vector3 _position,
            out Quaternion _rotation)
        {
            if (rayInteractorDict.TryGetValue(_handedness, out var tmp_RayInteractor))
            {
                _position = tmp_RayInteractor.position;
                _rotation = tmp_RayInteractor.rotation;
            }
            else
            {
                _position = Vector3.zero;
                _rotation = Quaternion.identity;
            }
        }

        /// <summary>
        /// Attempts to retrieve the <see cref="NearFarInteractor"/> component for the specified handedness.
        /// </summary>
        /// <param name="_handness">The handedness (LeftController, RightController, LeftHand, RightHand) of the interactor.</param>
        /// <param name="_nearFarInteractor">Outputs the <see cref="NearFarInteractor"/> component if found.</param>
        /// <returns><see langword="true"/> if the <see cref="NearFarInteractor"/> was found, <see langword="false"/> otherwise.</returns>
        public bool GetRayInteractor(InteractorHandness _handness, out NearFarInteractor _nearFarInteractor)
        {
            if (rayInteractorDict.TryGetValue(_handness, out var tmp_RayInteractor))
            {
                return tmp_RayInteractor.TryGetComponent(out _nearFarInteractor);
            }

            _nearFarInteractor = null;
            return false;
        }

        /// <summary>
        /// Gets the currently active input type (XR Hand/Controller, Keyboard&Mouse, or Gamepad).
        /// </summary>
        /// <returns>The current <see cref="InputType"/>.</returns>
        public InputType GetCurrentInputType()
        {
#if QUEST_INSTALL || PICO_INSTALL
            if (xrInputModalityManager)
            {
                var tmp_LeftHand = xrInputModalityManager.leftHand;
                var tmp_RightHand = xrInputModalityManager.rightHand;
                if (tmp_LeftHand.activeSelf || tmp_RightHand.activeSelf) return InputType.NatureHands;


                var tmp_LeftController = xrInputModalityManager.leftController;
                var tmp_RightController = xrInputModalityManager.rightController;
                if (tmp_LeftController.activeSelf || tmp_RightController.activeSelf) return InputType.XRController;
            }
#else
            if (handsAggregatorSubsystem.leftHand.isTracked || handsAggregatorSubsystem.rightHand.isTracked)
                return InputType.NatureHands;
#endif


            if (!playerInput) return InputType.Unknown;
            switch (playerInput.currentControlScheme)
            {
                case "Keyboard&Mouse":
                    return InputType.KeyboardNMouse;
                case "Gamepad":
                    return InputType.GamePad;
            }

            return InputType.Unknown;
        }

        /// <summary>
        /// Checks if one or more specified hands are currently being tracked by the XR system.
        /// </summary>
        /// <param name="_hands">An array of <see cref="Handedness"/> values (Left, Right) to check for tracking.</param>
        /// <returns><see langword="true"/> if any of the specified hands are tracked, <see langword="false"/> otherwise.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if an invalid <see cref="Handedness"/> value is provided.</exception>
        public bool IsHandTracked(params Handedness[] _hands)
        {
            foreach (var tmp_Handedness in _hands)
            {
                switch (tmp_Handedness)
                {
                    case Handedness.Invalid:
                        break;
                    case Handedness.Left:
                        return handsAggregatorSubsystem.leftHand.isTracked;
                    case Handedness.Right:
                        return handsAggregatorSubsystem.rightHand.isTracked;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(tmp_Handedness), tmp_Handedness, null);
                }
            }


            return false;
        }
    }
}

#endif