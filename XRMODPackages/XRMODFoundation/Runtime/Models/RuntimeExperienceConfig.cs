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
    public class RuntimeExperienceConfig : IModel, IReleaseCommand
    {
        public BindableProperty<BaseExperienceConfigModel> CurrentConfigures { get; private set; }
        public string MetaData;

        public void Initialize()
        {
            CurrentConfigures = new BindableProperty<BaseExperienceConfigModel>();
        }

        public RuntimeExperienceConfig()
        {
            Initialize();
        }

        public void Release(string _projectName = null)
        {
            CurrentConfigures.OnValueChanged = null;
            CurrentConfigures.Value = null;
        }
    }
}