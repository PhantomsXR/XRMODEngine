// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.QuestModule.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;
using UnityEngine.Scripting;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    [Preserve]
    public class AutoRegisterModule : MonoBehaviour
    {
#if QUEST_INSTALL
        private void Awake()
        {
            RegisterModule();
        }

        private void RegisterModule()
        {
            if (!RuntimePlatformHelper.IsQuest()) return;
            IocContainer.GetIoc.Register<IModule>(new MetaQuestModule());
            APICallback.SdkInitialized();
        }
#endif

    }
}