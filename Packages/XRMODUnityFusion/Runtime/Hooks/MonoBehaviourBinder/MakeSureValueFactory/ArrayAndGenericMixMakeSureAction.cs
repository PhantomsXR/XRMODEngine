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
using System.Collections;
using System.Linq;
using System.Reflection;
using UnityFusion.Reflection;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public class ArrayAndGenericMixMakeSureAction : IBaseMakeSureValueAction
    {
        protected bool isGenericList;
        protected Array convertedArray;

        public virtual bool MakeSureValue(ref FieldInfo _fieldInfo, object _target, object _value)
        {
            bool tmp_IsListLike = false;
            if (_fieldInfo.FieldType is UnityFusionType tmp_FusionType)
            {
                if (tmp_FusionType.IsArray || tmp_FusionType.GetInterfaces().Contains(typeof(IList)))
                {
                    tmp_IsListLike = true;
                }
            }
            else
            {
                tmp_IsListLike = typeof(IList).IsAssignableFrom(_fieldInfo.FieldType);
            }

            if (_fieldInfo.FieldType.IsGenericType && _fieldInfo.FieldType.GetGenericArguments().Length > 0)
            {
                isGenericList = true;
            }


            if (!tmp_IsListLike || _value is not Array tmp_Array) return false;
            convertedArray = tmp_Array;
            return true;
        }
    }
}