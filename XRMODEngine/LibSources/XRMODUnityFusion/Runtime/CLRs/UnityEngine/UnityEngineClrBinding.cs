namespace UnityFusion.Runtime.Generated
{
    public class UnityEngineClrBinding
    {
        internal static UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2>
            s_UnityEngine_Vector2_Binding_Binder = null;

        internal static UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3>
            s_UnityEngine_Vector3_Binding_Binder = null;


        internal static UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion>
            s_UnityEngine_Quaternion_Binding_Binder = null;

        public static void Binding(Enviorment.AppDomain _app)
        {
            UnityFusion.CLR.TypeSystem.CLRType __clrType = null;
            __clrType = (UnityFusion.CLR.TypeSystem.CLRType) _app.GetType(typeof(UnityEngine.Vector3));
            s_UnityEngine_Vector3_Binding_Binder =
                __clrType.ValueTypeBinder as UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3>;
            __clrType = (UnityFusion.CLR.TypeSystem.CLRType) _app.GetType(typeof(UnityEngine.Vector2));
            s_UnityEngine_Vector2_Binding_Binder =
                __clrType.ValueTypeBinder as UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2>;
            __clrType = (UnityFusion.CLR.TypeSystem.CLRType) _app.GetType(typeof(UnityEngine.Quaternion));
            s_UnityEngine_Quaternion_Binding_Binder =
                __clrType.ValueTypeBinder as UnityFusion.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion>;


            UnityEngine_Screen_Binding.Register(_app);
            UnityEngine_Behaviour_Binding.Register(_app);
            UnityEngine_GameObject_Binding.Register(_app);
            UnityEngine_RectTransform_Binding.Register(_app);
            UnityEngine_Time_Binding.Register(_app);
            UnityEngine_Mathf_Binding.Register(_app);
            UnityEngine_Random_Binding.Register(_app);
            UnityEngine_Quaternion_Binding.Register(_app);
            UnityEngine_TrailRenderer_Binding.Register(_app);
            UnityEngine_Object_Binding.Register(_app);
            UnityEngine_Gizmos_Binding.Register(_app);

            //EventSystems
            UnityEngine_EventSystems_EventTrigger_Binding.Register(_app);
            UnityEngine_EventSystems_PointerEventData_Binding.Register(_app);
            UnityEngine_EventSystems_EventTrigger_Binding_Entry_Binding.Register(_app);
            UnityEngine_EventSystems_IDragHandler_Binding.Register(_app);
            UnityEngine_EventSystems_IBeginDragHandler_Binding.Register(_app);
            UnityEngine_EventSystems_UIBehaviour_Binding.Register(_app);
            UnityEngine_EventSystems_IEndDragHandler_Binding.Register(_app);
            UnityEngine_EventSystems_IPointerClickHandler_Binding.Register(_app);
            UnityEngine_EventSystems_IPointerDownHandler_Binding.Register(_app);
            UnityEngine_EventSystems_IPointerUpHandler_Binding.Register(_app);

            UnityEngine_Events_UnityEvent_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_1_Boolean_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_1_BaseEventData_Binding.Register(_app);
            UnityEngine_Events_UnityEventBase_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_3_String_Int32_Int32_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_3_String_Byte_Byte_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_3_String_Boolean_Boolean_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_1_String_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_1_Single_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_1_SelectExitEventArgs_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_1_SelectEnterEventArgs_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_1_Int32_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_1_Double_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_1_Byte_Binding.Register(_app);
            UnityEngine_Events_UnityEvent_1_Vector2_Binding.Register(_app);

            UnityEngine_AnimatorStateInfo_Binding.Register(_app);
            UnityEngine_Component_Binding.Register(_app);

            //AI
            Unity_AI_Navigation_NavMeshLink_Binding.Register(_app);
            Unity_AI_Navigation_NavMeshModifier_Binding.Register(_app);
            Unity_AI_Navigation_NavMeshModifierVolume_Binding.Register(_app);
            Unity_AI_Navigation_CollectObjects_Binding.Register(_app);
            Unity_AI_Navigation_NavMeshSurface_Binding.Register(_app);
            UnityEngine_Experimental_AI_PolygonId_Binding.Register(_app);
            UnityEngine_Experimental_AI_NavMeshLocation_Binding.Register(_app);
            UnityEngine_Experimental_AI_PathQueryStatus_Binding.Register(_app);
            UnityEngine_Experimental_AI_NavMeshPolyTypes_Binding.Register(_app);
            UnityEngine_Experimental_AI_NavMeshWorld_Binding.Register(_app);
            UnityEngine_Experimental_AI_NavMeshQuery_Binding.Register(_app);
            UnityEngine_AI_NavMeshBuilder_Binding.Register(_app);
            UnityEngine_AI_ObstacleAvoidanceType_Binding.Register(_app);
            UnityEngine_AI_NavMeshAgent_Binding.Register(_app);
            UnityEngine_AI_NavMeshObstacleShape_Binding.Register(_app);
            UnityEngine_AI_NavMeshObstacle_Binding.Register(_app);
            UnityEngine_AI_OffMeshLinkType_Binding.Register(_app);
            UnityEngine_AI_OffMeshLinkData_Binding.Register(_app);
            UnityEngine_AI_OffMeshLink_Binding.Register(_app);
            UnityEngine_AI_NavMeshHit_Binding.Register(_app);
            UnityEngine_AI_NavMeshTriangulation_Binding.Register(_app);
            UnityEngine_AI_NavMeshData_Binding.Register(_app);
            UnityEngine_AI_NavMeshDataInstance_Binding.Register(_app);
            UnityEngine_AI_NavMeshLinkData_Binding.Register(_app);
            UnityEngine_AI_NavMeshLinkInstance_Binding.Register(_app);
            UnityEngine_AI_NavMeshQueryFilter_Binding.Register(_app);
            UnityEngine_AI_NavMesh_Binding.Register(_app);
            UnityEngine_AI_NavMeshPathStatus_Binding.Register(_app);
            UnityEngine_AI_NavMeshPath_Binding.Register(_app);
            UnityEngine_AI_NavMeshBuildDebugFlags_Binding.Register(_app);
            UnityEngine_AI_NavMeshBuildSourceShape_Binding.Register(_app);
            UnityEngine_AI_NavMeshCollectGeometry_Binding.Register(_app);
            UnityEngine_AI_NavMeshBuildSource_Binding.Register(_app);
            UnityEngine_AI_NavMeshBuildMarkup_Binding.Register(_app);
            UnityEngine_AI_NavMeshBuildSettings_Binding.Register(_app);


            // Audio Module
            UnityEngine_AudioClip_Binding.Register(_app);
            UnityEngine_AudioSource_Binding.Register(_app);
            UnityEngine_Audio_AudioMixer_Binding.Register(_app);

            UnityEngine_Animator_Binding.Register(_app);
            UnityEngine_Animation_Binding.Register(_app);
            UnityEngine_MeshRenderer_Binding.Register(_app);
            UnityEngine_Material_Binding.Register(_app);
            UnityEngine_Debug_Binding.Register(_app);
            UnityEngine_Camera_Binding.Register(_app);
            UnityEngine_Input_Binding.Register(_app);
            UnityEngine_Touch_Binding.Register(_app);
            UnityEngine_Transform_Binding.Register(_app);
            UnityEngine_Rigidbody_Binding.Register(_app);
            UnityEngine_WaitForSeconds_Binding.Register(_app);
            UnityEngine_MonoBehaviour_Binding.Register(_app);
            UnityEngine_Texture_Binding.Register(_app);
            UnityEngine_Rect_Binding.Register(_app);
            UnityEngine_Sprite_Binding.Register(_app);
            UnityEngine_WaitForEndOfFrame_Binding.Register(_app);
            UnityEngine_Vector3_Binding.Register(_app);
            UnityEngine_Vector2_Binding.Register(_app);
            UnityEngine_Texture2D_Binding.Register(_app);
            UnityEngine_U2D_SpriteAtlas_Binding.Register(_app);
            UnityEngine_LineRenderer_Binding.Register(_app);
            UnityEngine_AnimationClip_Binding.Register(_app);
            UnityEngine_AnimationCurve_Binding.Register(_app);
            UnityEngine_AnimationEvent_Binding.Register(_app);
            UnityEngine_Animations_ConstraintSource_Binding.Register(_app);
            UnityEngine_ParticleSystem_Binding.Register(_app);
            UnityEngine_ParticleSystem_Binding_MinMaxGradient_Binding.Register(_app);
            UnityEngine_ParticleSystemRenderer_Binding.Register(_app);
            UnityEngine_ParticleSystem_Binding_MainModule_Binding.Register(_app);
            UnityEngine_ParticleSystemRenderMode_Binding.Register(_app);
            UnityEngine_ParticleSystemSortMode_Binding.Register(_app);
            UnityEngine_ParticleSystemCurveMode_Binding.Register(_app);
            UnityEngine_ParticleSystemGradientMode_Binding.Register(_app);
            UnityEngine_ParticleSystemAnimationMode_Binding.Register(_app);
            UnityEngine_ParticleSystemAnimationTimeMode_Binding.Register(_app);
            UnityEngine_ParticleSystemAnimationRowMode_Binding.Register(_app);
            UnityEngine_ParticleSystemCollisionMode_Binding.Register(_app);
            UnityEngine_ParticleSystemColliderQueryMode_Binding.Register(_app);
            UnityEngine_ParticleSystemScalingMode_Binding.Register(_app);
            UnityEngine_ParticleSystemCullingMode_Binding.Register(_app);
            UnityEngine_ParticleSystemEmitterVelocityMode_Binding.Register(_app);
            UnityEngine_ParticleSystemInheritVelocityMode_Binding.Register(_app);
            UnityEngine_ParticleSystemCustomDataMode_Binding.Register(_app);
            UnityEngine_ParticleSystemTrailMode_Binding.Register(_app);
            UnityEngine_ParticleSystemTrailTextureMode_Binding.Register(_app);
            UnityEngine_ParticleSystemShapeMultiModeValue_Binding.Register(_app);
            UnityEngine_ParticleSystemRingBufferMode_Binding.Register(_app);
            UnityEngine_ParticleSystem_Binding_RotationOverLifetimeModule_Binding.Register(_app);
            UnityEngine_ParticleSystem_Binding_MinMaxCurve_Binding.Register(_app);

            UnityEngine_Resolution_Binding.Register(_app);

            UnityEngine_AnimationState_Binding.Register(_app);
            UnityEngine_Assertions_Assert_Binding.Register(_app);
            UnityEngine_TextAsset_Binding.Register(_app);
            UnityEngine_SkinnedMeshRenderer_Binding.Register(_app);
            UnityEngine_Application_Binding.Register(_app);
            UnityEngine_LocationService_Binding.Register(_app);
            UnityEngine_LocationInfo_Binding.Register(_app);
            UnityEngine_Gyroscope_Binding.Register(_app);
#if UNITY_IOS || UNITY_ANDROID || UNITY_VISIONOS
            UnityEngine_Handheld_Binding.Register(_app);
#endif
            UnityEngine_LayerMask_Binding.Register(_app);
            UnityEngine_AssetBundle_Binding.Register(_app);


            //Networking
            UnityEngine_Networking_DownloadHandlerBuffer_Binding.Register(_app);
            UnityEngine_Networking_DownloadHandlerScript_Binding.Register(_app);
            UnityEngine_Networking_DownloadHandlerAudioClip_Binding.Register(_app);
            UnityEngine_Networking_DownloadHandlerAssetBundle_Binding.Register(_app);
            UnityEngine_Networking_UploadHandlerFile_Binding.Register(_app);
            UnityEngine_Networking_UploadHandler_Binding.Register(_app);
            UnityEngine_Networking_UploadHandlerRaw_Binding.Register(_app);
            UnityEngine_Networking_MultipartFormFileSection_Binding.Register(_app);
            UnityEngine_Networking_MultipartFormDataSection_Binding.Register(_app);
            UnityEngine_Networking_UnityWebRequestMultimedia_Binding.Register(_app);
            UnityEngine_Networking_UnityWebRequestTexture_Binding.Register(_app);
            UnityEngine_Networking_DownloadHandlerTexture_Binding.Register(_app);
            UnityEngine_Networking_DownloadHandler_Binding.Register(_app);
            UnityEngine_Networking_UnityWebRequest_Binding.Register(_app);
            UnityEngine_Networking_UnityWebRequestAssetBundle_Binding.Register(_app);
            UnityEngine_WWWForm_Binding.Register(_app);


            //URP
            UniversalAdditionalCameraData_Binding.Register(_app);
            UniversalAdditionalLightData_Binding.Register(_app);
            Universal_CameraExtensions_Binding.Register(_app);
            //UI
            UnityEngine_Canvas_Binding.Register(_app);
            UnityEngine_UI_GraphicRaycaster_Binding.Register(_app);
            UnityEngine_UI_ScrollRect_Binding.Register(_app);
            UnityEngine_CanvasGroup_Binding.Register(_app);
            UnityEngine_UI_Selectable_Binding.Register(_app);
            UnityEngine_UI_Button_Binding.Register(_app);
            UnityEngine_UI_Graphic_Binding.Register(_app);
            UnityEngine_UI_MaskableGraphic_Binding.Register(_app);
            UnityEngine_UI_Image_Binding.Register(_app);
            UnityEngine_UI_RawImage_Binding.Register(_app);
            UnityEngine_UI_Slider_Binding.Register(_app);
            UnityEngine_UI_Text_Binding.Register(_app);
            UnityEngine_UI_Toggle_Binding.Register(_app);
            UnityEngine_UI_ToggleGroup_Binding.Register(_app);
            UnityEngine_UI_Scrollbar_Binding.Register(_app);
            UnityEngine_UI_GridLayoutGroup_Binding.Register(_app);
            UnityEngine_UI_HorizontalLayoutGroup_Binding.Register(_app);
            UnityEngine_UI_InputField_Binding.Register(_app);
            UnityEngine_UI_VerticalLayoutGroup_Binding.Register(_app);
            UnityEngine_UI_LayoutElement_Binding.Register(_app);
            TMPro_TextMeshProUGUI_Binding.Register(_app);
            TMPro_TMP_InputField_Binding.Register(_app);
            TMPro_TMP_Dropdown_Binding.Register(_app);
            TMPro_TMP_Text_Binding.Register(_app);
            UnityEngine_UI_HorizontalOrVerticalLayoutGroup_Binding.Register(_app);

            //Others
            UnityEngine_ColorUtility_Binding.Register(_app);
            UnityEngine_Mesh_Binding.Register(_app);
            UnityEngine_MeshFilter_Binding.Register(_app);
            VideoPlayer_Binding.Register(_app);
            VideoClip_Binding.Register(_app);
            UnityEngine_Color_Binding.Register(_app);
            UnityEngine_Bounds_Binding.Register(_app);


            UnityEngine_ComputeShader_Binding.Register(_app);
            UnityEngine_InputSystem_InputAction_Binding.Register(_app);
            UnityEngine_InputSystem_InputAction_Binding_CallbackContext_Binding.Register(_app);
            UnityEngine_InputSystem_InputActionAsset_Binding.Register(_app);
            UnityEngine_InputSystem_InputActionMap_Binding.Register(_app);
            UnityEngine_InputSystem_InputActionPhase_Binding.Register(_app);
            UnityEngine_InputSystem_InputActionReference_Binding.Register(_app);
            UnityEngine_InputSystem_InputControlPath_Binding.Register(_app);
            UnityEngine_InputSystem_EnhancedTouch_EnhancedTouchSupport_Binding.Register(_app);
            UnityEngine_InputSystem_EnhancedTouch_Finger_Binding.Register(_app);
            UnityEngine_InputSystem_EnhancedTouch_Touch_Binding.Register(_app);
            UnityEngine_InputSystem_EnhancedTouch_TouchHistory_Binding.Register(_app);
            UnityEngine_InputSystem_EnhancedTouch_TouchSimulation_Binding.Register(_app);

            //ARFoundation
#if USE_ARFOUNDATION
            UnityEngine_XR_ARFoundation_ARAnchorManager_Binding.Register(_app);
            UnityEngine_XR_ARFoundation_ARCameraManager_Binding.Register(_app);
            UnityEngine_XR_ARFoundation_ARFaceManager_Binding.Register(_app);
            UnityEngine_XR_ARFoundation_ARInputManager_Binding.Register(_app);
            UnityEngine_XR_ARFoundation_ARMeshManager_Binding.Register(_app);
            UnityEngine_XR_ARFoundation_AROcclusionManager_Binding.Register(_app);
            UnityEngine_XR_ARFoundation_ARPlaneManager_Binding.Register(_app);
            UnityEngine_XR_ARFoundation_ARRaycastManager_Binding.Register(_app);
            UnityEngine_XR_ARFoundation_AREnvironmentProbeManager_Binding.Register(_app);
            UnityEngine_XR_ARFoundation_ARFaceMeshVisualizer_Binding.Register(_app);
            UnityEngine_XR_ARFoundation_ARHumanBodyManager_Binding.Register(_app);
            UnityEngine_XR_ARFoundation_ARPointCloudManager_Binding.Register(_app);
            UnityEngine_XR_ARFoundation_ARTrackedImageManager_Binding.Register(_app);
            UnityEngine_XR_ARFoundation_ARTrackedObjectManager_Binding.Register(_app);
#endif

            //////////////////////////////////////////////////////////////////////
            //////////////////////////// Core ////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            UnityEngine_Renderer_Binding.Register(_app);
            UnityEngine_Projector_Binding.Register(_app);
            UnityEngine_Shader_Binding.Register(_app);
            UnityEngine_ShaderVariantCollection_Binding.Register(_app);
            UnityEngine_TrailRenderer_Binding.Register(_app);
            UnityEngine_LineRenderer_Binding.Register(_app);
            UnityEngine_MaterialPropertyBlock_Binding.Register(_app);
            UnityEngine_RenderSettings_Binding.Register(_app);
            UnityEngine_Material_Binding.Register(_app);
            UnityEngine_Light_Binding.Register(_app);
            UnityEngine_Skybox_Binding.Register(_app);
            UnityEngine_MeshFilter_Binding.Register(_app);
            UnityEngine_MeshRenderer_Binding.Register(_app);
            UnityEngine_LineUtility_Binding.Register(_app);
            UnityEngine_LODGroup_Binding.Register(_app);
            UnityEngine_Gradient_Binding.Register(_app);
            UnityEngine_PlayerPrefsException_Binding.Register(_app);
            UnityEngine_PlayerPrefs_Binding.Register(_app);
            UnityEngine_AsyncOperation_Binding.Register(_app);
            UnityEngine_MonoBehaviour_Binding.Register(_app);
            UnityEngine_ScriptableObject_Binding.Register(_app);
            UnityEngine_MissingComponentException_Binding.Register(_app);
            UnityEngine_UnassignedReferenceException_Binding.Register(_app);
            UnityEngine_MissingReferenceException_Binding.Register(_app);
            UnityEngine_TextAsset_Binding.Register(_app);
            UnityEngine_Object_Binding.Register(_app);
            UnityEngine_WaitForEndOfFrame_Binding.Register(_app);
            UnityEngine_WaitForFixedUpdate_Binding.Register(_app);
            UnityEngine_WaitForSeconds_Binding.Register(_app);
            UnityEngine_WaitForSecondsRealtime_Binding.Register(_app);
            UnityEngine_WaitUntil_Binding.Register(_app);
            UnityEngine_WaitWhile_Binding.Register(_app);
            UnityEngine_YieldInstruction_Binding.Register(_app);
            UnityEngine_SystemInfo_Binding.Register(_app);
            UnityEngine_Time_Binding.Register(_app);
            UnityEngine_TouchScreenKeyboard_Binding.Register(_app);
            UnityEngine_RectTransform_Binding.Register(_app);
            UnityEngine_Transform_Binding.Register(_app);
            UnityEngine_SpriteRenderer_Binding.Register(_app);
            UnityEngine_Sprite_Binding.Register(_app);
            UnityEngine_Sprites_DataUtility_Binding.Register(_app);
            UnityEngine_U2D_Light2DBase_Binding.Register(_app);
            UnityEngine_U2D_PixelPerfectRendering_Binding.Register(_app);
            UnityEngine_U2D_SpriteDataAccessExtensions_Binding.Register(_app);
            UnityEngine_U2D_SpriteRendererDataAccessExtensions_Binding.Register(_app);
            UnityEngine_U2D_SpriteAtlasManager_Binding.Register(_app);
            UnityEngine_U2D_SpriteAtlas_Binding.Register(_app);
            UnityEngine_Rendering_GraphicsSettings_Binding.Register(_app);
            UnityEngine_Rendering_SortingGroup_Binding.Register(_app);
            UnityEngine_Device_Screen_Binding.Register(_app);

            //////////////////////////////////////////////////////////////////////
            //////////////////////////// Physics ////////////////////////////////
            //////////////////////////////////////////////////////////////////////

            // 3D
            UnityEngine_Joint_Binding.Register(_app);
            UnityEngine_SpringJoint_Binding.Register(_app);
            UnityEngine_FixedJoint_Binding.Register(_app);
            UnityEngine_HingeJoint_Binding.Register(_app);
            UnityEngine_RigidbodyConstraints_Binding.Register(_app);
            UnityEngine_ForceMode_Binding.Register(_app);
            UnityEngine_JointProjectionMode_Binding.Register(_app);
            UnityEngine_MeshColliderCookingOptions_Binding.Register(_app);
            UnityEngine_WheelFrictionCurve_Binding.Register(_app);
            UnityEngine_SoftJointLimit_Binding.Register(_app);
            UnityEngine_SoftJointLimitSpring_Binding.Register(_app);
            UnityEngine_JointDrive_Binding.Register(_app);
            UnityEngine_RigidbodyInterpolation_Binding.Register(_app);
            UnityEngine_JointMotor_Binding.Register(_app);
            UnityEngine_JointSpring_Binding.Register(_app);
            UnityEngine_JointLimits_Binding.Register(_app);
            UnityEngine_ControllerColliderHit_Binding.Register(_app);
            UnityEngine_PhysicMaterialCombine_Binding.Register(_app);
            UnityEngine_Collision_Binding.Register(_app);
            UnityEngine_CollisionFlags_Binding.Register(_app);
            UnityEngine_QueryTriggerInteraction_Binding.Register(_app);
            UnityEngine_CollisionDetectionMode_Binding.Register(_app);
            UnityEngine_ConfigurableJointMotion_Binding.Register(_app);
            UnityEngine_RotationDriveMode_Binding.Register(_app);
            UnityEngine_ArticulationJointType_Binding.Register(_app);
            UnityEngine_ArticulationDofLock_Binding.Register(_app);
            UnityEngine_ArticulationDriveType_Binding.Register(_app);
            UnityEngine_ArticulationDrive_Binding.Register(_app);
            UnityEngine_ArticulationReducedSpace_Binding.Register(_app);
            UnityEngine_ArticulationJacobian_Binding.Register(_app);
            UnityEngine_ArticulationDriveAxis_Binding.Register(_app);
            UnityEngine_ArticulationBody_Binding.Register(_app);
            UnityEngine_Physics_Binding.Register(_app);
            UnityEngine_ModifiableContactPair_Binding.Register(_app);
            UnityEngine_ModifiableMassProperties_Binding.Register(_app);
            UnityEngine_PhysicMaterial_Binding.Register(_app);
            UnityEngine_RaycastHit_Binding.Register(_app);
            UnityEngine_Ray_Binding.Register(_app);
            UnityEngine_Rigidbody_Binding.Register(_app);
            UnityEngine_Collider_Binding.Register(_app);
            UnityEngine_CharacterController_Binding.Register(_app);
            UnityEngine_MeshCollider_Binding.Register(_app);
            UnityEngine_CapsuleCollider_Binding.Register(_app);
            UnityEngine_BoxCollider_Binding.Register(_app);
            UnityEngine_SphereCollider_Binding.Register(_app);
            UnityEngine_ConstantForce_Binding.Register(_app);
            UnityEngine_CharacterJoint_Binding.Register(_app);
            UnityEngine_ConfigurableJoint_Binding.Register(_app);
            UnityEngine_ContactPoint_Binding.Register(_app);
            UnityEngine_PhysicsScene_Binding.Register(_app);
            UnityEngine_PhysicsSceneExtensions_Binding.Register(_app);
            UnityEngine_SimulationMode_Binding.Register(_app);
            UnityEngine_ContactPairHeader_Binding.Register(_app);
            UnityEngine_ContactPair_Binding.Register(_app);
            UnityEngine_ContactPairPoint_Binding.Register(_app);
            UnityEngine_QueryParameters_Binding.Register(_app);
            UnityEngine_ColliderHit_Binding.Register(_app);
            UnityEngine_RaycastCommand_Binding.Register(_app);
            UnityEngine_SpherecastCommand_Binding.Register(_app);
            UnityEngine_CapsulecastCommand_Binding.Register(_app);
            UnityEngine_BoxcastCommand_Binding.Register(_app);
            UnityEngine_ClosestPointCommand_Binding.Register(_app);
            UnityEngine_OverlapSphereCommand_Binding.Register(_app);
            UnityEngine_OverlapBoxCommand_Binding.Register(_app);
            UnityEngine_OverlapCapsuleCommand_Binding.Register(_app);
            UnityEngine_Plane_Binding.Register(_app);

            // 2D
            UnityEngine_SimulationMode2D_Binding.Register(_app);
            UnityEngine_CapsuleDirection2D_Binding.Register(_app);
            UnityEngine_RigidbodyConstraints2D_Binding.Register(_app);
            UnityEngine_RigidbodyInterpolation2D_Binding.Register(_app);
            UnityEngine_RigidbodySleepMode2D_Binding.Register(_app);
            UnityEngine_CollisionDetectionMode2D_Binding.Register(_app);
            UnityEngine_RigidbodyType2D_Binding.Register(_app);
            UnityEngine_ForceMode2D_Binding.Register(_app);
            UnityEngine_ColliderErrorState2D_Binding.Register(_app);
            UnityEngine_JointLimitState2D_Binding.Register(_app);
            UnityEngine_JointBreakAction2D_Binding.Register(_app);
            UnityEngine_EffectorSelection2D_Binding.Register(_app);
            UnityEngine_EffectorForceMode2D_Binding.Register(_app);
            UnityEngine_PhysicsShapeType2D_Binding.Register(_app);
            UnityEngine_PhysicsShape2D_Binding.Register(_app);
            UnityEngine_PhysicsShapeGroup2D_Binding.Register(_app);
            UnityEngine_ColliderDistance2D_Binding.Register(_app);
            UnityEngine_ContactFilter2D_Binding.Register(_app);
            UnityEngine_Collision2D_Binding.Register(_app);
            UnityEngine_ContactPoint2D_Binding.Register(_app);
            UnityEngine_JointAngleLimits2D_Binding.Register(_app);
            UnityEngine_JointTranslationLimits2D_Binding.Register(_app);
            UnityEngine_JointMotor2D_Binding.Register(_app);
            UnityEngine_JointSuspension2D_Binding.Register(_app);
            UnityEngine_RaycastHit2D_Binding.Register(_app);
            UnityEngine_PhysicsJobOptions2D_Binding.Register(_app);
            UnityEngine_Collider2D_Binding.Register(_app);
            UnityEngine_CustomCollider2D_Binding.Register(_app);
            UnityEngine_CircleCollider2D_Binding.Register(_app);
            UnityEngine_CapsuleCollider2D_Binding.Register(_app);
            UnityEngine_EdgeCollider2D_Binding.Register(_app);
            UnityEngine_BoxCollider2D_Binding.Register(_app);
            UnityEngine_PolygonCollider2D_Binding.Register(_app);
            UnityEngine_CompositeCollider2D_Binding.Register(_app);
            UnityEngine_Joint2D_Binding.Register(_app);
            UnityEngine_AnchoredJoint2D_Binding.Register(_app);
            UnityEngine_SpringJoint2D_Binding.Register(_app);
            UnityEngine_DistanceJoint2D_Binding.Register(_app);
            UnityEngine_FrictionJoint2D_Binding.Register(_app);
            UnityEngine_HingeJoint2D_Binding.Register(_app);
            UnityEngine_RelativeJoint2D_Binding.Register(_app);
            UnityEngine_SliderJoint2D_Binding.Register(_app);
            UnityEngine_TargetJoint2D_Binding.Register(_app);
            UnityEngine_FixedJoint2D_Binding.Register(_app);
            UnityEngine_WheelJoint2D_Binding.Register(_app);
            UnityEngine_Effector2D_Binding.Register(_app);
            UnityEngine_AreaEffector2D_Binding.Register(_app);
            UnityEngine_BuoyancyEffector2D_Binding.Register(_app);
            UnityEngine_PointEffector2D_Binding.Register(_app);
            UnityEngine_PlatformEffector2D_Binding.Register(_app);
            UnityEngine_SurfaceEffector2D_Binding.Register(_app);
            UnityEngine_ConstantForce2D_Binding.Register(_app);
            UnityEngine_PhysicsMaterial2D_Binding.Register(_app);

            // 2D Effector
            UnityEngine_Effector2D_Binding.Register(_app);
            UnityEngine_PlatformEffector2D_Binding.Register(_app);
            UnityEngine_PointEffector2D_Binding.Register(_app);
            UnityEngine_SurfaceEffector2D_Binding.Register(_app);
            UnityEngine_BuoyancyEffector2D_Binding.Register(_app);
            UnityEngine_AreaEffector2D_Binding.Register(_app);

            // 2D
            UnityEngine_CustomGridBrushAttribute_Binding.Register(_app);
            UnityEngine_GridBrushBase_Binding.Register(_app);
            UnityEngine_Tilemaps_ITilemap_Binding.Register(_app);
            UnityEngine_Tilemaps_Tile_Binding.Register(_app);
            UnityEngine_Tilemaps_TileBase_Binding.Register(_app);
            UnityEngine_Tilemaps_Tilemap_Binding.Register(_app);
            UnityEngine_Tilemaps_TilemapRenderer_Binding.Register(_app);
            UnityEngine_Tilemaps_TilemapCollider2D_Binding.Register(_app);

            UnityEngine_Grid_Binding.Register(_app);
            UnityEngine_GridLayout_Binding.Register(_app);
            UnityEngine_GUIUtility_Binding.Register(_app);

            UnityEngine_ImageConversion_Binding.Register(_app);

            // List
            System_Collections_Generic_List_1_LineRenderer_Binding.Register(_app);

#if UNITY_6000_0_OR_NEWER
            UnityEngine_AsyncInstantiateOperation_1_GameObject_Binding_Awaiter_Binding.Register(_app);
            UnityEngine_AsyncInstantiateOperation_1_GameObject_Binding.Register(_app);
#if UNITY_6000_0_34
            UnityEngine_InstantiateParameters_Binding.Register(_app);
#endif
#endif
        }
    }
}