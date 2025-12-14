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
using System.Reflection;
using UnityFusion.CLR.Method;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLR.Utils;
using UnityFusion.Reflection;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityEngine;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;
using Object = UnityEngine.Object;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public class FindObjectOfTypeClrMethodRegister : AbstractRegister
    {
        public override unsafe void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;

            var objectType = typeof(UnityEngine.Object);
            var args = new Type[] {typeof(System.Type)};

            #region FindObjectsOfType

            // Object FindObjectOfType(Type type);
            var findObjectsOfTypeMethod2 = objectType.GetMethod("FindObjectsOfType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(findObjectsOfTypeMethod2, FindObjectsOfType_Object_1p);

            // Object[] FindObjectsOfType(Type type, bool includeInactive);
            args = new Type[] {typeof(System.Type), typeof(Boolean)};
            var findObjectsOfTypeMethod3 = objectType.GetMethod("FindObjectsOfType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(findObjectsOfTypeMethod3, FindObjectsOfType_Object_2p);

            // T[] FindObjectsOfType();
            args = Type.EmptyTypes;
            var findObjectsOfTypeMethod4 = objectType.GetMethod("FindObjectsOfType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(findObjectsOfTypeMethod4, FindObjectsOfType_T_0p);

            // T[] FindObjectsOfType(bool includeInactive);
            args = new Type[] {typeof(bool)};
            var findObjectsOfTypeMethod5 = objectType.GetMethod("FindObjectsOfType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(findObjectsOfTypeMethod5, FindObjectsOfType_T_1p);

            #endregion

            #region FindObjectOfType

            // T FindObjectOfType();
            args = Type.EmptyTypes;
            var tmp_FindObjectOfType11 = objectType.GetMethod("FindObjectOfType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_FindObjectOfType11, FindObjectOfType_T_0p);

            // T FindObjectOfType(bool includeInactive);
            args = new Type[] {typeof(bool)};
            var tmp_FindObjectOfType12 = objectType.GetMethod("FindObjectOfType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_FindObjectOfType12, FindObjectOfType_T_1p);

            // Object FindObjectOfType(Type type);
            args = new Type[] {typeof(System.Type)};
            var tmp_FindObjectOfType13 = objectType.GetMethod("FindObjectOfType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_FindObjectOfType13, FindObjectOfType_Object_1p);

            // Object FindObjectOfType(Type type, bool includeInactive);
            args = new Type[] {typeof(System.Type), typeof(Boolean)};
            var tmp_FindObjectOfType14 = objectType.GetMethod("FindObjectOfType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_FindObjectOfType14, FindObjectOfType_Object_2p);

            #endregion

            #region FindObjectsByType

            // Object[] FindObjectsByType(Type type, FindObjectsSortMode sortMode);
            args = new Type[] {typeof(System.Type), typeof(FindObjectsSortMode)};
            var FindObjectsByTypeMethod1 = objectType.GetMethod("FindObjectsByType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(FindObjectsByTypeMethod1, FindObjectsByType_Object_2p);

            // Object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode);
            args = new Type[] {typeof(System.Type), typeof(FindObjectsInactive), typeof(FindObjectsSortMode)};
            var FindObjectsByTypeMethod2 = objectType.GetMethod("FindObjectsByType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(FindObjectsByTypeMethod2, FindObjectsByType_Object_3p);

            // T[] FindObjectsByType(FindObjectsSortMode sortMode);
            args = new Type[] {typeof(FindObjectsSortMode)};
            var FindObjectsByTypeMethod = objectType.GetMethod("FindObjectsByType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(FindObjectsByTypeMethod, FindObjectsByType_T_1p);

            // T[] FindObjectsByType(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode);
            args = new Type[] {typeof(FindObjectsInactive), typeof(FindObjectsSortMode)};
            var FindObjectsByTypeMethod3 = objectType.GetMethod("FindObjectsByType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(FindObjectsByTypeMethod3, FindObjectsByType_T_2p);

            #endregion

            #region FindAnyObjectByType

            // FindAnyObjectByType
            args = Type.EmptyTypes;
            var FindAnyObjectByTypeMethod = objectType.GetMethod("FindAnyObjectByType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(FindAnyObjectByTypeMethod, FindAnyObjectByType_T_0p);

            args = new Type[] {typeof(FindObjectsInactive)};
            var FindAnyObjectByTypeMethod3 = objectType.GetMethod("FindAnyObjectByType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(FindAnyObjectByTypeMethod3, FindAnyObjectByType_T_1p);

            args = new Type[] {typeof(System.Type), typeof(FindObjectsInactive)};
            var FindAnyObjectByTypeMethod1 = objectType.GetMethod("FindAnyObjectByType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(FindAnyObjectByTypeMethod1, FindAnyObjectByType_Object_2p);

            args = new Type[] {typeof(System.Type)};
            var FindAnyObjectByTypeMethod2 = objectType.GetMethod("FindAnyObjectByType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(FindAnyObjectByTypeMethod2, FindAnyObjectByType_Object_1p);

            #endregion

            #region FindFirstObjectByType

            // FindFirstObjectByType
            args = new Type[] {typeof(System.Type)};
            var FindFirstObjectByTypeMethod2 = objectType.GetMethod("FindFirstObjectByType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(FindFirstObjectByTypeMethod2, FindFirstObjectByType_Object_1p);

            args = new Type[] {typeof(System.Type), typeof(FindObjectsInactive)};
            var FindFirstObjectByTypeMethod1 = objectType.GetMethod("FindFirstObjectByType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(FindFirstObjectByTypeMethod1, FindFirstObjectByType_Object_2p);

            args = Type.EmptyTypes;
            var FindFirstObjectByTypeMethod = objectType.GetMethod("FindFirstObjectByType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(FindFirstObjectByTypeMethod, FindFirstObjectByType_T_0p);

            args = new Type[] {typeof(FindObjectsInactive)};
            var FindFirstObjectByTypeMethod3 = objectType.GetMethod("FindFirstObjectByType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(FindFirstObjectByTypeMethod3, FindFirstObjectByType_T_1p);

            #endregion
        }

        private unsafe StackObject* FindObjectsOfType_T_0p(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var genericArgument = __method.GenericArguments;

            if (genericArgument != null && genericArgument.Length == 1)
            {
                var type = genericArgument[0];
                object res;
                if (type is CLRType)
                {
                    res = UnityEngine.Object.FindObjectsByType(type.TypeForCLR, FindObjectsSortMode.None);
                }
                else
                {
                    var adapters = CommonUtility.GetAllMonoAdapters();

                    var ilInstances = CommonUtility.GetHotComponents(adapters, type as ILType);
                    int length = ilInstances.Length;
                    res = Array.CreateInstance(type.TypeForCLR, length);
                    for (int idx = 0; idx < length; idx++)
                    {
                        ((Array) res).SetValue(ilInstances[idx].CLRInstance, idx);
                    }
                }

                return ILIntepreter.PushObject(__ret, __mStack, res);
            }

            return __esp;
        }

        private unsafe StackObject* FindObjectsOfType_T_1p(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            StackObject* ptr_of_this_method;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            bool @includeInactive = ptr_of_this_method->Value == 1;
            __intp.Free(ptr_of_this_method);

            var genericArgument = __method.GenericArguments;

            if (genericArgument != null && genericArgument.Length == 1)
            {
                var type = genericArgument[0];
                object res;
                if (type is CLRType)
                {
                    res = UnityEngine.Object.FindObjectsByType(type.TypeForCLR, FindObjectsSortMode.None);
                }
                else
                {
                    var adapters = CommonUtility.GetAllMonoAdapters(_findObjectsInactive: includeInactive
                        ? FindObjectsInactive.Include
                        : FindObjectsInactive.Exclude);

                    var ilInstances = CommonUtility.GetHotComponents(adapters, type as ILType);
                    int length = ilInstances.Length;
                    res = Array.CreateInstance(type.TypeForCLR, length);
                    for (int idx = 0; idx < length; idx++)
                    {
                        ((Array) res).SetValue(ilInstances[idx].CLRInstance, idx);
                    }
                }

                return ILIntepreter.PushObject(__ret, __mStack, res);
            }

            return __esp;
        }

        static unsafe StackObject* FindObjectsOfType_Object_1p(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            StackObject* ptr_of_this_method;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type =
                (System.Type) typeof(System.Type).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            object res;
            if (type is UnityFusionType ilType)
            {
                var adapters = CommonUtility.GetAllMonoAdapters();
                var ilInstances = ((ILTypeInstance[]) CommonUtility.GetHotComponents(adapters, ilType.ILType));
                int n = ilInstances.Length;
                res = Array.CreateInstance(ilType.ILType.TypeForCLR, n);
                for (int i = 0; i < n; i++)
                    ((Array) res).SetValue(ilInstances[i].CLRInstance, i);
            }
            else
            {
                res = UnityEngine.Object.FindObjectsByType(type, FindObjectsSortMode.None);
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        static unsafe StackObject* FindObjectsOfType_Object_2p(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            StackObject* ptr_of_this_method;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            bool @includeInactive = ptr_of_this_method->Value == 1;
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @type =
                (System.Type) typeof(System.Type).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);


            object res;
            if (type is UnityFusionType ilType)
            {
                var adapters =
                    CommonUtility.GetAllMonoAdapters(_findObjectsInactive: includeInactive
                        ? FindObjectsInactive.Include
                        : FindObjectsInactive.Exclude);
                var ilInstances = ((ILTypeInstance[]) CommonUtility.GetHotComponents(adapters, ilType.ILType));
                int n = ilInstances.Length;
                res = Array.CreateInstance(ilType.ILType.TypeForCLR, n);
                for (int i = 0; i < n; i++)
                    ((Array) res).SetValue(ilInstances[i].CLRInstance, i);
            }
            else
            {
                res = UnityEngine.Object.FindObjectsByType(type, FindObjectsSortMode.None);
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }


        static unsafe StackObject* FindObjectOfType_T_0p(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);
            var tmp_GenericArgument = __method.GenericArguments;
            if (tmp_GenericArgument != null && tmp_GenericArgument.Length == 1)
            {
                var tmp_Type = tmp_GenericArgument[0];
                object tmp_Res;
                if (tmp_Type is CLRType)
                {
                    tmp_Res = Object.FindObjectOfType(tmp_Type.TypeForCLR);
                }
                else
                {
                    var tmp_Adapters = CommonUtility.GetAllMonoAdapters();
                    tmp_Res = CommonUtility.GetHotComponent(tmp_Adapters, tmp_Type as ILType);
                    // var tmp_ILInstances = CommonUtility.GetHotComponents(tmp_Adapters, tmp_Type as ILType);
                    // tmp_Res = tmp_ILInstances.Length > 0 ? tmp_ILInstances[0] : null;
                }

                return ILIntepreter.PushObject(__ret, __mStack, tmp_Res);
            }

            return __esp;
        }

        static unsafe StackObject* FindObjectOfType_T_1p(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            StackObject* ptr_of_this_method;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            bool @includeInactive = ptr_of_this_method->Value == 1;
            __intp.Free(ptr_of_this_method);

            var tmp_GenericArgument = __method.GenericArguments;
            if (tmp_GenericArgument != null && tmp_GenericArgument.Length == 1)
            {
                var tmp_Type = tmp_GenericArgument[0];
                object tmp_Res;
                if (tmp_Type is CLRType)
                {
                    tmp_Res = Object.FindObjectOfType(tmp_Type.TypeForCLR);
                }
                else
                {
                    var tmp_Adapters = CommonUtility.GetAllMonoAdapters(_findObjectsInactive: @includeInactive
                        ? FindObjectsInactive.Include
                        : FindObjectsInactive.Exclude);
                    tmp_Res = CommonUtility.GetHotComponent(tmp_Adapters, tmp_Type as ILType);
                    return ILIntepreter.PushObject(__ret, __mStack, tmp_Res);
                }

                return ILIntepreter.PushObject(__ret, __mStack, tmp_Res);
            }

            return __esp;
        }

        private unsafe StackObject* FindObjectOfType_Object_1p(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            StackObject* ptr_of_this_method;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type =
                (System.Type) typeof(System.Type).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            object res;
            if (type is UnityFusionType ilType)
            {
                var adapters = CommonUtility.GetAllMonoAdapters();
                var ilInstances = CommonUtility.GetHotComponent(adapters, ilType.ILType);
                res = ilInstances;
            }
            else
            {
                res = UnityEngine.Object.FindAnyObjectByType(type);
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        private unsafe StackObject* FindObjectOfType_Object_2p(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            StackObject* ptr_of_this_method;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Boolean @includeInacitve = ptr_of_this_method->Value == 1;
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @type =
                (System.Type) typeof(System.Type).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            object res;
            if (type is UnityFusionType ilType)
            {
                var adapters =
                    CommonUtility.GetAllMonoAdapters(_findObjectsInactive: includeInacitve
                        ? FindObjectsInactive.Include
                        : FindObjectsInactive.Exclude);
                var ilInstances = CommonUtility.GetHotComponents(adapters, ilType.ILType);
                res = ilInstances.Length > 0 ? ilInstances[0] : null;
            }
            else
            {
                res = Object.FindAnyObjectByType(type, includeInacitve
                    ? FindObjectsInactive.Include
                    : FindObjectsInactive.Exclude);
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        static unsafe StackObject* FindObjectsByType_Object_2p(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            StackObject* ptr_of_this_method;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FindObjectsSortMode @sortMode =
                (FindObjectsSortMode) typeof(FindObjectsSortMode).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @type =
                (System.Type) typeof(System.Type).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);


            object res;
            if (type is UnityFusionType ilType)
            {
                var adapters = CommonUtility.GetAllMonoAdapters(_sortMode: @sortMode);
                var ilInstances = ((ILTypeInstance[]) CommonUtility.GetHotComponents(adapters, ilType.ILType));
                int n = ilInstances.Length;
                res = Array.CreateInstance(ilType.ILType.TypeForCLR, n);
                for (int i = 0; i < n; i++)
                    ((Array) res).SetValue(ilInstances[i].CLRInstance, i);
            }
            else
            {
                res = Object.FindObjectsByType(@type, @sortMode);
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        static unsafe StackObject* FindObjectsByType_Object_3p(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            StackObject* ptr_of_this_method;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FindObjectsSortMode @sortMode =
                (FindObjectsSortMode) typeof(FindObjectsSortMode).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FindObjectsInactive @findObjectsInactive =
                (FindObjectsInactive) typeof(FindObjectsInactive).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Type @type =
                (System.Type) typeof(System.Type).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);


            object res;
            if (type is UnityFusionType ilType)
            {
                var adapters =
                    CommonUtility.GetAllMonoAdapters(_sortMode: @sortMode, _findObjectsInactive: @findObjectsInactive);
                var ilInstances = ((ILTypeInstance[]) CommonUtility.GetHotComponents(adapters, ilType.ILType));
                int n = ilInstances.Length;
                res = Array.CreateInstance(ilType.ILType.TypeForCLR, n);
                for (int i = 0; i < n; i++)
                    ((Array) res).SetValue(ilInstances[i].CLRInstance, i);
            }
            else
            {
                res = Object.FindObjectsByType(@type, @findObjectsInactive, @sortMode);
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        static unsafe StackObject* FindObjectsByType_T_1p(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            StackObject* ptr_of_this_method;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FindObjectsSortMode @findObjectsSortMode =
                (FindObjectsSortMode) typeof(FindObjectsSortMode).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            var genericArgument = __method.GenericArguments;

            if (genericArgument != null && genericArgument.Length == 1)
            {
                var type = genericArgument[0];
                object res;
                if (type is CLRType)
                {
                    res = UnityEngine.Object.FindObjectsByType(type.TypeForCLR, @findObjectsSortMode);
                }
                else
                {
                    var adapters = CommonUtility.GetAllMonoAdapters(_sortMode: @findObjectsSortMode);
                    var ilInstances = CommonUtility.GetHotComponents(adapters, type as ILType);
                    int length = ilInstances.Length;
                    res = Array.CreateInstance(type.TypeForCLR, length);
                    for (int idx = 0; idx < length; idx++)
                    {
                        ((Array) res).SetValue(ilInstances[idx].CLRInstance, idx);
                    }
                }

                return ILIntepreter.PushObject(__ret, __mStack, res);
            }

            return __esp;
        }

        static unsafe StackObject* FindObjectsByType_T_2p(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            StackObject* ptr_of_this_method;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FindObjectsInactive @findObjectsInactive =
                (FindObjectsInactive) typeof(FindObjectsInactive).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FindObjectsSortMode @findObjectsSortMode =
                (FindObjectsSortMode) typeof(FindObjectsSortMode).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            var genericArgument = __method.GenericArguments;

            if (genericArgument != null && genericArgument.Length == 1)
            {
                var type = genericArgument[0];
                object res;
                if (type is CLRType)
                {
                    res = UnityEngine.Object.FindObjectsByType(type.TypeForCLR, @findObjectsInactive,
                        @findObjectsSortMode);
                }
                else
                {
                    var adapters = CommonUtility.GetAllMonoAdapters(_sortMode: @findObjectsSortMode,
                        _findObjectsInactive: @findObjectsInactive);
                    var ilInstances = CommonUtility.GetHotComponents(adapters, type as ILType);
                    int length = ilInstances.Length;
                    res = Array.CreateInstance(type.TypeForCLR, length);
                    for (int idx = 0; idx < length; idx++)
                    {
                        ((Array) res).SetValue(ilInstances[idx].CLRInstance, idx);
                    }
                }

                return ILIntepreter.PushObject(__ret, __mStack, res);
            }

            return __esp;
        }

        static unsafe StackObject* FindAnyObjectByType_T_0p(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var genericArgument = __method.GenericArguments;

            if (genericArgument != null && genericArgument.Length == 1)
            {
                var type = genericArgument[0];
                object res;

                if (type is CLRType)
                {
                    res = Object.FindAnyObjectByType(type.TypeForCLR);
                }
                else
                {
                    var adapters = CommonUtility.GetAllMonoAdapters();
                    var ilInstances = ((ILTypeInstance[]) CommonUtility.GetHotComponents(adapters, type as ILType));
                    res = ilInstances.Length > 0 ? ilInstances[0] : null;
                }

                return ILIntepreter.PushObject(__ret, __mStack, res);
            }

            return __esp;
        }

        static unsafe StackObject* FindAnyObjectByType_T_1p(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            var ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FindObjectsInactive @findObjectsInactive =
                (FindObjectsInactive) typeof(FindObjectsInactive).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            var genericArgument = __method.GenericArguments;

            if (genericArgument != null && genericArgument.Length == 1)
            {
                var type = genericArgument[0];
                object res;

                if (type is CLRType)
                {
                    res = Object.FindAnyObjectByType(type.TypeForCLR, @findObjectsInactive);
                }
                else
                {
                    var tmp_Adapters = CommonUtility.GetAllMonoAdapters(_findObjectsInactive: @findObjectsInactive) ??
                                       throw new ArgumentNullException(
                                           "CommonUtility.GetAllMonoAdapters(_findObjectsInactive: @findObjectsInactive)");
                    var tmp_ILInstances = CommonUtility.GetHotComponents(tmp_Adapters, type as ILType);
                    res = tmp_ILInstances.Length > 0 ? tmp_ILInstances[0] : null;
                }

                return ILIntepreter.PushObject(__ret, __mStack, res);
            }

            return __esp;
        }

        static unsafe StackObject* FindAnyObjectByType_Object_1p(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            StackObject* ptr_of_this_method;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type =
                (System.Type) typeof(System.Type).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            object res;
            if (type is UnityFusionType ilType)
            {
                var adapters = CommonUtility.GetAllMonoAdapters();
                var ilInstances = ((ILTypeInstance[]) CommonUtility.GetHotComponents(adapters, ilType.ILType));
                res = ilInstances.Length > 0 ? ilInstances[0] : null;
            }
            else
            {
                res = UnityEngine.Object.FindAnyObjectByType(type);
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        static unsafe StackObject* FindAnyObjectByType_Object_2p(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            StackObject* ptr_of_this_method;


            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FindObjectsInactive @findObjectsInactive =
                (FindObjectsInactive) typeof(FindObjectsInactive).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @type =
                (System.Type) typeof(System.Type).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);


            object res;
            if (type is UnityFusionType ilType)
            {
                var adapters = CommonUtility.GetAllMonoAdapters(_findObjectsInactive: @findObjectsInactive);
                var ilInstances = ((ILTypeInstance[]) CommonUtility.GetHotComponents(adapters, ilType.ILType));
                res = ilInstances.Length > 0 ? ilInstances[0] : null;
            }
            else
            {
                res = UnityEngine.Object.FindAnyObjectByType(type, @findObjectsInactive);
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        static unsafe StackObject* FindFirstObjectByType_Object_1p(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            StackObject* ptr_of_this_method;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            object res;
            if (type is UnityFusionType ilType)
            {
                var adapters = CommonUtility.GetAllMonoAdapters();
                var ilInstances = ((ILTypeInstance[]) CommonUtility.GetHotComponents(adapters, ilType.ILType));
                res = ilInstances.Length > 0 ? ilInstances[0] : null;
            }
            else
            {
                res = UnityEngine.Object.FindFirstObjectByType(type);
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        static unsafe StackObject* FindFirstObjectByType_Object_2p(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            StackObject* ptr_of_this_method;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FindObjectsInactive @findObjectsInactive =
                (FindObjectsInactive) typeof(FindObjectsInactive).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @type =
                (System.Type) typeof(System.Type).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            object res;
            if (type is UnityFusionType ilType)
            {
                var adapters = CommonUtility.GetAllMonoAdapters(_findObjectsInactive: @findObjectsInactive);
                var ilInstances = CommonUtility.GetHotComponents(adapters, ilType.ILType);
                res = ilInstances.Length > 0 ? ilInstances[0] : null;
            }
            else
            {
                res = UnityEngine.Object.FindFirstObjectByType(type, @findObjectsInactive);
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        static unsafe StackObject* FindFirstObjectByType_T_0p(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var genericArgument = __method.GenericArguments;

            if (genericArgument != null && genericArgument.Length == 1)
            {
                var type = genericArgument[0];
                object res;

                if (type is CLRType)
                {
                    res = Object.FindFirstObjectByType(type.TypeForCLR);
                }
                else
                {
                    var adapters = CommonUtility.GetAllMonoAdapters();
                    var ilInstances = ((ILTypeInstance[]) CommonUtility.GetHotComponents(adapters, type as ILType));
                    res = ilInstances.Length > 0 ? ilInstances[0] : null;
                }

                return ILIntepreter.PushObject(__ret, __mStack, res);
            }

            return __esp;
        }

        static unsafe StackObject* FindFirstObjectByType_T_1p(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            var ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FindObjectsInactive @findObjectsInactive =
                (FindObjectsInactive) typeof(FindObjectsInactive).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            var genericArgument = __method.GenericArguments;

            if (genericArgument != null && genericArgument.Length == 1)
            {
                var type = genericArgument[0];
                object res;

                if (type is CLRType)
                {
                    res = Object.FindAnyObjectByType(type.TypeForCLR, @findObjectsInactive);
                }
                else
                {
                    var adapters =
                        CommonUtility.GetAllMonoAdapters(_findObjectsInactive: @findObjectsInactive);
                    var ilInstances = ((ILTypeInstance[]) CommonUtility.GetHotComponents(adapters, type as ILType));
                    res = ilInstances.Length > 0 ? ilInstances[0] : null;
                }

                return ILIntepreter.PushObject(__ret, __mStack, res);
            }

            return __esp;
        }
    }
}