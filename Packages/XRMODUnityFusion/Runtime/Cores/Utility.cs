// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.Core.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using UnityEngine;
using UnityFusion.Runtime.Intepreter;

namespace UnityFusion.Runtime
{
    public class Utility
    {
        /// <summary>
        /// find ilrt gameObject
        /// </summary>
        /// <param name="_instance"></param>
        /// <returns>GameObject</returns>
        public static GameObject FindGameFromILTypeInstance(ILTypeInstance _instance)
        {
            var tmp_ReturnType = _instance.Type;
            if (tmp_ReturnType.ReflectionType == typeof(MonoBehaviour))
            {
                var tmp_PropertyInfo = tmp_ReturnType.ReflectionType.GetProperty("gameObject");
                if (tmp_PropertyInfo != null)
                    return tmp_PropertyInfo.GetValue((_instance as ILTypeInstance).CLRInstance) as GameObject;
            }
            else if (tmp_ReturnType.ReflectionType.IsSubclassOf(typeof(MonoBehaviour)))
            {
                if (tmp_ReturnType.ReflectionType.BaseType == null) return null;
                var tmp_PropertyInfo = tmp_ReturnType.ReflectionType.BaseType.GetProperty("gameObject");
                if (tmp_PropertyInfo != null)
                    return tmp_PropertyInfo.GetValue((_instance as ILTypeInstance).CLRInstance) as GameObject;
            }

            return null;
        }

        /// <summary>
        /// 从 LayerMask 值中获取所有被选中的层名称。
        /// </summary>
        /// <param name="_mask">LayerMask 的整型值。</param>
        /// <returns>包含所有被选中的层名称的列表。</returns>
        public static List<string> GetLayerNamesFromMask(int _mask)
        {
            List<string> tmp_LayerNames = new List<string>();
            for (int i = 0; i < 32; i++) // Unity 支持最多 32 个 Layer
            {
                if ((_mask & (1 << i)) != 0)
                {
                    string tmp_LayerName = LayerMask.LayerToName(i);
                    if (!string.IsNullOrEmpty(tmp_LayerName))
                    {
                        tmp_LayerNames.Add(tmp_LayerName);
                    }
                }
            }

            return tmp_LayerNames;
        }

        /// <summary>
        /// 从一组层名称生成对应的 LayerMask。
        /// </summary>
        /// <param name="_layerNames">层名称的集合（如 "Default", "UI"）。</param>
        /// <returns>对应的 LayerMask 对象。</returns>
        public static LayerMask CreateLayerMaskFromNames(IEnumerable<string> _layerNames)
        {
            int tmp_Mask = 0;
            foreach (var tmp_Name in _layerNames)
            {
                int tmp_Layer = LayerMask.NameToLayer(tmp_Name);
                if (tmp_Layer >= 0)
                {
                    tmp_Mask |= (1 << tmp_Layer);
                }
                else
                {
                    Debug.LogWarning($"Layer \"{tmp_Name}\" does not exist.");
                }
            }

            return tmp_Mask;
        }
    }
}