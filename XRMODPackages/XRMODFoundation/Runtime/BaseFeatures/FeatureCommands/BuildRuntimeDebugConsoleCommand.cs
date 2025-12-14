// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the BaseFeaturesModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;
using UnityEngine.Assertions;
using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    public class BuildRuntimeDebugConsoleCommand : AbstractCommand, ICommand, IReleaseCommand
    {
        private const string _CONST_DEBUG_CONSOLE = "IngameDebugConsole";

        public void Execute()
        {
            base.Initializer();
            if (Config.DebugModel)
            {
                BaseContextDataModel.ConsoleGo = Object.Instantiate(Resources.Load<GameObject>(_CONST_DEBUG_CONSOLE));
            }
        }

        public void Release(string _projectName = null)
        {
            if (BaseContextDataModel == null || BaseContextDataModel.ConsoleGo == null) return;
            Object.Destroy(BaseContextDataModel.ConsoleGo);
        }
    }
}