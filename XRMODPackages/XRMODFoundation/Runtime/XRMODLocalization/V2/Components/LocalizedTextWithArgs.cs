/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using TMPro;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Localizes a <see cref="TextMeshProUGUI"/> component while supporting dynamic argument formatting in XRMOD V2.
    /// </summary>
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class LocalizedTextWithArgs : MonoBehaviour
    {
        /// <summary>
        /// The unique localization key for the string template.
        /// </summary>
        [Header("Localization Settings")] public string LocalizationKey;

        /// <summary>
        /// The localization scope for this component.
        /// </summary>
        public LocalizationScope Scope = LocalizationScope.InExperiences;

        private TextMeshProUGUI textComp;
        private LocalizedTemplate template;

        private object[] currentArgs;

        private void Awake()
        {
            textComp = GetComponent<TextMeshProUGUI>();
            UpdateTemplate();
            Refresh();
        }

        private void OnEnable()
        {
            LocalizationManagerV2.OnLanguageChanged += OnLanguageChanged;
        }

        private void OnDestroy()
        {
            LocalizationManagerV2.OnLanguageChanged -= OnLanguageChanged;
        }

        private void OnLanguageChanged(SystemLanguage _newLang)
        {
            UpdateTemplate();
            Refresh();
        }

        /// <summary>
        /// Sets the dynamic arguments used to format the localized template.
        /// </summary>
        /// <param name="_args">The arguments for formatting.</param>
        public void SetArgs(params object[] _args)
        {
            currentArgs = _args;
            Refresh();
        }

        /// <summary>
        /// Refreshes the text display by formatting the template with the current arguments.
        /// </summary>
        public void Refresh()
        {
            if (template == null)
                UpdateTemplate();

            if (template != null)
                textComp.text = template.Format(currentArgs ?? System.Array.Empty<object>());
        }

        /// <summary>
        /// Updates the internal localized template from the database.
        /// </summary>
        public void UpdateTemplate()
        {
            var tmp_HasDb = LocalizationManagerV2.Instance.GetLocalizationDatabase(Scope, out var tmp_Database);
            if (!tmp_HasDb || string.IsNullOrEmpty(LocalizationKey)) return;

            template = new LocalizedTemplate(
                tmp_Database,
                LocalizationKey,
                LocalizationManagerV2.Instance.CurrentLanguage,
                Scope,
                LocalizationManagerV2.Instance.Platform
            );
        }
    }
}