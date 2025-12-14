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
using System.Linq;
using System.Reflection;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLRBinding.Adapter;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    //主工程多重继承后跨域继承的生成适配器后用这个
    public class MultipleInheritanceCreation : IScriptCreation
    {
        public bool CanHandle(Type _baseType)
        {
            if (_baseType == null) return false;
            var tmp_NeedAdapter = _baseType.GetInterfaces().Contains(typeof(CrossBindingAdaptorType));
            var tmp_IsMono = _baseType.IsSubclassOf(typeof(MonoBehaviour));
            var tmp_NotXRMODAdapter = _baseType != typeof(XRMODBehaviourAdapter.Adapter);
            return tmp_NeedAdapter && tmp_IsMono && tmp_NotXRMODAdapter;
        }

        public void Create(GameObject _target, ILTypeInstance _ilTypeInstance, MonoData _monoData, ILType _ilType)
        {
            Type tmp_AdapterType = null;
            var tmp_ReflectionType = _ilType.ReflectionType;

            foreach (Assembly tmp_Assembly in System.AppDomain.CurrentDomain.GetAssemblies())
            {
                var tmp_ComponentType =
                    tmp_Assembly.GetType(tmp_ReflectionType.BaseType?.FullName ?? String.Empty);
                if (tmp_ComponentType == null) continue;
                tmp_AdapterType = tmp_ComponentType;
                break;
            }

            if (tmp_AdapterType == null)
            {
                Debug.LogError($"{tmp_ReflectionType.BaseType?.FullName} need to generate adapter.");
                return;
            }


            var tmp_AdapterComponent = _target.AddComponent(tmp_AdapterType);
            var tmp_ILInstanceInfo = tmp_ReflectionType.GetFields(Utility.CONST_ALL_BINDING_FLAGS)
                .First(f => f.Name == "instance" && f.FieldType == typeof(ILTypeInstance));
            var tmp_AppDomainInfo = tmp_ReflectionType.GetFields(Utility.CONST_ALL_BINDING_FLAGS)
                .First(f => f.Name == "appdomain" && f.FieldType == typeof(AppDomain));

            tmp_ILInstanceInfo.SetValue(tmp_AdapterComponent, _ilTypeInstance);
            tmp_AppDomainInfo.SetValue(tmp_AdapterComponent, CodesHook.GetAppDomain);
            _ilTypeInstance.CLRInstance = tmp_AdapterComponent;
            _monoData.ClrInstance = (CrossBindingAdaptorType) tmp_AdapterComponent;
            _monoData.Added = true;
            Utility.InvokeConstructor(_ilTypeInstance, _ilType);
        }
    }

    public static class TypeExtensions
    {
        public static Type GetTopBaseType(this Type _type)
        {
            Type tmp_Top = _type;
            while (tmp_Top.BaseType != null &&
                   !tmp_Top.BaseType.GetInterfaces().Contains(typeof(CrossBindingAdaptorType)))
            {
                tmp_Top = tmp_Top.BaseType;
            }

            return tmp_Top;
        }
    }
}