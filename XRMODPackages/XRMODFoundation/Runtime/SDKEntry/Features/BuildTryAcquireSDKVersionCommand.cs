// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.SDKEntry.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.Models;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    /// <summary>
    /// Command that provides the current version of the XRMOD SDK.
    /// Subscribes to the <c>TryAcquireSDKVersion</c> action notification.
    /// </summary>
    public class BuildTryAcquireSDKVersionCommand : ICommand, IReleaseCommand
    {
        public BuildTryAcquireSDKVersionCommand()
        {
            Execute();
        }
        
        /// <summary>
        /// Get current sdk version
        /// </summary>
        /// <param name="_base"></param>
        /// <returns>sdk version string</returns>
        private string TryAcquireSDKVersionObserver(BaseNotificationData _base)
        {
            return IocContainer.GetIoc.Resolve<SDKEntryPointModel>().SdkVersion.Value;
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireSDKVersionObserver,
                nameof(ActionParameterDataType.TryAcquireSDKVersion));
        }

        public void Release(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.TryAcquireSDKVersion));
        }
    }
}