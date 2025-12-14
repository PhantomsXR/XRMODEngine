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

using Phantom.XRMOD.ActionNotification.Runtime;

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public static class MethodKey
    {
        public static readonly string ONLOAD = nameof(ActionParameterDataType.OnLoad);
        public static readonly string ONUPDATE = nameof(ActionParameterDataType.OnUpdate);
        public static readonly string ONEVENT =nameof( ActionParameterDataType.OnEvent);
        public static readonly string INITMONOSCRIPTS = nameof(ActionParameterDataType.InitMonoScripts);
        // public static readonly string ONMULTIPLAYEREVENT = nameof(ActionParameterDataType.OnMultiplayerEvent);

        public static readonly string ONFOCUSSLAMSTATECHANGE = nameof(ActionParameterDataType.OnFocusStateChange);
        public static readonly string RELEASEMEMORY = nameof(ActionParameterDataType.ReleaseMemory);
        public static readonly string IMAGESTATECHANGE = nameof(ActionParameterDataType.ImageStateChange);
    }
}