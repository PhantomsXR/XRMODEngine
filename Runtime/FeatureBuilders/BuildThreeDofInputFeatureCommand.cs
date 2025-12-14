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
    public class BuildThreeDofInputFeatureCommand: BaseBuildFeature<ThreeDRayInteractorFeature>, ICommand, IReleaseCommand
    {
        public void Execute()
        {
            base.Create();
        }

        public void Release(string _projectName = default)
        {
            base.ReleaseFeature();
        }
    }
}