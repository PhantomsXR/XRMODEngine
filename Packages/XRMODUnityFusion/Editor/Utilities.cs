// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.Runtime.Editor
{
    public static class Utilities
    {
        public static float MakeSureHeight =>
            EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;

        public static string[] GetLayerNamesFromMask(LayerMask _layerMask)
        {
            List<string> tmp_LayerNames = new List<string>();

            // 遍历32个层，检查它们是否在LayerMask中
            for (int i = 0; i < 32; i++)
            {
                // 检查层是否在LayerMask中
                if (((1 << i) & _layerMask) != 0)
                {
                    // 获取层的名称，并添加到列表中
                    string tmp_LayerName = LayerMask.LayerToName(i);
                    tmp_LayerNames.Add(tmp_LayerName);
                }
            }

            return tmp_LayerNames.ToArray();
        }

        public static Object GetComponent(GameObject _gameObject, string _fieldTypeName, FieldInfo _fieldInfo)
        {
            var tmp_Components = _gameObject.GetComponentsInChildren<Component>(true).ToList();

            var tmp_Component =
                tmp_Components.Find(_component =>
                {
                    if (_component == null) return false;
                    return _component.GetType().IsAssignableFrom(_fieldInfo.FieldType)
                           || _fieldInfo.FieldType.IsInstanceOfType(_component);
                });
            return tmp_Component;
        }


        public static string GetFirstTwoNameParts(string _fullName, char _separator = '.')
        {
            var tmp_Parts = _fullName.Split(_separator);
            if (tmp_Parts.Length >= 2)
                return $"{tmp_Parts[0]}.{tmp_Parts[1]}";
            return _fullName;
        }


      
    }

    internal class UnityContractResolver : DefaultContractResolver
    {
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            // 忽略 UnityEngine.Vector3.normalized、magnitude 等计算型属性
            var props = base.CreateProperties(type, memberSerialization);

            if (type == typeof(UnityEngine.Vector3))
            {
                props = props.Where(p => p.PropertyName == "x" || p.PropertyName == "y" || p.PropertyName == "z")
                    .ToList();
            }

            if (type == typeof(UnityEngine.Quaternion))
            {
                props = props.Where(p =>
                        p.PropertyName == "x" || p.PropertyName == "y"
                                              || p.PropertyName == "z" ||
                                              p.PropertyName == "w")
                    .ToList();
            }

            if (type == typeof(UnityEngine.Vector2))
            {
                props = props.Where(p => p.PropertyName == "x" || p.PropertyName == "y").ToList();
            }

            if (type == typeof(UnityEngine.Color))
            {
                props = props.Where(p =>
                        p.PropertyName == "r" || p.PropertyName == "g" || p.PropertyName == "b" ||
                        p.PropertyName == "a")
                    .ToList();
            }

            return props;
        }
    }
}