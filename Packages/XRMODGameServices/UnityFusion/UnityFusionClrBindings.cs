// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.GameServices.UnityFusion.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Reflection;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif
namespace UnityFusion.Runtime.Generated
{
    class UnityFusionClrBindings
    {
//will auto register in unity
#if UNITY_5_3_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#endif
        private static void RegisterBindingAction()
        {
            UnityFusion.Runtime.CLRBinding.CLRBindingUtils.RegisterBindingAction(Initialize);
        }

        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            app.DelegateManager
                .RegisterFunctionDelegate<Phantom.XRMOD.GameServices.Runtime.VoiceParticipant, System.Boolean>();

            app.DelegateManager
                .RegisterDelegateConvertor<System.Predicate<Phantom.XRMOD.GameServices.Runtime.VoiceParticipant>>(
                    (act) =>
                    {
                        return new System.Predicate<Phantom.XRMOD.GameServices.Runtime.VoiceParticipant>((obj) =>
                        {
                            return
                                ((Func<Phantom.XRMOD.GameServices.Runtime.VoiceParticipant, System.Boolean>) act)(
                                    obj);
                        });
                    });

            // Authentication
            AuthenticationSystem_Runtime_SignInWithMetaProvider_Binding.Register(app);
            AuthenticationSystem_Runtime_SingInWithGooglePlayProvider_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_AuthenticationSystemManager_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_ConstArgs_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_UserInfoModel_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_PlatformProviderType_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_PlatformProviderFactory_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_IPlatformSignInProvider_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_SignInWithAppleProvider_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_RegisterXRMODAccountCommand_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_XRMODAccountInfoCommand_Binding.Register(app);

            // Leaderboard
            Phantom_XRMOD_GameServices_Runtime_BaseLeaderboardArgs_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_AddOrUpdateScoreArgs_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_GetScoreListArgs_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_GetPlayerScoreArgs_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_ILeaderboardProvider_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_LeaderboardScore_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_LeaderboardScores_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_LeaderboardSystemManager_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_UnityLeaderboardProvider_Binding.Register(app);
            Unity_Services_Leaderboards_PaginationOptions_Binding.Register(app);
            Unity_Services_Leaderboards_GetScoresOptions_Binding.Register(app);
            Unity_Services_Leaderboards_ILeaderboardsService_Binding.Register(app);
            Unity_Services_Leaderboards_LeaderboardsService_Binding.Register(app);
            Unity_Services_Leaderboards_Models_LeaderboardEntry_Binding.Register(app);
            Unity_Services_Leaderboards_Models_LeaderboardScoresPage_Binding.Register(app);
            System_Collections_Generic_List_1_LeaderboardScore_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_List_1_LeaderboardScore_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_LeaderboardScore_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_LeaderboardScores_Binding.Register(app);
            System_Threading_Tasks_Task_1_LeaderboardScore_Binding.Register(app);
            System_Threading_Tasks_Task_1_LeaderboardScores_Binding.Register(app);

            // Voice
            Phantom_XRMOD_GameServices_Runtime_WebResponseDataBody_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_WebResponse_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_PermissionHelper_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_ConfigurationArgs_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_TextMessage_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_VoiceNotificationKey_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_VoiceModuleNotifyActionKey_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_VoiceNotificationDataArgs_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_VoiceParticipant_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_IVoiceProvider_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_VoiceManager_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_VivoxProvider_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_Voice3DProperties_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_VoiceAudioFadeModel_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_JoinChannelType_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_VoiceSystemManager_Binding.Register(app);
            System_Collections_Generic_List_1_VoiceParticipant_Binding.Register(app);
            System_Collections_Generic_List_1_VoiceParticipant_Binding_Enumerator_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_ITextMessage_Binding.Register(app);

            // Cloud Save
            System_Byte_Binding.Register(app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Boolean_Binding.Register(app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_Item_Binding.Register(app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_Item_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_Item_Binding.Register(app);
            System_Threading_Tasks_Task_1_Boolean_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Boolean_Binding.Register(app);
            System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Binding.Register(app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_List_1_EntityData_Binding.Register(app);
            Unity_Services_CloudSave_CloudSaveService_Binding.Register(app);
            Unity_Services_CloudSave_ICloudSaveService_Binding.Register(app);
            Unity_Services_CloudSave_Internal_IDataService_Binding.Register(app);
            Unity_Services_CloudSave_Models_Data_Player_DeleteOptions_Binding.Register(app);
            Unity_Services_CloudSave_Internal_IPlayerDataService_Binding.Register(app);
            System_Threading_Tasks_Task_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_Binding.Register(app);
            Unity_Services_CloudSave_Models_Data_Player_QueryOptions_Binding.Register(app);
            System_Threading_Tasks_Task_1_List_1_EntityData_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_List_1_EntityData_Binding.Register(app);
            System_Threading_Tasks_Task_1_Dictionary_2_String_String_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Dictionary_2_String_String_Binding.Register(app);
            Unity_Services_CloudSave_Internal_Http_IDeserializable_Binding.Register(app);
            Unity_Services_CloudSave_Internal_IFilesService_Binding.Register(app);
            Unity_Services_CloudSave_Internal_IPlayerFilesService_Binding.Register(app);
            Unity_Services_CloudSave_Models_Item_Binding.Register(app);
            Phantom_XRMOD_GameServices_Runtime_CloudSaveSystemManager_Binding.Register(app);

            Phantom_XRMOD_GameServices_Runtime_XRMODGameServicesManager_Binding.Register(app);
#if UNITY_IN_APP_PURCHASE
            //Phantom_XRMOD_InAppPurchase_Runtime_InAppPurchaseManager_Binding.Register(app);
            Phantom_XRMOD_InAppPurchase_Runtime_PurchaseCallback_Binding.Register(app);
            Phantom_XRMOD_InAppPurchase_Runtime_ProductData_Binding.Register(app);
#endif
            // Extensions
            System_Collections_Generic_List_1_VoiceParticipant_Binding.Register(app);
            System_Collections_Generic_List_1_VoiceParticipant_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_IEnumerable_1_Relationship_Binding.Register(app);
            System_Collections_Generic_IEnumerator_1_Relationship_Binding.Register(app);
            System_Collections_Generic_List_1_LeaderboardEntry_Binding.Register(app);
            System_Collections_Generic_List_1_LeaderboardEntry_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_List_1_Member_Binding.Register(app);
            System_Collections_Generic_List_1_Member_Binding_Enumerator_Binding.Register(app);

            // Cores
            Unity_Services_Core_InitializationOptions_Binding.Register(app);
            Unity_Services_Core_UnityServices_Binding.Register(app);
            //Unity_Services_Core_CheckRegion_Binding.Register(app);

            // Friends
            Unity_Services_Friends_Models_Profile_Binding.Register(app);
            Unity_Services_Friends_Exceptions_FriendsServiceException_Binding.Register(app);
            Unity_Services_Friends_FriendsService_Binding.Register(app);
            Unity_Services_Friends_IFriendsService_Binding.Register(app);
            Unity_Services_Friends_Models_Member_Binding.Register(app);
            Unity_Services_Friends_Models_Presence_Binding.Register(app);
            Unity_Services_Friends_Models_Profile_Binding.Register(app);
            Unity_Services_Friends_Models_Relationship_Binding.Register(app);
            Unity_Services_Friends_Notifications_IRelationshipAddedEvent_Binding.Register(app);
            Unity_Services_Friends_Notifications_IRelationshipDeletedEvent_Binding.Register(app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}