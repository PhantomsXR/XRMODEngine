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

using Phantom.XRMOD.Models.Runtime;
using UnityEngine.Assertions;
using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    /// <summary>
    /// Base class for commands that requires access to core XRMOD configurations and context data.
    /// Provides helper methods for resolving common dependencies from the Ioc Container.
    /// </summary>
    public abstract class AbstractCommand
    {
        /// <summary> The base experience configuration (e.g., tracking settings, quality level). </summary>
        protected BaseExperienceConfigModel Config;
        /// <summary> The runtime configuration management component. </summary>
        protected RuntimeExperienceConfig RuntimeExperienceConfig;
        /// <summary> Core context data model for localization and state tracking. </summary>
        protected BaseContextDataModel BaseContextDataModel;
        private bool initialized;
        
        protected virtual void Initializer()
        {
            if (initialized) return;
            ARContext();
            ARConfig();
            initialized = true;
        }

        private void ARConfig()
        {
            Config = RuntimeExperienceConfig.CurrentConfigures.Value;
            Assert.IsNotNull(Config);
        }

        private void ARContext()
        {
            RuntimeExperienceConfig = IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>();
            Assert.IsNotNull(RuntimeExperienceConfig);

            BaseContextDataModel = IocContainer.GetIoc.Resolve<BaseContextDataModel>();
            Assert.IsNotNull(BaseContextDataModel);

        }
    }
}