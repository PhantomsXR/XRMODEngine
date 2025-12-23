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
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Represents a single localization entry, containing translations for multiple languages.
    /// </summary>
    [Serializable]
    public class LocalizationEntry
    {
        /// <summary>
        /// The unique key used to identify this localization entry.
        /// </summary>
        public string Key;
#if UNITY_EDITOR
        [FormerlySerializedAs("Lock")] [HideInInspector] public bool Sync;
#endif

        [SerializeField] public List<SystemLanguageTextPair> Translations = new()
        {
            new SystemLanguageTextPair()
            {
                Language = SystemLanguage.English,
                Text = "English"
            },
            new SystemLanguageTextPair()
            {
                Language = SystemLanguage.Chinese,
                Text = "Chinese"
            }
        };

        /// <summary>
        /// Retrieves the localized text for a specific language.
        /// </summary>
        /// <param name="_lang">The desired language.</param>
        /// <returns>The localized text if found; otherwise, returns the <see cref="Key"/> as a fallback.</returns>
        public string Get(SystemLanguage _lang)
        {
            foreach (var tmp_Pair in Translations)
            {
                if (tmp_Pair.Language == _lang)
                    return tmp_Pair.Text;
            }

            return Key; // fallback
        }

        public void Set(SystemLanguage _lang, string _value)
        {
            foreach (var tmp_Pair in Translations)
            {
                if (tmp_Pair.Language != _lang) continue;
                tmp_Pair.Text = _value;
                return;
            }

            Translations.Add(new SystemLanguageTextPair {Language = _lang, Text = _value});
        }
    }

    /// <summary>
    /// A simple pair representing a language and its corresponding localized text.
    /// </summary>
    [Serializable]
    public class SystemLanguageTextPair
    {
        /// <summary>
        /// The language for this pair.
        /// </summary>
        public SystemLanguage Language;

        /// <summary>
        /// The localized text value.
        /// </summary>
        public string Text;
    }
}