// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public static class CommonUtility
    {
        public static List<CrossBindingAdaptorType> GetAllMonoAdapters(
            FindObjectsSortMode _sortMode = FindObjectsSortMode.None,
            FindObjectsInactive _findObjectsInactive = FindObjectsInactive.Exclude)
        {
            var tmp_FoundList = Object.FindObjectsByType<MonoBehaviour>(_findObjectsInactive, _sortMode).ToList();
            
            var tmp_CrossBindingAdaptorList = tmp_FoundList.FindAll(
                _script => _script.GetType().GetInterfaces().Contains(typeof(CrossBindingAdaptorType)));
            
            var tmp_GotScripts =
                tmp_CrossBindingAdaptorList.Select(_script => (CrossBindingAdaptorType) _script);
            return tmp_GotScripts.ToList();
        }

        public static ILTypeInstance[] GetHotComponents(List<CrossBindingAdaptorType> _adapters, ILType _type)
        {
            var tmp_Filter = _adapters.FindAll(_script =>
                _script.ILInstance != null && _script.ILInstance.Type.CanAssignTo(_type));
            var tmp_Select = tmp_Filter.Select(_script => _script.ILInstance).ToArray();
            return tmp_Select;
        }

        public static object GetHotComponent(List<CrossBindingAdaptorType> _adapters, ILType _type)
        {
            foreach (CrossBindingAdaptorType tmp_BindingAdaptorType in _adapters)
            {
                if (tmp_BindingAdaptorType.ILInstance != null &&
                    tmp_BindingAdaptorType.ILInstance.Type.CanAssignTo(_type))
                {
                    return tmp_BindingAdaptorType.ILInstance;
                }
            }

            return null;
        }
    }
}