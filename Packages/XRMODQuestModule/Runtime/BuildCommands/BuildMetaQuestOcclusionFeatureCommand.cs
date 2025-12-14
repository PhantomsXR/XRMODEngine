// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.QuestModule.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    public class BuildMetaQuestOcclusionFeatureCommand : BaseBuildFeature<MetaQuestOcclusionDecorator>, ICommand,
        IReleaseCommand
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