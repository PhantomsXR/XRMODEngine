// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.GameServices.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;

namespace Phantom.XRMOD.InAppPurchase.Runtime
{
    public class PurchaseCallback
    {
        public Action<bool> OnPurchaseStateChange;
        public Action<string> OnPurchaseFailedHandler;
        public Action<bool> OnRestoreHandler;
    }
}