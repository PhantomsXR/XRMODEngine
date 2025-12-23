// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantoms.Models.Runtime.
// //
// // The XRMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace Phantom.XRMOD.Models.Runtime
{
    /// <summary>
    /// Specialized data model for Immersal visual positioning system (VPS) configuration.
    /// contains tokens, timing, and behavior flags for the Immersal localizer.
    /// </summary>
    public class ImmersalContextDataModel
    {
        /// <summary> The developer token for authenticating with Immersal services. </summary>
        public string DeveloperToken;
        /// <summary> Whether to start the Immersal localizer automatically. </summary>
        public bool AutoStart = true;
        /// <summary> Whether to use position filtering for more stable results. </summary>
        public bool UseFiltering = true;
        /// <summary> Whether to reset the localization state when the active map changes. </summary>
        public bool ResetOnMapChange = false;
        /// <summary> The interval (in seconds) between localization attempts. </summary>
        public float LocalizationInterval = 2f;
        /// <summary> Whether to use server-side localization instead of local. </summary>
        public bool UseServerLocalizer;
        /// <summary> Whether to enable burst mode for high-frequency localization attempts. </summary>
        public bool BurstMode = true;
        /// <summary> Whether to stop the localizer after a successful localization. </summary>
        public bool StopLocalizedAfterSuccess;
    }
}