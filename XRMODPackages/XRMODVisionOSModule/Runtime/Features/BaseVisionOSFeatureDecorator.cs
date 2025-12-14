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

using System.Collections.Generic;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using UnityEngine;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public abstract class BaseVisionOSFeatureDecorator : IFeatureDecorator
    {
        public abstract bool SupportThisFeature();

        public virtual void StartAlgorithm()
        {
            RuntimeFeatureRegister();
        }

        public abstract void PauseAlgorithm();
        public abstract void StopAlgorithm();

        /// <summary>
        /// Auto register the feature decorator to manager.
        /// </summary>
        protected virtual void RuntimeFeatureRegister()
        {
            var tmp_ExperienceData = IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.Value;
            var tmp_ContextData = IocContainer.GetIoc.Resolve<ARContextDataModel>();


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