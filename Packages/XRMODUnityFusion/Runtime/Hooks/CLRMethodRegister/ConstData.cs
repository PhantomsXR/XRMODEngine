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

using System;
using System.Reflection;
using UnityEngine;

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public class ConstData
    {
        public const BindingFlags CONST_BINDING_FLAGS =
            BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
            BindingFlags.DeclaredOnly;

        public static readonly Type MOMO_TYPE = typeof(MonoBehaviour);
        public static readonly Type GAME_OBJECT_TYPE = typeof(GameObject);
        public static readonly Type COMPONENT_TYPE = typeof(Component);
    }
}