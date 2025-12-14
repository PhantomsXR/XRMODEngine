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

using UnityFusion.Runtime.Generated;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public class RegisterClrMethodRedirection : IRegister
    {
        public unsafe void Register(AppDomain _appDomain)
        {
            new AddComponentClrMethodRegister().Register(_appDomain);
            new GetComponentClrMethodRegister().Register(_appDomain);
            new GetComponentInChildrenRedirection().Register(_appDomain);
            new GetComponentInParentRedirection().Register(_appDomain);
            new DebugClrMethodRegister().Register(_appDomain);
            new FindObjectOfTypeClrMethodRegister().Register(_appDomain);
            new InstantiateClrMethodRegister().Register(_appDomain);
            new SendMessageClrMethodRegister().Register(_appDomain);
            new SendMessageUpwardsClrMethodRegister().Register(_appDomain);
            new BroadcastMessageClrMethodRegister().Register(_appDomain);
            new InvokeClrMethodRegister().Register(_appDomain);
            //new LoadTTypeAssetRedirection().Register(_appDomain);

            LitJson.JsonMapper.RegisterUnityFusionCLRRedirection(_appDomain);
        }
    }
}