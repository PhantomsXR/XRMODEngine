// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System; 

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    public enum RegionType
    {
        SouthCarolina,
        Iowa,
        Oregon,
        SaoPaulo,
        Finland,
        Poland,
        Netherlands,
        Singapore,
        Tokyo,
        Mumbai,
        Sydney
    }

    public static class RegionTypeExtensions
    {
        public static string ToRegionString(this RegionType _regionType)
        {
            switch (_regionType)
            {
                case RegionType.SouthCarolina:
                    return "us-east1";
                case RegionType.Iowa:
                    return "us-central1";
                case RegionType.Oregon:
                    return "us-west1";
                case RegionType.SaoPaulo:
                    return "southamerica-east1";
                case RegionType.Finland:
                    return "europe-north1";
                case RegionType.Poland:
                    return "europe-central2";
                case RegionType.Netherlands:
                    return "europe-west4";
                case RegionType.Singapore:
                    return "asia-southeast1";
                case RegionType.Tokyo:
                    return "asia-northeast1";
                case RegionType.Mumbai:
                    return "asia-south1";
                case RegionType.Sydney:
                    return "australia-southeast1";
                default:
                    throw new ArgumentOutOfRangeException(nameof(_regionType), _regionType, null);
            }
        }
    }
}