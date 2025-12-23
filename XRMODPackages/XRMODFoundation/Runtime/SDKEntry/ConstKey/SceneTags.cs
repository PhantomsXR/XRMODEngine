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

    //Unity Scene
    /// <summary>
    /// Standard Unity scene names/tags used by the SDK for internal navigation and cleanup.
    /// </summary>
    public enum SceneTags
    {
        /// <summary> The initialization scene. </summary>
        Initilizer = 0,
        /// <summary> The main XR experience scene. </summary>
        Main,
        /// <summary> A utility scene used for clearing state. </summary>
        Clear
    }
}