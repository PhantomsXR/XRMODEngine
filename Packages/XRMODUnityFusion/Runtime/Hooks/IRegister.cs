// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the UnityFusion.Runtime.CodeHook.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityFusion.Runtime.Enviorment;

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public interface IRegister
    {
        void Register(AppDomain _appDomain);
    }
}