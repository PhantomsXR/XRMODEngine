// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VisionOSModule.Runtime.
// //
// // The AVPPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class BuildDynamicLibraryCommand: ICommand, IReleaseCommand
    {
        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(AddNewTrackingImage,
                nameof(ActionParameterDataType.AddNewImageForTracking));
        }

        public void Release(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(
                nameof(ActionParameterDataType.AddNewImageForTracking));
        }

        private void AddNewTrackingImage(BaseNotificationData _baseNotification)
        {
            if (_baseNotification is DynamicLibraryArgs tmp_Data)
                new VisionOSDynamicLibraryDecorator(tmp_Data.Images, tmp_Data.NotificationAct).StartAlgorithm();
        }
    }

}