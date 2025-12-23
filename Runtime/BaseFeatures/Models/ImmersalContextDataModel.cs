// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the BaseFeaturesModule.Runtime.
// //
// // The XRMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.BaseFeatures.Runtime.Models
{
    /// <summary>
    /// Data model specifically for managing Immersal localization state within the BaseFeatures module.
    /// Implements <see cref="IModel"/> for registration in the Ioc Container.
    /// </summary>
    public class ImmersalContextDataModel : IModel
    {
        /// <summary> The token used for Immersal server authentication. </summary>
        public string DeveloperToken;
        /// <summary> Whether localization should start automatically. </summary>
        public bool AutoStart;
        /// <summary> Whether to enable position and rotation filtering. </summary>
        public bool UseFiltering;
        /// <summary> Time interval between localization attempts (in seconds). </summary>
        public float LocalizationInterval;
        /// <summary> Use cloud-side localization instead of local on-device. </summary>
        public bool UseServerLocalizer;
        /// <summary> Enable high-frequency burst mode for faster localization. </summary>
        public bool BurstMode;
        /// <summary> Automatically stop the localizer once a valid position is found. </summary>
        public bool StopLocalizedAfterSuccess;
        /// <summary> Reset the localization state when the active map changes. </summary>
        public bool ResetOnMapChange;

        /// <summary>
        /// Initializes the model. Currently not implemented.
        /// </summary>
        public void Initialize()
        {
            throw new System.NotImplementedException();
        }
    }
} 