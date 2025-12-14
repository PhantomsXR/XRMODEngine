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

using System.Linq;
using System.Reflection; 
using UnityFusion.Runtime.Enviorment;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public class MakeSureGenericValue : IBaseMakeSureValueAction
    {
        public bool MakeSureValue(ref FieldInfo _fieldInfo, object _target, object _value)
        { 
            if (_fieldInfo.FieldType.IsGenericType)
            {
                var tmp_Type = _fieldInfo.FieldType.GetGenericArguments()[0];
                if (tmp_Type.GetInterfaces().Contains(typeof(CrossBindingAdaptorType)))
                {
                    return new ILTypeInstanceXRMODBehaviourAdapterValue().MakeSureValue(ref _fieldInfo, _target,
                        _value);
                }
            } 
            _fieldInfo.SetValue(_target, _value);
            return true;
        }
    }
}