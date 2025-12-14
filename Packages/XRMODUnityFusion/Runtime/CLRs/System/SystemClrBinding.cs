namespace UnityFusion.Runtime.Generated
{
    public class SystemClrBinding
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

            System_IO_File_Binding.Register(_app);
            System_IO_Path_Binding.Register(_app);
            System_IO_FileInfo_Binding.Register(_app);
            System_IO_MemoryStream_Binding.Register(_app);
            System_IO_FileSystemInfo_Binding.Register(_app);

            System_TimeSpan_Binding.Register(_app);

            System_Action_Binding.Register(_app);
            System_Action_1_DownloadHandler_Binding.Register(_app);
            System_Func_2_Nullable_1_DateTime_Task_Binding.Register(_app);
            System_Action_1_Int32_Binding.Register(_app);
            System_Action_1_String_Binding.Register(_app);
            System_Action_1_ILTypeInstance_Binding.Register(_app);
            System_Action_1_Transform_Binding.Register(_app);
            System_Func_1_ILTypeInstance_Binding.Register(_app);
            Dictionary_2_Int32_Func_1_ILTypeInstance_Binding.Register(_app);
            Dictionary_2_Type_List_1_Delegate_Binding.Register(_app);
            List_1_Delegate_Binding_Enumerator_Binding.Register(_app);
            List_1_Delegate_Binding.Register(_app);
            System_Math_Binding.Register(_app);
            System_Type_Binding.Register(_app);
            System_Int32_Binding.Register(_app);
            System_Char_Binding.Register(_app);
            System_Single_Binding.Register(_app);
            System_Int64_Binding.Register(_app);
            System_Object_Binding.Register(_app);
            System_String_Binding.Register(_app);
            System_Array_Binding.Register(_app);
            System_Boolean_Binding.Register(_app);
            System_Enum_Binding.Register(_app);
            System_DateTime_Binding.Register(_app);
            System_Double_Binding.Register(_app);


            System_Threading_Interlocked_Binding.Register(_app);
            System_Threading_Tasks_Task_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Texture_Binding.Register(_app);
            System_Threading_Tasks_Task_1_GameObject_Binding.Register(_app);
            System_Threading_Tasks_Task_1_AudioClip_Binding.Register(_app);
            System_Threading_Tasks_Task_1_SpriteAtlas_Binding.Register(_app);
            System_Threading_Tasks_Task_1_TextAsset_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Texture2D_Binding.Register(_app);
            System_Threading_Tasks_Task_1_VideoClip_Binding.Register(_app);
            System_Threading_Tasks_Task_1_GameObject_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Material_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Material_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Mesh_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_ScriptableObject_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Sprite_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Texture2D_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_UniversalRenderPipelineAsset_Binding.Register(_app);
            System_Threading_Tasks_Task_1_ScriptableObject_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Boolean_Binding.Register(_app);
            System_Threading_Tasks_Task_1_HttpResponseMessage_Binding.Register(_app);
            System_Threading_Tasks_Task_1_AudioClip_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_ShaderVariantCollection_Binding.Register(_app);
            System_Threading_Tasks_Task_1_VideoClip_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_AnimationClip_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Animator_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_AudioMixer_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_AnimationClip_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_Animator_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_AudioClip_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_AudioMixer_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_Font_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_GameObject_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_Material_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_Mesh_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_PhysicsMaterial_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_PhysicsMaterial2D_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_ScriptableObject_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_Shader_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_Sprite_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_SpriteAtlas_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_TextAsset_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_Texture_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_Texture2D_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_VideoClip_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Font_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_PhysicsMaterial_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_PhysicsMaterial2D_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Shader_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_SpriteAtlas_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_TextAsset_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Texture_Array_Binding.Register(_app);
            System_Threading_Tasks_Task_1_VideoClip_Binding.Register(_app);
            System_Threading_Tasks_Task_1_AnimationClip_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Animator_Binding.Register(_app);
            System_Threading_Tasks_Task_1_AudioMixer_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Font_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Mesh_Binding.Register(_app);
            System_Threading_Tasks_Task_1_PhysicsMaterial_Binding.Register(_app);
            System_Threading_Tasks_Task_1_PhysicsMaterial2D_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Shader_Binding.Register(_app);
            System_Threading_Tasks_Task_1_Sprite_Binding.Register(_app);


            System_Threading_Monitor_Binding.Register(_app);
            System_Threading_CancellationTokenSource_Binding.Register(_app);

            System_Convert_Binding.Register(_app);
            System_IDisposable_Binding.Register(_app);
            System_Random_Binding.Register(_app);

            System_Security_Cryptography_HashAlgorithm_Binding.Register(_app);
            System_Security_Cryptography_HMACSHA256_Binding.Register(_app);
            System_Security_Cryptography_KeyedHashAlgorithm_Binding.Register(_app);
            System_Security_Cryptography_MD5_Binding.Register(_app);

            System_Text_ASCIIEncoding_Binding.Register(_app);
            System_Text_Encoding_Binding.Register(_app);
            System_Text_StringBuilder_Binding.Register(_app);
            System_Text_RegularExpressions_Regex_Binding.Register(_app);

            //  Collections generic
            System_Collections_Generic_CollectionExtensions_Binding.Register(_app);
            System_Collections_ObjectModel_Collection_1_ILTypeInstance_Binding.Register(_app);

            System_Collections_Generic_List_1_Action_1_Object_Binding.Register(_app);
            System_Collections_Generic_List_1_Delegate_Binding.Register(_app);
            System_Collections_Generic_List_1_Int32_Binding.Register(_app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding.Register(_app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_List_1_UnityEngine_EventSystems_EventTrigger_Binding_Entry_Binding
                .Register(_app);
            System_Collections_Generic_List_1_Texture2D_Binding.Register(_app);
            System_Collections_Generic_List_1_Adaptor_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_List_1_UnityFusion_CLRBinding_Adapter_ScriptableObjectAdapter_Binding_Adapter_Binding_Enumerator_Binding
                .Register(_app);
            System_Collections_Generic_List_1_UnityFusion_CLRBinding_Adapter_ScriptableObjectAdapter_Binding_Adapter_Binding
                .Register(_app);
            System_Collections_Generic_List_1_UnityFusion_CLRBinding_Adapter_XRMODBehaviourAdapter_Binding_Adapter_Binding
                .Register(_app);
            System_Collections_Generic_List_1_String_Binding.Register(_app);
            System_Collections_Generic_List_1_Text_Binding.Register(_app);
            System_Collections_Generic_List_1_Transform_Binding.Register(_app);
            System_Collections_Generic_List_1_Vector2_Binding.Register(_app);
            System_Collections_Generic_List_1_Vector3_Binding.Register(_app);
            System_Collections_Generic_List_1_Single_Binding.Register(_app);
            System_Collections_Generic_List_1_Transform_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_List_1XRMODBehaviourAdapter_Adapter_Enumerator_Binding.Register(_app);
            System_Collections_Generic_List_1_XRMODBehaviourAdapter_Adapter_Binding.Register(_app);
            System_Collections_Generic_List_1_InputActionAsset_Binding.Register(_app);
            System_Collections_Generic_List_1_Image_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_List_1_GameObject_Binding.Register(_app);
            System_Collections_Generic_List_1_GameObject_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_List_1_Adapter_CoroutineAdapter_Enumerator_Binding
                .Register(_app);
            System_Collections_Generic_List_1_Adapter_CoroutineAdaptor_Binding
                .Register(_app);
            System_Collections_Generic_List_1_Mesh_Binding.Register(_app);
            System_Collections_Generic_List_1_Material_Binding.Register(_app);
            System_Collections_Generic_List_1_AnimationClip_Binding.Register(_app);
            System_Collections_Generic_List_1_AudioMixer_Binding.Register(_app);
            System_Collections_Generic_List_1_Font_Binding.Register(_app);
            System_Collections_Generic_List_1_Physics_Binding.Register(_app);
            System_Collections_Generic_List_1_PhysicsMaterial_Binding.Register(_app);
            System_Collections_Generic_List_1_ScriptableObject_Binding.Register(_app);
            System_Collections_Generic_List_1_Shader_Binding.Register(_app);
            System_Collections_Generic_List_1_SpriteAtlas_Binding.Register(_app);
            System_Collections_Generic_List_1_TextAsset_Binding.Register(_app);
            System_Collections_Generic_List_1_Texture_Binding.Register(_app);
            System_Collections_Generic_List_1_VideoClip_Binding.Register(_app);


            System_Collections_Generic_KeyValuePair_2_String_GameObject_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_Int32_GameObject_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_Int32_Vector2_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_AudioSource_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_Int32_AudioSource_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_Int32_GameObject_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_Int32_GameObject_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_Int32_String_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_Int32_Transform_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_GameObject_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_String_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_XRMODBehaviour_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_Int32_Func_1_ILTypeInstance_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_AudioClip_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_List_1_Action_1_Object_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_Type_List_1_Delegate_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_AnimationClip_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_AnimationClip_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Animator_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Animator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_AudioClip_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_AudioMixer_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_AudioMixer_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Font_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Font_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Material_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Material_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Mesh_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Mesh_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_PhysicsMaterial_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_PhysicsMaterial_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_PhysicsMaterial2D_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_PhysicsMaterial2D_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_ScriptableObject_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_ScriptableObject_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Shader_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Shader_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Sprite_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Sprite_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_SpriteAtlas_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_SpriteAtlas_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_TextAsset_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_TextAsset_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Texture_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Texture_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Texture2D_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Texture2D_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_VideoClip_Binding_Enumerator_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_VideoClip_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_Physics_Binding.Register(_app);

            System_Collections_Generic_KeyValuePair_2_String_VideoClip_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_AnimationClip_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_Animator_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_AudioClip_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_AudioMixer_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_Font_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_Material_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_Mesh_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_PhysicsMaterial_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_PhysicsMaterial2D_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_ScriptableObject_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_Shader_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_Sprite_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_SpriteAtlas_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_TextAsset_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_Texture_Binding.Register(_app);
            System_Collections_Generic_KeyValuePair_2_String_Texture2D_Binding.Register(_app);

            System_Runtime_CompilerServices_TaskAwaiter_1_VideoClip_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_AnimationClip_Binding
                .Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_Animator_Binding
                .Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_AudioMixer_Binding
                .Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_Font_Binding.Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_Material_Binding
                .Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_Mesh_Binding.Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_PhysicsMaterial_Binding
                .Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_PhysicsMaterial2D_Binding
                .Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_ScriptableObject_Binding
                .Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_Shader_Binding.Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_Sprite_Binding.Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_SpriteAtlas_Binding
                .Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_TextAsset_Binding
                .Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_Texture_Binding.Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_Texture2D_Binding
                .Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_VideoClip_Binding
                .Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_AnimationClip_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Animator_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_AudioMixer_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_AnimationClip_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_Animator_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_AudioMixer_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_Font_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_GameObject_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_Material_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_Mesh_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_PhysicsMaterial_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_PhysicsMaterial2D_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_ScriptableObject_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_Shader_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_Sprite_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_SpriteAtlas_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_TextAsset_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_Texture_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_Texture2D_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_VideoClip_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Font_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_PhysicsMaterial_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_PhysicsMaterial2D_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Shader_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_SpriteAtlas_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_TextAsset_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Texture_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_AnimationClip_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Animator_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_AudioMixer_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Font_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Mesh_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_PhysicsMaterial_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_PhysicsMaterial2D_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Sprite_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Texture_Binding.Register(_app);


            System_Collections_Generic_Dictionary_2_String_UnityFusion_CLRBinding_Adapter_XRMODBehaviourAdapter_Binding_Adapter_Binding
                .Register(_app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding_ValueCollection_Binding
                .Register(_app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding_ValueCollection_Binding_Enumerator_Binding
                .Register(_app);
            System_Collections_Generic_Dictionary_2_String_GameObject_Binding_KeyCollection_Binding.Register(_app);
            System_Collections_Generic_Dictionary_2_String_GameObject_Binding_KeyCollection_Binding_Enumerator_Binding
                .Register(_app);
            System_Collections_Generic_Dictionary_2_String_GameObject_Binding_Enumerator_Binding.Register(_app);

            System_Collections_Generic_Queue_1_GameObject_Binding.Register(_app);
            System_Collections_Generic_Queue_1_Int32_Binding.Register(_app);
            System_Collections_Generic_Queue_1_Quaternion_Binding.Register(_app);
            System_Collections_Generic_Queue_1_Single_Binding.Register(_app);
            System_Collections_Generic_Queue_1_String_Binding.Register(_app);
            System_Collections_Generic_Queue_1_Transform_Binding.Register(_app);
            System_Collections_Generic_Queue_1_Vector2_Binding.Register(_app);
            System_Collections_Generic_Queue_1_Vector3_Binding.Register(_app);
            System_Collections_Generic_Queue_1_XRMODBehaviourAdapter_Binding.Register(_app);
            System_Collections_Generic_Queue_1_XRMODBehaviour_Binding.Register(_app);
            System_Collections_Generic_Queue_1_ILTypeInstance_Binding.Register(_app);
            System_Collections_Generic_Stack_1_GameObject_Binding.Register(_app);
            System_Collections_Generic_Stack_1_XRMODBehaviour_Binding.Register(_app);

            System_Collections_Generic_Stack_1_Int32_Binding.Register(_app);
            System_Collections_Generic_Stack_1_Quaternion_Binding.Register(_app);
            System_Collections_Generic_Stack_1_Single_Binding.Register(_app);
            System_Collections_Generic_Stack_1_String_Binding.Register(_app);
            System_Collections_Generic_Stack_1_Transform_Binding.Register(_app);
            System_Collections_Generic_Stack_1_Vector2_Binding.Register(_app);
            System_Collections_Generic_Stack_1_Vector3_Binding.Register(_app);
            System_Collections_Generic_Stack_1_XRMODBehaviourAdapter_Binding.Register(_app);
            System_Collections_Generic_Stack_1_XRMODBehaviourAdapter_Adapter_Binding.Register(_app);

            System_Collections_Generic_HashSet_1_Mesh_Binding.Register(_app);
            System_Collections_Generic_HashSet_1_String_Binding.Register(_app);

            System_Collections_IEnumerator_Binding.Register(_app);
            System_Collections_Generic_IEnumerable_1_ILTypeInstance_Binding.Register(_app);
            System_Collections_Generic_ICollection_1_ILTypeInstance_Binding.Register(_app);
            System_Collections_Generic_IEnumerator_1_ILTypeInstance_Binding.Register(_app);
            IEnumerable_1_KeyValuePair_2_Vector3_Int32_Binding.Register(_app);
            IEnumerable_1_IGrouping_2_Vector3_KeyValuePair_2_Vector3_Int32_Binding.Register(_app);
            IEnumerator_1_IGrouping_2_Vector3_KeyValuePair_2_Vector3_Int32_Binding.Register(_app);
            IEnumerator_1_KeyValuePair_2_Vector3_Int32_Binding.Register(_app);
            KeyValuePair_2_Vector3_Int32_Binding.Register(_app);


            // Exception
            System_NotImplementedException_Binding.Register(_app);
            System_Exception_Binding.Register(_app);
            System_ArgumentOutOfRangeException_Binding.Register(_app);
            System_NotSupportedException_Binding.Register(_app);

            // CompilerServices
            System_Runtime_CompilerServices_TaskAwaiter_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_SpriteAtlas_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_TextAsset_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Texture2D_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_VideoClip_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Shader_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_AudioClip_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_GameObject_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Material_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_ComputeShader_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_UniversalRenderPipelineAsset_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Texture2D_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Sprite_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_ScriptableObject_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Mesh_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Material_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_GameObject_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_ScriptableObject_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Boolean_Binding.Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_Binding.Register(_app);
            System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Binding.Register(_app);
            System_Runtime_CompilerServices_YieldAwaitable_Binding.Register(_app);
            System_Runtime_CompilerServices_YieldAwaitable_Binding_YieldAwaiter_Binding.Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_ScriptableObject_Binding.Register(_app);
#if UNITY_6000_0_OR_NEWER
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_GameObject_Binding.Register(_app);
#endif
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Boolean_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_HttpResponseMessage_Binding.Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_GameObject_Binding
                .Register(_app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_AudioClip_Binding
                .Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_AudioClip_Array_Binding.Register(_app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_AudioClip_Binding.Register(_app);

            System_Attribute_Binding.Register(_app);
            System_AttributeUsageAttribute_Binding.Register(_app);
            System_MathF_Binding.Register(_app);

            System_Linq_Enumerable_Binding.Register(_app);
            System_Nullable_1_Vector3_Binding.Register(_app);
            System_Nullable_1_Quaternion_Binding.Register(_app);
            System_Nullable_1_Single_Binding.Register(_app);

            System_Globalization_CultureInfo_Binding.Register(_app);
            System_Diagnostics_Stopwatch_Binding.Register(_app);

            // Net
            System_Net_Http_StreamContent_Binding.Register(_app);
            System_Net_Http_HttpClient_Binding.Register(_app);
            System_Net_Http_HttpMethod_Binding.Register(_app);
            System_Net_Http_HttpRequestMessage_Binding.Register(_app);
            System_Net_Http_MultipartFormDataContent_Binding.Register(_app);
            System_Net_Http_StringContent_Binding.Register(_app);
            System_Net_Http_HttpResponseMessage_Binding.Register(_app);
            System_Net_Http_HttpContent_Binding.Register(_app);
            System_Net_Http_Headers_HttpHeaders_Binding.Register(_app);
            System_Net_IPHostEntry_Binding.Register(_app);
            System_Net_Dns_Binding.Register(_app);
            System_Net_IPAddress_Binding.Register(_app);
        }
    }
}