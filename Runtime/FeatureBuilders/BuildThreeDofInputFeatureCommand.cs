// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.RokidModule.Runtime.
// //
// // The RokidPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    /// <summary>
    /// Command to build and initialize 3-DOF ray interaction for Rokid devices.
    /// </summary>
    public class BuildThreeDofInputFeatureCommand: BaseBuildFeature<ThreeDRayInteractorFeature>, ICommand, IReleaseCommand
    {
        /// <summary>
        /// Executes the command to create the 3-DOF ray interactor feature.
        /// </summary>
        public void Execute()
        {
            base.Create();
        }

        /// <summary>
        /// Releases the 3-DOF ray interactor feature.
        /// </summary>
        /// <param name="_projectName">Optional project name (unused).</param>
        public void Release(string _projectName = default)
        {
            base.ReleaseFeature();
        }
    }
}