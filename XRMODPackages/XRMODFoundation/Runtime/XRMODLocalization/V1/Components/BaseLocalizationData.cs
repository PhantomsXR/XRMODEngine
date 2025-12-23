/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Base abstract class for all localizable data components in XRMOD.
    /// Handles the management of localization keys and scopes.
    /// </summary>
    /// <typeparam name="T">The type of data being localized.</typeparam>
    public abstract class BaseLocalizationData<T> : MonoBehaviour, IContentComponent<T>
    {
        /// <summary>
        /// The unique key used to look up the localized value in the localization table.
        /// </summary>
        [SerializeField] protected string key;

        /// <summary>
        /// Specifies the application scope (e.g., InExperiences, InLauncher) where this component's localization is applied.
        /// </summary>
        [FormerlySerializedAs("scope")]
        [FormerlySerializedAs("availablePlace")]
        [Tooltip(
            "Used to distinguish different work areas. \nInExperiences is used for the XR Experience workspace, and InLauncher is used for the Launcher workspace")]
        [SerializeField]
        protected LocalizationScope localizationScope = LocalizationScope.InExperiences;

        /// <summary>
        /// Gets the localization scope assigned to this component.
        /// </summary>
        internal LocalizationScope GetLocalizationScope => localizationScope;
        
        /// <summary>
        /// Standard Unity Start method. Ensures the key is initialized.
        /// </summary>
        protected virtual void Start()
        {
            SetKey(key);
        } 

        /// <summary>
        /// Abstract method to apply a new localized value to the component.
        /// </summary>
        /// <param name="_value">The new localized value.</param>
        public abstract void UpdateContent(T _value);

        /// <summary>
        /// Sets a new localization key for this component.
        /// </summary>
        /// <param name="_key">The new unique key.</param>
        public virtual void SetKey(string _key)
        {
            key = _key;
        }

        /// <summary>
        /// Gets the current localization key assigned to this component.
        /// </summary>
        /// <returns>The localization key.</returns>
        public virtual string GetKey() => key;
    }
}