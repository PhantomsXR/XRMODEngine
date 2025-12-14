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

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime;
using Phantom.XRMOD.Models.Runtime;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    public class BuildScriptRuntimeEnvironmentCommand : AbstractCommand, ICommand, IReleaseCommand
    {
        public async void Execute()
        {
            base.Initializer();
            Config = RuntimeExperienceConfig.CurrentConfigures.Value;
            switch (RuntimeExperienceConfig.CurrentConfigures.Value.ProgrammableType)
            {
                case ProgrammableType.CSharp:
                    if ((!string.IsNullOrEmpty(RuntimeExperienceConfig.CurrentConfigures.Value.MainEntry)
                         || !string.IsNullOrEmpty(RuntimeExperienceConfig.CurrentConfigures.Value.DomainName)))
                    {
                        var tmp_ProjectName = Config.ProjectName;
                        BaseContextDataModel.CodeHook.Value ??= new CodesHook();
                        BaseContextDataModel.CodeHook.Value.debug =
                            RuntimeExperienceConfig.CurrentConfigures.Value.DebugModel;
                        BaseContextDataModel.CodeHook.Value?.InitializeHook(tmp_ProjectName, Config.DomainName,
                            Config.MainEntry,
                            (int) Config.JitFlag);
                        ActionNotificationCenter.DefaultCenter.AddObserver(BaseContextDataModel.CodeHook.Value.OnEvent,
                            nameof(ActionParameterDataType.OnEvent));
                    }

                    break;
                case ProgrammableType.VisualScripting:

                    var tmp_Result = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                        nameof(ActionParameterDataType.TryAcquireLoadObject), new LoadObjectArgs()
                        {
                            LoadObjectType = typeof(GameObject),
                            LoadObjectName = new List<string>() {Config.MainVisualScripting}
                        });
                    if (tmp_Result != null || tmp_Result.Count > 0)
                    {
                        if (tmp_Result[0] is Task<List<Object>> tmp_TempTask)
                        {
                            var tmp_Results = await tmp_TempTask;
                            if (tmp_Results[0] is GameObject tmp_GameObject)
                            {
                                BaseContextDataModel.VisualScriptingGo = Object.Instantiate(tmp_GameObject);
                            }
                        }
                    }

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Release(string _projectName = null)
        {
            BaseContextDataModel.CodeHook.Value.Dispose(_projectName); 
        }
    }
}