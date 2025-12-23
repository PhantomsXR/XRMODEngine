// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Threading.Tasks;
using Phantom.XRMOD.SDKEntry.Runtime.Models;

namespace Phantom.XRMOD.SDKEntry.Runtime.DataRequest
{
        /// <summary>
    /// Generic command for downloading a JSON manifest for an asset bundle.
    /// </summary>
    /// <typeparam name="T">The type to deserialize the JSON result into.</typeparam>
    public class DownloadAssetBundleJson<T> : IHttpRequestCommand<T> 
    {
        private readonly QueryParameter queryParameter;

        public DownloadAssetBundleJson(QueryParameter _queryParameter)
        {
            queryParameter = _queryParameter;
        }

        public async Task<T> Execute()
        {
            return await NetworkRequestUtil.SendRequest<T>(_apiUrl: queryParameter.AssetBundleJsonUrl,
                _method: ConstKey.CONST_REQUEST_GET,
                _timeout: queryParameter.Timeout,
                _token: queryParameter.Token);
        }
    }
}