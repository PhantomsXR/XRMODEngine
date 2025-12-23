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
    /// <summary>
    /// Automatically registers the Meta Quest module when running on a Quest device.
    /// </summary>
    [Preserve]
    public class AutoRegisterModule : MonoBehaviour
    {
#if QUEST_INSTALL
        /// <summary>
        /// Unity Awake lifecycle method. Calls RegisterModule.
        /// </summary>
        private void Awake()
        {
            RegisterModule();
        }

        /// <summary>
        /// Registers the <see cref="MetaQuestModule"/> into the IoC container if the current platform is Quest.
        /// </summary>
        private void RegisterModule()
        {
            if (!RuntimePlatformHelper.IsQuest()) return;
            IocContainer.GetIoc.Register<IModule>(new MetaQuestModule());
            APICallback.SdkInitialized();
        }
#endif

    }
}