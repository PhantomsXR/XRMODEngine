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
#if USE_XRI && XR_HANDS_1_1_OR_NEWER 
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Hands;
using UnityEngine.XR.Hands.Gestures;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    public class StaticHandGestureListener : MonoBehaviour
    {
        [SerializeField]
        [Tooltip(
            "The hand tracking events component to subscribe to receive updated joint data to be used for gesture detection.")]
        XRHandTrackingEvents handTrackingEvents;

        [SerializeField] [Tooltip("The hand shape or pose that must be detected for the gesture to be performed.")]
        ScriptableObject handShapeOrPose;

        [SerializeField] [Tooltip("The target Transform to user for target conditions in the hand shape or pose.")]
        Transform targetTransform;

        [SerializeField] [Tooltip("The event fired when the gesture is performed.")]
        UnityEvent gesturePerformed;

        [SerializeField] [Tooltip("The event fired when the gesture is ended.")]
        UnityEvent gestureEnded;

        [SerializeField]
        [Tooltip(
            "The minimum amount of time the hand must be held in the required shape and orientation for the gesture to be performed.")]
        float minimumHoldTime = 0.2f;

        [SerializeField] [Tooltip("The interval at which the gesture detection is performed.")]
        float gestureDetectionInterval = 0.1f;

        [SerializeField] [Tooltip("The static gestures associated with this gestures handedness.")]
        StaticHandGestureListener[] staticGestures;


        XRHandShape handShape;
        XRHandPose handPose;
        bool wasDetected;
        bool performedTriggered;
        float timeOfLastConditionCheck;
        float holdStartTime;


        /// <summary>
        /// The hand tracking events component to subscribe to receive updated joint data to be used for gesture detection.
        /// </summary>
        public XRHandTrackingEvents HandTrackingEvents
        {
            get => handTrackingEvents;
            set => handTrackingEvents = value;
        }

        /// <summary>
        /// The hand shape or pose that must be detected for the gesture to be performed.
        /// </summary>
        public ScriptableObject HandShapeOrPose
        {
            get => handShapeOrPose;
            set => handShapeOrPose = value;
        }

        /// <summary>
        /// The event fired when the gesture is performed.
        /// </summary>
        public UnityEvent GesturePerformed
        {
            get => gesturePerformed;
            set => gesturePerformed = value;
        }

        /// <summary>
        /// The event fired when the gesture is ended.
        /// </summary>
        public UnityEvent GestureEnded
        {
            get => gestureEnded;
            set => gestureEnded = value;
        }

        /// <summary>
        /// The minimum amount of time the hand must be held in the required shape and orientation for the gesture to be performed.
        /// </summary>
        public float MinimumHoldTime
        {
            get => minimumHoldTime;
            set => minimumHoldTime = value;
        }

        /// <summary>
        /// The interval at which the gesture detection is performed.
        /// </summary>
        public float GestureDetectionInterval
        {
            get => gestureDetectionInterval;
            set => gestureDetectionInterval = value;
        }
 
        void OnEnable()
        {
            if (handTrackingEvents == null)
                handTrackingEvents = GetComponent<XRHandTrackingEvents>();

            if (!handShapeOrPose) return;
            handTrackingEvents.jointsUpdated.AddListener(OnJointsUpdated);

            handShape = handShapeOrPose as XRHandShape;
            handPose = handShapeOrPose as XRHandPose;

            if (handPose != null && handPose.relativeOrientation != null)
                handPose.relativeOrientation.targetTransform = targetTransform;
        }

        void OnDisable()
        {
            if (!handShapeOrPose) return;
            handTrackingEvents.jointsUpdated.RemoveListener(OnJointsUpdated);
        }

        void OnJointsUpdated(XRHandJointsUpdatedEventArgs _eventArgs)
        {
            if (!handShapeOrPose) return;
            if (!isActiveAndEnabled ||
                Time.timeSinceLevelLoad < timeOfLastConditionCheck + gestureDetectionInterval)
                return;

            var tmp_Detected =
                handTrackingEvents.handIsTracked &&
                handShape != null && handShape.CheckConditions(_eventArgs) ||
                handPose != null && handPose.CheckConditions(_eventArgs);

            switch (wasDetected)
            {
                case false when tmp_Detected:
                    holdStartTime = Time.timeSinceLevelLoad;
                    break;
                case true when !tmp_Detected:
                    performedTriggered = false;
                    gestureEnded?.Invoke();
                    break;
            }

            wasDetected = tmp_Detected;

            if (!performedTriggered && tmp_Detected)
            {
                var tmp_HoldTimer = Time.timeSinceLevelLoad - holdStartTime;
                if (tmp_HoldTimer > minimumHoldTime)
                {
                    gesturePerformed?.Invoke();
                    performedTriggered = true;
                }
            }

            timeOfLastConditionCheck = Time.timeSinceLevelLoad;
        }
    }
}

#endif