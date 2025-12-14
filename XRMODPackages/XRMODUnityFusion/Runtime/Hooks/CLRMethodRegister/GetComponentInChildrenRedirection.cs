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

using System;
using System.Collections.Generic;
using System.Linq;
using Phantom.XRMOD.UnityFusion.Runtime;
using UnityEngine;
using UnityFusion.CLR.Method;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLR.Utils;
using UnityFusion.Reflection;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;
using Object = UnityEngine.Object;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public unsafe class GetComponentInChildrenRedirection : AbstractRegister
    {
        public override void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);

            #region Component

            // Component.GetComponentInChildren(Typeof(T))
            var tmp_Args = new Type[] {typeof(System.Type)};
            var tmp_Method = ConstData.COMPONENT_TYPE.GetMethod("GetComponentInChildren", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentComponentGetComponentInChildren_1);

            // Component.GetComponentInChildren(Typeof(T),true)
            tmp_Args = new Type[] {typeof(System.Type), typeof(System.Boolean)};
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethod("GetComponentInChildren", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentComponentGetComponentInChildren_2);

            // Component.GetComponentInChildren<T>()
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentInChildren" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 0);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentComponentGetComponentInChildren_1);


            // Component.GetComponentInChildren<T>(true)
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentInChildren" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentComponentGetComponentInChildren_2);

            // Component.GetComponentsInChildren(Typeof(T))
            tmp_Args = new Type[] {typeof(System.Type)};
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethod("GetComponentsInChildren", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentGetComponentsInChildren_5);


            // Component.GetComponentsInChildren(Typeof(T),true)
            tmp_Args = new Type[] {typeof(System.Type), typeof(System.Boolean)};
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethod("GetComponentsInChildren", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentGetComponentsInChildren_6);


            // Component.GetComponentsInChildren<T>()
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentsInChildren" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 0);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentGetComponentsInChildren_5);


            // Component.GetComponentsInChildren<T>(true)
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentsInChildren" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentGetComponentsInChildren_6);

            #endregion

            #region GameObject

            // GameObject.GetComponentInChildren(Typeof(T))
            tmp_Args = new Type[] {typeof(System.Type)};
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethod("GetComponentInChildren", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentInChildren_3);

            // GameObject.GetComponentInChildren(Typeof(T),true)
            tmp_Args = new Type[] {typeof(System.Type), typeof(System.Boolean)};
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethod("GetComponentInChildren", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentInChildren_4);


            // GameObject.GetComponentInChildren<T>()
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentInChildren" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 0);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentInChildren_3);


            // GameObject.GetComponentInChildren<T>(true)
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentInChildren" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentInChildren_4);


            // GameObject.GetComponentsInChildren(Typeof(T))
            tmp_Args = new Type[] {typeof(System.Type)};
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethod("GetComponentsInChildren", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentsInChildren_5);


            // GameObject.GetComponentsInChildren(Typeof(T),true)
            tmp_Args = new Type[] {typeof(System.Type), typeof(System.Boolean)};
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethod("GetComponentsInChildren", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentsInChildren_6);


            // GameObject.GetComponentsInChildren<T>()
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentsInChildren" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 0);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentsInChildren_5);


            // GameObject.GetComponentsInChildren<T>(true)
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentsInChildren" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentsInChildren_6);

            #endregion
        }

        #region Component

        static StackObject* ComponentComponentGetComponentInChildren_1(ILIntepreter _intp, StackObject* _esp,
            AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* tmp_PtrOfThisMethod;
            object tmp_Res;
            Component tmp_Component;
            StackObject* tmp_Ret;

            if (_method.GenericArguments is {Length: > 0})
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 1);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_Component =
                    (Component) typeof(Component).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                var tmp_ComponentType = _method.GenericArguments[0];
                GetComponentInChildren(tmp_ComponentType, tmp_Component, out tmp_Res);
            }
            else
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 2);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                var tmp_ComponentType = (Type) typeof(Type).CheckCLRTypes(
                    StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);

                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                tmp_Component =
                    (Component) typeof(Component).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentInChildren(tmp_ComponentType, tmp_Component, out tmp_Res, false, tmp_ComponentType);
            }

            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }

        static StackObject* ComponentComponentGetComponentInChildren_2(ILIntepreter _intp, StackObject* _esp,
            AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* tmp_PtrOfThisMethod;
            StackObject* tmp_Ret;
            object tmp_Res;
            Boolean tmp_IncludeInactive;

            Component tmp_Component;

            if (_method.GenericArguments is {Length: > 0})
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 2);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_IncludeInactive = tmp_PtrOfThisMethod->Value == 1;
                var tmp_ComponentType = _method.GenericArguments[0];
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                tmp_Component =
                    (Component) typeof(Component).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentInChildren(tmp_ComponentType, tmp_Component, out tmp_Res, tmp_IncludeInactive);
            }
            else
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 3);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_IncludeInactive = tmp_PtrOfThisMethod->Value == 1;

                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                var tmp_ComponentType = (Type) typeof(Type).CheckCLRTypes(
                    StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);

                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 3);
                tmp_Component =
                    (Component) typeof(Component).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentInChildren(tmp_ComponentType, tmp_Component, out tmp_Res, tmp_IncludeInactive,
                    tmp_ComponentType);
            }


            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }

        static StackObject* ComponentGetComponentsInChildren_5(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* tmp_PtrOfThisMethod;
            StackObject* tmp_Ret;
            object tmp_Res;

            Component tmp_Component;

            if (_method.GenericArguments is {Length: > 0})
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 1);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_Component =
                    (Component) typeof(Component).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                var tmp_ComponentType = _method.GenericArguments[0];
                GetComponentsInChildren(tmp_ComponentType, tmp_Component, out tmp_Res);
            }
            else
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 2);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                var tmp_ComponentType = (Type) typeof(Type).CheckCLRTypes(
                    StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);

                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                tmp_Component =
                    (Component) typeof(Component).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentsInChildren(tmp_ComponentType, tmp_Component, out tmp_Res, false, tmp_ComponentType);
            }

            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }

        static StackObject* ComponentGetComponentsInChildren_6(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* tmp_PtrOfThisMethod;
            StackObject* tmp_Ret;
            object tmp_Res;
            Boolean tmp_IncludeInactive;

            Component tmp_Component;

            if (_method.GenericArguments is {Length: > 0})
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 2);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_IncludeInactive = tmp_PtrOfThisMethod->Value == 1;
                var tmp_ComponentType = _method.GenericArguments[0];
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                tmp_Component =
                    (Component) typeof(Component).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentsInChildren(tmp_ComponentType, tmp_Component, out tmp_Res, tmp_IncludeInactive);
            }
            else
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 3);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_IncludeInactive = tmp_PtrOfThisMethod->Value == 1;

                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                var tmp_ComponentType = (Type) typeof(Type).CheckCLRTypes(
                    StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);

                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 3);
                tmp_Component =
                    (Component) typeof(Component).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentsInChildren(tmp_ComponentType, tmp_Component, out tmp_Res, tmp_IncludeInactive,
                    tmp_ComponentType);
            }


            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }

        #endregion

        #region GameObject

        static StackObject* GameObjectGetComponentInChildren_3(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* tmp_PtrOfThisMethod;
            object tmp_Res;
            GameObject tmp_GameObject;
            StackObject* tmp_Ret;
            if (_method.GenericArguments is {Length: > 0})
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 1);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_GameObject =
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                var tmp_ComponentType = _method.GenericArguments[0];
                GetComponentInChildren(tmp_ComponentType, tmp_GameObject, out tmp_Res, false);
            }
            else
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 2);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                var tmp_ComponentType = (Type) typeof(Type).CheckCLRTypes(
                    StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);

                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                tmp_GameObject =
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentInChildren(tmp_ComponentType, tmp_GameObject, out tmp_Res, false, tmp_ComponentType);
            }


            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }

        static StackObject* GameObjectGetComponentInChildren_4(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* tmp_PtrOfThisMethod;
            StackObject* tmp_Ret;
            object tmp_Res;
            Boolean tmp_IncludeInactive;

            GameObject tmp_GameObject;

            if (_method.GenericArguments is {Length: > 0})
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 2);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_IncludeInactive = tmp_PtrOfThisMethod->Value == 1;
                var tmp_ComponentType = _method.GenericArguments[0];
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                tmp_GameObject =
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentInChildren(tmp_ComponentType, tmp_GameObject, out tmp_Res, false);
            }
            else
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 3);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_IncludeInactive = tmp_PtrOfThisMethod->Value == 1;

                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                var tmp_ComponentType = (Type) typeof(Type).CheckCLRTypes(
                    StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);

                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 3);
                tmp_GameObject =
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentInChildren(tmp_ComponentType, tmp_GameObject, out tmp_Res, false, tmp_ComponentType);
            }


            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res, tmp_IncludeInactive);
        }

        static StackObject* GameObjectGetComponentsInChildren_5(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* tmp_PtrOfThisMethod;
            StackObject* tmp_Ret;
            object tmp_Res;

            GameObject tmp_GameObject;

            if (_method.GenericArguments is {Length: > 0})
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 1);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_GameObject =
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                var tmp_ComponentType = _method.GenericArguments[0];
                GetComponentsInChildren(tmp_ComponentType, tmp_GameObject, out tmp_Res, false);
            }
            else
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 2);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                var tmp_ComponentType = (Type) typeof(Type).CheckCLRTypes(
                    StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);

                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                tmp_GameObject =
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentsInChildren(tmp_ComponentType, tmp_GameObject, out tmp_Res, false, tmp_ComponentType);
            }


            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }

        static StackObject* GameObjectGetComponentsInChildren_6(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* tmp_PtrOfThisMethod;
            StackObject* tmp_Ret;
            object tmp_Res;
            Boolean tmp_IncludeInactive;

            GameObject tmp_GameObject;

            if (_method.GenericArguments is {Length: > 0})
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 2);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_IncludeInactive = tmp_PtrOfThisMethod->Value == 1;
                var tmp_ComponentType = _method.GenericArguments[0];
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                tmp_GameObject =
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentsInChildren(tmp_ComponentType, tmp_GameObject, out tmp_Res, tmp_IncludeInactive);
            }
            else
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 3);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_IncludeInactive = tmp_PtrOfThisMethod->Value == 1;

                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                var tmp_ComponentType = (Type) typeof(Type).CheckCLRTypes(
                    StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);

                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 3);
                tmp_GameObject =
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentsInChildren(tmp_ComponentType, tmp_GameObject, out tmp_Res, tmp_IncludeInactive,
                    tmp_ComponentType);
            }


            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }

        #endregion

        static void GetComponentInChildren<T>(object _type, T _target, out object _result,
            bool _includeInactive = false, Type _getType = null) where T : Object
        {
            _result = null;
            switch (_type)
            {
                case CLRType tmp_ClrType:
                {
                    _result = _target switch
                    {
                        GameObject tmp_GameObject => tmp_GameObject.GetComponentInChildren(tmp_ClrType.TypeForCLR,
                            _includeInactive),
                        Component tmp_Component => tmp_Component.GetComponentInChildren(tmp_ClrType.TypeForCLR,
                            _includeInactive),
                        _ => _result
                    };

                    if (_result is CrossBindingAdaptorType tmp_CrossBindingAdaptorType)
                    {
                        _result = tmp_CrossBindingAdaptorType.ILInstance;
                    }

                    break;
                }
                case ILType tmp_ILType:
                {
                    var tmp_ClrInstance = _target switch
                    {
                        GameObject tmp_GameObject => tmp_GameObject
                            .GetComponentsInChildren(typeof(CrossBindingAdaptorType), _includeInactive)
                            .Cast<CrossBindingAdaptorType>()
                            .FirstOrDefault(_clrInstance => _clrInstance.ILInstance != null
                                                            && _clrInstance.ILInstance.Type.CanAssignTo(tmp_ILType)),

                        Component tmp_Component => tmp_Component
                            .GetComponentsInChildren(typeof(CrossBindingAdaptorType), _includeInactive)
                            .Cast<CrossBindingAdaptorType>()
                            .FirstOrDefault(_clrInstance => _clrInstance.ILInstance != null
                                                            && _clrInstance.ILInstance.Type.CanAssignTo(tmp_ILType)),
                        _ => throw new ArgumentOutOfRangeException(nameof(_target), _target, null)
                    };

                    if (tmp_ClrInstance != null) _result = tmp_ClrInstance.ILInstance;
                    break;
                }

                case UnityFusionType tmp_UnityFusionType:
                {
                    var tmp_ClrInstance = _target switch
                    {
                        GameObject tmp_GameObject => tmp_GameObject
                            .GetComponentsInChildren(typeof(CrossBindingAdaptorType), _includeInactive)
                            .Cast<CrossBindingAdaptorType>()
                            .FirstOrDefault(_clrInstance => _clrInstance.ILInstance != null
                                                            && _clrInstance.ILInstance.Type.CanAssignTo(
                                                                tmp_UnityFusionType.ILType)),
                        Component tmp_Component => tmp_Component
                            .GetComponentsInChildren(typeof(CrossBindingAdaptorType), _includeInactive)
                            .Cast<CrossBindingAdaptorType>()
                            .FirstOrDefault(_clrInstance => _clrInstance.ILInstance != null
                                                            && _clrInstance.ILInstance.Type.CanAssignTo(
                                                                tmp_UnityFusionType.ILType)),
                        _ => throw new ArgumentOutOfRangeException(nameof(_target), _target, null)
                    };

                    if (tmp_ClrInstance != null) _result = tmp_ClrInstance.ILInstance;
                    break;
                }
                default:

                    _result = _target switch
                    {
                        GameObject tmp_GameObject => tmp_GameObject.GetComponentInChildren(_getType,
                            _includeInactive),
                        Component tmp_Component => tmp_Component.GetComponentInChildren(_getType,
                            _includeInactive),
                        _ => _result
                    };
                    break;
            }
        }

        static void GetComponentsInChildren<T>(object _type, T _target, out object _result,
            bool _includeInactive = false, Type _getType = null) where T : Object
        {
            _result = null;

            switch (_type)
            {
                case CLRType tmp_ClrType:
                {
                    _result = _target switch
                    {
                        GameObject tmp_GameObject => tmp_GameObject.GetComponentsInChildren(tmp_ClrType.TypeForCLR,
                            _includeInactive),
                        Component tmp_Component => tmp_Component.GetComponentsInChildren(tmp_ClrType.TypeForCLR,
                            _includeInactive),
                        _ => throw new ArgumentOutOfRangeException(nameof(_target), _target, null)
                    };
                    break;
                }
                case ILType tmp_ILType:
                {
                    GetCrossBindingAdaptorComponent(_target, out _result, tmp_ILType, _includeInactive);
                    break;
                }
                case UnityFusionType tmp_UnityFusionType:
                {
                    GetCrossBindingAdaptorComponent(_target, out _result, tmp_UnityFusionType.ILType, _includeInactive);
                    break;
                }
                default:
                    _result = _target switch
                    {
                        GameObject tmp_GameObject => tmp_GameObject.GetComponentsInChildren(_getType, _includeInactive),
                        Component tmp_Component => tmp_Component.GetComponentsInChildren(_getType, _includeInactive),
                        _ => throw new ArgumentOutOfRangeException(nameof(_target), _target, null)
                    };
                    break;
            }
        }

        private static void GetCrossBindingAdaptorComponent<T>(T _target, out object _result,
            ILType _ilType, bool _includeInactive) where T : Object
        {
            var tmp_CrossBindingAdaptorArray = _target switch
            {
                GameObject tmp_GameObject => tmp_GameObject
                    .GetComponentsInChildren<CrossBindingAdaptorType>(_includeInactive)
                    .ToArray(),
                Component tmp_Component => tmp_Component
                    .GetComponentsInChildren<CrossBindingAdaptorType>(_includeInactive)
                    .ToArray(),
                _ => throw new ArgumentOutOfRangeException(nameof(_target), _target, null)
            };

            Utility.GetCrossBindingAdaptorComponent(_target, out _result, _ilType, tmp_CrossBindingAdaptorArray);
        }
    }
}