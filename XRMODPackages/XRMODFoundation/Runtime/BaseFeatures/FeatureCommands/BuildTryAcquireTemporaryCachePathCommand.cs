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

using System.IO;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    /// <summary>
    /// Command that returns the path to the temporary cache directory used by XRMOD for storing downloaded assets.
    /// Subscribes to the <c>TryAcquireTemporaryCachePath</c> action notification.
    /// </summary>
    public class BuildTryAcquireTemporaryCachePathCommand : ICommand, IReleaseCommand
    {
        public BuildTryAcquireTemporaryCachePathCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireTemporaryCachePath,
                nameof(ActionParameterDataType.TryAcquireTemporaryCachePath));
        }

        private string TryAcquireTemporaryCachePath(BaseNotificationData _baseNotificationData)
        {
            return Path.Combine(Application.temporaryCachePath, "XRMODEngine");
        }

        public void Release(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType
                .TryAcquireTemporaryCachePath));
        }
    }
}