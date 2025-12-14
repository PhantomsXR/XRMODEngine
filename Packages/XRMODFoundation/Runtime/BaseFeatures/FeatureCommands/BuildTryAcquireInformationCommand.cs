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

using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    public class BuildTryAcquireInformationCommand : ICommand, IReleaseCommand
    {
        public BuildTryAcquireInformationCommand()
        {
            Execute();
        }
        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireInformation,
                nameof(ActionParameterDataType.TryAcquireAppInfo));
        }

        public void Release(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.TryAcquireAppInfo));
        }

        /// <summary>
        /// Try acquire the native info. e.g. user info or device unique id
        /// </summary>
        /// <param name="_notificationData">operation tag</param>
        /// <returns></returns>
        private void TryAcquireInformation(BaseNotificationData _notificationData)
        {
            if (!(_notificationData is TryAcquireAppInfoArgs tmp_TryAcquireAppInfoNotificationData))
                return;
            APICallback.TryAcquireInformation(tmp_TryAcquireAppInfoNotificationData.GetInfoType,
                _data => { _notificationData.NotificationActWithData.Invoke(_data); });
        }
    }
}