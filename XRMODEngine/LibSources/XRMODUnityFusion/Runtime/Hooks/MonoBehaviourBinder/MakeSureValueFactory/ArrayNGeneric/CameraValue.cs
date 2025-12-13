// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.Animations;
using Unity.AI.Navigation;
using UnityEngine.U2D;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine.Rendering;
using UnityEngine.Rendering;
using UnityEngine.AI;
using Object = UnityEngine.Object;
using UnityEngine.Playables;
using TMPro;


namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public class CameraValue:ArrayAndGenericMixMakeSureAction
    {
        public override bool MakeSureValue(ref FieldInfo _fieldInfo, object _target, object _value)
        {
            if (!base.MakeSureValue(ref _fieldInfo, _target, _value)) return false;
            _fieldInfo.SetValue(_target,
                isGenericList
                    ? convertedArray.Cast<Camera>().ToList()
                    : convertedArray.Cast<Camera>().ToArray());
            return true;

        }
    }
}