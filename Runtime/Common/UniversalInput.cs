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
    [Obsolete("Please use UniversalXRInput instead.",true)]
    public class UniversalInput
    {
        private HandsAggregatorSubsystem handsAggregatorSubsystem;
        private Transform xrOrigin;
        private Transform cameraOffset;
        private Dictionary<InteractorHandness, Transform> rayInteractorDict;

        private SpaceType spaceType;
        private static UniversalInput _UNIVERSAL_XR_INPUT;
        public static UniversalInput _INSTANCE => _UNIVERSAL_XR_INPUT ?? new UniversalInput();

        public enum InteractorMode
        {
            Far,
            Near,
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
        /// Setup the interactor state.
        /// </summary>
        /// <param name="_interactorMode">The interactor type: Far,Near.</param>
        /// <param name="_enable">Enable this interactor.</param>
        /// <exception cref="ArgumentOutOfRangeException">Incorrect interactor type.</exception>
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
        /// Pinch gesture.
        /// Only supported <see cref="SpaceType">SharedSpace</see>.
        /// </summary>
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
        /// Pinch gesture.
        /// Only supported <see cref="SpaceType">FullSpace or metal</see>.
        /// </summary>
        /// <param name="_handNode">Left or right hand <see cref="XRNode"/> for this method.</param>
        /// <returns>If <c>True</c> current hand is pinched.</returns>
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
        /// Queries a specific hand joint, specified by <paramref name="_joint"/>.
        /// Only supported <see cref="SpaceType">FullSpace or metal</see>.
        /// </summary>
        /// <param name="_joint">Identifier of the requested joint.</param>
        /// <param name="_hand">The hand node being queried.</param>
        /// <param name="_jointPose">The resulting joint pose that was found.</param>
        /// <param name="_convertToWorldPose">Transform a pose into world space</param>
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
        /// Get the visualizer joint transform
        /// </summary>
        /// <param name="_xrNode">Enumeration of XR nodes which can be updated by XR input or sent haptic data.</param>
        /// <param name="_jointId">Represents the type of a hand joint.</param>
        /// <param name="_jointTransform">Joint transform.</param>
        /// <returns>If true you got the transform, False otherwise</returns>
        public bool TryGetJointTransform(XRNode _xrNode, XRHandJointID _jointId, out Transform _jointTransform)
        {
            _jointTransform = null;
            return handsAggregatorSubsystem.TryGetJointTransform(_xrNode, _jointId, out _jointTransform);
        }

        /// <summary>
        /// Whether the palm of the given handedness is facing away from the user.
        /// Only supported <see cref="SpaceType">FullSpace</see>.
        /// </summary>
        /// <param name="_hand">The hand node being queried.</param>
        /// <param name="_palmFacingAway">Will be <see langword="true"/> if the palm is facing away from the other, <see langword="false"/> otherwise.</param>
        /// <returns><see langword="true"/> if the hand was found, and <see langword="false"/> otherwise.</returns>
        public void TryGetPalmFacingAway(XRNode _hand, out bool _palmFacingAway)
        {
            _ = handsAggregatorSubsystem.TryGetJointPose(XRHandJointID.Palm, _hand, out var tmp_Pose);
            _palmFacingAway = handsAggregatorSubsystem.IsPalmFacingAway(tmp_Pose) &&
                              spaceType == SpaceType.ExclusiveSpace;
        }

        /// <summary>
        /// Switch user input to the specified type.
        /// </summary>
        /// <param name="_inputType">The specified <see cref="InputType"/>.</param>
        public void SwitchInput(InputType _inputType)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(SwitchInput), new BaseNotificationData()
            {
                ObjectData = _inputType
            });
        }

        /// <summary>
        /// Get ray interactor pose.
        /// </summary>
        /// <param name="_handedness">The interactor handness</param>
        /// <param name="_position">Current ray position</param>
        /// <param name="_rotation">Current ray rotation</param>
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
        /// Get ray interactor
        /// </summary>
        /// <param name="_nearFarInteractor">The ray interactor type</param>
        /// <returns>True: got the ray interactor. False:otherwise</returns>
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
        /// To check current input type is you own
        /// </summary>
        /// <param name="_characteristics">You own input device characteristics</param>
        /// <returns></returns>
        public bool IsInputDeviceCharacteristics(InputDeviceCharacteristics _characteristics)
        {
            List<InputDevice> tmp_HandDevices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(_characteristics, tmp_HandDevices);
            return tmp_HandDevices.Count > 0;
        }
    }
}