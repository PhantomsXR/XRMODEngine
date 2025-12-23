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
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phantom.XRMOD.InAppPurchase.Runtime
{
    /// <summary>
    /// Manages In-App Purchases (IAP).
    /// Handles product initialization, purchase flow, and restoration.
    /// </summary>
    public class InAppPurchaseManager
    {
        public Action<bool> OnPurchaseStateChange;
        public Action<string> OnPurchaseFailedHandler;
        public Action<bool> OnRestoreHandler;
        private IPurchaseAPI purchaseAPI;

        private static InAppPurchaseManager _INSTANCE;
        public static InAppPurchaseManager GetInstance => _INSTANCE ??= new();

        private InAppPurchaseManager()
        {
        }


        /// <summary>
        /// Initialize in-app purchase products
        /// </summary>
        /// <param name="_productDatas">The products for in-app purchase</param>
        public async Task Initialization(ProductData[] _productDatas)
        {
            try
            {
#if QUEST_INSTALL && !UNITY_EDITOR && META_PLATFORM_PLUGIN_INSTALL
                purchaseAPI = new OculusInAppPurchase(new PurchaseCallback
                {
                    OnPurchaseStateChange = this.OnPurchaseStateChange,
                    OnPurchaseFailedHandler = this.OnPurchaseFailedHandler,
                    OnRestoreHandler = this.OnRestoreHandler
                });
#elif (UNITY_IOS || UNITY_ANDROID || UNITY_TVOS || UNITY_VISIONOS) && !UNITY_EDITOR
                purchaseAPI = new AppleAppPurchase(new PurchaseCallback
                {
                    OnPurchaseStateChange = this.OnPurchaseStateChange,
                    OnPurchaseFailedHandler = this.OnPurchaseFailedHandler,
                    OnRestoreHandler = this.OnRestoreHandler
                });
#else
                purchaseAPI = new UnityEditorPurchase(new PurchaseCallback
                {
                    OnPurchaseStateChange = this.OnPurchaseStateChange,
                    OnPurchaseFailedHandler = this.OnPurchaseFailedHandler,
                    OnRestoreHandler = this.OnRestoreHandler
                });
#endif
                await purchaseAPI.FetchProduct(_productDatas);
            }
            catch (Exception e)
            {
                throw; // TODO handle exception
            }
        }

        /// <summary>
        /// But the product via product id
        /// </summary>
        /// <param name="_productId">Will be but product id</param>
        public Task<bool> BuyProduct(string _productId) => purchaseAPI.BuyProduct(_productId);

        /// <summary>
        /// Restore your product
        /// </summary>
        public async Task<bool> Restore() => await purchaseAPI.RestoreProduct();

        /// <summary>
        /// Check the product is purchased
        /// </summary>
        /// <param name="_productId">Provide the product id to check purchase state</param>
        /// <returns>If the return value is True,
        /// it means that the current product has been purchased and vice versa.
        /// </returns>
        public async Task<bool> IsPurchased(string _productId) => await purchaseAPI.IsPurchased(_productId);

        /// <summary>
        /// Get a list of products that can be purchased in-app.
        /// </summary>
        /// <returns>List of products</returns>
        public async Task<List<ProductData>> GetProducts() => await purchaseAPI.GetProducts();
    }
}
#endif