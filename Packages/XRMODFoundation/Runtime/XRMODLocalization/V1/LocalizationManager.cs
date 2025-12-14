// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Localization.Runtime.
// //
// // The Localization cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    public class LocalizationManager
    {
        private static LocalizationManager _INSTANCE;
        public static LocalizationManager Instance => _INSTANCE ??= new LocalizationManager();

        private static readonly Dictionary<LocalizationScope, LocalizationModule> _LOCALIZATION_MODULES = new();

        private const string _CONST_NOT_INITIALIZED_PROMPTS =
            "Localization module has not been initialized yet. You must initialize this API before calling this method.";

        private LocalizationManager()
        {
        }

        /// <summary>
        /// Initialize localization system
        /// </summary>
        /// <param name="_localizationTable">Your localization table</param>
        /// <param name="_language">Default language</param>
        /// <param name="_localizationScope">Workspace</param>
        public void Initialized(string _proejctName, byte[] _localizationTable, string _language = null,
            LocalizationScope _localizationScope = LocalizationScope.InExperiences)
        {
            if (_LOCALIZATION_MODULES.ContainsKey(_localizationScope))
                _LOCALIZATION_MODULES.Remove(_localizationScope);

            _LOCALIZATION_MODULES.TryAdd(_localizationScope,
                new LocalizationModule(_proejctName, _localizationTable, _language, _localizationScope));
        }

        [Obsolete("This method will be removed in future versions.")]
        public void Initialized(string _proejctName, byte[] _localizationTable, string _language = null,
            AvailablePlace _localizationScope = AvailablePlace.InExperiences)
        {
            var tmp_LocalizationScope = _localizationScope.ToLocalizationScope();
            if (_LOCALIZATION_MODULES.ContainsKey(tmp_LocalizationScope))
                _LOCALIZATION_MODULES.Remove(tmp_LocalizationScope);

            _LOCALIZATION_MODULES.TryAdd(tmp_LocalizationScope,
                new LocalizationModule(_proejctName, _localizationTable, _language, tmp_LocalizationScope));
        }

        /// <summary>
        /// Manually add the text component to the localization
        /// </summary>
        /// <param name="_contentComponent">The unity ugui component(Request:LocalizedTextMeshProUGUI/LocalizedText/LocalizedTextMeshPro)</param>
        /// <param name="_place">Workspace</param>
        internal void AddText(BaseLocalizedTextComponent _contentComponent, LocalizationScope _place)
        {
            if (_LOCALIZATION_MODULES.TryGetValue(_place, out var tmp_LocalizationModule))
            {
                tmp_LocalizationModule.AddText(_contentComponent, _place);
                return;
            }

            Debug.Log(_CONST_NOT_INITIALIZED_PROMPTS);
        }

        /// <summary>
        /// Get the localized string via a key.
        /// </summary>
        /// <param name="_key">The key for localized.</param>
        /// <param name="_place">Workspace</param>
        /// <returns>The localized string.</returns>
        public string GetLocalizedString(string _key, LocalizationScope _place)
        {
            if (_LOCALIZATION_MODULES.TryGetValue(_place, out var tmp_LocalizationModule))
            {
                return tmp_LocalizationModule.GetLocalizedString(_key);
            }

            Debug.LogError(_CONST_NOT_INITIALIZED_PROMPTS);
            return string.Empty;
        }
        
        public string GetLocalizedString(string _key, AvailablePlace _place)
        {
            if (_LOCALIZATION_MODULES.TryGetValue(_place.ToLocalizationScope(), out var tmp_LocalizationModule))
            {
                return tmp_LocalizationModule.GetLocalizedString(_key);
            }

            Debug.LogError(_CONST_NOT_INITIALIZED_PROMPTS);
            return string.Empty;
        }

        /// <summary>
        /// Change current localized language to other language
        /// </summary>
        /// <param name="_localizationTable">The language database(Dictionary)</param>
        /// <param name="_language">Target language</param>
        /// <param name="_localizationScope">Workspace</param>
        public void ChangeLanguage(byte[] _localizationTable, string _language, LocalizationScope _localizationScope)
        {
            if (_LOCALIZATION_MODULES.TryGetValue(_localizationScope, out var tmp_LocalizationModule))
            {
                tmp_LocalizationModule.ChangeLanguage(_localizationTable, _language, _localizationScope);
                return;
            }

            Debug.LogError(_CONST_NOT_INITIALIZED_PROMPTS);
        }
        
        public void ChangeLanguage(byte[] _localizationTable, string _language, AvailablePlace _localizationScope)
        {
            if (_LOCALIZATION_MODULES.TryGetValue(_localizationScope.ToLocalizationScope(), out var tmp_LocalizationModule))
            {
                tmp_LocalizationModule.ChangeLanguage(_localizationTable, _language, _localizationScope.ToLocalizationScope());
                return;
            }

            Debug.LogError(_CONST_NOT_INITIALIZED_PROMPTS);
        }



        #region Image Localization

        /// <summary>
        /// Manually add the text component to the localization
        /// </summary>
        /// <param name="_contentComponent">The unity ugui component(Request:LocalizedTextMeshProUGUI/LocalizedText/LocalizedTextMeshPro)</param>
        /// <param name="_place">Workspace</param>
        internal void AddImage(BaseLocalizedImageComponent _contentComponent, LocalizationScope _place)
        {
            if (_LOCALIZATION_MODULES.TryGetValue(_place, out var tmp_LocalizationModule))
            {
                tmp_LocalizationModule.AddImage(_contentComponent, _place);
                return;
            }

            Debug.Log(_CONST_NOT_INITIALIZED_PROMPTS);
        }

        #endregion

        #region Audio Localization

        /// <summary>
        /// Manually add the text component to the localization
        /// </summary>
        /// <param name="_contentComponent">The unity ugui component(Request:LocalizedTextMeshProUGUI/LocalizedText/LocalizedTextMeshPro)</param>
        /// <param name="_place">Workspace</param>
        internal void AddAudio(LocalizationAudioComponent _contentComponent, LocalizationScope _place)
        {
            if (_LOCALIZATION_MODULES.TryGetValue(_place, out var tmp_LocalizationModule))
            {
                tmp_LocalizationModule.AddAudio(_contentComponent, _place);
                return;
            }

            Debug.Log(_CONST_NOT_INITIALIZED_PROMPTS);
        }

        /// <summary>
        /// Manually add the text component to the localization
        /// </summary>
        /// <param name="_contentComponent">The unity ugui component(Request:LocalizedTextMeshProUGUI/LocalizedText/LocalizedTextMeshPro)</param>
        /// <param name="_place">Workspace</param>
#if USE_AUDIO_MODULE
        internal void AddAudioModule(LocalizationAudioModuleComponent _contentComponent, LocalizationScope _place)
        {
            if (_LOCALIZATION_MODULES.TryGetValue(_place, out var tmp_LocalizationModule))
            {
                tmp_LocalizationModule.AddAudioModule(_contentComponent, _place);
                return;
            }

            Debug.Log(_CONST_NOT_INITIALIZED_PROMPTS);
        }
#endif

        #endregion
    }
}