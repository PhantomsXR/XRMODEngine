/*===============================================================================
Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The Localization cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Defines a generic interface for components that can have their content localized.
    /// </summary>
    /// <typeparam name="T">The type of content to be localized (e.g., string, Sprite, AudioClip).</typeparam>
    public interface IContentComponent<T>
    {
        /// <summary>
        /// Updates the current content of the component with a new localized value.
        /// </summary>
        /// <param name="_value">The new localized value to apply.</param>
        void UpdateContent(T _value);

        /// <summary>
        /// Sets the unique localization key used by this component to retrieve its content.
        /// </summary>
        /// <param name="_key">The unique localization key.</param>
        void SetKey(string _key);

        /// <summary>
        /// Retrieves the unique localization key currently assigned to this component.
        /// </summary>
        /// <returns>The unique localization key as a string.</returns>
        string GetKey();
    }
}