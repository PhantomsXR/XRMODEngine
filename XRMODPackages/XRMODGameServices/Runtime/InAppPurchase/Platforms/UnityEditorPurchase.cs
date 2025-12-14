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

#if UNITY_EDITOR && UNITY_IN_APP_PURCHASE

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Phantom.XRMOD.InAppPurchase.Runtime
{
    public class UnityEditorPurchase : IDetailedStoreListener, IPurchaseAPI
    {
        IStoreController storeController;
        private TaskCompletionSource<bool> purchaseTcs;
        private string currentPurchasingProductID;
        private readonly List<ProductData> products = new List<ProductData>();

        private PurchaseCallback purchaseCallback;

        public UnityEditorPurchase(PurchaseCallback _purchaseCallback)
        {
            purchaseCallback = _purchaseCallback;
        }

        #region IDetailedStoreListener implementation

        public void OnInitializeFailed(InitializationFailureReason _error)
        {
            OnInitializeFailed(_error, null);
        }

        public void OnInitializeFailed(InitializationFailureReason _error, string _message)
        {
            var tmp_ErrorMessage = $"Purchasing failed to initialize. Reason: {_error}.";

            if (_message != null)
            {
                tmp_ErrorMessage += $" More details: {_message}";
            }

            Debug.Log(tmp_ErrorMessage);
        }

        public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs _purchaseEvent)
        {
            var tmp_Product = _purchaseEvent.purchasedProduct;
            var tmp_ProductID = tmp_Product.definition.id;
            var tmp_IsPurchased = ((IPurchaseAPI) this).IsPurchased(tmp_ProductID);

            // 如果是当前我们等待的商品，完成 Task
            if (tmp_ProductID == currentPurchasingProductID && purchaseTcs != null)
            {
                purchaseTcs.SetResult(true);
                //purchaseTcs = null;
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
        }

        public void OnPurchaseFailed(Product _product, PurchaseFailureDescription _failureDescription)
        {
            purchaseCallback?.OnPurchaseFailedHandler?.Invoke(_failureDescription.ToString());
        }

        #endregion


        #region IPurchaseAPI implementation

        async Task IPurchaseAPI.FetchProduct(ProductData[] _productIDs)
        {
            products.Clear();
            await Task.Yield();
            products.AddRange(_productIDs);
            var tmp_Builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
            foreach (ProductData tmp_ProductData in _productIDs)
            {
                tmp_Builder.AddProduct(tmp_ProductData.ProductUid, tmp_ProductData.ProductType);
            }

            UnityPurchasing.Initialize(this, tmp_Builder);
        }

        async Task<bool> IPurchaseAPI.BuyProduct(string _productID)
        {
            if (purchaseTcs != null && !purchaseTcs.Task.IsCompleted)
            {
                throw new InvalidOperationException("A purchase is already in progress.");
            }

            currentPurchasingProductID = _productID;
            purchaseTcs = null;
            purchaseTcs = new TaskCompletionSource<bool>();

            storeController.InitiatePurchase(_productID);

            // 等待 ProcessPurchase 或失败流程完成
            return await purchaseTcs.Task;
        }

        Task<bool> IPurchaseAPI.IsPurchased(string _productID)
        {
            var tmp_IsPurchased = storeController.products.WithID(_productID);
            return Task.FromResult(tmp_IsPurchased is {hasReceipt: true});
        }

        Task<bool> IPurchaseAPI.RestoreProduct()
        {
            return Task.FromResult(true);
        }

        Task<List<ProductData>> IPurchaseAPI.GetProducts()
        {
            return Task.FromResult(products);
        }

        #endregion
    }
}
#endif