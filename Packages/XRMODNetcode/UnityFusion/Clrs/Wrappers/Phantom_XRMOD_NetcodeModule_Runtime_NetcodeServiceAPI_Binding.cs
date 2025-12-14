using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_NetcodeServiceAPI_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI);
            args = new Type[] { };
            method = type.GetMethod("get_GetCurrentSession", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetCurrentSession_0);
            args = new Type[] { };
            method = type.GetMethod("get_IsServer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsServer_1);
            args = new Type[] { };
            method = type.GetMethod("get_IsClient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsClient_2);
            args = new Type[] { };
            method = type.GetMethod("get_IsHost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsHost_3);
            args = new Type[] { };
            method = type.GetMethod("get_GetNetworkManager", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetNetworkManager_4);
            args = new Type[] { };
            method = type.GetMethod("get_GetInstance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetInstance_5);
            args = new Type[]
            {
                typeof(UnityEngine.GameObject), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion),
                typeof(UnityEngine.Transform), typeof(System.Boolean), typeof(System.Action<UnityEngine.GameObject>)
            };
            method = type.GetMethod("SpawnNetworkGameObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SpawnNetworkGameObject_6);
            args = new Type[]
            {
                typeof(System.UInt64), typeof(UnityEngine.GameObject), typeof(UnityEngine.Vector3),
                typeof(UnityEngine.Quaternion), typeof(UnityEngine.Transform), typeof(System.Boolean),
                typeof(System.Action<UnityEngine.GameObject>)
            };
            method = type.GetMethod("SpawnPlayerGameObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SpawnPlayerGameObject_7);
            args = new Type[] {typeof(UnityEngine.GameObject)};
            method = type.GetMethod("DespawnNetworkGameObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DespawnNetworkGameObject_8);
            args = new Type[] {typeof(UnityEngine.GameObject)};
            method = type.GetMethod("RegisterPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterPrefab_9);
            args = new Type[] {typeof(UnityEngine.GameObject)};
            method = type.GetMethod("UnRegisterPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnRegisterPrefab_10);
            args = new Type[] {typeof(System.String), typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)};
            method = type.GetMethod("CreateOrJoinSession", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateOrJoinSession_11);
            args = new Type[] {typeof(System.String), typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)};
            method = type.GetMethod("JoinRandomSession", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, JoinRandomSession_12);
            args = new Type[] { };
            method = type.GetMethod("DisconnectSession", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DisconnectSession_13);


            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI[s]);
        }


        static StackObject* get_GetCurrentSession_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCurrentSession;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_IsServer_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsServer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsClient_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsClient;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsHost_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsHost;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_GetNetworkManager_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetNetworkManager;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_GetInstance_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI.GetInstance;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SpawnNetworkGameObject_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.GameObject> @_onBeforeSpawned =
                (System.Action<UnityEngine.GameObject>) typeof(System.Action<UnityEngine.GameObject>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @_destroyWithScene = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Transform @_parent = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Quaternion @_rotation = (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector3 @_position = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.GameObject @_networkPrefab =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SpawnNetworkGameObject(@_networkPrefab, @_position,
                @_rotation, @_parent, @_destroyWithScene, @_onBeforeSpawned);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SpawnPlayerGameObject_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.GameObject> @_onBeforeSpawned =
                (System.Action<UnityEngine.GameObject>) typeof(System.Action<UnityEngine.GameObject>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @_destroyWithScene = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Transform @_parent = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Quaternion @_rotation = (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector3 @_position = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.GameObject @_playerPrefab =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.UInt64 @_clientId = *(ulong*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SpawnPlayerGameObject(@_clientId, @_playerPrefab,
                @_position, @_rotation, @_parent, @_destroyWithScene, @_onBeforeSpawned);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DespawnNetworkGameObject_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @_networkGameObject =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DespawnNetworkGameObject(@_networkGameObject);

            return __ret;
        }

        static StackObject* RegisterPrefab_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @_networkPrefab =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterPrefab(@_networkPrefab);

            return __ret;
        }

        static StackObject* UnRegisterPrefab_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @_networkPrefab =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UnRegisterPrefab(@_networkPrefab);

            return __ret;
        }

        static StackObject* CreateOrJoinSession_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig @_baseSessionConfig =
                (Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_gameName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateOrJoinSession(@_gameName, @_baseSessionConfig);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* JoinRandomSession_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig @_baseSessionConfig =
                (Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_gameName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.JoinRandomSession(@_gameName, @_baseSessionConfig);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DisconnectSession_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeServiceAPI).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DisconnectSession();

            return __ret;
        }
    }
}