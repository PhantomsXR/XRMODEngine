// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODInput.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using Phantom.XRMOD.ActionNotification.Runtime;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Hands;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// Legacy input handler for XRMOD. 
    /// </summary>
    /// <remarks>
    /// Use <see cref="UniversalXRInput"/> instead for the modern input system.
    /// </remarks>
    [Obsolete("Please use UniversalXRInput instead.",true)]
    public class UniversalInput
    {
        private HandsAggregatorSubsystem handsAggregatorSubsystem;
        private Transform xrOrigin;
        private Transform cameraOffset;
        private Dictionary<InteractorHandness, Transform> rayInteractorDict;

        private SpaceType spaceType;
        private static UniversalInput _UNIVERSAL_XR_INPUT;

        /// <summary>
        /// Singleton instance of UniversalInput.
        /// </summary>
        public static UniversalInput _INSTANCE => _UNIVERSAL_XR_INPUT ?? new UniversalInput();

        /// <summary>
        /// Modes for interactors.
        /// </summary>
        public enum InteractorMode
        {
            /// <summary>
            /// Interaction at a distance (e.g., ray casting).
            /// </summary>
            Far,
            /// <summary>
            /// Close-range interaction (e.g., direct touch).
            /// </summary>
            Near,
            /// <summary>
            /// Both far and near interaction modes.
            /// </summary>
            Both,
        }

        private UniversalInput()
        {
            handsAggregatorSubsystem = HandsAggregatorSubsystem.INSTANCE;
            xrOrigin = Object.FindAnyObjectByType<XROrigin>().transform;
            cameraOffset = xrOrigin.GetChild(0);
            rayInteractorDict = new();

#if XRMOD_INSTALL && ROKID_INSTALL
            var tmp_RokidRayInteractor = xrOrigin.Find("3DofRay/Aim Pose");
            rayInteractorDict.Add(InteractorHandness.RightController,tmp_RokidRayInteractor);            
            rayInteractorDict.Add(InteractorHandness.LeftController,tmp_RokidRayInteractor);
            var tmp_LeftHandRayInteractor = xrOrigin.Find("Camera Offset/Left Hand/Near-FarInteractor");
            var tmp_RightHandRayInteractor = xrOrigin.Find("Camera Offset/Right Hand/Near-FarInteractor");
            rayInteractorDict.Add(InteractorHandness.RightHand, tmp_RightHandRayInteractor);
            rayInteractorDict.Add(InteractorHandness.LeftHand, tmp_LeftHandRayInteractor);
#elif XRMOD_INSTALL && (QUEST_INSTALL || PICO_INSTALL)
            var tmp_LeftControllerRayInteractor = xrOrigin.Find("Camera Offset/Left Controller/Near-FarInteractor");
            var tmp_RightControllerRayInteractor = xrOrigin.Find("Camera Offset/Right Controller/Near-FarInteractor");
            rayInteractorDict.Add(InteractorHandness.RightController, tmp_RightControllerRayInteractor);
            rayInteractorDict.Add(InteractorHandness.LeftController, tmp_LeftControllerRayInteractor);


            var tmp_LeftHandRayInteractor = xrOrigin.Find("Camera Offset/Left Hand/Near-FarInteractor");
            var tmp_RightHandRayInteractor = xrOrigin.Find("Camera Offset/Right Hand/Near-FarInteractor");
            rayInteractorDict.Add(InteractorHandness.RightHand, tmp_RightHandRayInteractor);
            rayInteractorDict.Add(InteractorHandness.LeftHand, tmp_LeftHandRayInteractor);
#endif


            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.GetSpaceType),
                new BaseNotificationData()
                {
                    NotificationActWithData = _data => { spaceType = (SpaceType) _data; }
                });
#if VISIONOS_INSTALL || CLASSIC_3D_INSTALL
            UnityEngine.InputSystem.EnhancedTouch.EnhancedTouchSupport.Enable();
#endif
        }

        /// <summary>
        /// Configures the state (enabled/disabled) of different interactor modes.
        /// </summary>
        /// <param name="_interactorMode">The mode to configure (Far, Near, or Both).</param>
        /// <param name="_enable"><c>true</c> to enable the interactor, <c>false</c> to disable it.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when an invalid interactor mode is provided.</exception>
        public void SetupInteractorState(InteractorMode _interactorMode, bool _enable)
        {
            var tmp_NearFarInteractors =
                Object.FindObjectsByType<NearFarInteractor>(FindObjectsInactive.Include, FindObjectsSortMode.None);

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
        /// Attempts to get the pinch status.
        /// Supported only in <see cref="SpaceType.SharedSpace"/>.
        /// </summary>
        /// <returns><c>true</c> if a pinch gesture is detected, <c>false</c> otherwise.</returns>
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
        /// Attempts to get the progress of a pinch gesture.
        /// Supported only in <see cref="SpaceType.FullSpace"/> or metal mode.
        /// </summary>
        /// <param name="_handNode">The hand node (<see cref="XRNode.LeftHand"/> or <see cref="XRNode.RightHand"/>) to query.</param>
        /// <param name="_isReadyToPinch">Whether the hand is in a pose ready to begin a pinch.</param>
        /// <param name="_isPinching">Whether the hand is currently pinching.</param>
        /// <param name="_pinchAmount">A value from 0 to 1 representing the pinch progress.</param>
        /// <returns><c>true</c> if the pinch data was successfully retrieved, <c>false</c> otherwise.</returns>
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
        /// Attempts to get the pose of a specific hand joint.
        /// Supported only in <see cref="SpaceType.FullSpace"/> or metal mode.
        /// </summary>
        /// <param name="_joint">The identifier of the joint to query.</param>
        /// <param name="_hand">The hand node being queried.</param>
        /// <param name="_jointPose">The resulting pose of the joint.</param>
        /// <param name="_convertToWorldPose">If <c>true</c>, the pose is transformed into world space.</param>
        /// <returns><c>true</c> if the joint pose was successfully retrieved, <c>false</c> otherwise.</returns>
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
        /// Attempts to get the transform of a specific hand joint.
        /// </summary>
        /// <param name="_xrNode">The XR node (hand) to query.</param>
        /// <param name="_jointId">The identifier of the joint.</param>
        /// <param name="_jointTransform">The resulting transform of the joint.</param>
        /// <returns><c>true</c> if the transform was found, <c>false</c> otherwise.</returns>
        public bool TryGetJointTransform(XRNode _xrNode, XRHandJointID _jointId, out Transform _jointTransform)
        {
            _jointTransform = null;
            return handsAggregatorSubsystem.TryGetJointTransform(_xrNode, _jointId, out _jointTransform);
        }

        /// <summary>
        /// Checks whether the palm of the specified hand is facing away from the user.
        /// Supported only in <see cref="SpaceType.FullSpace"/>.
        /// </summary>
        /// <param name="_hand">The hand node being queried.</param>
        /// <param name="_palmFacingAway"><c>true</c> if the palm is facing away from the user, <c>false</c> otherwise.</param>
        public void TryGetPalmFacingAway(XRNode _hand, out bool _palmFacingAway)
        {
            _ = handsAggregatorSubsystem.TryGetJointPose(XRHandJointID.Palm, _hand, out var tmp_Pose);
            _palmFacingAway = handsAggregatorSubsystem.IsPalmFacingAway(tmp_Pose) &&
                              spaceType == SpaceType.ExclusiveSpace;
        }

        /// <summary>
        /// Switches the user input to the specified <see cref="InputType"/>.
        /// </summary>
        /// <param name="_inputType">The target input type.</param>
        public void SwitchInput(InputType _inputType)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(SwitchInput), new BaseNotificationData()
            {
                ObjectData = _inputType
            });
        }

        /// <summary>
        /// Retrieves the pose (position and rotation) of the ray interactor for the specified hand.
        /// </summary>
        /// <param name="_handedness">The handedness of the interactor.</param>
        /// <param name="_position">The current position of the ray.</param>
        /// <param name="_rotation">The current rotation of the ray.</param>
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
        /// Attempts to get the <see cref="NearFarInteractor"/> component for the specified hand.
        /// </summary>
        /// <param name="_handness">The handedness of the interactor.</param>
        /// <param name="_nearFarInteractor">The resulting interactor component.</param>
        /// <returns><c>true</c> if the interactor was found, <c>false</c> otherwise.</returns>
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
        /// Checks if an input device with the specified characteristics is connected.
        /// </summary>
        /// <param name="_characteristics">The characteristics of the input device to look for.</param>
        /// <returns><c>true</c> if a matching device is found, <c>false</c> otherwise.</returns>
        public bool IsInputDeviceCharacteristics(InputDeviceCharacteristics _characteristics)
        {
            List<InputDevice> tmp_HandDevices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(_characteristics, tmp_HandDevices);
            return tmp_HandDevices.Count > 0;
        }
    }
}