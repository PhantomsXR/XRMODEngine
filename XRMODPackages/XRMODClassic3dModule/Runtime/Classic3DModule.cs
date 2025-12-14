// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Classic3D.Runtime.
// //
// // The DedicatedServerPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.BaseFeatures.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Core.Runtime.Enums;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.Classic3D.Runtime
{
    public class Classic3DModule : IModule
    {
        public Classic3DModule()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(_data =>
            {
                // Avoid executing features within a module before initializing base features
                IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.OnValueChanged +=
                    OnConfigUpdated;

                //Re-parse the json string to runtime project config,
                //if not re-parse the RuntimeProjectConfig type is BaseProjectConfigModel
                var tmp_Configures = IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>();
                tmp_Configures.CurrentConfigures.Value =
                    JsonUtility.FromJson<BaseExperienceConfigModel>(tmp_Configures.MetaData);
            }, nameof(ActionParameterDataType.OnXRDataGot));

            ActionNotificationCenter.DefaultCenter.AddObserver(RemoveFeatureDecorators,
                nameof(ActionParameterDataType.RemoveFeatures));
            MakeSureDependencies();
        }

        public bool StartModule()
        {
            try
            {
                ActionNotificationCenter.DefaultCenter.PostNotification(
                    nameof(ActionParameterDataType.FetchProjectDetail),
                    new BaseNotificationData());


                return true;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                return false;
            }
        }

        public bool PauseModule()
        {
            return true;
        }

        public bool StopModule()
        {
            ActionNotificationCenter.DefaultCenter.Release();
            return true;
        }

        public bool IsModuleAvailability()
        {
            return true;
        }

        public void MakeSureDependencies()
        {
        }


        private void OnConfigUpdated(IModel _config)
        {
            if (_config is not BaseExperienceConfigModel tmp_Config) return;

            if (tmp_Config.SDKDeviceType != SDKDeviceType.Classic3D)
            {
                string tmp_LogInfo = "This experience is not available for this device.";
                APICallback.ThrowException(tmp_LogInfo, -1);
                Debug.LogError(tmp_LogInfo);
                return;
            }
        }

        private void RemoveFeatureDecorators(BaseNotificationData _data)
        {
            try
            {
                var tmp_ProjectName = _data.BaseData;
                IocContainer.GetIoc.Resolve<BuildScriptRuntimeEnvironmentCommand>().Release(tmp_ProjectName);
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                throw;
            }
        }
    }
}