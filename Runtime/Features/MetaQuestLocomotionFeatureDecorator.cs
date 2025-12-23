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

using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.XRMODInput.Runtime;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    /// <summary>
    /// Feature decorator for enabling/disabling locomotion features on Meta Quest.
    /// <para>
    /// Controls the activation of teleport interactors, character controllers, and locomotion providers.
    /// </para>
    /// </summary>
    public class MetaQuestLocomotionFeatureDecorator : BaseMetaQuestFeatureDecorator
    {
        private ArchitectureComponentsModel architectureComponentsModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaQuestLocomotionFeatureDecorator"/> class.
        /// </summary>
        public MetaQuestLocomotionFeatureDecorator()
        {
            architectureComponentsModel = IocContainer.GetIoc.Resolve<ArchitectureComponentsModel>();
        }

        /// <summary>
        /// Starts the locomotion feature.
        /// <para>
        /// Enables teleport interactors, character controller, and locomotion provider.
        /// </para>
        /// </summary>
        public override void StartAlgorithm()
        {
            base.StartAlgorithm();

            architectureComponentsModel.LeftController.Find("Teleport Interactor").gameObject.SetActive(true);
            architectureComponentsModel.RightController.Find("Teleport Interactor").gameObject.SetActive(true);
            architectureComponentsModel.CharacterController.enabled = true;
            architectureComponentsModel.LocomotionProvider.gameObject.SetActive(true);
        }

        /// <summary>
        /// Determines if this feature is supported.
        /// </summary>
        /// <returns>Always returns true.</returns>
        public override bool SupportThisFeature()
        {
            return true;
        }

        /// <summary>
        /// Pauses the algorithm.
        /// </summary>
        /// <exception cref="System.NotImplementedException">Not implemented.</exception>
        public override void PauseAlgorithm()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Stops the locomotion feature.
        /// <para>
        /// Disables character controller, locomotion provider, and teleport interactors.
        /// </para>
        /// </summary>
        public override void StopAlgorithm()
        {
            architectureComponentsModel.CharacterController.enabled = false;
            architectureComponentsModel.LocomotionProvider.gameObject.SetActive(false);
            architectureComponentsModel.LeftController.Find("Teleport Interactor").gameObject.SetActive(false);
            architectureComponentsModel.RightController.Find("Teleport Interactor").gameObject.SetActive(false);
        }
    }
}