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
    /// Command to build and initialize the plane detection feature for Rokid devices.
    /// </summary>
    public class BuildPlaneDetectFeatureCommand : BaseBuildFeature<PlaneDetectorFeature>, ICommand, IReleaseCommand
    {
        /// <summary>
        /// Executes the command to create the plane detector feature.
        /// </summary>
        public void Execute()
        {
            base.Create();
        }

        /// <summary>
        /// Releases the plane detector feature.
        /// </summary>
        /// <param name="_projectName">Optional project name (unused).</param>
        public void Release(string _projectName = default)
        {
            base.ReleaseFeature();
        }
    }
}