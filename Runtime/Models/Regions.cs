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
    /// <summary>
    /// Defines geographic regions for Unity multiplayer services.
    /// </summary>
    public enum RegionType
    {
        /// <summary>
        /// South Carolina, USA (us-east1).
        /// </summary>
        SouthCarolina,
        
        /// <summary>
        /// Iowa, USA (us-central1).
        /// </summary>
        Iowa,
        
        /// <summary>
        /// Oregon, USA (us-west1).
        /// </summary>
        Oregon,
        
        /// <summary>
        /// São Paulo, Brazil (southamerica-east1).
        /// </summary>
        SaoPaulo,
        
        /// <summary>
        /// Finland (europe-north1).
        /// </summary>
        Finland,
        
        /// <summary>
        /// Poland (europe-central2).
        /// </summary>
        Poland,
        
        /// <summary>
        /// Netherlands (europe-west4).
        /// </summary>
        Netherlands,
        
        /// <summary>
        /// Singapore (asia-southeast1).
        /// </summary>
        Singapore,
        
        /// <summary>
        /// Tokyo, Japan (asia-northeast1).
        /// </summary>
        Tokyo,
        
        /// <summary>
        /// Mumbai, India (asia-south1).
        /// </summary>
        Mumbai,
        
        /// <summary>
        /// Sydney, Australia (australia-southeast1).
        /// </summary>
        Sydney
    }

    /// <summary>
    /// Extension methods for <see cref="RegionType"/>.
    /// </summary>
    public static class RegionTypeExtensions
    {
        /// <summary>
        /// Converts a <see cref="RegionType"/> to its corresponding Unity region string identifier.
        /// </summary>
        /// <param name="_regionType">The region type to convert.</param>
        /// <returns>The Unity region string identifier.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the region type is not recognized.</exception>
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