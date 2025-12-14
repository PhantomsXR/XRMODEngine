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
    [System.Serializable]
    public class OfflineLicense
    {
        public string name;
        public long start_time;
        public long expiration_time;
    }
}