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
#if UNITY_IN_APP_PURCHASE
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phantom.XRMOD.InAppPurchase.Runtime
{
    internal interface IPurchaseAPI
    {
        internal Task FetchProduct(ProductData[] _productIDs);
        internal Task<bool> BuyProduct(string _productID);
        internal Task<bool> IsPurchased(string _productID);

        internal Task<bool> RestoreProduct();

        internal Task<List<ProductData>> GetProducts();
    }
}
#endif