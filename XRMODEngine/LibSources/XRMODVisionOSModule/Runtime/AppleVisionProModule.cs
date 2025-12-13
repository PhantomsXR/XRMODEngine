// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VisionOSModule.Runtime.
// //
// // The AVPPlatform cannot be copied, distributed, or made available to
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
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;
using UnityEngine.Scripting;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    [Preserve]
    public class AppleVisionProModule : IModule
    {
        readonly RuntimeExperienceConfig configures = IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>();

        public AppleVisionProModule()
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
            throw new System.NotImplementedException();
        }

        public bool StopModule()
        {
            IocContainer.GetIoc.UnRegister<BuildVisionOSAnchorCommand>();
            IocContainer.GetIoc.UnRegister<BuildVisionOSARAvailabilityCommand>();
            IocContainer.GetIoc.UnRegister<BuildVisionOSImageTrackCommand>();
            IocContainer.GetIoc.UnRegister<BuildVisionOSPlaneDetector>();
            IocContainer.GetIoc.UnRegister<BuildVisionOSCheckARFeaturesAvailabilityCommand>();
            IocContainer.GetIoc.UnRegister<BuildVisionOSARAlgorithmLifeControllerCommand>();
            IocContainer.GetIoc.UnRegister<VisionOSAlgorithmUtility>();
            IocContainer.GetIoc.UnRegister<BuildVolumeCameraCommand>();
            IocContainer.GetIoc.UnRegister<BuildVisionOSMeshingCommand>();
            IocContainer.GetIoc.UnRegister<BuildVisionOSFocusSlamCommand>();
            IocContainer.GetIoc.UnRegister<BuildScriptRuntimeEnvironmentCommand>();

            IocContainer.GetIoc.UnRegister<InitializeARComponentCommand>();
            IocContainer.GetIoc.UnRegister<ARComponentModel>();
            IocContainer.GetIoc.UnRegister<ARContextDataModel>();

            ActionNotificationCenter.DefaultCenter.Release();


            return true;
        }

        public bool IsModuleAvailability()
        {
            return true;
        }

        public void MakeSureDependencies()
        {
            IocContainer.GetIoc.Register(new ARContextDataModel());
            IocContainer.GetIoc.Register(new ARComponentModel());

            IocContainer.GetIoc.Register(new InitializeARComponentCommand());
            IocContainer.GetIoc.Register(new BuildVisionOSFocusSlamCommand());
            IocContainer.GetIoc.Register(new BuildVisionOSAnchorCommand());
            IocContainer.GetIoc.Register(new BuildVisionOSARAvailabilityCommand());
            IocContainer.GetIoc.Register(new BuildVisionOSImageTrackCommand());
            IocContainer.GetIoc.Register(new BuildVisionOSPlaneDetector());
            IocContainer.GetIoc.Register(new BuildVisionOSCheckARFeaturesAvailabilityCommand());
            IocContainer.GetIoc.Register(new BuildVisionOSARAlgorithmLifeControllerCommand());
            IocContainer.GetIoc.Register(new VisionOSAlgorithmUtility());
            IocContainer.GetIoc.Register(new BuildVolumeCameraCommand());
            IocContainer.GetIoc.Register(new BuildVisionOSMeshingCommand());
        }

        private void OnConfigUpdated(IModel _config)
        {
            if (!CheckConfig(_config)) return;
            if (configures.CurrentConfigures.Value.SDKDeviceType != SDKDeviceType.VisionOS)
            {
                string tmp_LogInfo = "This experience is not available for this device.";
                APICallback.ThrowException(tmp_LogInfo, -1);
                Debug.LogError(tmp_LogInfo);
                return;
            }
            
            AddFeatureDecorator(configures.CurrentConfigures.Value as ARConfiguresModel);
            MakeSureAlgorithm(configures.CurrentConfigures.Value.Algorithm);
        }

        private void MakeSureAlgorithm(AlgorithmType _arAlgorithmType)
        {
            ICommand tmp_ARFeatureCommand = null;
            switch (_arAlgorithmType)
            {
                case AlgorithmType.FocusSlam:
                    tmp_ARFeatureCommand = IocContainer.GetIoc.Resolve<BuildVisionOSFocusSlamCommand>();
                    break;
                case AlgorithmType.Anchor:
                    tmp_ARFeatureCommand = IocContainer.GetIoc.Resolve<BuildVisionOSAnchorCommand>();
                    break;

                case AlgorithmType.ImageTracker:
                    tmp_ARFeatureCommand = IocContainer.GetIoc.Resolve<BuildVisionOSImageTrackCommand>();
                    break;
                case AlgorithmType.Meshing:
                    IocContainer.GetIoc.Resolve<BuildVisionOSMeshingCommand>().Execute();
                    break;
                case AlgorithmType.Gyro:
                case AlgorithmType.Fixed:
                case AlgorithmType.Classic3D:
                    Debug.Log($"Current [{_arAlgorithmType}] algorithm is not supported.");
                    break;
            }


            var tmp_AutoStart = IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.Value
                .AlgorithmAutoStart;
            if (tmp_AutoStart)
            {
                tmp_ARFeatureCommand?.Execute();
            }
        }

        private void AddFeatureDecorator(ARConfiguresModel _config)
        {
            if (_config.Algorithm is AlgorithmType.Classic3D
                or AlgorithmType.Fixed
                or AlgorithmType.Immersal
                or AlgorithmType.FaceMesh
                or AlgorithmType.Gyro) return;

            IocContainer.GetIoc.Resolve<InitializeARComponentCommand>().Execute();

            if (!string.IsNullOrEmpty(_config.CustomPlaneVisualizerName) &&
                _config.Algorithm == AlgorithmType.FocusSlam)
            {
                IocContainer.GetIoc.Resolve<BuildVisionOSPlaneDetector>().Execute();
            }

            IocContainer.GetIoc.Resolve<BuildVolumeCameraCommand>().Execute();
        }


        private bool CheckConfig(IModel _config)
        {
            if (_config is ARConfiguresModel _) return true;
            configures.CurrentConfigures.OnValueChanged -= OnConfigUpdated;
            if (configures == null || string.IsNullOrEmpty(configures.MetaData)) return false;
            configures.CurrentConfigures.Value =
                JsonUtility.FromJson<ARConfiguresModel>(configures.MetaData);
            return true;
        }


        /// <summary>
        /// Remove the features for a given experience. 
        /// </summary>
        /// <param name="_data"></param>
        private void RemoveFeatureDecorators(BaseNotificationData _data)
        {
            try
            {
                var tmp_ARContextData = IocContainer.GetIoc.Resolve<ARContextDataModel>();
                var tmp_ProjectName = _data.BaseData;

                if (string.IsNullOrEmpty(tmp_ProjectName))
                {
                    Debug.LogError("Can not removed feature. Because project name is empty.");
                    return;
                }

                if (tmp_ARContextData.FeatureDecoratorsAtRuntime.TryGetValue(tmp_ProjectName,
                        out var tmp_FeatureDecorator))
                {
                    foreach (IFeatureDecorator tmp_Decorator in tmp_FeatureDecorator)
                    {
                        tmp_Decorator.StopAlgorithm();
                    }

                    var tmp_Trackables = GameObject.Find("Trackables").transform;
                    var tmp_TrackableNodes = tmp_Trackables.GetComponentsInChildren<Transform>();
                    for (int tmp_Idx = 1; tmp_Idx < tmp_TrackableNodes.Length; tmp_Idx++)
                    {
                        tmp_TrackableNodes[tmp_Idx].DestroyWithPlatform();
                    }
                }

                // TODO: 未来Unity支持多个Volume时这里不应当如此草率的注销脚本运行环境。理应按照每个项目不同而进行注销。
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