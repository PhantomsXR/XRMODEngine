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
using UnityEditor;
using UnityFusion.CLR.Method;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityEngine;
using UnityEngine.Assertions;
using UnityFusion.CLR.Utils;
using UnityFusion.CLRBinding.Adapter;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;
using Object = UnityEngine.Object;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public class GetComponentClrMethodRegister : AbstractRegister
    {
        public override unsafe void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;

            var getComponentsMethod = ConstData.COMPONENT_TYPE.GetMethods().ToList()
                .Find(i => i.Name == "GetComponents" && i.GetGenericArguments().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(getComponentsMethod, GetComponents);
            var getComponentsMethod2 = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(i => i.Name == "GetComponents" && i.GetGenericArguments().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(getComponentsMethod2, GetComponents);


            // Get component via generic type
            var tmp_GetComponentMethod = ConstData.COMPONENT_TYPE.GetMethods().ToList()
                .Find(_i => _i.Name == "GetComponent" && _i.GetGenericArguments().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_GetComponentMethod, GetComponent);

            var tmp_GetComponentMethod1 = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(_i => _i.Name == "GetComponent" && _i.GetGenericArguments().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_GetComponentMethod1, GetComponent);

            var tmp_TryGetComponentMethod1 = ConstData.COMPONENT_TYPE.GetMethods().ToList()
                .Find(_i => _i.Name == "TryGetComponent" && _i.GetGenericArguments().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_TryGetComponentMethod1, TryGetComponent);

            var tmp_TryGetComponentMethod2 = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(_i => _i.Name == "TryGetComponent" && _i.GetGenericArguments().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_TryGetComponentMethod2, TryGetComponent);

            // Get component via string
            var args = new[] {typeof(String)};
            var getComponentMethod3 = ConstData.GAME_OBJECT_TYPE.GetMethod("GetComponent", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(getComponentMethod3, GetComponentViaString);
            var getComponentMethod4 = ConstData.COMPONENT_TYPE.GetMethod("GetComponent", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(getComponentMethod4, GetComponentViaString);
        }
        
        private unsafe StackObject* GetComponent(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            var ptr = __esp - 1;
            var instance = StackObject.ToObject(ptr, __domain, __mStack);
            __intp.Free(ptr);

            var genericArgument = __method.GenericArguments;
            if (genericArgument == null || genericArgument.Length != 1) return __esp;
            GameObject tmp_GameObject;
            switch (instance)
            {
                case GameObject tmp_Instance:
                    tmp_GameObject = tmp_Instance;
                    break;
                case Component tmp_Component:
                    tmp_GameObject = tmp_Component.gameObject;
                    break;
                case ILTypeInstance tmp_IlTypeInstance:
                    tmp_GameObject = Utility.FindGameFromILTypeInstance(tmp_IlTypeInstance);
                    break;
                default:
                    Debug.LogError(
                        $"[Get Component Error]: Not Support type of parameter:{instance.GetType().FullName}");
                    return __esp;
            }

            var type = genericArgument[0];
            object res = null;
            if (type is CLRType)
            {
                res = tmp_GameObject.GetComponent(type.TypeForCLR);
                if (res is CrossBindingAdaptorType crossBindingAdaptorType)
                {
                    res = crossBindingAdaptorType.ILInstance;
                }
            }
            else
            {
                var clrInstances = tmp_GameObject.GetComponents(typeof(CrossBindingAdaptorType))
                    .Cast<CrossBindingAdaptorType>().ToArray();

                foreach (var clrInstance in clrInstances)
                {
                    if (clrInstance.ILInstance == null) continue;
                    if (!clrInstance.ILInstance.Type.CanAssignTo(type)) continue;
                    res = clrInstance.ILInstance;
                    break;
                }
            }

            return ILIntepreter.PushObject(ptr, __mStack, res);
        }

        private unsafe static StackObject* TryGetComponent(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Component @component =
                (UnityEngine.Component) typeof(UnityEngine.Component).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (Extensions.TypeFlags) 0);

            if (__method.GenericArguments.Length == 0) return __esp;
            var tmp_ComponentType = __method.GenericArguments[0];
            Dictionary<string, CrossBindingAdaptorType> tmp_AllComponentILDict =
                new Dictionary<string, CrossBindingAdaptorType>();

            var tmp_ComponentAttacher = __mStack.Find(_obj => _obj is GameObject or Component);
            if (tmp_ComponentAttacher == null)
                throw new System.NullReferenceException();
            GameObject tmp_GameObject;
            switch (tmp_ComponentAttacher)
            {
                case GameObject tmp_Instance:
                    tmp_GameObject = tmp_Instance;
                    break;
                case Component tmp_Component:
                    tmp_GameObject = tmp_Component.gameObject;
                    break;
                case ILTypeInstance tmp_IlTypeInstance:
                    tmp_GameObject = Utility.FindGameFromILTypeInstance(tmp_IlTypeInstance);
                    break;
                default:
                    Debug.LogError(
                        $"[Get Component Error]: Not Support type of parameter:{tmp_ComponentAttacher.GetType().FullName}");
                    return __esp;
            }

            bool tmp_Result_of_this_method = false;
            if (tmp_ComponentType is CLRType)
            {
                tmp_Result_of_this_method =
                    tmp_GameObject.TryGetComponent(tmp_ComponentType.TypeForCLR, out @component);
            }
            else
            {
                var tmp_AllComponents = tmp_GameObject.GetComponents(typeof(CrossBindingAdaptorType));
                var tmp_ClrInstances = tmp_AllComponents.Cast<CrossBindingAdaptorType>().ToArray();

                // 确保序列唯一，一一对齐
                Dictionary<string, Component> tmp_AllComponentDict = new Dictionary<string, Component>();
                foreach (Component tmp_Component in tmp_AllComponents)
                {
                    var tmp_AdaptorType = tmp_Component as CrossBindingAdaptorType;
                    var tmp_FullName = tmp_AdaptorType.ILInstance.Type.FullName;
                    if (tmp_AdaptorType.ILInstance.Type.CanAssignTo(tmp_ComponentType))
                    {
                        tmp_AllComponentDict.TryAdd(tmp_ComponentType.FullName, tmp_Component);
                        tmp_AllComponentILDict.TryAdd(tmp_ComponentType.FullName, tmp_AdaptorType);
                    }

                    tmp_AllComponentDict.TryAdd(tmp_FullName, tmp_Component);
                }

                foreach (var clrInstance in tmp_ClrInstances)
                {
                    if (clrInstance.ILInstance == null) continue;
                    if (!tmp_AllComponentDict.TryGetValue(tmp_ComponentType.FullName, out component)) continue;
                    tmp_Result_of_this_method = true;
                    break;
                }
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    object ___obj = @component;

                    if (___dst->ObjectType >= ObjectTypes.Object)
                    {
                        if (___obj is CrossBindingAdaptorType)
                            ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                        __mStack[___dst->Value] = ___obj;
                        return ILIntepreter.PushObject(ptr_of_this_method, __mStack, ___obj);
                    }
                    else
                    {
                        ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                    }
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        // 适配Interface，当继承XRMODBehaviour或者MonoBehaviour时又实现了Interface
                        if (tmp_ComponentType.IsInterface
                            && tmp_AllComponentILDict.TryGetValue(tmp_ComponentType.FullName, out var tmp_ILInstance)
                            && tmp_ILInstance.ILInstance != null)
                        {
                            ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = tmp_ILInstance.ILInstance;
                            return ILIntepreter.PushObject(ptr_of_this_method, __mStack, tmp_ILInstance.ILInstance);
                        }
                        else
                            ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @component;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @component);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @component;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @component);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Component[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @component;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = tmp_Result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static unsafe StackObject* GetComponents(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            var ins = StackObject.ToObject(ptr_of_this_method, __domain, __mStack);
            if (ins == null)
                throw new NullReferenceException();
            __intp.Free(ptr_of_this_method);

            var genericArgument = __method.GenericArguments;
            if (genericArgument != null && genericArgument.Length == 1)
            {
                var type = genericArgument[0];
                object res;
                GameObject instance = ins.GetGameObject();

                if (type is CLRType)
                {
                    //Unity主工程的类不需要任何特殊处理，直接调用Unity接口
                    var result = instance != null ? instance.GetComponents(type.TypeForCLR) : null;
                    res = result;
                    if (result != null)
                    {
                        int n = result.Length;
                        res = Array.CreateInstance(type.TypeForCLR, n);
                        for (int i = 0; i < n; i++)
                            ((Array) res).SetValue(result[i], i);
                    }
                }
                else
                {
                    var ilInstances = Utility.GetILComponents(instance, type as ILType);
                    int n = ilInstances.Length;
                    res = Array.CreateInstance(type.TypeForCLR, n);
                    for (int i = 0; i < n; i++)
                        ((Array) res).SetValue(((ILTypeInstance) ilInstances[i]).CLRInstance, i);
                }

                return ILIntepreter.PushObject(ptr_of_this_method, __mStack, res);
            }

            return __esp;
        }

        // <summary>
        /// Get的字符串参数重定向
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        private static unsafe StackObject* GetComponentViaString(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            String type =
                (String) typeof(String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            GameObject instance_of_this_method =
                (GameObject) typeof(GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            object result_of_this_method = instance_of_this_method.GetComponent(type); //先从本地匹配

            if (result_of_this_method == null) //本地没再从热更匹配
            {
                var typeName = __domain.LoadedTypes.Keys.ToList().Find(k => k.EndsWith(type));
                if (typeName != null) //如果有这个热更类型
                {
                    result_of_this_method = Utility.GetILComponent(instance_of_this_method, __domain, type);
                }
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}