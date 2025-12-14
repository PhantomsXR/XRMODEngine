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

#if (UNITY_IOS || UNITY_VISIONOS || UNITY_TVOS) && UNITY_IN_APP_PURCHASE

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Phantom.XRMOD.InAppPurchase.Runtime
{
    public class AppleAppPurchase : IPurchaseAPI, IDetailedStoreListener
    {
        IStoreController storeController;
        IAppleExtensions appleExtensions;
        ConfigurationBuilder configurationBuilder;
        private TaskCompletionSource<bool> purchaseTCS;
        private string currentPurchasingProductID;

        private PurchaseCallback purchaseCallback;

        internal readonly List<ProductData> products = new List<ProductData>();

        public AppleAppPurchase(PurchaseCallback _purchaseCallback)
        {
            purchaseCallback = _purchaseCallback;
        }

        #region IPurchaseAPI implementation

        async Task IPurchaseAPI.FetchProduct(ProductData[] _productIDs)
        {
            await Task.Yield();

            var tmp_Builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
            foreach (var tmp_ProductId in _productIDs)
            {
                tmp_Builder.AddProduct(tmp_ProductId.ProductUid, tmp_ProductId.ProductType);
            }

            UnityPurchasing.Initialize(this, tmp_Builder);
        }

        async Task<bool> IPurchaseAPI.BuyProduct(string _productID)
        {
            if (purchaseTCS != null && !purchaseTCS.Task.IsCompleted)
            {
                throw new InvalidOperationException("A purchase is already in progress.");
            }

            currentPurchasingProductID = _productID;
            purchaseTCS = new TaskCompletionSource<bool>();

            storeController.InitiatePurchase(_productID);

            // 等待 ProcessPurchase 或失败流程完成
            return await purchaseTCS.Task;
        }

        async Task<bool> IPurchaseAPI.RestoreProduct()
        {
            try
            {
                bool tmp_Success = await RestoreTransactionsAsync();
                return tmp_Success;
            }
            catch (Exception tmp_Ex)
            {
                Debug.LogError($"RestoreProduct failed: {tmp_Ex.Message}");
            }

            return false;
        }

        Task<bool> IPurchaseAPI.IsPurchased(string _productID)
        {
            var tmp_IsPurchased = storeController.products.WithID(_productID);
            return Task.FromResult(tmp_IsPurchased is {hasReceipt: true});
        }

        Task<List<ProductData>> IPurchaseAPI.GetProducts()
        {
            return Task.FromResult(products);
        }


        // 将回调形式的 RestoreTransactions 包装为 Task<bool>
        Task<bool> RestoreTransactionsAsync()
        {
            var tmp_Tcs = new TaskCompletionSource<bool>();

            appleExtensions.RestoreTransactions((_success, _error) =>
            {
                if (!string.IsNullOrEmpty(_error))
                {
                    tmp_Tcs.SetException(new Exception(_error));
                }
                else
                {
                    tmp_Tcs.SetResult(_success);
                }
            });

            return tmp_Tcs.Task;
        }

        #endregion

        #region IStoreController implementation

        public void OnInitializeFailed(InitializationFailureReason _error)
        {
            OnInitializeFailed(_error, null);
        }

        public void OnInitializeFailed(InitializationFailureReason _error, string _message)
        {
            var tmp_ErrorMessage = $"Purchasing failed to initialize. Reason: {_error}.";
            Debug.LogError(tmp_ErrorMessage);
        }

        public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs _purchaseEvent)
        {
            var tmp_Product = _purchaseEvent.purchasedProduct;
            var tmp_ProductID = tmp_Product.definition.id;
            var tmp_IsPurchased = ((IPurchaseAPI) this).IsPurchased(tmp_ProductID);

            // 如果是当前我们等待的商品，完成 Task
            if (tmp_ProductID == currentPurchasingProductID && purchaseTCS != null)
            {
                purchaseTCS.SetResult(true);
                purchaseTCS = null;
                currentPurchasingProductID = null;
            }

            return PurchaseProcessingResult.Complete;
        }

        public void OnPurchaseFailed(Product _product, PurchaseFailureReason _failureReason)
        {
            purchaseCallback?.OnPurchaseFailedHandler?.Invoke(_failureReason.ToString());
        }

        public void OnInitialized(IStoreController _controller, IExtensionProvider _extensions)
        {
            storeController = _controller;
            appleExtensions = _extensions.GetExtension<IAppleExtensions>();

            var tmp_Prices = appleExtensions.GetIntroductoryPriceDictionary();
            foreach (var tmp_Product in configurationBuilder.products)
            {
                var tmp_Price = tmp_Prices[tmp_Product.id];
                var tmp_ProductData = new ProductData
                {
                    ProductUid = tmp_Product.id,
                    ProductName = tmp_Product.storeSpecificId,
                    ProductType = tmp_Product.type,
                    ProductPrice = tmp_Price
                };
                products.Add(tmp_ProductData);
            }
        }

        public void OnPurchaseFailed(Product _product, PurchaseFailureDescription _failureDescription)
        {
            purchaseCallback?.OnPurchaseFailedHandler?.Invoke(_failureDescription.ToString());
        }

        #endregion
    }
}
#endif