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

namespace Phantom.XRMOD.QuestModule.Runtime
{
    /// <summary>
    /// Manages the lifecycle of XR algorithms on the Quest platform.
    /// <para>
    /// Listens for <see cref="ActionParameterDataType.ARAlgorithmLifeCTRL"/> notifications and controls the state (Start, Pause, Stop)
    /// of various algorithms such as Meshing and Passthrough.
    /// </para>
    /// </summary>
    public class BuildXRAlgorithmLifeControllerCommand : ICommand, IReleaseCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildXRAlgorithmLifeControllerCommand"/> class and immediately executes it.
        /// </summary>
        public BuildXRAlgorithmLifeControllerCommand()
        {
            Execute();
        }

        /// <summary>
        /// Subscribes to the algorithm lifecycle control notification.
        /// </summary>
        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(XRAlgorithmLifeController,
                nameof(ActionParameterDataType.ARAlgorithmLifeCTRL));
        }

        /// <summary>
        /// Unsubscribes from the algorithm lifecycle control notification.
        /// </summary>
        /// <param name="_projectName">Optional project name context.</param>
        public void Release(string _projectName = default)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.ARAlgorithmLifeCTRL));
        }


        /// <summary>
        /// Callback handler for algorithm lifecycle notifications.
        /// <para>
        /// Dispatches control commands to specific feature decorators based on the algorithm type in <paramref name="_data"/>.
        /// </para>
        /// </summary>
        /// <param name="_data">Notification data containing <see cref="ARAlgorithmArgs"/>.</param>
        private void XRAlgorithmLifeController(BaseNotificationData _data)
        {
            if (_data is ARAlgorithmArgs tmp_Args)
            {
                switch (tmp_Args.ARAlgorithmType)
                {
                    case ARAlgorithmType.ImageTracker:
                        // Not support for Quest platform
                        break;
                    case ARAlgorithmType.Immersal:
                        break;
                    case ARAlgorithmType.Anchor:
                        break;
                    case ARAlgorithmType.Meshing:
                        ExecuteOrCreateFeature<BuildMetaQuestMeshFeatureCommand>(typeof(MetaQuestMeshingDecorator),
                            tmp_Args);
                        break;
                    case ARAlgorithmType.PassThrough:
                        ExecuteOrCreateFeature<BuildMetaQuestMRFeatureCommand>(typeof(MetaQuestMRFeatureDecorator),
                            tmp_Args);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }


                tmp_Args.NotificationAct?.Invoke();
            }
        }

        /// <summary>
        /// Executes or controls a feature based on whether it already exists.
        /// </summary>
        /// <typeparam name="T">The type of the command to build the feature if it doesn't exist.</typeparam>
        /// <param name="tmp_AlgorithmType">The type of the feature decorator.</param>
        /// <param name="tmp_Args">Arguments specifying the operation (Start, Pause, Stop).</param>
        private void ExecuteOrCreateFeature<T>(Type tmp_AlgorithmType, ARAlgorithmArgs tmp_Args)
            where T : class, ICommand
        {
            IFeatureDecorator tmp_Decorator;
            if (FeatureHasBeenAlready(tmp_AlgorithmType, out tmp_Decorator))
            {
                switch (tmp_Args.ARAlgorithmOperator)
                {
                    case ARAlgorithmOperator.StartAlgorithm:
                        tmp_Decorator.StartAlgorithm();
                        break;
                    case ARAlgorithmOperator.PauseAlgorithm:
                        tmp_Decorator.PauseAlgorithm();
                        break;
                    case ARAlgorithmOperator.StopAlgorithm:
                        tmp_Decorator.StopAlgorithm();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                IocContainer.GetIoc.Resolve<T>().Execute();
            }
        }

        /// <summary>
        /// Checks if a feature decorator has already been registered in the FeatureManager.
        /// </summary>
        /// <param name="_algorithmType">The type of the feature decorator.</param>
        /// <param name="_featureDecorator">The retrieved feature decorator instance.</param>
        /// <returns>True if the feature exists, false otherwise.</returns>
        private bool FeatureHasBeenAlready(Type _algorithmType, out IFeatureDecorator _featureDecorator)
        {
            return FeatureManager.TryGetValue(_algorithmType!, out _featureDecorator);
        }
    }
}