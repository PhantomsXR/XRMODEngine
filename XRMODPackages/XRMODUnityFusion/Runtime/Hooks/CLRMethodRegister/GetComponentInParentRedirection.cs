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
using UnityEngine;
using UnityFusion.CLR.Method;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLR.Utils;
using UnityFusion.Reflection;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public unsafe class GetComponentInParentRedirection : AbstractRegister
    {
        public override void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);

            #region Component

            // Component.GetComponentInParent(Typeof(T))
            var tmp_Args = new Type[] {typeof(System.Type)};
            var tmp_Method = ConstData.COMPONENT_TYPE.GetMethod("GetComponentInParent", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentGetComponentInParent_1);

            // Component.GetComponentInParent(Typeof(T),true)
            tmp_Args = new Type[] {typeof(System.Type), typeof(System.Boolean)};
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethod("GetComponentInParent", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentGetComponentInParent_2);

            // Component.GetComponentInParent<T>()
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentInParent" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 0);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentGetComponentInParent_1);


            // Component.GetComponentInParent<T>(true)
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentInParent" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentGetComponentInParent_2);

            // Component.GetComponentsInParent(Typeof(T))
            tmp_Args = new Type[] {typeof(System.Type)};
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethod("GetComponentsInParent", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentGetComponentsInParent_5);


            // Component.GetComponentsInParent(Typeof(T),true)
            tmp_Args = new Type[] {typeof(System.Type), typeof(System.Boolean)};
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethod("GetComponentsInParent", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentGetComponentsInParent_6);


            // Component.GetComponentsInParent<T>()
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentsInParent" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 0);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentGetComponentsInParent_5);


            // Component.GetComponentsInParent<T>(true)
            tmp_Method = ConstData.COMPONENT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentsInParent" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, ComponentGetComponentsInParent_6);

            #endregion

            #region GameObject

            // GameObject.GetComponentInParent(Typeof(T))
            tmp_Args = new Type[] {typeof(System.Type)};
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethod("GetComponentInParent", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentInParent_3);

            // GameObject.GetComponentInParent(Typeof(T),true)
            tmp_Args = new Type[] {typeof(System.Type), typeof(System.Boolean)};
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethod("GetComponentInParent", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentInParent_4);


            // GameObject.GetComponentInParent<T>()
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentInParent" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 0);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentInParent_3);


            // GameObject.GetComponentInParent<T>(true)
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentInParent" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentInParent_4);


            // GameObject.GetComponentsInParent(Typeof(T))
            tmp_Args = new Type[] {typeof(System.Type)};
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethod("GetComponentsInParent", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentsInParent_5);


            // GameObject.GetComponentsInParent(Typeof(T),true)
            tmp_Args = new Type[] {typeof(System.Type), typeof(System.Boolean)};
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethod("GetComponentsInParent", ConstData.CONST_BINDING_FLAGS,
                null,
                tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentsInParent_6);


            // GameObject.GetComponentsInParent<T>()
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentsInParent" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 0);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentsInParent_5);


            // GameObject.GetComponentsInParent<T>(true)
            tmp_Method = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(_methodInfo => _methodInfo.Name == "GetComponentsInParent" &&
                                     _methodInfo.GetGenericArguments().Length == 1 &&
                                     _methodInfo.GetParameters().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_Method, GameObjectGetComponentsInParent_6);

            #endregion
        }


        static StackObject* ComponentGetComponentInParent_1(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
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
                GetComponentInParent(tmp_ComponentType, tmp_Component, out tmp_Res, false);
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
                GetComponentInParent(tmp_ComponentType, tmp_Component, out tmp_Res, false, tmp_ComponentType);
            }


            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }

        static StackObject* ComponentGetComponentInParent_2(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
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
                GetComponentInParent(tmp_ComponentType, tmp_Component, out tmp_Res, tmp_IncludeInactive);
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
                GetComponentInParent(tmp_ComponentType, tmp_Component, out tmp_Res, tmp_IncludeInactive,
                    tmp_ComponentType);
            }


            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }

        static StackObject* GameObjectGetComponentInParent_3(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* __ret;
            object tmp_Res = null;
            StackObject* tmp_PtrOfThisMethod;
            GameObject tmp_GameObject;
            if (_method.GenericArguments is {Length: > 0})
            {
                __ret = ILIntepreter.Minus(_esp, 1);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_GameObject =
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                object tmp_ComponentType = _method.GenericArguments[0];
                GetComponentInParent(tmp_ComponentType, tmp_GameObject, out tmp_Res, false);
            }
            else
            {
                __ret = ILIntepreter.Minus(_esp, 2);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                var tmp_ClrTypes = (Type) typeof(Type).CheckCLRTypes(
                    StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack),
                    0);
                _intp.Free(tmp_PtrOfThisMethod);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                tmp_GameObject =
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentInParent(tmp_ClrTypes, tmp_GameObject, out tmp_Res, false, tmp_ClrTypes);
            }

            return ILIntepreter.PushObject(__ret, _mStack, tmp_Res);
        }

        static StackObject* GameObjectGetComponentInParent_4(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* tmp_PtrOfThisMethod;
            StackObject* tmp_Ret;
            object tmp_Res = null;
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
                GetComponentInParent(tmp_ComponentType, tmp_GameObject, out tmp_Res, tmp_IncludeInactive);
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
                GetComponentInParent(tmp_ComponentType, tmp_GameObject, out tmp_Res, tmp_IncludeInactive,
                    tmp_ComponentType);
            }


            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }

        static StackObject* GameObjectGetComponentsInParent_5(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* tmp_PtrOfThisMethod;
            StackObject* tmp_Ret;
            object tmp_Res = null;

            GameObject tmp_Component;

            if (_method.GenericArguments is {Length: > 0})
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 1);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_Component =
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                var tmp_ComponentType = _method.GenericArguments[0];
                GetComponentsInParent(tmp_ComponentType, tmp_Component, out tmp_Res, false);
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
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentsInParent(tmp_ComponentType, tmp_Component, out tmp_Res, false, tmp_ComponentType);
            }


            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }

        static StackObject* GameObjectGetComponentsInParent_6(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* tmp_PtrOfThisMethod;
            StackObject* tmp_Ret;
            object tmp_Res = null;
            Boolean tmp_IncludeInactive;

            GameObject tmp_Component;

            if (_method.GenericArguments is {Length: > 0})
            {
                tmp_Ret = ILIntepreter.Minus(_esp, 2);
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 1);
                tmp_IncludeInactive = tmp_PtrOfThisMethod->Value == 1;
                var tmp_ComponentType = _method.GenericArguments[0];
                tmp_PtrOfThisMethod = ILIntepreter.Minus(_esp, 2);
                tmp_Component =
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentsInParent(tmp_ComponentType, tmp_Component, out tmp_Res, tmp_IncludeInactive);
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
                    (GameObject) typeof(GameObject).CheckCLRTypes(
                        StackObject.ToObject(tmp_PtrOfThisMethod, tmp_Domain, _mStack), 0);
                _intp.Free(tmp_PtrOfThisMethod);
                GetComponentsInParent(tmp_ComponentType, tmp_Component, out tmp_Res, tmp_IncludeInactive,
                    tmp_ComponentType);
            }


            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }


        static StackObject* ComponentGetComponentsInParent_5(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* tmp_PtrOfThisMethod;
            StackObject* tmp_Ret;
            object tmp_Res = null;

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
                GetComponentsInParent(tmp_ComponentType, tmp_Component, out tmp_Res, false);
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
                GetComponentsInParent(tmp_ComponentType, tmp_Component, out tmp_Res, false, tmp_ComponentType);
            }


            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }

        static StackObject* ComponentGetComponentsInParent_6(ILIntepreter _intp, StackObject* _esp, AutoList _mStack,
            CLRMethod _method, bool _isNewObj)
        {
            AppDomain tmp_Domain = _intp.AppDomain;
            StackObject* tmp_PtrOfThisMethod;
            StackObject* tmp_Ret;
            object tmp_Res = null;
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
                GetComponentsInParent(tmp_ComponentType, tmp_Component, out tmp_Res, tmp_IncludeInactive);
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
                GetComponentsInParent(tmp_ComponentType, tmp_Component, out tmp_Res, tmp_IncludeInactive,
                    tmp_ComponentType);
            }


            return ILIntepreter.PushObject(tmp_Ret, _mStack, tmp_Res);
        }


        static void GetComponentInParent<T>(object _type, T _target, out object _result,
            bool _includeInactive = false, Type _getType = null) where T : UnityEngine.Object
        {
            _result = null;
            switch (_type)
            {
                case CLRType tmp_ClrType:
                {
                    _result = _target switch
                    {
                        GameObject tmp_GameObject => tmp_GameObject.GetComponentInParent(tmp_ClrType.TypeForCLR,
                            _includeInactive),
                        Component tmp_Component => tmp_Component.GetComponentInParent(tmp_ClrType.TypeForCLR,
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
                            .GetComponentsInParent(typeof(CrossBindingAdaptorType), _includeInactive)
                            .Cast<CrossBindingAdaptorType>()
                            .FirstOrDefault(_clrInstance => _clrInstance.ILInstance != null
                                                            && _clrInstance.ILInstance.Type.CanAssignTo(
                                                                tmp_ILType)),

                        Component tmp_Component => tmp_Component
                            .GetComponentsInParent(typeof(CrossBindingAdaptorType), _includeInactive)
                            .Cast<CrossBindingAdaptorType>()
                            .FirstOrDefault(_clrInstance => _clrInstance.ILInstance != null
                                                            && _clrInstance.ILInstance.Type.CanAssignTo(
                                                                tmp_ILType)),
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
                        GameObject tmp_GameObject => tmp_GameObject.GetComponentInParent(_getType,
                            _includeInactive),
                        Component tmp_Component => tmp_Component.GetComponentInParent(_getType,
                            _includeInactive),
                        _ => _result
                    };
                    break;
            }
        }

        static void GetComponentsInParent<T>(object _type, T _target, out object _result,
            bool _includeInactive = false, Type _getType = null) where T : UnityEngine.Object
        {
            _result = null;
            switch (_type)
            {
                case CLRType tmp_ClrType:
                {
                    _result = _target switch
                    {
                        GameObject tmp_GameObject => tmp_GameObject.GetComponentsInParent(tmp_ClrType.TypeForCLR,
                            _includeInactive),
                        Component tmp_Component => tmp_Component.GetComponentsInParent(tmp_ClrType.TypeForCLR,
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
                        GameObject tmp_GameObject => tmp_GameObject.GetComponentsInParent(_getType,
                            _includeInactive),
                        Component tmp_Component => tmp_Component.GetComponentsInParent(_getType,
                            _includeInactive),
                        _ => _result
                    };
                    break;
            }
        }

        private static void GetCrossBindingAdaptorComponent<T>(T _target, out object _result,
            ILType _ilType, bool _includeInactive) where T : UnityEngine.Object
        {
            var tmp_CrossBindingAdaptorArray = _target switch
            {
                GameObject tmp_GameObject => tmp_GameObject
                    .GetComponentsInParent<CrossBindingAdaptorType>(_includeInactive)
                    .ToArray(),
                Component tmp_Component => tmp_Component
                    .GetComponentsInParent<CrossBindingAdaptorType>(_includeInactive)
                    .ToArray(),
                _ => throw new ArgumentOutOfRangeException(nameof(_target), _target, null)
            };

            Utility.GetCrossBindingAdaptorComponent(_target, out _result, _ilType, tmp_CrossBindingAdaptorArray);
        }
    }
}