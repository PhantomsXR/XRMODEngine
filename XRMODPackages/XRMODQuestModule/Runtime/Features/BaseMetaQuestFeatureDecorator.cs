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

using System.Collections.Generic;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    /// <summary>
    /// Base abstract decorator for Meta Quest features.
    /// <para>
    /// Provides common functionality for registering feature decorators at runtime.
    /// Implementations should override <see cref="StartAlgorithm"/>, <see cref="PauseAlgorithm"/>, and <see cref="StopAlgorithm"/>.
    /// </para>
    /// </summary>
    public abstract class BaseMetaQuestFeatureDecorator : IFeatureDecorator
    {
        /// <summary>
        /// Determines if the specific feature is supported on the current platform/device.
        /// </summary>
        /// <returns>True if supported, otherwise false.</returns>
        public abstract bool SupportThisFeature();

        /// <summary>
        /// Starts the feature algorithm.
        /// <para>
        /// By default, it calls <see cref="RuntimeFeatureRegister"/> to register the decorator.
        /// </para>
        /// </summary>
        public virtual void StartAlgorithm()
        {
            RuntimeFeatureRegister();
        }

        /// <summary>
        /// Pauses the feature algorithm.
        /// </summary>
        public abstract void PauseAlgorithm();

        /// <summary>
        /// Stops the feature algorithm.
        /// </summary>
        public abstract void StopAlgorithm();
        
        /// <summary>
        /// Automatically registers the feature decorator to the <see cref="XRRuntimeContextDataModel"/>.
        /// <para>
        /// This ensures the feature is tracked and managed by the runtime context for the current project.
        /// </para>
        /// </summary>
        protected  void RuntimeFeatureRegister()
        {
            var tmp_ExperienceData = IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.Value;
            var tmp_ContextData = IocContainer.GetIoc.Resolve<XRRuntimeContextDataModel>();


            if (tmp_ExperienceData == null || string.IsNullOrEmpty(tmp_ExperienceData.ProjectName))
            {
                Debug.LogError("Can not read project.");
                return;
            }
            
            if (tmp_ContextData.FeatureDecoratorsAtRuntime.TryGetValue(tmp_ExperienceData.ProjectName,
                    out var tmp_Decorators))
            {
                if (!tmp_Decorators.Contains(this))
                {
                    tmp_Decorators.Add(this);
                }
            }
            else
            {
                List<IFeatureDecorator> tmp_NewDecorators = new List<IFeatureDecorator> {this};
                tmp_ContextData.FeatureDecoratorsAtRuntime.Add(tmp_ExperienceData.ProjectName, tmp_NewDecorators);
            }
        }

    }
}