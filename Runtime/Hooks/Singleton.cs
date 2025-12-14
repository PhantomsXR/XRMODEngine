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

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public class Singleton<T> where T : class, new()
    {
        private Singleton()
        {
        }

        private static readonly Lazy<T> Instance = new Lazy<T>(() => new T());

        public static T GetInstance => Instance.Value;
    }
}