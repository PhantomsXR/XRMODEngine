// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.Reflection;
using UnityFusion.Runtime.Intepreter;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public class ScriptInstantiator
    {
        private readonly List<IScriptCreation> creationStrategies;

        public ScriptInstantiator(List<IScriptCreation> _strategies)
        {
            this.creationStrategies = _strategies;
        }

        public bool InstantiateScript(GameObject _target, MonoData _data)
        {
            try
            {
                string tmp_ClassPath = $"{_data.ClassNamespace}.{_data.ClassName}";
                if (!CodesHook.GetAppDomain.LoadedTypes.TryGetValue(tmp_ClassPath, out var tmp_Type))
                {
                    return false;
                }

                Type tmp_ReflectionType = tmp_Type.ReflectionType;
                if (tmp_ReflectionType == null) return false;
                _data.ClassType = tmp_ReflectionType;

                if (tmp_ReflectionType.BaseType == null) return false;

                Type tmp_BaseType = tmp_ReflectionType.BaseType is UnityFusionWrapperType tmp_WrapperType
                    ? tmp_WrapperType.RealType
                    : tmp_ReflectionType.BaseType;


                Type tmp_MonoType = typeof(MonoBehaviour);
                bool tmp_IsMono = tmp_ReflectionType.IsSubclassOf(tmp_MonoType) ||
                                  (tmp_BaseType != null && tmp_BaseType.IsSubclassOf(tmp_MonoType));
                ILTypeInstance tmp_ILInstance = tmp_IsMono
                    ? new ILTypeInstance(tmp_Type as ILType, false)
                    : CodesHook.GetAppDomain.Instantiate(tmp_ClassPath);
                tmp_ILInstance.CLRInstance = tmp_ILInstance;
                _target.SetActive(false);
                
                
                var tmp_Strategy = creationStrategies.FirstOrDefault(_s => _s.CanHandle(tmp_BaseType));

                if (tmp_Strategy != null)
                {
                    tmp_Strategy.Create(_target, tmp_ILInstance, _data, tmp_Type as ILType);
                    return true;
                }

                Debug.LogWarning($"No creation strategy found for base type: {tmp_BaseType?.FullName}");
                return false;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogException(tmp_Exception);
                throw;
            }
        }
    }
}