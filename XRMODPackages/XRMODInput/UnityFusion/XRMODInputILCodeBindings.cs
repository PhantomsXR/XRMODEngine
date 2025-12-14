// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODInput.ILCode.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/


using System.Collections.Generic;
#if USE_XRI
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
#endif

namespace UnityFusion.Runtime.Generated
{
    public class XRMODInputILCodeBindings
    {
        //will auto register in unity
#if UNITY_5_3_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#endif
        static private void RegisterBindingAction()
        {
            UnityFusion.Runtime.CLRBinding.CLRBindingUtils.RegisterBindingAction(Initialize);
        }

        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(UnityFusion.Runtime.Enviorment.AppDomain _app)
        {
            _app.DelegateManager.RegisterMethodDelegate<UnityEngine.InputSystem.EnhancedTouch.Finger>();

#if USE_XRI
            _app.DelegateManager.RegisterFunctionDelegate<int, int, bool>();
            _app.DelegateManager.RegisterFunctionDelegate<IXRHoverInteractor, IXRHoverInteractable, bool>();
            _app.DelegateManager.RegisterFunctionDelegate<IXRSelectInteractor, IXRSelectInteractable, bool>();
            _app.DelegateManager.RegisterFunctionDelegate<IXRInteractor, IXRInteractable, float, float>();
            _app.DelegateManager.RegisterFunctionDelegate<IXRSelectInteractor, IXRSelectInteractable, bool>();
            _app.DelegateManager.RegisterFunctionDelegate<IXRInteractor>();
            _app.DelegateManager
                .RegisterFunctionDelegate<IXRInteractor, List<IXRInteractable>, List<IXRInteractable>>();
#endif

            // New Input System
            ReadOnlyArray_1_Touch_Binding_Enumerator_Binding.Register(_app);
            ReadOnlyArray_1_Touch_Binding.Register(_app);
            InputAction_Binding_CallbackContext_Binding.Register(_app);
            IInputActionCollection_Binding.Register(_app);
            IInputInteraction_Binding.Register(_app);
            InputAction_Binding.Register(_app);
            InputActionAsset_Binding.Register(_app);
            InputActionChange_Binding.Register(_app);
            InputActionMap_Binding.Register(_app);
            InputActionRebindingExtensions_Binding.Register(_app);
            InputActionPhase_Binding.Register(_app);
            InputActionProperty_Binding.Register(_app);
            InputActionReference_Binding.Register(_app);
            InputActionSetupExtensions_Binding.Register(_app);
            InputActionType_Binding.Register(_app);
            InputControlScheme_Binding.Register(_app);
            InputInteractionContext_Binding.Register(_app);
            InputSystem_Binding.Register(_app);
            CommonUsages_Binding.Register(_app);
            InputControl_Binding.Register(_app);
            InputControlLayoutChange_Binding.Register(_app);
            InputControlPath_Binding.Register(_app);
            UnityEngine_InputSystem_InputProcessor_Binding.Register(_app);
            UnityEngine_InputSystem_Gamepad_Binding.Register(_app);
            UnityEngine_InputSystem_InputDevice_Binding.Register(_app);
            UnityEngine_InputSystem_InputDeviceChange_Binding.Register(_app);
            UnityEngine_InputSystem_Mouse_Binding.Register(_app);
            UnityEngine_InputSystem_Pointer_Binding.Register(_app);
            UnityEngine_InputSystem_InputRemoting_Binding.Register(_app);
            UnityEngine_InputSystem_Gyroscope_Binding.Register(_app);
            UnityEngine_InputSystem_GravitySensor_Binding.Register(_app);
            UnityEngine_InputSystem_AttitudeSensor_Binding.Register(_app);
            UnityEngine_InputSystem_Accelerometer_Binding.Register(_app);
            UnityEngine_InputSystem_LinearAccelerationSensor_Binding.Register(_app);
            UnityEngine_InputSystem_MagneticFieldSensor_Binding.Register(_app);
            UnityEngine_InputSystem_LightSensor_Binding.Register(_app);
            UnityEngine_InputSystem_StepCounter_Binding.Register(_app);
            UnityEngine_InputSystem_TrackedDevice_Binding.Register(_app);
            UnityEngine_InputSystem_InputExtensions_Binding.Register(_app);
            InputControl_Binding.Register(_app);
            UnityEngine_InputSystem_DefaultInputActions_Binding.Register(_app);
            UnityEngine_InputSystem_InputValue_Binding.Register(_app);
            UnityEngine_InputSystem_PlayerInput_Binding.Register(_app);
            UnityEngine_InputSystem_PlayerInputManager_Binding.Register(_app);
            UnityEngine_InputSystem_PlayerJoinBehavior_Binding.Register(_app);
            UnityEngine_InputSystem_PlayerNotifications_Binding.Register(_app);
            UnityEngine_InputSystem_XR_PoseState_Binding.Register(_app);
            UnityEngine_InputSystem_XR_PoseControl_Binding.Register(_app);
            UnityEngine_InputSystem_XR_XRController_Binding.Register(_app);
            UnityEngine_InputSystem_XR_XRControllerWithRumble_Binding.Register(_app);
            UnityEngine_InputSystem_XR_TrackedPoseDriver_Binding.Register(_app);
            UnityEngine_InputSystem_Users_InputUser_Binding.Register(_app);
            UnityEngine_InputSystem_Users_InputUserChange_Binding.Register(_app);
            UnityEngine_InputSystem_Users_InputUserPairingOptions_Binding.Register(_app);
            UnityEngine_InputSystem_UI_ExtendedPointerEventData_Binding.Register(_app);
            UnityEngine_InputSystem_UI_UIPointerType_Binding.Register(_app);
            UnityEngine_InputSystem_UI_UIPointerBehavior_Binding.Register(_app);
            UnityEngine_InputSystem_UI_MultiplayerEventSystem_Binding.Register(_app);
            UnityEngine_InputSystem_UI_TrackedDeviceRaycaster_Binding.Register(_app);
            UnityEngine_InputSystem_UI_VirtualMouseInput_Binding.Register(_app);
            UnityEngine_InputSystem_OnScreen_OnScreenButton_Binding.Register(_app);
            UnityEngine_InputSystem_OnScreen_OnScreenStick_Binding.Register(_app);
            UnityEngine_InputSystem_Haptics_IDualMotorRumble_Binding.Register(_app);
            UnityEngine_InputSystem_Haptics_IHaptics_Binding.Register(_app);
            // Touch Enhanced
            UnityEngine_InputSystem_EnhancedTouch_EnhancedTouchSupport_Binding.Register(_app);
            UnityEngine_InputSystem_EnhancedTouch_Finger_Binding.Register(_app);
            UnityEngine_InputSystem_EnhancedTouch_Touch_Binding.Register(_app);
            UnityEngine_InputSystem_EnhancedTouch_TouchHistory_Binding.Register(_app);
            UnityEngine_InputSystem_EnhancedTouch_TouchSimulation_Binding.Register(_app);
            // Touch
            UnityEngine_InputSystem_TouchPhase_Binding.Register(_app);
            UnityEngine_InputSystem_Touchscreen_Binding.Register(_app);
#if UNITY_EDITOR || UNITY_IOS || UNITY_TVOS || PACKAGE_DOCS_GENERATION
            UnityEngine_InputSystem_InputSettings_Binding.Register(_app);
#endif
            Phantom_XRMOD_XRMODInput_Runtime_Vibration_Binding.Register(_app);


#if XR_HAND
            // XR Hand
            UnityEngine_XR_Hands_XRHandJointTrackingState_Binding.Register(_app);
            UnityEngine_XR_Hands_XRHandJointID_Binding.Register(_app);
            UnityEngine_XR_Hands_Handedness_Binding.Register(_app);
            UnityEngine_XR_Hands_XRHand_Binding.Register(_app);
            UnityEngine_XR_Hands_XRHandDevice_Binding.Register(_app);
            UnityEngine_XR_Hands_XRHandJoint_Binding.Register(_app);
            UnityEngine_XR_Hands_XRHandMeshController_Binding.Register(_app);
            UnityEngine_XR_Hands_XRHandSubsystem_Binding.Register(_app);
            UnityEngine_XR_Hands_XRHandTrackingEvents_Binding.Register(_app);
            GestureUtilities_Binding.Register(_app);
            HandVisualizer_Binding.Register(_app);
            PinchPointFollow_Binding.Register(_app);
            PokeGestureDetector_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_CustomGestureData_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_InteractorHandness_Binding.Register(_app);
#endif


#if USE_XRI
            // XRI
            UnityEngine_XR_Interaction_Toolkit_Interactors_NearFarInteractor_Binding.Register(_app);
            UnityEngine_XR_Interaction_Toolkit_Inputs_InputActionManager_Binding.Register(_app);
            UnityEngine_XR_Interaction_Toolkit_Interactables_XRBaseInteractable_Binding.Register(_app);
            UnityEngine_XR_Interaction_Toolkit_Interactors_IXRInteractor_Binding.Register(_app);
            UnityEngine_XR_Interaction_Toolkit_Interactors_XRRayInteractor_Binding.Register(_app);
            UnityEngine_XR_Interaction_Toolkit_SelectEnterEventArgs_Binding.Register(_app);
            UnityEngine_XR_Interaction_Toolkit_Transformers_XRBaseGrabTransformer_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_1_HoverExitEventArgs_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_1_HoverEnterEventArgs_Binding.Register(_app);
            UnityEngine_XR_Interaction_Toolkit_HoverEnterEventArgs_Binding.Register(_app);
            UnityEngine_XR_Interaction_Toolkit_HoverExitEventArgs_Binding.Register(_app);
            UnityEngine_XR_Interaction_Toolkit_SelectExitEventArgs_Binding.Register(_app);
                
            Phantom_XRMOD_XRMODInput_Runtime_HandsAggregatorSubsystem_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_DynamicMoveProvider_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_InputType_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_PoseWrapper_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_Vector3Wrapper_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_UniversalXRInput_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_RotationAxisLockGrabTransformer_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_XRBaseGrabTransformAdapter_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_XRControllerKey_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_InteractorMode_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_XRIFilters_XRITargetFilter_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_XRIFilters_XRISelectFilter_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_XRIFilters_XRIPokeFilter_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_XRIFilters_XRIInteractionStrengthFilter_Binding.Register(_app);
            Phantom_XRMOD_XRMODInput_Runtime_XRIFilters_XRIHoverFilter_Binding.Register(_app);
            Phantom_XRMOD_UIFramework_Runtime_Keyboard_GlobalNonNativeKeyboard_Binding.Register(_app);

#endif
        }
    }
}