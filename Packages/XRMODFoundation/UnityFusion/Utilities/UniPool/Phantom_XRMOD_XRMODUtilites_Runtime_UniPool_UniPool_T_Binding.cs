// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODUtilites.UnityFusion.
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
using System.Runtime.InteropServices;
using Phantom.XRMOD.XRMODUtilites.Runtime.UniPool;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityFusion.Reflection;
using UnityFusion.CLR.Utils;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace UnityFusion.Runtime.Generated
{
    unsafe class Phantom_XRMOD_XRMODUtilites_Runtime_UniPool_UniPool_T_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool);
            Dictionary<string, List<MethodInfo>> genericMethods = new Dictionary<string, List<MethodInfo>>();
            List<MethodInfo> lst = null;
            foreach (var m in type.GetMethods())
            {
                if (m.IsGenericMethodDefinition)
                {
                    if (!genericMethods.TryGetValue(m.Name, out lst))
                    {
                        lst = new List<MethodInfo>();
                        genericMethods[m.Name] = lst;
                    }

                    lst.Add(m);
                }
            }

            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.MonoBehaviourAdapter.Adapter)};
            if (genericMethods.TryGetValue("Register", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(System.Boolean), typeof(UnityEngine.GameObject),
                            typeof(UnityEngine.Transform), typeof(System.Boolean)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, Register_T_0);

                        break;
                    }

                    if (m.MatchGenericParameters(args, typeof(System.Boolean), typeof(UnityEngine.GameObject),
                            typeof(string), typeof(UnityEngine.Transform), typeof(System.Boolean)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, Register_T_1);

                        break;
                    }
                }
            }

            if (genericMethods.TryGetValue("Get", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell),
                            typeof(UnityEngine.GameObject), typeof(System.Boolean)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, Get_T_0);

                        break;
                    }

                    if (m.MatchGenericParameters(args, typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell),
                            typeof(string)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, Get_T_1);

                        break;
                    }
                }
            }
        }


        static StackObject* Register_T_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UniPool.Pool.isXRMOD = true;
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_componentInChildren = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @_container = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            var tmp_GenericArguments = __method.GenericArguments;
            var tmp_ILTypeValue = tmp_GenericArguments.First();
            Type tmp_GenericType = null;
            tmp_GenericType = tmp_ILTypeValue.ReflectionType;
            bool result_of_this_method =
                Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Pool
                    .Register(@_prefab, tmp_GenericType, @_container, @_componentInChildren);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Register_T_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UniPool.Pool.isXRMOD = true;

            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_componentInChildren = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @_container = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            string @_name = (string) typeof(string).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);


            var tmp_GenericArguments = __method.GenericArguments;
            var tmp_ILTypeValue = tmp_GenericArguments.First();
            Type tmp_GenericType = null;
            tmp_GenericType = tmp_ILTypeValue.ReflectionType;
            var result_of_this_method =
                Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Pool.Register(@_prefab, tmp_GenericType, @_name,
                    @_container,
                    @_componentInChildren);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Get_T_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UniPool.Pool.isXRMOD = true;

            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_componentInChildren = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_GenericArguments = __method.GenericArguments;
            var tmp_ILTypeValue = tmp_GenericArguments.First();
            Type tmp_GenericType = null;
            tmp_GenericType = tmp_ILTypeValue.ReflectionType;
            var result_of_this_method =
                Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Pool.Get(@_prefab, tmp_GenericType,
                    @_componentInChildren);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Get_T_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UniPool.Pool.isXRMOD = true;

            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            string @_name = (string) typeof(string).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_GenericArguments = __method.GenericArguments;
            var tmp_ILTypeValue = tmp_GenericArguments.First();
            Type tmp_GenericType = null;
            tmp_GenericType = tmp_ILTypeValue.ReflectionType;
            var result_of_this_method =
                Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Pool.Get(@_name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}