// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.SDKEntry.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    /// <summary>
    /// Manages file downloads using a specified <see cref="IDownloadStrategy"/>.
    /// Provides a high-level API for asynchronous downloads with progress reporting.
    /// </summary>
    public class DownloadManager
    {
        private readonly IDownloadStrategy downloadStrategy;

        public DownloadManager(IDownloadStrategy _downloadStrategy)
        {
            this.downloadStrategy = _downloadStrategy ?? throw new ArgumentNullException(nameof(_downloadStrategy));
        }

        public async Task DownloadAsync(string _url, string _destinationPath, IProgress<float> _progress = null)
        {
            if (string.IsNullOrEmpty(_url))
            {
                throw new ArgumentNullException(nameof(_url));
            }

            if (string.IsNullOrEmpty(_destinationPath))
            {
                throw new ArgumentNullException(nameof(_destinationPath));
            }

            try
            {
                await downloadStrategy.DownloadFileAsync(_url, _destinationPath, _progress);
            }
            catch (HttpRequestException tmp_Ex)
            {
                Debug.LogError($"Download Failed：{tmp_Ex.Message}");
                throw;
            }
            catch (Exception tmp_Ex)
            {
                Debug.LogError($"Download Failed：{tmp_Ex.Message}");
                throw;
            }
        }
    }
}