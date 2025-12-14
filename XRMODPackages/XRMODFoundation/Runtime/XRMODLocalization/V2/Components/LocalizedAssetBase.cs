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
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    public abstract class LocalizedAssetBase<T> : MonoBehaviour where T : UnityEngine.Object
    {
        public string Key;
        public LocalizationScope Scope;
        protected abstract void ApplyAsset(T _asset);

        protected virtual void OnEnable()
        {
            LocalizationManagerV2.OnLanguageChanged += Refresh;
            Refresh(LocalizationManagerV2.Instance.CurrentLanguage);
        }

        protected virtual void OnDisable()
        {
            LocalizationManagerV2.OnLanguageChanged -= Refresh;
        }

        protected async void Refresh(SystemLanguage _language)
        {
            if (string.IsNullOrEmpty(Key)) return;
            var tmp_LocalizationManager = LocalizationManagerV2.Instance;
            var tmp_HasDb = LocalizationManagerV2.Instance.GetLocalizationDatabase(Scope, out var tmp_Database);
            if (!tmp_HasDb) return;
            var tmp_LocalizedKey =
                tmp_Database.GetLocalizedString(Key, _language, Scope, tmp_LocalizationManager.Platform);
            var tmp_Asset = await LocalizedAssetLoader.LoadAsync<T>(
                Key, _language, tmp_LocalizationManager.ProjectName, Scope, tmp_LocalizedKey
            );

            if (tmp_Asset != null)
                ApplyAsset(tmp_Asset);
        }
    }
}