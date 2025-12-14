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
    public class BuildVisionOSCheckARFeaturesAvailabilityCommand: ICommand, IReleaseCommand
    {
        public BuildVisionOSCheckARFeaturesAvailabilityCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(CheckARFeaturesAvailabilityObserver,
                nameof(ActionParameterDataType.CheckARFeaturesAvailability));
        }

        public void Release(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType
                .CheckARFeaturesAvailability));
        }

        /// <summary>
        /// Check AR features is support on this device.
        /// </summary>
        /// <param name="_base">feature module name</param>
        /// <returns>True or False</returns>
        private string CheckARFeaturesAvailabilityObserver(BaseNotificationData _base)
        {
            return IocContainer.GetIoc.Resolve<VisionOSAlgorithmUtility>().FeatureAvailability(_base.BaseData).ToString();
        }
    }

}