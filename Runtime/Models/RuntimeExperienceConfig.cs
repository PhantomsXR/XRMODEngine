// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantoms.Models.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.Models.Runtime
{
    /// <summary>
    /// Managed model that holds the current runtime configuration and metadata for an active XR experience.
    /// It provides a bindable property for reactive updates when the configuration changes.
    /// </summary>
    public class RuntimeExperienceConfig : IModel, IReleaseCommand
    {
        /// <summary>
        /// The current experience configuration, wrapped in a <see cref="BindableProperty{T}"/> for observation.
        /// </summary>
        public BindableProperty<BaseExperienceConfigModel> CurrentConfigures { get; private set; }
        
        /// <summary> Optional metadata string associated with the experience. </summary>
        public string MetaData;

        /// <summary>
        /// Initializes the config model and its bindable properties.
        /// </summary>
        public void Initialize()
        {
            CurrentConfigures = new BindableProperty<BaseExperienceConfigModel>();
        }

        public RuntimeExperienceConfig()
        {
            Initialize();
        }

        /// <summary>
        /// Releases resources and clears bindings when the experience is stopped or disposed.
        /// </summary>
        /// <param name="_projectName">Optional project name for scoped release.</param>
        public void Release(string _projectName = null)
        {
            CurrentConfigures.OnValueChanged = null;
            CurrentConfigures.Value = null;
        }
    }
}