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

using System;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    /// <summary>
    /// Command that facilitates acquiring the custom configuration JSON associated with the current project's launch.
    /// Subscribes to the <c>TryAcquireCustomConfig</c> action notification.
    /// </summary>
    public class BuildTryAcquireLaunchConfigCommand : ICommand, IReleaseCommand
    {
        public BuildTryAcquireLaunchConfigCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireCustomConfig,
                nameof(ActionParameterDataType.TryAcquireCustomConfig));
        }

        public void Release(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(
                nameof(ActionParameterDataType.TryAcquireCustomConfig));
        }

        private string TryAcquireCustomConfig(BaseNotificationData _notification)
        {
            return IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value.customConfig.config;
        }
    }
}