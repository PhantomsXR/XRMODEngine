// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Nin1.Runtime.
// //
// // The Nin1 cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if UNITY_IN_APP_PURCHASE

using UnityEngine.Purchasing;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.InAppPurchase.Runtime
{
    [System.Serializable]
    public class ProductData
    {
        public string ProductUid;
        public string ProductName;
        public ProductType ProductType;
        public string ProductPrice;
    }
}
#endif