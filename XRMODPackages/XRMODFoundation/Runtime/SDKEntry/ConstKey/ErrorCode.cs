// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    /// <summary>
    /// Defines error codes returned by various SDK operations, such as initialization,
    /// downloading, and asset loading.
    /// </summary>
    public enum ErrorCode : int
    {
        /// <summary> SDK initialization failed. </summary>
        INIT_SDK_FAILED = -1,
        /// <summary> SDK initialization was successful. </summary>
        INIT_SDK_SUCCESS = 0,
        /// <summary> Unpacking project assets failed. </summary>
        UNPACKING_FAILED = 1,
        /// <summary> Downloading project assets failed. </summary>
        DOWNLOAD_FAILED = 2,
        /// <summary> Loading the AR/XR visualizer failed. </summary>
        LOAD_VISUALIZER_FAILED = 3,
        /// <summary> An error occurred within the tracking algorithm. </summary>
        ALGORITHM_ERROR = 4,
        /// <summary> The maximum number of retry attempts for an operation was reached. </summary>
        REACHED_MAXIMUM_OF_RETRIES = 5,
        /// <summary> The current SDK version is below the minimum required by the project. </summary>
        SDK_VERSION_IS_TOO_LOW = 6
    }
}