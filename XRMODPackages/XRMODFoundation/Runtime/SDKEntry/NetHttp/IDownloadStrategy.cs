// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Miscellaneous Files.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Threading.Tasks;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    /// <summary>
    /// Interface for file download strategies.
    /// </summary>
    public interface IDownloadStrategy
    {
        Task DownloadFileAsync(string _url, string _destinationPath, IProgress<float> _progress = null);
    }
}