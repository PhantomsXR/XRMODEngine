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

using System.Reflection;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public interface IBaseMakeSureValueAction
    {
        bool MakeSureValue(ref FieldInfo _fieldInfo,object _target,object _value);
    }
}