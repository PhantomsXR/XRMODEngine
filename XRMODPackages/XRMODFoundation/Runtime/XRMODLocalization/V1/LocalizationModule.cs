/*===============================================================================
Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The Localization cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Represents a single localization module for a specific project and scope.
    /// Handles the parsing of localization tables, management of localizable components, 
    /// and retrieval of localized assets (strings, sprites, audio clips).
    /// </summary>
    public class LocalizationModule
    {
        /// <summary>
        /// Tracks all text components registered for automatic localization within this module.
        /// </summary>
        private Dictionary<LocalizationScope, List<BaseLocalizedTextComponent>> textComponents;

        /// <summary>
        /// Tracks all image components registered for automatic localization within this module.
        /// </summary>
        private Dictionary<LocalizationScope, List<BaseLocalizedImageComponent>> imgComponents;

        /// <summary>
        /// Tracks all audio components registered for automatic localization within this module.
        /// </summary>
        private Dictionary<LocalizationScope, List<LocalizationAudioComponent>> audioComponents;

#if USE_AUDIO_MODULE
        /// <summary>
        /// Tracks all audio module components registered for automatic localization within this module.
        /// </summary>
        private Dictionary<LocalizationScope, List<LocalizationAudioModuleComponent>> audioModuleComponents;
#endif

        /// <summary>
        /// The parsed localization table, mapping languages to key-value pairs.
        /// </summary>
        private Dictionary<string, Dictionary<string, string>> localizationTable;

        /// <summary>
        /// The current language code being used by this module.
        /// </summary>
        private string currentLanguage;

        /// <summary>
        /// The localization scope (e.g., InExperiences, InLauncher) of this module.
        /// </summary>
        private LocalizationScope localizationScope;

        /// <summary>
        /// The name of the project associated with this localization module.
        /// </summary>
        private string projectName;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizationModule"/> class.
        /// </summary>
        /// <param name="_projectName">The name of the project.</param>
        /// <param name="_localizationTable">The raw bytes of the localization table.</param>
        /// <param name="_language">The initial language to use.</param>
        /// <param name="_place">The localization scope.</param>
        public LocalizationModule(string _projectName, byte[] _localizationTable, string _language,
            LocalizationScope _place)
        {
            projectName = _projectName;
            Init(_localizationTable, _language, _place);
        }

        /// <summary>
        /// Internal initialization of the localization module.
        /// </summary>
        /// <param name="_localizationTable">The raw bytes of the localization table.</param>
        /// <param name="_language">The language to use.</param>
        /// <param name="_place">The localization scope.</param>
        protected void Init(byte[] _localizationTable, string _language, LocalizationScope _place)
        {
            currentLanguage = _language;
            localizationScope = _place;
            textComponents = new();
            localizationTable = new();
            imgComponents = new();
            audioComponents = new();
#if USE_AUDIO_MODULE
            audioModuleComponents = new();
#endif
            LoadLanguageDb(_localizationTable);
            Refresh(localizationScope);
        }


        /// <summary>
        /// Retrieves the localized string for a given key in the current language.
        /// </summary>
        /// <param name="_key">The unique key for the localized string.</param>
        /// <returns>The localized string if found; otherwise, returns a formatted error message.</returns>
        public string GetLocalizedString(string _key)
        {
            if (localizationTable == null)
            {
                return GetErrorFormat("The default language not exist!");
            }

            if (!localizationTable.ContainsKey(currentLanguage))
            {
                Debug.LogError($"{currentLanguage} not exist!");
                return GetErrorFormat($"{currentLanguage} not exist!");
            }


            if (localizationTable[currentLanguage].TryGetValue(_key, out var tmp_Value))
                return tmp_Value;

            Debug.LogError($"{currentLanguage}->{_key} not exist!");
            return GetErrorFormat($"{currentLanguage}->{_key} not exist!");
        }

        /// <summary>
        /// Changes the current language and refreshes all registered components.
        /// </summary>
        /// <param name="_localizationTable">The new localization table data.</param>
        /// <param name="_language">The target language.</param>
        /// <param name="_place">The localization scope.</param>
        public void ChangeLanguage(byte[] _localizationTable, string _language, LocalizationScope _place)
        {
            textComponents.Clear();

            var tmp_AllLocalizedTextComps =
                Object.FindObjectsByType<BaseLocalizedTextComponent>(FindObjectsInactive.Include,
                    FindObjectsSortMode.None);

            var tmp_FilteredLocalizedTextComps =
                tmp_AllLocalizedTextComps.Where(_comp => _comp.GetLocalizationScope == _place)
                    .ToList();


            // Add or update
            if (!textComponents.TryAdd(_place, tmp_FilteredLocalizedTextComps))
            {
                textComponents[_place] = tmp_FilteredLocalizedTextComps;
            }

            if (localizationTable == null) return;
            if (textComponents.Count == 0) return;
            currentLanguage = _language;
            Init(_localizationTable, _language, _place);

            foreach (var tmp_Text in textComponents[_place])
            {
                tmp_Text.UpdateContent(GetLocalizedString(tmp_Text.GetKey()));
            }
        }


        /// <summary>
        /// Manually registers a text component for automatic localization within this module's scope.
        /// </summary>
        /// <param name="_contentComponent">The text component to register.</param>
        /// <param name="_place">The localization scope.</param>
        public void AddText(BaseLocalizedTextComponent _contentComponent, LocalizationScope _place)
        {
            if (textComponents.TryGetValue(_place, out var tmp_Text))
            {
                tmp_Text.Add(_contentComponent);
                _contentComponent.UpdateContent(GetLocalizedString(_contentComponent.GetKey()));
            }
        }


        /// <summary>
        /// Manually registers an image component for automatic localization within this module's scope.
        /// </summary>
        /// <param name="_contentComponent">The image component to register.</param>
        /// <param name="_place">The localization scope.</param>
        public async void AddImage(BaseLocalizedImageComponent _contentComponent, LocalizationScope _place)
        {
            if (imgComponents.TryGetValue(_place, out var tmp_Img))
            {
                tmp_Img.Add(_contentComponent);
                var tmp_Key = GetLocalizedString(_contentComponent.GetKey());

                if (_place == LocalizationScope.InExperiences)
                {
                    var tmp_Sprite = await BasePackageLoaderUtility.LoadAssetFromPackage<Sprite>(projectName, tmp_Key);
                    _contentComponent.UpdateContent(tmp_Sprite);
                }
                else
                {
                    _contentComponent.UpdateContent(Resources.Load<Sprite>(tmp_Key));
                }
            }
        }

        /// <summary>
        /// Manually registers an audio component for automatic localization within this module's scope.
        /// </summary>
        /// <param name="_contentComponent">The audio component to register.</param>
        /// <param name="_place">The localization scope.</param>
        public async void AddAudio(LocalizationAudioComponent _contentComponent, LocalizationScope _place)
        {
            if (audioComponents.TryGetValue(_place, out var tmp_AudioComponents))
            {
                tmp_AudioComponents.Add(_contentComponent);
                var tmp_Key = GetLocalizedString(_contentComponent.GetKey());

                if (_place == LocalizationScope.InExperiences)
                {
                    var tmp_AudioClip =
                        await BasePackageLoaderUtility.LoadAssetFromPackage<AudioClip>(projectName, tmp_Key);
                    _contentComponent.UpdateContent(tmp_AudioClip);
                }
                else
                {
                    _contentComponent.UpdateContent(Resources.Load<AudioClip>(tmp_Key));
                }
            }
        }

#if USE_AUDIO_MODULE

        /// <summary>
        /// Manually registers an audio module component for automatic localization within this module's scope.
        /// </summary>
        /// <param name="_contentComponent">The audio module component to register.</param>
        /// <param name="_place">The localization scope.</param>
        public async void AddAudioModule(LocalizationAudioModuleComponent _contentComponent, LocalizationScope _place)
        {
            if (audioModuleComponents.TryGetValue(_place, out var tmp_AudioComponents))
            {
                tmp_AudioComponents.Add(_contentComponent);
                var tmp_Key = GetLocalizedString(_contentComponent.GetKey());

                if (_place == LocalizationScope.InExperiences)
                {
                    var tmp_AudioClipData =
                        await BasePackageLoaderUtility
                            .LoadAssetFromPackage<Phantom.XRMOD.AudioModule.Runtime.AudioClipData>(projectName,
                                tmp_Key);
                    _contentComponent.UpdateContent(tmp_AudioClipData);
                }
                else
                {
                    _contentComponent.UpdateContent(
                        Resources.Load<Phantom.XRMOD.AudioModule.Runtime.AudioClipData>(tmp_Key));
                }
            }
        }
#endif

        /// <summary>
        /// Refreshes all registered components for the specified scope.
        /// </summary>
        /// <param name="_place">The localization scope to refresh.</param>
        internal void Refresh(LocalizationScope _place)
        {
            RefreshTextComps(_place);
            RefreshImageComps(_place);
            RefreshAudioComps(_place);
            RefreshAudioModuleComps(_place);
        }

        private async void RefreshAudioModuleComps(LocalizationScope _place)
        {
#if USE_AUDIO_MODULE
            if (audioModuleComponents.TryGetValue(_place, out var tmp_AudioComponents))
            {
                tmp_AudioComponents.Clear();
            }

            var tmp_AllLocalizedAudioModuleComps =
                Object.FindObjectsByType<LocalizationAudioModuleComponent>(FindObjectsInactive.Include,
                    FindObjectsSortMode.None);

            var tmp_FilteredLocalizedAudioModuleComps =
                tmp_AllLocalizedAudioModuleComps.Where(_comp => _comp.GetLocalizationScope == _place)
                    .ToList();

            // Add or update
            if (!audioModuleComponents.TryAdd(_place, tmp_FilteredLocalizedAudioModuleComps))
            {
                audioModuleComponents[_place] = tmp_FilteredLocalizedAudioModuleComps;
            }

            foreach (var tmp_AudioModule in audioModuleComponents[_place])
            {
                var tmp_Key = GetLocalizedString(tmp_AudioModule.GetKey());
                if (_place == LocalizationScope.InExperiences)
                {
                    var tmp_AudioClipData =
                        await BasePackageLoaderUtility
                            .LoadAssetFromPackage<Phantom.XRMOD.AudioModule.Runtime.AudioClipData>(projectName,
                                tmp_Key);
                    tmp_AudioModule.UpdateContent(tmp_AudioClipData);
                }
                else
                {
                    tmp_AudioModule.UpdateContent(
                        Resources.Load<Phantom.XRMOD.AudioModule.Runtime.AudioClipData>(tmp_Key));
                }
            }
#endif
        }

        private async void RefreshAudioComps(LocalizationScope _place)
        {
            if (audioComponents.TryGetValue(_place, out var tmp_AudioComponents))
            {
                tmp_AudioComponents.Clear();
            }

            var tmp_AllLocalizedAudioComps =
                Object.FindObjectsByType<LocalizationAudioComponent>(FindObjectsInactive.Include,
                    FindObjectsSortMode.None);
            var tmp_FilteredLocalizedAudioComps =
                tmp_AllLocalizedAudioComps.Where(_comp => _comp.GetLocalizationScope == _place)
                    .ToList();

            // Add or update
            if (!audioComponents.TryAdd(_place, tmp_FilteredLocalizedAudioComps))
            {
                audioComponents[_place] = tmp_FilteredLocalizedAudioComps;
            }

            foreach (var tmp_AudioComponent in audioComponents[_place])
            {
                var tmp_Key = GetLocalizedString(tmp_AudioComponent.GetKey());
                if (_place == LocalizationScope.InExperiences)
                {
                    var tmp_AudioClip =
                        await BasePackageLoaderUtility.LoadAssetFromPackage<AudioClip>(projectName, tmp_Key);
                    tmp_AudioComponent.UpdateContent(tmp_AudioClip);
                }
                else
                {
                    tmp_AudioComponent.UpdateContent(Resources.Load<AudioClip>(tmp_Key));
                }
            }
        }

        private async void RefreshImageComps(LocalizationScope _place)
        {
            if (imgComponents.TryGetValue(_place, out var tmp_ImageComponents))
            {
                tmp_ImageComponents.Clear();
            }

            var tmp_AllLocalizedImgComps =
                Object.FindObjectsByType<BaseLocalizedImageComponent>(FindObjectsInactive.Include,
                    FindObjectsSortMode.None);

            var tmp_FilteredLocalizedImgComps =
                tmp_AllLocalizedImgComps.Where(_comp => _comp.GetLocalizationScope == _place)
                    .ToList();

            // Add or update
            if (!imgComponents.TryAdd(_place, tmp_FilteredLocalizedImgComps))
            {
                imgComponents[_place] = tmp_FilteredLocalizedImgComps;
            }

            foreach (var tmp_Img in imgComponents[_place])
            {
                var tmp_ImgKey = GetLocalizedString(tmp_Img.GetKey());
                if (_place == LocalizationScope.InExperiences)
                {
                    var tmp_Sprite =
                        await BasePackageLoaderUtility.LoadAssetFromPackage<Sprite>(projectName, tmp_ImgKey);
                    tmp_Img.UpdateContent(tmp_Sprite);
                }
                else
                {
                    tmp_Img.UpdateContent(Resources.Load<Sprite>(tmp_ImgKey));
                }
            }
        }

        private void RefreshTextComps(LocalizationScope _place)
        {
            if (textComponents.TryGetValue(_place, out var tmp_TextComponents))
            {
                tmp_TextComponents.Clear();
            }

            var tmp_AllLocalizedTextComps =
                Object.FindObjectsByType<BaseLocalizedTextComponent>(FindObjectsInactive.Include,
                    FindObjectsSortMode.None);

            var tmp_FilteredLocalizedTextComps =
                tmp_AllLocalizedTextComps.Where(_comp => _comp.GetLocalizationScope == _place)
                    .ToList();

            // Add or update
            if (!textComponents.TryAdd(_place, tmp_FilteredLocalizedTextComps))
            {
                textComponents[_place] = tmp_FilteredLocalizedTextComps;
            }

            foreach (var tmp_Text in textComponents[_place])
            {
                tmp_Text.UpdateContent(GetLocalizedString(tmp_Text.GetKey()));
            }
        }

        /// <summary>
        /// Loads the localization database from the provided raw bytes (CSV format).
        /// </summary>
        /// <param name="_localizationTable">The raw bytes of the CSV file.</param>
        private void LoadLanguageDb(byte[] _localizationTable)
        {
            List<string> tmp_AllRows = new List<string>(0);
            using MemoryStream tmp_Stream = new MemoryStream(_localizationTable);
            using StreamReader tmp_Sr = new StreamReader(tmp_Stream, Encoding.UTF8);
            while (tmp_Sr.ReadLine() is { } tmp_Line)
            {
                tmp_AllRows.Add(tmp_Line);
            }

            tmp_Sr.Close();

            string tmp_Pattern = @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))";

            var tmp_Header = Regex.Split(tmp_AllRows[0], tmp_Pattern);

            for (int tmp_Idx = 1; tmp_Idx < tmp_Header.Length; tmp_Idx++)
            {
                string tmp_Lang = GetExactValue(tmp_Header[tmp_Idx].Trim('"'));
                if (tmp_Lang != currentLanguage) continue;
                Dictionary<string, string> tmp_Value = new Dictionary<string, string>();
                for (int tmp_J = 1; tmp_J < tmp_AllRows.Count; tmp_J++)
                {
                    string tmp_Row = tmp_AllRows[tmp_J];
                    var tmp_Cells = Regex.Split(tmp_Row, tmp_Pattern);
                    tmp_Value.Add(GetExactValue(tmp_Cells[0]), GetExactValue(tmp_Cells[tmp_Idx]));
                }

                localizationTable.Add(tmp_Lang, tmp_Value);
            }
        }

        /// <summary>
        /// Parses a CSV value string, removing quotes and handling escaped quotes.
        /// </summary>
        /// <param name="_val">The raw CSV value.</param>
        /// <returns>The cleaned string value.</returns>
        private string GetExactValue(string _val)
        {
            if (_val[0] == '"' && _val[^1] == '"')
            {
                _val = _val.Substring(1, _val.Length - 2);
            }

            const char tmp_const_P = '"';
            string tmp_Pattern = tmp_const_P + tmp_const_P.ToString();
            string tmp_P2 = tmp_const_P + "";
            _val = _val.Replace(tmp_Pattern, tmp_P2);
            return _val;
        }

        /// <summary>
        /// Formats an error message for display when a localization key or table is missing.
        /// </summary>
        /// <param name="_error">The error message.</param>
        /// <returns>A rich text formatted error string.</returns>
        private string GetErrorFormat(string _error)
        {
            return $"<color=red><size=10>{_error}</size></color>";
        }
    }
}