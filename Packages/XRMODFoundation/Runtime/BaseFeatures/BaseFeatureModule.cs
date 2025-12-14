// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Assembly-CSharp.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.BaseFeatures.Runtime.Models;
using Phantom.XRMOD.Models.Runtime;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    public class BaseFeatureModule : IModule
    {
        public BaseFeatureModule()
        {
            IocContainer.GetIoc.Register(new BaseFeatureModel());
            IocContainer.GetIoc.Register(new BuildGltfLoaderCommand());
            IocContainer.GetIoc.Register(new BuildEventSystemCommand());
            IocContainer.GetIoc.Register(new BuildGraphQualityCommand());
            IocContainer.GetIoc.Register(new BuildPostProcessingCommand());
            IocContainer.GetIoc.Register(new BuildProcessesManagerCommand());
            IocContainer.GetIoc.Register(new BuildSendMessageToSDKCommand());
            IocContainer.GetIoc.Register(new BuildOpenBuiltInBrowserCommand());
            IocContainer.GetIoc.Register(new BuildRuntimeDebugConsoleCommand());
            IocContainer.GetIoc.Register(new BuildNetworkMeshDownloadCommand());
            IocContainer.GetIoc.Register(new BuildTryAcquireLoadObjectCommand());
            IocContainer.GetIoc.Register(new BuildTryAcquireProjectInfoCommand());
            IocContainer.GetIoc.Register(new BuildTryAcquireInformationCommand());
            IocContainer.GetIoc.Register(new BuildScriptRuntimeEnvironmentCommand());
            IocContainer.GetIoc.Register(new BuildTryAcquireTemporaryCachePathCommand());
        }

        private void DisposeModule()
        {
            try
            {
                IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.OnValueChanged = null;

                IocContainer.GetIoc.UnRegister<BaseFeatureModel>();
                IocContainer.GetIoc.UnRegister<BuildGltfLoaderCommand>();
                // Will cause a crash. Crash Log:
                // ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                // IocContainer.GetIoc.UnRegister<BuildEventSystemCommand>();
                IocContainer.GetIoc.UnRegister<BuildGraphQualityCommand>();
                IocContainer.GetIoc.UnRegister<BuildPostProcessingCommand>();
                IocContainer.GetIoc.UnRegister<BuildProcessesManagerCommand>();
                IocContainer.GetIoc.UnRegister<BuildOpenBuiltInBrowserCommand>();

                IocContainer.GetIoc.UnRegister<BuildSendMessageToSDKCommand>();

                IocContainer.GetIoc.UnRegister<BuildRuntimeDebugConsoleCommand>();
                IocContainer.GetIoc.UnRegister<BuildTryAcquireProjectInfoCommand>();
                IocContainer.GetIoc.UnRegister<BuildTryAcquireLoadObjectCommand>();
                IocContainer.GetIoc.UnRegister<BuildTryAcquireInformationCommand>();
                IocContainer.GetIoc.UnRegister<BuildTryAcquireTemporaryCachePathCommand>();

                IocContainer.GetIoc.UnRegister<BuildScriptRuntimeEnvironmentCommand>();
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                throw;
            }
        }

        public bool StartModule()
        {
            var tmp_Config = IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.Value;
            if (tmp_Config.PostProcessing)
            {
                IocContainer.GetIoc.Resolve<BuildPostProcessingCommand>().Execute();
            }

            if (tmp_Config.DebugModel)
            {
                IocContainer.GetIoc.Resolve<BuildRuntimeDebugConsoleCommand>().Execute();
            }

            IocContainer.GetIoc.Resolve<BuildGraphQualityCommand>().Execute();
            IocContainer.GetIoc.Resolve<BuildScriptRuntimeEnvironmentCommand>().Execute();
            return true;
        }

        public bool PauseModule()
        {
            throw new System.NotImplementedException();
        }

        public bool StopModule()
        {
            DisposeModule();
            return true;
        }

        public bool IsModuleAvailability()
        {
            return true;
        }

        void IModule.MakeSureDependencies()
        {
            throw new NotImplementedException();
        }
    }
}