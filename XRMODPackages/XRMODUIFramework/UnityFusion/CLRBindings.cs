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
    class CLRBindings
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
        public static void Initialize(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            Recorders_Runtime_RecordButton_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_AnimationUI_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_AnimationUICustomizable_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_Ease_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_Sequence_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_UIParticle_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_UIParticleSystem_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_CustomButton_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_Grabber_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_ListElement_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_MaterialSetup_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_ProgressBar_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_Resizer_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_ShadowPlacer_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_SpriteNumberSwitcher_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_TabbarAnimation_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_ToggleAnimation_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_UpdateChildTogglesOnAwake_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_WindowsStacker_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_ImageWithIndependentRoundedCorners_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_ImageWithRoundedCorners_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_AnimatableProperty_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_CanvasSafeArea_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_VisionControls_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_ScrollerDirection_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_Scroller_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_AnimationEffects_UIAnimator_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_AnimationEffects_UIAnimationSequence_Binding.Register(app);
            
#if USE_TIMELINE
            Phantom_XRMOD_UIFramework_Runtime_TimelinePlayController_Binding.Register(app);
            Phantom_XRMOD_UIFramework_Runtime_TimelineSegmentationConfig_Binding.Register(app);
            UnityEngine_Timeline_ActivationTrack_Binding.Register(app);
            UnityEngine_Timeline_AnimationPlayableAsset_Binding.Register(app);
            UnityEngine_Timeline_MatchTargetFields_Binding.Register(app);
            UnityEngine_Timeline_TrackOffset_Binding.Register(app);
            UnityEngine_Timeline_AnimationTrack_Binding.Register(app);
            UnityEngine_Timeline_TimelineClip_Binding.Register(app);
            UnityEngine_Timeline_TimelineAsset_Binding.Register(app);
            UnityEngine_Timeline_TrackAsset_Binding.Register(app);
            UnityEngine_Timeline_TrackColorAttribute_Binding.Register(app);
            UnityEngine_Timeline_AudioPlayableAsset_Binding.Register(app);
            UnityEngine_Timeline_AudioTrack_Binding.Register(app);
            UnityEngine_Timeline_ClipCaps_Binding.Register(app);
            UnityEngine_Timeline_ControlPlayableAsset_Binding.Register(app);
            UnityEngine_Timeline_ControlTrack_Binding.Register(app);
            UnityEngine_Timeline_IMarker_Binding.Register(app);
            UnityEngine_Timeline_INotificationOptionProvider_Binding.Register(app);
            UnityEngine_Timeline_Marker_Binding.Register(app);
            UnityEngine_Timeline_MarkerTrack_Binding.Register(app);
            UnityEngine_Timeline_SignalAsset_Binding.Register(app);
            UnityEngine_Timeline_SignalEmitter_Binding.Register(app);
            UnityEngine_Timeline_SignalReceiver_Binding.Register(app);
            UnityEngine_Timeline_SignalTrack_Binding.Register(app);
            UnityEngine_Timeline_TrackAssetExtensions_Binding.Register(app);
            UnityEngine_Timeline_GroupTrack_Binding.Register(app);
            UnityEngine_Timeline_ILayerable_Binding.Register(app);
            UnityEngine_Timeline_ActivationControlPlayable_Binding.Register(app);
            UnityEngine_Timeline_DirectorControlPlayable_Binding.Register(app);
            UnityEngine_Timeline_ITimeControl_Binding.Register(app);
            UnityEngine_Timeline_NotificationFlags_Binding.Register(app);
            UnityEngine_Timeline_ParticleControlPlayable_Binding.Register(app);
            UnityEngine_Timeline_PrefabControlPlayable_Binding.Register(app);
            UnityEngine_Timeline_TimeControlPlayable_Binding.Register(app);
            UnityEngine_Timeline_TimeNotificationBehaviour_Binding.Register(app);
            UnityEngine_Timeline_PlayableTrack_Binding.Register(app);
            UnityEngine_Timeline_TrackClipTypeAttribute_Binding.Register(app);
            UnityEngine_Timeline_NotKeyableAttribute_Binding.Register(app);
            UnityEngine_Timeline_TrackBindingFlags_Binding.Register(app);
            UnityEngine_Timeline_TrackBindingTypeAttribute_Binding.Register(app);
            UnityEngine_Timeline_HideInMenuAttribute_Binding.Register(app);
            UnityEngine_Timeline_CustomStyleAttribute_Binding.Register(app);
            UnityEngine_Timeline_ITimelineClipAsset_Binding.Register(app);
            UnityEngine_Timeline_TimelinePlayable_Binding.Register(app);
            UnityEngine_Timeline_IPropertyCollector_Binding.Register(app);
            UnityEngine_Timeline_IPropertyPreview_Binding.Register(app);
            UnityEngine_Timeline_TimelineClipExtensions_Binding.Register(app);
            UnityEngine_Timeline_StandardFrameRates_Binding.Register(app);
            UnityEngine_Playables_PlayableDirector_Binding.Register(app);
#endif
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}