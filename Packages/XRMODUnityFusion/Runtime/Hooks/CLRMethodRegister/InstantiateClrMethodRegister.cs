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
using System.Threading;
using System.Threading.Tasks;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime;
using UnityFusion.CLR.Method;
using UnityFusion.CLR.Utils;
using UnityFusion.Runtime;
using UnityFusion.Runtime.Generated;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityEngine;
using UnityEngine.Assertions;
using UnityFusion.Runtime.Enviorment;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;
using Extensions = UnityFusion.CLR.Utils.Extensions;
using Object = UnityEngine.Object;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public class InstantiateClrMethodRegister : AbstractRegister
    {
        public override unsafe void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);
            Type[] tmp_Args = null;

            var tmp_ObjectType = typeof(UnityEngine.Object);
            MethodInfo tmp_InstantiateMethod;
            var tmp_AllInstantiateMethods = tmp_ObjectType.GetMethods().ToList()
                .FindAll(_methodInfo => _methodInfo.Name == "Instantiate");

            tmp_Args = new[] {typeof(GameObject)};
            foreach (var tmp_MethodInfo in tmp_AllInstantiateMethods)
            {
                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(GameObject), typeof(GameObject)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, Instantiate_7);
                }
                else if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(GameObject), typeof(GameObject),
                             typeof(Transform)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, Instantiate_8);
                }
                else if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(GameObject), typeof(GameObject),
                             typeof(Transform), typeof(System.Boolean)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, Instantiate_9);
                }
                else if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(GameObject), typeof(GameObject),
                             typeof(Vector3), typeof(Quaternion)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, Instantiate_10);
                }
                else if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(GameObject), typeof(GameObject),
                             typeof(Vector3), typeof(Quaternion), typeof(Transform)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, Instantiate_11);
                }
            }

            foreach (var tmp_MethodInfo in tmp_AllInstantiateMethods)
            {
                var tmp_AllParams = tmp_MethodInfo.GetParameters();
                switch (tmp_AllParams.Length)
                {
                    case 1:
                        _appDomain.RegisterCLRMethodRedirection(tmp_MethodInfo, Instantiate_12);
                        break;
                    case 2:
                        _appDomain.RegisterCLRMethodRedirection(tmp_MethodInfo, Instantiate_13);
                        break;
                    case 3 when tmp_AllParams[1].ParameterType == typeof(Transform) &&
                                tmp_AllParams[2].ParameterType == typeof(Boolean):
                        _appDomain.RegisterCLRMethodRedirection(tmp_MethodInfo, Instantiate_14);
                        break;
                    case 3 when tmp_AllParams[1].ParameterType == typeof(Vector3) &&
                                tmp_AllParams[2].ParameterType == typeof(Quaternion):
                        _appDomain.RegisterCLRMethodRedirection(tmp_MethodInfo, Instantiate_15);
                        break;
                    case 4 when tmp_AllParams[1].ParameterType == typeof(Vector3) &&
                                tmp_AllParams[2].ParameterType == typeof(Quaternion) &&
                                tmp_AllParams[3].ParameterType == typeof(Transform):
                        _appDomain.RegisterCLRMethodRedirection(tmp_MethodInfo, Instantiate_16);
                        break;
                    default:
                        _appDomain.RegisterCLRMethodRedirection(tmp_MethodInfo, Instantiate_17);
                        break;
                }
            }


            var tmp_AllInstantiateAsyncMethods =
                tmp_ObjectType.GetMethods().ToList().FindAll(_methodInfo => _methodInfo.Name == "InstantiateAsync");

            foreach (MethodInfo tmp_MethodInfo in tmp_AllInstantiateAsyncMethods)
            {
                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(AsyncInstantiateOperation<GameObject>),
                        typeof(GameObject)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, InstantiateAsync_01);
                }

#if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34 || UNITY_6000_1_OR_NEWER)
                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(AsyncInstantiateOperation<GameObject>),
                        typeof(GameObject),
                        typeof(InstantiateParameters), typeof(CancellationToken)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, InstantiateAsync_02);
                }
#endif


                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(AsyncInstantiateOperation<GameObject>),
                        typeof(GameObject),
                        typeof(Transform)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, InstantiateAsync_03);
                }


                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(AsyncInstantiateOperation<GameObject>),
                        typeof(GameObject),
                        typeof(Vector3), typeof(Quaternion)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, InstantiateAsync_04);
                }

#if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34 || UNITY_6000_1_OR_NEWER)
                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(AsyncInstantiateOperation<GameObject>),
                        typeof(GameObject),
                        typeof(Vector3), typeof(Quaternion), typeof(InstantiateParameters), typeof(CancellationToken)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, InstantiateAsync_05);
                }
#endif

                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(AsyncInstantiateOperation<GameObject>),
                        typeof(GameObject),
                        typeof(Transform), typeof(Vector3), typeof(Quaternion)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, InstantiateAsync_06);
                }


                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(AsyncInstantiateOperation<GameObject>),
                        typeof(GameObject),
                        typeof(int)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, InstantiateAsync_07);
                }
#if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34 || UNITY_6000_1_OR_NEWER)
                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(AsyncInstantiateOperation<GameObject>),
                        typeof(GameObject),
                        typeof(int), typeof(InstantiateParameters), typeof(CancellationToken)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, InstantiateAsync_08);
                }
#endif


                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(AsyncInstantiateOperation<GameObject>),
                        typeof(GameObject),
                        typeof(int), typeof(Transform)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, InstantiateAsync_09);
                }


                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(AsyncInstantiateOperation<GameObject>),
                        typeof(GameObject),
                        typeof(int), typeof(Vector3), typeof(Quaternion)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, InstantiateAsync_10);
                }

#if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34 || UNITY_6000_1_OR_NEWER)
                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(AsyncInstantiateOperation<GameObject>),
                        typeof(GameObject),
                        typeof(int), typeof(Vector3), typeof(Quaternion), typeof(InstantiateParameters),
                        typeof(CancellationToken)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, InstantiateAsync_11);
                }
#endif


                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(AsyncInstantiateOperation<GameObject>),
                        typeof(GameObject),
                        typeof(int), typeof(Transform), typeof(Vector3), typeof(Quaternion)))
                {
                    tmp_InstantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(tmp_InstantiateMethod, InstantiateAsync_12);
                }
            }
        }

        #region InstantiateAsync

        private unsafe StackObject* InstantiateAsync_01(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            GameObject @_original = (GameObject) typeof(GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            Utility.CheckoutIlTypeInstance(@_original, out var tmp_Go, out _);
            return InstantiateAsync(tmp_Go, __mStack, __ret);
        }

#if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34 || UNITY_6000_1_OR_NEWER)
        private unsafe StackObject* InstantiateAsync_02(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            CancellationToken @_cancellationToken = (CancellationToken) typeof(CancellationToken).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            InstantiateParameters @_InstantiateParameters =
                (InstantiateParameters) typeof(InstantiateParameters).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            GameObject @_original = (GameObject) typeof(GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            Utility.CheckoutIlTypeInstance(@_original, out var tmp_Go, out _);
            return InstantiateAsync(tmp_Go, __mStack, __ret, _InstantiateParameters, _cancellationToken);
        }
#endif

        private unsafe StackObject* InstantiateAsync_03(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Transform @_Parent =
                (Transform) typeof(Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            GameObject @_original = (GameObject) typeof(GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            Utility.CheckoutIlTypeInstance(@_original, out var tmp_Go, out _);
            return InstantiateAsync(tmp_Go, __mStack, __ret, @_Parent);
        }

        private unsafe StackObject* InstantiateAsync_04(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Quaternion @_Rotation = (Quaternion) typeof(Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Vector3 @_Position =
                (Vector3) typeof(Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            GameObject @_original = (GameObject) typeof(GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            Utility.CheckoutIlTypeInstance(@_original, out var tmp_Go, out _);
            return InstantiateAsync(tmp_Go, __mStack, __ret, @_Position, @_Rotation);
        }

#if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34 || UNITY_6000_1_OR_NEWER)
        private unsafe StackObject* InstantiateAsync_05(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            CancellationToken @_CancellationToken = (CancellationToken) typeof(CancellationToken).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            InstantiateParameters @_InstantiateParameters =
                (InstantiateParameters) typeof(InstantiateParameters).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Quaternion @_Rotation = (Quaternion) typeof(Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Vector3 @_Position = (Vector3) typeof(Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            GameObject @_original = (GameObject) typeof(Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            Utility.CheckoutIlTypeInstance(@_original, out var tmp_Go, out _);
            return InstantiateAsync(tmp_Go, __mStack, __ret, _Position, _Rotation, _InstantiateParameters,
                _CancellationToken);
        }

#endif
        private unsafe StackObject* InstantiateAsync_06(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Quaternion @_Rotation = (Quaternion) typeof(Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Vector3 @_Position =
                (Vector3) typeof(Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Transform @_Transform = (Transform) typeof(Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            GameObject @_original = (GameObject) typeof(GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            Utility.CheckoutIlTypeInstance(@_original, out var tmp_Go, out _);
            return InstantiateAsync(tmp_Go, __mStack, __ret, @_Transform, @_Position, @_Rotation);
        }


        private unsafe StackObject* InstantiateAsync_07(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            int @_Count = (int) typeof(int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            GameObject @_original = (GameObject) typeof(GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            Utility.CheckoutIlTypeInstance(@_original, out var tmp_Go, out _);
            return InstantiateAsync(tmp_Go, __mStack, __ret, @_Count);
        }

#if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34 || UNITY_6000_1_OR_NEWER)
        private unsafe StackObject* InstantiateAsync_08(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            CancellationToken @_CancellationToken = (CancellationToken) typeof(CancellationToken).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            InstantiateParameters @_InstantiateParameters =
                (InstantiateParameters) typeof(InstantiateParameters).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            int @_Count = (int) typeof(int).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            GameObject @_original = (GameObject) typeof(GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            Utility.CheckoutIlTypeInstance(@_original, out var tmp_Go, out _);
            return InstantiateAsync(tmp_Go, __mStack, __ret, @_InstantiateParameters, @_CancellationToken, @_Count);
        }
#endif


        private unsafe StackObject* InstantiateAsync_09(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Transform @_Transform =
                (Transform) typeof(Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            int @_Count = (int) typeof(int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            GameObject @_original = (GameObject) typeof(GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            Utility.CheckoutIlTypeInstance(@_original, out var tmp_Go, out _);
            return InstantiateAsync(tmp_Go, __mStack, __ret, @_Transform, @_Count);
        }


        private unsafe StackObject* InstantiateAsync_10(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Quaternion @_Rotation =
                (Quaternion) typeof(Quaternion).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Vector3 @_Position = (Vector3) typeof(Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            int @_Count = (int) typeof(int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            GameObject @_original = (GameObject) typeof(GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            Utility.CheckoutIlTypeInstance(@_original, out var tmp_Go, out _);
            return InstantiateAsync(tmp_Go, __mStack, __ret, @_Position, @_Rotation, @_Count);
        }

#if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34 || UNITY_6000_1_OR_NEWER)
        private unsafe StackObject* InstantiateAsync_11(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            CancellationToken @_CancellationToken =
                (CancellationToken) typeof(CancellationToken).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            InstantiateParameters @_InstantiateParameters =
                (InstantiateParameters) typeof(InstantiateParameters).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Quaternion @_Rotation =
                (Quaternion) typeof(Quaternion).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Vector3 @_Position = (Vector3) typeof(Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            int @_Count = (int) typeof(int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            GameObject @_original = (GameObject) typeof(GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            Utility.CheckoutIlTypeInstance(@_original, out var tmp_Go, out _);
            return InstantiateAsync(tmp_Go, __mStack, __ret, @_Position, @_Rotation, @_InstantiateParameters,
                @_CancellationToken, @_Count);
        }
#endif

        private unsafe StackObject* InstantiateAsync_12(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Quaternion @_Rotation =
                (Quaternion) typeof(Quaternion).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Vector3 @_Position = (Vector3) typeof(Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Transform @_Parent = (Transform) typeof(Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            int @_Count = (int) typeof(int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            GameObject @_original = (GameObject) typeof(GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            Utility.CheckoutIlTypeInstance(@_original, out var tmp_Go, out _);
            return InstantiateAsync(tmp_Go, __mStack, __ret, @_Position, @_Rotation, @_Parent, @_Count);
        }


        private unsafe StackObject* InstantiateAsync<T>(T _object, AutoList __mStack, StackObject* __ret,
            int _count = -1)
            where T : UnityEngine.Object
        {
            var tmp_ResultOfThisMethod =
                _count == -1
                    ? Object.InstantiateAsync(_object)
                    : Object.InstantiateAsync(_object, _count);

            object tmp_ObjResultOfThisMethod = tmp_ResultOfThisMethod;

            if (tmp_ObjResultOfThisMethod is CrossBindingAdaptorType tmp_AdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack, tmp_AdaptorType.ILInstance);
            }

            var tmp_Result = ILIntepreter.PushObject(__ret, __mStack, tmp_ObjResultOfThisMethod);

            Utility.ProcessMonoBinder(tmp_ResultOfThisMethod);


            return tmp_Result;
        }

        private unsafe StackObject* InstantiateAsync<T>(T _object, AutoList __mStack, StackObject* __ret,
            Transform _parent, int _count = -1)
            where T : UnityEngine.Object
        {
            var tmp_ResultOfThisMethod = _count == -1
                ? Object.InstantiateAsync(_object, _parent)
                : Object.InstantiateAsync(_object, _count, _parent);

            object tmp_ObjResultOfThisMethod = tmp_ResultOfThisMethod;
            if (tmp_ObjResultOfThisMethod is CrossBindingAdaptorType tmp_AdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack, tmp_AdaptorType.ILInstance);
            }

            var tmp_Result = ILIntepreter.PushObject(__ret, __mStack, tmp_ObjResultOfThisMethod);

            Utility.ProcessMonoBinder(tmp_ResultOfThisMethod);


            return tmp_Result;
        }

        private unsafe StackObject* InstantiateAsync<T>(T _object, AutoList __mStack, StackObject* __ret,
            Transform _parent, Vector3 _position, Quaternion _rotation, int _count = -1)
            where T : UnityEngine.Object
        {
            var tmp_ResultOfThisMethod = _count == -1
                ? Object.InstantiateAsync(_object, _parent, _position, _rotation)
                : Object.InstantiateAsync(_object, _count, _parent, _position, _rotation);

            object tmp_ObjResultOfThisMethod = tmp_ResultOfThisMethod;

            if (tmp_ObjResultOfThisMethod is CrossBindingAdaptorType tmp_AdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack, tmp_AdaptorType.ILInstance);
            }

            var tmp_Result = ILIntepreter.PushObject(__ret, __mStack, tmp_ObjResultOfThisMethod);

            Utility.ProcessMonoBinder(tmp_ResultOfThisMethod);

            return tmp_Result;
        }

        private unsafe StackObject* InstantiateAsync<T>(T _object, AutoList __mStack, StackObject* __ret,
            Vector3 _position, Quaternion _rotation, int _count = -1)
            where T : UnityEngine.Object
        {
            var tmp_ResultOfThisMethod = _count == -1
                ? Object.InstantiateAsync(_object, _position, _rotation)
                : Object.InstantiateAsync(_object, _count, _position, _rotation);

            object tmp_ObjResultOfThisMethod = tmp_ResultOfThisMethod;

            if (tmp_ObjResultOfThisMethod is CrossBindingAdaptorType tmp_AdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack, tmp_AdaptorType.ILInstance);
            }

            var tmp_Result = ILIntepreter.PushObject(__ret, __mStack, tmp_ObjResultOfThisMethod);

            Utility.ProcessMonoBinder(tmp_ResultOfThisMethod);


            return tmp_Result;
        }
#if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34 || UNITY_6000_1_OR_NEWER)
        private unsafe StackObject* InstantiateAsync<T>(T _object, AutoList __mStack, StackObject* __ret,
            InstantiateParameters _parameters, CancellationToken _cancellationToken, int _count = -1)
            where T : UnityEngine.Object
        {
            var tmp_ResultOfThisMethod = _count == -1
                ? Object.InstantiateAsync(_object, _parameters, _cancellationToken)
                : Object.InstantiateAsync(_object, _count, _parameters, _cancellationToken);

            object tmp_ObjResultOfThisMethod = tmp_ResultOfThisMethod;

            if (tmp_ObjResultOfThisMethod is CrossBindingAdaptorType tmp_AdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack, tmp_AdaptorType.ILInstance);
            }

            var tmp_Result = ILIntepreter.PushObject(__ret, __mStack, tmp_ObjResultOfThisMethod);


            Utility.ProcessMonoBinder(tmp_ResultOfThisMethod);

            return tmp_Result;
        }
#endif
        private unsafe StackObject* InstantiateAsync<T>(T _object, AutoList __mStack, StackObject* __ret,
            Vector3 _position, Quaternion _rotation, Transform _parent, int _count = -1)
            where T : UnityEngine.Object
        {
            var tmp_ResultOfThisMethod = _count == -1
                ? Object.InstantiateAsync(_object, _parent, _position, _rotation)
                : Object.InstantiateAsync(_object, _count, _parent, _position, _rotation);

            object tmp_ObjResultOfThisMethod = tmp_ResultOfThisMethod;

            if (tmp_ObjResultOfThisMethod is CrossBindingAdaptorType tmp_AdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack, tmp_AdaptorType.ILInstance);
            }


            Utility.ProcessMonoBinder(tmp_ResultOfThisMethod);
            var tmp_Result = ILIntepreter.PushObject(__ret, __mStack, tmp_ObjResultOfThisMethod);
            return tmp_Result;
        }


#if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34 || UNITY_6000_1_OR_NEWER)
        private unsafe StackObject* InstantiateAsync<T>(T _object, AutoList __mStack, StackObject* __ret,
            Vector3 _position, Quaternion _rotation, InstantiateParameters _parameters,
            CancellationToken _cancellationToken, int _count = -1)
            where T : UnityEngine.Object
        {
            var tmp_ResultOfThisMethod = _count == -1
                ? Object.InstantiateAsync(_object, _position, _rotation, _parameters, _cancellationToken)
                : Object.InstantiateAsync(_object, _count, _position, _rotation, _parameters, _cancellationToken);

            object tmp_ObjResultOfThisMethod = tmp_ResultOfThisMethod;

            var tmp_Result = ILIntepreter.PushObject(__ret, __mStack, tmp_ObjResultOfThisMethod);

            Utility.ProcessMonoBinder(tmp_ResultOfThisMethod);

            return tmp_Result;
        }
#endif

        #endregion

        #region Instantiate

        private unsafe StackObject* InstanceMethod_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool __isnewobj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Object @_NeedToInstanceObject =
                (Object) typeof(Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var tmp_GenericArgument = __method.GenericArguments;

            if (tmp_GenericArgument == null || tmp_GenericArgument.Length != 1) return __esp;
            var tmp_Type = tmp_GenericArgument[0];
            if (tmp_Type.TypeForCLR == typeof(Material))
            {
                var tmp_InstancedMat = Object.Instantiate(_NeedToInstanceObject) as Material;
                return ILIntepreter.PushObject(__ret, __mStack, tmp_InstancedMat);
            }

            if (tmp_Type.TypeForCLR == typeof(GameObject))
            {
                Utility.CheckoutIlTypeInstance(_NeedToInstanceObject, out var go, out var type);
                var result_of_this_method = UnityEngine.Object.Instantiate(go);
                object res = Utility.DoBinding(go, result_of_this_method, __domain, type);
                if (type == null && res is GameObject && res.GetType() != _NeedToInstanceObject.GetType())
                {
                    res = ((GameObject) res).GetComponent(_NeedToInstanceObject.GetType());
                }

                IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

                return ILIntepreter.PushObject(__ret, __mStack, res);
            }

            return ILIntepreter.PushObject(__ret, __mStack, null);
        }

        private object InstantiateForMainProject(BaseNotificationData _arg)
        {
            if (_arg is not InstantiateArgs tmp_Data) return null;
            if (appDomain == null)
            {
                Assert.IsNotNull(tmp_Data.Prefab);
                return Object.Instantiate(tmp_Data.Prefab);
            }
            else
            {
                Utility.CheckoutIlTypeInstance(tmp_Data.Prefab, out var tmp_Go, out var tmp_Type);
                var tmp_ResultOfThisMethod = UnityEngine.Object.Instantiate(tmp_Go);
                var tmp_Res = Utility.DoBinding(tmp_Go, tmp_ResultOfThisMethod, appDomain, tmp_Type);

                if (tmp_Type == null && tmp_Res is GameObject tmp_GameObject
                                     && tmp_GameObject.GetType() != tmp_Data.Prefab.GetType())
                {
                    return tmp_GameObject.GetComponent(tmp_Data.Prefab.GetType());
                }

                return tmp_Res;
            }
        }

        private unsafe StackObject* Instantiate_7(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            GameObject @_original = (GameObject) typeof(GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            Utility.CheckoutIlTypeInstance(@_original, out _, out var tmp_Type);
            var result_of_this_method = Object.Instantiate(@_original);
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack,
                Utility.DoBinding(@_original, result_of_this_method, __domain));
        }

        private unsafe StackObject* Instantiate_8(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @parent =
                (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(@original, @parent);
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack,
                Utility.DoBinding(original, result_of_this_method, __domain));
        }

        private unsafe StackObject* Instantiate_9(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @worldPositionStays = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @parent =
                (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Object.Instantiate<UnityEngine.GameObject>(@original, @parent, @worldPositionStays);
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack,
                Utility.DoBinding(original, result_of_this_method, __domain));
        }

        private unsafe StackObject* Instantiate_10(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation =
                (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @position =
                (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Object.Instantiate<UnityEngine.GameObject>(@original, @position, @rotation);
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack,
                Utility.DoBinding(original, result_of_this_method, __domain));
        }

        private unsafe StackObject* Instantiate_11(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @parent =
                (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @rotation =
                (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @position =
                (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Object.Instantiate<UnityEngine.GameObject>(@original, @position, @rotation, @parent);
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack,
                Utility.DoBinding(original, result_of_this_method, __domain));
        }

        private unsafe StackObject* Instantiate_12(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            object @original = StackObject.ToObject(ptr_of_this_method, __domain, __mStack);
            __intp.Free(ptr_of_this_method);

            var tmp_GenericArgument = __method.GenericArguments;

            if (tmp_GenericArgument == null || tmp_GenericArgument.Length != 1) return __esp;
            var tmp_Type = tmp_GenericArgument[0];
            if (tmp_Type.TypeForCLR == typeof(Material))
            {
                if (original is Material tmp_Material)
                {
                    var tmp_InstancedMat = Object.Instantiate(tmp_Material);
                    return ILIntepreter.PushObject(__ret, __mStack, tmp_InstancedMat);
                }
            }

            Utility.CheckoutIlTypeInstance(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go);
            object res = Utility.ProcessPrefabMonoBinder(result_of_this_method);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }

            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        private unsafe StackObject* Instantiate_13(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @parent =
                (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            Utility.CheckoutIlTypeInstance(original, out var tmp_Go, out var tmp_Type);
            var result_of_this_method = UnityEngine.Object.Instantiate(tmp_Go, @parent);
            object res = Utility.ProcessPrefabMonoBinder(result_of_this_method);
            if (tmp_Type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }

            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        private unsafe StackObject* Instantiate_14(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @worldPositionStays = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @parent =
                (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            Utility.CheckoutIlTypeInstance(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go, @parent, @worldPositionStays);
            object res = Utility.ProcessPrefabMonoBinder(result_of_this_method);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }

            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        private unsafe StackObject* Instantiate_15(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation =
                (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @position =
                (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            Utility.CheckoutIlTypeInstance(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go, @position, @rotation);
            object res = Utility.ProcessPrefabMonoBinder(result_of_this_method);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }

            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        private unsafe StackObject* Instantiate_16(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @parent =
                (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @rotation =
                (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @position =
                (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            Utility.CheckoutIlTypeInstance(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go, @position, @rotation, @parent);
            object res = Utility.ProcessPrefabMonoBinder(result_of_this_method);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }

            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        private unsafe StackObject* Instantiate_17(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            throw new NotSupportedException("No support");
        }

        #endregion
    }
}