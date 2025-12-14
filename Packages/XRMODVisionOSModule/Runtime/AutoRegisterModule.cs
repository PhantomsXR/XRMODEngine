// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VisionOSModule.Runtime.
// //
// // The AVPPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;
using UnityEngine.Scripting;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    [Preserve]
    public class AutoRegisterModule : MonoBehaviour
    {
#if VISIONOS_INSTALL
        private void Awake()
        {
            RegisterModule();
        }

        private void RegisterModule()
        {
            if (!RuntimePlatformHelper.IsVisionOS()) return;
            IocContainer.GetIoc.Register<IModule>(new AppleVisionProModule());
            APICallback.SdkInitialized();
        }
#endif
    }
}