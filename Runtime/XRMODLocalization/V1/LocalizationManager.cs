/*===============================================================================
Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The Localization cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// The central manager for the localization system in XRMOD. 
    /// It handles the initialization of localization modules for different scopes 
    /// and provides APIs for retrieving localized strings and managing language changes.
    /// </summary>
    public class LocalizationManager
    {
        private static LocalizationManager _INSTANCE;

        /// <summary>
        /// Gets the singleton instance of the <see cref="LocalizationManager"/>.
        /// </summary>
        public static LocalizationManager Instance => _INSTANCE ??= new LocalizationManager();

        private static readonly Dictionary<LocalizationScope, LocalizationModule> _LOCALIZATION_MODULES = new();

        private const string _CONST_NOT_INITIALIZED_PROMPTS =
            "Localization module has not been initialized yet. You must initialize this API before calling this method.";

        private LocalizationManager()
        {
        }

        /// <summary>
        /// Initializes the localization system for a specific project and scope.
        /// </summary>
        /// <param name="_proejctName">The name of the project.</param>
        /// <param name="_localizationTable">The raw bytes of the localization table (typically a CSV file).</param>
        /// <param name="_language">The default language to use (e.g., "en-US", "zh-CN").</param>
        /// <param name="_localizationScope">The scope to which this localization applies (e.g., InExperiences, InLauncher).</param>
        public void Initialized(string _proejctName, byte[] _localizationTable, string _language = null,
            LocalizationScope _localizationScope = LocalizationScope.InExperiences)
        {
            if (_LOCALIZATION_MODULES.ContainsKey(_localizationScope))
                _LOCALIZATION_MODULES.Remove(_localizationScope);

            _LOCALIZATION_MODULES.TryAdd(_localizationScope,
                new LocalizationModule(_proejctName, _localizationTable, _language, _localizationScope));
        }

        /// <summary>
        /// Obsolete initialization method using <see cref="AvailablePlace"/>. Use the <see cref="LocalizationScope"/> version instead.
        /// </summary>
        /// <param name="_proejctName">The name of the project.</param>
        /// <param name="_localizationTable">The raw bytes of the localization table.</param>
        /// <param name="_language">The default language.</param>
        /// <param name="_localizationScope">The legacy workspace scope.</param>
        [Obsolete("This method will be removed in future versions. Use LocalizationScope instead.")]
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
        /// Manually registers a text component for automatic localization updates.
        /// </summary>
        /// <param name="_contentComponent">The localizable text component to add.</param>
        /// <param name="_place">The localization scope the component belongs to.</param>
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
        /// Retrieves a localized string based on the provided key and scope.
        /// </summary>
        /// <param name="_key">The unique key for the localized string.</param>
        /// <param name="_place">The localization scope to search in.</param>
        /// <returns>The localized string if found; otherwise, returns an error message or an empty string.</returns>
        public string GetLocalizedString(string _key, LocalizationScope _place)
        {
            if (_LOCALIZATION_MODULES.TryGetValue(_place, out var tmp_LocalizationModule))
            {
                return tmp_LocalizationModule.GetLocalizedString(_key);
            }

            Debug.LogError(_CONST_NOT_INITIALIZED_PROMPTS);
            return string.Empty;
        }

        /// <summary>
        /// Legacy method to retrieve a localized string using <see cref="AvailablePlace"/>.
        /// </summary>
        /// <param name="_key">The unique key for the localized string.</param>
        /// <param name="_place">The legacy workspace scope.</param>
        /// <returns>The localized string.</returns>
        [Obsolete("Use LocalizationScope instead.")]
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
        /// Changes the current language for a specific localization scope.
        /// This will update all registered components within that scope.
        /// </summary>
        /// <param name="_localizationTable">The new localization table data for the target language.</param>
        /// <param name="_language">The name of the target language.</param>
        /// <param name="_localizationScope">The scope in which to apply the language change.</param>
        public void ChangeLanguage(byte[] _localizationTable, string _language, LocalizationScope _localizationScope)
        {
            if (_LOCALIZATION_MODULES.TryGetValue(_localizationScope, out var tmp_LocalizationModule))
            {
                tmp_LocalizationModule.ChangeLanguage(_localizationTable, _language, _localizationScope);
                return;
            }

            Debug.LogError(_CONST_NOT_INITIALIZED_PROMPTS);
        }

        /// <summary>
        /// Legacy method to change the language using <see cref="AvailablePlace"/>.
        /// </summary>
        /// <param name="_localizationTable">The new localization table data.</param>
        /// <param name="_language">The target language.</param>
        /// <param name="_localizationScope">The legacy workspace scope.</param>
        [Obsolete("Use LocalizationScope instead.")]
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
        /// Manually registers an image component for automatic localization updates.
        /// </summary>
        /// <param name="_contentComponent">The localizable image component to add.</param>
        /// <param name="_place">The localization scope the component belongs to.</param>
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
        /// Manually registers an audio component for automatic localization updates.
        /// </summary>
        /// <param name="_contentComponent">The localizable audio component to add.</param>
        /// <param name="_place">The localization scope the component belongs to.</param>
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
        /// Manually registers an audio module component for automatic localization updates.
        /// Only available if <c>USE_AUDIO_MODULE</c> is defined.
        /// </summary>
        /// <param name="_contentComponent">The localizable audio module component to add.</param>
        /// <param name="_place">The localization scope the component belongs to.</param>
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