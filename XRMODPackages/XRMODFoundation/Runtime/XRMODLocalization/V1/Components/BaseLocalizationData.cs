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

using UnityEngine;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.Localization.Runtime
{
    public abstract class BaseLocalizationData<T> : MonoBehaviour, IContentComponent<T>
    {
        [SerializeField] protected string key;

        [FormerlySerializedAs("scope")]
        [FormerlySerializedAs("availablePlace")]
        [Tooltip(
            "Used to distinguish different work areas. \nInExperiences is used for the XR Experience workspace, and InLauncher is used for the Launcher workspace")]
        [SerializeField]
        protected LocalizationScope localizationScope = LocalizationScope.InExperiences;

        internal LocalizationScope GetLocalizationScope => localizationScope;
        
        protected virtual void Start()
        {
            SetKey(key);
        } 

        public abstract void UpdateContent(T _value);

        public virtual void SetKey(string _key)
        {
            key = _key;
        }

        public virtual string GetKey() => key;
    }
}