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
    /// <summary>
    /// Command to build and initialize the Meta Quest Mixed Reality feature.
    /// <para>
    /// This command creates an instance of <see cref="MetaQuestMRFeatureDecorator"/> to enable mixed reality capabilities like passthrough.
    /// </para>
    /// </summary>
    public class BuildMetaQuestMRFeatureCommand : BaseBuildFeature<MetaQuestMRFeatureDecorator>, ICommand,
        IReleaseCommand
    {
        /// <summary>
        /// Executes the command to create the feature.
        /// </summary>
        public void Execute()
        {
            base.Create();
        }

        /// <summary>
        /// Releases the feature.
        /// </summary>
        /// <param name="_projectName">Optional project name context.</param>
        public void Release(string _projectName = default)
        {
            base.ReleaseFeature();
        }
    }
}