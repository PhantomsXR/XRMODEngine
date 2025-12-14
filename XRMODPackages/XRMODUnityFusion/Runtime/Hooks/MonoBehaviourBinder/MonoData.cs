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
using System.Collections.Generic;
using UnityFusion.Runtime.Enviorment;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    [System.Serializable]
    public class MonoData
    {
        public string ClassNamespace;
        public string ClassName;

        public List<MonoField> Fields = new();

        public bool BoundData = false;
        public bool Added = false;
        public bool Activated = false;

        public CrossBindingAdaptorType ClrInstance;
        public Type ClassType;
    }

    public enum RenderStateType
    {
        None,
        Visiable,
        Hiden
    }
}