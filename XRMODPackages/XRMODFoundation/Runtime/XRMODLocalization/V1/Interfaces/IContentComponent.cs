// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Localization.Runtime.
// //
// // The Localization cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    public interface IContentComponent<T>
    {
        /// <summary>
        /// Update current content
        /// </summary>
        void UpdateContent(T _value);

        /// <summary>
        /// Set the localization key for this component.
        /// </summary>
        /// <param name="_key">The localization key for indexing.</param>
        void SetKey(string _key);

        /// <summary>
        /// Get the component key for localization.
        /// </summary>
        /// <returns></returns>
        string GetKey();
    }
}