// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.RokidModule.Runtime.
// //
// // The RokidPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/


using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    public class AutoRegisterModule : MonoBehaviour
    {
        private void Awake()
        {
            if (!RuntimePlatformHelper.IsRokid()) return;
            var tmp_RokidRuntimeContextModel = new RokidRuntimeContextModel(transform.Find("XRMODRig"));
            tmp_RokidRuntimeContextModel.Initialize();
            IocContainer.GetIoc.Register(tmp_RokidRuntimeContextModel);
#if ROKID_INSTALL
            IocContainer.GetIoc.Register<IModule>(new RokidModule());
#endif
            APICallback.SdkInitialized();
        }
    }
}
