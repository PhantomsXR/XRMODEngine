// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineCore.Runtime.
// //
// // The XRMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace Phantom.XRMOD.Core.Runtime
{
    public interface IFeatureDecorator
    {
        public bool SupportThisFeature();
        public void StartAlgorithm();
        public void PauseAlgorithm();
        public void StopAlgorithm();
    }
}