// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XR-MOD SDK.
// //
// // The XR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace Phantom.XRMOD.SDKEntry.Runtime.Mapper
{
    [System.Serializable]
    public class BaseServerResponse
    {
        // ReSharper disable once InconsistentNaming
        public int status_code;
        
        // ReSharper disable once InconsistentNaming
        public string msg;
    }
}