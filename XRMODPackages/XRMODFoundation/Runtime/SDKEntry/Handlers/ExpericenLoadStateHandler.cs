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

using Phantom.XRMOD.XRMODUtilites.Runtime;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    /// <summary>
    /// Handler that notifies the host application that asset loading is in progress.
    /// </summary>
    public class ExpericenLoadStateHandler : AbstractHandler
    {
        public override void Handle()
        {
            APICallback.ExperienceStartLoad();
            base.Handle();
        }
    }
}