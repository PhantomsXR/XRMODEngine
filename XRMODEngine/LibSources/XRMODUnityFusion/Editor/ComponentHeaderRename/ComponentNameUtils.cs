// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Editor.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.UnityFusion.Editor
{
    public class ComponentNameUtils
    {
        private static Dictionary<Type, string> _INTERNAL_INSPECTOR_TITLES_CACHE = null;
        private static readonly Dictionary<Type, string> _INTERNAL_ORIGINAL_INSPECTOR_TITLES_CACHE = new();
        private static readonly Dictionary<Object, string> _INTERNAL_ORIGINAL_INSPECTOR_TITLES_OVERRIDES_CACHE = new();


        internal static string GetInspectorTitle([DisallowNull] Component _component)
        {
            return _INTERNAL_ORIGINAL_INSPECTOR_TITLES_OVERRIDES_CACHE.TryGetValue(_component,
                out var tmp_InspectorTitle)
                ? tmp_InspectorTitle
                : GetDefault(_component);
        }


        internal static void SetName(Component _component, string _name)
        {
            if (IsNullEmptyOrDefault(_component, _name))
            {
                ResetToDefault(_component);
                return;
            }

            InternalInspectorTitlesCache[_component.GetType()] = _name;
            _INTERNAL_ORIGINAL_INSPECTOR_TITLES_OVERRIDES_CACHE[_component] = _name;
        }

        internal static Dictionary<Type, string> InternalInspectorTitlesCache
        {
            get
            {
                if (_INTERNAL_INSPECTOR_TITLES_CACHE != null) return _INTERNAL_INSPECTOR_TITLES_CACHE;
                Type tmp_InspectorTitlesType = typeof(ObjectNames).GetNestedType("InspectorTitles",
                    BindingFlags.Static | BindingFlags.NonPublic);
                var tmp_InspectorTitlesField = tmp_InspectorTitlesType.GetField("s_InspectorTitles",
                    BindingFlags.Static | BindingFlags.NonPublic);
                if (tmp_InspectorTitlesField != null)
                    _INTERNAL_INSPECTOR_TITLES_CACHE =
                        tmp_InspectorTitlesField.GetValue(null) as Dictionary<Type, string>;
                return _INTERNAL_INSPECTOR_TITLES_CACHE;
            }
        }

        internal static void EnsureOriginalInspectorTitleIsCached([DisallowNull] Component _component,
            [DisallowNull] Type _componentType) => _ = GetDefaultBultIn(_component, _componentType);

        private static string GetDefault([DisallowNull] Component _component)
        {
            var tmp_ComponentType = _component.GetType();
            return GetDefaultBultIn(_component, tmp_ComponentType);
        }

        private static void ResetToDefault(Component _component)
        {
            _INTERNAL_ORIGINAL_INSPECTOR_TITLES_OVERRIDES_CACHE.Remove(_component);
        }

        private static string GetDefaultBultIn(Component _component, Type _componentType)
        {
            if (_INTERNAL_ORIGINAL_INSPECTOR_TITLES_CACHE.TryGetValue(_componentType, out var tmp_InspectorTitle))
            {
                return tmp_InspectorTitle;
            }


            if (_componentType.GetCustomAttribute<AddComponentMenu>(false) is
                {componentMenu: {Length: > 0} tmp_MenuPath})
            {
                int tmp_LastCategoryEnd = tmp_MenuPath.LastIndexOf('/');
                tmp_InspectorTitle = tmp_LastCategoryEnd != -1
                    ? tmp_MenuPath.Substring(tmp_LastCategoryEnd + 1)
                    : tmp_MenuPath;
                _INTERNAL_ORIGINAL_INSPECTOR_TITLES_CACHE.TryAdd(_componentType, tmp_InspectorTitle);
                return tmp_InspectorTitle;
            }


            tmp_InspectorTitle = ObjectNames.GetInspectorTitle(_component);
            if (tmp_InspectorTitle.EndsWith(")"))
            {
                int tmp_SuffixStart = tmp_InspectorTitle.LastIndexOf('(');
                if (tmp_SuffixStart != -1)
                {
                    var tmp_HeaderName = tmp_InspectorTitle.Substring(0, tmp_SuffixStart).TrimEnd(' ');
                    var tmp_HeaderSuffix = tmp_InspectorTitle.Substring(tmp_SuffixStart + 1,
                        tmp_InspectorTitle.Length - tmp_SuffixStart - 2);
                    if (string.Equals(tmp_HeaderSuffix, "Script"))
                    {
                        tmp_InspectorTitle = $"{tmp_HeaderName} ({tmp_HeaderSuffix})";
                    }
                    else
                    {
                        tmp_InspectorTitle = tmp_HeaderName;
                    }
                }
            }

            _INTERNAL_ORIGINAL_INSPECTOR_TITLES_CACHE.TryAdd(_componentType, tmp_InspectorTitle);
            return tmp_InspectorTitle;
        }


        private static bool IsNullEmptyOrDefault(Component _component, string _name)
        {
            if (string.IsNullOrEmpty(_name))
            {
                return true;
            }

            var tmp_DefaultName = GetDefault(_component);
            return string.Equals(_name, tmp_DefaultName);
        }
    }
}