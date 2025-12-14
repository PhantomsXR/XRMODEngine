// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Goap.Resolver.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Reflection;
using Phantom.XRMOD.UnityFusion.Runtime;
using UnityEngine;
using UnityFusion.CLR.TypeSystem;

namespace Goap.Core
{
    public static class TypeReSolveHelper
    {
        public static Type ResolveType(object _obj)
        {
            if (_obj == null)
            {
                return null;
            }

            if (CodesHook.GetAppDomain == null) return _obj.GetType();
            return CodesHook.GetAppDomain.LoadedTypes.TryGetValue(_obj.ToString(), out var tmp_IType)
                ? tmp_IType.ReflectionType
                : _obj.GetType();
        }


        public static Type[] ResolveTypes(Assembly _assembly)
        {
            if (_assembly == null) return default;
            if (CodesHook.GetAppDomain == null) return _assembly.GetTypes();
            List<Type> tmp_RefTypes = new List<Type>();
            foreach (Type tmp_Type in _assembly.GetTypes())
            {
                if (CodesHook.GetAppDomain.LoadedTypes.TryGetValue(tmp_Type.FullName, out var tmp_IType))
                {
                    tmp_RefTypes.Add(tmp_IType.ReflectionType);
                }
            }


            return tmp_RefTypes.ToArray();
        }


        public static TType Instantiate<TType, TConfig>(string _type) where TType : class, IHasConfig<TConfig>
            where TConfig : IClassConfig
        {
            if (string.IsNullOrEmpty(_type)) return default;
            Debug.Log($"{_type},{typeof(TType)}");
            var tmp_Instance = Activator.CreateInstance(Type.GetType(_type)) as TType;
            if (CodesHook.GetAppDomain == null) return tmp_Instance;

            if (CodesHook.GetAppDomain.LoadedTypes.TryGetValue(_type, out _))
            {
                return CodesHook.GetAppDomain.Instantiate(_type).CLRInstance as TType;
            }

            return tmp_Instance;
        }
    }
}