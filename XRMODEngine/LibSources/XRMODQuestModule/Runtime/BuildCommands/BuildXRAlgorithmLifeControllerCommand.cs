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
    public class BuildXRAlgorithmLifeControllerCommand : ICommand, IReleaseCommand
    {
        public BuildXRAlgorithmLifeControllerCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(XRAlgorithmLifeController,
                nameof(ActionParameterDataType.ARAlgorithmLifeCTRL));
        }

        public void Release(string _projectName = default)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.ARAlgorithmLifeCTRL));
        }


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

        private bool FeatureHasBeenAlready(Type _algorithmType, out IFeatureDecorator _featureDecorator)
        {
            return FeatureManager.TryGetValue(_algorithmType!, out _featureDecorator);
        }
    }
}