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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.UI;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// Use this class to mediate the controllers and their associated interactors and input actions under different interaction states.
    /// </summary>
    [AddComponentMenu("XR/Action Based Controller Manager")]
    [DefaultExecutionOrder(CONST_K_UPDATE_ORDER)]
    public class ActionBasedControllerManager : MonoBehaviour
    {
        /// <summary>
        /// Order when instances of type <see cref="ActionBasedControllerManager"/> are updated.
        /// </summary>
        /// <remarks>
        /// Executes before controller components to ensure input processors can be attached
        /// to input actions and/or bindings before the controller component reads the current
        /// values of the input actions.
        /// </remarks>
        public const int CONST_K_UPDATE_ORDER = XRInteractionUpdateOrder.k_Controllers - 1;

        [Space]
        [Header("Interactors")]
        [SerializeField]
        [Tooltip("The GameObject containing the interaction group used for direct and distant manipulation.")]
        UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup manipulationInteractionGroup;

        [SerializeField] [Tooltip("The GameObject containing the interactor used for direct manipulation.")]
        UnityEngine.XR.Interaction.Toolkit.Interactors.XRDirectInteractor directInteractor;

        [SerializeField] [Tooltip("The GameObject containing the interactor used for distant/ray manipulation.")]
        UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor rayInteractor;

        [FormerlySerializedAs("m_TeleportInteractor")]
        [SerializeField]
        [Tooltip("The GameObject containing the interactor used for teleportation.")]
        UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor teleportInteractor;

        [FormerlySerializedAs("m_TeleportModeActivate")]
        [Space]
        [Header("Controller Actions")]
        [SerializeField]
        [Tooltip("The reference to the action to start the teleport aiming mode for this controller.")]
        InputActionReference teleportModeActivate;

        [FormerlySerializedAs("m_TeleportModeCancel")]
        [SerializeField]
        [Tooltip("The reference to the action to cancel the teleport aiming mode for this controller.")]
        InputActionReference teleportModeCancel;

        [FormerlySerializedAs("m_Turn")]
        [SerializeField]
        [Tooltip("The reference to the action of continuous turning the XR Origin with this controller.")]
        InputActionReference turn;

        [FormerlySerializedAs("m_SnapTurn")]
        [SerializeField]
        [Tooltip("The reference to the action of snap turning the XR Origin with this controller.")]
        InputActionReference snapTurn;

        [FormerlySerializedAs("m_Move")]
        [SerializeField]
        [Tooltip("The reference to the action of moving the XR Origin with this controller.")]
        InputActionReference move;

        [FormerlySerializedAs("m_UIScroll")]
        [SerializeField]
        [Tooltip("The reference to the action of scrolling UI with this controller.")]
        InputActionReference uiScroll;

        [FormerlySerializedAs("m_SmoothMotionEnabled")]
        [Space]
        [Header("Locomotion Settings")]
        [SerializeField]
        [Tooltip("If true, continuous movement will be enabled. If false, teleport will enabled.")]
        bool smoothMotionEnabled;

        [FormerlySerializedAs("m_SmoothTurnEnabled")]
        [SerializeField]
        [Tooltip(
            "If true, continuous turn will be enabled. If false, snap turn will be enabled. Note: If smooth motion is enabled and enable strafe is enabled on the continuous move provider, turn will be overriden in favor of strafe.")]
        bool smoothTurnEnabled;

        [FormerlySerializedAs("m_UIScrollingEnabled")]
        [Space]
        [Header("UI Settings")]
        [SerializeField]
        [Tooltip("If true, UI scrolling will be enabled.")]
        bool uiScrollingEnabled;

        [Space]
        [Header("Mediation Events")]
        [SerializeField]
        [Tooltip("Event fired when the active ray interactor changes between interaction and teleport.")]
        UnityEvent<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRRayProvider> m_RayInteractorChanged;

        public bool SmoothMotionEnabled
        {
            get => smoothMotionEnabled;
            set
            {
                smoothMotionEnabled = value;
                UpdateLocomotionActions();
            }
        }

        public bool SmoothTurnEnabled
        {
            get => smoothTurnEnabled;
            set
            {
                smoothTurnEnabled = value;
                UpdateLocomotionActions();
            }
        }

        public bool UIScrollingEnabled
        {
            get => uiScrollingEnabled;
            set
            {
                uiScrollingEnabled = value;
                UpdateUIActions();
            }
        }

        bool postponedDeactivateTeleport;
        bool uiScrollModeActive = false;

        const int _CONST_K_INTERACTOR_NOT_IN_GROUP = -1;

        IEnumerator afterInteractionEventsRoutine;
        HashSet<InputAction> locomotionUsers = new HashSet<InputAction>();

        /// <summary>
        /// Temporary scratch list to populate with the group members of the interaction group.
        /// </summary>
        static readonly List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember> _GROUP_MEMBERS =
            new List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember>();

        // For our input mediation, we are enforcing a few rules between direct, ray, and teleportation interaction:
        // 1. If the Teleportation Ray is engaged, the Ray interactor is disabled
        // 2. The interaction group ensures that the Direct and Ray interactors cannot interact at the same time, with the Direct interactor taking priority
        // 3. If the Ray interactor is selecting, all locomotion controls are disabled (teleport ray, move, and turn controls) to prevent input collision
        void SetupInteractorEvents()
        {
            if (rayInteractor != null)
            {
                rayInteractor.selectEntered.AddListener(OnRaySelectEntered);
                rayInteractor.selectExited.AddListener(OnRaySelectExited);
                rayInteractor.uiHoverEntered.AddListener(OnUIHoverEntered);
                rayInteractor.uiHoverExited.AddListener(OnUIHoverExited);
            }

            var tmp_TeleportModeActivateAction = GetInputAction(teleportModeActivate);
            if (tmp_TeleportModeActivateAction != null)
            {
                tmp_TeleportModeActivateAction.performed += OnStartTeleport;
                tmp_TeleportModeActivateAction.performed += OnStartLocomotion;
                tmp_TeleportModeActivateAction.canceled += OnCancelTeleport;
                tmp_TeleportModeActivateAction.canceled += OnStopLocomotion;
            }

            var tmp_TeleportModeCancelAction = GetInputAction(teleportModeCancel);
            if (tmp_TeleportModeCancelAction != null)
            {
                tmp_TeleportModeCancelAction.performed += OnCancelTeleport;
                tmp_TeleportModeActivateAction.canceled += OnStopLocomotion;
            }

            var tmp_MoveAction = GetInputAction(move);
            if (tmp_MoveAction != null)
            {
                tmp_MoveAction.performed += OnStartLocomotion;
                tmp_MoveAction.canceled += OnStopLocomotion;
            }

            var tmp_TurnAction = GetInputAction(turn);
            if (tmp_TurnAction != null)
            {
                tmp_TurnAction.performed += OnStartLocomotion;
                tmp_TurnAction.canceled += OnStopLocomotion;
            }
        }

        void TeardownInteractorEvents()
        {
            if (rayInteractor != null)
            {
                rayInteractor.selectEntered.RemoveListener(OnRaySelectEntered);
                rayInteractor.selectExited.RemoveListener(OnRaySelectExited);
            }

            var tmp_TeleportModeActivateAction = GetInputAction(teleportModeActivate);
            if (tmp_TeleportModeActivateAction != null)
            {
                tmp_TeleportModeActivateAction.performed -= OnStartTeleport;
                tmp_TeleportModeActivateAction.performed -= OnStartLocomotion;
                tmp_TeleportModeActivateAction.canceled -= OnCancelTeleport;
                tmp_TeleportModeActivateAction.canceled -= OnStopLocomotion;
            }

            var tmp_TeleportModeCancelAction = GetInputAction(teleportModeCancel);
            if (tmp_TeleportModeCancelAction != null)
            {
                tmp_TeleportModeCancelAction.performed -= OnCancelTeleport;
                tmp_TeleportModeCancelAction.performed -= OnStopLocomotion;
            }

            var tmp_MoveAction = GetInputAction(move);
            if (tmp_MoveAction != null)
            {
                tmp_MoveAction.performed -= OnStartLocomotion;
                tmp_MoveAction.canceled -= OnStopLocomotion;
            }

            var tmp_TurnAction = GetInputAction(turn);
            if (tmp_TurnAction != null)
            {
                tmp_TurnAction.performed -= OnStartLocomotion;
                tmp_TurnAction.canceled -= OnStopLocomotion;
            }
        }

        void OnStartTeleport(InputAction.CallbackContext _context)
        {
            postponedDeactivateTeleport = false;

            if (teleportInteractor != null)
                teleportInteractor.gameObject.SetActive(true);

            if (rayInteractor != null)
                rayInteractor.gameObject.SetActive(false);

            m_RayInteractorChanged?.Invoke(teleportInteractor);
        }

        void OnCancelTeleport(InputAction.CallbackContext _context)
        {
            // Do not deactivate the teleport interactor in this callback.
            // We delay turning off the teleport interactor in this callback so that
            // the teleport interactor has a chance to complete the teleport if needed.
            // OnAfterInteractionEvents will handle deactivating its GameObject.
            postponedDeactivateTeleport = true;

            if (rayInteractor != null)
                rayInteractor.gameObject.SetActive(true);

            m_RayInteractorChanged?.Invoke(rayInteractor);
        }

        void OnStartLocomotion(InputAction.CallbackContext _context)
        {
            if (!_context.started)
                return;

            locomotionUsers.Add(_context.action);
        }

        void OnStopLocomotion(InputAction.CallbackContext _context)
        {
            locomotionUsers.Remove(_context.action);

            if (locomotionUsers.Count == 0 && uiScrollModeActive)
            {
                DisableLocomotionActions();
            }
        }

        void OnRaySelectEntered(SelectEnterEventArgs _args)
        {
            // Disable locomotion and turn actions
            DisableLocomotionActions();
        }

        void OnRaySelectExited(SelectExitEventArgs _args)
        {
            // Re-enable the locomotion and turn actions
            UpdateLocomotionActions();
        }

        void OnUIHoverEntered(UIHoverEventArgs _args)
        {
            uiScrollModeActive = _args.deviceModel.isScrollable && uiScrollingEnabled;
            if (!uiScrollModeActive)
                return;

            // If locomotion is occurring, wait
            if (locomotionUsers.Count == 0)
            {
                // Disable locomotion and turn actions
                DisableLocomotionActions();
            }
        }

        void OnUIHoverExited(UIHoverEventArgs _args)
        {
            uiScrollModeActive = false;

            // Re-enable the locomotion and turn actions
            UpdateLocomotionActions();
        }

        protected void Awake()
        {
            afterInteractionEventsRoutine = OnAfterInteractionEvents();
        }

        protected void OnEnable()
        {
            if (teleportInteractor != null)
                teleportInteractor.gameObject.SetActive(false);

            SetupInteractorEvents();

            // Start the coroutine that executes code after the Update phase (during yield null).
            // Since this behavior has an execution order that runs before the XRInteractionManager,
            // we use the coroutine to run after the selection events
            StartCoroutine(afterInteractionEventsRoutine);
        }

        protected void OnDisable()
        {
            TeardownInteractorEvents();

            StopCoroutine(afterInteractionEventsRoutine);
        }

        protected void Start()
        {
            // Ensure the enabled state of locomotion and turn actions are properly set up.
            // Called in Start so it is done after the InputActionManager enables all input actions earlier in OnEnable.
            UpdateLocomotionActions();
            UpdateUIActions();

            if (manipulationInteractionGroup == null)
            {
                Debug.LogError(
                    "Missing required Manipulation Interaction Group reference. Use the Inspector window to assign the XR Interaction Group component reference.",
                    this);
                return;
            }

            // Ensure interactors are properly set up in the interaction group by adding
            // them if necessary and ordering Direct before Ray interactor.
            var tmp_DirectInteractorIndex = _CONST_K_INTERACTOR_NOT_IN_GROUP;
            var tmp_RayInteractorIndex = _CONST_K_INTERACTOR_NOT_IN_GROUP;
            manipulationInteractionGroup.GetGroupMembers(_GROUP_MEMBERS);
            for (var tmp_Idx = 0; tmp_Idx < _GROUP_MEMBERS.Count; ++tmp_Idx)
            {
                var tmp_GroupMember = _GROUP_MEMBERS[tmp_Idx];
                if (ReferenceEquals(tmp_GroupMember, directInteractor))
                    tmp_DirectInteractorIndex = tmp_Idx;
                else if (ReferenceEquals(tmp_GroupMember, rayInteractor))
                    tmp_RayInteractorIndex = tmp_Idx;
            }

            if (tmp_DirectInteractorIndex == _CONST_K_INTERACTOR_NOT_IN_GROUP)
            {
                // Must add Direct interactor to group, and make sure it is ordered before the Ray interactor
                if (tmp_RayInteractorIndex == _CONST_K_INTERACTOR_NOT_IN_GROUP)
                {
                    // Must add Ray interactor to group
                    if (directInteractor != null)
                        manipulationInteractionGroup.AddGroupMember(directInteractor);

                    if (rayInteractor != null)
                        manipulationInteractionGroup.AddGroupMember(rayInteractor);
                }
                else if (directInteractor != null)
                {
                    manipulationInteractionGroup.MoveGroupMemberTo(directInteractor, tmp_RayInteractorIndex);
                }
            }
            else
            {
                if (tmp_RayInteractorIndex == _CONST_K_INTERACTOR_NOT_IN_GROUP)
                {
                    // Must add Ray interactor to group
                    if (rayInteractor != null)
                        manipulationInteractionGroup.AddGroupMember(rayInteractor);
                }
                else
                {
                    // Must make sure Direct interactor is ordered before the Ray interactor
                    if (tmp_RayInteractorIndex < tmp_DirectInteractorIndex)
                    {
                        manipulationInteractionGroup.MoveGroupMemberTo(directInteractor, tmp_RayInteractorIndex);
                    }
                }
            }
        }

        IEnumerator OnAfterInteractionEvents()
        {
            while (true)
            {
                // Yield so this coroutine is resumed after the teleport interactor
                // has a chance to process its select interaction event during Update.
                yield return null;

                if (postponedDeactivateTeleport)
                {
                    if (teleportInteractor != null)
                        teleportInteractor.gameObject.SetActive(false);

                    postponedDeactivateTeleport = false;
                }
            }
        }

        void UpdateLocomotionActions()
        {
            // Disable/enable Teleport and Turn when Move is enabled/disabled.
            SetEnabled(move, smoothMotionEnabled);
            SetEnabled(teleportModeActivate, !smoothMotionEnabled);
            SetEnabled(teleportModeCancel, !smoothMotionEnabled);

            // Disable ability to turn when using continuous movement
            SetEnabled(turn, !smoothMotionEnabled && smoothTurnEnabled);
            SetEnabled(snapTurn, !smoothMotionEnabled && !smoothTurnEnabled);
        }

        void DisableLocomotionActions()
        {
            DisableAction(move);
            DisableAction(teleportModeActivate);
            DisableAction(teleportModeCancel);
            DisableAction(turn);
            DisableAction(snapTurn);
        }

        void UpdateUIActions()
        {
            SetEnabled(uiScroll, uiScrollingEnabled);
        }

        static void SetEnabled(InputActionReference _actionReference, bool _enabled)
        {
            if (_enabled)
                EnableAction(_actionReference);
            else
                DisableAction(_actionReference);
        }

        static void EnableAction(InputActionReference _actionReference)
        {
            var tmp_Action = GetInputAction(_actionReference);
            if (tmp_Action != null && !tmp_Action.enabled)
                tmp_Action.Enable();
        }

        static void DisableAction(InputActionReference _actionReference)
        {
            var tmp_Action = GetInputAction(_actionReference);
            if (tmp_Action != null && tmp_Action.enabled)
                tmp_Action.Disable();
        }

        static InputAction GetInputAction(InputActionReference _actionReference)
        {
#pragma warning disable IDE0031 // Use null propagation -- Do not use for UnityEngine.Object types
            return _actionReference != null ? _actionReference.action : null;
#pragma warning restore IDE0031
        }
    }
}

#endif