// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace Phantom.XRMOD.SDKEntry.Runtime.Models
{
    /// <summary>
    /// Represents a license for offline usage of the XRMOD SDK.
    /// </summary>
    [System.Serializable]
    public class OfflineLicense
    {
        /// <summary> The name associated with the license. </summary>
        public string name;
        /// <summary> The Unix timestamp (seconds) when the license validity starts. </summary>
        public long start_time;
        /// <summary> The Unix timestamp (seconds) when the license expires. </summary>
        public long expiration_time;
    }
}