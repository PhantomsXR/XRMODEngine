/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;
using System.Collections.Generic;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Manages localization data and language settings for the application.
    /// This class follows a singleton pattern to ensure a single instance throughout the application lifecycle.
    /// </summary>
    public class LocalizationManagerV2
    {
        private static LocalizationManagerV2 _LOCALIZATION_MANAGER_V2;

        /// <summary>
        /// Gets the singleton instance of the LocalizationManagerV2.
        /// </summary>
        /// <returns>The singleton instance of LocalizationManagerV2.</returns>
        public static LocalizationManagerV2 Instance => _LOCALIZATION_MANAGER_V2 ??= new LocalizationManagerV2();

        /// <summary>
        /// Gets or sets the current language of the application.
        /// </summary>
        public SystemLanguage CurrentLanguage { get; private set; }

        /// <summary>
        /// Event triggered when the current language changes.
        /// Subscribers can update their UI or content based on the new language.
        /// </summary>
        public static event Action<SystemLanguage> OnLanguageChanged;

        /// <summary>
        /// Gets the name of the current project being localized.
        /// </summary>
        public string ProjectName { get; private set; }

        /// <summary>
        /// Gets the current XRMOD platform.
        /// </summary>
        public XRMODPlatform Platform { get; private set; }

        /// <summary>
        /// Gets the dictionary containing localization databases, keyed by project name and scope.
        /// </summary>
        public Dictionary<string, LocalizationDatabase> Database { get; private set; } = new();

        private LocalizationManagerV2()
        {
            CurrentLanguage = Application.systemLanguage;
            ActionNotificationCenter.DefaultCenter.AddObserver(ReceivedChangeLanguageRequest, nameof(SetLanguage));
        }

        private void ReceivedChangeLanguageRequest(BaseNotificationData _obj)
        {
            if (string.IsNullOrEmpty(_obj.BaseData)) return;
            if (Enum.TryParse<SystemLanguage>(_obj.BaseData, out var tmp_CurrentLanguage))
            {
                SetLanguage(tmp_CurrentLanguage);
            }
        }
        
        /// <summary>
        /// Initializes the localization manager with a specific project, scope, database, language, and platform.
        /// </summary>
        /// <param name="_project">The name of the project.</param>
        /// <param name="_scope">The scope of the localization (e.g., InExperiences, Global).</param>
        /// <param name="_database">The localization database to use for this scope.</param>
        /// <param name="_language">The initial language to set.</param>
        /// <param name="_platform">The XRMOD platform.</param>
        public void Initialize(string _project, LocalizationScope _scope, LocalizationDatabase _database,
            SystemLanguage _language, XRMODPlatform _platform)
        {
            if (_scope == LocalizationScope.InExperiences)
            {
                ProjectName = _project;
                Database.TryAdd($"{_project}.{_scope}", _database);
            }
            else
            {
                Database.TryAdd($"{_scope}.{_scope}", _database);
            }

            Platform = _platform;
            SetLanguage(_language);
        }
        
        /// <summary>
        /// Initializes the localization manager with a specific project, scope, and database.
        /// The initial language is set to the system's current language, and the platform is detected automatically.
        /// </summary>
        /// <param name="_project">The name of the project.</param>
        /// <param name="_scope">The scope of the localization (e.g., InExperiences, Global).</param>
        /// <param name="_database">The localization database to use for this scope.</param>
        public void Initialize(string _project, LocalizationScope _scope, LocalizationDatabase _database)
        {
            if (_scope == LocalizationScope.InExperiences)
            {
                ProjectName = _project;
                Database.TryAdd($"{_project}.{_scope}", _database);
            }
            else
            {
                Database.TryAdd($"{_scope}.{_scope}", _database);
            }

            Platform = RuntimePlatformHelper.GetXRMODRuntimePlatformType();
        }

        /// <summary>
        /// Sets the current language of the application.
        /// If the new language is different from the current one, the OnLanguageChanged event is invoked.
        /// </summary>
        /// <param name="_newLang">The new SystemLanguage to set.</param>
        public void SetLanguage(SystemLanguage _newLang)
        {
            if (_newLang == CurrentLanguage) return;
            CurrentLanguage = _newLang;
            OnLanguageChanged?.Invoke(_newLang);
        }

        /// <summary>
        /// Retrieves a localized template for a given key and scope.
        /// </summary>
        /// <param name="_key">The key to look up in the localization database.</param>
        /// <param name="_scope">The scope of the localization (e.g., InExperiences, Global).</param>
        /// <returns>A LocalizedTemplate instance if the database and key are found, otherwise null.</returns>
        public LocalizedTemplate GetLocalizedTemplate(string _key, LocalizationScope _scope)
        {
            return GetLocalizationDatabase(_scope, out var tmp_Database)
                ? new LocalizedTemplate(tmp_Database, _key, CurrentLanguage, _scope, Platform)
                : null;
        }

        /// <summary>
        /// Releases a localization database from memory based on project name and scope.
        /// </summary>
        /// <param name="_projectName">The name of the project associated with the database.</param>
        /// <param name="_scope">The scope of the localization database to release.</param>
        /// <returns>True if the database was successfully removed, false otherwise.</returns>
        public bool Release(string _projectName, LocalizationScope _scope)
        {
            return Database.Remove($"{_projectName}.{_scope}");
        }

        /// <summary>
        /// Attempts to retrieve a localization database based on its scope.
        /// </summary>
        /// <param name="_scope">The scope of the localization database to retrieve.</param>
        /// <param name="_database">When this method returns, contains the LocalizationDatabase associated with the specified scope, if found; otherwise, null.</param>
        /// <returns>True if the LocalizationDatabase is found; otherwise, false.</returns>
        internal bool GetLocalizationDatabase(LocalizationScope _scope, out LocalizationDatabase _database)
        {
            return _scope == LocalizationScope.InExperiences
                ? Database.TryGetValue($"{ProjectName}.{_scope}", out _database)
                : Database.TryGetValue($"{_scope}.{_scope}", out _database);
        }
    }
}