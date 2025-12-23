// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.RokidModule.Runtime.
// //
// // The RokidPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if ROKID_INSTALL
using System;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Core.Runtime.Enums;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.XRMODInput.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
#if ROKID_UXR_INSTALL
using Rokid.UXR.Native;
#endif
using UnityEngine;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    /// <summary>
    /// The main entry point for the Rokid module integration in XRMOD.
    /// Manages lifecycle, feature activation, input switching, and configuration updates for Rokid devices.
    /// </summary>
    public class RokidModule : IModule
    {
        private const string CONST_SWITH_INPUT_KEY = "SwitchInput";

        /// <summary>
        /// Initializes a new instance of the <see cref="RokidModule"/>.
        /// Sets up observers for dependency registration, input switching, and configuration data.
        /// </summary>
        public RokidModule()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver((_data) => { MakeSureDependencies(); },
                nameof(ActionParameterDataType.RegisterExtraCLR));
            ActionNotificationCenter.DefaultCenter.AddObserver(OnSwitchInputType, CONST_SWITH_INPUT_KEY);

            ActionNotificationCenter.DefaultCenter.AddObserver(_data =>
            {
                //Re-parse the json string to runtime project config,
                //if not re-parse the RuntimeProjectConfig type is BaseProjectConfigModel
                var tmp_Configures = IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>();
                tmp_Configures.CurrentConfigures.Value =
                    JsonUtility.FromJson<RokidConfiguresModel>(tmp_Configures.MetaData);
            }, nameof(ActionParameterDataType.OnXRDataGot));

            MakeSureFeatures();

            IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.OnValueChanged +=
                OnConfigUpdated;

            if (IsStationPro())
            {
                OnSwitchInputType(new BaseNotificationData()
                {
                    ObjectData = nameof(InputType.NatureHands)
                });
            }
            else
            {
                OnSwitchInputType(new BaseNotificationData()
                {
                    ObjectData = nameof(InputType.ThreeDofRay)
                });
            }
        }


        /// <summary>
        /// Starts the Rokid module.
        /// Triggers the project detail fetch notification.
        /// </summary>
        /// <returns>True if started successfully.</returns>
        public bool StartModule()
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.FetchProjectDetail),
                new BaseNotificationData());


            return true;
        }


        /// <summary>
        /// Pauses the module. Currently not implemented.
        /// </summary>
        /// <returns>Always false.</returns>
        public bool PauseModule()
        {
            return false;
        }

        /// <summary>
        /// Stops the module and releases resources.
        /// Unregisters features and event listeners.
        /// </summary>
        /// <returns>Always false.</returns>
        public bool StopModule()
        {
            IocContainer.GetIoc.Resolve<BuildNatureHandInputFeatureCommand>().Release();
            IocContainer.GetIoc.Resolve<BuildThreeDofInputFeatureCommand>().Release();
#if ENABLE_IMMERSAL
            IocContainer.GetIoc.Resolve<BuildImmersalFeatureCommand>().Release();
#endif
            IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.OnValueChanged -=
                OnConfigUpdated;
            IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.Value = null;
            return false;
        }

        /// <summary>
        /// Checks if the module is available on the current platform.
        /// </summary>
        /// <returns>True if available.</returns>
        public bool IsModuleAvailability()
        {
            return true;
        }

        /// <summary>
        /// Ensures all necessary dependencies are registered.
        /// </summary>
        public void MakeSureDependencies()
        {
        }


        private void OnConfigUpdated(IModel _config)
        {
            if (_config is not RokidConfiguresModel tmp_Config) return;
            if (tmp_Config.SDKDeviceType != SDKDeviceType.Rokid)
            {
                string tmp_LogInfo = "This experience is not available for this device.";
                APICallback.ThrowException(tmp_LogInfo, -1);
                Debug.LogError(tmp_LogInfo);
                return;
            }

            ActivateRuntimeFeatures(tmp_Config);
        }

        private void ActivateRuntimeFeatures(BaseExperienceConfigModel _config)
        {
            if (IsStationPro() || Application.isEditor)
            {
                OnSwitchInputType(new BaseNotificationData()
                {
                    ObjectData = nameof(InputType.NatureHands)
                });
#if ENABLE_IMMERSAL
                if (_config.Algorithm == AlgorithmType.Immersal)
                {
                    IocContainer.GetIoc.Resolve<BuildImmersalFeatureCommand>().Execute();
                }
#endif
            }
            else
            {
                OnSwitchInputType(new BaseNotificationData()
                {
                    ObjectData = nameof(InputType.ThreeDofRay)
                });
            }
        }

        private static bool IsStationPro()
        {
            return SystemInfo.deviceModel.ToLower().Contains("stationpro");
        }

        private void OnSwitchInputType(BaseNotificationData _baseNotification)
        {
            if (!Enum.TryParse<InputType>(_baseNotification.ObjectData.ToString(), out var tmp_InputType)) return;

            switch (tmp_InputType)
            {
                case InputType.NatureHands:
                    IocContainer.GetIoc.Resolve<BuildNatureHandInputFeatureCommand>().Execute();
                    break;
                case InputType.TouchScreen:
                    break;
                case InputType.ThreeDofRay:
                    IocContainer.GetIoc.Resolve<BuildThreeDofInputFeatureCommand>().Execute();
                    break;
            }
        }


        private void MakeSureFeatures()
        {
            if (IocContainer.GetIoc.Resolve<RokidContextDataModel>() == null)
                IocContainer.GetIoc.Register(new RokidContextDataModel());

            if (IocContainer.GetIoc.Resolve<BuildThreeDofInputFeatureCommand>() == null)
                IocContainer.GetIoc.Register(new BuildThreeDofInputFeatureCommand());
            if (IocContainer.GetIoc.Resolve<BuildNatureHandInputFeatureCommand>() == null)
                IocContainer.GetIoc.Register(new BuildNatureHandInputFeatureCommand());
#if ENABLE_IMMERSAL
            if (IocContainer.GetIoc.Resolve<BuildImmersalFeatureCommand>() == null)
                IocContainer.GetIoc.Register(new BuildImmersalFeatureCommand());
#endif
            if (IocContainer.GetIoc.Resolve<BuildPlaneDetectFeatureCommand>() == null)
                IocContainer.GetIoc.Register(new BuildPlaneDetectFeatureCommand());
        }
    }
}

#endif