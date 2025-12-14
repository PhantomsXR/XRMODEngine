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

using System;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityFusion.CLRBinding.Adapter;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public class RegisterCrossBindingAdaptor : IRegister

    {
        public void Register(AppDomain _appDomain)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.RegisterBuiltInAdaptor),
                new UnityFusionArgs
                {
                    AppDomain = _appDomain
                });
        }
    }
}