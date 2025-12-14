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
    [Serializable]
    public class LocalizationEntry
    {
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

    [Serializable]
    public class SystemLanguageTextPair
    {
        public SystemLanguage Language;
        public string Text;
    }
}