#if USE_XRI && XR_HANDS_1_1_OR_NEWER
using System;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Hands;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    public class HandsAggregatorSubsystem : MonoBehaviour
    {
        private Camera mainCamera;
        private Transform mainCamTransform;
        private XROrigin xrOrigin;

        private XRHandSubsystem handSubsystem;
        private XRHandTrackingEvents leftHandTrackingEvent;
        private XRHandTrackingEvents rightHandTrackingEvent;

        private XRHandSkeletonDriver leftHandSkeletonDriver;
        private XRHandSkeletonDriver rightHandSkeletonDriver;

        private Dictionary<Handedness, StaticHandGestureListener> staticHandListeners = new();


        private static HandsAggregatorSubsystem instance;


        internal XRHand leftHand { get; private set; }
        internal XRHand rightHand { get; private set; }

        public static HandsAggregatorSubsystem INSTANCE
        {
            get
            {
                if (instance) return instance;
                instance = FindFirstObjectByType<HandsAggregatorSubsystem>();
                if (instance != null) return instance;
                GameObject tmp_HandsAggregator = new GameObject(nameof(HandsAggregatorSubsystem));
                instance = tmp_HandsAggregator.AddComponent<HandsAggregatorSubsystem>();
                return instance;
            }
        }

        static readonly List<XRHandSubsystem> _SUBSYSTEMS = new List<XRHandSubsystem>();

        // Cached index finger length.
        private float? indexFingerLength;

        void GetHandSubsystem()
        {
#if VISIONOS_INSTALL && !UNITY_EDITOR
            var tmp_XRGeneralSettings = UnityEngine.XR.Management.XRGeneralSettings.Instance;
            if (tmp_XRGeneralSettings == null)
            {
                Debug.LogError("XR general settings not set");
            }

            var tmp_Manager = tmp_XRGeneralSettings.Manager;
            if (tmp_Manager == null) return;
            var tmp_Loader = tmp_Manager.activeLoader;
            if (tmp_Loader == null) return;
            handSubsystem = tmp_Loader.GetLoadedSubsystem<XRHandSubsystem>();
            if (!CheckHandSubsystem())
                return;

            handSubsystem.Start();
#else
            SubsystemManager.GetSubsystems(_SUBSYSTEMS);
            if (_SUBSYSTEMS.Count == 0)
                return;

            handSubsystem = _SUBSYSTEMS[0];

#endif
            rightHand = handSubsystem.rightHand;
            leftHand = handSubsystem.leftHand;
        }

        bool CheckHandSubsystem()
        {
            if (handSubsystem != null) return true;
            Debug.LogError("Could not find Hand Subsystem");
            enabled = false;
            return false;
        }

        private void OnEnable()
        {
            mainCamera = Camera.main;
            xrOrigin = FindFirstObjectByType<XROrigin>();

            if (mainCamera)
                mainCamTransform = mainCamera.transform;

            GetHandSubsystem();
            var tmp_XRHandTrackingEvents =
                FindObjectsByType<XRHandTrackingEvents>(FindObjectsInactive.Include, FindObjectsSortMode.InstanceID);

            foreach (XRHandTrackingEvents tmp_XRHandTrackingEvent in tmp_XRHandTrackingEvents)
            {
                switch (tmp_XRHandTrackingEvent.handedness)
                {
                    case Handedness.Invalid:
                        break;
                    case Handedness.Left:
                        leftHandTrackingEvent = tmp_XRHandTrackingEvent;
                        break;
                    case Handedness.Right:
                        rightHandTrackingEvent = tmp_XRHandTrackingEvent;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void OnDisable()
        {
            if (handSubsystem == null)
                return;
            handSubsystem = null;
            _SUBSYSTEMS.Clear();

            // Fix 127
            if (!gameObject) return;
            if (Application.isEditor && gameObject.activeInHierarchy)
            {
                DestroyImmediate(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }


        /// <summary>
        /// How pinched the specific hand is.
        /// </summary>
        /// <param name="_handNode">The hand node being queried.</param>
        /// <param name="_isReadyToPinch">Represents whether the hand is in a pinch ready pose or not, within the camera's FOV and palm facing away from the user.</param>
        /// <param name="_isPinching">If hand is not pinching at all, this will be false.</param>
        /// <param name="_pinchAmount">This value will be <c>0</c> for no pinch, <c>1</c> for fully pinched, or any floating point value if in between.</param>
        public bool TryGetPinchProgress(XRNode _handNode, out bool _isReadyToPinch, out bool _isPinching,
            out float _pinchAmount)
        {
            bool tmp_GotData = TryGetJointPose(XRHandJointID.Wrist, _handNode, out var tmp_PlamPose);

            var tmp_HandIsUp = Vector3.Angle(mainCamTransform.forward,
                tmp_PlamPose.position - mainCamTransform.position) < _CONST_HAND_RAISE_CAMERA_FOV;
            tmp_GotData &= TryGetJointPose(XRHandJointID.ThumbTip, _handNode, out var tmp_ThumTipPose);
            tmp_GotData &= TryGetJointPose(XRHandJointID.IndexTip, _handNode, out var tmp_IndexTipPose);
            tmp_GotData &= TryGetIndexFingerLength(_handNode, out var tmp_IndexFingerLength);
            if (!tmp_GotData)
            {
                _isReadyToPinch = false;
                _isPinching = false;
                _pinchAmount = 0f;
                return false;
            }

            // Is the hand facing away from the head? Pinching is only allowed when this is true.
            var tmp_HandIsFacingAway = IsPalmFacingAway(tmp_PlamPose);

            float tmp_PinchDistance = Vector3.Distance(tmp_IndexTipPose.position, tmp_ThumTipPose.position);
            float tmp_NormalizedPinch = tmp_PinchDistance / tmp_IndexFingerLength;

            // Is the hand in the ready-pose? Clients may choose to ignore pinch progress
            // if the hand is not yet ready to pinch.
            _isReadyToPinch = tmp_HandIsUp && tmp_HandIsFacingAway;

            // Are we actually fully pinching?
            _isPinching = tmp_NormalizedPinch < _CONST_PINCH_OPEN_THRESHOLD;

            var tmp_OriginalPinchAmount = 1f - Mathf.InverseLerp(_CONST_PINCH_CLOSED_THRESHOLD,
                _CONST_PINCH_OPEN_THRESHOLD,
                tmp_NormalizedPinch);
            _pinchAmount = Mathf.Clamp(tmp_OriginalPinchAmount, 0f, 1f);
            return tmp_GotData;
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
            switch (_xrNode)
            {
                case XRNode.LeftHand:
                    if (leftHandSkeletonDriver == null)
                        leftHandSkeletonDriver = leftHandTrackingEvent.GetComponent<XRHandSkeletonDriver>();
                    _jointTransform = leftHandSkeletonDriver.jointTransformReferences[(int) _jointId].jointTransform;
                    break;
                case XRNode.RightHand:
                    if (rightHandSkeletonDriver == null)
                        rightHandSkeletonDriver = rightHandTrackingEvent.GetComponent<XRHandSkeletonDriver>();
                    _jointTransform = rightHandSkeletonDriver.jointTransformReferences[(int) _jointId].jointTransform;
                    break;
            }

            return false;
        }

        /// <summary>
        /// Query a single joint.
        /// </summary>
        public bool TryGetJointPose(XRHandJointID _jointId, XRNode _xrhand, out Pose _pose)
        {
            _pose = Pose.identity;

            if (handSubsystem == null)
            {
                Debug.LogError("Missing Handsubsystem.");
                return false;
            }

            switch (_xrhand)
            {
                case XRNode.LeftHand:
                    var tmp_LeftJointNode = handSubsystem.leftHand.GetJoint(_jointId);
                    return tmp_LeftJointNode.TryGetPose(out _pose);
                case XRNode.RightHand:
                    var tmp_RightJointNode = handSubsystem.rightHand.GetJoint(_jointId);
                    return tmp_RightJointNode.TryGetPose(out _pose);
            }


            return false;
        }

        /// <summary>
        /// Calculates whether the palm is facing away from the user.
        /// </summary>
        public bool IsPalmFacingAway(Pose _palmJoint)
        {
            if (mainCamera == null) return false;
            Vector3 tmp_PalmDown = _palmJoint.rotation * -Vector3.up;

            // The original palm orientation is based on a horizontal palm facing down.
            // So, if you bring your hand up and face it away from you, the palm.up is the forward vector.
            return !(Mathf.Abs(Vector3.Angle(tmp_PalmDown, mainCamTransform.forward)) >
                     _CONST_HAND_FACING_AWAY_TOLERANCE_IN_DEGREES);
        }

        /// <summary>
        /// Register custom gesture 
        /// </summary>
        /// <param name="_handedness">Left or right hand</param>
        /// <param name="_customGestureData">The custom gesture data</param>
        /// <exception cref="ArgumentOutOfRangeException">The exception that is thrown when the value of an argument is outside the allowable range of values as defined by the invoked method.</exception>
        public void RegisterGestureRecognition(Handedness _handedness, CustomGestureData _customGestureData)
        {
            StaticHandGestureListener tmp_Listeners = null;
            switch (_handedness)
            {
                case Handedness.Invalid:
                    break;
                case Handedness.Left:
                    if (!staticHandListeners.TryGetValue(_handedness, out tmp_Listeners))
                        tmp_Listeners = leftHandTrackingEvent.GetComponent<StaticHandGestureListener>();

                    break;
                case Handedness.Right:
                    if (!staticHandListeners.TryGetValue(_handedness, out tmp_Listeners))
                        tmp_Listeners = rightHandTrackingEvent.GetComponent<StaticHandGestureListener>();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_handedness), _handedness, null);
            }

            if (tmp_Listeners == null)
            {
                Debug.Log("Static Hand Gesture Listener not found.");
                return;
            }

            staticHandListeners.Add(_handedness, tmp_Listeners);

            if (_customGestureData.GestureHandOrPose)
                tmp_Listeners.HandShapeOrPose = _customGestureData.GestureHandOrPose;

            if (_customGestureData.OnEnded != null)
                tmp_Listeners.GestureEnded.AddListener(_customGestureData.OnEnded);

            if (_customGestureData.OnPerformed != null)
                tmp_Listeners.GesturePerformed.AddListener(_customGestureData.OnPerformed);

            tmp_Listeners.MinimumHoldTime = _customGestureData.MinimumHoldTime;
            tmp_Listeners.GestureDetectionInterval = _customGestureData.GestureDetectionInterval;
        }

        /// <summary>
        /// Unregister custom gesture 
        /// </summary>
        /// <param name="_handedness">Left or right hand</param>
        /// <param name="_customGestureData">The custom gesture data</param>
        /// <exception cref="ArgumentOutOfRangeException">The exception that is thrown when the value of an argument is outside the allowable range of values as defined by the invoked method.</exception>
        public void UnregisterGestureRecognition(Handedness _handedness, CustomGestureData _customGestureData)
        {
            if(_handedness == Handedness.Invalid)return;
            if (!staticHandListeners.TryGetValue(_handedness, out var tmp_Listeners))
            {
                tmp_Listeners = _handedness == Handedness.Left
                    ? leftHandTrackingEvent.GetComponent<StaticHandGestureListener>()
                    : rightHandTrackingEvent.GetComponent<StaticHandGestureListener>();
            }
            

            if (!tmp_Listeners) return;

            staticHandListeners.Remove(_handedness);

            if (_customGestureData == null) return;

            if (_customGestureData.OnEnded != null)
                tmp_Listeners.GestureEnded.RemoveListener(_customGestureData.OnEnded);

            if (_customGestureData.OnPerformed != null)
                tmp_Listeners.GesturePerformed.RemoveListener(_customGestureData.OnPerformed);


            tmp_Listeners.HandShapeOrPose = null;
        }

        /// <summary>
        /// Returns the length of the index finger, as measured when this hand first became visible.
        /// Recomputed each time the hand is lost and found.
        /// </summary>
        internal bool TryGetIndexFingerLength(XRNode _xrNode, out float _length)
        {
            bool tmp_GotData = true;
            tmp_GotData &= TryGetJointPose(XRHandJointID.IndexTip, _xrNode, out var tmp_IndexTipPose);

            // If our first query fails, we've lost tracking, and we reset the cached finger length
            // to be recomputed when the hand is visible again.
            if (!tmp_GotData)
            {
                indexFingerLength = null;
                _length = 0;
                return false;
            }

            // If we are tracked and also have a cached finger length, return that.
            if (indexFingerLength.HasValue && indexFingerLength.Value != 0f)
            {
                _length = indexFingerLength.Value;
                return true;
            }

            // Otherwise, we compute a fresh finger length.
            tmp_GotData &= TryGetJointPose(XRHandJointID.IndexProximal, _xrNode, out var tmp_IndexKnuckle);
            tmp_GotData &= TryGetJointPose(XRHandJointID.IndexIntermediate, _xrNode, out var tmp_IndexMiddle);
            tmp_GotData &= TryGetJointPose(XRHandJointID.IndexDistal, _xrNode, out var tmp_IndexDistal);

            if (tmp_GotData)
            {
                indexFingerLength = Vector3.Distance(tmp_IndexKnuckle.position, tmp_IndexMiddle.position) +
                                    Vector3.Distance(tmp_IndexMiddle.position, tmp_IndexDistal.position) +
                                    Vector3.Distance(tmp_IndexDistal.position, tmp_IndexTipPose.position);

                _length = indexFingerLength.Value;
                return true;
            }

            indexFingerLength = null;
            _length = 0;
            return false;
        }


        private const float _CONST_PINCH_CLOSED_THRESHOLD = 0.25f;
        private const float _CONST_PINCH_OPEN_THRESHOLD = 0.75f;
        private const float _CONST_HAND_RAISE_CAMERA_FOV = 45;
        private const float _CONST_HAND_FACING_AWAY_TOLERANCE_IN_DEGREES = 75;
    }
}

#endif