// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using UnityFusion.Runtime.Enviorment;

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public abstract class AbstractRegister:IRegister
    {
        protected AppDomain appDomain;

        public virtual unsafe void Register(AppDomain _appDomain)
        {
            appDomain = _appDomain;
        }
    }
}