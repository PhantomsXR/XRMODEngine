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

#if QUEST_INSTALL && UNITY_IN_APP_PURCHASE && META_PLATFORM_PLUGIN_INSTALL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using ProductType = Oculus.Platform.ProductType;

namespace Phantom.XRMOD.InAppPurchase.Runtime
{
    internal class OculusInAppPurchase : IPurchaseAPI
    {
        private readonly List<ProductData> allProducts = new();
        private readonly List<ProductData> purchasedProducts = new();
        private PurchaseCallback purchasedCallback;
        private ProductData[] willFetchProductData;

        public OculusInAppPurchase(PurchaseCallback _purchasedCallback = null)
        {
            purchasedCallback = _purchasedCallback;
            if (!Oculus.Platform.Core.IsInitialized())
            {
                Oculus.Platform.Core.AsyncInitialize();
            }
        }

        async Task IPurchaseAPI.FetchProduct(ProductData[] _productIDs)
        {
            willFetchProductData = _productIDs;
            var tmp_ProductIds = _productIDs.Select(p => p.ProductUid).ToArray();

            var tmp_ProductsTask = WaitForRequestResult(Oculus.Platform.IAP.GetProductsBySKU(tmp_ProductIds));
            var tmp_PurchasesTask = WaitForRequestResult(Oculus.Platform.IAP.GetViewerPurchases());

            var tmp_ProductsResult = await tmp_ProductsTask;
            var tmp_PurchasesResult = await tmp_PurchasesTask;

            // 调用原来的回调逻辑
            GetProductsBySKUCallback(tmp_ProductsResult);
            GetPurchasedProductListCallback(tmp_PurchasesResult);
        }


        async Task<bool> IPurchaseAPI.BuyProduct(string _productID)
        {
            var tmp_BuyProductTask = WaitForRequestResult(Oculus.Platform.IAP.LaunchCheckoutFlow(_productID));
            var tmp_BuyProductResult = await tmp_BuyProductTask;
            return await Task.FromResult(LaunchCheckoutFlowCallback(tmp_BuyProductResult));
        }

        async Task<bool> IPurchaseAPI.IsPurchased(string _productID)
        {
            var tmp_PurchasesTask = WaitForRequestResult(Oculus.Platform.IAP.GetViewerPurchases());
            var tmp_PurchasesResult = await tmp_PurchasesTask;
            GetPurchasedProductListCallback(tmp_PurchasesResult);
            return purchasedProducts.Exists(_product => _product.ProductUid == _productID);
        }

        async Task<bool> IPurchaseAPI.RestoreProduct()
        {
            await Task.Yield();
            return true;
        }

        async Task<List<ProductData>> IPurchaseAPI.GetProducts()
        {
            var tmp_ProductIds = willFetchProductData.Select(p => p.ToString()).ToArray();
            var tmp_ProductsTask = WaitForRequestResult(Oculus.Platform.IAP.GetProductsBySKU(tmp_ProductIds));
            var tmp_ProductsResult = await tmp_ProductsTask;
            GetProductsBySKUCallback(tmp_ProductsResult);

            return allProducts;
        }


        void GetPurchasedProductListCallback(
            Oculus.Platform.Message<Oculus.Platform.Models.PurchaseList> _response)
        {
            if (_response.IsError)
            {
                Debug.LogError(_response.GetError().Message);
                return;
            }

            foreach (Oculus.Platform.Models.Purchase p in _response.GetPurchaseList())
            {
                ConvertOculusProductTypeToUnityProductType(p.Type, out var tmp_UnityProductType);
                var tmp_ProductData = new ProductData
                {
                    ProductUid = p.Sku,
                    ProductType = tmp_UnityProductType,
                };
                purchasedProducts.Add(tmp_ProductData);
            }
        }


        void GetProductsBySKUCallback(Oculus.Platform.Message<Oculus.Platform.Models.ProductList> msg)
        {
            if (msg.IsError)
            {
                Debug.LogError(msg.GetError().Message);
                return;
            }

            foreach (Oculus.Platform.Models.Product p in msg.GetProductList())
            {
                ConvertOculusProductTypeToUnityProductType(p.Type, out var tmp_UnityProductType);
                var tmp_ProductData = new ProductData
                {
                    ProductUid = p.Sku,
                    ProductName = p.Name,
                    ProductType = tmp_UnityProductType,
                    ProductPrice = p.FormattedPrice
                };
                allProducts.Add(tmp_ProductData);
            } 
        }


        bool LaunchCheckoutFlowCallback(Oculus.Platform.Message<Oculus.Platform.Models.Purchase> msg)
        {
            if (msg.IsError)
            {
                Debug.LogError(msg.GetError());
                purchasedCallback?.OnPurchaseFailedHandler(msg.GetError().Message);
                return false;
            }

            Oculus.Platform.Models.Purchase tmp_Product = msg.GetPurchase(); 
            purchasedCallback?.OnPurchaseStateChange(true);
            return true;
        }


        void ConvertOculusProductTypeToUnityProductType(ProductType _productType,
            out UnityEngine.Purchasing.ProductType _unityProductType)
        {
            _unityProductType = UnityEngine.Purchasing.ProductType.NonConsumable;
            switch (_productType)
            {
                case ProductType.Unknown:
                    break;
                case ProductType.DURABLE:
                    _unityProductType = UnityEngine.Purchasing.ProductType.Consumable;
                    break;
                case ProductType.CONSUMABLE:
                    _unityProductType = UnityEngine.Purchasing.ProductType.NonConsumable;
                    break;
                case ProductType.SUBSCRIPTION:
                    _unityProductType = UnityEngine.Purchasing.ProductType.Subscription;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_productType), _productType, null);
            }
        }

        // 用于将 Oculus 的回调式 Request 转换成 Task
        Task<Oculus.Platform.Message<T>> WaitForRequestResult<T>(Oculus.Platform.Request<T> request)
        {
            var tmp_Tcs = new TaskCompletionSource<Oculus.Platform.Message<T>>();
            request.OnComplete(_message =>
            {
                if (_message.IsError)
                {
                    tmp_Tcs.SetException(new Exception($"Oculus request failed: {_message.GetError().Message}"));
                }
                else
                {
                    tmp_Tcs.SetResult(_message);
                }
            });
            return tmp_Tcs.Task;
        }
    }
}
#endif