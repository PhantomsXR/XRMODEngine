// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.ARAlgorithm.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Models.Runtime;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    /// <summary>
    /// Command that configures post-processing settings on the main camera.
    /// Enables FXAA, Stop NaN, and Post-Processing as part of the experience initialization.
    /// </summary>
    public class BuildPostProcessingCommand : AbstractCommand, ICommand, IReleaseCommand
    {
        private BaseContextDataModel arComponentModel;
        private UniversalAdditionalCameraData uac;


        public void Execute()
        {
            base.Initializer();
            var tmp_MainCamera = IocContainer.GetIoc.Resolve<BaseContextDataModel>().MainCamera;
            if (tmp_MainCamera == null)
                tmp_MainCamera = Camera.main;
            uac = tmp_MainCamera.GetComponent<UniversalAdditionalCameraData>();
            uac.antialiasing = AntialiasingMode.FastApproximateAntialiasing;
            uac.stopNaN = true;
            uac.renderPostProcessing = true;
        }

        public void Release(string _projectName = null)
        {
            if (uac == null) return;
            uac.renderPostProcessing = false;
            uac.antialiasing = AntialiasingMode.None;
            uac.stopNaN = false;
        }
    }
}