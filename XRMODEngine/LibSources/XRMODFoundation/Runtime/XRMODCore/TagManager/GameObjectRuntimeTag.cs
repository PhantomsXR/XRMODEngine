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
using UnityEngine;

namespace Phantom.XRMOD.Core.Runtime
{
    public class GameObjectRuntimeTag : MonoBehaviour, IRuntimeTag
    {
        public string RuntimeTag;
        // public bool RegisterImmediatelyl = true;
        
        public bool DoCompareTag(string _tag)
        {
            return String.CompareOrdinal(RuntimeTag, _tag) == 0;
        }
    }
}