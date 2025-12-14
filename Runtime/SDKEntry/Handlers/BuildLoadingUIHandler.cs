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

using System.Threading.Tasks;
using Phantom.XRMOD.XRMODUtilites.Runtime;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    public class BuildLoadingUIHandler : AbstractHandler
    {
        public override void Handle()
        {
            APICallback.ExperienceStartLoad();
            base.Handle();
        }
    }


    public static class HandlerExtension
    {
        public static async Task<string> GetEmptyResult(this AbstractHandler _abstractHandler)
        {
            await Task.Yield();
            return string.Empty;
        }
    }
}