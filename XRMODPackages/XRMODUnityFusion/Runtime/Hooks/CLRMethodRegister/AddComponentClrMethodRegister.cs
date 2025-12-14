// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the UnityFusion.Runtime.CodeHook.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityFusion.CLR.Method;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLR.Utils;
using UnityFusion.CLRBinding.Adapter;
using UnityFusion.Reflection;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityEngine;
using UnityEngine.Assertions;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif
namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public class AddComponentClrMethodRegister : AbstractRegister
    {
        public override unsafe void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);
            var tmp_AddComponentMethod = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(i => i.Name == "AddComponent" && i.GetGenericArguments().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_AddComponentMethod, AddComponent);

            var tmp_AddComponentMethod2 = ConstData.COMPONENT_TYPE.GetMethods().ToList()
                .Find(i => i.Name == "AddComponent" && i.GetGenericArguments().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_AddComponentMethod2, AddComponent);
        }

        /// <summary>
        /// AddComponent
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException"></exception>
        private unsafe StackObject* AddComponent(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            var ptr = __esp - 1;
            GameObject instance = StackObject.ToObject(ptr, __domain, __mStack) as GameObject;
            if (instance == null)
                throw new NullReferenceException();
            __intp.Free(ptr);

            var tmp_GenericArgument = __method.GenericArguments;
            if (tmp_GenericArgument is not {Length: 1}) return __esp;
            var tmp_Type = tmp_GenericArgument[0];

            object tmp_Res = null;

            if (tmp_Type is CLRType)
            {
                tmp_Res = instance.AddComponent(tmp_Type.TypeForCLR);
            }
            else
            {
                //We need to create the code in ARExperience manually
                //We could not use `new` key word to create the MonoBehaviour
                //new ILTypeInstance(tmp_Type as ILType, false);
                if (!appDomain.LoadedTypes.TryGetValue(tmp_Type.FullName, out tmp_Type))
                {
                    throw new KeyNotFoundException();
                }

                ILTypeInstance tmp_ILInstance = new ILTypeInstance(tmp_Type as ILType, false);
                Type tmp_ReflectionType = tmp_Type.ReflectionType;
                Type tmp_BaseType = tmp_ReflectionType.BaseType is UnityFusionWrapperType tmp_WrapperType
                    ? tmp_WrapperType.RealType
                    : tmp_ReflectionType.BaseType;

                bool tmp_NeedAdapter = tmp_BaseType != null &&
                                       tmp_BaseType.GetInterfaces().Contains(typeof(CrossBindingAdaptorType));
                if (tmp_NeedAdapter && tmp_BaseType != typeof(XRMODBehaviourAdapter.Adapter))
                {
                    Type tmp_AdapterType = null;

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
                        return ILIntepreter.PushObject(ptr, __mStack, tmp_Res);
                    }


                    var tmp_AdapterComponent = instance.AddComponent(tmp_AdapterType);

                    var tmp_ILInstanceInfo = tmp_ReflectionType.GetFields(
                            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                        .First(f => f.Name == "instance" && f.FieldType == typeof(ILTypeInstance));
                    var tmp_AppDomainInfo = tmp_ReflectionType.GetFields(
                            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                        .First(f => f.Name == "appdomain" && f.FieldType == typeof(AppDomain));

                    tmp_ILInstanceInfo.SetValue(tmp_AdapterComponent, tmp_ILInstance);
                    tmp_AppDomainInfo.SetValue(tmp_AdapterComponent, __domain);
                    tmp_ILInstance.CLRInstance = tmp_AdapterComponent;
                    var tmp_Constructor = tmp_ILInstance.Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_ILInstance, null);
                    }


                    var tmp_AwakeMethod = tmp_AdapterComponent.GetType().GetMethod("Awake",
                        BindingFlags.Default | BindingFlags.Public
                                             | BindingFlags.Instance | BindingFlags.FlattenHierarchy |
                                             BindingFlags.NonPublic | BindingFlags.Static);

                    if (tmp_AwakeMethod == null)
                    {
                        tmp_AwakeMethod = tmp_ReflectionType.GetMethod("Awake",
                            BindingFlags.Default | BindingFlags.Public
                                                 | BindingFlags.Instance | BindingFlags.FlattenHierarchy |
                                                 BindingFlags.NonPublic | BindingFlags.Static);
                    }

                    if (tmp_AwakeMethod != null)
                        tmp_AwakeMethod.Invoke(tmp_AdapterComponent, null);
                }
                else
                {
                    var tmp_AdapterInstance = instance.AddComponent<XRMODBehaviourAdapter.Adapter>();
                    tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                    tmp_AdapterInstance.AppDomain = __domain;
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;

                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_ILInstance, null);
                    }

                    tmp_AdapterInstance.Awake();
                }

                tmp_Res = tmp_ILInstance;
            }

            return ILIntepreter.PushObject(ptr, __mStack, tmp_Res);
        }
    }
}