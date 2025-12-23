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
using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    /// <summary>
    /// Command that applies the project-level graphical quality settings to the Unity engine.
    /// Inherits from <see cref="AbstractCommand"/> to access project configuration.
    /// </summary>
    public class BuildGraphQualityCommand : AbstractCommand, ICommand, IReleaseCommand
    {
        public void Execute()
        {
            base.Initializer();
            if (QualitySettings.GetQualityLevel() == Config.QualityLevel)
                return;
            QualitySettings.SetQualityLevel(Config.QualityLevel, true);
        }

        public void Release(string _projectName = null)
        {
            QualitySettings.SetQualityLevel(0, true); 
        }
    }
}