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

using System;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Core.Runtime.Enums;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    /// <summary>
    /// The main module class for Meta Quest support in XR-MOD.
    /// <para>
    /// This class implements the <see cref="IModule"/> interface and is responsible for managing the lifecycle of Quest-specific features
    /// such as Mixed Reality, Occlusion, and Meshing. It listens for configuration changes and initializes the appropriate systems.
    /// </para>
    /// </summary>
    public class MetaQuestModule : IModule
    {
        readonly RuntimeExperienceConfig configures = IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaQuestModule"/> class.
        /// <para>
        /// Subscribes to configuration updates and notification center events.
        /// call <see cref="MakeSureDependencies"/> to register necessary components.
        /// </para>
        /// </summary>
        public MetaQuestModule()
        {
            configures.CurrentConfigures.OnValueChanged += OnConfigUpdated;
            ActionNotificationCenter.DefaultCenter.AddObserver(RemoveFeatureDecorators,
                nameof(ActionParameterDataType.RemoveFeatures));

            MakeSureDependencies();
        }

        /// <summary>
        /// Starts the module.
        /// <para>
        /// Posts a notification to fetch project details.
        /// </para>
        /// </summary>
        /// <returns>True if started successfully, otherwise false.</returns>
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

        /// <summary>
        /// Pauses the module.
        /// </summary>
        /// <returns>Always returns true.</returns>
        public bool PauseModule()
        {
            return true;
        }

        /// <summary>
        /// Stops the module and unregisters dependencies from the IoC container.
        /// </summary>
        /// <returns>Always returns true.</returns>
        public bool StopModule()
        {
            IocContainer.GetIoc.UnRegister<BuildMetaQuestMRFeatureCommand>();
            IocContainer.GetIoc.UnRegister<BuildMetaQuestMeshFeatureCommand>();
            IocContainer.GetIoc.UnRegister<BuildMetaQuestSceneCaptureCommand>();
            IocContainer.GetIoc.UnRegister<BuildMetaQuestOcclusionFeatureCommand>();
            IocContainer.GetIoc.UnRegister<BuildXRAlgorithmLifeControllerCommand>();
            IocContainer.GetIoc.UnRegister<BuildMetaQuestLocomotionFeatureCommand>();
            IocContainer.GetIoc.UnRegister<BuildMetaQuestInteracterSwitcherFeatureCommand>();

            IocContainer.GetIoc.UnRegister<XRRuntimeContextDataModel>();
            IocContainer.GetIoc.UnRegister<ArchitectureComponentsModel>();

            return true;
        }

        /// <summary>
        /// Checks if the module is available on the current platform.
        /// </summary>
        /// <returns>Always returns true.</returns>
        public bool IsModuleAvailability()
        {
            return true;
        }

        /// <summary>
        /// Registers necessary dependencies (Models, Commands, Decorators) into the IoC container.
        /// </summary>
        public void MakeSureDependencies()
        {
            IocContainer.GetIoc.Register(new ArchitectureComponentsModel());
            IocContainer.GetIoc.Register(new XRRuntimeContextDataModel());
            IocContainer.GetIoc.Register(new MetaQuestMeshingDecorator());
            IocContainer.GetIoc.Register(new MetaQuestOcclusionDecorator());
            IocContainer.GetIoc.Register(new BuildMetaQuestMRFeatureCommand());
            IocContainer.GetIoc.Register(new BuildMetaQuestMeshFeatureCommand());
            IocContainer.GetIoc.Register(new BuildMetaQuestSceneCaptureCommand());
            IocContainer.GetIoc.Register(new BuildXRAlgorithmLifeControllerCommand());
            IocContainer.GetIoc.Register(new BuildMetaQuestLocomotionFeatureCommand());
            IocContainer.GetIoc.Register(new BuildMetaQuestInteracterSwitcherFeatureCommand());
        }

        /// <summary>
        /// Callback to remove feature decorators when receiving the 'RemoveFeatures' notification.
        /// </summary>
        /// <param name="_data">Notification data containing the project name.</param>
        private void RemoveFeatureDecorators(BaseNotificationData _data)
        {
            var tmp_ProjectName = _data.BaseData;

            if (string.IsNullOrEmpty(tmp_ProjectName))
            {
                Debug.LogError("Can not removed feature. Because project name is empty.");
                return;
            }
        }

        /// <summary>
        /// Validates and parses the configuration model.
        /// </summary>
        /// <param name="_config">The configuration model to check.</param>
        /// <returns>True if the configuration is valid or updated successfully, false otherwise.</returns>
        private bool CheckConfig(IModel _config)
        {
            if (_config is XRConfiguresModel _) return true;
            configures.CurrentConfigures.OnValueChanged -= OnConfigUpdated;
            if (configures == null || string.IsNullOrEmpty(configures.MetaData)) return false;
            configures.CurrentConfigures.Value =
                JsonUtility.FromJson<XRConfiguresModel>(configures.MetaData);
            return true;
        }

        /// <summary>
        /// Ensures the appropriate algorithm features are executed based on the algorithm type.
        /// </summary>
        /// <param name="_arAlgorithmType">The type of algorithm (e.g., Meshing, Anchor).</param>
        private void MakeSureAlgorithm(AlgorithmType _arAlgorithmType)
        {
            ICommand tmp_XRFeatureCommand = null;

            switch (_arAlgorithmType)
            {
                case AlgorithmType.Anchor:
                    break;


                case AlgorithmType.Immersal:
                    break;

                case AlgorithmType.Meshing:
                    tmp_XRFeatureCommand = IocContainer.GetIoc.Resolve<BuildMetaQuestOcclusionFeatureCommand>();
                    break;
                case AlgorithmType.None: break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_arAlgorithmType), _arAlgorithmType, null);
            }

            tmp_XRFeatureCommand?.Execute();
        }

        /// <summary>
        /// Adds feature decorators based on the configuration (e.g., Mixed Reality, Occlusion).
        /// </summary>
        /// <param name="_config">The Quest configuration model.</param>
        private void AddFeatureDecorator(XRConfiguresModel _config)
        {
            if (_config.MixedReality)
            {
                IocContainer.GetIoc.Resolve<BuildMetaQuestMRFeatureCommand>().Execute();
            }

            if (_config.UseOcclusion)
            {
                IocContainer.GetIoc.Resolve<BuildMetaQuestOcclusionFeatureCommand>().Execute();
            }
        }

        /// <summary>
        /// Callback invoked when the module configuration is updated.
        /// <para>
        /// Updates the current configuration value, checks device compatibility, and establishes feature decorators and algorithms.
        /// </para>
        /// </summary>
        /// <param name="_config">The updated configuration model.</param>
        private void OnConfigUpdated(BaseExperienceConfigModel _config)
        {
            if (!CheckConfig(_config)) return;
            if (configures.CurrentConfigures.Value.SDKDeviceType != SDKDeviceType.Quest)
            {
                string tmp_LogInfo = "This experience is not available for this device.";
                APICallback.ThrowException(tmp_LogInfo, -1);
                Debug.LogError(tmp_LogInfo);
                return;
            }

            AddFeatureDecorator(configures.CurrentConfigures.Value as XRConfiguresModel);
            MakeSureAlgorithm(configures.CurrentConfigures.Value.Algorithm);
        }
    }
}