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

using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using Phantom.XRMOD.BaseFeatures.Runtime;
using Phantom.XRMOD.Models.Runtime;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.Models;
using Phantom.XRMOD.XRMODUtilites.Runtime;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    public class DisposeXRMODEngineHandler : AbstractHandler
    {
        public override void Handle()
        {
            BasePackageLoaderUtility.ReleaseAllAssetBundle();
            InstantiateUtility.CleanPool();
#if UNITY_IOS || UNITY_ANDROID || UNITY_VISIONOS
            Handheld.ClearShaderCache();
#endif
            Resources.UnloadUnusedAssets();

            ActionNotificationCenter.DefaultCenter.Release();

            IocContainer.GetIoc.UnRegister<BuildExitCommand>();
            IocContainer.GetIoc.UnRegister<BuildExceptionCollectorCommand>();
            IocContainer.GetIoc.UnRegister<BuildTryAcquireSdkTypeCommand>();
            IocContainer.GetIoc.UnRegister<BuildTryAcquireSDKVersionCommand>();

            IocContainer.GetIoc.UnRegister<BaseFeatureModule>();
            IocContainer.GetIoc.UnRegister<IModule>();


            IocContainer.GetIoc.UnRegister<SDKEntryPointModel>();
            IocContainer.GetIoc.UnRegister<RuntimeExperienceConfig>();

            //Notice app, xr-mod was closed.
            APICallback.OnXRMODExit();
            base.Handle();
        }
    }
}