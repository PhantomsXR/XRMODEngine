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

using System;
using UnityEngine;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
#if XR_HANDS_1_1_OR_NEWER
using UnityEngine.XR.Hands;
#endif

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// Behavior that provides events for when the system gesture starts and ends and when the
    /// menu palm pinch gesture occurs while hand tracking is in use.
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.unity3d.com/Packages/com.unity.xr.hands@1.1/manual/features/metahandtrackingaim.html">Meta Hand Tracking Aim</see>.
    /// </remarks>
    /// <seealso cref="MetaAimHand"/>
    public class MetaSystemGestureDetector : MonoBehaviour
    {
        /// <summary>
        /// The state of the system gesture.
        /// </summary>
        /// <seealso cref="MetaSystemGestureDetector.SystemGestureStateInfo"/>
        public enum SystemGestureState
        {
            /// <summary>
            /// The system gesture has fully ended.
            /// </summary>
            Ended,

            /// <summary>
            /// The system gesture has started or is ongoing. Typically, this means the user is looking at
            /// their palm at eye level or has not yet released the palm pinch gesture or turned their hand around.
            /// </summary>
            Started,
        }

        [SerializeField] InputActionProperty aimFlagsAction = new(new InputAction(expectedControlType: "Integer"));

        /// <summary>
        /// The Input System action to read the Aim Flags.
        /// </summary>
        /// <remarks>
        /// Typically a <b>Value</b> action type with an <b>Integer</b> control type with a binding to either:
        /// <list type="bullet">
        /// <item>
        /// <description><c>&lt;MetaAimHand&gt;{LeftHand}/aimFlags</c></description>
        /// </item>
        /// <item>
        /// <description><c>&lt;MetaAimHand&gt;{RightHand}/aimFlags</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        public InputActionProperty AimFlagsAction
        {
            get => aimFlagsAction;
            set
            {
                if (Application.isPlaying)
                    UnbindAimFlags();

                aimFlagsAction = value;

                if (Application.isPlaying && isActiveAndEnabled)
                    BindAimFlags();
            }
        }

        [FormerlySerializedAs("m_SystemGestureStarted")] [SerializeField]
        UnityEvent systemGestureStarted;

        /// <summary>
        /// Calls the methods in its invocation list when the system gesture starts, which typically occurs when
        /// the user looks at their palm at eye level.
        /// </summary>
        /// <seealso cref="SystemGestureEnded"/>
        /// <seealso cref="MetaAimFlags.SystemGesture"/>
        public UnityEvent SystemGestureStarted
        {
            get => systemGestureStarted;
            set => systemGestureStarted = value;
        }

        [FormerlySerializedAs("m_SystemGestureEnded")] [SerializeField]
        UnityEvent systemGestureEnded;

        /// <summary>
        /// Calls the methods in its invocation list when the system gesture ends.
        /// </summary>
        /// <remarks>
        /// This behavior postpones ending the system gesture until the user has turned their hand around.
        /// In other words, it isn't purely based on the <see cref="MetaAimFlags.SystemGesture"/>
        /// being cleared from the aim flags in order to better replicate the native visual feedback in the Meta Home menu.
        /// </remarks>
        /// <seealso cref="SystemGestureStarted"/>
        /// <seealso cref="MetaAimFlags.SystemGesture"/>
        public UnityEvent SystemGestureEnded
        {
            get => systemGestureEnded;
            set => systemGestureEnded = value;
        }

        [FormerlySerializedAs("m_MenuPressed")] [SerializeField]
        UnityEvent menuPressed;

        /// <summary>
        /// Calls the methods in its invocation list when the menu button is triggered by a palm pinch gesture.
        /// </summary>
        /// <remarks>
        /// This is triggered by the non-dominant hand, which is the one with the menu icon (&#x2630;).
        /// The universal menu (Oculus icon) on the dominant hand does not trigger this event.
        /// </remarks>
        /// <seealso cref="MetaAimFlags.MenuPressed"/>
        public UnityEvent MenuPressed
        {
            get => menuPressed;
            set => menuPressed = value;
        }

        /// <summary>
        /// The state of the system gesture.
        /// </summary>
        /// <seealso cref="SystemGestureState"/>
        /// <seealso cref="SystemGestureStarted"/>
        /// <seealso cref="SystemGestureEnded"/>
        public IReadOnlyBindableVariable<SystemGestureState> SystemGestureStateInfo => systemGestureStateInfo;

        readonly BindableEnum<SystemGestureState> systemGestureStateInfo = new(checkEquality: false);

#if XR_HANDS_1_1_OR_NEWER
        [NonSerialized] // NonSerialized is required to avoid an "Unsupported enum base type" error about the Flags enum being ulong
        MetaAimFlags aimFlags;
#endif

        bool m_AimFlagsBound;

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        protected void OnEnable()
        {
            BindAimFlags();

#if XR_HANDS_1_1_OR_NEWER
            var tmp_Action = aimFlagsAction.action;
            if (tmp_Action != null)
                // Force invoking the events upon initialization to simplify making sure the callback's desired results are synced
                UpdateAimFlags((MetaAimFlags) tmp_Action.ReadValue<int>(), true);
#else
            Debug.LogWarning("Script requires XR Hands (com.unity.xr.hands) package to monitor Meta Aim Flags. Install using Window > Package Manager or click Fix on the related issue in Edit > Project Settings > XR Plug-in Management > Project Validation.", this);
            SetGestureState(SystemGestureState.Ended, true);
#endif
        }

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        protected void OnDisable()
        {
            UnbindAimFlags();
        }

        void BindAimFlags()
        {
            if (m_AimFlagsBound)
                return;

            var action = aimFlagsAction.action;
            if (action == null)
                return;

            action.performed += OnAimFlagsActionPerformedOrCanceled;
            action.canceled += OnAimFlagsActionPerformedOrCanceled;
            m_AimFlagsBound = true;

            aimFlagsAction.EnableDirectAction();
        }

        void UnbindAimFlags()
        {
            if (!m_AimFlagsBound)
                return;

            var action = aimFlagsAction.action;
            if (action == null)
                return;

            aimFlagsAction.DisableDirectAction();

            action.performed -= OnAimFlagsActionPerformedOrCanceled;
            action.canceled -= OnAimFlagsActionPerformedOrCanceled;
            m_AimFlagsBound = false;
        }

        void SetGestureState(SystemGestureState state, bool forceInvoke)
        {
            if (!forceInvoke && systemGestureStateInfo.Value == state)
                return;

            systemGestureStateInfo.Value = state;
            switch (state)
            {
                case SystemGestureState.Ended:
                    systemGestureEnded?.Invoke();
                    break;
                case SystemGestureState.Started:
                    systemGestureStarted?.Invoke();
                    break;
            }
        }

#if XR_HANDS_1_1_OR_NEWER
        void UpdateAimFlags(MetaAimFlags _value, bool _forceInvoke = false)
        {
            var tmp_HadMenuPressed = (aimFlags & MetaAimFlags.MenuPressed) != 0;
            aimFlags = _value;
            var tmp_HasSystemGesture = (aimFlags & MetaAimFlags.SystemGesture) != 0;
            var tmp_HasMenuPressed = (aimFlags & MetaAimFlags.MenuPressed) != 0;
            var tmp_HasValid = (aimFlags & MetaAimFlags.Valid) != 0;
            var tmp_HasIndexPinching = (aimFlags & MetaAimFlags.IndexPinching) != 0;

            if (!tmp_HadMenuPressed && tmp_HasMenuPressed)
            {
                menuPressed?.Invoke();
            }

            if (tmp_HasSystemGesture || tmp_HasMenuPressed)
            {
                SetGestureState(SystemGestureState.Started, _forceInvoke);
                return;
            }

            if (tmp_HasValid)
            {
                SetGestureState(SystemGestureState.Ended, _forceInvoke);
                return;
            }

            // We want to keep the system gesture going when the user is still index pinching
            // even though the SystemGesture flag is no longer set.
            if (tmp_HasIndexPinching && systemGestureStateInfo.Value != SystemGestureState.Ended)
            {
                SetGestureState(SystemGestureState.Started, _forceInvoke);
                return;
            }

            SetGestureState(SystemGestureState.Ended, _forceInvoke);
        }
#endif

        void OnAimFlagsActionPerformedOrCanceled(InputAction.CallbackContext _context)
        {
#if XR_HANDS_1_1_OR_NEWER
            UpdateAimFlags((MetaAimFlags) _context.ReadValue<int>());
#endif
        }
    }
}

#endif