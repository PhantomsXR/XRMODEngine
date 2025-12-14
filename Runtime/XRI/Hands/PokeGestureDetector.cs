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
#if USE_XRI && XR_HANDS_1_1_OR_NEWER

using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.Serialization;
#if XR_HANDS_1_1_OR_NEWER
using UnityEngine.XR.Hands;
#endif

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// Behavior that provides events for when an <see cref="XRHand"/> starts and ends a poke gesture. The gesture is
    /// detected if the index finger is extended and the middle, ring, and little fingers are curled in.
    /// </summary>
    public class PokeGestureDetector : MonoBehaviour
    {
        [SerializeField] [Tooltip("Which hand to check for the poke gesture.")]
#if XR_HANDS_1_1_OR_NEWER
        Handedness handedness;
#else
        int handedness;
#endif

        [SerializeField] [Tooltip("Called when the hand has started a poke gesture.")]
        UnityEvent pokeGestureStarted;

        [SerializeField] [Tooltip("Called when the hand has ended a poke gesture.")]
        UnityEvent pokeGestureEnded;

#if XR_HANDS_1_1_OR_NEWER
        XRHandSubsystem subsystem;
        bool isPoking;

        static readonly List<XRHandSubsystem> subsystems = new List<XRHandSubsystem>();
#endif

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        protected void OnEnable()
        {
#if XR_HANDS_1_1_OR_NEWER
            SubsystemManager.GetSubsystems(subsystems);
            if (subsystems.Count == 0)
                return;

            subsystem = subsystems[0];
            subsystem.updatedHands += OnUpdatedHands;
#else
            Debug.LogError("Script requires XR Hands (com.unity.xr.hands) package. Install using Window > Package Manager or click Fix on the related issue in Edit > Project Settings > XR Plug-in Management > Project Validation.", this);
#endif
        }

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        protected void OnDisable()
        {
#if XR_HANDS_1_1_OR_NEWER
            if (subsystem == null)
                return;

            subsystem.updatedHands -= OnUpdatedHands;
            subsystem = null;
#endif
        }

#if XR_HANDS_1_1_OR_NEWER
        void OnUpdatedHands(XRHandSubsystem _subsystem, XRHandSubsystem.UpdateSuccessFlags _updateSuccessFlags,
            XRHandSubsystem.UpdateType _updateType)
        {
            var tmp_WasPoking = isPoking;
            switch (handedness)
            {
                case Handedness.Left:
                    if (!HasUpdateSuccessFlag(_updateSuccessFlags, XRHandSubsystem.UpdateSuccessFlags.LeftHandJoints))
                        return;

                    var tmp_LeftHand = _subsystem.leftHand;
                    isPoking = GestureUtilities.IsIndexExtended(tmp_LeftHand) &&
                               GestureUtilities.IsMiddleGrabbing(tmp_LeftHand) &&
                               GestureUtilities.IsRingGrabbing(tmp_LeftHand) &&
                               GestureUtilities.IsLittleGrabbing(tmp_LeftHand);
                    break;
                case Handedness.Right:
                    if (!HasUpdateSuccessFlag(_updateSuccessFlags, XRHandSubsystem.UpdateSuccessFlags.RightHandJoints))
                        return;

                    var tmp_RightHand = _subsystem.rightHand;
                    isPoking = GestureUtilities.IsIndexExtended(tmp_RightHand) &&
                               GestureUtilities.IsMiddleGrabbing(tmp_RightHand) &&
                               GestureUtilities.IsRingGrabbing(tmp_RightHand) &&
                               GestureUtilities.IsLittleGrabbing(tmp_RightHand);
                    break;
            }

            if (isPoking && !tmp_WasPoking)
                StartPokeGesture();
            else if (!isPoking && tmp_WasPoking)
                EndPokeGesture();
        }

        /// <summary>
        /// Determines whether one or more bit fields are set in the flags.
        /// Non-boxing version of <c>HasFlag</c> for <see cref="XRHandSubsystem.UpdateSuccessFlags"/>.
        /// </summary>
        /// <param name="_successFlags">The flags enum instance.</param>
        /// <param name="_successFlag">The flag to check if set.</param>
        /// <returns>Returns <see langword="true"/> if the bit field or bit fields are set, otherwise returns <see langword="false"/>.</returns>
        static bool HasUpdateSuccessFlag(XRHandSubsystem.UpdateSuccessFlags _successFlags,
            XRHandSubsystem.UpdateSuccessFlags _successFlag)
        {
            return (_successFlags & _successFlag) == _successFlag;
        }


        void StartPokeGesture()
        {
            isPoking = true;
            pokeGestureStarted.Invoke();
        }

        void EndPokeGesture()
        {
            isPoking = false;
            pokeGestureEnded.Invoke();
        }
#endif
    }
}

#endif