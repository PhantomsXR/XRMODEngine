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
    public class MetaQuestModule : IModule
    {
        readonly RuntimeExperienceConfig configures = IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>();

        public MetaQuestModule()
        {
            configures.CurrentConfigures.OnValueChanged += OnConfigUpdated;
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

        public bool IsModuleAvailability()
        {
            return true;
        }

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
        /// Remove the features for a given experience. 
        /// </summary>
        /// <param name="_data"></param>
        private void RemoveFeatureDecorators(BaseNotificationData _data)
        {
            var tmp_ProjectName = _data.BaseData;

            if (string.IsNullOrEmpty(tmp_ProjectName))
            {
                Debug.LogError("Can not removed feature. Because project name is empty.");
                return;
            }
        }

        private bool CheckConfig(IModel _config)
        {
            if (_config is XRConfiguresModel _) return true;
            configures.CurrentConfigures.OnValueChanged -= OnConfigUpdated;
            if (configures == null || string.IsNullOrEmpty(configures.MetaData)) return false;
            configures.CurrentConfigures.Value =
                JsonUtility.FromJson<XRConfiguresModel>(configures.MetaData);
            return true;
        }

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