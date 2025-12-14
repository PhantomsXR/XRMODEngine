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

using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.VisionOSModule.Runtime.Models;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class BuildVisionOSARAlgorithmLifeControllerCommand : ICommand, IReleaseCommand
    {
        public BuildVisionOSARAlgorithmLifeControllerCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(ARAlgorithmLifeController,
                nameof(ActionParameterDataType.ARAlgorithmLifeCTRL));
        }

        public void Release(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.ARAlgorithmLifeCTRL));
        }


        /// <summary>
        /// Create the addition ar algorithm
        /// </summary>
        /// <param name="_base">Action data</param>
        private void ARAlgorithmLifeController(BaseNotificationData _base)
        {
            if (!(_base is ARAlgorithmArgs tmp_NotifyData)) return;

            System.Type tmp_AlgorithmType = null;
            IFeatureDecorator tmp_Decorator;

            switch (tmp_NotifyData.ARAlgorithmType)
            {
                case ARAlgorithmType.Anchor:
                    tmp_AlgorithmType = typeof(VisionOSAnchorCreatorDecorator);
                    IocContainer.GetIoc.Resolve<BuildVisionOSAnchorCommand>().Execute();
                    break;

                case ARAlgorithmType.ImageTracker:
                    tmp_AlgorithmType = typeof(VisionOSImageTrackDecorator);
                    IocContainer.GetIoc.Resolve<BuildVisionOSImageTrackCommand>().Execute();
                    break;
#if ENABLE_IMMERSAL && HANDHELD_ARMODULE_INSTALLED
                case ARAlgorithmType.Immersal:
                    tmp_AlgorithmType = typeof(ImmersalDecorator);
                    IocContainer.GetIoc.Resolve<BuildImmersalCommand>().Execute();
                    break;
#endif
                case ARAlgorithmType.Meshing:
                    bool tmp_PausedMeshing = tmp_NotifyData.ARAlgorithmOperator != ARAlgorithmOperator.PauseAlgorithm
                                             || tmp_NotifyData.ARAlgorithmOperator != ARAlgorithmOperator.StopAlgorithm;
                    IocContainer.GetIoc.Resolve<ARComponentModel>().ARMeshManager.gameObject
                        .SetActive(tmp_PausedMeshing);
                    break;
            }

            if (tmp_AlgorithmType == null || !FeatureManager.TryGetValue(tmp_AlgorithmType!, out tmp_Decorator)) return;
            switch (tmp_NotifyData.ARAlgorithmOperator)
            {
                case ARAlgorithmOperator.StartAlgorithm:
                    tmp_Decorator?.StartAlgorithm();
                    break;
                case ARAlgorithmOperator.PauseAlgorithm:
                    tmp_Decorator?.PauseAlgorithm();
                    break;
                case ARAlgorithmOperator.StopAlgorithm:
                    tmp_Decorator?.StopAlgorithm();
                    break;
            }

            tmp_NotifyData.NotificationAct?.Invoke();
        }
    }
}