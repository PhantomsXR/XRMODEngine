// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the BaseFeaturesModule.Runtime.
// //
// // The XRMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.BaseFeatures.Runtime.Models;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;
using UnityEngine.Assertions;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    /// <summary>
    /// Core command that manages the lifecycle of multiple XR projects/processes.
    /// It handles process registration, space type switching (Shared vs Exclusive),
    /// and clean release of project assets and memory.
    /// </summary>
    public class BuildProcessesManagerCommand : ICommand, IReleaseCommand
    {
        private readonly List<ProcessIdComponent> allProcesses;

        public BuildProcessesManagerCommand()
        {
            allProcesses = new List<ProcessIdComponent>();
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(ReleaseProject,
                nameof(ActionParameterDataType.ReleaseProject));
            ActionNotificationCenter.DefaultCenter.AddObserver(AddNewProcess,
                nameof(ActionParameterDataType.AddNewProcess));
            ActionNotificationCenter.DefaultCenter.AddObserver(GetAllProcesses,
                nameof(ActionParameterDataType.GetAllProcesses));
            ActionNotificationCenter.DefaultCenter.AddObserver(OnSpaceTypeChange,
                nameof(ActionParameterDataType.SwitchSpaceType));
            ActionNotificationCenter.DefaultCenter.AddObserver(GetSpaceType,
                nameof(ActionParameterDataType.GetSpaceType));
        }

        public void Release(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.AddNewProcess));
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.GetAllProcesses));
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.ReleaseProject));
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.SwitchSpaceType));
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.GetSpaceType));
        }

        private Dictionary<string, List<string>> GetAllProcesses(BaseNotificationData _notification)
        {
            var tmp_BaseFeatureModel = IocContainer.GetIoc.Resolve<BaseFeatureModel>();
            return tmp_BaseFeatureModel.Processes;
        }


        private void AddNewProcess(BaseNotificationData _notification)
        {
            if (_notification is not ProcessesArgs tmp_Notification) return;
            var tmp_Configures = IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures;
            var tmp_SpaceType = tmp_Configures.Value.SpaceType;
            var tmp_BaseFeatureModel = IocContainer.GetIoc.Resolve<BaseFeatureModel>();
            string tmp_ProjectName = tmp_Notification.ProjectName;
            string tmp_ProcessId = tmp_Notification.ProcessId;
            if (tmp_BaseFeatureModel.Processes.TryGetValue(tmp_ProjectName, out var tmp_Projects))
            {
                tmp_Projects.Add(tmp_ProcessId);
                tmp_BaseFeatureModel.Processes[tmp_ProjectName] = tmp_Projects;
            }
            else
            {
                tmp_BaseFeatureModel.Processes.Add(tmp_ProjectName, new List<string> {tmp_ProcessId});
            }

            allProcesses.Clear();
            allProcesses.AddRange(Object.FindObjectsByType<ProcessIdComponent>(FindObjectsInactive.Include,
                FindObjectsSortMode.InstanceID));

            // Init the process space type
            var tmp_CurrentProcessId = allProcesses.Find(_e => _e.ProcessId.Equals(tmp_ProcessId));
            if (tmp_CurrentProcessId)
            {
                // 0->Share space
                // 1->Full space
                tmp_CurrentProcessId.SpaceType = (byte) tmp_SpaceType;
                IocContainer.GetIoc.Resolve<BaseContextDataModel>().AppSpaceType = tmp_SpaceType;
            }

            tmp_Notification.NotificationAct?.Invoke();


            if (tmp_SpaceType == SpaceType.CustomProfile)
            {
                // CustomPorfile 用于不同开发人员为一款游戏拓展开发使用，这里不需要管理
                // 当主Space关闭后，该任务将随之关闭
            }
            else
            {
                // 如果当前是Exclusive模式，启动其它进程将关闭当前进程（无论是Shared 或者Exclusive）
                // 但是如果是Shared space，则显示所有Shared进程关闭所有Exclusive
                var tmp_AllExclusiveExperiences =
                    allProcesses.Where(_e => _e.SpaceType == (byte) SpaceType.ExclusiveSpace).ToList();
                foreach (ProcessIdComponent tmp_FullSpaceProcessId in tmp_AllExclusiveExperiences)
                {
                    if (tmp_FullSpaceProcessId.Equals(tmp_CurrentProcessId)) continue;
                    ReleaseProcess(new ProcessesArgs()
                    {
                        ProcessId = tmp_FullSpaceProcessId.ProcessId
                    });
                    allProcesses.Remove(tmp_FullSpaceProcessId);
                }

                // 如果当前是Share space模式，启动ExclusiveSpace进程则隐藏当前所有share space进程
                var tmp_SpaceData = new SpaceTypeActionArgs()
                {
                    SpaceTypeValue = tmp_SpaceType,
                    ProcessId = tmp_ProcessId,
                    ProjectName = tmp_ProjectName,
                    BoundPosition = tmp_Configures.Value.Position,
                    BoundResizeMode = tmp_Configures.Value.BoundResizeMode,
                    Dimensions = tmp_Configures.Value.Dimensions,
                    CullingMask = tmp_Configures.Value.CullingMask,
                    MRPassthrough = tmp_Configures.Value.MRPassthrough
                };
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.SwitchSpaceType),
                    tmp_SpaceData);
            }

            APICallback.ProcessesChanged(new ProcessChangeArgs
            {
                ChangeType = ProcessChangeArgs.ChangeTypeEnum.AddNew,
                ProcessId = tmp_ProcessId
            });
        }

        private void ReleaseProject(BaseNotificationData _notification)
        {
            // Remove features from a specified experience
            if (_notification is ProcessesArgs tmp_ProcessesNotificationData)
            {
                string tmp_ProjectName = tmp_ProcessesNotificationData.ProjectName;
                string tmp_ProcessId = tmp_ProcessesNotificationData.ProcessId;
                if (string.IsNullOrEmpty(tmp_ProjectName))
                {
                    tmp_ProcessesNotificationData.ProjectName = FindProjectNameViaProcessId(tmp_ProcessId);
                    tmp_ProjectName = tmp_ProcessesNotificationData.ProjectName;
                    if (string.IsNullOrEmpty(tmp_ProjectName)) return;
                }

                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.RemoveFeatures),
                    new BaseNotificationData() {BaseData = tmp_ProcessesNotificationData.ProjectName});
            }

            ReleaseProcess(_notification);

            // Handheld ar only full space mode
            if (!RuntimePlatformHelper.IsHandheldAR())
            {
                var tmp_SpaceData = new SpaceTypeActionArgs()
                {
                    SpaceTypeValue = SpaceType.SharedSpace,
                };
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.SwitchSpaceType),
                    tmp_SpaceData);
            }
        }


        /// <summary>
        /// Get the experience process name
        /// </summary>
        /// <param name="_processId">The experience process id</param>
        /// <returns>The experience process name</returns>
        private string FindProjectNameViaProcessId(string _processId)
        {
            var tmp_BaseFeatureModel = IocContainer.GetIoc.Resolve<BaseFeatureModel>();

            foreach (var tmp_Kvp in tmp_BaseFeatureModel.Processes)
            {
                foreach (var tmp_ProcessId in tmp_Kvp.Value)
                {
                    if (tmp_ProcessId == _processId)
                    {
                        return tmp_Kvp.Key;
                    }
                }
            }

            return string.Empty;
        }


        /// <summary>
        /// Callback method when space type changes (response to space type switching event)
        /// </summary>
        /// <param name="_data">Notification data, including parameters related to space type change</param>
        private void OnSpaceTypeChange(BaseNotificationData _data)
        {
            if (_data is not SpaceTypeActionArgs tmp_Data) return;
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent), tmp_Data);
            IocContainer.GetIoc.Resolve<BaseContextDataModel>().AppSpaceType = tmp_Data.SpaceTypeValue;

            switch (tmp_Data.SpaceTypeValue)
            {
                case SpaceType.SharedSpace:
                    foreach (ProcessIdComponent tmp_Process in allProcesses)
                    {
                        if (tmp_Process.SpaceType == (byte) SpaceType.SharedSpace)
                            tmp_Process.gameObject.SetActive(true);
                    }

                    break;
                case SpaceType.Metal:
                case SpaceType.ExclusiveSpace:
                    // Hang all share space task
                    foreach (ProcessIdComponent tmp_Process in allProcesses)
                    {
                        if (!tmp_Process.ProcessId.Equals(tmp_Data.ProcessId) &&
                            tmp_Process.SpaceType == (byte) SpaceType.SharedSpace)
                            tmp_Process.gameObject.SetActive(false);
                    }

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Gets the current application space type value.
        /// </summary>
        /// <param name="_data">Notification data (this parameter is not actually used in the method, but may be reserved for compatibility with the notification callback interface).</param>
        /// <returns>The current application space type value (of type <see cref="object"/>, usually a <see cref="SpaceType"/> enumeration value).</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <see cref="BaseContextDataModel"/> is not properly initialized.</exception>
        private object GetSpaceType(BaseNotificationData _data)
        {
            var tmp_Context = IocContainer.GetIoc.Resolve<BaseContextDataModel>();
            Assert.IsNotNull(tmp_Context, "BaseContextDataModel is empty.");
            return tmp_Context.AppSpaceType;
        }

        /// <summary>
        /// Release process resources and update process management status
        /// </summary>
        /// <param name="_notification">Notification data containing process information</param>
        private void ReleaseProcess(BaseNotificationData _notification)
        {
            if (_notification is not ProcessesArgs tmp_Notification) return;
            var tmp_BaseFeatureModel = IocContainer.GetIoc.Resolve<BaseFeatureModel>();

            string tmp_ProjectName = tmp_Notification.ProjectName;
            string tmp_ProcessId = tmp_Notification.ProcessId;
            if (string.IsNullOrEmpty(tmp_ProjectName))
            {
                tmp_Notification.ProjectName = FindProjectNameViaProcessId(tmp_ProcessId);
                tmp_ProjectName = tmp_Notification.ProjectName;
                if (string.IsNullOrEmpty(tmp_ProjectName)) return;
            }


            if (!tmp_BaseFeatureModel.Processes.TryGetValue(tmp_ProjectName, out var tmp_Projects))
                return;

            BasePackageLoaderUtility.ReleaseAssetBundle($"{tmp_ProjectName}.arexperience",
                tmp_ProcessId,
                // To avoid unload same project
                tmp_Projects.Count < 2
            );

            BasePackageLoaderUtility.ReleaseAssetBundleScene($"{tmp_ProjectName}.arexperience",
                tmp_ProcessId,
                // To avoid unload same project
                tmp_Projects.Count < 2
            );

            // Remove pre process 
            int tmp_Idx = tmp_Projects.IndexOf(tmp_ProcessId);
            if (tmp_Idx >= 0)
            {
                tmp_Projects.RemoveAt(tmp_Idx);
                if (tmp_Projects.Count > 0)
                {
                    tmp_BaseFeatureModel.Processes[tmp_ProjectName] = tmp_Projects;
                }
                else
                {
                    tmp_Projects.Clear();
                    tmp_BaseFeatureModel.Processes.Remove(tmp_ProjectName);
                }
            }

            // [Sync Go list]Remove process Go data(Because it was destroyed)
            var tmp_ProcessIdx = allProcesses.FindIndex(_e => _e.ProcessId.Equals(tmp_ProcessId));
            if (allProcesses.Count > tmp_ProcessIdx && tmp_ProcessIdx >= 0)
                allProcesses.RemoveAt(tmp_ProcessIdx);
            tmp_Notification.NotificationAct?.Invoke();
            APICallback.ProcessesChanged(new ProcessChangeArgs
            {
                ChangeType = ProcessChangeArgs.ChangeTypeEnum.Release,
                ProcessId = tmp_ProcessId
            });

            IocContainer.GetIoc.Resolve<BuildScriptRuntimeEnvironmentCommand>().Release(tmp_ProjectName);
        }
    }
}