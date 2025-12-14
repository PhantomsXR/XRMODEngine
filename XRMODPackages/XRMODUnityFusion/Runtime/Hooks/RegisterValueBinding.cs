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

using Phantom.XRMOD.UnityFusion.ValueBinder;
using UnityFusion.Runtime.Enviorment;
using UnityEngine;

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public class RegisterValueBinding : IRegister
    {
        public void Register(AppDomain _appDomain)
        {
            _appDomain.RegisterValueTypeBinder(typeof(Vector3), new Vector3Binder());
            _appDomain.RegisterValueTypeBinder(typeof(Vector2), new Vector2Binder());
            _appDomain.RegisterValueTypeBinder(typeof(Vector4), new Vector4Binder());
            _appDomain.RegisterValueTypeBinder(typeof(Quaternion), new QuaternionBinder());
        }
    }
}