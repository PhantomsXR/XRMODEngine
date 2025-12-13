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
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    /// <summary>
    ///  Send message from xr-experience to sdk
    /// </summary>
    public class BuildSendMessageToSDKCommand : ICommand, IReleaseCommand
    {
        public BuildSendMessageToSDKCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(SendMessageToSDK,
                nameof(ActionParameterDataType.SendMessageToSDK));
        }

        public void Release(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.SendMessageToSDK));
        }


        private void SendMessageToSDK(BaseNotificationData _notification)
        {
            APICallback.SendMessageToSDK(_notification.BaseData);
        }
    }
}