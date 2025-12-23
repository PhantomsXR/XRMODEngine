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
#if ENABLE_IMMERSAL
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    /// <summary>
    /// Command to build and initialize the Immersal feature for Rokid devices.
    /// Configures the Immersal context with settings from the project configuration.
    /// </summary>
    public class BuildImmersalFeatureCommand : BaseBuildFeature<ImmersalFeature>, ICommand, IReleaseCommand
    {
        /// <summary>
        /// Executes the command to create the Immersal feature.
        /// Extracts Immersal parameters from the current configuration and initializes the context.
        /// </summary>
        public void Execute()
        {
            if (IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.Value is not
                RokidConfiguresModel tmp_Config) return;

            IocContainer.GetIoc.Resolve<RokidContextDataModel>().ImmersalParameters = new ImmersalContextDataModel
            {
                DeveloperToken = tmp_Config.DeveloperToken,
                AutoStart = tmp_Config.AutoStart,
                UseFiltering = tmp_Config.UseFiltering,
                LocalizationInterval = tmp_Config.LocalizationInterval,
                UseServerLocalizer = tmp_Config.UseServerLocalizer,
                BurstMode = tmp_Config.BurstMode,
                StopLocalizedAfterSuccess = tmp_Config.StopLocalizedAfterSuccess
            };

            base.Create();
        }

        /// <summary>
        /// Releases the Immersal feature and cleans up resources.
        /// </summary>
        /// <param name="_projectName">Optional project name (unused).</param>
        public void Release(string _projectName = default)
        {
            base.ReleaseFeature();
        }
    }
}
#endif