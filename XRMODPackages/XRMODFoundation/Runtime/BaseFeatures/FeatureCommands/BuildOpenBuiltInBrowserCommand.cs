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
    /// <summary>
    /// Command that enables opening URLs in the platform's built-in web browser or a customized in-app browser.
    /// Subscribes to the <c>OpenBuiltInBrowser</c> action notification.
    /// </summary>
    public class BuildOpenBuiltInBrowserCommand : ICommand, IReleaseCommand
    {
        public BuildOpenBuiltInBrowserCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(OpenBuiltInBrowserObserver,
                nameof(ActionParameterDataType.OpenBuiltInBrowser));
        }

        public void Release(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.OpenBuiltInBrowser));
        }

        /// <summary>
        /// Open Builtin browser observer
        /// </summary>
        /// <param name="_data">url</param>
        private void OpenBuiltInBrowserObserver(BaseNotificationData _data)
        {
            if (!(_data is OpenInBuiltInBrowserArgs tmp_OpenBuiltInNotificationData)) return;
            APICallback.OpenBuiltInBrowser(tmp_OpenBuiltInNotificationData.Url);
            _data.NotificationAct?.Invoke();
        }
    }
}