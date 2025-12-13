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
    public class ImmersalContextDataModel : IModel
    {
        public string DeveloperToken;
        public bool AutoStart;
        public bool UseFiltering;
        public float LocalizationInterval;
        public bool UseServerLocalizer;
        public bool BurstMode;
        public bool StopLocalizedAfterSuccess;
        public bool ResetOnMapChange;

        public void Initialize()
        {
            throw new System.NotImplementedException();
        }
    }
} 