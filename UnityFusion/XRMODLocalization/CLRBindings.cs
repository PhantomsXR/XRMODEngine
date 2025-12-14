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
            Phantom_XRMOD_Localization_Runtime_BaseLocalizedImageComponent_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_BaseLocalizedTextComponent_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_LocalizatedTextMeshProUGUI_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_LocalizationAudioComponent_Binding.Register(app);


            System_Collections_Generic_List_1_LocalizationTable_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_LocalizationTable_Binding.Register(app);
            System_Collections_Generic_List_1_LocalizationEntry_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_LocalizationEntry_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_LocalizedTemplate_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_LocalizationDatabase_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_LocalizationManagerV2_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_LocalizedTextWithArgs_Binding.Register(app);
            System_Collections_Generic_List_1_LocalizationEntry_Binding_Enumerator_Binding.Register(app);

#if USE_AUDIO_MODULE
            Phantom_XRMOD_Localization_Runtime_LocalizationAudioModuleComponent_Binding.Register(app);
#endif
            Phantom_XRMOD_Localization_Runtime_LocalizationImageComponent_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_LocalizedText_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_LocalizedTextMeshPro_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_AvailablePlace_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_LocalizationManager_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_LocalizationModule_Binding.Register(app);
            Phantom_XRMOD_Localization_Runtime_LocalizedStringKeyExtension_Binding.Register(app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE UnityFusion Appdomain destroy
        /// </summary>
        public static void Shutdown(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}