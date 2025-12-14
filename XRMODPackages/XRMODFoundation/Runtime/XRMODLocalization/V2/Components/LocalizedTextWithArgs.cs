// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Localization.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using TMPro;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    public class LocalizedTextWithArgs : MonoBehaviour
    {
        [Header("Localization Settings")] public string LocalizationKey;
        public LocalizationScope Scope = LocalizationScope.InExperiences;

        private TextMeshProUGUI textComp;
        private LocalizedTemplate template;

        private object[] currentArgs = null;

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

        public void SetArgs(params object[] _args)
        {
            currentArgs = _args;
            Refresh();
        }

        public void Refresh()
        {
            if (template == null)
                UpdateTemplate();

            if (template != null)
                textComp.text = template.Format(currentArgs ?? System.Array.Empty<object>());
        }

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